using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class NewUserCheck : MonoBehaviour
{
    public AudioMixer audioMixer2;
    // Start is called before the first frame update
    void Start()
    {
        float gameVolume = PlayerPrefs.GetFloat("MAIN_VOLUME",0);
        audioMixer2.SetFloat("volume", gameVolume);
        if (!(PlayerPrefs.HasKey("first_name")))
        {
            Debug.Log("New user, jumps to name registration");
            SceneManager.LoadScene(1);
            PlayerPrefs.SetFloat("MAIN_VOLUME", 0);
        }
    }
}
