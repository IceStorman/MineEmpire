using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Songs : MonoBehaviour
{
    public AudioClip song1;
    public AudioClip song2;
    public AudioClip song3;
    public AudioClip song4;
    public AudioClip song5;
    public AudioClip song6;
    public AudioClip song7;
    public AudioClip song8;
    public AudioClip song9;
    public AudioClip song10;

    void Start()
    {
        GetComponent<AudioSource>();
        //AudioSource.PlayClipAtPoint(song1, new Vector2(0, 0));
        
    }

    void Update()
    {
        
    }
}