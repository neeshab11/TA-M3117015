using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menu_game : MonoBehaviour
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
	public void Back()
    {
       SceneManager.LoadScene("main_menu");
    }
	public void BonangBarung()
    {
       SceneManager.LoadScene("AR_BONANG_BARUNG");
    }
	public void BonangPenerus()
    {
       SceneManager.LoadScene("AR_BONANG_PENERUS");
    }
	public void Peking()
    {
       SceneManager.LoadScene("AR_PEKING");
    }
	public void Gong()
    {
       SceneManager.LoadScene("AR_GONG");
    }
	public void Kendhang()
    {
       SceneManager.LoadScene("AR_KENDHANG");
    }
	public void KethukKempyang()
    {
       SceneManager.LoadScene("AR_KETHUKKEMPYANG");
    }
	public void Saron()
    {
       SceneManager.LoadScene("AR_SARON");
    }
	public void Slenthem()
    {
       SceneManager.LoadScene("AR_SLENTHEM");
    }
	public void Kenong()
    {
       SceneManager.LoadScene("AR_KENONG");
    }
	public void GoMenu()
    {
       SceneManager.LoadScene("MENU_GAME");
    }
}
