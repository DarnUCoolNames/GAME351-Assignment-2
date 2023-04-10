using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLaser : MonoBehaviour
{
    [SerializeField] private GameObject laser;
    [SerializeField] private GameObject laser_point;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laser, laser_point.transform.position, laser_point.transform.rotation);
        }
    }
}
