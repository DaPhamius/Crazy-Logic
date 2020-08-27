using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class musicController : MonoBehaviour
{
    public AudioMixer audioManager;
    public GameObject musicOn;
    public GameObject musicOff;
    public GameObject sfxOn;
    public GameObject sfxOff;


    // Start is called before the first frame update
    void Start()
    {

        SetSFXVolume();
        SetMusicVolume();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void musicToggle()
    {
        if (PlayerPrefs.GetInt("musicMuted") == 0)
        {
            audioManager.SetFloat("musicVolume", -80);
            PlayerPrefs.SetFloat("musicVolume", -80);
            PlayerPrefs.SetInt("musicMuted", 1);
            PlayerPrefs.Save();
            musicOff.SetActive(true);
            musicOn.SetActive(false);

        }
        else
        {
            audioManager.SetFloat("musicVolume", 0);
            PlayerPrefs.SetInt("musicMuted", 0);
            PlayerPrefs.SetFloat("musicVolume", 0);
            PlayerPrefs.Save();
            musicOff.SetActive(false);
            musicOn.SetActive(true);
        }
    }
    public void sfxToggle()
    {
        if (PlayerPrefs.GetInt("sfxMuted") == 0)
        {
            audioManager.SetFloat("sfxVolume", -80);
            PlayerPrefs.SetFloat("sfxVolume", -80);
            PlayerPrefs.SetInt("sfxMuted", 1);
            PlayerPrefs.Save();
            sfxOff.SetActive(true);
            sfxOn.SetActive(false);

        }
        else
        {
            audioManager.SetFloat("sfxVolume", 0);
            PlayerPrefs.SetInt("sfxMuted", 0);
            PlayerPrefs.SetFloat("sfxVolume", 0);
            PlayerPrefs.Save();
            sfxOff.SetActive(false);
            sfxOn.SetActive(true);
        }
    }

    public void SetMusicVolume()
    {
        if (PlayerPrefs.GetInt("musicMuted") == 0)
        {
            audioManager.SetFloat("musicVolume", 0);
            musicOff.SetActive(false);
            musicOn.SetActive(true);
        }
        else
        {
            audioManager.SetFloat("musicVolume", -80);
            musicOff.SetActive(true);
            musicOn.SetActive(false);
        }

    }

    public void SetSFXVolume()
    {
        if (PlayerPrefs.GetInt("sfxMuted") == 0)
        {
            audioManager.SetFloat("sfxVolume", 0);
            sfxOff.SetActive(false);
            sfxOn.SetActive(true);
        }
        else
        {
            audioManager.SetFloat("sfxVolume", -80);
            sfxOff.SetActive(true);
            sfxOn.SetActive(false);
        }

    }

    public void clearPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();

    }
}
