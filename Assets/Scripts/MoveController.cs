using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{

    //https://my-develop-note.tistory.com/13?category=819292
    public float movementSpeed = 3.0f;
    Vector2 movement = new Vector2();
    Rigidbody2D rigidbody2D;

    Animator animator;
    string animationState = "AnimationState";

    enum States
    {
        side = 1, top = 2
    }
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        UpdateState();
    }
    private void FixedUpdate()
    {
        MoveCharacter();
    }
    private void MoveCharacter()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement.Normalize();

        rigidbody2D.velocity = movement * movementSpeed;
    }

    private void UpdateState()
    {
        if (movement.x>0)
        {
            animator.SetInteger(animationState, (int)States.side);
        }
        if (movement.x < 0)
        {
            animator.SetInteger(animationState, (int)States.side);
        }
        if (movement.y > 0)
        {
            animator.SetInteger(animationState, (int)States.side);
        }
        if (movement.y < 0)
        {
            animator.SetInteger(animationState, (int)States.side);
        }
        else
        {
            animator.SetInteger(animationState, (int)States.top);
        }
    }

}
