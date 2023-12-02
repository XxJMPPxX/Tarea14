using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoBala : MonoBehaviour
{
    private AudioSource _audioSource;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        { 
            _audioSource.Play();
        }
    }
    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }
}

