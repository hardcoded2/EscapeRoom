using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class WavePlatformSwitch : MonoBehaviour
{
   
    void Start()
    {
        //2021/11/09 20:54:36.397 32000 32044 Info Unity Device name HTC VIVE Focus 3 device type Handheld

        Debug.Log($"ASINK: 1Device name {SystemInfo.deviceModel} device type {SystemInfo.deviceType}");
        if (SystemInfo.deviceModel == "htc_flow")
        {
            Debug.Log($"1Switching vive focus grip");
            var xrController = GetComponent<XRController>();
            xrController.selectUsage = InputHelpers.Button.MenuButton;
            xrController.enabled = true;
        }
        else
        {
            Debug.Log("Control switch didn't run");
        }
        //if(Wave.XR.)
    }
}
