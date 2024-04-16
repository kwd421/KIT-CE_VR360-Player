using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VIdeo360Play : MonoBehaviour
{
    VideoPlayer vp;
    
    public VideoClip[] vcList;
    int curVCidx;   // 현재 재생중인 클립 번호 저장

    void Start()
    {
        vp = GetComponent<VideoPlayer>();
        vp.clip = vcList[0];
        curVCidx = 0;
        vp.Stop();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftBracket))
        {
            //vp.clip = vcList[(--curVCidx + vcList.Length) % vcList.Length];
            SwapVideoClip(false);
        }
        else if(Input.GetKeyDown(KeyCode.RightBracket))
        {
            //vp.clip = vcList[++curVCidx % vcList.Length];
            SwapVideoClip(true);
        }
    }

    public void SwapVideoClip(bool isNext)
    {
        int setVCnum = curVCidx;
        vp.Stop();
        if(isNext)
        {
            setVCnum = (setVCnum + 1) % vcList.Length;
        }
        else
        {
            setVCnum = ((setVCnum - 1) + vcList.Length) % vcList.Length;
        }

        vp.clip = vcList[setVCnum];
        vp.Play();
        curVCidx = setVCnum;
        Debug.Log(curVCidx);
    }

    public void SetVideoPlay(int num)
    {
        if(curVCidx != num)
        {
            vp.Stop();
            vp.clip = vcList[num];
            curVCidx = num;
            vp.Play();
        }
    }
}
