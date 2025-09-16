using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObject : MonoBehaviour
{
    [Tooltip("초당 회전 속도 (도 단위)")]
    public float rotationSpeed = 100f;

    void Update()
    {
       transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime, Space.Self);
    }
}
