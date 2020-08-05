using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playsound : MonoBehaviour
{
    void Start()
	{
        MusicPlay.Instance.gameObject.GetComponent<AudioSource>().UnPause();
	}
}
