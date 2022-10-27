using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class elevatorSystem : MonoBehaviour
{

    bool enterE = false;
    public Animator anim;
    GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
    }

    private void Update()
    {
        if (enterE == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetTrigger("isE");
                Debug.Log("moving");
            }
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "player")
        {
            enterE = true;
        }


    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "player")
        {
            enterE = false;
        }
    }


}
