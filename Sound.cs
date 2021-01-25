using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip sound01;
    public AudioClip sound02;
    public AudioSource source;
    public AudioClip NowPlaying = null;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void B1()
    {
        if (NowPlaying == sound02)
        {
            source.Stop();
            NowPlaying = null;


            
        }
        if (NowPlaying == sound01)
        {
            source.Stop();
            NowPlaying = null;

            
        }


        NowPlaying = sound01;
        source.PlayOneShot(NowPlaying);
    }

    public void B2()
    {
        if (NowPlaying == sound01)
        {
            source.Stop();
            NowPlaying = null;
            
        }
        if (NowPlaying == sound02)
        {
            source.Stop();
            NowPlaying = null;

        }
        NowPlaying = sound02;
        source.PlayOneShot(NowPlaying);
    }
    
}