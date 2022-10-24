using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatToyGet : MonoBehaviour
{
    public oldManEvent dme;
    bool enter = false;
    bool getItem = false;
    public DialogueTrigger[] trigs;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enter)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                if (getItem == false)
                {
                    dme.cattoyCheck();
                    getItem = true;
                    DialogueTrigger trig = trigs[0];
                    trig.TriggerDialogue();
                    anim.SetBool("isOpened", true);
                }
                else
                {
                    DialogueTrigger trig = trigs[1];
                    trig.TriggerDialogue();
                }

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        enter = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        enter = false;
    }
}
