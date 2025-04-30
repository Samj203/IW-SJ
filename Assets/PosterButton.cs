using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PosterButtonTrigger : MonoBehaviour
{
    public PosterSlideshow slideshow;  

    public void TriggerNextPoster()
    {
        if (slideshow != null)
            slideshow.ShowNextPoster();
    }
}
