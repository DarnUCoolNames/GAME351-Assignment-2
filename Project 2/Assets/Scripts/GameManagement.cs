using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    public Camera[] cameras;
    public CarController[] cars;

    private int currentCameraIndex = 0;
    private int currentCarIndex = 0;


    // Start is called before the first frame update
    void Start()
    {

        // Set the first camera and car in the array to be the active ones
        cameras[0].enabled = true;
        cars[0].enabled = true;
        Camera.main.transform.position = cameras[0].transform.position;
        Camera.main.transform.rotation = cameras[0].transform.rotation;

        // Disable all other cameras and cars
        for (int i = 1; i < cameras.Length; i++)
        {
            cameras[i].enabled = false;
            cars[i].enabled = false;
        }
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            // Disable the current camera and car
            cameras[currentCameraIndex].enabled = false;
            cars[currentCarIndex].enabled = false;

            // Move to the next camera and car
            currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;
            currentCarIndex = (currentCarIndex + 1) % cars.Length;

            // Enable the new camera and car
            cameras[currentCameraIndex].enabled = true;
            cars[currentCarIndex].enabled = true;
            Camera.main.transform.position = cameras[currentCameraIndex].transform.position;
            Camera.main.transform.rotation = cameras[currentCameraIndex].transform.rotation;
        }
    }
}
