using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackButtonPressedHome : MonoBehaviour
{
    public GameObject exit;
    public GameObject settings;
    void Update()
    {
        // Make sure user is on Android platform
        if (Application.platform == RuntimePlatform.Android)
        {

            // Check if Back was pressed this frame
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (settings.activeSelf)
                {
                    settings.SetActive(false);
                }
                else
                {
                    exit.SetActive(true);
                }
            }
        }
    }
}
