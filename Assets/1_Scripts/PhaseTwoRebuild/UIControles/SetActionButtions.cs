using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SurvivorObject;

public class SetActionButtions : MonoBehaviour
{
    // Start is called before the first frame update
    public Button primary;
    public Button secondary;
    public Button utility1;
    public Button utility2;
    public Button utility3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ///Who is the player selected base on the unit value from the change selected member
        /// unit value is the 1 to 1 of SurvivorByName
        /// get the string SurvivorOnMission[UnitValue] then search the BetweenPhaseData.Survivros[i].name for that string
        /// when found break loop and assign the sprites to the sprites assigned to those items

        //string SurvivorName = GetComponent<ChangeSelectedMember>().SurvivorOnMission[GetComponent<ChangeSelectedMember>().unitValue];
        //int temp = 0;
        //for (int i = 0; i < BetweenPhaseData.Survivors.Length; i++)
        //{
        //    if(SurvivorName.Equals(BetweenPhaseData.Survivors[i].Name))
        //    {
        //        temp = i;
        //        break;
        //    }
        //}

        primary.GetComponent<Image>().sprite = GetComponent<ChangeSelectedMember>().ActiveSurvivor.Weapon1.WeaponPic;
        secondary.GetComponent<Image>().sprite = GetComponent<ChangeSelectedMember>().ActiveSurvivor.Weapon2.WeaponPic;
        utility1.GetComponent<Image>().sprite = GetComponent<ChangeSelectedMember>().ActiveSurvivor.Utility1.UtilityPic;
        utility2.GetComponent<Image>().sprite = GetComponent<ChangeSelectedMember>().ActiveSurvivor.Utility2.UtilityPic;
        utility3.GetComponent<Image>().sprite = GetComponent<ChangeSelectedMember>().ActiveSurvivor.Utility3.UtilityPic;
    }
    public void Primary()
    {
        Deactivate();
        primary.interactable = false;
    }
    public void Secondary()
    {
        Deactivate();
        secondary.interactable = false;
    }
    public void Utility1()
    {
        Deactivate();
        utility1.interactable = false;
    }
    public void Utility2()
    {
        Deactivate();
        utility2.interactable = false;
    }
    public void Utility3()
    {
        Deactivate();
        utility3.interactable = false;
    }
    public void Deactivate()
    {
        primary.interactable = true;
        secondary.interactable = true;
        utility1.interactable = true;
        utility2.interactable = true;
        utility3.interactable = true;
    }
}
