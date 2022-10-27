using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTrap : MonoBehaviour
{
    int downTime;
    public float distance;
    Vector3 originalPos;
    // Start is called before the first frame update
    void Start()
    {
        downTime = 0;
        originalPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (downTime > 10 && this.transform.position.y > originalPos.y - distance)
        {
            this.transform.position -= new Vector3(0f, 0.4f, 0f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            this.transform.position -= new Vector3(0f, 0.2f, 0f);
            downTime += 1;
        }
    }


}
