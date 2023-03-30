using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalLevelChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GmManager.levelStatus == 2)
        {
            GetComponent<PortalTeleport>().scene = "level2";
        }
        else if (GmManager.levelStatus == 1)
        {
            GetComponent<PortalTeleport>().scene = "MainScene";
        }
        else
        {
            GetComponent<PortalTeleport>().scene = "LevelSelect";
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
