using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RigthFolderControle : MonoBehaviour
{
    [SerializeField] private GameObject FolderClosed;
    private int fileOpened;
    [SerializeField] private GameObject FolderOpen1;
    [SerializeField] private GameObject FolderOpen2;
    [SerializeField] private GameObject FolderOpen3;
    public int RPageNumber = 0;
    [SerializeField] private GameObject TurnPageSound;
    //-----------LoadOunt(0)----------------
    [SerializeField] private GameObject survivorLoadoutImageFront;
    [SerializeField] private GameObject SurvivorLoadouDisplayControler;
    private int SurvivorLoadoutNumPages = 10;
    //--------------------------------------
    //-----------description(1)---------------
    [SerializeField] private GameObject SurvivorDescriptionDisplayControler;
    private int SurvivorDescriptionNumPages = 10;
    //--------------------------------------
    //-----------lost(2)--------------------
    [SerializeField] private GameObject SurvivorLostDisplayControler;
    private int SurvivorLostNumPages = 10;
    //--------------------------------------
    // Start is called before the first frame update
    void Start()
    {
        fileOpened = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SurvivorLoadoutButton()
    {
        fileOpened = 0;
    }
    public void SurvivorDescriptionButton()
    {
        fileOpened = 1;
    }
    public void LostButton()
    {
        fileOpened = 2;
    }
    public void ActivateFolderClosed()
    {
        RPageNumber = 0;
        SurvivorLoadouDisplayControler.SetActive(false);
        SurvivorDescriptionDisplayControler.SetActive(false);
        SurvivorLostDisplayControler.SetActive(false);
        FolderClosed.SetActive(true);
        FolderOpen1.SetActive(false);
        FolderOpen2.SetActive(false);
        FolderOpen3.SetActive(false);
    }
    public void ActivateFolderOpen1()
    {
        if (fileOpened == 0)
        {
            //survivorLoadoutImageFront.SetActive(true);
            RPageNumber = 0;
            SurvivorLoadouDisplayControler.SetActive(true);
            SurvivorDescriptionDisplayControler.SetActive(false);
            SurvivorLostDisplayControler.SetActive(false);
        }
        if (fileOpened == 1)
        {
            RPageNumber = 0;
            SurvivorLoadouDisplayControler.SetActive(false);
            SurvivorDescriptionDisplayControler.SetActive(true);
            SurvivorLostDisplayControler.SetActive(false);
        }
        if (fileOpened == 2)
        {
            SurvivorLoadouDisplayControler.SetActive(false);
            SurvivorDescriptionDisplayControler.SetActive(false);
            SurvivorLostDisplayControler.SetActive(true);
        }
        SetFolderImage();
    }
    public void NextButton()
    {
        TurnPageSound.SetActive(false);
        TurnPageSound.SetActive(true);
        if (fileOpened == 0)
        {
            if (RPageNumber != SurvivorLoadoutNumPages)
            {
                RPageNumber++;
            }
        }
        if (fileOpened == 1)
        {
            if (RPageNumber != SurvivorDescriptionNumPages)
            {
                RPageNumber++;
            }
        }
        if (fileOpened == 2)
        {
            if (RPageNumber != SurvivorLostNumPages)
            {
                RPageNumber++;
            }
        }
        SetFolderImage();
    }
    public void PreviousButton()
    {
        TurnPageSound.SetActive(false);
        TurnPageSound.SetActive(true);
        RPageNumber--;
        if (RPageNumber < 0)
        {
            RPageNumber = 0;
        }
        SetFolderImage();
    }
    public void SetFolderImage()
    {
        if(fileOpened == 0)
        {
            if (RPageNumber == 0)
            {
                FolderClosed.SetActive(false);
                FolderOpen1.SetActive(true);
                FolderOpen2.SetActive(false);
                FolderOpen3.SetActive(false);
            }
            else if (RPageNumber == SurvivorLoadoutNumPages)
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
        if (fileOpened == 1)
        {
            if (RPageNumber == 0)
            {
                FolderClosed.SetActive(false);
                FolderOpen1.SetActive(true);
                FolderOpen2.SetActive(false);
                FolderOpen3.SetActive(false);
            }
            else if (RPageNumber == SurvivorDescriptionNumPages)
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
        if (fileOpened == 2)
        {
            if (RPageNumber == 0)
            {
                FolderClosed.SetActive(false);
                FolderOpen1.SetActive(true);
                FolderOpen2.SetActive(false);
                FolderOpen3.SetActive(false);
            }
            else if (RPageNumber == SurvivorLostNumPages)
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
    }
}
