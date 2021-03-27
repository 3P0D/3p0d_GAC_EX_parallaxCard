using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrpt_turnAround : MonoBehaviour
{
    public float m_RotationSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * (m_RotationSpeed * Time.deltaTime));
    }
}
