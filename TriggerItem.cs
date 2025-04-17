using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//FindObjectOfType: https://docs.unity3d.com/ja/current/ScriptReference/Object.FindObjectOfType.html

public class TriggerItem : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<CountScore>().AddScore(1); // call the AddScore method from CountScore
        Destroy(gameObject); // Destroy the trigger item
    }
}
