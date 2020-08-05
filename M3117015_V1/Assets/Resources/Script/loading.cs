using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class loading : MonoBehaviour
{
    public Transform LoadingBar;
    [SerializeField]
    private float currentAmount;
    [SerializeField]
    private float speed = 30;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (currentAmount < 100)
        {
            currentAmount += speed * Time.deltaTime;
            Debug.Log((int)currentAmount);
        }
        else
        {
            //Application.LoadLevel("main_menu");
            SceneManager.LoadScene("main_menu");
        }

        LoadingBar.GetComponent<Image>().fillAmount = currentAmount / 100;
    }
}

