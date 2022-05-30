using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    int wholeNumber = 3;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horzInput = Input.GetAxis("Horizontal");
        float vertInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horzInput * 5f, rb.velocity.y, vertInput*5f);

        //from project settings Jump has more options from unity input manager than just using space
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("space pressed");
            rb.velocity = new Vector3(rb.velocity.x, 3f, rb.velocity.z);
        }



        /*getkeydown only works on a single depress
        if (Input.GetKeyDown("space"))
            {
            Debug.Log("space pressed");
            rb.velocity = new Vector3(0, 3f, 0);
       } 

        //get key executed even if you hold down the key
        if (Input.GetKeyDown("up"))
        {
            rb.velocity = new Vector3(0, 0, 3f);
        }

        if (Input.GetKeyDown("right"))
        {
            rb.velocity = new Vector3(3f, 0, 0);
        }

        if (Input.GetKeyDown("left"))
        {
            rb.velocity = new Vector3(-3f, 0, 0);
        }

        if (Input.GetKeyDown("down"))
        {
            rb.velocity = new Vector3(0, 0, -3);
        }*/

    }

    //if something hits me I lose health
    private void OnCollisionEnter()
    {
        Debug.Log("Player hit :(");
    }


}
