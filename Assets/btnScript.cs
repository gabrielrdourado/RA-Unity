using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class btnScript : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject btnObject;
    public Animator Dog;

    // Start is called before the first frame update
    void Start()
    {
        btnObject = GameObject.Find("VirtualButton");
        Dog.GetComponent<Animator>();
        btnObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Dog.Play("Die");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Dog.Play("DieRecover");
    }

}
