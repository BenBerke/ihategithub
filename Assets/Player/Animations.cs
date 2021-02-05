using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{

    public Animator animator;


    void Start()
    {
        
    }

    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {

            animator.SetBool("Yürüme", true);
            
        }

        else 
        {

            animator.SetBool("Yürüme", false);

        }

    }
}
