using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cek_sound : MonoBehaviour {
 
 public AudioSource AS;
 public AudioSource ASS;

 private AudioSource[] AllAudioSources;
 
    void Start () 
    {
		
    }

    public void playKendang()
    {
         AS = GetComponent<AudioSource>();
         AS.Play();
         AS.enabled = true;
         AS.loop = false;
         AllAudioSources = GameObject.FindObjectsOfType (typeof(AudioSource)) as AudioSource[];
    }
 
    public void StopAllAudio() {
		try
		{
         foreach (AudioSource Audio in AllAudioSources) 
		 {
             Audio.Stop();
             Audio.enabled = true;
         }
		}
		catch
		{
			Debug.Log("nothing clik sound");
		}
     }
 }