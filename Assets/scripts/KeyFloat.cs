using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class KeyFloat : MonoBehaviour
{
    public float speed= 0.1f;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.eulerAngles;
        rot.z += speed*Time.deltaTime;
        transform.eulerAngles = rot;
        //transform.Rotate(0,0, speed * Time.deltaTime);
        //transform.position = Vector3.zero;

        //transform.eulerAngles = Vector3.zero;
       
    }
}
