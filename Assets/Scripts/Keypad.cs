using UnityEngine;
using UnityEngine.UI;
using StarterAssets;

public class Keypad : MonoBehaviour
{
    public LevelDoor doorToOpen;
    public GameObject keypadUI;

    public Text passwordText;
    public string password = "123";

    public FirstPersonController playerScript;

    public void Start()
    {
        keypadUI.SetActive(false);
        ResetPassword();
    }
    private void Update()
    {
        if(keypadUI.activeInHierarchy && Input.GetKeyDown(KeyCode.Escape))
        {
            keypadUI.SetActive(false);
            Cursor.visible = false;
            playerScript.enabled = true;

        }
    }

    public void OpenKeypadUI(){
        keypadUI.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        playerScript.enabled = false;
    }

    public void KeypadButton(string key)
    {
        passwordText.text = passwordText.text + key;
    }

    public void ResetPassword()
    {
        passwordText.text = "";
    }

    public void CheckPassword()
    {
        if(passwordText.text == password)
        {
            doorToOpen.isLocked = false;
            keypadUI.SetActive(false);
            ResetPassword();
            Cursor.visible = false;
            playerScript.enabled = true;


        }
        else
        {
            ResetPassword();
        }
    }
}
