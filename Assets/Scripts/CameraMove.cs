using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PlayerObject;
    public float CameraSpeed = 0.005f;
    public float colorTime = 0.005f;
    public int CameraOffset = 3;

    public Color goalColor;

    public bool cameraMove = true;
    void Start()
    {
        goalColor = GetComponent<Camera>().backgroundColor;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (cameraMove)
        {
            Vector3 newPos = transform.position;

            newPos.x = Mathf.Lerp(newPos.x, PlayerObject.transform.position.x, CameraSpeed * Time.deltaTime);
            newPos.y = Mathf.Lerp(newPos.y, PlayerObject.transform.position.y + CameraOffset, CameraSpeed * Time.deltaTime);



            Color lerpColor = new Color(Mathf.Lerp(this.GetComponent<Camera>().backgroundColor.r, goalColor.r, colorTime * Time.deltaTime),
             Mathf.Lerp(this.GetComponent<Camera>().backgroundColor.g, goalColor.g, colorTime * Time.deltaTime),
                Mathf.Lerp(this.GetComponent<Camera>().backgroundColor.b, goalColor.b, colorTime * Time.deltaTime));

            GetComponent<Camera>().backgroundColor = lerpColor;

            transform.position = newPos;

        }

    }
}
