using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosterSlideshow : MonoBehaviour
{
    public Texture[] posterImages;      // Assign in Inspector
    public Renderer posterRenderer;     // The mesh renderer of the poster
    private int currentIndex = 0;

    public void ShowNextPoster()
    {
        if (posterImages.Length == 0) return;

        currentIndex = (currentIndex + 1) % posterImages.Length;
        posterRenderer.material.mainTexture = posterImages[currentIndex];
    }
}
