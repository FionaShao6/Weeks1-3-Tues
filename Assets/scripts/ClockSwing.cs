using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockRotate : MonoBehaviour
{
    public float SwingSpeed = 5f;

    public float SwingAngle = 30f;
    private Quaternion startRotation;
    private Vector3 rotationAxis;


    void Start()
    {//https://blog.csdn.net/ysn11111/article/details/133277377
        startRotation = transform.localRotation;
        rotationAxis = transform.forward;//forward corresponds to the z axis
    }

    // Update is called once per frame
    void Update()
    {
        float angle = Mathf.Sin(Time.time * SwingSpeed) * SwingAngle;
        transform.localRotation = Quaternion.AngleAxis(angle, rotationAxis) * startRotation;//Create a rotation around an axis

    }
}
