using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    bool triggerActive = false;
    public GameObject exhibitText;

        public void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Exhibit"))
            {
                triggerActive = true;
            }
        }

        public void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                triggerActive = false;
                exhibitText.SetActive(false);
            }
        }

        private void Update()
        {
            if (triggerActive && Input.GetKeyDown(KeyCode.Space))
            {
                exhibitText.SetActive(true);
            }
        }
}
