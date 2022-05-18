using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour
{
    Animation doorAnim;
    public Animator thisd;
    public bool isOpen;

    public bool isLock;
    
    void Start()
    {
        doorAnim = GetComponent<Animation>();
    }

    public void Open()
    {
        Debug.Log("açýldý");
        if (!isLock)
        {
            //doorAnim.Play("DoorOpen");
            thisd.SetBool("open", true);

            isOpen = true;
            Debug.Log("açýldý");
        }
    }
    public void Close()

    {
        //doorAnim.Play("DoorClose");
        isOpen = false;
    }
}
