using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HastaneTriggerDoor : MonoBehaviour
{

    public GameObject asylDoor;
    public AudioSource soundSource;
    public AudioClip closeSound;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(doorClose());

        }

    }

    IEnumerator doorClose()
    {

        {
            asylDoor.GetComponent<Animator>().Play("doorClevel3");
            soundSource.clip = closeSound;
            soundSource.Play();
            yield return new WaitForSeconds(0.4f);
            Destroy(gameObject);
        }



    }
}
