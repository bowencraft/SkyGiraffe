using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailCollideDetect : MonoBehaviour
{
    public GameObject cloudObject;
    public GameObject mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera.GetComponent<CameraMove>().cameraMove = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mainCamera.GetComponent<CameraMove>().cameraMove = true;
            Object.Destroy(cloudObject);

        }
    }
   

}
