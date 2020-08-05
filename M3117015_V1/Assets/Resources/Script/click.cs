using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    float scaleX, scaleY;
    //public AudioSource buttonSound;

    public void start()
    {
        scaleX = transform.localScale.x;
        scaleY = transform.localScale.y;
    }

    public void onMouseDown()
    {
        //buttonSound.PlayOneShot(buttonSound.clip);
        transform.localScale = new Vector2(scaleX * 1.2f, 2 * scaleY / 1.2f);

    }


    public void onMouseUp()
    {
        //buttonSound.PlayOneShot(buttonSound.clip);
        transform.localScale = new Vector2(scaleX , scaleY);

    }

}
