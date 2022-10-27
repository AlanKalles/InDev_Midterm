using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerSign : MonoBehaviour
{
    public NoticeSign notice;
    bool yesSign = false;
    int which;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (yesSign)
        {
            notice.signPop(which);
        }
        else
        {
            notice.signDown();
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.tag == "interactive")
        {
            yesSign = true;
            which = 0;
        }
        if (col.gameObject.tag == "npc" || col.gameObject.tag == "cat")
        {
            yesSign = true;
            which = 2;
        }
        if (col.gameObject.tag == "missitem")
        {
            yesSign = true;
            which = 1;
        }

    }

    private void OnTriggerExit2D(Collider2D col)
    {
        yesSign = false;
    }
}
