using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

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
        rot.z += speed*Time.deltaTime;// Rotate around the z - axis
        transform.eulerAngles = rot;
        //Self rotation

    }
}
