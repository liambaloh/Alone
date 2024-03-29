﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class SplashController : MonoBehaviour
{

    public CanvasGroup img1;
    public CanvasGroup img2;
    public AudioSource as1;
    public AudioSource as2;
    public float progress = 0;

    public int ScreenX = 1024;
    public int ScreenY = 786;

    // Use this for initialization
    void Start()
    {
        //Screen.SetResolution(ScreenX, ScreenY, false);
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime;

        img1.alpha = 0;
        img2.alpha = 0;

        if (progress >= 0.5f && progress < 1.5f)
        {
            img1.alpha = progress - 0.5f;
            if (!as1.isPlaying)
            {
                as1.Play();
            }
        }
        if (progress >= 1.5f && progress < 3f)
        {
            img1.alpha = 1;
        }
        if (progress >= 3f && progress < 4f)
        {
            img1.alpha = Mathf.Abs(4 - progress);
        }

        if (progress >= 4.5f && progress < 5.5f)
        {
            img2.alpha = (progress - 4.5f);
            if (!as2.isPlaying)
            {
                as2.Play();
            }
        }
        if (progress >= 5.5f && progress < 7.5f)
        {
            img2.alpha = 1;
        }
        if (progress >= 7.5f && progress < 8.5f)
        {
            img2.alpha = Mathf.Abs(8.5f - progress);
        }

        if (progress >= 9.5f)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
