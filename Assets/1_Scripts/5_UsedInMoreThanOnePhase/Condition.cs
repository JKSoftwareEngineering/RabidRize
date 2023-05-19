using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace ConditionObject
{
    public class Condition
    {
        public bool active;
        public string Name;

        public Condition()
        {
            active = false;
            Name = "Null";
        }
        /*
        public bool Tired;
        public bool Hungry;
        public bool Angry;
        public bool Loved;
        public bool InLove;
        public bool Hated;
        private int ConditionNum = 6;
        public Condition()
        {
            Tired = false;
            Hungry = false;
            Angry = false;
            Loved = false;
            InLove = false;
            Hated = false;
        }
        public void NewRandomConditionAttempt()
        {
            int temp = (int)UnityEngine.Random.Range(0, (ConditionNum + 1));
            if(temp == 1)
            {
                Tired = true;
            }
            if (temp == 2)
            {
                Hungry = true;
            }
            if (temp == 3)
            {
                Angry = true;
            }
            if (temp == 4)
            {
                Loved = true;
            }
            if (temp == 5)
            {
                InLove = true;
            }
            if (temp == 6)
            {
                Hated = true;
            }
        }
        public int ActiveNumber()
        {
            int temp = 0;
            if (Tired)
            {
                temp++;
            }
            if (Hungry)
            {
                temp++;
            }
            if (Angry)
            {
                temp++;
            }
            if (Loved)
            {
                temp++;
            }
            if (InLove)
            {
                temp++;
            }
            if (Hated)
            {
                temp++;
            }
            return temp;
        }
        */
    }
}