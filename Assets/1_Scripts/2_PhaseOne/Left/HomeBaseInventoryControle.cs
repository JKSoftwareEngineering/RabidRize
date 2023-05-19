using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WeaponObject;
using UtilityObject;
using AromorObject;
using TMPro;

public class HomeBaseInventoryControle : MonoBehaviour
{
    [HideInInspector] public Weapon[] WeaponsOwned = new Weapon[BetweenPhaseData.MaxWeaponInventory];
    
    private Weapon frontWeapon = new Weapon();
    private Weapon backWeapon = new Weapon();
    private Armor frontArmor = new Armor();
    private Armor backArmor = new Armor();
    private Utility frontUtility = new Utility();
    private Utility backUtility = new Utility();

    [SerializeField] private GameObject PoloroidFront;
    [SerializeField] private TextMeshProUGUI ItemNameFront;
    [SerializeField] private TextMeshProUGUI EquipmentListFront;
    [SerializeField] private TextMeshProUGUI EquipmentListBack;
    [SerializeField] private GameObject PoloroidBack;
    [SerializeField] private TextMeshProUGUI ItemNameBack;
    //---------------Sprites-----------------------
    [SerializeField] private Image ContentsOfFront;
    [SerializeField] private Image ContentsOfBack;
    //---------------------------------------------
    //--------------inventoryCount-----------------
    // this is the total number of the item in question
    private int _12GaugeShotgun = 0;
    private int _20GuageShotgun = 0;
    private int _2X4 = 0;
    private int _AK47 = 0;
    private int _BaseballBat = 0;
    private int _BoltactionRifle = 0;
    private int _KitchenKnife = 0;
    private int _CombatKnife = 0;
    private int _M16 = 0;
    private int _Machete = 0;
    private int _9mmPistol = 0;
    private int _Revolver = 0;
    private int _SledgeHammer = 0;
    private int _HardHat = 0;
    private int _FaceMask = 0;
    private int _BallCap = 0;
    private int _GasMask = 0;
    private int _RiotShield = 0;
    private int _ThickGloves = 0;
    private int _Bandalear = 0;
    private int _SportsPadding = 0;
    private int _ChestPlate = 0;
    private int _PoliceVest = 0;
    private int _DoctorsScrubs = 0;
    private int _SportsGear = 0;
    private int _MetalSuit = 0;
    private int _RiotGear = 0;
    private int _HazmatSuit = 0;
    private int _PipeBomb = 0;
    private int _Molotov = 0;
    private int _FlashBang = 0;
    private int _Medkit = 0;
    private int _TraumaBag = 0;
    private int _Granade = 0;
    private int _Flare = 0;
    private int _Disinfectant = 0;
    private int _Bandage = 0;
    private int _Antibiotic = 0;
    // this is the total number of the item that has been equipt
    public int Equipt_12GaugeShotgun = 0;
    public int Equipt_20GuageShotgun = 0;
    public int Equipt_2X4 = 0;
    public int Equipt_AK47 = 0;
    public int Equipt_BaseballBat = 0;
    public int Equipt_BoltactionRifle = 0;
    public int Equipt_KitchenKnife = 0;
    public int Equipt_CombatKnife = 0;
    public int Equipt_M16 = 0;
    public int Equipt_Machete = 0;
    public int Equipt_9mmPistol = 0;
    public int Equipt_Revolver = 0;
    public int Equipt_SledgeHammer = 0;
    public int Equipt_HardHat = 0;
    public int Equipt_FaceMask = 0;
    public int Equipt_BallCap = 0;
    public int Equipt_GasMask = 0;
    public int Equipt_RiotShield = 0;
    public int Equipt_ThickGloves = 0;
    public int Equipt_Bandalear = 0;
    public int Equipt_SportsPadding = 0;
    public int Equipt_ChestPlate = 0;
    public int Equipt_PoliceVest = 0;
    public int Equipt_DoctorsScrubs = 0;
    public int Equipt_SportsGear = 0;
    public int Equipt_MetalSuit = 0;
    public int Equipt_RiotGear = 0;
    public int Equipt_HazmatSuit = 0;
    public int Equipt_PipeBomb = 0;
    public int Equipt_Molotov = 0;
    public int Equipt_FlashBang = 0;
    public int Equipt_Medkit = 0;
    public int Equipt_TraumaBag = 0;
    public int Equipt_Granade = 0;
    public int Equipt_Flare = 0;
    public int Equipt_Disinfectant = 0;
    public int Equipt_Bandage = 0;
    public int Equipt_Antibiotic = 0;
    //this is the total number of the item that can still be equipt
    public int Available_12GaugeShotgun = 0;
    public int Available_20GuageShotgun = 0;
    public int Available_2X4 = 0;
    public int Available_AK47 = 0;
    public int Available_BaseballBat = 0;
    public int Available_BoltactionRifle = 0;
    public int Available_KitchenKnife = 0;
    public int Available_CombatKnife = 0;
    public int Available_M16 = 0;
    public int Available_Machete = 0;
    public int Available_9mmPistol = 0;
    public int Available_Revolver = 0;
    public int Available_SledgeHammer = 0;
    public int Available_HardHat = 0;
    public int Available_FaceMask = 0;
    public int Available_BallCap = 0;
    public int Available_GasMask = 0;
    public int Available_RiotShield = 0;
    public int Available_ThickGloves = 0;
    public int Available_Bandalear = 0;
    public int Available_SportsPadding = 0;
    public int Available_ChestPlate = 0;
    public int Available_PoliceVest = 0;
    public int Available_DoctorsScrubs = 0;
    public int Available_SportsGear = 0;
    public int Available_MetalSuit = 0;
    public int Available_RiotGear = 0;
    public int Available_HazmatSuit = 0;
    public int Available_PipeBomb = 0;
    public int Available_Molotov = 0;
    public int Available_FlashBang = 0;
    public int Available_Medkit = 0;
    public int Available_TraumaBag = 0;
    public int Available_Granade = 0;
    public int Available_Flare = 0;
    public int Available_Disinfectant = 0;
    public int Available_Bandage = 0;
    public int Available_Antibiotic = 0;
    //----------------------------------------------
    void Start()
    {
        TestEquipmentRandomizer();
        FullResetInventory();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<LeftFolderControle>().LPageNumber == 0)
        {
            PoloroidFront.SetActive(false);
            ItemNameFront.gameObject.SetActive(false);
            EquipmentListFront.text = "12 Gauge Shotgun   Qt. " + _12GaugeShotgun + "\n" +
                                      "20 Guage Shotgun   Qt. " + _20GuageShotgun + "\n" +
                                      "2X4                Qt. " + _2X4 + "\n" +
                                      "AK 47              Qt. " + _AK47 + "\n" +
                                      "Baseball Bat       Qt. " + _BaseballBat + "\n" +
                                      "Bolt-Action Rifle  Qt. " + _BoltactionRifle + "\n" +
                                      "Kitchen Knife      Qt. " + _KitchenKnife + "\n" +
                                      "Combat Knife       Qt. " + _CombatKnife + "\n" +
                                      "M16                Qt. " + _M16 + "\n" +
                                      "Machete            Qt. " + _Machete + "\n" +
                                      "9mm Pistol         Qt. " + _9mmPistol + "\n" +
                                      "Revolver           Qt. " + _Revolver + "\n" +
                                      "Sledge Hammer      Qt. " + _SledgeHammer + "\n" +
                                      "Pipe Bomb          Qt. " + _PipeBomb + "\n" +
                                      "Molotov            Qt. " + _Molotov + "\n" +
                                      "Flash Bang         Qt. " + _FlashBang + "\n" +
                                      "Medkit             Qt. " + _Medkit + "\n" +
                                      "Trauma Bag         Qt. " + _TraumaBag + "\n" +
                                      "Granade            Qt. " + _Granade + "\n" +
                                      "Flare              Qt. " + _Flare + "\n" +
                                      "Disinfectant       Qt. " + _Disinfectant + "\n" +
                                      "Bandage            Qt. " + _Bandage + "\n" +
                                      "Antibiotic         Qt. " + _Antibiotic + "\n" +
                                      "Hard Hat           Qt. " + _HardHat + "\n";

            PoloroidBack.SetActive(false);
            ItemNameBack.gameObject.SetActive(false);
            EquipmentListBack.text = "";
        }
        if (gameObject.GetComponent<LeftFolderControle>().LPageNumber == 1)
        {
            frontWeapon.Reset();
            frontWeapon._12GaugeShotgun();
            buildDescriptionPageFront(frontWeapon);

            PoloroidBack.SetActive(false);
            ItemNameBack.gameObject.SetActive(false);
            EquipmentListBack.text = "Face Mask          Qt. " + _FaceMask + "\n" +
                                     "Ball Cap           Qt. " + _BallCap + "\n" +
                                     "Gas Mask           Qt. " + _GasMask + "\n" +
                                     "Riot Shield        Qt. " + _RiotShield + "\n" +
                                     "Thick Gloves       Qt. " + _ThickGloves + "\n" +
                                     "Bandalear          Qt. " + _Bandalear + "\n" +
                                     "Sports Padding     Qt. " + _SportsPadding + "\n" +
                                     "Chest Plate        Qt. " + _ChestPlate + "\n" +
                                     "Police Vest        Qt. " + _PoliceVest + "\n" +
                                     "Doctors Scrubs     Qt. " + _DoctorsScrubs + "\n" +
                                     "Sports Gear        Qt. " + _SportsGear + "\n" +
                                     "Metal Suit         Qt. " + _MetalSuit + "\n" +
                                     "Riot Gear          Qt. " + _RiotGear + "\n" +
                                     "Hazmat Suit        Qt. " + _HazmatSuit + "\n";
        }
        if (gameObject.GetComponent<LeftFolderControle>().LPageNumber == 2)
        {
            frontWeapon.Reset();
            frontWeapon._20GuageShotgun();
            buildDescriptionPageFront(frontWeapon);

            backWeapon.Reset();
            backWeapon._2X4();
            buildDescriptionPageBack(backWeapon);
        }
        if (gameObject.GetComponent<LeftFolderControle>().LPageNumber == 3)
        {
            frontWeapon.Reset();
            frontWeapon._AK47();
            buildDescriptionPageFront(frontWeapon);

            backWeapon.Reset();
            backWeapon._BaseballBat();
            buildDescriptionPageBack(backWeapon);
        }
        if (gameObject.GetComponent<LeftFolderControle>().LPageNumber == 4)
        {
            frontWeapon.Reset();
            frontWeapon._BoltactionRifle();
            buildDescriptionPageFront(frontWeapon);

            backWeapon.Reset();
            backWeapon._KitchenKnife();
            buildDescriptionPageBack(backWeapon);
        }
        if (gameObject.GetComponent<LeftFolderControle>().LPageNumber == 5)
        {
            frontWeapon.Reset();
            frontWeapon._CombatKnife();
            buildDescriptionPageFront(frontWeapon);

            backWeapon.Reset();
            backWeapon._M16();
            buildDescriptionPageBack(backWeapon);
        }
        if (gameObject.GetComponent<LeftFolderControle>().LPageNumber == 6)
        {
            frontWeapon.Reset();
            frontWeapon._Machete();
            buildDescriptionPageFront(frontWeapon);

            backWeapon.Reset();
            backWeapon._9mmPistol();
            buildDescriptionPageBack(backWeapon);
        }
        if (gameObject.GetComponent<LeftFolderControle>().LPageNumber == 7)
        {
            frontWeapon.Reset();
            frontWeapon._Revolver();
            buildDescriptionPageFront(frontWeapon);

            backWeapon.Reset();
            backWeapon._SledgeHammer();
            buildDescriptionPageBack(backWeapon);
        }
        if (gameObject.GetComponent<LeftFolderControle>().LPageNumber == 8)
        {
            frontUtility.Reset();
            frontUtility._PipeBomb();
            buildDescriptionPageFront(frontUtility);

            backUtility.Reset();
            backUtility._Molotov();
            buildDescriptionPageBack(backUtility);
        }
        if (gameObject.GetComponent<LeftFolderControle>().LPageNumber == 9)
        {
            frontUtility.Reset();
            frontUtility._FlashBang();
            buildDescriptionPageFront(frontUtility);

            backUtility.Reset();
            backUtility._Medkit();
            buildDescriptionPageBack(backUtility);
        }
        if (gameObject.GetComponent<LeftFolderControle>().LPageNumber == 10)
        {
            frontUtility.Reset();
            frontUtility._TraumaBag();
            buildDescriptionPageFront(frontUtility);

            backUtility.Reset();
            backUtility._Granade();
            buildDescriptionPageBack(backUtility);
        }
        if (gameObject.GetComponent<LeftFolderControle>().LPageNumber == 11)
        {
            frontUtility.Reset();
            frontUtility._Flare();
            buildDescriptionPageFront(frontUtility);

            backUtility.Reset();
            backUtility._Disinfectant();
            buildDescriptionPageBack(backUtility);
        }
        if (gameObject.GetComponent<LeftFolderControle>().LPageNumber == 12)
        {
            frontUtility.Reset();
            frontUtility._Bandage();
            buildDescriptionPageFront(frontUtility);

            backUtility.Reset();
            backUtility._Antibiotic();
            buildDescriptionPageBack(backUtility);
        }
        if (gameObject.GetComponent<LeftFolderControle>().LPageNumber == 13) //<=========
        {
            frontArmor.Reset();
            frontArmor._HardHat();
            buildDescriptionPageFront(frontArmor);

            backArmor.Reset();
            backArmor._FaceMask();
            buildDescriptionPageBack(backArmor);
        }
        if (gameObject.GetComponent<LeftFolderControle>().LPageNumber == 14)
        {
            frontArmor.Reset();
            frontArmor._BallCap();
            buildDescriptionPageFront(frontArmor);

            backArmor.Reset();
            backArmor._GasMask();
            buildDescriptionPageBack(backArmor);
        }
        if (gameObject.GetComponent<LeftFolderControle>().LPageNumber == 15)
        {
            frontArmor.Reset();
            frontArmor._RiotShield();
            buildDescriptionPageFront(frontArmor);

            backArmor.Reset();
            backArmor._ThickGloves();
            buildDescriptionPageBack(backArmor);
        }
        if (gameObject.GetComponent<LeftFolderControle>().LPageNumber == 16)
        {
            frontArmor.Reset();
            frontArmor._Bandalear();
            buildDescriptionPageFront(frontArmor);

            backArmor.Reset();
            backArmor._SportsPadding();
            buildDescriptionPageBack(backArmor);
        }
        if (gameObject.GetComponent<LeftFolderControle>().LPageNumber == 17)
        {
            frontArmor.Reset();
            frontArmor._ChestPlate();
            buildDescriptionPageFront(frontArmor);

            backArmor.Reset();
            backArmor._PoliceVest();
            buildDescriptionPageBack(backArmor);
        }
        if (gameObject.GetComponent<LeftFolderControle>().LPageNumber == 18)
        {
            frontArmor.Reset();
            frontArmor._DoctorsScrubs();
            buildDescriptionPageFront(frontArmor);

            backArmor.Reset();
            backArmor._SportsGear();
            buildDescriptionPageBack(backArmor);
        }
        if (gameObject.GetComponent<LeftFolderControle>().LPageNumber == 19)
        {
            frontArmor.Reset();
            frontArmor._MetalSuit();
            buildDescriptionPageFront(frontArmor);

            backArmor.Reset();
            backArmor._RiotGear();
            buildDescriptionPageBack(backArmor);
        }
        if (gameObject.GetComponent<LeftFolderControle>().LPageNumber == 20)
        {
            PoloroidFront.SetActive(false);
            ItemNameFront.gameObject.SetActive(false);
            ItemNameFront.text = "";
            EquipmentListFront.text = "";

            backArmor.Reset();
            backArmor._HazmatSuit();
            buildDescriptionPageBack(backArmor);
        }
    }
    public void buildDescriptionPageFront(Weapon weapon)
    {
        PoloroidFront.SetActive(true);
        ItemNameFront.gameObject.SetActive(true);
        ContentsOfFront.sprite = weapon.WeaponPic;
        ItemNameFront.text = weapon.Name;
        EquipmentListFront.text = weapon.Description;
    }
    public void buildDescriptionPageBack(Weapon weapon)
    {
        PoloroidBack.SetActive(true);
        ItemNameBack.gameObject.SetActive(true);
        ContentsOfBack.sprite = weapon.WeaponPic;
        ItemNameBack.text = weapon.Name;
        EquipmentListBack.text = weapon.Description;
    }
    public void buildDescriptionPageFront(Armor armor)
    {
        PoloroidFront.SetActive(true);
        ItemNameFront.gameObject.SetActive(true);
        ContentsOfFront.sprite = armor.ArmorPic;
        ItemNameFront.text = armor.Name;
        EquipmentListFront.text = armor.Description;
    }
    public void buildDescriptionPageBack(Armor armor)
    {
        PoloroidBack.SetActive(true);
        ItemNameBack.gameObject.SetActive(true);
        ContentsOfBack.sprite = armor.ArmorPic;
        ItemNameBack.text = armor.Name;
        EquipmentListBack.text = armor.Description;
    }
    public void buildDescriptionPageFront(Utility utility)
    {
        PoloroidFront.SetActive(true);
        ItemNameFront.gameObject.SetActive(true);
        ContentsOfFront.sprite = utility.UtilityPic;
        ItemNameFront.text = utility.Name;
        EquipmentListFront.text = utility.Description;
    }
    public void buildDescriptionPageBack(Utility utility)
    {
        PoloroidBack.SetActive(true);
        ItemNameBack.gameObject.SetActive(true);
        ContentsOfBack.sprite = utility.UtilityPic;
        ItemNameBack.text = utility.Name;
        EquipmentListBack.text = utility.Description;
    }
    public void FullResetInventory()
    {
        FullResetWeapons();
        FullResetArmor();
        FullResetUtility();
    }
    public void FullResetWeapons()
    {
        SetActiveInventory();
        Available_12GaugeShotgun =  _12GaugeShotgun  - Equipt_12GaugeShotgun;
        Available_20GuageShotgun =  _20GuageShotgun  - Equipt_20GuageShotgun ;
        Available_2X4 =             _2X4             - Equipt_2X4            ;
        Available_AK47 =            _AK47            - Equipt_AK47           ;
        Available_BaseballBat =     _BaseballBat     - Equipt_BaseballBat    ;
        Available_BoltactionRifle = _BoltactionRifle - Equipt_BoltactionRifle;
        Available_KitchenKnife =    _KitchenKnife    - Equipt_KitchenKnife   ;
        Available_CombatKnife =     _CombatKnife     - Equipt_CombatKnife    ;
        Available_M16 =             _M16             - Equipt_M16            ;
        Available_Machete =         _Machete         - Equipt_Machete        ;
        Available_9mmPistol =       _9mmPistol       - Equipt_9mmPistol      ;
        Available_Revolver =        _Revolver        - Equipt_Revolver       ;
        Available_SledgeHammer =    _SledgeHammer    - Equipt_SledgeHammer   ;
    }
    public void FullResetArmor()
    {
        SetActiveInventory();
        Available_HardHat =         _HardHat       - Equipt_HardHat      ;
        Available_FaceMask =        _FaceMask      - Equipt_FaceMask     ;
        Available_BallCap =         _BallCap       - Equipt_BallCap      ;
        Available_GasMask =         _GasMask       - Equipt_GasMask      ;
        Available_RiotShield =      _RiotShield    - Equipt_RiotShield   ;
        Available_ThickGloves =     _ThickGloves   - Equipt_ThickGloves  ;
        Available_Bandalear =       _Bandalear     - Equipt_Bandalear    ;
        Available_SportsPadding =   _SportsPadding - Equipt_SportsPadding;
        Available_ChestPlate =      _ChestPlate    - Equipt_ChestPlate   ;
        Available_PoliceVest =      _PoliceVest    - Equipt_PoliceVest   ;
        Available_DoctorsScrubs =   _DoctorsScrubs - Equipt_DoctorsScrubs;
        Available_SportsGear =      _SportsGear    - Equipt_SportsGear   ;
        Available_MetalSuit =       _MetalSuit     - Equipt_MetalSuit    ;
        Available_RiotGear =        _RiotGear      - Equipt_RiotGear     ;
        Available_HazmatSuit =      _HazmatSuit    - Equipt_HazmatSuit   ;
    }
    public void FullResetUtility()
    {
        SetActiveInventory();
        Available_PipeBomb =    _PipeBomb     - Equipt_PipeBomb    ;
        Available_Molotov =     _Molotov      - Equipt_Molotov     ;
        Available_FlashBang =   _FlashBang    - Equipt_FlashBang   ;
        Available_Medkit =      _Medkit       - Equipt_Medkit      ;
        Available_TraumaBag =   _TraumaBag    - Equipt_TraumaBag   ;
        Available_Granade =     _Granade      - Equipt_Granade     ;
        Available_Flare =       _Flare        - Equipt_Flare       ;
        Available_Disinfectant =_Disinfectant - Equipt_Disinfectant;
        Available_Bandage =     _Bandage      - Equipt_Bandage     ;
        Available_Antibiotic =  _Antibiotic   - Equipt_Antibiotic  ;
    }
    public void SetActiveInventory()
    {
        Equipt_12GaugeShotgun  = 0;
        Equipt_20GuageShotgun  = 0;
        Equipt_2X4             = 0;
        Equipt_AK47            = 0;
        Equipt_BaseballBat     = 0;
        Equipt_BoltactionRifle = 0;
        Equipt_KitchenKnife    = 0;
        Equipt_CombatKnife     = 0;
        Equipt_M16             = 0;
        Equipt_Machete         = 0;
        Equipt_9mmPistol       = 0;
        Equipt_Revolver        = 0;
        Equipt_SledgeHammer    = 0;
        Equipt_HardHat         = 0;
        Equipt_FaceMask        = 0;
        Equipt_BallCap         = 0;
        Equipt_GasMask         = 0;
        Equipt_RiotShield      = 0;
        Equipt_ThickGloves     = 0;
        Equipt_Bandalear       = 0;
        Equipt_SportsPadding   = 0;
        Equipt_ChestPlate      = 0;
        Equipt_PoliceVest      = 0;
        Equipt_DoctorsScrubs   = 0;
        Equipt_SportsGear      = 0;
        Equipt_MetalSuit       = 0;
        Equipt_RiotGear        = 0;
        Equipt_HazmatSuit      = 0;
        Equipt_PipeBomb        = 0;
        Equipt_Molotov         = 0;
        Equipt_FlashBang       = 0;
        Equipt_Medkit          = 0;
        Equipt_TraumaBag       = 0;
        Equipt_Granade         = 0;
        Equipt_Flare           = 0;
        Equipt_Disinfectant    = 0;
        Equipt_Bandage         = 0;
        Equipt_Antibiotic      = 0;

        for (int i = 0; i < BetweenPhaseData.MaxSurvivorsInWorld; i++)
        {
            if (BetweenPhaseData.Survivors[i].Weapon1.Name.Equals("12 Gauge Shotgun"))
            {
                Equipt_12GaugeShotgun++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon1.Name.Equals("20 Guage Shotgun"))
            {
                Equipt_20GuageShotgun++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon1.Name.Equals("2X4"))
            {
                Equipt_2X4++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon1.Name.Equals("AK 47"))
            {
                Equipt_AK47++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon1.Name.Equals("Baseball Bat"))
            {
                Equipt_BaseballBat++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon1.Name.Equals("Bolt Action Rifle"))
            {
                Equipt_BoltactionRifle++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon1.Name.Equals("Kitchen Knife"))
            {
                Equipt_KitchenKnife++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon1.Name.Equals("Combat Knife"))
            {
                Equipt_CombatKnife++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon1.Name.Equals("M16"))
            {
                Equipt_M16++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon1.Name.Equals("Machete"))
            {
                Equipt_Machete++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon1.Name.Equals("9mm"))
            {
                Equipt_9mmPistol++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon1.Name.Equals("Revolver"))
            {
                Equipt_Revolver++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon1.Name.Equals("Sledge Hammer"))
            {
                Equipt_SledgeHammer++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon2.Name.Equals("12 Gauge Shotgun"))
            {
                Equipt_12GaugeShotgun++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon2.Name.Equals("20 Guage Shotgun"))
            {
                Equipt_20GuageShotgun++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon2.Name.Equals("2X4"))
            {
                Equipt_2X4++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon2.Name.Equals("AK 47"))
            {
                Equipt_AK47++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon2.Name.Equals("Baseball Bat"))
            {
                Equipt_BaseballBat++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon2.Name.Equals("Bolt Action Rifle"))
            {
                Equipt_BoltactionRifle++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon2.Name.Equals("Kitchen Knife"))
            {
                Equipt_KitchenKnife++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon2.Name.Equals("Combat Knife"))
            {
                Equipt_CombatKnife++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon2.Name.Equals("M16"))
            {
                Equipt_M16++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon2.Name.Equals("Machete"))
            {
                Equipt_Machete++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon2.Name.Equals("9mm"))
            {
                Equipt_9mmPistol++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon2.Name.Equals("Revolver"))
            {
                Equipt_Revolver++;
            }
            if (BetweenPhaseData.Survivors[i].Weapon2.Name.Equals("Sledge Hammer"))
            {
                Equipt_SledgeHammer++;
            }
            if (BetweenPhaseData.Survivors[i].ArmorHead.Name.Equals("Hard Hat"))
            {
                Equipt_HardHat++;
            }
            if (BetweenPhaseData.Survivors[i].ArmorHead.Name.Equals("Face Mask"))
            {
                Equipt_FaceMask++;
            }
            if (BetweenPhaseData.Survivors[i].ArmorHead.Name.Equals("Ball Cap"))
            {
                Equipt_BallCap++;
            }
            if (BetweenPhaseData.Survivors[i].ArmorHead.Name.Equals("Gas Mask"))
            {
                Equipt_GasMask++;
            }
            if (BetweenPhaseData.Survivors[i].ArmorHand.Name.Equals("Riot Shield"))
            {
                Equipt_RiotShield++;
            }
            if (BetweenPhaseData.Survivors[i].ArmorHand.Name.Equals("Thick Gloves"))
            {
                Equipt_ThickGloves++;
            }
            if (BetweenPhaseData.Survivors[i].ArmorBody.Name.Equals("Sports Padding"))
            {
                Equipt_SportsPadding++;
            }
            if (BetweenPhaseData.Survivors[i].ArmorBody.Name.Equals("Chest Plate"))
            {
                Equipt_ChestPlate++;
            }
            if (BetweenPhaseData.Survivors[i].ArmorBody.Name.Equals("Police Vest"))
            {
                Equipt_PoliceVest++;
            }
            if (BetweenPhaseData.Survivors[i].ArmorBody.Name.Equals("Doctors Scrubs"))
            {
                Equipt_DoctorsScrubs++;
            }
            if (BetweenPhaseData.Survivors[i].ArmorBody.Name.Equals("Sports Gear"))
            {
                Equipt_SportsGear++;
            }
            if (BetweenPhaseData.Survivors[i].ArmorBody.Name.Equals("Metal Suit"))
            {
                Equipt_MetalSuit++;
            }
            if (BetweenPhaseData.Survivors[i].ArmorBody.Name.Equals("Riot Gear"))
            {
                Equipt_RiotGear++;
            }
            if (BetweenPhaseData.Survivors[i].ArmorBody.Name.Equals("Hazmat Suit"))
            {
                Equipt_HazmatSuit++;
            }
            if (BetweenPhaseData.Survivors[i].ArmorHand.Name.Equals("Bandalear"))
            {
                Equipt_Bandalear++;
            }
            if (BetweenPhaseData.Survivors[i].Utility1.Name.Equals("Pipe Bomb"))
            {
                Equipt_PipeBomb++;
            }
            if (BetweenPhaseData.Survivors[i].Utility1.Name.Equals("Molotov"))
            {
                Equipt_Molotov++;
            }
            if (BetweenPhaseData.Survivors[i].Utility1.Name.Equals("Flash Bang"))
            {
                Equipt_FlashBang++;
            }
            if (BetweenPhaseData.Survivors[i].Utility1.Name.Equals("Medkit"))
            {
                Equipt_Medkit++;
            }
            if (BetweenPhaseData.Survivors[i].Utility1.Name.Equals("Trauma Bag"))
            {
                Equipt_TraumaBag++;
            }
            if (BetweenPhaseData.Survivors[i].Utility1.Name.Equals("Granade"))
            {
                Equipt_Granade++;
            }
            if (BetweenPhaseData.Survivors[i].Utility1.Name.Equals("Flare"))
            {
                Equipt_Flare++;
            }
            if (BetweenPhaseData.Survivors[i].Utility1.Name.Equals("Disinfectant"))
            {
                Equipt_Disinfectant++;
            }
            if (BetweenPhaseData.Survivors[i].Utility1.Name.Equals("Bandage"))
            {
                Equipt_Bandage++;
            }
            if (BetweenPhaseData.Survivors[i].Utility1.Name.Equals("Antibiotic"))
            {
                Equipt_Antibiotic++;
            }
            if (BetweenPhaseData.Survivors[i].Utility2.Name.Equals("Pipe Bomb"))
            {
                Equipt_PipeBomb++;
            }
            if (BetweenPhaseData.Survivors[i].Utility2.Name.Equals("Molotov"))
            {
                Equipt_Molotov++;
            }
            if (BetweenPhaseData.Survivors[i].Utility2.Name.Equals("Flash Bang"))
            {
                Equipt_FlashBang++;
            }
            if (BetweenPhaseData.Survivors[i].Utility2.Name.Equals("Medkit"))
            {
                Equipt_Medkit++;
            }
            if (BetweenPhaseData.Survivors[i].Utility2.Name.Equals("Trauma Bag"))
            {
                Equipt_TraumaBag++;
            }
            if (BetweenPhaseData.Survivors[i].Utility2.Name.Equals("Granade"))
            {
                Equipt_Granade++;
            }
            if (BetweenPhaseData.Survivors[i].Utility2.Name.Equals("Flare"))
            {
                Equipt_Flare++;
            }
            if (BetweenPhaseData.Survivors[i].Utility2.Name.Equals("Disinfectant"))
            {
                Equipt_Disinfectant++;
            }
            if (BetweenPhaseData.Survivors[i].Utility2.Name.Equals("Bandage"))
            {
                Equipt_Bandage++;
            }
            if (BetweenPhaseData.Survivors[i].Utility2.Name.Equals("Antibiotic"))
            {
                Equipt_Antibiotic++;
            }
            if (BetweenPhaseData.Survivors[i].Utility3.Name.Equals("Pipe Bomb"))
            {
                Equipt_PipeBomb++;
            }
            if (BetweenPhaseData.Survivors[i].Utility3.Name.Equals("Molotov"))
            {
                Equipt_Molotov++;
            }
            if (BetweenPhaseData.Survivors[i].Utility3.Name.Equals("Flash Bang"))
            {
                Equipt_FlashBang++;
            }
            if (BetweenPhaseData.Survivors[i].Utility3.Name.Equals("Medkit"))
            {
                Equipt_Medkit++;
            }
            if (BetweenPhaseData.Survivors[i].Utility3.Name.Equals("Trauma Bag"))
            {
                Equipt_TraumaBag++;
            }
            if (BetweenPhaseData.Survivors[i].Utility3.Name.Equals("Granade"))
            {
                Equipt_Granade++;
            }
            if (BetweenPhaseData.Survivors[i].Utility3.Name.Equals("Flare"))
            {
                Equipt_Flare++;
            }
            if (BetweenPhaseData.Survivors[i].Utility3.Name.Equals("Disinfectant"))
            {
                Equipt_Disinfectant++;
            }
            if (BetweenPhaseData.Survivors[i].Utility3.Name.Equals("Bandage"))
            {
                Equipt_Bandage++;
            }
            if (BetweenPhaseData.Survivors[i].Utility3.Name.Equals("Antibiotic"))
            {
                Equipt_Antibiotic++;
            }
        }
    }
    public void TestEquipmentRandomizer()
    {
        for (int i = 0; i < BetweenPhaseData.MaxWeaponInventory; i++)
        {
            if (BetweenPhaseData.WeaponsOwned[i].Name.Equals("12 Gauge Shotgun"))
            {
                _12GaugeShotgun++;
            }
            if (BetweenPhaseData.WeaponsOwned[i].Name.Equals("20 Guage Shotgun"))
            {
                _20GuageShotgun++;
            }
            if (BetweenPhaseData.WeaponsOwned[i].Name.Equals("2X4"))
            {
                _2X4++;
            }
            if (BetweenPhaseData.WeaponsOwned[i].Name.Equals("AK 47"))
            {
                _AK47++;
            }
            if (BetweenPhaseData.WeaponsOwned[i].Name.Equals("Baseball Bat"))
            {
                _BaseballBat++;
            }
            if (BetweenPhaseData.WeaponsOwned[i].Name.Equals("Bolt Action Rifle"))
            {
                _BoltactionRifle++;
            }
            if (BetweenPhaseData.WeaponsOwned[i].Name.Equals("Kitchen Knife"))
            {
                _KitchenKnife++;
            }
            if (BetweenPhaseData.WeaponsOwned[i].Name.Equals("Combat Knife"))
            {
                _CombatKnife++;
            }
            if (BetweenPhaseData.WeaponsOwned[i].Name.Equals("M16"))
            {
                _M16++;
            }
            if (BetweenPhaseData.WeaponsOwned[i].Name.Equals("Machete"))
            {
                _Machete++;
            }
            if (BetweenPhaseData.WeaponsOwned[i].Name.Equals("9mm"))
            {
                _9mmPistol++;
            }
            if (BetweenPhaseData.WeaponsOwned[i].Name.Equals("Revolver"))
            {
                _Revolver++;
            }
            if (BetweenPhaseData.WeaponsOwned[i].Name.Equals("Sledge Hammer"))
            {
                _SledgeHammer++;
            }
        }
        for (int i = 0; i < BetweenPhaseData.MaxArmorInventory; i++)
        {
            if (BetweenPhaseData.ArmorOwned[i].Name.Equals("Hard Hat"))
            {
                _HardHat++;
            }
            if (BetweenPhaseData.ArmorOwned[i].Name.Equals("Face Mask"))
            {
                _FaceMask++;
            }
            if (BetweenPhaseData.ArmorOwned[i].Name.Equals("Ball Cap"))
            {
                _BallCap++;
            }
            if (BetweenPhaseData.ArmorOwned[i].Name.Equals("Gas Mask"))
            {
                _GasMask++;
            }
            if (BetweenPhaseData.ArmorOwned[i].Name.Equals("Riot Shield"))
            {
                _RiotShield++;
            }
            if (BetweenPhaseData.ArmorOwned[i].Name.Equals("Thick Gloves"))
            {
                _ThickGloves++;
            }
            if (BetweenPhaseData.ArmorOwned[i].Name.Equals("Sports Padding"))
            {
                _SportsPadding++;
            }
            if (BetweenPhaseData.ArmorOwned[i].Name.Equals("Chest Plate"))
            {
                _ChestPlate++;
            }
            if (BetweenPhaseData.ArmorOwned[i].Name.Equals("Police Vest"))
            {
                _PoliceVest++;
            }
            if (BetweenPhaseData.ArmorOwned[i].Name.Equals("Doctors Scrubs"))
            {
                _DoctorsScrubs++;
            }
            if (BetweenPhaseData.ArmorOwned[i].Name.Equals("Sports Gear"))
            {
                _SportsGear++;
            }
            if (BetweenPhaseData.ArmorOwned[i].Name.Equals("Metal Suit"))
            {
                _MetalSuit++;
            }
            if (BetweenPhaseData.ArmorOwned[i].Name.Equals("Riot Gear"))
            {
                _RiotGear++;
            }
            if (BetweenPhaseData.ArmorOwned[i].Name.Equals("Hazmat Suit"))
            {
                _HazmatSuit++;
            }
            if (BetweenPhaseData.ArmorOwned[i].Name.Equals("Bandalear"))
            {
                _Bandalear++;
            }
        }
        for (int i = 0; i < BetweenPhaseData.MaxUtilityInventory; i++)
        {
            if (BetweenPhaseData.UtilityOwned[i].Name.Equals("Pipe Bomb"))
            {
                _PipeBomb++;
            }
            if (BetweenPhaseData.UtilityOwned[i].Name.Equals("Molotov"))
            {
                _Molotov++;
            }
            if (BetweenPhaseData.UtilityOwned[i].Name.Equals("Flash Bang"))
            {
                _FlashBang++;
            }
            if (BetweenPhaseData.UtilityOwned[i].Name.Equals("Medkit"))
            {
                _Medkit++;
            }
            if (BetweenPhaseData.UtilityOwned[i].Name.Equals("Trauma Bag"))
            {
                _TraumaBag++;
            }
            if (BetweenPhaseData.UtilityOwned[i].Name.Equals("Granade"))
            {
                _Granade++;
            }
            if (BetweenPhaseData.UtilityOwned[i].Name.Equals("Flare"))
            {
                _Flare++;
            }
            if (BetweenPhaseData.UtilityOwned[i].Name.Equals("Disinfectant"))
            {
                _Disinfectant++;
            }
            if (BetweenPhaseData.UtilityOwned[i].Name.Equals("Bandage"))
            {
                _Bandage++;
            }
            if (BetweenPhaseData.UtilityOwned[i].Name.Equals("Antibiotic"))
            {
                _Antibiotic++;
            }
            //_12GaugeShotgun = 1;
        }
    }
}
