using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InfectedObject;

public class InfectedAI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Vector3 thisInfectedActiveTarget;
    private float InfectedActionPointMin = 10000f; //resets to 0
    private float attackTimer = 0;
    public float attackTimerMax = 1.8f;// not very well synched with the animation but it does process all attacks that are in range with a starting actions of 5
    [HideInInspector] public bool InfectedAttacking = false;
    [HideInInspector] public bool InfectedIdle = true;
    [HideInInspector] public bool InfectedRunning = false;
    [HideInInspector] public Infected LocalInfected;
    public int AIsTarget;
    private InfectedManager i;
    private ChangeSelectedMember healthCheck;
    private bool unit1;
    private bool unit2;
    private bool unit3;
    private bool unit4;
    private bool unit5;
    private bool unit6;
    void Start()
    {
        i = GameObject.Find("InfectedContainer").transform.GetChild(2).GetComponent<InfectedManager>();
        healthCheck = GameObject.Find("GameControler").gameObject.GetComponent<ChangeSelectedMember>();
    }

    // Update is called once per frame
    void Update()
    {
        LocalInfected.CheckIfAlive();
        IsThisInfectedAlive(LocalInfected.Alive);
        setTargetsAvailable();
        //--------test--------
        //infectedManagersActiveTarget = i.InfectedManagerTarget;
        //--------------------
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            AIsTarget = LocalattackSequence(unit1, unit2, unit3, unit4, unit5, unit6);
            thisInfectedActiveTarget = SetThisInfectedTarget();
            if (Vector3.Distance(gameObject.transform.position, thisInfectedActiveTarget) > 1f && Vector3.Distance(gameObject.transform.position, thisInfectedActiveTarget) < 61.5f)//10*6.15
            {
                InfectedRunning = true;
            }
            InfectedActionPointMin = 0;
        }
        if (Vector3.Distance(gameObject.transform.position, thisInfectedActiveTarget) > 6f && Vector3.Distance(gameObject.transform.position, thisInfectedActiveTarget) < 61.6f)
        {
            if (InfectedActionPointMin < LocalInfected.ActionPoints)
            {
                gameObject.transform.GetComponent<UnityEngine.AI.NavMeshAgent>().destination = thisInfectedActiveTarget;
                InfectedRunning = true;
            }
            else if (InfectedActionPointMin >= LocalInfected.ActionPoints)
            {
                gameObject.transform.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                InfectedIdle = true;
            }
        }
        else
        {
            gameObject.transform.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
            if (InfectedActionPointMin < LocalInfected.ActionPoints && Vector3.Distance(gameObject.transform.position, thisInfectedActiveTarget) < 61.5f)
            {
                attackTimer += Time.deltaTime;
                if(attackTimer >= attackTimerMax)
                {
                    //need the survivor of character
                    //character is just the body game controler holds the data
                    //need to acess the equivalent survivor data in survivorList found in changeSelectedMember
                    InfectedAttacking = true;
                    TransferDamage();
                    attackTimer = 0f;
                }
            }
            else
            {
                InfectedIdle = true;
            }
        }
    }
    public int InfectedAP()
    {
        return (int)LocalInfected.ActionPoints;
    }
    void IsThisInfectedAlive(bool alive)
    {
        if(!alive)
        {
            Instantiate(i.DeathPrefab, transform.position, transform.rotation);
            healthCheck.ActiveSurvivor.XP += 1;
            Destroy(gameObject);
        }
        else
        {
            transform.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
            InfectedActionPointMin += Time.deltaTime;
        }
    }
    void setTargetsAvailable()
    {
        if (i.Character6.activeInHierarchy && Vector3.Distance(gameObject.transform.position, i.Character6.transform.position) < 61.5f)
        {
            unit6 = true;
        }
        else
        {
            unit6 = false;
        }
        if (i.Character5.activeInHierarchy && Vector3.Distance(gameObject.transform.position, i.Character5.transform.position) < 61.5f)
        {
            unit5 = true;
        }
        else
        {
            unit5 = false;
        }
        if (i.Character4.activeInHierarchy && Vector3.Distance(gameObject.transform.position, i.Character4.transform.position) < 61.5f)
        {
            unit4 = true;
        }
        else
        {
            unit4 = false;
        }
        if (i.Character3.activeInHierarchy && Vector3.Distance(gameObject.transform.position, i.Character3.transform.position) < 61.5f)
        {
            unit3 = true;
        }
        else
        {
            unit3 = false;
        }
        if (i.Character2.activeInHierarchy && Vector3.Distance(gameObject.transform.position, i.Character2.transform.position) < 61.5f)
        {
            unit2 = true;
        }
        else
        {
            unit2 = false;
        }
        if (i.Character1.activeInHierarchy && Vector3.Distance(gameObject.transform.position, i.Character1.transform.position) < 61.5f)
        {
            unit1 = true;
        }
        else
        {
            unit1 = false;
        }
    }
    void TransferDamage()
    {
        if (unit6 && AIsTarget == 6)
        {
            healthCheck.survivorlist[5].ChangeHealth(true, LocalInfected.Damage);
            InfectedActionPointMin += 10000f; // instantly cancel attack to avoid damage bleed to the next survivor
        }
        else if (unit5 && AIsTarget == 5)
        {
            healthCheck.survivorlist[4].ChangeHealth(true, LocalInfected.Damage);
            InfectedActionPointMin += 10000f;
        }
        else if (unit4 && AIsTarget == 4)
        {
            healthCheck.survivorlist[3].ChangeHealth(true, LocalInfected.Damage);
            InfectedActionPointMin += 10000f;
        }
        else if (unit3 && AIsTarget == 3)
        {
            healthCheck.survivorlist[2].ChangeHealth(true, LocalInfected.Damage);
            InfectedActionPointMin += 10000f;
        }
        else if (unit2 && AIsTarget == 2)
        {
            healthCheck.survivorlist[1].ChangeHealth(true, LocalInfected.Damage);
            InfectedActionPointMin += 10000f;
        }
        else if (unit1 && AIsTarget == 1)
        {
            healthCheck.survivorlist[0].ChangeHealth(true, LocalInfected.Damage);
            InfectedActionPointMin += 10000f;
        }
    }
    int LocalattackSequence(bool unit1, bool unit2, bool unit3, bool unit4, bool unit5, bool unit6)
    {
        int attack = 1;

        //all six are active and alive
        if (unit1 && unit2 && unit3 && unit4 && unit5 && unit6)
        {
            attack = (int)Random.Range(1, 7);
        }
        //----------------------------------------------
        //1-5
        else if (unit1 && unit2 && unit3 && unit4 && unit5)
        {
            attack = (int)Random.Range(1, 6);
        }
        //2-6
        else if (unit2 && unit3 && unit4 && unit5 && unit6)
        {
            attack = (int)Random.Range(2, 7);
        }
        //1, 3-6
        else if (unit1 && unit3 && unit4 && unit5 && unit6)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = 1;
            }
            else if (temp == 1)
            {
                attack = (int)Random.Range(3, 7);
            }
        }
        //1-2, 4-6
        else if (unit1 && unit3 && unit4 && unit5 && unit6)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = (int)Random.Range(1, 3);
            }
            else if (temp == 1)
            {
                attack = (int)Random.Range(4, 7);
            }
        }
        //1-3, 5-6
        else if (unit1 && unit3 && unit4 && unit5 && unit6)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = (int)Random.Range(1, 4);
            }
            else if (temp == 1)
            {
                attack = (int)Random.Range(5, 7);
            }
        }
        //1-4, 6
        else if (unit1 && unit3 && unit4 && unit5 && unit6)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = (int)Random.Range(1, 5);
            }
            else if (temp == 1)
            {
                attack = 6;
            }
        }
        //--------------------------------------------
        //1-4
        else if (unit1 && unit2 && unit3 && unit4)
        {
            attack = (int)Random.Range(0, 6);
        }
        //1-3, 5
        else if (unit1 && unit2 && unit3 && unit5)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = (int)Random.Range(1, 4);
            }
            else if (temp == 1)
            {
                attack = 5;
            }
        }
        //1-3, 6
        else if (unit1 && unit2 && unit3 && unit6)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = (int)Random.Range(1, 4);
            }
            else if (temp == 1)
            {
                attack = 6;
            }
        }
        //1-2, 4-5
        else if (unit1 && unit2 && unit4 && unit5)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = (int)Random.Range(1, 3);
            }
            else if (temp == 1)
            {
                attack = (int)Random.Range(4, 6);
            }
        }
        //1-2, 4, 6
        else if (unit1 && unit2 && unit4 && unit6)
        {
            int temp = (int)Random.Range(0, 3);
            if (temp == 0)
            {
                attack = (int)Random.Range(1, 3);
            }
            else if (temp == 1)
            {
                attack = 4;
            }
            else if (temp == 2)
            {
                attack = 6;
            }
        }
        //1, 3-5
        else if (unit1 && unit3 && unit4 && unit5)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = 1;
            }
            else if (temp == 1)
            {
                attack = (int)Random.Range(3, 6);
            }
        }
        //1, 3-4, 6
        else if (unit1 && unit3 && unit4 && unit6)
        {
            int temp = (int)Random.Range(0, 3);
            if (temp == 0)
            {
                attack = 1;
            }
            else if (temp == 1)
            {
                attack = (int)Random.Range(3, 5);
            }
            else if (temp == 2)
            {
                attack = 6;
            }
        }
        //1, 3, 5-6
        else if (unit1 && unit3 && unit5 && unit6)
        {
            int temp = (int)Random.Range(0, 3);
            if (temp == 0)
            {
                attack = 1;
            }
            else if (temp == 1)
            {
                attack = 3;
            }
            else if (temp == 2)
            {
                attack = (int)Random.Range(5, 7);
            }
        }
        //2-5
        else if (unit2 && unit3 && unit4 && unit5)
        {
            attack = Random.Range(2, 6);
        }
        //2-4, 6
        else if (unit2 && unit3 && unit4 && unit6)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = (int)Random.Range(2, 5);
            }
            else if (temp == 1)
            {
                attack = 6;
            }
        }
        //2-3 5-6
        else if (unit2 && unit3 && unit5 && unit6)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = 2;
            }
            else if (temp == 1)
            {
                attack = (int)Random.Range(4, 7);
            }
        }
        //2, 4-6
        else if (unit2 && unit4 && unit5 && unit6)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = 2;
            }
            else if (temp == 1)
            {
                attack = (int)Random.Range(4, 7);
            }
        }
        //3-6
        else if (unit3 && unit4 && unit5 && unit6)
        {
            attack = (int)Random.Range(1, 7);
        }
        //-----------------------------------------
        //1-3
        else if (unit1 && unit2 && unit3)
        {
            attack = (int)Random.Range(1, 4);
        }
        //1-2, 4
        else if (unit1 && unit2 && unit3)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = (int)Random.Range(1, 3);
            }
            else if (temp == 1)
            {
                attack = 4;
            }
        }
        //1-2, 5
        else if (unit1 && unit2 && unit3)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = (int)Random.Range(1, 3);
            }
            else if (temp == 1)
            {
                attack = 5;
            }
        }
        //1-2, 6
        else if (unit1 && unit2 && unit6)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = (int)Random.Range(1, 3);
            }
            else if (temp == 1)
            {
                attack = 6;
            }
        }
        //1, 3-4
        else if (unit1 && unit3 && unit4)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = 1;
            }
            else if (temp == 1)
            {
                attack = (int)Random.Range(3, 5);
            }
        }
        //1, 3, 5
        else if (unit1 && unit3 && unit5)
        {
            int temp = (int)Random.Range(0, 3);
            if (temp == 0)
            {
                attack = 1;
            }
            else if (temp == 1)
            {
                attack = 3;
            }
            else if (temp == 2)
            {
                attack = 5;
            }
        }
        //1, 3, 6
        else if (unit1 && unit3 && unit6)
        {
            int temp = (int)Random.Range(0, 3);
            if (temp == 0)
            {
                attack = 1;
            }
            else if (temp == 1)
            {
                attack = 3;
            }
            else if (temp == 2)
            {
                attack = 6;
            }
        }
        //1, 4-5
        else if (unit1 && unit4 && unit5)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = 1;
            }
            else if (temp == 1)
            {
                attack = (int)Random.Range(4, 6);
            }
        }
        //1, 4, 6
        else if (unit1 && unit4 && unit6)
        {
            int temp = (int)Random.Range(0, 3);
            if (temp == 0)
            {
                attack = 1;
            }
            else if (temp == 1)
            {
                attack = 4;
            }
            else if (temp == 2)
            {
                attack = 6;
            }
        }
        //2-4
        else if (unit2 && unit3 && unit4)
        {
            attack = (int)Random.Range(2, 5);
        }
        //2-3, 5
        else if (unit2 && unit3 && unit5)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = (int)Random.Range(2, 4);
            }
            else if (temp == 1)
            {
                attack = 5;
            }
        }
        //2-3, 6
        else if (unit2 && unit3 && unit6)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = (int)Random.Range(2, 4);
            }
            else if (temp == 1)
            {
                attack = 6;
            }
        }
        //2, 4-5
        else if (unit2 && unit4 && unit5)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = 2;
            }
            else if (temp == 1)
            {
                attack = (int)Random.Range(4, 6);
            }
        }
        //2, 4, 6
        else if (unit2 && unit4 && unit6)
        {
            int temp = (int)Random.Range(0, 3);
            if (temp == 0)
            {
                attack = 2;
            }
            else if (temp == 1)
            {
                attack = 4;
            }
            else if (temp == 2)
            {
                attack = 6;
            }
        }
        //3-5
        else if (unit3 && unit4 && unit5)
        {
            attack = (int)Random.Range(3, 6);
        }
        //3, 5-6
        else if (unit2 && unit4 && unit5)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = 3;
            }
            else if (temp == 1)
            {
                attack = (int)Random.Range(5, 7);
            }
        }
        //4-6
        else if (unit3 && unit4 && unit5)
        {
            attack = (int)Random.Range(4, 7);
        }
        //------------------------------------------
        //1-2
        else if (unit1 && unit2)
        {
            attack = (int)Random.Range(1, 3);
        }
        //1, 3
        else if (unit1 && unit3)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = 1;
            }
            else if (temp == 1)
            {
                attack = 3;
            }
        }
        //1, 4
        else if (unit1 && unit4)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = 1;
            }
            else if (temp == 1)
            {
                attack = 4;
            }
        }
        //1, 5
        else if (unit1 && unit5)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = 1;
            }
            else if (temp == 1)
            {
                attack = 5;
            }
        }
        //1, 6
        else if (unit1 && unit6)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = 1;
            }
            else if (temp == 1)
            {
                attack = 6;
            }
        }
        //2-3
        else if (unit2 && unit3)
        {
            attack = (int)Random.Range(2, 4);
        }
        //2, 4
        else if (unit2 && unit4)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = 2;
            }
            else if (temp == 1)
            {
                attack = 4;
            }
        }
        //2, 5
        else if (unit2 && unit5)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = 2;
            }
            else if (temp == 1)
            {
                attack = 5;
            }
        }
        //2, 6
        else if (unit2 && unit6)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = 2;
            }
            else if (temp == 1)
            {
                attack = 6;
            }
        }
        //3-4
        else if (unit3 && unit4)
        {
            attack = (int)Random.Range(3, 5);
        }
        //3, 5
        else if (unit3 && unit5)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = 3;
            }
            else if (temp == 1)
            {
                attack = 5;
            }
        }
        //3, 6
        else if (unit3 && unit6)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = 3;
            }
            else if (temp == 1)
            {
                attack = 6;
            }
        }
        //4-5
        else if (unit4 && unit5)
        {
            attack = (int)Random.Range(4, 6);
        }
        //4, 6
        else if (unit4 && unit6)
        {
            int temp = (int)Random.Range(0, 2);
            if (temp == 0)
            {
                attack = 4;
            }
            else if (temp == 1)
            {
                attack = 6;
            }
        }
        //5-6
        else if (unit5 && unit6)
        {
            attack = (int)Random.Range(5, 6);
        }
        //------------------------------------
        //1
        else if (unit1)
        {
            attack = 1;
        }
        //2
        else if (unit2)
        {
            attack = 2;
        }
        //3
        else if (unit3)
        {
            attack = 3;
        }
        //4
        else if (unit4)
        {
            attack = 5;
        }
        //5
        else if (unit5)
        {
            attack = 5;
        }
        //6
        else if (unit6)
        {
            attack = 6;
        }
        return attack;
    }
    Vector3 SetThisInfectedTarget()
    {
        if (AIsTarget == 1)
        {
            return i.Character1.transform.position;
        }
        if (AIsTarget == 2)
        {
            return i.Character2.transform.position;
        }
        if (AIsTarget == 3)
        {
            return i.Character3.transform.position;
        }
        if (AIsTarget == 4)
        {
            return i.Character4.transform.position;
        }
        if (AIsTarget == 5)
        {
            return i.Character5.transform.position;
        }
        if (AIsTarget == 6)
        {
            return i.Character6.transform.position;
        }
        else
        {
            return new Vector3(0, 0, 0);
        }
    }
}
