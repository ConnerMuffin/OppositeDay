using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionTutorial : MonoBehaviour
{
    public bool has_interacted = false;
    public GameObject tutorial;
    bool triggerActive = false;
     public void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Carpet"))
            {
                triggerActive = true;
            }
        }
        public void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Carpet"))
            {
                triggerActive = false;
            }
        }
        private void Update()
        {
            if (triggerActive && Input.GetKeyDown(KeyCode.Space))
            {
                tutorial.SetActive(false);
            }
        }
}
