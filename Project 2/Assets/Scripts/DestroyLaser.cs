using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLaser : MonoBehaviour
{
    private float delay = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, delay);
    }
}
