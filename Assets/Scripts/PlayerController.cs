using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().PlayAudio("Background");
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag=="Enemy")
        {
           AudioManager.instance.StopPlayAudio("Background");
            FindObjectOfType<AudioManager>().PlayAudio("PlayerDeath");
        }
    }
   
}
