using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioSource bgaudioSource;

    public List<Sound> clips;
    public static Audio inst;


    public void Awake()
    {
        inst = this;

    }

    public void SoundPlay(SoundName name)
    {
        foreach (var item in clips)
        {
            if (item.bgName == name)
            {
                audioSource.PlayOneShot(item.clip);
                break;
            }
        }

    }
    public void BackgroundMusic(SoundName name)
    {
        foreach (var a in clips)
        {
            if (a.bgName == SoundName.Background)
            {
                int bgClipIndex = clips.FindIndex(x => x.bgName == SoundName.Background);
                Debug.Log("int val" + bgClipIndex);
                bgaudioSource.clip = clips[bgClipIndex].clip;
                bgaudioSource.Play();
            }
        }
    }
    //public void SoundStop()
    //{
    //    bgaudioSource.Pause();
    //}


    [System.Serializable]
    public class Sound
    {
        public SoundName bgName;
        public AudioClip clip;
    }
    public enum SoundName
    {
        Shoot,
        NearMiss,
        GameOver,
        GameComplete,
        Buttons,
        Try,
        Background,
        Mainmenu
    }



}




