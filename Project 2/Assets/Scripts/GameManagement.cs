using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{

    public Camera[] cameras;
    private int currentCameraIndex = 0;


    // Start is called before the first frame update
    void Start()
    {

        // Set the first camera in the array to be the active camera
        cameras[0].enabled = true;
        Camera.main.transform.position = cameras[0].transform.position;
        Camera.main.transform.rotation = cameras[0].transform.rotation;

        // Disable all other cameras
        for (int i = 1; i < cameras.Length; i++)
        {
            cameras[i].enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;

            // Set the new active camera
            Camera.main.enabled = false;
            cameras[currentCameraIndex].enabled = true;
            Camera.main.transform.position = cameras[currentCameraIndex].transform.position;
            Camera.main.transform.rotation = cameras[currentCameraIndex].transform.rotation;
        }

    }
}
