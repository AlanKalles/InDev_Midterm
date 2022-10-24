using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerSign : MonoBehaviour
{
    public NoticeSign notice;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "interactive")
        {
            notice.signPop(0);
        }
        if (col.gameObject.tag == "npc")
        {
            notice.signPop(2);
        }
        if (col.gameObject.tag == "missitem")
        {
            notice.signPop(1);
        }

    }

    private void OnTriggerExit2D(Collider2D col)
    {
        notice.signDown();
    }
}
