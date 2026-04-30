using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class StaticData
{
    public float rotationSpeed;

    public StaticData()
    {
        rotationSpeed = 360f;
    }

    public void RotateObject(GameObject gameObject)
    {
        gameObject.transform.Rotate(Vector3.forward * Time.deltaTime * GetRotationSpeed());
    }

    public float GetRotationSpeed()
    {
        return rotationSpeed;
    }
}
