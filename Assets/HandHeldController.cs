using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandHeldController : MonoBehaviour {

    private Valve.VR.EVRButtonId gripButton = Valve.VR.EVRButtonId.k_EButton_Grip;
    //
    private bool gripButtonDown = false;
    private bool gripButtonUp = false;
    private bool gripButtonPressed = false;


    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
    //
    private bool triggerButtonDown = false;
    private bool triggerButtonUp = false;
    private bool triggerButtonPressed = false;


    // Use this for initialization
    private SteamVR_TrackedObject TrackedObj;

    private SteamVR_Controller.Device controller {
        get{
            return SteamVR_Controller.Input((int) TrackedObj.index);
        }
    }


	void Start () {
        TrackedObj = GetComponent<SteamVR_TrackedObject>();

	}
	
	// Update is called once per frame
	void Update () {
        gripButtonDown = controller.GetPressDown(gripButton);
        gripButtonUp = controller.GetPressUp(gripButton);
        gripButtonPressed = controller.GetPress(gripButton);

        triggerButtonDown = controller.GetPressDown(triggerButton);
        triggerButtonUp = controller.GetPressUp(triggerButton);
        triggerButtonPressed = controller.GetPress(triggerButton);

        if (gripButtonDown) {
            Debug.Log("gripButtonDown pressed");
        }

        if (gripButtonUp)
        {
            Debug.Log("gripButtonUp pressed");
        }

        if (triggerButtonDown)
        {
            Debug.Log("triggerButtonDown pressed");
        }

        if (triggerButtonUp)
        {
            Debug.Log("triggerButtonUp pressed");
        }
    }
}
