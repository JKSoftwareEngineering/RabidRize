using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TurnControler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI DayVal;
    [SerializeField] TextMeshProUGUI TimeVal;
    private int Stage = 0; // the stages are night which is a planning stage and day which is the action stage
    // Update is called once per frame
    void Update()
    {
        DayVal.text = "" + BetweenPhaseData.TurnCountVal;
        //stage one planning
        if(Stage == 0)
        {
            TimeVal.text = "Night";
        }
        //stage two action
        if(Stage == 1)
        {
            TimeVal.text = "Day";
        }
    }
    public void NextStepButton()
    {
        BetweenPhaseData.food -= 6; // the loss will be variable depending on the survivors and there food requirements
        Stage++;
        if(Stage > 1)
        {
            BetweenPhaseData.TurnCountVal++;
            Stage = 0;
        }
    }
}
