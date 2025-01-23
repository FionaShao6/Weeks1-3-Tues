using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class ColoredShapes : MonoBehaviour
{
    public float speed = 0.05f;
    public SpriteRenderer spriteRenderer;

    public Sprite[] sprites;

    [Range(0, 1)] public float t;




    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        Vector3 Squareposition = transform.position;
        Vector3 fangposition = Camera.main.WorldToScreenPoint(Squareposition);
        Vector3 mousepositon = Camera.main.WorldToScreenPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0) && mousepositon == fangposition)
        {
            //if (mousepositon == fangposition)
            //{
            ChangeColor();
            ChangeSize();
            Destroy(gameObject, 1);
            // }
        }

    }
    void ChangeColor()
    {
        spriteRenderer.color = Random.ColorHSV();


    }
    void ChangeSize()
    {
        transform.localScale = Vector2.one * Random.Range(0.01f, 5);

    }
}
