using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SurvivorObject;
using WeaponObject;
using AromorObject;
using TMPro;

public class SurvivorLoadoutControle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject EquipSheetFront;
    [SerializeField] private GameObject EquipSheetBack;
    [SerializeField] private GameObject PerksSheet;
    [SerializeField] private TextMeshProUGUI HeadButtonFront;
    [SerializeField] private TextMeshProUGUI ArmorButtonFront;
    [SerializeField] private TextMeshProUGUI AuxArmorButtonFront;
    [SerializeField] private TextMeshProUGUI PrimWeaponButtonFront;
    [SerializeField] private TextMeshProUGUI SecWeaponButtonFront;
    [SerializeField] private TextMeshProUGUI Item1Front;
    [SerializeField] private TextMeshProUGUI Item2Front;
    [SerializeField] private GameObject Item2ButtonFront;
    [SerializeField] private TextMeshProUGUI Item3Front;
    [SerializeField] private GameObject Item3ButtonFront;
    [SerializeField] private TextMeshProUGUI survivorNameFront;
    [SerializeField] private TextMeshProUGUI survivorNameBack;
    [SerializeField] private GameObject FrontPage;
    [SerializeField] private GameObject BackPage;
    [SerializeField] private TextMeshProUGUI HeadButtonBack;
    [SerializeField] private TextMeshProUGUI ArmorButtonBack;
    [SerializeField] private TextMeshProUGUI AuxArmorButtonBack;
    [SerializeField] private TextMeshProUGUI PrimWeaponButtonBack;
    [SerializeField] private TextMeshProUGUI SecWeaponButtonBack;
    [SerializeField] private TextMeshProUGUI Item1Back;
    [SerializeField] private TextMeshProUGUI Item2Back;
    [SerializeField] private GameObject Item2ButtonBack;
    [SerializeField] private TextMeshProUGUI Item3Back;
    [SerializeField] private GameObject Item3ButtonBack;
    private Survivor[] localList = new Survivor[BetweenPhaseData.MaxSurvivorsInWorld];
    [SerializeField] private TextMeshProUGUI SurvivorHealthFront;
    [SerializeField] private TextMeshProUGUI SurvivorActionPointsFront;
    [SerializeField] private TextMeshProUGUI SurvivorHealthBack;
    [SerializeField] private TextMeshProUGUI SurvivorActionPointsBack;
    [SerializeField] private Toggle AssignToMissionFront;
    [SerializeField] private Toggle AssignToMissionBack;
    //---------EquipSheet-------------
    [SerializeField] private GameObject ArmorHeadF;
    [SerializeField] private GameObject ArmorBodyF;
    [SerializeField] private GameObject ArmorAuxF;
    [SerializeField] private GameObject WeaponF;
    [SerializeField] private GameObject SidearmF;
    [SerializeField] private GameObject Utility1F;
    [SerializeField] private GameObject Utility2F;
    [SerializeField] private GameObject Utility3F;
    [SerializeField] private GameObject ArmorHeadB;
    [SerializeField] private GameObject ArmorBodyB;
    [SerializeField] private GameObject ArmorAuxB;
    [SerializeField] private GameObject WeaponB;
    [SerializeField] private GameObject SidearmB;
    [SerializeField] private GameObject Utility1B;
    [SerializeField] private GameObject Utility2B;
    [SerializeField] private GameObject Utility3B;
    void Start()
    {
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
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 0)
        {
            FrontPage.SetActive(true);
            AssembleSurvivorLoadoutFront(localList[0]);

            BackPage.SetActive(false);           
        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 1)
        {
            FrontPage.SetActive(true);
            AssembleSurvivorLoadoutFront(localList[1]);

            BackPage.SetActive(true);
            AssembleSurvivorLoadoutBack(localList[2]);
        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 2)
        {
            FrontPage.SetActive(true);
            AssembleSurvivorLoadoutFront(localList[3]);

            BackPage.SetActive(true);
            AssembleSurvivorLoadoutBack(localList[4]);

        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 3)
        {
            FrontPage.SetActive(true);
            AssembleSurvivorLoadoutFront(localList[5]);


            BackPage.SetActive(true);
            AssembleSurvivorLoadoutBack(localList[6]);

        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 4)
        {
            FrontPage.SetActive(true);
            AssembleSurvivorLoadoutFront(localList[7]);


            BackPage.SetActive(true);
            AssembleSurvivorLoadoutBack(localList[8]);

        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 5)
        {
            FrontPage.SetActive(true);
            AssembleSurvivorLoadoutFront(localList[9]);


            BackPage.SetActive(true);
            AssembleSurvivorLoadoutBack(localList[10]);

        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 6)
        {
            FrontPage.SetActive(true);
            AssembleSurvivorLoadoutFront(localList[11]);


            BackPage.SetActive(true);
            AssembleSurvivorLoadoutBack(localList[12]);

        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 7)
        {
            FrontPage.SetActive(true);
            AssembleSurvivorLoadoutFront(localList[13]);


            BackPage.SetActive(true);
            AssembleSurvivorLoadoutBack(localList[14]);

        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 8)
        {
            FrontPage.SetActive(true);
            AssembleSurvivorLoadoutFront(localList[15]);


            BackPage.SetActive(true);
            AssembleSurvivorLoadoutBack(localList[16]);

        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 9)
        {
            FrontPage.SetActive(true);
            AssembleSurvivorLoadoutFront(localList[17]);


            BackPage.SetActive(true);
            AssembleSurvivorLoadoutBack(localList[18]);

        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 10)
        {
            FrontPage.SetActive(false);


            if (!localList[19].Name.Equals(""))
            {
                BackPage.SetActive(true);
            }
            else
            {
                BackPage.SetActive(false);
            }
            AssembleSurvivorLoadoutBack(localList[19]);

        }
    }
    public void SurvivorStatDisplayFront(Survivor personByIndex)
    {
        survivorNameFront.text = personByIndex.Name;
        SurvivorHealthFront.text = "" + personByIndex.Health;
        SurvivorActionPointsFront.text = "" + personByIndex.ActionPoints;
    }
    public void SurvivorStatDisplayBack(Survivor personByIndex)
    {
        survivorNameBack.text = personByIndex.Name;
        SurvivorHealthBack.text = "" + personByIndex.Health;
        SurvivorActionPointsBack.text = "" + personByIndex.ActionPoints;
    }
    public void AssembleSurvivorLoadoutFront(Survivor personByIndex)
    {
        SurvivorStatDisplayFront(personByIndex);
        HeadButtonFront.text = "["+personByIndex.ArmorHead.Name+"]";
        ArmorButtonFront.text = "[" + personByIndex.ArmorBody.Name + "]";
        AuxArmorButtonFront.text = "[" + personByIndex.ArmorHand.Name + "]";
        PrimWeaponButtonFront.text = "[" + personByIndex.Weapon1.Name + "]";
        SecWeaponButtonFront.text = "[" + personByIndex.Weapon2.Name + "]";
        Item1Front.text = "[" +personByIndex.Utility1.Name+ "]";
        Item2Front.text = "[" + personByIndex.Utility2.Name + "]";
        Item3Front.text = "[" + personByIndex.Utility3.Name+"]";
    }
    public void AssembleSurvivorLoadoutBack(Survivor personByIndex)
    {
        SurvivorStatDisplayBack(personByIndex);
        HeadButtonBack.text = "[" + personByIndex.ArmorHead.Name + "]";
        ArmorButtonBack.text = "[" + personByIndex.ArmorBody.Name + "]";
        AuxArmorButtonBack.text = "[" + personByIndex.ArmorHand.Name + "]";
        PrimWeaponButtonBack.text = "[" + personByIndex.Weapon1.Name + "]";
        SecWeaponButtonBack.text = "[" + personByIndex.Weapon2.Name + "]";
        Item1Back.text = "[" + personByIndex.Utility1.Name + "]";
        Item2Back.text = "[" + personByIndex.Utility2.Name + "]";
        Item3Back.text = "[" + personByIndex.Utility3.Name + "]";
    }
    public void ActivateEquipSheet()
    {
        EquipSheetFront.SetActive(true);
    }
    public void ActivateEquipSheetWeaponF()
    {
        DeactivateEquipSheet();
        WeaponF.SetActive(true);
        EquipSheetFront.SetActive(true);
    }
    public void ActivateEquipSheetSidearmF()
    {
        DeactivateEquipSheet();
        SidearmF.SetActive(true);
        EquipSheetFront.SetActive(true);
    }
    public void ActivateEquipSheetArmorHeadF()
    {
        DeactivateEquipSheet();
        ArmorHeadF.SetActive(true);
        EquipSheetFront.SetActive(true);
    }
    public void ActivateEquipSheetArmorBodyF()
    {
        DeactivateEquipSheet();
        ArmorBodyF.SetActive(true);
        EquipSheetFront.SetActive(true);
    }
    public void ActivateEquipSheetArmorAuxF()
    {
        DeactivateEquipSheet();
        ArmorAuxF.SetActive(true);
        EquipSheetFront.SetActive(true);
    }
    public void ActivateEquipSheetUtility1F()
    {
        DeactivateEquipSheet();
        Utility1F.SetActive(true);
        EquipSheetFront.SetActive(true);
    }
    public void ActivateEquipSheetUtility2F()
    {
        DeactivateEquipSheet();
        Utility2F.SetActive(true);
        EquipSheetFront.SetActive(true);
    }
    public void ActivateEquipSheetUtility3F()
    {
        DeactivateEquipSheet();
        Utility3F.SetActive(true);
        EquipSheetFront.SetActive(true);
    }
    public void ActivateEquipSheetWeaponB()
    {
        DeactivateEquipSheet();
        WeaponB.SetActive(true);
        EquipSheetBack.SetActive(true);
    }
    public void ActivateEquipSheetSidearmB()
    {
        DeactivateEquipSheet();
        DeactivateEquipSheet();
        SidearmB.SetActive(true);
        EquipSheetBack.SetActive(true);
    }
    public void ActivateEquipSheetArmorHeadB()
    {
        DeactivateEquipSheet();
        ArmorHeadB.SetActive(true);
        EquipSheetBack.SetActive(true);
    }
    public void ActivateEquipSheetArmorBodyB()
    {
        DeactivateEquipSheet();
        ArmorBodyB.SetActive(true);
        EquipSheetBack.SetActive(true);
    }
    public void ActivateEquipSheetArmorAuxB()
    {
        DeactivateEquipSheet();
        ArmorAuxB.SetActive(true);
        EquipSheetBack.SetActive(true);
    }
    public void ActivateEquipSheetUtility1B()
    {
        DeactivateEquipSheet();
        Utility1B.SetActive(true);
        EquipSheetBack.SetActive(true);
    }
    public void ActivateEquipSheetUtility2B()
    {
        DeactivateEquipSheet();
        Utility2B.SetActive(true);
        EquipSheetBack.SetActive(true);
    }
    public void ActivateEquipSheetUtility3B()
    {
        DeactivateEquipSheet();
        Utility3B.SetActive(true);
        EquipSheetBack.SetActive(true);
    }
    public void DeactivateEquipSheet()
    {
        EquipSheetFront.SetActive(false);
        EquipSheetBack.SetActive(false);
        WeaponF.SetActive(false);
        SidearmF.SetActive(false);
        Utility1F.SetActive(false);
        Utility2F.SetActive(false);
        Utility3F.SetActive(false);
        ArmorHeadF.SetActive(false);
        ArmorBodyF.SetActive(false);
        ArmorAuxF.SetActive(false);
        EquipSheetFront.SetActive(false);
        WeaponB.SetActive(false);
        SidearmB.SetActive(false);
        Utility1B.SetActive(false);
        Utility2B.SetActive(false);
        Utility3B.SetActive(false);
        ArmorHeadB.SetActive(false);
        ArmorBodyB.SetActive(false);
        ArmorAuxB.SetActive(false);
        EquipSheetBack.SetActive(false);
    }
    public void ActivatePerksSheet()
    {
        PerksSheet.SetActive(true);
    }
    public void DeactivatePerksSheet()
    {
        PerksSheet.SetActive(false);
    }
}
