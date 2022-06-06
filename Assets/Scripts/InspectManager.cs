using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StarterAssets;

public class InspectManager : MonoBehaviour
{
    public Image Cross;
    public float distance;
    public Transform playerSocket;
    public GameObject crossImage;
    public GameObject inspectCanvas;
    public Text objectText;

    Vector3 originalPos;
    bool onInspect = false;
    GameObject inspected;


    public FirstPersonController playerScript;

    private void Start()
    {
        inspectCanvas.SetActive(false);
    }
    private void Update()
    {

        Vector3 ffwd = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        //Cross.color = Color.red;

        if (Physics.Raycast(transform.position, ffwd, out hit, distance))
        {
            Debug.DrawLine(transform.position, hit.point, Color.blue);
            if (hit.transform.CompareTag("Object") && !onInspect)
            {
                Cross.color = Color.yellow;
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    inspected = hit.transform.gameObject;
                    originalPos = hit.transform.position;
                    onInspect = true;
                    crossImage.SetActive(false);
                    inspectCanvas.SetActive(true);

                    StartCoroutine(puckupItem());
                }
            }
        }

        if(onInspect)
        {
            inspected.transform.position = Vector3.Lerp(inspected.transform.position, playerSocket.position, 0.2f);
            playerSocket.Rotate(new Vector3(Input.GetAxis("Mouse Y"), -Input.GetAxis("Mouse X"), 0) * Time.deltaTime * 125f);
        }
        else if(inspected != null)
        {
            inspected.transform.SetParent(null);
            inspected.transform.position = Vector3.Lerp(inspected.transform.position, originalPos, 0.2f);
        }

        if(Input.GetKeyDown(KeyCode.Mouse1) && onInspect)
        {
            StartCoroutine(dropItem());
            onInspect = false;
            crossImage.SetActive(true);
            inspectCanvas.SetActive(false);

        }
    }

    IEnumerator puckupItem()
    {
        playerScript.enabled = false;
        yield return new WaitForSeconds(0.2f);
        inspected.transform.SetParent(playerSocket);
    }

    IEnumerator dropItem()
    {
        inspected.transform.rotation = Quaternion.identity;
        yield return new WaitForSeconds(0.2f);
        playerScript.enabled = true;
    }
}
