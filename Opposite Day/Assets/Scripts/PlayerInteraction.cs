using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    bool triggerActive = false;
    public GameObject exhibitText1;
    public GameObject exhibitText2;
    public GameObject exhibitText3;
    public GameObject exhibitText4;
    int cycle;

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
                exhibitText1.SetActive(false);
                exhibitText2.SetActive(false);
                exhibitText3.SetActive(false);
                exhibitText4.SetActive(false);
                cycle = 1;
            }
        }

        private void Update()
        {
            if (triggerActive && Input.GetKeyDown(KeyCode.Space))
            {
                if (cycle == 1)
                {
                    exhibitText1.SetActive(true);
                    cycle += 1;
                }
                if (cycle == 2)
                {
                    exhibitText1.SetActive(true);
                    cycle += 2;
                }
                if (cycle == 3)
                {
                    exhibitText1.SetActive(true);
                    cycle += 3;
                }
                if (cycle == 4)
                {
                    exhibitText1.SetActive(true);
                    cycle = 1;
                }
            }
        }
}
