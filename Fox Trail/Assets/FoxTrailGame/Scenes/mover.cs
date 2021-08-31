using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("FoxWalkFoward", true);
            animator.SetBool("IsFoxWalking", true);
            animator.SetBool("FoxWalkBackward", false);
            animator.SetBool("FoxWalkLeft", false);
            animator.SetBool("FoxWalkRight", false);
            animator.SetBool("FoxWalkForwardRight", false);
            animator.SetBool("FoxWalkForwardLeft", false);

        }
        else if (Input.GetKey(KeyCode.DownArrow)) 
        {
            animator.SetBool("FoxWalkBackward", true);
            animator.SetBool("IsFoxWalking", true);
            animator.SetBool("FoxWalkFoward", false);
            animator.SetBool("FoxWalkLeft", false);
            animator.SetBool("FoxWalkRight", false);
            animator.SetBool("FoxWalkForwardRight", false);
            animator.SetBool("FoxWalkForwardLeft", false);

        }
        else if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("FoxWalkLeft", true);
            animator.SetBool("IsFoxWalking", true);
            animator.SetBool("FoxWalkFoward", false);
            animator.SetBool("FoxWalkBackward", false);
            animator.SetBool("FoxWalkRight", false);
            animator.SetBool("FoxWalkForwardRight", false);
            animator.SetBool("FoxWalkForwardLeft", false);


        }
        else if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("FoxWalkRight", true);
            animator.SetBool("IsFoxWalking", true);
            animator.SetBool("FoxWalkFoward", false);
            animator.SetBool("FoxWalkBackward", false);
            animator.SetBool("FoxWalkLeft", false);
            animator.SetBool("FoxWalkForwardRight", false);
            animator.SetBool("FoxWalkForwardLeft", false);

        }
        else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("FoxWalkForwardRight", true);
            animator.SetBool("IsFoxWalking", true);
            animator.SetBool("FoxWalkFoward", false);
            animator.SetBool("FoxWalkBackward", false);
            animator.SetBool("FoxWalkLeft", false);
            animator.SetBool("FoxWalkRight", false);
            animator.SetBool("FoxWalkForwardLeft", false);

        }
        else if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("FoxWalkForwardLeft", true);
            animator.SetBool("IsFoxWalking", true);
            animator.SetBool("FoxWalkFoward", false);
            animator.SetBool("FoxWalkBackward", false);
            animator.SetBool("FoxWalkLeft", false);
            animator.SetBool("FoxWalkRight", false);
            animator.SetBool("FoxWalkForwardRight", false);

        }
        else
        {
            animator.SetBool("FoxWalkFoward", false);
            animator.SetBool("FoxWalkBackward", false);
            animator.SetBool("FoxWalkLeft", false);
            animator.SetBool("FoxWalkRight", false);
            animator.SetBool("IsFoxWalking", false);
            animator.SetBool("FoxWalkForwardRight", false);
            animator.SetBool("FoxWalkForwardLeft", false);


        }
    }



     
}
