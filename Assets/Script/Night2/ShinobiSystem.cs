using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShinobiSystem : MonoBehaviour
{
    public DialogueTrigger[] trigs;
    DialogueTrigger trig;
    bool enter = false;
    bool item = false;
    bool afterItem = false;
    bool talkOnce = false;
    public GameObject tube;
    public GameObject elevator;
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
                if (item == false && talkOnce == true)
                {
                    trig = trigs[2];
                    trig.TriggerDialogue();
                }
                else if (item == true && afterItem == false)
                {
                    trig = trigs[1];
                    trig.TriggerDialogue();
                    afterItem = true;
                    key.getkey();
                }
                else
                {
                    trig = trigs[0];
                    trig.TriggerDialogue();
                    talkOnce = true;
                    tube.SetActive(false);
                    elevator.SetActive(true);

                }
            }
        }
        if (afterItem == true)
        {
            StartCoroutine(Disappear());
        }
    }

    IEnumerator Disappear()
    {
        yield return new WaitForSeconds(6f);
        this.transform.position = new Vector3(155, 26, 0);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        enter = true;
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        enter = false;
    }

    public void catphotoCheck()
    {
        item = true;
    }
}
