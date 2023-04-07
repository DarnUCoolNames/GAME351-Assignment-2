using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private float speed = 30;
    [SerializeField] private float rotate_speed = 5;
    private void Update()
    {
        Vector3 position = transform.position;
        position.y = Terrain.activeTerrain.SampleHeight(transform.position) + 15;
        transform.position = position;

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotate_speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotate_speed * Time.deltaTime, 0);
        }
     }
}
