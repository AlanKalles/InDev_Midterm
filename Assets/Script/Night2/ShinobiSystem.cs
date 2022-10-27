using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShinobiSystem : MonoBehaviour
{
    public DialogueTrigger[] trigs;
    DialogueTrigger trig;
    bool enter = false;
    int talk = 0;
    public DoorKey key;
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
                if (talk == 1)
                {
                    trig = trigs[1];
                    trig.TriggerDialogue();
                    talk = 2;
                    StartCoroutine(Disappear());
                    key.getkey();
                }
                else
                {
                    trig = trigs[0];
                    trig.TriggerDialogue();
                    talk = 1;

                }
            }
        }
        if (talk == 1)
        {
            StartCoroutine(Disappear());
        }
    }

    IEnumerator Disappear()
    {
        yield return new WaitForSeconds(3f);
        if (talk == 1)
        {
            this.transform.position = new Vector3(169, 51.503f, 0);
        }
        else
        {
            this.transform.position = new Vector3(159.81f, 12.84f, 0);
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

}
