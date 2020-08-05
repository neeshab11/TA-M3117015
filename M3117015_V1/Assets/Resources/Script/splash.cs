using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class splash : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("loading");
    }
}

