using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{

    public GameObject btn_Red, btn_Green, btn_Blue, img_Colors, UISound, btn_StartStopCube, the_Cube;

    private void Start()
    {
        btn_Red.GetComponent<Button>().onClick.AddListener(call: btn_Red_Click);
        btn_Green.GetComponent<Button>().onClick.AddListener(call: btn_Green_Click);
        btn_Blue.GetComponent<Button>().onClick.AddListener(call: btn_Blue_Click);
        btn_StartStopCube.GetComponent<Button>().onClick.AddListener(() => btn_StartStopCube_Click(btn_StartStopCube));
        the_Cube.GetComponent<Animator>().enabled = false;
    }

    private void btn_StartStopCube_Click(GameObject btn)
    {
        if (the_Cube.GetComponent<Animator>().enabled)
        {
            the_Cube.GetComponent<Animator>().enabled = false;
            btn.GetComponentInChildren<Text>().text = "Start cube";
        }
        else
        {
            the_Cube.GetComponent<Animator>().enabled = true;
            btn.GetComponentInChildren<Text>().text = "Stop cube";
        }
    }

    private void btn_Red_Click()
    {
        img_Colors.GetComponent<Image>().color = Color.red;
        UISound.GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Sounds/UI/Spacey Click_Minimal UI Sounds"));
    }

    private void btn_Green_Click()
    {
        img_Colors.GetComponent<Image>().color = Color.green;
        UISound.GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Sounds/UI/Spacey Click_Minimal UI Sounds"));
    }

    private void btn_Blue_Click()
    {
        img_Colors.GetComponent<Image>().color = Color.blue;
        UISound.GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Sounds/UI/Spacey Click_Minimal UI Sounds"));
    }
}