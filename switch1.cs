using System.Collections;
using System. Collections. Generic;
using UnityEngine;


public class switch1 : MonoBehaviour
{
    public GameObject bridgeObj;
    public GameObject switchObj;

    void OnCollisionEnter(Collision collision)
    {
        bridgeObj.SetActive(true); // Activate the bridge object 
        switchObj.SetActive(false); // Deactivate the switch object
    }
}