using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBox : MonoBehaviour
{
    public Transform respawnObject;
    public int minYValue;

    // Update is called once per frame
    void Update()
    {
        if(respawnObject.transform.position.y < minYValue)
        {
            respawnObject.position = transform.position;
        }
    }
}
