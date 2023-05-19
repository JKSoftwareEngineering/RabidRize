using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WeaponObject;
using AromorObject;
using UtilityObject;
using ConditionObject;
using PerksObject;

namespace SurvivorObject
{
    public class Survivor
    {
        public string Name;
        public int Level;
        public int XP;
        public bool[] Goal;
        public int Health;
        public int ActionPoints;
        public int Body;
        public int Brawn;
        public int Skill;
        public int Senses;
        public int Intelligence;
        public int Influence;
        public Weapon Weapon1;
        public Weapon Weapon2;
        public Utility Utility1;
        public Utility Utility2;
        public Utility Utility3;
        public Armor ArmorHead;
        public Armor ArmorHand;
        public Armor ArmorBody;
        public int ItemPickedUp;
        public Perks[] ActivePerks;
        public Condition[] ActiveConditions;
        public bool[] AvailableAction; // new actions a survivor can take (makes new buttons available)
        public Survivor[] SurvivorBonds; //list of survivors that add positive effects
        public int[] SurvivorBondValues; //ex survivorbonds[3] = true and SurvivorBondValues[3] = 2 // this means this survivor has a positive association with the other and the value is friends
        public Survivor[] SurvivorConflicts; // list of survivors that add negative effects
        public int[] SurvivorConflictValues;
        public int[] collectedInventory;
        public bool Alive;
        public bool OnMission;
        private Sprite SurvivorPic;

        public Survivor()
        {
            Name = "";
            Level = 1;
            XP = 0;
            Goal = new bool[10];
            Health = 0;
            ActionPoints = 0;
            Body = 1;
            Brawn = 1;
            Skill = 1;
            Senses = 1;
            Intelligence = 1;
            Influence = 1;
            Weapon1 = new Weapon();
            Weapon2 = new Weapon();
            Utility1 = new Utility();
            Utility2 = new Utility();
            Utility3 = new Utility();
            ArmorHead = new Armor();
            ArmorHand = new Armor();
            ArmorBody = new Armor();
            ItemPickedUp = 0;
            ActivePerks = new Perks[30];
            ActiveConditions = new Condition[30];
            AvailableAction = new bool[10];
            SurvivorBonds = new Survivor[20];
            SurvivorBondValues = new int[10];
            SurvivorConflicts = new Survivor[20];
            SurvivorConflictValues = new int[10];
            collectedInventory = new int[10];
            for(int i = 0; i < 30; i++)
            {
                ActivePerks[i] = new Perks();
            }
            ActivePerks[0]._Cover_Lesser();
            ActivePerks[1]._Cover_Greater();
            ActivePerks[2]._Prone();
            ActivePerks[3]._High_Ground();
            ActivePerks[4]._Tussling();
            ActivePerks[5]._LitUp();
            ActivePerks[6]._Injured();
            ActivePerks[7]._Angry();
            ActivePerks[8]._Depressed();
            ActivePerks[9]._Loves();
            ActivePerks[10]._Coupled();
            ActivePerks[11]._CreepedOut();
            ActivePerks[12]._Scared();
            ActivePerks[13]._Hungry();
            ActivePerks[14]._Parkorist();
            ActivePerks[15]._Sniper();
            ActivePerks[16]._Actor();
            ActivePerks[17]._Surgeon();
            ActivePerks[18]._GunSlinger();
            ActivePerks[19]._SturdyBuild();
            ActivePerks[20]._Vicious();
            ActivePerks[21]._Brutal();
            for (int i = 0; i < 30; i++)
            {
                ActiveConditions[i] = new Condition();
            }
            for (int i = 0; i < Goal.Length; i++)
            {
                Goal[i] = false;
            }
            for (int i = 0; i < AvailableAction.Length; i++)
            {
                AvailableAction[i] = false;
            }
            for (int i = 0; i < SurvivorBonds.Length; i++)
            {
                SurvivorBonds[i] = null;
            }
            for (int i = 0; i < SurvivorBondValues.Length; i++)
            {
                SurvivorBondValues[i] = 0;
            }
            for (int i = 0; i < SurvivorConflicts.Length; i++)
            {
                SurvivorConflicts[i] = null;
            }
            for (int i = 0; i < SurvivorConflictValues.Length; i++)
            {
                SurvivorConflictValues[i] = 0;
            }
            for (int i = 0; i < collectedInventory.Length; i++)
            {
                collectedInventory[i] = 0;
            }
            Alive = false;
            OnMission = false;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public string getName()
        {
            return Name;
        }
        public void SetStats(int body, int brawn, int senses, int skill, int intelligence, int influence)
        {
            Body = body;
            Brawn = brawn;
            Senses = senses;
            Skill = skill;
            Intelligence = intelligence;
            Influence = influence;
        }
        public void SetbaseValues(bool alive, int health, int actionPoints, int level, int xp)
        {
            Alive = alive;
            Health = health;
            ActionPoints = actionPoints;
            Level = level;
            XP = xp;
        }
        public void SetInventory(Weapon weapon1, Weapon weapon2, Utility utility1, Utility utility2, Utility utility3, Armor armorHead, Armor armorHand, Armor armorBody)
        {
            Weapon1 = weapon1;
            Weapon2 = weapon2;
            Utility1 = utility1;
            Utility2 = utility2;
            Utility3 = utility3;
            ArmorHead = armorHead;
            ArmorHand = armorHand;
            ArmorHead = armorHead;
        }
        public void ChangeHealth(bool loss, int amount)
        {
            if(loss)
            {
                Health -= amount;
                if (Health <= 0)
                {
                    Alive = false;
                    Health = 0;
                    OnMission = false;
                }
            }
            else
            {
                if (Alive)
                {
                    Health += amount;
                    //------temperary placeholder before variable health
                    if(Health >= 100)
                    {
                        Health = 100;
                    }
                    //------
                }
            }
        }
        public bool getOnMission()
        {
            return OnMission;
        }
        public void setOnMission(bool on)
        {
            OnMission = on;
        }
        public void EqualTo(Survivor s)
        {
            Name = s.Name;
            Level = s.Level;
            XP = s.XP;
            Goal = s.Goal;
            Health = s.Health;
            ActionPoints = s.ActionPoints;
            Body = s.Body;
            Brawn = s.Brawn;
            Skill = s.Skill;
            Senses = s.Senses;
            Intelligence = s.Intelligence;
            Influence = s.Influence;
            Weapon1 = s.Weapon1;
            Weapon2 = s.Weapon2;
            Utility1 = s.Utility1;
            Utility2 = s.Utility2;
            Utility3 = s.Utility3;
            ArmorHead = s.ArmorHead;
            ArmorHand = s.ArmorHand;
            ArmorBody = s.ArmorBody;
            Alive = s.Alive;
            OnMission = s.OnMission;
        }
    }
}
