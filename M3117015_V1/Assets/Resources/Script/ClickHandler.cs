using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ClickHandler : MonoBehaviour
{
    private Animator animator;
    private AudioSource audioSource;

    void Start () {
		
        animator = gameObject.GetComponent<Animator>();
        audioSource = gameObject.GetComponent<AudioSource>();
	}
	
    void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        PlayerPress();
    }

    void OnMouseUp()
    {
        SetUnPressed(); 
    }
    
    public void SetPressed()
    {
        Press();
        Invoke("SetUnPressed", 0.5f); 
    }
    
    void Press()
    {
		if (animator == null) 
			{
				Debug.Log("not anim"); 
			}
		else
			{
				animator.SetBool("Pressed", true);	
				audioSource.Play();					
			}  
    }

    void PlayerPress()
    {
        Press(); 
        GameManager.lastHit  = gameObject;  
        GameManager.hitCount++; 
    }

    public void SetUnPressed()
    {
        animator.SetBool("Pressed", false); //untuk disable animasi saat di press >> mengembalikan ke ukuran awal cube nya
    }
}