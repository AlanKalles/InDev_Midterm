using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTurnOnTrigger : MonoBehaviour
{
    DialogueTrigger trig;
    bool ent = false;
    // Start is called before the first frame update
    void Start()
    {
        trig = GetComponent<DialogueTrigger>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (ent == true)
            {
                trig.TriggerDialogue();
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ent = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ent = false;
    }
}
