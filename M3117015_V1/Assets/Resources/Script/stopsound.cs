using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopsound : MonoBehaviour
{
    void Start()
    {
         MusicPlay.Instance.gameObject.GetComponent<AudioSource>().Pause();
	}
}
