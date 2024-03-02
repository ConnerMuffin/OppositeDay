using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabBox : MonoBehaviour
{
    public Transform box;
    public Transform boxPickUp;
    public LayerMask boxLayer;

// Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && Physics2D.OverlapCircle(transform.position, 1f, boxLayer))
        {
            box.position = boxPickUp.position;
        }
    }
}
