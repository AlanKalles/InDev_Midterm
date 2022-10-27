using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class oldManEvent : MonoBehaviour
{
    public DialogueTrigger[] trigs;
    DialogueTrigger trig;
    bool enter = false;
    bool item = false;
    bool afterItem = false;
    bool talkOnce = false;
    bool cat = false;
    GameObject player;
    bool goback = false;
    public BellSystem bellSystem;
    public SceneChanger changer;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");

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
                    bellSystem.enableBell();
                }
                else if (item == true && afterItem == true)
                {
                    trig = trigs[2];
                    trig.TriggerDialogue();
                }
                else if (cat == true)
                {
                    trig = trigs[4];
                    trig.TriggerDialogue();
                    goback = true;
                }
                else
                {
                    trig = trigs[0];
                    trig.TriggerDialogue();
                    talkOnce = true;
                }
            }
        }
        if (this.transform.position.x - player.transform.position.x > 0)
        {
            this.transform.localScale = new Vector3(1, 1, 1)
;        }
        else if (this.transform.position.x - player.transform.position.x < 0)
        {
            this.transform.localScale = new Vector3(-1, 1, 1);
        }

        if (goback == true && Input.GetKeyDown(KeyCode.T))
        {
            changer.SceneChange();
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

    public void catCheck()
    {
        cat = true;
    }
}
