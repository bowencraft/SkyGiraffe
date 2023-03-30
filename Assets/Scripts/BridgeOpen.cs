using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeOpen : MonoBehaviour
{
    public GameObject bridgeCollider;
    // Start is called before the first frame update
    void Start()
    {
        if (GmManager.levelStatus == 2) {
            Destroy(bridgeCollider);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
