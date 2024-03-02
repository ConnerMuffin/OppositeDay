using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundArt : MonoBehaviour
{
    public GameObject tutorialLevelArt;
    public GameObject level1Art;
    public GameObject level2Art;
    public GameObject level3Art;
    public GameObject level4Art;
    public GameObject level5Art;
    private GameObject completedLevel;
    public bool tutorialLevel;
    public bool level1;
    public bool level2;
    public bool level3;
    public bool level4;
    public bool level5;
    void Update()
    { 
        if(level5 == true)
        {
            completedLevel = level5Art;
        }
        else if(level4 == true)
        {
            completedLevel = level4Art;
        }
        else if(level3 == true)
        {
            completedLevel = level3Art;
        }
        else if(level2 == true)
        {
            completedLevel = level2Art;
        }
        else if(level1 == true)
        {
            completedLevel = level1Art;
        }
        else if(tutorialLevel == true)
        {
            completedLevel = tutorialLevelArt;
        }
    }
    void LateUpdate()
    {
        completedLevel.SetActive(true);
    }
}
