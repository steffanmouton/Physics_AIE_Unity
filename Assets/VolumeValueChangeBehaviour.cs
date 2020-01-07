using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeValueChangeBehaviour : MonoBehaviour
{
    private AudioSource audioSrc;

    private float musicVolume = .25f;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    private void Update()
    {
        audioSrc.volume = musicVolume;
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}
