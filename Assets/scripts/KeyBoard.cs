using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class KeyBoard : MonoBehaviour
{
    public float rotationSpeed=50;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 pos = transform.position;
        //pos.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        //pos.y += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        //transform.position = pos;
        transform.Translate(0, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0);
        transform.Rotate(0, 0, -Input.GetAxisRaw("Horizontal") * rotationSpeed * Time.deltaTime);
    }
}
