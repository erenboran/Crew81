using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour
{
    Animation doorAnim;
    public Animator thisd;
    public bool isOpen;
    public GameObject hinge;
    public bool isLock;
    
    void Start()
    {
        doorAnim = GetComponent<Animation>();
    }

    public void Open()
    {
        Debug.Log("a��ld�");
        if (!isLock)
        {
            //doorAnim.Play("DoorOpen");
            thisd.SetBool("open", true);

            isOpen = true;
            Debug.Log("a��ld�");
            hinge.transform.gameObject.tag = "Untagged";
        }
    }
    public void Close()

    {
        //doorAnim.Play("DoorClose");
        isOpen = false;
    }
}
