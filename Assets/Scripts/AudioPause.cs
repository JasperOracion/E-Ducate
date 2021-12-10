using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPause : MonoBehaviour
{
    void Start()
    {
        if (BGAudio.Instance != null)
        {
            Destroy(BGAudio.Instance.gameObject);
        }
    }
}
