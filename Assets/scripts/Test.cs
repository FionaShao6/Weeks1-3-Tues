using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float speed = 0.05f;
    public AnimationCurve curve;
    [Range(0, 10)]
    public float t;

    private float moveSpeed;
    public float lerp;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        transform.localScale = Vector2.one * curve.Evaluate(t);
        Vector2 pos = transform.localPosition;
        //Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.localPosition);
        if (pos.y <= 0.3f)
        {

            pos.y += speed;
            transform.localPosition = pos;
        }
        else
        {
            pos.y += 0;
        }

    }
}
