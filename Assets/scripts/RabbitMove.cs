using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitRun : MonoBehaviour
{
    float speed = 0.01f;
    public AnimationCurve curve;//Declaration of use AnimationCurve
    [Range(0,10)]//Set a range
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
      

        transform.localScale = Vector2.one * curve.Evaluate(t);//Use curve to make the rabbit bigger
        //Create a forward-moving effect

        Vector3 pos = transform.position;//Move towards the lower left corner, so both x and y decrease
        pos.x -= speed;
        pos.y -= speed;
        transform.position = pos;

        



    }
}
