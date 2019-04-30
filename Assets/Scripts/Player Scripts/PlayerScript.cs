using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class PlayerScript : MonoBehaviour
{

    public float moveForce = 20f;
    public float jumpForce = 600f;
    public float maxVelocity = 4f;

    private bool grounded = true;
    
    private Rigidbody2D myBody;
    private Animator anim;

    void Awake()
    {
        InitializeVariables();
    }
    
    void FixedUpdate()
    {
        PlayerWalkKeyboard();
    }

    void InitializeVariables()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void PlayerWalkKeyboard()
    {
        float forceX = 0f;
        float forceY = 0f;

        float vel = Mathf.Abs(myBody.velocity.x);

        float h = Input.GetAxisRaw("Horizontal");

        //if we are holding the right key
        if (h > 0)
        {
            if (vel < maxVelocity)
            {
                forceX = moveForce;
            }

            Vector3 scale = transform.localScale;
            scale.x = 1f; //moving in the right direction
            transform.localScale = scale;
            
            anim.SetBool("Walk", true); //start the walk animation
        }
        //if we are holding the left key
        else if (h < 0)
        {
            if (vel < maxVelocity)
            {
                forceX = -moveForce;
            }

            Vector3 scale = transform.localScale;
            scale.x = -1f; //moving in the left direction
            transform.localScale = scale;
            
            anim.SetBool("Walk", true); //start the walk animation

        }

        else if (h == 0)
        {
            anim.SetBool("Walk", false); //end the walk animation and start the idle animation
        }
        
        if (Input.GetKey(KeyCode.Space))
        {
            if (grounded)
            {
                grounded = false;
                forceY = jumpForce;
            }
        }
        
        myBody.AddForce(new Vector2(forceX, forceY));
        
    }

    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }

    public void BouncePlayerWithBouncy(float force)
    {
        if (grounded)
        {
            grounded = false;
        }
        
        myBody.AddForce( new Vector2(0, force));
        
    }
}
