using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SurvivorObject;
using WeaponObject;
using AromorObject;
using UtilityObject;
using MissionObject;

public class BetweenPhaseData : MonoBehaviour
{
    //--------------------Phase One-------------------------
    public static int food = 50;
    public static int fuel = 50;
    public static int medical = 0;
    public static int rawMaterial = 700;
    public static int missionVal = 0;
    public static int MaxSurvivorsInWorld = 20;
    public static int MaxWeaponInventory = 100;
    public static int MaxUtilityInventory = 100;
    public static int MaxArmorInventory = 100;
    public static Survivor[] Survivors = new Survivor[MaxSurvivorsInWorld];
    public static Weapon[] WeaponsOwned = new Weapon[MaxWeaponInventory];
    public static Armor[] ArmorOwned = new Armor[MaxUtilityInventory];
    public static Utility[] UtilityOwned = new Utility[MaxArmorInventory];
    public static int CurrentMaxSurvivorCountOnMission = 6;
    public static int TurnCountVal = 0;
    public static bool WasThereAwesomness = false;
    //-----------------------------------------------------
    //--------------------Phase Two------------------------
    public static int CurrentlyOnMission = 0;
    // Start is called before the first frame update
    void Start()
    {
        //--------------Create survivors-------------
        for(int i = 0; i < MaxSurvivorsInWorld; i++)
        {
            Survivors[i] = new Survivor();
        }
        //--------------------------------------------
        for(int i = 0; i < MaxWeaponInventory; i++)
        {
            WeaponsOwned[i] = new Weapon();
            #region Fill With Random Inventory
            //----------testing------------
            int temp = (int)Random.Range(0, 13);
            if (temp == 0)
            {
                WeaponsOwned[i]._12GaugeShotgun();
            }
            if (temp == 1)
            {
                WeaponsOwned[i]._20GuageShotgun();
            }
            if (temp == 2)
            {
                WeaponsOwned[i]._2X4();
            }
            if (temp == 3)
            {
                WeaponsOwned[i]._9mmPistol();
            }
            if (temp == 4)
            {
                WeaponsOwned[i]._AK47();
            }
            if (temp == 5)
            {
                WeaponsOwned[i]._BaseballBat();
            }
            if (temp == 6)
            {
                WeaponsOwned[i]._BoltactionRifle();
            }
            if (temp == 7)
            {
                WeaponsOwned[i]._CombatKnife();
            }
            if (temp == 8)
            {
                WeaponsOwned[i]._KitchenKnife();
            }
            if (temp == 9)
            {
                WeaponsOwned[i]._M16();
            }
            if (temp == 10)
            {
                WeaponsOwned[i]._Machete();
            }
            if (temp == 11)
            {
                WeaponsOwned[i]._Revolver();
            }
            if (temp == 12)
            {
                WeaponsOwned[i]._SledgeHammer();
            }
            //-----------------------------
            #endregion
        }
        for (int i = 0; i < MaxArmorInventory; i++)
        {
            ArmorOwned[i] = new Armor();
            #region Fill With Random Inventory
            //----------testing------------
            int temp = (int)Random.Range(0, 15);
            if (temp == 0)
            {
                ArmorOwned[i]._BallCap();
            }
            if (temp == 1)
            {
                ArmorOwned[i]._Bandalear();
            }
            if (temp == 2)
            {
                ArmorOwned[i]._ChestPlate();
            }
            if (temp == 3)
            {
                ArmorOwned[i]._DoctorsScrubs();
            }
            if (temp == 4)
            {
                ArmorOwned[i]._FaceMask();
            }
            if (temp == 5)
            {
                ArmorOwned[i]._GasMask();
            }
            if (temp == 6)
            {
                ArmorOwned[i]._HardHat();
            }
            if (temp == 7)
            {
                ArmorOwned[i]._HazmatSuit();
            }
            if (temp == 8)
            {
                ArmorOwned[i]._MetalSuit();
            }
            if (temp == 9)
            {
                ArmorOwned[i]._PoliceVest();
            }
            if (temp == 10)
            {
                ArmorOwned[i]._RiotGear();
            }
            if (temp == 11)
            {
                ArmorOwned[i]._RiotShield();
            }
            if (temp == 12)
            {
                ArmorOwned[i]._SportsGear();
            }
            if (temp == 13)
            {
                ArmorOwned[i]._SportsPadding();
            }
            if (temp == 14)
            {
                ArmorOwned[i]._ThickGloves();
            }
            //-----------------------------
            #endregion
        }
        for (int i = 0; i < MaxUtilityInventory; i++)
        {
            UtilityOwned[i] = new Utility();
            #region Fill With Random Inventory
            //----------testing------------
            int temp = (int)Random.Range(0, 10);
            if (temp == 0)
            {
                UtilityOwned[i]._Antibiotic();
            }
            if (temp == 1)
            {
                UtilityOwned[i]._Bandage();
            }
            if (temp == 2)
            {
                UtilityOwned[i]._Disinfectant();
            }
            if (temp == 3)
            {
                UtilityOwned[i]._Flare();
            }
            if (temp == 4)
            {
                UtilityOwned[i]._FlashBang();
            }
            if (temp == 5)
            {
                UtilityOwned[i]._Granade();
            }
            if (temp == 6)
            {
                UtilityOwned[i]._Medkit();
            }
            if (temp == 7)
            {
                UtilityOwned[i]._Molotov();
            }
            if (temp == 8)
            {
                UtilityOwned[i]._PipeBomb();
            }
            if (temp == 9)
            {
                UtilityOwned[i]._TraumaBag();
            }
            //-----------------------------
            #endregion
        }
        #region Manually Assign Survivors
        Survivors[0].SetName("MacKenzie");
        Survivors[0].SetStats(12, 14, 16, 18, 20, 22);
        Survivors[0].SetbaseValues(true, 100,13,1,1);
        Survivors[1].SetName("Dekota");
        Survivors[1].SetStats(14, 16, 18, 20, 22, 12);
        Survivors[1].SetbaseValues(true, 100, 12, 1, 1);
        Survivors[2].SetName("Jon");
        Survivors[2].SetStats(16, 18, 20, 22, 12, 14);
        Survivors[2].SetbaseValues(true, 100, 10, 1, 1);
        Survivors[3].SetName("Nick");
        Survivors[3].SetStats(18, 20, 22, 12, 14, 16);
        Survivors[3].SetbaseValues(true, 100, 12, 1, 1);
        Survivors[4].SetName("Luke");
        Survivors[4].SetStats(20, 22, 12, 14, 16, 18);
        Survivors[4].SetbaseValues(true, 100, 11, 1, 1);
        Survivors[5].SetName("Will");
        Survivors[5].SetStats(22, 12, 14, 16, 18, 20);
        Survivors[5].SetbaseValues(true, 100, 9, 1, 1);
        Survivors[6].SetName("Dave");// this will be the tutorial character
        Survivors[6].SetStats(26, 8, 27, 16, 4, 11);//actual numbers are irrelevent these were generated by a random number generator for the tutorial.
        Survivors[6].SetbaseValues(true, 100, 12, 1, 1);
        Survivors[7].SetName("Emma");
        Survivors[7].SetStats(10, 10, 10, 10, 10, 10);
        Survivors[7].SetbaseValues(true, 100, 10, 1, 1);
        Survivors[8].SetName("Noah");
        Survivors[8].SetStats(10, 10, 10, 10, 10, 10);
        Survivors[8].SetbaseValues(true, 100, 10, 1, 1);
        Survivors[9].SetName("Ava");
        Survivors[9].SetStats(10, 10, 10, 10, 10, 10);
        Survivors[9].SetbaseValues(true, 100, 10, 1, 1);
        Survivors[10].SetName("James");
        Survivors[10].SetStats(10, 10, 10, 10, 10, 10);
        Survivors[10].SetbaseValues(true, 100, 10, 1, 1);
        Survivors[11].SetName("Sophia");
        Survivors[11].SetStats(10, 10, 10, 10, 10, 10);
        Survivors[11].SetbaseValues(true, 100, 10, 1, 1);
        Survivors[12].SetName("Jacob");
        Survivors[12].SetStats(10, 10, 10, 10, 10, 10);
        Survivors[12].SetbaseValues(true, 100, 10, 1, 1);
        Survivors[13].SetName("Aiden");
        Survivors[13].SetStats(10, 10, 10, 10, 10, 10);
        Survivors[13].SetbaseValues(true, 100, 10, 1, 1);
        Survivors[14].SetName("Victoria");
        Survivors[14].SetStats(10, 10, 10, 10, 10, 10);
        Survivors[14].SetbaseValues(true, 100, 10, 1, 1);
        Survivors[15].SetName("Daniael");
        Survivors[15].SetStats(10, 10, 10, 10, 10, 10);
        Survivors[15].SetbaseValues(true, 100, 10, 1, 1);
        Survivors[16].SetName("Nora");
        Survivors[16].SetStats(10, 10, 10, 10, 10, 10);
        Survivors[16].SetbaseValues(true, 100, 10, 1, 1);
        Survivors[17].SetName("Jack");
        Survivors[17].SetStats(10, 10, 10, 10, 10, 10);
        Survivors[17].SetbaseValues(true, 100, 10, 1, 1);
        Survivors[18].SetName("Zoey");
        Survivors[18].SetStats(10, 10, 10, 10, 10, 10);
        Survivors[18].SetbaseValues(true, 100, 10, 1, 1);
        Survivors[19].SetName("Anna");
        Survivors[19].SetStats(10, 10, 10, 10, 10, 10);
        Survivors[19].SetbaseValues(true, 100, 10, 1, 1);
        //------------------------------
        #endregion
    }
}
