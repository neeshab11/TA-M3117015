using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MusicPlay : MonoBehaviour
{
	void Start()
     {
		 
	 }
     private static MusicPlay instance = null;
     
     public static MusicPlay Instance
     {
         get { return instance; }
     }

     void Awake()
     {
         if (instance != null && instance != this) 
		 {
             Destroy(this.gameObject);
			 Debug.Log("Destroy");
             return;
         } 
		 else 
		 {
             instance = this;
         }
         DontDestroyOnLoad(this.gameObject);
     }
}