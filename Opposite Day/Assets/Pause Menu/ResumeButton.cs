using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeButton : MonoBehaviour
{
    Movement movementscript;
    public GameObject PauseMenuCanvas;
    [SerializeField] GameObject player;
    public void Resume()
    {
            movementscript = player.GetComponent<Movement>();
            movementscript.enabled = true;
            PauseMenuCanvas.SetActive(false);
    }
}
