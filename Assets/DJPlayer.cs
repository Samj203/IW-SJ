using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DJPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    private bool isPlaying = false;

    public void ToggleMusic()
    {
        if (audioSource == null) return;

        if (isPlaying)
        {
            audioSource.Pause();
        }
        else
        {
            audioSource.Play();
        }

        isPlaying = !isPlaying;
    }
}
