using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPauseLevel : MonoBehaviour
{
    void Start()
    {
        if (BGAudioLevel.Instance != null)
        {
            Destroy(BGAudioLevel.Instance.gameObject);
        }
    }
}
