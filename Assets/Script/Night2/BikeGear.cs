using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class BikeGear : MonoBehaviour
{
    public DialogueTrigger[] trigs;
    bool enter = false;
    bool item = false;
    DialogueTrigger trig;
    public elevatorMiss[] elevatorMisses;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enter == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (item == false)
                {
                    trig = trigs[0];
                    trig.TriggerDialogue();
                    item = true;
                }
                else
                {
                    trig = trigs[1];
                    trig.TriggerDialogue();
                }
            }
        }

        if (item == true)
        {
            elevatorMiss el1 = elevatorMisses[0];
            elevatorMiss el2 = elevatorMisses[1];
            el1.getGear();
            el2.getGear();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        enter = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        enter=false;
    }

}
