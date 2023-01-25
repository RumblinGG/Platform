using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AnimationBehavior : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if ((Input.GetMouseButtonDown(0))|| (Input.GetKeyDown(KeyCode.S)))
        {    
            anim.Play("PickUp");
            anim.Play("PickDown");
        }
        else 
        {
        anim.SetBool("Pick",false);  
        }
        
    }
}
