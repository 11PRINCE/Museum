﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip MusicClip;

    public AudioSource MusicSource;

    // Start is called before the first frame update
    void Start()
    {

        MusicSource.clip = MusicClip;
        MusicSource.Play();

    }

}
