using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCamera : MonoBehaviour
{
    public float CameraSpeed = 0.005f;
    public int startFieldOfView = 120;
    public int ObjectFieldOfView = 86;
    void Start()
    {

        GetComponent<Camera>().fieldOfView = startFieldOfView;
    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, ObjectFieldOfView, CameraSpeed);


    }
}
