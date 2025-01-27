using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PokerRotate : MonoBehaviour
{
    public float speed = 0.1f;
    [Range(0, 0.3f)]
    public float t;

    public Vector2 start;
    public Vector2 end;
    // bool increasing = true;
    private int direction = 1;
    // public AnimationCurve curve;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += Input.GetAxis("Horizontal") * speed * 5f * Time.deltaTime;
        pos.y += Input.GetAxis("Vertical") * speed * 5f * Time.deltaTime;
        transform.position = pos;


        //if (increasing)
        //{
        //    t += speed * Time.deltaTime;
        //    if (t >= 0.3f)
        //    {
        //        increasing = false;

        //    }
        //    else
        //    {
        //        t -= speed * Time.deltaTime;
        //        if (t <= 0f)
        //        {
        //            increasing = true;
        //        }
        //    }
        //else if(t<=0)
        //{
        //    increasing= true;
        //    t -= speed * Time.deltaTime;

        //}

        t += direction * speed * Time.deltaTime;


        if (t >= 0.3f)
        {
            t = 0.3f;
            direction = -1;
        }
        else if (t <= 0f)
        {
            t = 0f;
            direction = 1;
        }
        Vector2 scale = transform.localScale;
        scale.x = Mathf.Lerp(0, 1, t);
        transform.localScale = scale;

    }




    //transform.Translate(Input.GetAxis("Horizontal")*speed* Time.deltaTime, Input.GetAxis("Vertical")*speed* Time.deltaTime,0);

    //transform.eulerAngles.z += 1;



    //transform.position = Vector2.Lerp(start, end, curve.Evaluate(t));
    //transform.localScale = Vector3.Lerp(originalScale, targetScale, t);



    //if (Input.GetMouseButtonDown(0))
    //{
    //    Vector2 scale = transform.localScale;
    //    scale.x = Mathf.Lerp(0, 1, 0.3f);
    //    transform.localScale = scale;
    //}
    //if (Input.GetMouseButtonDown(1))
    //{
    //    Vector2 scale = transform.localScale;
    //    scale.x = Mathf.Lerp(0, 1, 0);
    //    transform.localScale = scale;
    //}
}

