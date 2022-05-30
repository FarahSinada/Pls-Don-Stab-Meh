using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingObjects : MonoBehaviour
{
    [SerializeField] float flySpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float flyAmount = flySpeed * Time.deltaTime;
        transform.Translate(0, -flyAmount, 0);
    }
}
