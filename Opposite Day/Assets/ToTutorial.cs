using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTutorial : MonoBehaviour
{
    public string levelName;
    public void changeScene()
    {
        SceneManager.LoadScene(levelName);
    }
}
