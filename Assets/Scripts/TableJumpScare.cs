using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableJumpScare : MonoBehaviour
{
    public AudioSource soundSource;
    public AudioClip slideSound;

    public GameObject slidingObject;



    void Start()
    {
        soundSource.clip = slideSound;

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(scare());
        }
        //sound
    }
    IEnumerator scare()
    {
       
        {
            slidingObject.GetComponent<Animator>().Play("jumpSTV");
            soundSource.clip = slideSound;
            soundSource.Play();
            yield return new WaitForSeconds(0.4f);
            Destroy(gameObject);
        }



    }
}
