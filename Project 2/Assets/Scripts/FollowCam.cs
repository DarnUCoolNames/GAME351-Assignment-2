using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    void Update()
    {
        Vector3 position = transform.position;
        position.y = Terrain.activeTerrain.SampleHeight(transform.position) + 50;
        transform.position = position;
    }
}
