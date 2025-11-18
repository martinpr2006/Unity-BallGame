using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject MainMenuCanvas;
    public GameObject AboutCanvas;
    public GameObject LevelCanvas;

    // Start is called before the first frame update
    void Start()
    {
        MainMenuCanvas.SetActive(true);
        AboutCanvas.SetActive(false);
        LevelCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayButton()
    {   
        MainMenuCanvas.SetActive(false);
        LevelCanvas.SetActive(true);
    }

    public void AboutButton()
    {
        MainMenuCanvas.SetActive(false);
        AboutCanvas.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
