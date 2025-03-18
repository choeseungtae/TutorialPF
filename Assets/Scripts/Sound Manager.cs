using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private static SoundManager instance;
    public static SoundManager Instance
    {
        get
        {
            instance = (SoundManager)FindAnyObjectByType(typeof(SoundManager));
            if (instance == null)
            {
                GameObject obj = new GameObject("SoundManager", typeof(SoundManager));
                instance = obj.GetComponent<SoundManager>();
            }

            return instance;
        }
    }


    public AudioSource bgmPlayer;
    public AudioSource sfxPlayer;

    public AudioClip bgmClip;
    public AudioClip jumpClip;
    public AudioClip coinClip;

    private void Awake()
    {
        if (bgmPlayer == null)
            bgmPlayer = gameObject.AddComponent<AudioSource>();  // 자동 추가

        if (sfxPlayer == null)
            sfxPlayer = gameObject.AddComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        //Debug.Log("dd");
        PlayBGM();
    }

    public void PlayBGM()
    {
        bgmPlayer.clip = bgmClip;
        bgmPlayer.Play();
    }

    public void PlaySFX(string sfxName)
    {
        if(sfxName == "Jump")
        {
            sfxPlayer.PlayOneShot(jumpClip);
        }

        if(sfxName == "Coin")
        {
            sfxPlayer.PlayOneShot(coinClip);

        }
    }
    
}
