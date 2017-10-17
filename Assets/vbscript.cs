using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbscript : MonoBehaviour ,IVirtualButtonEventHandler{
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("按下");
        player.transform.Translate(new Vector3(0, 0, 5));
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("松开");
    }
    public GameObject player;
    public GameObject vbobject;
    // Use this for initialization
    void Start () {
        vbobject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}
	
}
