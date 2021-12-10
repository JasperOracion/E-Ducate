using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGAudioLevel : MonoBehaviour
{
    private static BGAudioLevel intro = null;
    public static BGAudioLevel Instance
    {
        get { return intro; }
    }

    void Awake()
    {
        if (intro != null && intro != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            intro = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
