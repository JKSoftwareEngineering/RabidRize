using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackSequences : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int attackSequence(bool unit1, bool unit2, bool unit3, bool unit4, bool unit5, bool unit6)
    {
        int attack = 1;

        //all six are active and alive
        if (unit1 && unit2 && unit3 && unit4 && unit5 && unit6)
        {
            attack = (int)Random.Range(1,7);
        }
        //----------------------------------------------
        //1-5
        if (unit1 && unit2 && unit3 && unit4 && unit5)
        {
            attack = (int)Random.Range(1, 6);
        }
        //2-6
        if (unit2 && unit3 && unit4 && unit5 && unit6)
        {
            attack = (int)Random.Range(2, 7);
        }
        //1, 3-6
        if (unit1 && unit3 && unit4 && unit5 && unit6)
        {
            int temp = (int)Random.Range(0,2);
            if(temp == 0)
            {
                attack = 1;
            }
            else if(temp == 1)
            {
                attack = (int)Random.Range(3, 7);
            }
        }
        //1-2, 4-6
        if (unit1 && unit3 && unit4 && unit5 && unit6)
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
        if (unit1 && unit3 && unit4 && unit5 && unit6)
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
        if (unit1 && unit3 && unit4 && unit5 && unit6)
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
        if (unit1 && unit2 && unit3 && unit4)
        {
            attack = (int)Random.Range(0, 6);
        }
        //1-3, 5
        if (unit1 && unit2 && unit3 && unit5)
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
        if (unit1 && unit2 && unit3 && unit6)
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
        if (unit1 && unit2 && unit4 && unit5)
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
        if (unit1 && unit2 && unit4 && unit6)
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
        if (unit1 && unit3 && unit4 && unit5)
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
        if (unit1 && unit3 && unit4 && unit6)
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
        if (unit1 && unit3 && unit5 && unit6)
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
        if (unit2 && unit3 && unit4 && unit5)
        {
            attack = Random.Range(2, 6);
        }
        //2-4, 6
        if (unit2 && unit3 && unit4 && unit6)
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
        if (unit2 && unit3 && unit5 && unit6)
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
        if (unit2 && unit4 && unit5 && unit6)
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
        if (unit3 && unit4 && unit5 && unit6)
        {
            attack = (int)Random.Range(1, 7);
        }
        //-----------------------------------------
        //1-3
        if (unit1 && unit2 && unit3)
        {
            attack = (int)Random.Range(0, 6);
        }
        //1-2, 4
        if (unit1 && unit2 && unit3)
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
        if (unit1 && unit2 && unit3)
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
        if (unit1 && unit2 && unit6)
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
        if (unit1 && unit3 && unit4)
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
        if (unit1 && unit3 && unit5)
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
        if (unit1 && unit3 && unit6)
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
        if (unit1 && unit4 && unit5)
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
        if (unit1 && unit4 && unit6)
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
        if (unit2 && unit3 && unit4)
        {
            attack = (int)Random.Range(2, 5);
        }
        //2-3, 5
        if (unit2 && unit3 && unit5)
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
        if (unit2 && unit3 && unit6)
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
        if (unit2 && unit4 && unit5)
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
        if (unit2 && unit4 && unit6)
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
        if (unit3 && unit4 && unit5)
        {
            attack = (int)Random.Range(3, 6);
        }
        //3, 5-6
        if (unit2 && unit4 && unit5)
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
        if (unit3 && unit4 && unit5)
        {
            attack = (int)Random.Range(4, 7);
        }
        //------------------------------------------
        //1-2
        if (unit1 && unit2)
        {
            attack = (int)Random.Range(1, 3);
        }
        //1, 3
        if (unit1 && unit3)
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
        if (unit1 && unit4)
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
        if (unit1 && unit5)
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
        if (unit1 && unit6)
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
        if (unit2 && unit3)
        {
            attack = (int)Random.Range(2, 4);
        }
        //2, 4
        if (unit2 && unit4)
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
        if (unit2 && unit5)
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
        if (unit2 && unit6)
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
        if (unit3 && unit4)
        {
            attack = (int)Random.Range(3, 5);
        }
        //3, 5
        if (unit3 && unit5)
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
        if (unit3 && unit6)
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
        if (unit4 && unit5)
        {
            attack = (int)Random.Range(4, 6);
        }
        //4, 6
        if (unit4 && unit6)
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
        if (unit5 && unit6)
        {
            attack = (int)Random.Range(5, 6);
        }
        //------------------------------------
        //1
        if (unit1)
        {
            attack = 1;
        }
        //1
        if (unit2)
        {
            attack = 2;
        }
        //1
        if (unit3)
        {
            attack = 3;
        }
        //1
        if (unit4)
        {
            attack = 5;
        }
        //1
        if (unit5)
        {
            attack = 5;
        }
        //1
        if (unit6)
        {
            attack = 6;
        }
        return attack;
    }
}
