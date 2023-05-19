using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LeftFolderControle : MonoBehaviour
{
    //rename lost display controler... later, i still dont know what will go in that slot
    [SerializeField] private GameObject FolderClosed;
    private int fileOpened;
    [SerializeField] private GameObject FolderOpen1;
    [SerializeField] private GameObject FolderOpen2;
    [SerializeField] private GameObject FolderOpen3;
    [HideInInspector] public int LPageNumber = 0;
    [SerializeField] private GameObject TurnPageSound;
    //-----------homeBaseFile(0)------------
    [SerializeField] private GameObject HomeBaseUpgradeDisplayControler;
    private int BaseNumPages = 0;
    //--------------------------------------
    //-----------equipment(1)---------------
    [SerializeField] private GameObject EquipmentDisplayControler;
    [SerializeField] private GameObject EqipmentListFront;
    [SerializeField] private GameObject EqipmentListBack;
    private int EquipNumOfPages = 20;
    //--------------------------------------
    //-----------lost(2)--------------------
    [SerializeField] private GameObject ActionDisplayControler;
    private int ActionNumPages = 0;
    //--------------------------------------
    // Start is called before the first frame update
    void Start()
    {
        fileOpened = 0;
    }
    public void HomeBaseButton()
    {
        fileOpened = 0;
    }
    public void EquipmentButton()
    {
        fileOpened = 1;
    }
    public void ActionButton()
    {
        fileOpened = 2;
    }
    public void ActivateFolderClosed()
    {
        LPageNumber = 0;
        EqipmentListFront.SetActive(false);
        EqipmentListBack.SetActive(false);
        HomeBaseUpgradeDisplayControler.SetActive(false);
        ActionDisplayControler.SetActive(false);
        FolderClosed.SetActive(true);
        FolderOpen1.SetActive(false);
        FolderOpen2.SetActive(false);
        FolderOpen3.SetActive(false);
    }
    public void ActivateFolderOpen1()
    {
        if (fileOpened == 0)
        {
            LPageNumber = 0;
            HomeBaseUpgradeDisplayControler.SetActive(true);
        }
        if (fileOpened == 1)
        {
            EqipmentListFront.SetActive(true);
            EqipmentListBack.SetActive(true);
            LPageNumber = 0;
            EquipmentDisplayControler.SetActive(true);
        }
        if (fileOpened == 2)
        {
            ActionDisplayControler.SetActive(true);
        }
        SetFolderImage();
    }
    public void NextButton()
    {
        TurnPageSound.SetActive(false);
        TurnPageSound.SetActive(true);
        if (fileOpened == 0)
        {
            if (LPageNumber != BaseNumPages)
            {
                LPageNumber++;
            }
        }
        if (fileOpened == 1)
        {
            if(LPageNumber != EquipNumOfPages)
            {
                LPageNumber++;
            }
        }
        if (fileOpened == 2)
        {
            if (LPageNumber != ActionNumPages)
            {
                LPageNumber++;
            }
        }
        SetFolderImage();
    }
    public void PreviousButton()
    {
        TurnPageSound.SetActive(false);
        TurnPageSound.SetActive(true);
        LPageNumber--;
        if(LPageNumber < 0)
        {
            LPageNumber = 0;
        }
        SetFolderImage();
    }
    public void SetFolderImage()
    {
        //----------Home Base----------------
        if (fileOpened == 0)
        {
            FolderClosed.SetActive(false);
            FolderOpen1.SetActive(true);
            FolderOpen2.SetActive(false);
            FolderOpen3.SetActive(false);
        }
        //-----------------------------------
        //--------Base Equipmet--------------
        if (fileOpened == 1)
        {
            if (LPageNumber == 0)
            {
                FolderClosed.SetActive(false);
                FolderOpen1.SetActive(true);
                FolderOpen2.SetActive(false);
                FolderOpen3.SetActive(false);
            }
            else if (LPageNumber == EquipNumOfPages)
            {
                FolderClosed.SetActive(false);
                FolderOpen1.SetActive(false);
                FolderOpen2.SetActive(false);
                FolderOpen3.SetActive(true);
            }
            else
            {
                FolderClosed.SetActive(false);
                FolderOpen1.SetActive(false);
                FolderOpen2.SetActive(true);
                FolderOpen3.SetActive(false);
            }
        }
        //-----------------------------------
        //--------------Actions--------------
        if (fileOpened == 2)
        {
            FolderClosed.SetActive(false);
            FolderOpen1.SetActive(true);
            FolderOpen2.SetActive(false);
            FolderOpen3.SetActive(false);
        }
        //-----------------------------------
    }
}
