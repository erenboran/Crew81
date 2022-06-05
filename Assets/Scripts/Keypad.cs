using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    public LevelDoor doorToOpen;
    public GameObject keypadUI;

    public Text passwordText;
    public string password = "123";

    public void Start()
    {
        keypadUI.SetActive(false);
        ResetPassword();
    }

    public void OpenKeypadUI(){
        keypadUI.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
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
        }
        else
        {
            ResetPassword();
        }
    }
}
