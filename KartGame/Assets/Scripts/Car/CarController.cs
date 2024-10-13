using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;

public class CarController : MonoBehaviour
{
    //public variables
    public Rigidbody rb;
    public Transform cam;

    public LayerMask whatisGround;
    public float groundRayLength = .5f;
    public Transform groundRayPoint;

    public CarEffects carEffects;

    public AudioSource engineAudio, carAudio;
    public AudioClip boostSound;

    [Header("Stats")]
    public float fwAccel;
    public float rvAccel, maxSpeed, turnStrength, gravityForce, handlingDiff = 6f;

    [Header("Model")]
    public Transform kart;
    public Transform leftFWheel;
    public Transform rightFWheel, leftBWheel, rightBWheel, steeringWheel;
    public float maxWheelTurn = 25f;

    public MeshRenderer playerMesh;

    //private variables
    private float fwSpeedInput, bwSpeedInput, turnInput;
    private bool drifting;
    private int driftDirection, tmpDriftDirection;
    private float driftControl, l_TmpDriftControl, r_TmpDriftControl;
    private float driftPower, powerControl, l_tmpPowerControl, r_tmpPowerControl;
    private float boostAmplifier = 1; //not a good name, will be renamed 
    private float slow = 1;
    private bool grounded;
    private bool falling;
    private bool lookBack;

    private int boostQueue; //how many boost are currently stacked on another

    private PlayerConfiguration playerConfig;
    //private KartInput controls;

    private void Awake()
    {

    }

    void Start()
    {
        carAudio.Stop();
        rb.transform.parent = null;
        cam.parent = null;
    }

