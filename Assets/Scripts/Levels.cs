using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Levels : MonoBehaviour
{
    public GameObject MainMenuCanvas;
    public GameObject AboutCanvas;
    public GameObject LevelCanvas;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Level1()
    {   
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
    }

     public void Level2()
    {   
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level2");
    }

     public void Level3()
    {   
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level3");
    }

     public void BackButton()
    {
        MainMenuCanvas.SetActive(true);
        LevelCanvas.SetActive(false);
    }
}
