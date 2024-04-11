using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPersist : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] music = GameObject.FindGameObjectsWithTag("Music");

        if (music.Length > 1)
        {
            for (int i = 1; i < music.Length; i++) // start at 1 to keep original music object
            {
                Destroy(music[i]);
            }
        }

        DontDestroyOnLoad(this.gameObject);
    }

}
