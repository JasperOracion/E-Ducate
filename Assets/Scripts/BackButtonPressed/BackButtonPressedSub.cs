using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackButtonPressedSub : MonoBehaviour
{
    public GameObject Settings, GradePanel;
    void Update()
    {
        // Make sure user is on Android platform
        if (Application.platform == RuntimePlatform.Android)
        {

            // Check if Back was pressed this frame
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (GradePanel.activeSelf)
                {
                    GradePanel.SetActive(false);
                }
                else if (Settings.activeSelf)
                {
                    Settings.SetActive(false);
                }
                else
                {
                    PlayerPrefs.DeleteKey("SelectedTopic");
                    PlayerPrefs.DeleteKey("SelectedTopicSprite");
                    SceneManager.LoadScene(2);
                    Debug.Log("User go to select subject");
                }
            }
        }
    }
}
