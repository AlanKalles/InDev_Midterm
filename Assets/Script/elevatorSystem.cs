using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class elevatorSystem : MonoBehaviour
{

    bool enterE = false;
    public Animator anim;
    private void Start()
    {

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
        enterE = true;

    }

    private void OnTriggerExit2D(Collider2D col)
    {
        enterE=false;
    }


}
