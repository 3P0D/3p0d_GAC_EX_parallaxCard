using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scrpt_gyroCtrl : MonoBehaviour
{
    Gyroscope _gyro;
    Quaternion _convertgyro;
    public float m_rotintensity = 10;
    Transform _camCtrl;

    public void Start()
    {
        _gyro = Input.gyro;
        _gyro.enabled = true;
        _camCtrl = this.transform;
    }

    public void Update()
    {
        Camera.main.transform.LookAt(transform);

        _convertgyro = _gyro.attitude;
        transform.localRotation = Quaternion.Euler((_convertgyro.x * m_rotintensity) - 45, (_convertgyro.y * m_rotintensity), 0);
    }


}
