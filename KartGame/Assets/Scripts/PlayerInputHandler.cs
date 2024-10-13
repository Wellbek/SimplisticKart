using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class PlayerInputHandler : MonoBehaviour
{
    private PlayerConfiguration playerConfig;
    private CarController carController;

    [SerializeField]
    private MeshRenderer playerMesh;

    private KartInput controls;

    private void Awake()
    {
        carController = GetComponent<CarController>();
        controls = new KartInput();
    }

    public void InitializePlayer(PlayerConfiguration pc)
    {
        playerConfig = pc;
        playerMesh.material = pc.PlayerMaterial;
        playerConfig.input.onActionTriggered += Input_onActionTriggered;
    }

    private void Input_onActionTriggered(CallbackContext obj)
    {
        //switc-case does not work??
        if (obj.action.name == controls.Kart.Accel.name) carController.OnAccel(obj.ReadValue<float>());
        else if (obj.action.name == controls.Kart.Reverse.name) carController.OnReverse(obj.ReadValue<float>());
        else if (obj.action.name == controls.Kart.DriftDown.name && obj.started) carController.OnDriftDown();
        else if (obj.action.name == controls.Kart.DriftUp.name && obj.canceled) carController.OnDriftUp();
        else if (obj.action.name == controls.Kart.Horizontal.name) carController.OnHorizontal(obj.ReadValue<float>());
        else if (obj.action.name == controls.Kart.driftControl_Left.name) carController.OnDriftControl_Left(obj.ReadValue<float>());
        else if (obj.action.name == controls.Kart.driftControl_Right.name) carController.OnDriftControl_Right(obj.ReadValue<float>());
        else if (obj.action.name == controls.Kart.powerControl_Left.name) carController.OnPowerControl_Left(obj.ReadValue<float>());
        else if (obj.action.name == controls.Kart.powerControl_Right.name) carController.OnPowerControl_Right(obj.ReadValue<float>());
        else if (obj.action.name == controls.Kart.LookBack.name) carController.OnLookBack(obj.ReadValue<float>());
        else if (obj.action.name == controls.Kart.PauseGame.name) carController.OnPauseGame();
        else if (obj.action.name == controls.Kart.UseItem.name && obj.started) GetComponent<KartItem>().SetUseItem(true);
    }
}
