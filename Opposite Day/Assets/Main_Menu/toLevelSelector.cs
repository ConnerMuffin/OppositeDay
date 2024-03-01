using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toLevelSelector : MonoBehaviour
{
    public string levelName;
    public GameObject LevelSelectCanvas;
    public GameObject MainMenuCanvas;
    public void changeScene()
    {
        LevelSelectCanvas.SetActive(true);
        MainMenuCanvas.SetActive(false);
    }
}
