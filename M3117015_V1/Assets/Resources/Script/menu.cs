using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void GoToBelajar()
    {
        SceneManager.LoadScene("belajar");
    }
    public void GoToAr()
    {
        SceneManager.LoadScene("MENU_GAME");
    }
    public void ExitApplication()
    {
       Application.Quit();
    }
	 public void Info()
    {
       SceneManager.LoadScene("CREDITS");
    }
	public void Panduan()
    {
       SceneManager.LoadScene("PANDUAN");
    }
}
