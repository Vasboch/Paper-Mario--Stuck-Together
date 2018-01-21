﻿using System;
using UnityEngine;

public class ExampleHammerable : MonoBehaviour, IHammerable
{
    public AudioClip destroySound;
    public AudioSource audioSource;

    public void hammer() {
        if(audioSource != null)
            audioSource.PlayOneShot(destroySound);

        gameObject.SetActive(false);
    }
}
