using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oldManEvent : MonoBehaviour
{
    public DialogueTrigger[] trigs;
    DialogueTrigger trig;
    bool enter = false;
    bool item = false;
    bool afterItem = false;
    bool talkOnce = false;
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
                if (item == false && talkOnce == true)
                {
                    trig = trigs[3];
                    trig.TriggerDialogue();
                }
                else if (item == true && afterItem == false)
                {
                    trig = trigs[1];
                    trig.TriggerDialogue();
                    afterItem = true;
                }
                else if (item == true && afterItem == true)
                {
                    trig = trigs[2];
                    trig.TriggerDialogue();
                }
                else
                {
                    trig = trigs[0];
                    trig.TriggerDialogue();
                    talkOnce = true;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        enter = true;    
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        enter = false;
    }

    public void cattoyCheck()
    {
        item = true;
    }
}
