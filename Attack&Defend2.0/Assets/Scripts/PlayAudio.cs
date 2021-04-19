using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    [SerializeField] private AudioSource audio;


    // Start is called before the first frame update
    void Start()
    {
        audio.Play();
        Debug.Log("Audio clip is being played");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
