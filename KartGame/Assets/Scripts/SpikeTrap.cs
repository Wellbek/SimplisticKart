using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;

public class SpikeTrap : MonoBehaviour
{
    private float slowAmount = .7f;
    private float slowTime = 4;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<CarController>())
        {
            var kart = other.GetComponentInParent<CarController>();
            kart.SlowCar(slowAmount, slowTime);
            Destroy(this.gameObject);
        }
    }
}
