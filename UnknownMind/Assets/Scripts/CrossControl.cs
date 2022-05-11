using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CrossControl : MonoBehaviour
{
    public Image Cross;
    public float Range;

    void Update()
    {
        Vector3 forwardX = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        Cross.color = Color.red;


        if (Physics.Raycast(transform.position, forwardX, out hit))
        {
            if (hit.distance <= Range && hit.collider.gameObject.tag == "Props")
            {
                Cross.color = Color.white;
                if (Input.GetMouseButton(0))
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }



}
