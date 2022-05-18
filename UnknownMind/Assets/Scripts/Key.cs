using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public DoorControl ds;
    public void Unlock()
    {
        ds.isLock = false;
    }
       
}
