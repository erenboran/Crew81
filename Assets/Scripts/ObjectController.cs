using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    [TextArea] [SerializeField] private string objectInfo;

    public string GetObjectInfo()
    {
        return objectInfo;
    }
}
