using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeFaderController : MonoBehaviour
{
    public Transform knob;
    public AudioSource audioSource;

    public float minWorldX = 1.66f;
    public float maxWorldX = 1.74f;

    void Update()
    {
        // Clamp world position on X axis
        Vector3 worldPos = knob.position;
        worldPos.x = Mathf.Clamp(worldPos.x, minWorldX, maxWorldX);
        knob.position = worldPos;

        // Convert world position to volume (based on world range)
        float t = Mathf.InverseLerp(minWorldX, maxWorldX, knob.position.x);
        audioSource.volume = t;
    }
}
