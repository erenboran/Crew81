using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CrossControl : MonoBehaviour
{
    public Image Cross;
    public float Range;
    public Camera fpsCam;
    public DoorControl DoorScript;
    public GameObject Ecza;
    public GameObject Komo;
    public AudioClip keySound, doorSound, openingSound, drawerOpen;
    public AudioSource audioSource1;
    void Update()
    {
        Vector3 forwardX = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        Cross.color = Color.red;

        // if (Physics.Raycast(fpsCam.transform.position, forwardX, out hit, Range))
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, Range))
        {
            Debug.DrawLine(transform.position, hit.point, Color.red);
            if (hit.distance <= Range && hit.collider.gameObject.tag == "Props")
            {
                Cross.color = Color.white;
                if (Input.GetMouseButton(0))
                {
                    {

                        Debug.Log(hit.transform.name);
                        var KeyScript = hit.transform.GetComponent<Key>();
                        if (KeyScript != null)
                        {
                            KeyScript.Unlock();
                            Destroy(hit.transform.gameObject);
                            audioSource1.clip = keySound;
                            audioSource1.Play();
                        }
                        //if (hit.transform.GetComponentsInChildren<DoorControl>().Length >=1)


                        {
                            Debug.Log("deneme");
                            DoorScript = hit.transform.GetComponentInChildren<DoorControl>();
                        }

                        //DoorScript = hit.transform.GetComponentsInChildren<DoorControl>() //()[0]; }
                        if (DoorScript != null)
                        {
                            if (!DoorScript.isOpen)
                            {
                                DoorScript.Open();
                                Debug.Log("asdf");
                                audioSource1.clip = doorSound;
                                audioSource1.Play();

                            }
                            else
                            {
                                DoorScript.Close();
                                
                            }
                        }
                    }
                }
            }
            if (hit.distance <= Range && hit.collider.gameObject.tag == "Ecza")
            {
                Cross.color = Color.white;
                if (Input.GetMouseButton(0))
                {
                    Ecza.GetComponent<Animator>().Play("EczaAnim");

                }
            }
            if (hit.distance <= Range && hit.collider.gameObject.tag == "Kome")
            {
                Cross.color = Color.white;
                if (Input.GetMouseButton(0))
                {
                    Komo.GetComponent<Animator>().Play("KomAnim");
                    audioSource1.clip = drawerOpen;
                    audioSource1.Play();
                    Komo.transform.gameObject.tag = "Untagged";

                }
            }
        }
    }
}



