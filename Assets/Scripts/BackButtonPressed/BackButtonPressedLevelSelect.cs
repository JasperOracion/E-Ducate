using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackButtonPressedLevelSelect : MonoBehaviour
{
    void Update()
    {
        // Make sure user is on Android platform
        if (Application.platform == RuntimePlatform.Android)
        {

            // Check if Back was pressed this frame
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                string prevScene = PlayerPrefs.GetString("SubjectSelected");
                if (prevScene == "Math")
                {
                    SceneManager.LoadScene(5);
                }
                if (prevScene == "Science")
                {
                    SceneManager.LoadScene(4);
                }
                if (prevScene == "English")
                {
                    SceneManager.LoadScene(6);
                }
                if (prevScene == "BasicSkills")
                {
                    SceneManager.LoadScene(7);
                }
            }
        }
    }
}