    void Update()
    {
        //if the game hasnt begone yet the player should'nt be able to move
        if (GameController.instance.gamePlaying)
        {

            if (grounded && !drifting)
            {
                if (fwSpeedInput > bwSpeedInput)
                    transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, turnInput * turnStrength * Time.deltaTime, 0f));
                else if (bwSpeedInput > fwSpeedInput)
                    transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, -turnInput * turnStrength * Time.deltaTime, 0f));
            }

            //Drift
            if (!drifting)
            {
                driftDirection = tmpDriftDirection;
            }
            if (driftDirection == 1)
            {
                driftControl = r_TmpDriftControl;
                powerControl = r_tmpPowerControl;
            }
            else if (driftDirection == -1)
            {
                driftControl = l_TmpDriftControl;
                powerControl = l_tmpPowerControl;
            }

            if (grounded && drifting)
            {
                transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, driftControl * driftDirection * 40 * Time.deltaTime, 0f));
            }

            if (falling && drifting)
            {
                StartCoroutine(DriftBoost(1.5f, 1.5f));
            }


            //Visuals: 
            //Steering wheel and wheels rotating
            leftFWheel.localRotation = Quaternion.Euler(leftFWheel.localEulerAngles.x, turnInput * maxWheelTurn, leftFWheel.localEulerAngles.z);
            leftFWheel.localEulerAngles += new Vector3(0, 0, rb.velocity.magnitude / 3);
            rightFWheel.localRotation = Quaternion.Euler(rightFWheel.localEulerAngles.x, turnInput * maxWheelTurn, rightFWheel.localEulerAngles.z);
            rightFWheel.localEulerAngles += new Vector3(0, 0, rb.velocity.magnitude / 3);
            leftBWheel.localEulerAngles += new Vector3(0, 0, rb.velocity.magnitude / 3);
            rightBWheel.localEulerAngles += new Vector3(0, 0, rb.velocity.magnitude / 3);
            steeringWheel.localRotation = Quaternion.Euler(-25, 90, (turnInput * maxWheelTurn));

            if (drifting)
            {
                kart.localEulerAngles = Vector3.Lerp(kart.localEulerAngles, new Vector3(0, 90 + (driftDirection * driftControl * 15), kart.localEulerAngles.z), .2f);
            }
            else
                kart.localEulerAngles = Vector3.Lerp(kart.localEulerAngles, new Vector3(0, 90, 0), .2f);

            //Movement is Sphere Collider based and so kart needs to follow the collider
            transform.position = rb.transform.position;

            cam.position = this.transform.position;
            if (lookBack) cam.localRotation = Quaternion.Euler(0, transform.eulerAngles.y + 180, 0);
            else cam.localRotation = Quaternion.Euler(0, transform.eulerAngles.y, 0);



            if (boostAmplifier > 1 && cam.GetComponentInChildren<Camera>().fieldOfView < 70)
            {
                cam.GetComponentInChildren<Camera>().fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, 70, Time.deltaTime * 10);
            }
            else if (boostAmplifier == 1 && cam.GetComponentInChildren<Camera>().fieldOfView > 60)
            {
                cam.GetComponentInChildren<Camera>().fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, 60, Time.deltaTime * 10);
            }

            // sound
            engineAudio.pitch = Mathf.Abs(fwSpeedInput - bwSpeedInput) / fwAccel / 2000f * 1.5f;

        }
        else
        {
            //locking the collider in its place
            rb.transform.position = transform.position;
            
            engineAudio.pitch = 0;
        }

    }

    private void FixedUpdate()
    {
        grounded = false;
        RaycastHit hit;

        if (Physics.Raycast(groundRayPoint.position, -transform.up, out hit, groundRayLength, whatisGround))
        {
            grounded = true;

            transform.rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;
        }

        if (Physics.Raycast(groundRayPoint.position, -transform.up, out hit, groundRayLength * 2, whatisGround))
        {
            falling = false;
        }
        else falling = true;

        //if the game hasnt begone yet the player should'nt be able to move
        if (GameController.instance.gamePlaying && grounded) {
            rb.drag = handlingDiff;

            if (fwSpeedInput - bwSpeedInput != 0)
            {
                rb.AddForce(transform.forward * ((fwSpeedInput - bwSpeedInput) * boostAmplifier) * slow);
            }

            if (drifting)
            {
                driftPower += powerControl;
                if (driftPower >= 150) carEffects.boostRdy();
            }
        } else
        {
            rb.drag = 1f;

            rb.AddForce(Vector3.up * -gravityForce * 100f);
        }
    }

    public bool IsDrifting()
    {
        return drifting;
    }

    private void Drift()
    {
        if (GameController.instance.gamePlaying)
        {
            drifting = true;
            turnStrength = turnStrength * 2.5f;
            carEffects.startEmitter();
            carAudio.Play();
        }
    }

    public IEnumerator DriftBoost(float strength, float duration)
    {
        carAudio.Stop();
        drifting = false;
        carEffects.stopEmitter();
        turnStrength = turnStrength / 2.5f;
        float tmp = driftPower;
        driftPower = 0;
        if (tmp >= 150)
        {
            carAudio.PlayOneShot(boostSound);
            carEffects.Boost();
            Vector3.Lerp(kart.localEulerAngles, new Vector3(0, 90, 0), .2f);
            boostAmplifier = strength;
            boostQueue++;
            yield return new WaitForSeconds(duration);
            boostQueue--;
            if (boostQueue <= 0) boostAmplifier = 1;
        }
    }

    public void ItemBoost(float strength, float duration)
    {
        StartCoroutine(ItemBoostCoroutine(strength, duration));
    }

    private IEnumerator ItemBoostCoroutine(float strength, float duration)
    {
        carAudio.PlayOneShot(boostSound);
        carEffects.Boost();
        boostAmplifier = strength;
        boostQueue++;
        yield return new WaitForSeconds(duration);
        boostQueue--;
        if (boostQueue <= 0) boostAmplifier = 1;
    }

    public void SlowCar(float amount, float duration)
    {
        StartCoroutine(SlowCarCoroutine(amount, duration));
    }

    private IEnumerator SlowCarCoroutine(float strength, float duration)
    {
        if (slow == 1)
        {
            slow -= strength;
            yield return new WaitForSeconds(duration);
            slow += strength;
        }
    }

    public void OnAccel(float value)
    {
        fwSpeedInput = fwAccel * 2000f * value;
    }

    public void OnReverse(float value)
    {
        bwSpeedInput = rvAccel * 2000f * value;
    }

    public void OnDriftDown()
    {
        if (!drifting && turnInput != 0 && fwSpeedInput > 0)
        {
            Drift();
        }
    }

    public void OnDriftUp()
    {
        if (drifting)
        {
            StartCoroutine(DriftBoost(1.5f, 1.5f));
        }
    }

    public void OnHorizontal(float value)
    {
        turnInput = value;
        tmpDriftDirection = value > 0 ? 1 : -1;
    }

    public void OnDriftControl_Left(float value)
    {
        l_TmpDriftControl = (value + 2) / 2;
    }

    public void OnDriftControl_Right(float value)
    {
        r_TmpDriftControl = (value+2) / 2;
    }

    public void OnPowerControl_Left(float value)
    {
        l_tmpPowerControl = (value + 2) / 2;
    }

    public void OnPowerControl_Right(float value)
    {
        r_tmpPowerControl = (value + 2) / 2;
    }

    public void OnLookBack(float value)
    {
        if (value == 0) lookBack = false;
        else lookBack = true;
    }

    public void OnPauseGame()
    {
        if (!UIController.instance.pauseMenu.activeSelf && GameController.instance.gamePlaying) UIController.instance.OpenPauseMenu();
        else if (UIController.instance.pauseMenu.activeSelf) UIController.instance.ClosePauseMenu();
    }    
}
