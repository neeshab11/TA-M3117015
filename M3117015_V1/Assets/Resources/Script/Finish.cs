using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Finish : MonoBehaviour
{
    public Text poinText;
	public GameObject starOne;
	public GameObject starTwo;
	public GameObject starThree;
    private int poin;
	
	
    void Start() {
		try
		{
			starOne.SetActive(false);
			starTwo.SetActive(false);
			starThree.SetActive(false);
			poin = PlayerPrefs.GetInt("CurrentScore");
			poinText.text = "Score:" + poin;
			Star();
		}
		catch (MissingReferenceException e)
		{
			Debug.Log("null");
		}
	}
	
	void Star()
	{
		if (poin > 0 && poin < 50)
		{
			starOne.SetActive(true);
		}
		if (poin >= 50 && poin <= 75 )
		{
			starOne.SetActive(true);
			starTwo.SetActive(true);
		}
		if (poin == 100)
		{
			starOne.SetActive(true);
			starTwo.SetActive(true);
			starThree.SetActive(true);
		}
	}
	
	public void Menu() 
	{
		SceneManager.LoadScene("main_menu");
	}
}