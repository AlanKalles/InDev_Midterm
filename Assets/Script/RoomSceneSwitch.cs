using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RoomSceneSwitch : MonoBehaviour
{
    private int clickNumber;
    public GameObject gb;
    public List<Sprite> sprites;
    SceneChanger changer;
    DialogueTrigger trigger;

    public void Start()
    {
        clickNumber = 0;
        changer = this.GetComponent<SceneChanger>();
        trigger = this.GetComponent<DialogueTrigger>();
        trigger.TriggerDialogue();
    }
    public void counterPlus()
    {
        clickNumber++;
    }

    public void Update()
    {
        if (clickNumber == 3)
        {
            gb.GetComponent<SpriteRenderer>().sprite = sprites[0];
        }

        if (clickNumber == 6)
        {
            gb.GetComponent <SpriteRenderer>().sprite = sprites[1];
        }
        
        if (clickNumber == 9)
        {
            StartCoroutine(wait());
        }
    }

    IEnumerator wait()
    {
         yield return new WaitForSeconds(0.75f);
         changer.SceneChange();
    }

}
