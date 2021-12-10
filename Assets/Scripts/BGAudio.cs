using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGAudio : MonoBehaviour
{
    private static BGAudio intro = null;
    public static BGAudio Instance
    {
        get { return intro; }
    }

    void Awake()
    {
        if(intro != null && intro != this)
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
