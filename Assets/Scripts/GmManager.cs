using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GmManager : MonoBehaviour
{

    public static int levelStatus = 1;
    public GameObject bridgeCollider;

    public GameObject player;
    public GameObject mainCamera;

    public GameObject level1FinishPos;
    public GameObject Pos2;

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name.Equals("LevelSelect"))
        {

            if (GmManager.levelStatus == 2)
            {
                mainCamera.GetComponent<SelCamera>().SelObject = Pos2;
                player.GetComponent<Transform>().position = level1FinishPos.transform.position;


                Destroy(bridgeCollider);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
    }
}
