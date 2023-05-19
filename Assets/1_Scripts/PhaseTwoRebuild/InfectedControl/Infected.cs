using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace InfectedObject
{
    public class Infected
    {
        public int Health;
        public float ActionPoints;
        public bool Alive;
        public string Name;
        public int Damage;

        public Infected()
        {
            Health = 80;
            ActionPoints = 10;
            Alive = true;
            Name = "Infected";
            Damage = 2;
        }
        public void CheckIfAlive()
        {
            if(Health <= 0)
            {
                Alive = false;
            }
        }
    }
}
