using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button tapToPlayButton;
    // Start is called before the first frame update

    public void TapToPlay()
    {
        SceneManager.LoadScene("Prototype 1");
    }
}
