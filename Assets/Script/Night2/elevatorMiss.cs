using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorMiss : MonoBehaviour
{
    bool gear = false;
    elevatorSystem system;

    // Start is called before the first frame update
    void Start()
    {
        system = GetComponent<elevatorSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gear == true)
        {
            gameObject.tag = "interactive";
            system.enabled = true;
        }
    }

    public void getGear()
    {
        gear = true;
    }
}
