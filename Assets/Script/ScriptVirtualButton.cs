using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ScriptVirtualButton : MonoBehaviour, IVirtualButtonEventHandler {

    private GameObject vbObject;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Ditekan!!!");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Dilepas!!!");
    }

    // Use this for initialization
    void Start () {
        vbObject = GameObject.Find("BtnVirtual");
        vbObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}
}
