using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoFrame : MonoBehaviour
{
    VideoPlayer vp;

    void Start()
    {
        vp = GetComponent<VideoPlayer>();
        vp.Stop();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            vp.Stop();
        }
        if(Input.GetKeyDown("space"))
        {
            if (vp.isPlaying)
            {
                vp.Pause();
            }
            else
                vp.Play();
        }
    }

    public void CheckVideoFrame(bool Checker)
    {
        if(Checker)
        {
            if(!vp.isPlaying)
            {
                vp.Play();
            }
            else
            {
                vp.Stop();
            }
        }
    }
}
