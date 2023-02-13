using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBGM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        Debug.Log("BGM Played.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
