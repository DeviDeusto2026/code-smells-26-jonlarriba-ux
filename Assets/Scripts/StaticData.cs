using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticData
{
    public float rotationSpeed;

    public StaticData()
    {
        rotationSpeed = 360f;
    }

    public float GetRotationSpeed()
    {
        return rotationSpeed;
    }
}
