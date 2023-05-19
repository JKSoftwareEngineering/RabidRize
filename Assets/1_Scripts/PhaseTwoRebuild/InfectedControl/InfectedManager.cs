using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InfectedObject;

public class InfectedManager : MonoBehaviour
{
    // Start is called before the first frame update
    //private int SpawnCount = 20;
    //private int StartingHealth = 80;
    //private int startingActions = 10;
    //public GameObject prefab;
    public GameObject DeathPrefab;
    public GameObject Character1;//these are the gameObjects in
    public GameObject Character2;
    public GameObject Character3;
    public GameObject Character4;
    public GameObject Character5;
    public GameObject Character6;

    //public Vector3 InfectedManagerTarget; //these are the gameObjects targeted by the infected
    //private int tempTarget = 1;

    //private bool unit1;
    //private bool unit2;
    //private bool unit3;
    //private bool unit4;
    //private bool unit5;
    //private bool unit6;
    void Start()
    {
        //for (int i = 0; i < SpawnCount; i++)
        //{
        //    GameObject infected = Instantiate(prefab, new Vector3(transform.position.x + Random.Range(0, 4.4f), 0, transform.position.z + Random.Range(0, 2.08f)), prefab.transform.rotation);
        //    Infected zed = new Infected();
        //    infected.name = zed.Name;
        //    zed.ActionPoints = Random.Range(2,10);
        //    zed.Health = (int)Random.Range(20,80);
        //    infected.GetComponent<InfectedAI>().LocalInfected = zed;
        //
        //    ///I did intend that the targets would be randomized but with there seems to be a problem that im not sure i can fix before the deadline 
        //    ///so im going to simplify the targets for now
        //    //InfectedManagerTarget = Character6.transform.position;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //InfectedManagerTarget = Character1.transform.position;
        //if (Character6.activeInHierarchy)
        //{
        //    unit6 = true;
        //}
        //else
        //{
        //    unit6 = false;
        //}
        //if (Character5.activeInHierarchy)
        //{
        //    unit5 = true;
        //}
        //else
        //{
        //    unit5 = false;
        //}
        //if (Character4.activeInHierarchy)
        //{
        //    unit4 = true;
        //}
        //else
        //{
        //    unit4 = false;
        //}
        //if (Character3.activeInHierarchy)
        //{
        //    unit3 = true;
        //}
        //else
        //{
        //    unit3 = false;
        //}
        //if (Character2.activeInHierarchy)
        //{
        //    unit2 = true;
        //}
        //else
        //{
        //    unit2 = false;
        //}
        //if (Character1.activeInHierarchy)
        //{
        //    unit1 = true;
        //}
        //else
        //{
        //    unit1 = false;
        //}
        //if (Input.GetKeyDown(KeyCode.LeftShift))
        //{
            //tempTarget = attackSequence(unit1, unit2, unit3, unit4, unit5, unit6);
            //
            //if (tempTarget == 1)
            //{
            //    InfectedManagerTarget = Character1.transform.position;
            //}
            //if (tempTarget == 2)
            //{
            //    InfectedManagerTarget = Character2.transform.position;
            //}
            //if (tempTarget == 3)
            //{
            //    InfectedManagerTarget = Character3.transform.position;
            //}
            //if (tempTarget == 4)
            //{
            //    InfectedManagerTarget = Character4.transform.position;
            //}
            //if (tempTarget == 5)
            //{
            //    InfectedManagerTarget = Character5.transform.position;
            //}
            //if (tempTarget == 6)
            //{
            //    InfectedManagerTarget = Character6.transform.position;
            //}
        //}
    }
    //int attackSequence(bool unit1, bool unit2, bool unit3, bool unit4, bool unit5, bool unit6)
    //{
    //    int attack = 1;
    //
    //    //all six are active and alive
    //    if (unit1 && unit2 && unit3 && unit4 && unit5 && unit6)
    //    {
    //        attack = (int)Random.Range(1, 7);
    //    }
    //    //----------------------------------------------
    //    //1-5
    //    else if (unit1 && unit2 && unit3 && unit4 && unit5)
    //    {
    //        attack = (int)Random.Range(1, 6);
    //    }
    //    //2-6
    //    else if (unit2 && unit3 && unit4 && unit5 && unit6)
    //    {
    //        attack = (int)Random.Range(2, 7);
    //    }
    //    //1, 3-6
    //    else if (unit1 && unit3 && unit4 && unit5 && unit6)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = 1;
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = (int)Random.Range(3, 7);
    //        }
    //    }
    //    //1-2, 4-6
    //    else if (unit1 && unit3 && unit4 && unit5 && unit6)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = (int)Random.Range(1, 3);
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = (int)Random.Range(4, 7);
    //        }
    //    }
    //    //1-3, 5-6
    //    else if (unit1 && unit3 && unit4 && unit5 && unit6)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = (int)Random.Range(1, 4);
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = (int)Random.Range(5, 7);
    //        }
    //    }
    //    //1-4, 6
    //    else if (unit1 && unit3 && unit4 && unit5 && unit6)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = (int)Random.Range(1, 5);
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 6;
    //        }
    //    }
    //    //--------------------------------------------
    //    //1-4
    //    else if (unit1 && unit2 && unit3 && unit4)
    //    {
    //        attack = (int)Random.Range(0, 6);
    //    }
    //    //1-3, 5
    //    else if (unit1 && unit2 && unit3 && unit5)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = (int)Random.Range(1, 4);
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 5;
    //        }
    //    }
    //    //1-3, 6
    //    else if (unit1 && unit2 && unit3 && unit6)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = (int)Random.Range(1, 4);
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 6;
    //        }
    //    }
    //    //1-2, 4-5
    //    else if (unit1 && unit2 && unit4 && unit5)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = (int)Random.Range(1, 3);
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = (int)Random.Range(4, 6);
    //        }
    //    }
    //    //1-2, 4, 6
    //    else if (unit1 && unit2 && unit4 && unit6)
    //    {
    //        int temp = (int)Random.Range(0, 3);
    //        if (temp == 0)
    //        {
    //            attack = (int)Random.Range(1, 3);
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 4;
    //        }
    //        else if (temp == 2)
    //        {
    //            attack = 6;
    //        }
    //    }
    //    //1, 3-5
    //    else if (unit1 && unit3 && unit4 && unit5)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = 1;
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = (int)Random.Range(3, 6);
    //        }
    //    }
    //    //1, 3-4, 6
    //    else if (unit1 && unit3 && unit4 && unit6)
    //    {
    //        int temp = (int)Random.Range(0, 3);
    //        if (temp == 0)
    //        {
    //            attack = 1;
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = (int)Random.Range(3, 5);
    //        }
    //        else if (temp == 2)
    //        {
    //            attack = 6;
    //        }
    //    }
    //    //1, 3, 5-6
    //    else if (unit1 && unit3 && unit5 && unit6)
    //    {
    //        int temp = (int)Random.Range(0, 3);
    //        if (temp == 0)
    //        {
    //            attack = 1;
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 3;
    //        }
    //        else if (temp == 2)
    //        {
    //            attack = (int)Random.Range(5, 7);
    //        }
    //    }
    //    //2-5
    //    else if (unit2 && unit3 && unit4 && unit5)
    //    {
    //        attack = Random.Range(2, 6);
    //    }
    //    //2-4, 6
    //    else if (unit2 && unit3 && unit4 && unit6)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = (int)Random.Range(2, 5);
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 6;
    //        }
    //    }
    //    //2-3 5-6
    //    else if (unit2 && unit3 && unit5 && unit6)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = 2;
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = (int)Random.Range(4, 7);
    //        }
    //    }
    //    //2, 4-6
    //    else if (unit2 && unit4 && unit5 && unit6)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = 2;
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = (int)Random.Range(4, 7);
    //        }
    //    }
    //    //3-6
    //    else if (unit3 && unit4 && unit5 && unit6)
    //    {
    //        attack = (int)Random.Range(1, 7);
    //    }
    //    //-----------------------------------------
    //    //1-3
    //    else if (unit1 && unit2 && unit3)
    //    {
    //        attack = (int)Random.Range(1, 4);
    //    }
    //    //1-2, 4
    //    else if (unit1 && unit2 && unit3)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = (int)Random.Range(1, 3);
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 4;
    //        }
    //    }
    //    //1-2, 5
    //    else if (unit1 && unit2 && unit3)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = (int)Random.Range(1, 3);
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 5;
    //        }
    //    }
    //    //1-2, 6
    //    else if (unit1 && unit2 && unit6)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = (int)Random.Range(1, 3);
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 6;
    //        }
    //    }
    //    //1, 3-4
    //    else if (unit1 && unit3 && unit4)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = 1;
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = (int)Random.Range(3, 5);
    //        }
    //    }
    //    //1, 3, 5
    //    else if (unit1 && unit3 && unit5)
    //    {
    //        int temp = (int)Random.Range(0, 3);
    //        if (temp == 0)
    //        {
    //            attack = 1;
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 3;
    //        }
    //        else if (temp == 2)
    //        {
    //            attack = 5;
    //        }
    //    }
    //    //1, 3, 6
    //    else if (unit1 && unit3 && unit6)
    //    {
    //        int temp = (int)Random.Range(0, 3);
    //        if (temp == 0)
    //        {
    //            attack = 1;
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 3;
    //        }
    //        else if (temp == 2)
    //        {
    //            attack = 6;
    //        }
    //    }
    //    //1, 4-5
    //    else if (unit1 && unit4 && unit5)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = 1;
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = (int)Random.Range(4, 6);
    //        }
    //    }
    //    //1, 4, 6
    //    else if (unit1 && unit4 && unit6)
    //    {
    //        int temp = (int)Random.Range(0, 3);
    //        if (temp == 0)
    //        {
    //            attack = 1;
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 4;
    //        }
    //        else if (temp == 2)
    //        {
    //            attack = 6;
    //        }
    //    }
    //    //2-4
    //    else if (unit2 && unit3 && unit4)
    //    {
    //        attack = (int)Random.Range(2, 5);
    //    }
    //    //2-3, 5
    //    else if (unit2 && unit3 && unit5)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = (int)Random.Range(2, 4);
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 5;
    //        }
    //    }
    //    //2-3, 6
    //    else if (unit2 && unit3 && unit6)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = (int)Random.Range(2, 4);
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 6;
    //        }
    //    }
    //    //2, 4-5
    //    else if (unit2 && unit4 && unit5)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = 2;
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = (int)Random.Range(4, 6);
    //        }
    //    }
    //    //2, 4, 6
    //    else if (unit2 && unit4 && unit6)
    //    {
    //        int temp = (int)Random.Range(0, 3);
    //        if (temp == 0)
    //        {
    //            attack = 2;
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 4;
    //        }
    //        else if (temp == 2)
    //        {
    //            attack = 6;
    //        }
    //    }
    //    //3-5
    //    else if (unit3 && unit4 && unit5)
    //    {
    //        attack = (int)Random.Range(3, 6);
    //    }
    //    //3, 5-6
    //    else if (unit2 && unit4 && unit5)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = 3;
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = (int)Random.Range(5, 7);
    //        }
    //    }
    //    //4-6
    //    else if (unit3 && unit4 && unit5)
    //    {
    //        attack = (int)Random.Range(4, 7);
    //    }
    //    //------------------------------------------
    //    //1-2
    //    else if (unit1 && unit2)
    //    {
    //        attack = (int)Random.Range(1, 3);
    //    }
    //    //1, 3
    //    else if (unit1 && unit3)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = 1;
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 3;
    //        }
    //    }
    //    //1, 4
    //    else if (unit1 && unit4)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = 1;
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 4;
    //        }
    //    }
    //    //1, 5
    //    else if (unit1 && unit5)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = 1;
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 5;
    //        }
    //    }
    //    //1, 6
    //    else if (unit1 && unit6)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = 1;
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 6;
    //        }
    //    }
    //    //2-3
    //    else if (unit2 && unit3)
    //    {
    //        attack = (int)Random.Range(2, 4);
    //    }
    //    //2, 4
    //    else if (unit2 && unit4)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = 2;
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 4;
    //        }
    //    }
    //    //2, 5
    //    else if (unit2 && unit5)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = 2;
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 5;
    //        }
    //    }
    //    //2, 6
    //    else if (unit2 && unit6)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = 2;
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 6;
    //        }
    //    }
    //    //3-4
    //    else if (unit3 && unit4)
    //    {
    //        attack = (int)Random.Range(3, 5);
    //    }
    //    //3, 5
    //    else if (unit3 && unit5)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = 3;
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 5;
    //        }
    //    }
    //    //3, 6
    //    else if (unit3 && unit6)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = 3;
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 6;
    //        }
    //    }
    //    //4-5
    //    else if (unit4 && unit5)
    //    {
    //        attack = (int)Random.Range(4, 6);
    //    }
    //    //4, 6
    //    else if (unit4 && unit6)
    //    {
    //        int temp = (int)Random.Range(0, 2);
    //        if (temp == 0)
    //        {
    //            attack = 4;
    //        }
    //        else if (temp == 1)
    //        {
    //            attack = 6;
    //        }
    //    }
    //    //5-6
    //    else if (unit5 && unit6)
    //    {
    //        attack = (int)Random.Range(5, 6);
    //    }
    //    //------------------------------------
    //    //1
    //    else if (unit1)
    //    {
    //        attack = 1;
    //    }
    //    //2
    //    else if (unit2)
    //    {
    //        attack = 2;
    //    }
    //    //3
    //    else if (unit3)
    //    {
    //        attack = 3;
    //    }
    //    //4
    //    else if (unit4)
    //    {
    //        attack = 5;
    //    }
    //    //5
    //    else if (unit5)
    //    {
    //        attack = 5;
    //    }
    //    //6
    //    else if (unit6)
    //    {
    //        attack = 6;
    //    }
    //    return attack;
    //}
}
