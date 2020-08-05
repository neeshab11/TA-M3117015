using UnityEngine;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Vuforia;

public class GameManager : MonoBehaviour
{

    private int level = 1;
    private List<GameObject> moves = new List<GameObject>();    
    private bool finished = false;
    private bool musicPlaying = false; 

    public AudioSource winSound;
    public AudioSource wrongSound;

    public GameObject[] availCubes; 
    public GameObject cubeParent;
    public Text scoreText;

    public GameObject RepeatButton;
	public GameObject Salah;
	public GameObject Benar;
	
    [HideInInspector] 
    public static GameObject lastHit = null;
    [HideInInspector]
    public static int hitCount=-1;
	[HideInInspector]
    public int score = 0;
	[HideInInspector]
	public int newscore;
    
	private void Awake()
	{
		PlayerPrefs.DeleteAll(); 
	}
	
    void Start() 
	{
        RepeatButton.SetActive(true);
		Salah.gameObject.SetActive(false);
		Benar.gameObject.SetActive(false);
        NextLevel();
        scoreText.text = "Score:" + score;
    }
	  
    public void NextLevel()
    {
		Benar.gameObject.SetActive(false);
		Salah.gameObject.SetActive(false);
        RepeatButton.SetActive(true);
        level++; 
        InitializeLevel(level); 
        StartPattern(); 
    }
    
    void InitializeLevel(int lvl)
    {
        moves.Clear();
        scoreText.text = "Score:" + score;
        for (int i = 0; i < lvl; i++)  
        {
            int randomIndex = Random.Range(0, availCubes.Length); 
            GameObject tempGameObj = availCubes[randomIndex]; 
            moves.Add(tempGameObj);    
        } 
    }

    public void StartPattern() 
    {
        if (!musicPlaying)
        {
            Restart(); 
            BlockCubes(); 
            finished = false;
            StartCoroutine(PlayPattern());
        }
    }

    void Restart()
    {
        lastHit = null; 
        hitCount = -1; 
    }

    IEnumerator PlayPattern() 
    {
        musicPlaying = true; 
        for (int i = 0; i < moves.Count; i++)
        {
            moves[i].GetComponent<ClickHandler>().SetPressed(); 
            yield return new WaitForSeconds(1f); 
        }
        UnblockCubes();
        musicPlaying = false;
    }

    void Update () 
    {      
        if ((lastHit != null) && (moves[hitCount] != lastHit)) 
        {
			Debug.Log("wrong");
			Salah.gameObject.SetActive(true);
			Benar.gameObject.SetActive(false);
			if (level == 5)
            {
				GoFinish();
            }
        }
		
        if (hitCount == level - 1 ) 
        {
            FinishLevel();
            if (level == 5)
            {
				GoFinish();
            }
        }
	}

    void FinishLevel()
    {
        if (!finished)
        { 
            finished = true;
            RepeatButton.SetActive(false);
            BlockCubes();
			if (level == 5)
            {
				GoFinish();
            }
			if (moves[hitCount]!= lastHit){
				score = score;
				Benar.gameObject.SetActive(false);
			}
			else {
			Benar.gameObject.SetActive(true);
			score = score + 25;
			Debug.Log(score);}
        }	
    }
	
	void GoFinish(){
		newscore = score;
	    PlayerPrefs.SetInt("CurrentScore",newscore);
		Debug.Log("newscore" + score);
		SceneManager.LoadScene("Finish");
	}

    void BlockCubes()
    {
        foreach (GameObject cube in availCubes)
        {
            cube.layer = LayerMask.NameToLayer("Ignore Raycast");
        }
    }

    void UnblockCubes()
    {
        foreach (GameObject cube in availCubes)
        {
            cube.layer = LayerMask.NameToLayer("Default"); 
        }
    }
	
	public void GoMenu()
    {
        SceneManager.LoadScene("MENU_GAME");
    }
}