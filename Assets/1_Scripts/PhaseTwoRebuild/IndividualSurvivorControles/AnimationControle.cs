using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControle : MonoBehaviour
{
    private Animator ani;
    private bool setOnce = true;
    [SerializeField] public ModelMouseManager controler; // for now it is mouse only but will likely expand beyond 3 buttons later
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    // quick animation instruction individual animations need to be set to a loop not in the controler the animation ex Rinning (1)
    // set with trigger runs through the whole animation then to the next
    // be sure to set the bool from the controler back to false or rappid looping will occure
    // when using triggers for an ation its best to trigger from the any state then all roads lead back to the idle
    void Update()
    {
        Vector3 CharacterWithoutY = new Vector3(transform.position.x, 0, transform.position.z);
        Vector3 MoveToWithoutY = new Vector3(controler.MoveTo.transform.position.x, 0, controler.MoveTo.transform.position.z);
        if (setOnce)
        {
            if (Vector3.Distance(CharacterWithoutY, MoveToWithoutY) < 0.01f)
            {
                setOnce = false;
                controler.idle = true;
            }
        }
        else if (Vector3.Distance(CharacterWithoutY, MoveToWithoutY) > 0.01f)
        {
            setOnce = true; // should rapidly reset setOnce but not idle
        }

        if(controler.Awesomeness)
        {
            Awesomeness();
        }
        else if (controler.running)
        {
            Move();
        }
        else if (controler.attacking)
        {
            Attack();
        }
        else if (controler.idle)
        {
            Idle();
        }
        AllFalse();
    }
    private void AllFalse()
    {
        controler.attacking = false;
        controler.running = false;
        controler.idle = false;
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
    private void Awesomeness()
    {
        ani.SetTrigger("Awesomeness");
        BetweenPhaseData.WasThereAwesomness = true;
        controler.Awesomeness = false;
    }
}
