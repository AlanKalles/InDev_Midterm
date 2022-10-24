using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NoticeSign : MonoBehaviour 
{
    GameObject ob;
    Transform trans;
    public Vector3 offset;
    public List<Sprite> sps;
    public Vector3 vec;

    private void Start()
    {
        ob = GameObject.FindGameObjectWithTag("player");
        trans=ob.transform;
        
    }
    private void Update()
    {
        trans = ob.transform;
    }

    public void signPop(int index)
    {
        SpriteRenderer spriteRenderer = this.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sps[index];
        this.transform.position = trans.position + offset;
    }

    public void signDown()
    {
        this.transform.position = vec;
    }

}
