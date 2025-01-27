using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliceBigger : MonoBehaviour
{
    public float speed = 0.01f;
    public AnimationCurve curve;
    [Range(0, 10)]
    public float t;


    public Vector2 rectPosition = new Vector2(2.31f, -1.79f);//The position of the rect
    public Vector2 rectSize = new Vector2(0.64f,1.68f);//the width and high of the rect, 
    //I created a rectangle with the same shape as the medicine under it to facilitate the size and position of the medicine.

    bool StartToChange = false;//Used to determine whether it is starting to grow
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//If player click the left button
        {
            Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Convert the mouse screen coordinates to world coordinates

            if (IsMouseInRectangle(mouseWorldPosition))//If the mouse click is within the rectangle
            {
                StartToChange = true; // it starts to change
            }
        }

        // If it has started to grow, then execute the enlargement logic I wrote below
        if (StartToChange)
        {
            AliceChange(); 
        }
    }



    private bool IsMouseInRectangle(Vector3 point)
    {
        //The return is used to pass the judgment result back to
        return point.x >= rectPosition.x - rectSize.x/2 &&//
               point.x <= rectPosition.x + rectSize.x/2 &&
               point.y >= rectPosition.y- rectSize.y/2 &&
               point.y <= rectPosition.y + rectSize.y/2;
        //The four points of the rectangle
        //These are used to determine whether the mouse point is within the rectangle

    }
    void AliceChange()
    {

        StartToChange = true;
        t += Time.deltaTime;//The animation time is increasing
        transform.localScale = Vector2.one * curve.Evaluate(t);//Place a curve and set it in the inspector to achieve the effect of enlarging
        Vector2 pos = transform.localPosition;
        //Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.localPosition);

        if (pos.y <= 0.3f)//Here I set Alice to move upwards
        {

            pos.y += speed;
            transform.localPosition = pos;
        }
        else
        {
            pos.y += 0;//Stop the upward
        }
    }
}

