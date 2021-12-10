using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewUserCheck1 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("first_name"))
        {
            Debug.Log("Not a new user, skipped to the start");
            SceneManager.LoadScene(0);
        }
    }
}
