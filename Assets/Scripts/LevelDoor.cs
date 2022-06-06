using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDoor : MonoBehaviour
{
    public bool isOpen;

    public bool isLocked;
    
    void Start()
    {
        isOpen = false;
        isLocked = true;
    }
    void Update()
    {
        if(!isLocked && !isOpen)
        {
            transform.GetComponent<Animator>().Play("DoorLast");
        }

        
    }

}
