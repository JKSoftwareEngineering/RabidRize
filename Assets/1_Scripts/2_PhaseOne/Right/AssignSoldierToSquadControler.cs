using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using SurvivorObject;

public class AssignSoldierToSquadControler : MonoBehaviour
{
    // Start is called before the first frame update
    //private int ToAssignFront = 0;
    //private int ToAssignBack = 0;
    public int currentSurvivorsOnMission = 0;
    [SerializeField] private TextMeshProUGUI OnMissionVal;
    [SerializeField] private Toggle AssignToSquadFront;
    [SerializeField] private Toggle AssignToSquadBack;
    private Survivor[] localList = new Survivor[BetweenPhaseData.MaxSurvivorsInWorld];
    private Survivor FrontDisplay;
    private Survivor BackDisplay;
    //[SerializeField] private TextMeshProUGUI testOnly;
    private bool step = false;
    private int RightPageNumber;
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
        RightPageNumber = gameObject.GetComponent<RigthFolderControle>().RPageNumber;
        currentSurvivorsOnMission = 0;
        for (int i = 0; i < BetweenPhaseData.MaxSurvivorsInWorld; i++)
        {
            if(BetweenPhaseData.Survivors[i].OnMission)
            {
                currentSurvivorsOnMission++;
            }
        }
        OnMissionVal.text = "" + currentSurvivorsOnMission;
        if (RightPageNumber == 0)
        {
            BackDisplay = localList[0];
            FrontDisplay = localList[0];
        }
        if (RightPageNumber == 1)
        {
            BackDisplay = localList[1];
            FrontDisplay = localList[2];
        }
        if (RightPageNumber == 2)
        {
            BackDisplay = localList[3];
            FrontDisplay = localList[4];
        }
        if (RightPageNumber == 3)
        {
            BackDisplay = localList[5];
            FrontDisplay = localList[6];
        }
        if (RightPageNumber == 4)
        {
            BackDisplay = localList[7];
            FrontDisplay = localList[8];
        }
        if (RightPageNumber == 5)
        {
            BackDisplay = localList[9];
            FrontDisplay = localList[10];
        }
        if (RightPageNumber == 6)
        {
            BackDisplay = localList[11];
            FrontDisplay = localList[12];
        }
        if (RightPageNumber == 7)
        {
            BackDisplay = localList[13];
            FrontDisplay = localList[14];
        }
        if (RightPageNumber == 8)
        {
            BackDisplay = localList[15];
            FrontDisplay = localList[16];
        }
        if (RightPageNumber == 9)
        {
            BackDisplay = localList[17];
            FrontDisplay = localList[18];
        }
        if (RightPageNumber == 10)
        {
            BackDisplay = localList[19];
        }
        AssignToSquadFront.isOn = FrontDisplay.OnMission;
        AssignToSquadBack.isOn = BackDisplay.OnMission;
    }
    public void AssignFront()//for some reason this was switched somewhere and this is for the back page
    {
        if (currentSurvivorsOnMission < BetweenPhaseData.CurrentMaxSurvivorCountOnMission)
        {
            FrontDisplay.OnMission = AssignToSquadFront.isOn;
        }
        else
        {
            if(FrontDisplay.OnMission)
            {
                FrontDisplay.OnMission = AssignToSquadFront.isOn;
            }
        }
    }
    public void AssignBack()//for some reason this was switched somewhere and this is for the front page
    {
        if (currentSurvivorsOnMission < BetweenPhaseData.CurrentMaxSurvivorCountOnMission)
        {
            BackDisplay.OnMission = AssignToSquadBack.isOn;
        }
        else
        {
            if (BackDisplay.OnMission)
            {
                BackDisplay.OnMission = AssignToSquadBack.isOn;
            }
        }
    }
}
