using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climb : MonoBehaviour
{
    CharacterMovement playerCM;
    // Start is called before the first frame update
    void Start()
    {
        playerCM = GetComponentInChildren<CharacterMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "ladder")
        {
            playerCM.climbDetector(true);
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "ladder")
        {
            playerCM.climbDetector(false);
        }
    }
}
