using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 0.2f;
    void Start()
    {
          
    }

    // Update is called once per frame


    void Update()
    {
        Vector2 pos = transform. position;
        pos.x = +speed;

        if (pos.x < 0 || pos.x > 5)
        {
            speed = speed * -1;
        }

        transform.position = pos;
       
    }
}
