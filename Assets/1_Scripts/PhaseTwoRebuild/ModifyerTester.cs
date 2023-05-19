using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyerTester : MonoBehaviour
{
    // Start is called before the first frame update
    ChangeSelectedMember who;
    private bool injured = false;
    void Start()
    {
        who = GameObject.Find("GameControler").GetComponent<ChangeSelectedMember>();
        for(int i = 0; i < BetweenPhaseData.CurrentMaxSurvivorCountOnMission; i++)
        {
            if(who.survivorlist[i].ActivePerks[7].active)
            {
                who.survivorlist[i].Influence -= 5;
            }
            if (who.survivorlist[i].ActivePerks[8].active)
            {
                who.survivorlist[i].Influence -= 5;
                who.survivorlist[i].Senses -= 5;
            }
            if (who.survivorlist[i].ActivePerks[13].active)
            {
                who.survivorlist[i].ActionPoints -= 1;
            }
            if(who.survivorlist[i].ActivePerks[18].active)
            {
                who.survivorlist[i].Intelligence += 5;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        who.survivorlist[who.unitValue].ActivePerks[0].active  = false;
        who.survivorlist[who.unitValue].ActivePerks[1].active  = false;
        who.survivorlist[who.unitValue].ActivePerks[2].active  = false;
        who.survivorlist[who.unitValue].ActivePerks[3].active  = false;
        //who.survivorlist[who.unitValue].ActivePerks[4].active  = true;//runtime, tussiling //waiting for cover system
        //who.survivorlist[who.unitValue].ActivePerks[5].active  = true;//runtime, lit Up //waiting for crit system
        //runtine, injured
        #region Injured 
        if (who.survivorlist[who.unitValue].Health <= 20 && !injured)
        {
            who.survivorlist[who.unitValue].ActivePerks[6].active = true;
            who.survivorlist[who.unitValue].ActionPoints -= 1;
            injured = true;
        }
        else if (who.survivorlist[who.unitValue].Health >= 21 && injured)
        {
            who.survivorlist[who.unitValue].ActivePerks[6].active = false;
            who.survivorlist[who.unitValue].ActionPoints += 1;
            injured = false;
        }
        #endregion
        //who.survivorlist[who.unitValue].ActivePerks[7].active  = true;//on start, angry
        //who.survivorlist[who.unitValue].ActivePerks[8].active  = true;//on start, depressed
        who.survivorlist[who.unitValue].ActivePerks[9].active  = false;
        who.survivorlist[who.unitValue].ActivePerks[10].active = false;
        who.survivorlist[who.unitValue].ActivePerks[11].active = false;
        who.survivorlist[who.unitValue].ActivePerks[12].active = false;
        //who.survivorlist[who.unitValue].ActivePerks[13].active = true;//on start, hungry
        who.survivorlist[who.unitValue].ActivePerks[14].active = false;
        //who.survivorlist[who.unitValue].ActivePerks[15].active = true;//on start, sniper
        who.survivorlist[who.unitValue].ActivePerks[16].active = false;
        who.survivorlist[who.unitValue].ActivePerks[17].active = false;
        //who.survivorlist[who.unitValue].ActivePerks[18].active = true;//on start, gun slinger
        who.survivorlist[who.unitValue].ActivePerks[19].active = false;
        who.survivorlist[who.unitValue].ActivePerks[20].active = false;
        who.survivorlist[who.unitValue].ActivePerks[21].active = false;
    }
    //regions seem like a beter idea than seperate functions for checks that take place in every frame or if there is a single big chunk of code bet dosnt need to be called multiple times
}
