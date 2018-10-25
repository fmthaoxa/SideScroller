using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    private static bool playerExist;
    private Vector2 moveInput;
    private Rigidbody2D myRigibody;
    //   private CircleCollider2D myCollider;
    private Animator myAnimator;
   // private bool playerAttack;


    // Use this for initialization
    void Start () {
      //  myCollider = GetComponent<CircleCollider2D>();
        myRigibody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();

        if (!playerExist)
        {
            playerExist = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else {
            Destroy(gameObject);
        }
        
	}
	
	// Update is called once per frame
	void Update () {
        moveInput = new Vector2(/*Input.GetAxisRaw("Horizontal")*/0f, Input.GetAxisRaw("Vertical")).normalized;

        if (Input.GetKeyDown(KeyCode.J)) {
            //  playerAttack = true;
            myAnimator.SetBool("Attack", true);
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            //  playerAttack = true;
            myAnimator.SetBool("Attack", false);
        }



        if (moveInput != Vector2.zero)
        {
            myRigibody.velocity = new Vector2(moveInput.x * moveSpeed, moveInput.y * moveSpeed);
            //playerMoving = true;
           // lastMove = moveInput;
        }
        else
        {
            myRigibody.velocity = Vector2.zero;
        }

    }
}

