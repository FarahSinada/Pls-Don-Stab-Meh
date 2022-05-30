using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    private void OnTriggerEnter()
    {
        Debug.Log("Something hit the wall");
    }



}
