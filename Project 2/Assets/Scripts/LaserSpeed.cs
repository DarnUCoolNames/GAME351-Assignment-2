using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSpeed : MonoBehaviour
{
    [SerializeField] private float laser_speed = 50;

    void Update()
    {
        transform.Translate(0 , 0, laser_speed * Time.deltaTime);
    }
}
