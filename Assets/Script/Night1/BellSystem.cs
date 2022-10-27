using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BellSystem : MonoBehaviour
{

    bool enableCheck = false;
    public AudioSource ringBell;
    public AudioSource catBell;
    bool enter = false;
    public DialogueTrigger[] trig;
    Animator myAnim;
    public oldManEvent oe;
    bool talked = false;

    // Start is called before the first frame update
    void Start()
    {

        
        myAnim = this.GetComponent<Animator>();
        myAnim.SetTrigger("isIdle");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.R) && enableCheck == true)
        {
            ringBell.Play();
            catBell.Play();
        }

        if (enter == true && Input.GetKeyDown(KeyCode.E))
        {
            if (talked == false)
            {
                trig[0].TriggerDialogue();
                oe.catCheck();
                this.transform.position = new Vector3(57.71f, -5.478f, 0);
                talked = true;
            }
            else
            {
                trig[1].TriggerDialogue();
            }
        }


    }


    public void enableBell()
    {
        enableCheck = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            enter = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            enter = false;
        }

    }

}
