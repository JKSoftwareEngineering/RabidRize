using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WeaponObject;
using UtilityObject;

public class InitTutorial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InitializeTutorial()
    {
        BetweenPhaseData.Survivors[6].OnMission = true;
        Weapon wep1 = new Weapon();
        Weapon wep2 = new Weapon();
        Utility util1 = new Utility();
        Utility util2 = new Utility();
        Utility util3 = new Utility();
        wep1._9mmPistol();
        wep2._BaseballBat();
        util1._PipeBomb();
        util2._Molotov();
        util3._Bandage();
        BetweenPhaseData.Survivors[6].Weapon1 = wep1;
        BetweenPhaseData.Survivors[6].Weapon2 = wep2;
        BetweenPhaseData.Survivors[6].Utility1 = util1;
        BetweenPhaseData.Survivors[6].Utility2 = util2;
        BetweenPhaseData.Survivors[6].Utility3 = util3;
    }
}
