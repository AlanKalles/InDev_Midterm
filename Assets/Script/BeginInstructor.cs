using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginInstructor : MonoBehaviour
{
    DialogueTrigger trigger;
    // Start is called before the first frame update
    void Start()
    {
        trigger = this.GetComponent<DialogueTrigger>();
        trigger.TriggerDialogue();
    }
}
