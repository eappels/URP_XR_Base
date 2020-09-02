using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{

    public GameObject btn_Red, btn_Green, btn_Blue, img_Colors, UISound;

    private void Start()
    {
        btn_Red.GetComponent<Button>().onClick.AddListener(call: btn_Red_Click);
        btn_Green.GetComponent<Button>().onClick.AddListener(call: btn_Green_Click);
        btn_Blue.GetComponent<Button>().onClick.AddListener(call: btn_Blue_Click);
    }

    private void btn_Red_Click()
    {
        img_Colors.GetComponent<Image>().color = Color.red;
        UISound.GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Sounds/Spacey Click_Minimal UI Sounds"));
    }

    private void btn_Green_Click()
    {
        img_Colors.GetComponent<Image>().color = Color.green;
        UISound.GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Sounds/Spacey Click_Minimal UI Sounds"));
    }

    private void btn_Blue_Click()
    {
        img_Colors.GetComponent<Image>().color = Color.blue;
        UISound.GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Sounds/Spacey Click_Minimal UI Sounds"));
    }
}