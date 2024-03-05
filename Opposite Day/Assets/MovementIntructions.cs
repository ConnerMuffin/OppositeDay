using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementIntructions : MonoBehaviour
{
    public GameObject MoveWithAAndD;
    public GameObject JumpWithSpace;
    private bool MovedWithAAndD;
    private bool Jumped;
    void Update()
    {
        if(Input.GetKeyDown("a") || Input.GetKeyDown("d"))
        {
            MovedWithAAndD = true;
        }
        if(Input.GetButtonDown("Jump"))
        {
            Jumped = true;
        }
        if(MovedWithAAndD)
        {
            MoveWithAAndD.SetActive(false);
            JumpWithSpace.SetActive(true);
        }
        if(MovedWithAAndD && Jumped)
        {
            JumpWithSpace.SetActive(false);
        }
    }
}
