using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitRun : MonoBehaviour
{
    float speed = 0.01f;
    public AnimationCurve curve;
    [Range(0,10)]
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 10)
        {
            t = 0;
        }

        transform.localScale = Vector2.one * curve.Evaluate(t);


        Vector3 pos = transform.position;
        pos.x -= speed;
        pos.y -= speed;
        transform.position = pos;

        



    }
}
