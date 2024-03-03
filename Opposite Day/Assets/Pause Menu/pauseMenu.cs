using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    Movement movementscript;
    public GameObject PauseMenuCanvas;
    [SerializeField] GameObject player;
    void Awake()
    {
        movementscript = player.GetComponent<Movement>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            movementscript.enabled = false;
            PauseMenuCanvas.SetActive(true);
        }
    }
}
