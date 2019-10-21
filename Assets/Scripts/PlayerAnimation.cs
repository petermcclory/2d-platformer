using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    public Animator animator;

    float myDirection = 0f; // set up a player direction variable (going to be based on input)
    Vector3 theScale;

    // Update is called once per frame
    void Update()
    {

        myDirection = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Horizontal", myDirection); // Use the float value to determine the animation to play.

        theScale = transform.localScale;

        if ((myDirection < 0) & (theScale.x > 0)) // If Player is moving LEFT and is flipped RIGHT
        {
            theScale.x *= -1;
            transform.localScale = theScale;
            Debug.Log("LEFT " + theScale); // print out theScale in the Unity Console
        }
        else if ((myDirection > 0) & (theScale.x < 0)) // If Player is moving RIGHT and is flipped LEFT
        {
            theScale.x *= -1;
            transform.localScale = theScale;
            Debug.Log("RIGHT " + theScale); // print out theScale in the Unity Console
        }

    }

   

}
