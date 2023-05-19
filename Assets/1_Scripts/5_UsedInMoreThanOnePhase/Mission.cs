using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace MissionObject
{
    public class Mission
    {
        public int CostFood;
        public int CostFuel;
        public int CostMedicine;
        public int CostRawMaterials;
        public int RewardFood;
        public int RewardFuel;
        public int RewardMedicine;
        public int RewardRawMaterials;
        public int Light;
        public int Noise;
        public int Contagion;
        public String Name;

        public Mission()
        {
            CostFood = 0;
            CostFuel = 0;
            CostMedicine = 0;
            CostRawMaterials = 0;
            RewardFood = 0;
            RewardFuel = 0;
            RewardMedicine = 0;
            RewardRawMaterials = 0;
            Light = 0;
            Noise = 0;
            Contagion = 0;
            Name = "";
        }

        public Mission(int costFood, int costFuel, int costMedicine, int costRawMaterials, int rewardFood, int rewardFuel, int rewardMedicine, int rewardRawMaterials, int light, int noise, int contaigion, String name)
        {
            CostFood = costFood;
            CostFuel = costFuel;
            CostMedicine = costMedicine;
            CostRawMaterials = costRawMaterials;
            RewardFood = rewardFood;
            RewardFuel = rewardFuel;
            RewardMedicine = rewardMedicine;
            RewardRawMaterials = rewardRawMaterials;
            Light = light;
            Noise = noise;
            Contagion = contaigion;
            Name = name;
        }
        public void GenerateRandomCost()
        {
            float temp = UnityEngine.Random.Range(0, 100);
            if(temp < 50)
            {
                CostFood = (int)UnityEngine.Random.Range(0, 51);
            }
            else
            {
                CostFuel = (int)UnityEngine.Random.Range(0, 51);
            }
        }
        public void GenerateRandomConditions()
        {
            Light = (int)UnityEngine.Random.Range(0, 101);
            Noise = (int)UnityEngine.Random.Range(0, 101);
            Contagion = (int)UnityEngine.Random.Range(0, 101);
        }
    }
}
