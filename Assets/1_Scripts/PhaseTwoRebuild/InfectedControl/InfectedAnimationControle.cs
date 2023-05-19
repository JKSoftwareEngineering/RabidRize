using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfectedAnimationControle : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator ani;
    private bool setOnce = true;
    private InfectedAI controler;

    void Start()
    {
        ani = GetComponent<Animator>();
        controler = GetComponent<InfectedAI>();
        controler.InfectedIdle = true;
        controler.InfectedAttacking = false;
        controler.InfectedRunning = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (controler.InfectedRunning)
        {
            Move();
        }
        else if (controler.InfectedAttacking)
        {
            Attack();
        }
        else if (controler.InfectedIdle)
        {
            Idle();
        }
        AllFalse();
    }

    private void AllFalse()
    {
        controler.InfectedAttacking = false;
        controler.InfectedRunning = false;
        controler.InfectedIdle = false;
    }
    private void Idle() // infinite looped
    {
        ani.SetTrigger("Idle");
    }
    private void Move() // infinite looped
    {
        ani.SetTrigger("Running");
    }
    private void Attack() // needs transition back to idle
    {
        ani.SetTrigger("Attacking");
    }
}
