using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject SelObject;
    public float CameraSpeed = 0.005f;
    public int CameraOffset = 3;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;

        newPos.x = Mathf.Lerp(newPos.x, SelObject.transform.position.x, CameraSpeed * Time.deltaTime);
        newPos.y = Mathf.Lerp(newPos.y, SelObject.transform.position.y + CameraOffset, CameraSpeed*Time.deltaTime);

        transform.position = newPos;

    }
}
