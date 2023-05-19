using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WeaponObject;
using UtilityObject;
using AromorObject;
using SurvivorObject;
using TMPro;

public class ChangeEquipment : MonoBehaviour
{
    private int SurvivorEquip = 0;
    [SerializeField] private GameObject FrontEquipPage;
    [SerializeField] private GameObject BackEquipPage;
    private Survivor[] localList = new Survivor[BetweenPhaseData.MaxSurvivorsInWorld];
    private int RightPageNumber;
    private HomeBaseInventoryControle inv;
    // Start is called before the first frame update
    void Start()
    {
        inv = GetComponent<HomeBaseInventoryControle>();
        for (int i = 0; i < BetweenPhaseData.MaxSurvivorsInWorld; i++)
        {
            localList[i] = new Survivor();
        }
        int tracker = 0;
        for (int i = 0; i < BetweenPhaseData.MaxSurvivorsInWorld; i++)
        {
            if (BetweenPhaseData.Survivors[i].Alive)
            {
                localList[tracker] = BetweenPhaseData.Survivors[i];
                tracker++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        RightPageNumber = gameObject.GetComponent<RigthFolderControle>().RPageNumber;
        if (RightPageNumber == 0)
        {
            if (FrontEquipPage.activeInHierarchy)
            {
                SurvivorEquip = 0;
            }
        }
        if (RightPageNumber == 1)
        {
            if (FrontEquipPage.activeInHierarchy)
            {
                SurvivorEquip = 1;
            }
            if (BackEquipPage.activeInHierarchy)
            {
                SurvivorEquip = 2;
            }
        }
        if (RightPageNumber == 2)
        {
            if (FrontEquipPage.activeInHierarchy)
            {
                SurvivorEquip = 3;
            }
            if (BackEquipPage.activeInHierarchy)
            {
                SurvivorEquip = 4;
            }
        }
        if (RightPageNumber == 3)
        {
            if (FrontEquipPage.activeInHierarchy)
            {
                SurvivorEquip = 5;
            }
            if (BackEquipPage.activeInHierarchy)
            {
                SurvivorEquip = 6;
            }
        }
        if (RightPageNumber == 4)
        {
            if (FrontEquipPage.activeInHierarchy)
            {
                SurvivorEquip = 7;
            }
            if (BackEquipPage.activeInHierarchy)
            {
                SurvivorEquip = 8;
            }
        }
        if (RightPageNumber == 5)
        {
            if (FrontEquipPage.activeInHierarchy)
            {
                SurvivorEquip = 9;
            }
            if (BackEquipPage.activeInHierarchy)
            {
                SurvivorEquip = 10;
            }
        }
        if (RightPageNumber == 6)
        {
            if (FrontEquipPage.activeInHierarchy)
            {
                SurvivorEquip = 11;
            }
            if (BackEquipPage.activeInHierarchy)
            {
                SurvivorEquip = 12;
            }
        }
        if (RightPageNumber == 7)
        {
            if (FrontEquipPage.activeInHierarchy)
            {
                SurvivorEquip = 13;
            }
            if (BackEquipPage.activeInHierarchy)
            {
                SurvivorEquip = 14;
            }
        }
        if (RightPageNumber == 8)
        {
            if (FrontEquipPage.activeInHierarchy)
            {
                SurvivorEquip = 15;
            }
            if (BackEquipPage.activeInHierarchy)
            {
                SurvivorEquip = 16;
            }
        }
        if (RightPageNumber == 9)
        {
            if (FrontEquipPage.activeInHierarchy)
            {
                SurvivorEquip = 17;
            }
            if (BackEquipPage.activeInHierarchy)
            {
                SurvivorEquip = 18;
            }
        }
        if (RightPageNumber == 10)
        {
            if (BackEquipPage.activeInHierarchy)
            {
                SurvivorEquip = 19;
            }
        }
    }//im tired note for later each one of these is going to be connected to its specific button if its quantity is greater than zero then add else disable 
    //and decrease availability directaly set to each survivor all other checks are for if alive so do that. if page number is ect then set to that survivor
    public void EquipmentSwitchBackWeapon_12GaugeShotgun()
    {
        inv.FullResetWeapons();
        if (inv.Available_12GaugeShotgun > 0)
        {
            localList[SurvivorEquip].Weapon1._12GaugeShotgun();
        }
    }
    public void EquipmentSwitchBackWeapon_20GaugeShotgun()
    {
        inv.FullResetWeapons();
        if (inv.Available_20GuageShotgun > 0)
        {
            localList[SurvivorEquip].Weapon1._20GuageShotgun();
        }
    }
    public void EquipmentSwitchBackWeapon_2x4()
    {
        inv.FullResetWeapons();
        if (inv.Available_2X4 > 0)
        {
            localList[SurvivorEquip].Weapon1._2X4();
        }
    }
    public void EquipmentSwitchBackWeapon_AK47()
    {
        inv.FullResetWeapons();
        if (inv.Available_AK47 > 0)
        {
            localList[SurvivorEquip].Weapon1._AK47();
        }
    }
    public void EquipmentSwitchBackWeapon_SledgeHammer()
    {
        inv.FullResetWeapons();
        if (inv.Available_SledgeHammer > 0)
        {
            localList[SurvivorEquip].Weapon1._SledgeHammer();
        }
    }
    public void EquipmentSwitchBackWeapon_BaseballBat()
    {
        inv.FullResetWeapons();
        if (inv.Available_BaseballBat > 0)
        {
            localList[SurvivorEquip].Weapon1._BaseballBat();
        }
    }
    public void EquipmentSwitchBackWeapon_BoltActionRifle()
    {
        inv.FullResetWeapons();
        if (inv.Available_BoltactionRifle > 0)
        {
            localList[SurvivorEquip].Weapon1._BoltactionRifle();
        }
    }
    public void EquipmentSwitchBackWeapon_KnifeKitchen()
    {
        inv.FullResetWeapons();
        if (inv.Available_KitchenKnife > 0)
        {
            localList[SurvivorEquip].Weapon1._KitchenKnife();
        }
    }
    public void EquipmentSwitchBackWeapon_KnifeCombat()
    {
        inv.FullResetWeapons();
        if (inv.Available_CombatKnife > 0)
        {
            localList[SurvivorEquip].Weapon1._CombatKnife();
        }
    }
    public void EquipmentSwitchBackWeapon_M16()
    {
        inv.FullResetWeapons();
        if (inv.Available_M16 > 0)
        {
            localList[SurvivorEquip].Weapon1._M16();
        }
    }
    public void EquipmentSwitchBackWeapon_Machete()
    {
        inv.FullResetWeapons();
        if (inv.Available_Machete > 0)
        {
            localList[SurvivorEquip].Weapon1._Machete();
        }
    }
    public void EquipmentSwitchBackWeapon_Revolver()
    {
        inv.FullResetWeapons();
        if (inv.Available_Revolver > 0)
        {
            localList[SurvivorEquip].Weapon1._Revolver();
        }
    }
    public void EquipmentSwitchBackWeapon_Pistol()
    {
        inv.FullResetWeapons();
        if (inv.Available_9mmPistol > 0)
        {
            localList[SurvivorEquip].Weapon1._9mmPistol();
        }
    }
    public void EquipmentSwitchBackSidearm_12GaugeShotgun()
    {
        inv.FullResetWeapons();
        if (inv.Available_12GaugeShotgun > 0)
        {
            localList[SurvivorEquip].Weapon2._12GaugeShotgun();
        }
    }
    public void EquipmentSwitchBackSidearm_20GaugeShotgun()
    {
        inv.FullResetWeapons();
        if (inv.Available_20GuageShotgun > 0)
        {
            localList[SurvivorEquip].Weapon2._20GuageShotgun();
        }
    }
    public void EquipmentSwitchBackSidearm_2x4()
    {
        inv.FullResetWeapons();
        if (inv.Available_2X4 > 0)
        {
            localList[SurvivorEquip].Weapon2._2X4();
        }
    }
    public void EquipmentSwitchBackSidearm_AK47()
    {
        inv.FullResetWeapons();
        if (inv.Available_AK47 > 0)
        {
            localList[SurvivorEquip].Weapon2._AK47();
        }
    }
    public void EquipmentSwitchBackSidearm_SledgeHammer()
    {
        inv.FullResetWeapons();
        if (inv.Available_SledgeHammer > 0)
        {
            localList[SurvivorEquip].Weapon2._SledgeHammer();
        }
    }
    public void EquipmentSwitchBackSidearm_BaseballBat()
    {
        inv.FullResetWeapons();
        if (inv.Available_BaseballBat > 0)
        {
            localList[SurvivorEquip].Weapon2._BaseballBat();
        }
    }
    public void EquipmentSwitchBackSidearm_BoltActionRifle()
    {
        inv.FullResetWeapons();
        if (inv.Available_BoltactionRifle > 0)
        {
            localList[SurvivorEquip].Weapon2._BoltactionRifle();
        }
    }
    public void EquipmentSwitchBackSidearm_KnifeKitchen()
    {
        inv.FullResetWeapons();
        if (inv.Available_KitchenKnife > 0)
        {
            localList[SurvivorEquip].Weapon2._KitchenKnife();
        }
    }
    public void EquipmentSwitchBackSidearm_KnifeCombat()
    {
        inv.FullResetWeapons();
        if (inv.Available_CombatKnife > 0)
        {
            localList[SurvivorEquip].Weapon2._CombatKnife();
        }
    }
    public void EquipmentSwitchBackSidearm_M16()
    {
        inv.FullResetWeapons();
        if (inv.Available_M16 > 0)
        {
            localList[SurvivorEquip].Weapon2._M16();
        }
    }
    public void EquipmentSwitchBackSidearm_Machete()
    {
        inv.FullResetWeapons();
        if (inv.Available_Machete > 0)
        {
            localList[SurvivorEquip].Weapon2._Machete();
        }
    }
    public void EquipmentSwitchBackSidearm_Revolver()
    {
        inv.FullResetWeapons();
        if (inv.Available_Revolver > 0)
        {
            localList[SurvivorEquip].Weapon2._Revolver();
        }
    }
    public void EquipmentSwitchBackSidearm_Pistol()
    {
        inv.FullResetWeapons();
        if (inv.Available_9mmPistol > 0)
        {
            localList[SurvivorEquip].Weapon2._9mmPistol();
        }
    }
    public void EquipmentSwitchBackUtility1_AntiBiotic()
    {
        inv.FullResetUtility();
        if (inv.Available_Antibiotic > 0)
        {
            localList[SurvivorEquip].Utility1._Antibiotic();
        }
    }
    public void EquipmentSwitchBackUtility1_Medkit()
    {
        inv.FullResetUtility();
        if (inv.Available_Medkit > 0)
        localList[SurvivorEquip].Utility1._Medkit();
    }
    public void EquipmentSwitchBackUtility1_TraumaBag()
    {
        inv.FullResetUtility();
        if (inv.Available_TraumaBag > 0)
        localList[SurvivorEquip].Utility1._TraumaBag();
    }
    public void EquipmentSwitchBackUtility1_Molotov()
    {
        inv.FullResetUtility();
        if (inv.Available_Molotov > 0)
        localList[SurvivorEquip].Utility1._Molotov();
    }
    public void EquipmentSwitchBackUtility1_PipeBomb()
    {
        inv.FullResetUtility();
        if (inv.Available_PipeBomb > 0)
        localList[SurvivorEquip].Utility1._PipeBomb();
    }
    public void EquipmentSwitchBackUtility1_Granade()
    {
        inv.FullResetUtility();
        if (inv.Available_Granade > 0)
        localList[SurvivorEquip].Utility1._Granade();
    }
    public void EquipmentSwitchBackUtility1_Bandage()
    {
        inv.FullResetUtility();
        if (inv.Available_Bandage > 0)
        localList[SurvivorEquip].Utility1._Bandage();
    }
    public void EquipmentSwitchBackUtility1_Flare()
    {
        inv.FullResetUtility();
        if (inv.Available_Flare > 0)
        localList[SurvivorEquip].Utility1._Flare();
    }
    public void EquipmentSwitchBackUtility1_Flashbang()
    {
        inv.FullResetUtility();
        if (inv.Available_FlashBang > 0)
        localList[SurvivorEquip].Utility1._FlashBang();
    }
    public void EquipmentSwitchBackUtility1_Disinfectant()
    {
        inv.FullResetUtility();
        if (inv.Available_Disinfectant > 0)
        localList[SurvivorEquip].Utility1._Disinfectant();
    }
    public void EquipmentSwitchBackUtility2_AntiBiotic()
    {
        inv.FullResetUtility();
        if (inv.Available_Antibiotic > 0)
        localList[SurvivorEquip].Utility2._Antibiotic();
    }
    public void EquipmentSwitchBackUtility2_Medkit()
    {
        inv.FullResetUtility();
        if (inv.Available_Medkit > 0)
        localList[SurvivorEquip].Utility2._Medkit();
    }
    public void EquipmentSwitchBackUtility2_TraumaBag()
    {
        inv.FullResetUtility();
        if (inv.Available_TraumaBag > 0)
        localList[SurvivorEquip].Utility2._TraumaBag();
    }
    public void EquipmentSwitchBackUtility2_Molotov()
    {
        inv.FullResetUtility();
        if (inv.Available_Molotov > 0)
        localList[SurvivorEquip].Utility2._Molotov();
    }
    public void EquipmentSwitchBackUtility2_PipeBomb()
    {
        inv.FullResetUtility();
        if (inv.Available_PipeBomb > 0)
        localList[SurvivorEquip].Utility2._PipeBomb();
    }
    public void EquipmentSwitchBackUtility2_Granade()
    {
        inv.FullResetUtility();
        if (inv.Available_Granade > 0)
        localList[SurvivorEquip].Utility2._Granade();
    }
    public void EquipmentSwitchBackUtility2_Bandage()
    {
        inv.FullResetUtility();
        if (inv.Available_Bandage > 0)
        localList[SurvivorEquip].Utility2._Bandage();
    }
    public void EquipmentSwitchBackUtility2_Flare()
    {
        inv.FullResetUtility();
        if (inv.Available_Flare > 0)
        localList[SurvivorEquip].Utility2._Flare();
    }
    public void EquipmentSwitchBackUtility2_Flashbang()
    {
        inv.FullResetUtility();
        if (inv.Available_FlashBang > 0)
        localList[SurvivorEquip].Utility2._FlashBang();
    }
    public void EquipmentSwitchBackUtility2_Disinfectant()
    {
        inv.FullResetUtility();
        if (inv.Available_Disinfectant > 0)
        localList[SurvivorEquip].Utility2._Disinfectant();
    }
    public void EquipmentSwitchBackUtility3_AntiBiotic()
    {
        inv.FullResetUtility();
        if (inv.Available_Antibiotic > 0)
        localList[SurvivorEquip].Utility3._Antibiotic();
    }
    public void EquipmentSwitchBackUtility3_Medkit()
    {
        inv.FullResetUtility();
        if (inv.Available_Medkit > 0)
        localList[SurvivorEquip].Utility3._Medkit();
    }
    public void EquipmentSwitchBackUtility3_TraumaBag()
    {
        inv.FullResetUtility();
        if (inv.Available_TraumaBag > 0)
        localList[SurvivorEquip].Utility3._TraumaBag();
    }
    public void EquipmentSwitchBackUtility3_Molotov()
    {
        inv.FullResetUtility();
        if (inv.Available_Molotov > 0)
        localList[SurvivorEquip].Utility3._Molotov();
    }
    public void EquipmentSwitchBackUtility3_PipeBomb()
    {
        inv.FullResetUtility();
        if (inv.Available_PipeBomb > 0)
        localList[SurvivorEquip].Utility3._PipeBomb();
    }
    public void EquipmentSwitchBackUtility3_Granade()
    {
        inv.FullResetUtility();
        if (inv.Available_Granade > 0)
        localList[SurvivorEquip].Utility3._Granade();
    }
    public void EquipmentSwitchBackUtility3_Bandage()
    {
        inv.FullResetUtility();
        if (inv.Available_Bandage > 0)
        localList[SurvivorEquip].Utility3._Bandage();
    }
    public void EquipmentSwitchBackUtility3_Flare()
    {
        inv.FullResetUtility();
        if (inv.Available_Flare > 0)
        localList[SurvivorEquip].Utility3._Flare();
    }
    public void EquipmentSwitchBackUtility3_Flashbang()
    {
        inv.FullResetUtility();
        if (inv.Available_FlashBang > 0)
        localList[SurvivorEquip].Utility3._FlashBang();
    }
    public void EquipmentSwitchBackUtility3_Disinfectant()
    {
        inv.FullResetUtility();
        if (inv.Available_Disinfectant > 0)
        localList[SurvivorEquip].Utility3._Disinfectant();
    }
    public void EquipmentSwitchBackArmor_BallCap()
    {
        inv.FullResetArmor();
        if (inv.Available_BallCap > 0)
        {
            localList[SurvivorEquip].ArmorHead._BallCap();
        }
    }
    public void EquipmentSwitchBackArmor_FaceMask()
    {
        inv.FullResetArmor();
        if (inv.Available_FaceMask > 0)
        {
            localList[SurvivorEquip].ArmorHead._FaceMask();
        }
    }
    public void EquipmentSwitchBackArmor_GasMask()
    {
        inv.FullResetArmor();
        if (inv.Available_GasMask > 0)
        {
            localList[SurvivorEquip].ArmorHead._GasMask();
        }
    }
    public void EquipmentSwitchBackArmor_HardHat()
    {
        inv.FullResetArmor();
        if (inv.Available_HardHat > 0)
        {
            localList[SurvivorEquip].ArmorHead._HardHat();
        }
    }
    public void EquipmentSwitchBackArmor_Bandalear()
    {
        inv.FullResetArmor();
        if (inv.Available_Bandalear > 0)
        {
            localList[SurvivorEquip].ArmorHand._Bandalear();
        }
    }
    public void EquipmentSwitchBackArmor_ThickGloves()
    {
        inv.FullResetArmor();
        if (inv.Available_ThickGloves > 0)
        {
            localList[SurvivorEquip].ArmorHand._ThickGloves();
        }
    }
    public void EquipmentSwitchBackArmor_RiotShield()
    {
        inv.FullResetArmor();
        if (inv.Available_RiotShield > 0)
        {
            localList[SurvivorEquip].ArmorHand._RiotShield();
        }
    }
    public void EquipmentSwitchBackArmor_ChestPlate()
    {
        inv.FullResetArmor();
        if (inv.Available_ChestPlate > 0)
        {
            localList[SurvivorEquip].ArmorBody._ChestPlate();
        }
    }
    public void EquipmentSwitchBackArmor_DoctorsScrubs()
    {
        inv.FullResetArmor();
        if (inv.Available_DoctorsScrubs > 0)
        {
            localList[SurvivorEquip].ArmorBody._DoctorsScrubs();
        }
    }
    public void EquipmentSwitchBackArmor_HazmatSuit()
    {
        inv.FullResetArmor();
        if (inv.Available_HazmatSuit > 0)
        {
            localList[SurvivorEquip].ArmorBody._HazmatSuit();
        }
    }
    public void EquipmentSwitchBackArmor_MetalSuit()
    {
        inv.FullResetArmor();
        if (inv.Available_MetalSuit > 0)
        {
            localList[SurvivorEquip].ArmorBody._MetalSuit();
        }
    }
    public void EquipmentSwitchBackArmor_PoliceVest()
    {
        inv.FullResetArmor();
        if (inv.Available_PoliceVest > 0)
        {
            localList[SurvivorEquip].ArmorBody._PoliceVest();
        }
    }
    public void EquipmentSwitchBackArmor_RiotGear()
    {
        inv.FullResetArmor();
        if (inv.Available_RiotGear > 0)
        {
            localList[SurvivorEquip].ArmorBody._RiotGear();
        }
    }
    public void EquipmentSwitchBackArmor_SportsGear()
    {
        inv.FullResetArmor();
        if (inv.Available_SportsGear > 0)
        {
            localList[SurvivorEquip].ArmorBody._SportsGear();
        }
    }
    public void EquipmentSwitchBackArmor_SportsPadding()
    {
        inv.FullResetArmor();
        if (inv.Available_SportsPadding > 0)
        {
            localList[SurvivorEquip].ArmorBody._SportsPadding();
        }
    }

    public void EquipmentSwitchFrontWeapon_12GaugeShotgun()
    {
        inv.FullResetWeapons();
        if (inv.Available_12GaugeShotgun > 0)
        {
            localList[SurvivorEquip].Weapon1._12GaugeShotgun();
        }
    }
    public void EquipmentSwitchFrontWeapon_20GaugeShotgun()
    {
        inv.FullResetWeapons();
        if (inv.Available_20GuageShotgun > 0)
        {
            localList[SurvivorEquip].Weapon1._20GuageShotgun();
        }
    }
    public void EquipmentSwitchFrontWeapon_2x4()
    {
        inv.FullResetWeapons();
        if (inv.Available_2X4 > 0)
        {
            localList[SurvivorEquip].Weapon1._2X4();
        }
    }
    public void EquipmentSwitchFrontWeapon_AK47()
    {
        inv.FullResetWeapons();
        if (inv.Available_AK47 > 0)
        {
            localList[SurvivorEquip].Weapon1._AK47();
        }
    }
    public void EquipmentSwitchFrontWeapon_SledgeHammer()
    {
        inv.FullResetWeapons();
        if (inv.Available_SledgeHammer > 0)
        {
            localList[SurvivorEquip].Weapon1._SledgeHammer();
        }
    }
    public void EquipmentSwitchFrontWeapon_BaseballBat()
    {
        inv.FullResetWeapons();
        if (inv.Available_BaseballBat > 0)
        {
            localList[SurvivorEquip].Weapon1._BaseballBat();
        }
    }
    public void EquipmentSwitchFrontWeapon_BoltActionRifle()
    {
        inv.FullResetWeapons();
        if (inv.Available_BoltactionRifle > 0)
        {
            localList[SurvivorEquip].Weapon1._BoltactionRifle();
        }
    }
    public void EquipmentSwitchFrontWeapon_KnifeKitchen()
    {
        inv.FullResetWeapons();
        if (inv.Available_KitchenKnife > 0)
        {
            localList[SurvivorEquip].Weapon1._KitchenKnife();
        }
    }
    public void EquipmentSwitchFrontWeapon_KnifeCombat()
    {
        inv.FullResetWeapons();
        if (inv.Available_CombatKnife > 0)
        {
            localList[SurvivorEquip].Weapon1._CombatKnife();
        }
    }
    public void EquipmentSwitchFrontWeapon_M16()
    {
        inv.FullResetWeapons();
        if (inv.Available_M16 > 0)
        {
            localList[SurvivorEquip].Weapon1._M16();
        }
    }
    public void EquipmentSwitchFrontWeapon_Machete()
    {
        inv.FullResetWeapons();
        if (inv.Available_Machete > 0)
        {
            localList[SurvivorEquip].Weapon1._Machete();
        }
    }
    public void EquipmentSwitchFrontWeapon_Revolver()
    {
        inv.FullResetWeapons();
        if (inv.Available_Revolver > 0)
        {
            localList[SurvivorEquip].Weapon1._Revolver();
        }
    }
    public void EquipmentSwitchFrontWeapon_Pistol()
    {
        inv.FullResetWeapons();
        if (inv.Available_9mmPistol > 0)
        {
            localList[SurvivorEquip].Weapon1._9mmPistol();
        }
    }
    public void EquipmentSwitchFrontSidearm_12GaugeShotgun()
    {
        inv.FullResetWeapons();
        if (inv.Available_12GaugeShotgun > 0)
        {
            localList[SurvivorEquip].Weapon2._12GaugeShotgun();
        }
    }
    public void EquipmentSwitchFrontSidearm_20GaugeShotgun()
    {
        inv.FullResetWeapons();
        if (inv.Available_20GuageShotgun > 0)
        {
            localList[SurvivorEquip].Weapon2._20GuageShotgun();
        }
    }
    public void EquipmentSwitchFrontSidearm_2x4()
    {
        inv.FullResetWeapons();
        if (inv.Available_2X4 > 0)
        {
            localList[SurvivorEquip].Weapon2._2X4();
        }
    }
    public void EquipmentSwitchFrontSidearm_AK47()
    {
        inv.FullResetWeapons();
        if (inv.Available_AK47 > 0)
        {
            localList[SurvivorEquip].Weapon2._AK47();
        }
    }
    public void EquipmentSwitchFrontSidearm_SledgeHammer()
    {
        inv.FullResetWeapons();
        if (inv.Available_SledgeHammer > 0)
        {
            localList[SurvivorEquip].Weapon2._SledgeHammer();
        }
    }
    public void EquipmentSwitchFrontSidearm_BaseballBat()
    {
        inv.FullResetWeapons();
        if (inv.Available_BaseballBat > 0)
        {
            localList[SurvivorEquip].Weapon2._BaseballBat();
        }
    }
    public void EquipmentSwitchFrontSidearm_BoltActionRifle()
    {
        inv.FullResetWeapons();
        if (inv.Available_BoltactionRifle > 0)
        {
            localList[SurvivorEquip].Weapon2._BoltactionRifle();
        }
    }
    public void EquipmentSwitchFrontSidearm_KnifeKitchen()
    {
        inv.FullResetWeapons();
        if (inv.Available_KitchenKnife > 0)
        {
            localList[SurvivorEquip].Weapon2._KitchenKnife();
        }
    }
    public void EquipmentSwitchFrontSidearm_KnifeCombat()
    {
        inv.FullResetWeapons();
        if (inv.Available_CombatKnife > 0)
        {
            localList[SurvivorEquip].Weapon2._CombatKnife();
        }
    }
    public void EquipmentSwitchFrontSidearm_M16()
    {
        inv.FullResetWeapons();
        if (inv.Available_M16 > 0)
        {
            localList[SurvivorEquip].Weapon2._M16();
        }
    }
    public void EquipmentSwitchFrontSidearm_Machete()
    {
        inv.FullResetWeapons();
        if (inv.Available_Machete > 0)
        {
            localList[SurvivorEquip].Weapon2._Machete();
        }
    }
    public void EquipmentSwitchFrontSidearm_Revolver()
    {
        inv.FullResetWeapons();
        if (inv.Available_Revolver > 0)
        {
            localList[SurvivorEquip].Weapon2._Revolver();
        }
    }
    public void EquipmentSwitchFrontSidearm_Pistol()
    {
        inv.FullResetWeapons();
        if (inv.Available_9mmPistol > 0)
        {
            localList[SurvivorEquip].Weapon2._9mmPistol();
        }
    }
    public void EquipmentSwitchFrontUtility1_AntiBiotic()
    {
        inv.FullResetUtility();
        if (inv.Available_Antibiotic > 0)
        localList[SurvivorEquip].Utility1._Antibiotic();
    }
    public void EquipmentSwitchFrontUtility1_Medkit()
    {
        inv.FullResetUtility();
        if (inv.Available_Medkit > 0)
        localList[SurvivorEquip].Utility1._Medkit();
    }
    public void EquipmentSwitchFrontUtility1_TraumaBag()
    {
        inv.FullResetUtility();
        if (inv.Available_TraumaBag > 0)
        localList[SurvivorEquip].Utility1._TraumaBag();
    }
    public void EquipmentSwitchFrontUtility1_Molotov()
    {
        inv.FullResetUtility();
        if (inv.Available_Molotov > 0)
        localList[SurvivorEquip].Utility1._Molotov();
    }
    public void EquipmentSwitchFrontUtility1_PipeBomb()
    {
        inv.FullResetUtility();
        if (inv.Available_PipeBomb > 0)
        localList[SurvivorEquip].Utility1._PipeBomb();
    }
    public void EquipmentSwitchFrontUtility1_Granade()
    {
        inv.FullResetUtility();
        if (inv.Available_Granade > 0)
        localList[SurvivorEquip].Utility1._Granade();
    }
    public void EquipmentSwitchFrontUtility1_Bandage()
    {
        inv.FullResetUtility();
        if (inv.Available_Bandage > 0)
        localList[SurvivorEquip].Utility1._Bandage();
    }
    public void EquipmentSwitchFrontUtility1_Flare()
    {
        inv.FullResetUtility();
        if (inv.Available_Flare > 0)
        localList[SurvivorEquip].Utility1._Flare();
    }
    public void EquipmentSwitchFrontUtility1_Flashbang()
    {
        inv.FullResetUtility();
        if (inv.Available_FlashBang > 0)
        localList[SurvivorEquip].Utility1._FlashBang();
    }
    public void EquipmentSwitchFrontUtility1_Disinfectant()
    {
        inv.FullResetUtility();
        if (inv.Available_Disinfectant > 0)
        localList[SurvivorEquip].Utility1._Disinfectant();
    }
    public void EquipmentSwitchFrontUtility2_AntiBiotic()
    {
        inv.FullResetUtility();
        if (inv.Available_Antibiotic > 0)
        localList[SurvivorEquip].Utility2._Antibiotic();
    }
    public void EquipmentSwitchFrontUtility2_Medkit()
    {
        inv.FullResetUtility();
        if (inv.Available_Medkit > 0)
        localList[SurvivorEquip].Utility2._Medkit();
    }
    public void EquipmentSwitchFrontUtility2_TraumaBag()
    {
        inv.FullResetUtility();
        if (inv.Available_TraumaBag > 0)
        localList[SurvivorEquip].Utility2._TraumaBag();
    }
    public void EquipmentSwitchFrontUtility2_Molotov()
    {
        inv.FullResetUtility();
        if (inv.Available_Molotov > 0)
        localList[SurvivorEquip].Utility2._Molotov();
    }
    public void EquipmentSwitchFrontUtility2_PipeBomb()
    {
        inv.FullResetUtility();
        if (inv.Available_PipeBomb > 0)
        localList[SurvivorEquip].Utility2._PipeBomb();
    }
    public void EquipmentSwitchFrontUtility2_Granade()
    {
        inv.FullResetUtility();
        if (inv.Available_Granade > 0)
        localList[SurvivorEquip].Utility2._Granade();
    }
    public void EquipmentSwitchFrontUtility2_Bandage()
    {
        inv.FullResetUtility();
        if (inv.Available_Bandage > 0)
        localList[SurvivorEquip].Utility2._Bandage();
    }
    public void EquipmentSwitchFrontUtility2_Flare()
    {
        inv.FullResetUtility();
        if (inv.Available_Flare > 0)
        localList[SurvivorEquip].Utility2._Flare();
    }
    public void EquipmentSwitchFrontUtility2_Flashbang()
    {
        inv.FullResetUtility();
        if (inv.Available_FlashBang > 0)
        localList[SurvivorEquip].Utility2._FlashBang();
    }
    public void EquipmentSwitchFrontUtility2_Disinfectant()
    {
        inv.FullResetUtility();
        if (inv.Available_Disinfectant > 0)
        localList[SurvivorEquip].Utility2._Disinfectant();
    }
    public void EquipmentSwitchFrontUtility3_AntiBiotic()
    {
        inv.FullResetUtility();
        if (inv.Available_Antibiotic > 0)
        localList[SurvivorEquip].Utility3._Antibiotic();
    }
    public void EquipmentSwitchFrontUtility3_Medkit()
    {
        inv.FullResetUtility();
        if (inv.Available_Medkit > 0)
        localList[SurvivorEquip].Utility3._Medkit();
    }
    public void EquipmentSwitchFrontUtility3_TraumaBag()
    {
        inv.FullResetUtility();
        if (inv.Available_TraumaBag > 0)
        localList[SurvivorEquip].Utility3._TraumaBag();
    }
    public void EquipmentSwitchFrontUtility3_Molotov()
    {
        inv.FullResetUtility();
        if (inv.Available_Molotov > 0)
        localList[SurvivorEquip].Utility3._Molotov();
    }
    public void EquipmentSwitchFrontUtility3_PipeBomb()
    {
        inv.FullResetUtility();
        if (inv.Available_PipeBomb > 0)
        localList[SurvivorEquip].Utility3._PipeBomb();
    }
    public void EquipmentSwitchFrontUtility3_Granade()
    {
        inv.FullResetUtility();
        if (inv.Available_Granade > 0)
        localList[SurvivorEquip].Utility3._Granade();
    }
    public void EquipmentSwitchFrontUtility3_Bandage()
    {
        inv.FullResetUtility();
        if (inv.Available_Bandage > 0)
        localList[SurvivorEquip].Utility3._Bandage();
    }
    public void EquipmentSwitchFrontUtility3_Flare()
    {
        inv.FullResetUtility();
        if (inv.Available_Flare > 0)
        localList[SurvivorEquip].Utility3._Flare();
    }
    public void EquipmentSwitchFrontUtility3_Flashbang()
    {
        inv.FullResetUtility();
        if (inv.Available_FlashBang > 0)
        localList[SurvivorEquip].Utility3._FlashBang();
    }
    public void EquipmentSwitchFrontUtility3_Disinfectant()
    {
        inv.FullResetUtility();
        if (inv.Available_Disinfectant > 0)
        localList[SurvivorEquip].Utility3._Disinfectant();
    }
    public void EquipmentSwitchFrontArmor_BallCap()
    {
        inv.FullResetArmor();
        if (inv.Available_BallCap > 0)
        {
            localList[SurvivorEquip].ArmorHead._BallCap();
        }
    }
    public void EquipmentSwitchFrontArmor_FaceMask()
    {
        inv.FullResetArmor();
        if (inv.Available_FaceMask > 0)
        {
            localList[SurvivorEquip].ArmorHead._FaceMask();
        }
    }
    public void EquipmentSwitchFrontArmor_GasMask()
    {
        inv.FullResetArmor();
        if (inv.Available_GasMask > 0)
        {
            localList[SurvivorEquip].ArmorHead._GasMask();
        }
    }
    public void EquipmentSwitchFrontArmor_HardHat()
    {
        inv.FullResetArmor();
        if (inv.Available_HardHat > 0)
        {
            localList[SurvivorEquip].ArmorHead._HardHat();
        }
    }
    public void EquipmentSwitchFrontArmor_Bandalear()
    {
        inv.FullResetArmor();
        if (inv.Available_Bandalear > 0)
        {
            localList[SurvivorEquip].ArmorHand._Bandalear();
        }
    }
    public void EquipmentSwitchFrontArmor_ThickGloves()
    {
        inv.FullResetArmor();
        if (inv.Available_ThickGloves > 0)
        {
            localList[SurvivorEquip].ArmorHand._ThickGloves();
        }
    }
    public void EquipmentSwitchFrontArmor_RiotShield()
    {
        inv.FullResetArmor();
        if (inv.Available_RiotShield > 0)
        {
            localList[SurvivorEquip].ArmorHand._RiotShield();
        }
    }
    public void EquipmentSwitchFrontArmor_ChestPlate()
    {
        inv.FullResetArmor();
        if (inv.Available_ChestPlate > 0)
        {
            localList[SurvivorEquip].ArmorBody._ChestPlate();
        }
    }
    public void EquipmentSwitchFrontArmor_DoctorsScrubs()
    {
        inv.FullResetArmor();
        if (inv.Available_DoctorsScrubs > 0)
        {
            localList[SurvivorEquip].ArmorBody._DoctorsScrubs();
        }
    }
    public void EquipmentSwitchFrontArmor_HazmatSuit()
    {
        inv.FullResetArmor();
        if (inv.Available_HazmatSuit > 0)
        {
            localList[SurvivorEquip].ArmorBody._HazmatSuit();
        }
    }
    public void EquipmentSwitchFrontArmor_MetalSuit()
    {
        inv.FullResetArmor();
        if (inv.Available_MetalSuit > 0)
        {
            localList[SurvivorEquip].ArmorBody._MetalSuit();
        }
    }
    public void EquipmentSwitchFrontArmor_PoliceVest()
    {
        inv.FullResetArmor();
        if (inv.Available_PoliceVest > 0)
        {
            localList[SurvivorEquip].ArmorBody._PoliceVest();
        }
    }
    public void EquipmentSwitchFrontArmor_RiotGear()
    {
        inv.FullResetArmor();
        if (inv.Available_RiotGear > 0)
        {
            localList[SurvivorEquip].ArmorBody._RiotGear();
        }
    }
    public void EquipmentSwitchFrontArmor_SportsGear()
    {
        inv.FullResetArmor();
        if (inv.Available_SportsGear > 0)
        {
            localList[SurvivorEquip].ArmorBody._SportsGear();
        }
    }
    public void EquipmentSwitchFrontArmor_SportsPadding()
    {
        inv.FullResetArmor();
        if (inv.Available_SportsPadding > 0)
        {
            localList[SurvivorEquip].ArmorBody._SportsPadding();
        }
    }
}