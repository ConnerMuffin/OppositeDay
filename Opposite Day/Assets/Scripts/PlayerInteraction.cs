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
    public GameObject exhibitText5;
    int cycle;
    public int maxCycle;

        public void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                triggerActive = true;
                Debug.Log("Collided") ;
            }
        }
        public void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                Debug.Log("Uncollided");
                triggerActive = false;
                exhibitText1.SetActive(false);
                exhibitText2.SetActive(false);
                exhibitText3.SetActive(false);
                exhibitText4.SetActive(false);
                exhibitText5.SetActive(false);
                cycle = 1;
            }
        }
        private void Update()
        {
            if (triggerActive && Input.GetKeyDown(KeyCode.Space))
            {
                exhibitText1.SetActive(false);
                exhibitText2.SetActive(false);
                exhibitText3.SetActive(false);
                exhibitText4.SetActive(false);
                exhibitText5.SetActive(false);
                if (cycle == 5)
                {
                    exhibitText5.SetActive(true);
                    cycle += 1;
                }
                else if (cycle == 4)
                {
                    exhibitText4.SetActive(true);
                    cycle += 1;
                }
                else if (cycle == 3)
                {
                    exhibitText3.SetActive(true);
                    cycle += 1;
                }
                else if (cycle == 2)
                {
                    exhibitText2.SetActive(true);
                    cycle += 1;
                }
                else if (cycle == 1)
                {
                    exhibitText1.SetActive(true);
                    cycle += 1;
                }
            }
            if (cycle >= maxCycle)
            {
                cycle = 1;
            }
        }
}
