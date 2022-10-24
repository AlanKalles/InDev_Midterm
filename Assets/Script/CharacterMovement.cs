using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveMult;
    float horiMove;
    float vertMove;

    bool grounded = false;
    bool jumping = false;
    bool jump = false;
    public float castDist = 0.55f;

    public float takeoffTime = 0.1f;
    public float jumpLimit = 10f;
    public float gravityScale = 2f;
    public float gravityFall = 5f;

    Rigidbody2D myBody;
    Animator myAnim;
    GameObject myPlayer;
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponentInParent<Animator>();
        myPlayer = GameObject.FindWithTag("player");
        myBody = GetComponentInParent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        horiMove = Input.GetAxis("Horizontal");
        vertMove = Input.GetAxis("Vertical");
        if (Input.GetKeyDown("space") && grounded)
        {
            myAnim.SetTrigger("takeoff");
            StartCoroutine(jumpDelay(takeoffTime));
        }
    }

    private void FixedUpdate()
    {
        horizontalMove(horiMove);

        if (jump)
        {
            myBody.AddForce(Vector2.up * jumpLimit, ForceMode2D.Impulse);
            jump = false;

        }

        if (myBody.velocity.y >= 0 && jumping == true)
        {
            myBody.gravityScale = gravityScale;

        }
        if (myBody.velocity.y < 0 && jumping == true)
        {
            myAnim.SetTrigger("fall");
            myBody.gravityScale = gravityFall;

        }
        if (myBody.velocity.y == 0 && jumping == true)
        {
            jumping = false;
            myAnim.SetTrigger("landed");
        }

        RaycastHit2D hit = Physics2D.Raycast(myPlayer.transform.position, Vector2.down, castDist);
        Debug.DrawRay(myPlayer.transform.position, Vector2.down * castDist, new Color(255, 0, 0));
        if (hit.collider != null && hit.collider.tag == "ground")
        {
            grounded = true;
            Debug.DrawRay(myPlayer.transform.position, Vector2.down * castDist, new Color(0, 255, 0));
        }
        else
        {
            grounded = false;
            Debug.DrawRay(myPlayer.transform.position, Vector2.down * castDist, new Color(0, 0,255));
        }

    }

    IEnumerator jumpDelay(float delaytime)
    {
        yield return new WaitForSeconds(delaytime);
        jump = true;
        jumping = true;

    }

    void horizontalMove(float toMove)
    {
        float moveX = toMove * Time.fixedDeltaTime * moveMult;
        myBody.velocity = new Vector3(moveX, myBody.velocity.y);
        
        if (myBody.velocity.x > 0 || myBody.velocity.x < 0)
        {
            myAnim.SetBool("isRun", true);
            if (myBody.velocity.x > 0)
            {
                myPlayer.transform.localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                myPlayer.transform.localScale = new Vector3(1, 1, 1);
            }
        }
        else
        {
            myAnim.SetBool("isRun", false);
        }
    }
}
