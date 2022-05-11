using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableJumpScare : MonoBehaviour
{
    //public AudioSource soundSource;
    //public AudioClip slideSound;

    public GameObject slidingObject;

    bool isPlayed;


    void Start()
    {
        isPlayed = false;
    //  soundSource.clip = slideSound;

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
        if (!isPlayed)
        {
           // soundSource.Play();
            slidingObject.SetActive(true);
            isPlayed = true;

        }
        yield return new WaitForSeconds(0.4f);
            //slidingObject.SetActive(false);

    }
}
