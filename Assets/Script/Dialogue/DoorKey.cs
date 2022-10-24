using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class DoorKey : MonoBehaviour
{
    bool key = false;
    bool enter = false;
    DialogueTrigger trig;
    public SceneChanger sc;
    // Start is called before the first frame update
    void Start()
    {
        trig = GetComponent<DialogueTrigger>();
    }

    // Update is called once per frame
    void Update()
    {
        if (key == true)
        {
            this.gameObject.tag = "interactive";
        }
        if (enter == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (key == true)
                {
                    trig.TriggerDialogue();
                    StartCoroutine(Ending());
                }

            }
        }
    }

    IEnumerator Ending()
    {
        yield return new WaitForSeconds(4f);
        sc.SceneChange();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        enter = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        enter = false;
    }

    public void getkey()
    {
        key = true;
    }
}
