using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideJumpScare : MonoBehaviour
{
    //  [SerializeField] private Animator slideObjectAnim;
    // [SerializeField] private string test = "test";
    public GameObject table;
   // public AnimationClip slide;
   // Animation anim;

    void Start()
    {
     //   anim = GetComponent<Animation>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))

        {
            // slideObjectAnim.Play(test,0,0f);
            table.GetComponent<Animator>().Play("test");
         //   anim.clip = slide;
          //  anim.Play();
        }
    }
}
