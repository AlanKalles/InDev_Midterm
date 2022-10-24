using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class photo : MonoBehaviour
{
    bool enter = false;
    bool item = false;
    DialogueTrigger trig;
    public ShinobiSystem shinobiSystem;
    SpriteRenderer sr;
    public Sprite sp;
    // Start is called before the first frame update
    void Start()
    {
        trig = GetComponent<DialogueTrigger>();
        sr = GetComponent<SpriteRenderer>();
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
                    trig.TriggerDialogue();
                    item = true;
                }
                else
                {
                    sr.sprite = sp;
                    this.gameObject.tag = "Untagged";
                }
            }
        }

        if (item == true)
        {
            shinobiSystem.catphotoCheck();
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
