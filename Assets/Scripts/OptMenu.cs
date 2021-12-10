using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class OptMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider volumeSlider;
    public Dropdown graphicsSettings;

    public void Start()
    {
        float gameVolume = PlayerPrefs.GetFloat("MAIN_VOLUME");
        int gameGraphics = PlayerPrefs.GetInt("GRAPHICS");
        volumeSlider.value = gameVolume;
        graphicsSettings.value = gameGraphics;
    }
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
        PlayerPrefs.SetFloat("MAIN_VOLUME", volume);
        Debug.Log("User adjust the volume");
    }
    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        PlayerPrefs.SetInt("GRAPHICS",qualityIndex);
        Debug.Log("User sets the quality to " + qualityIndex);
    }
    public void ResetPlayerPref()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(1);
        Debug.Log("User resets all the progress");
    }
}