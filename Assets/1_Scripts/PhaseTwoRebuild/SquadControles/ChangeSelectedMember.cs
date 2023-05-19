using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SurvivorObject;
using WeaponObject;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeSelectedMember : MonoBehaviour
{
    /// <summary>
    /// Plan max of 6 members at any time
    ///     6 assembled human models
    ///     assign the models
    ///     if there arnt enough in a squad then deactivate the extras
    ///     tab to next, +1 to unit value
    ///     if val gth max go to min
    ///     this selected number is what survivor from the betweenphasedata
    /// </summary>
    [SerializeField] private GameObject enemyTurn;
    [HideInInspector] public GameObject ActiveSoldier;
    [HideInInspector] public Survivor ActiveSurvivor;
    private GameObject ActiveLocationSelecter;
    [SerializeField] private GameObject Soldier0;
    [SerializeField] private GameObject Soldier0LocationSelector;
    [SerializeField] private GameObject Soldier1;
    [SerializeField] private GameObject Soldier1LocationSelector;
    [SerializeField] private GameObject Soldier2;
    [SerializeField] private GameObject Soldier2LocationSelector;
    [SerializeField] private GameObject Soldier3;
    [SerializeField] private GameObject Soldier3LocationSelector;
    [SerializeField] private GameObject Soldier4;
    [SerializeField] private GameObject Soldier4LocationSelector;
    [SerializeField] private GameObject Soldier5;
    [SerializeField] private GameObject Soldier5LocationSelector;
    private int[] tempSurvivorIndex = new int[BetweenPhaseData.CurrentMaxSurvivorCountOnMission]; //warning survivor list is a deep copy not a reference
    [HideInInspector] public Survivor[] survivorlist = new Survivor[BetweenPhaseData.CurrentMaxSurvivorCountOnMission];
    public int unitValue = 0;
    private bool setOnce = true;
    //----------Test Only-------------
    private float timermin = 10;
    private float timermax = 11;
    private bool timing = true;
    //--------------------------------
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < BetweenPhaseData.CurrentMaxSurvivorCountOnMission; i++)
        {
            survivorlist[i] = new Survivor();
        }
        int temp = 0;
        for (int i = 0; i < BetweenPhaseData.Survivors.Length; i++)
        {
            if (BetweenPhaseData.Survivors[i].OnMission)
            {
                survivorlist[temp].EqualTo(BetweenPhaseData.Survivors[i]);
                temp++;
            }
        }
        if (!survivorlist[0].Name.Equals(""))
        {
          Soldier0.SetActive(true);
          Soldier0.transform.parent.gameObject.SetActive(true);
          Soldier0.SetActive(false);
        }
        if (!survivorlist[1].Name.Equals(""))
        {
          Soldier1.SetActive(true);
          Soldier1.transform.parent.gameObject.SetActive(true);
          Soldier1.SetActive(false);
        }
        if (!survivorlist[2].Name.Equals(""))
        {
          Soldier2.SetActive(true);
          Soldier2.transform.parent.gameObject.SetActive(true);
          Soldier2.SetActive(false);
        }
        if (!survivorlist[3].Name.Equals(""))
        {
          Soldier3.SetActive(true);
          Soldier3.transform.parent.gameObject.SetActive(true);
          Soldier3.SetActive(false);
        }
        if (!survivorlist[4].Name.Equals(""))
        {
          Soldier4.SetActive(true);
          Soldier4.transform.parent.gameObject.SetActive(true);
          Soldier4.SetActive(false);
        }
        if (!survivorlist[5].Name.Equals(""))
        {
          Soldier5.SetActive(true);
          Soldier5.transform.parent.gameObject.SetActive(true);
          Soldier5.SetActive(false);
        }
        Soldier0.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Slider>().value = survivorlist[0].Health;
        Soldier1.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Slider>().value = survivorlist[1].Health;
        Soldier2.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Slider>().value = survivorlist[2].Health;
        Soldier3.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Slider>().value = survivorlist[3].Health;
        Soldier4.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Slider>().value = survivorlist[4].Health;
        Soldier5.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Slider>().value = survivorlist[5].Health;

        Soldier0.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Slider>().value = survivorlist[0].ActionPoints;
        Soldier1.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Slider>().value = survivorlist[1].ActionPoints;
        Soldier2.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Slider>().value = survivorlist[2].ActionPoints;
        Soldier3.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Slider>().value = survivorlist[3].ActionPoints;
        Soldier4.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Slider>().value = survivorlist[4].ActionPoints;
        Soldier5.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Slider>().value = survivorlist[5].ActionPoints;
    }

    // Update is called once per frame
    void Update()
    {
        if(timing)
        {
            timermin += Time.deltaTime;
        }
        Soldier0.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Slider>().value = survivorlist[0].Health;
        Soldier1.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Slider>().value = survivorlist[1].Health;
        Soldier2.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Slider>().value = survivorlist[2].Health;
        Soldier3.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Slider>().value = survivorlist[3].Health;
        Soldier4.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Slider>().value = survivorlist[4].Health;
        Soldier5.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Slider>().value = survivorlist[5].Health;

        Soldier0.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Slider>().value = survivorlist[0].ActionPoints;
        Soldier1.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Slider>().value = survivorlist[1].ActionPoints;
        Soldier2.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Slider>().value = survivorlist[2].ActionPoints;
        Soldier3.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Slider>().value = survivorlist[3].ActionPoints;
        Soldier4.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Slider>().value = survivorlist[4].ActionPoints;
        Soldier5.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.GetComponent<Slider>().value = survivorlist[5].ActionPoints;
        if (setOnce)
        {
            SetUnitActive(unitValue);
            setOnce = false;
        }
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            unitValue++;
            if (unitValue > 5)
            {
                unitValue = 0;
            }
            else if (unitValue == 5)
            {
                if (!Soldier5.transform.parent.gameObject.activeInHierarchy)
                {
                    unitValue = 0;
                    if (!Soldier0.transform.parent.gameObject.activeInHierarchy)
                    {
                        unitValue = 1;
                        if (!Soldier1.transform.parent.gameObject.activeInHierarchy)
                        {
                            unitValue = 2;
                            if (!Soldier2.transform.parent.gameObject.activeInHierarchy)
                            {
                                unitValue = 3;
                                if (!Soldier3.transform.parent.gameObject.activeInHierarchy)
                                {
                                    unitValue = 4;
                                }
                            }
                        }
                    }
                }
            }
            else if (unitValue == 4)
            {
                if (!Soldier4.transform.parent.gameObject.activeInHierarchy)
                {
                    unitValue = 5;
                    if (!Soldier5.transform.parent.gameObject.activeInHierarchy)
                    {
                        unitValue = 0;
                        if (!Soldier0.transform.parent.gameObject.activeInHierarchy)
                        {
                            unitValue = 1;
                            if (!Soldier1.transform.parent.gameObject.activeInHierarchy)
                            {
                                unitValue = 2;
                                if (!Soldier2.transform.parent.gameObject.activeInHierarchy)
                                {
                                    unitValue = 3;
                                }
                            }
                        }
                    }
                }
            }
            else if (unitValue == 3)
            {
                if (!Soldier3.transform.parent.gameObject.activeInHierarchy)
                {
                    unitValue = 4;
                    if (!Soldier4.transform.parent.gameObject.activeInHierarchy)
                    {
                        unitValue = 5;
                        if (!Soldier5.transform.parent.gameObject.activeInHierarchy)
                        {
                            unitValue = 0;
                            if (!Soldier0.transform.parent.gameObject.activeInHierarchy)
                            {
                                unitValue = 1;
                                if (!Soldier1.transform.parent.gameObject.activeInHierarchy)
                                {
                                    unitValue = 2;
                                }
                            }
                        }
                    }
                }
            }
            else if (unitValue == 2)
            {
                if (!Soldier2.transform.parent.gameObject.activeInHierarchy)
                {
                    unitValue = 3;
                    if (!Soldier3.transform.parent.gameObject.activeInHierarchy)
                    {
                        unitValue = 4;
                        if (!Soldier4.transform.parent.gameObject.activeInHierarchy)
                        {
                            unitValue = 5;
                            if (!Soldier5.transform.parent.gameObject.activeInHierarchy)
                            {
                                unitValue = 0;
                                if (!Soldier0.transform.parent.gameObject.activeInHierarchy)
                                {
                                    unitValue = 1;
                                }
                            }
                        }
                    }
                }
            }
            else if (unitValue == 1)
            {
                if (!Soldier1.transform.parent.gameObject.activeInHierarchy)
                {
                    unitValue = 2;
                    if (!Soldier2.transform.parent.gameObject.activeInHierarchy)
                    {
                        unitValue = 3;
                        if (!Soldier3.transform.parent.gameObject.activeInHierarchy)
                        {
                            unitValue = 4;
                            if (!Soldier4.transform.parent.gameObject.activeInHierarchy)
                            {
                                unitValue = 5;
                                if (!Soldier5.transform.parent.gameObject.activeInHierarchy)
                                {
                                    unitValue = 0;
                                }
                            }
                        }
                    }
                }
            }
            else if (unitValue == 0)
            {
                if (!Soldier0.transform.parent.gameObject.activeInHierarchy)
                {
                    unitValue = 1;
                    if (!Soldier1.transform.parent.gameObject.activeInHierarchy)
                    {
                        unitValue = 2;
                        if (!Soldier2.transform.parent.gameObject.activeInHierarchy)
                        {
                            unitValue = 3;
                            if (!Soldier3.transform.parent.gameObject.activeInHierarchy)
                            {
                                unitValue = 4;
                                if (!Soldier4.transform.parent.gameObject.activeInHierarchy)
                                {
                                    unitValue = 5;
                                }
                            }
                        }
                    }
                }
            }
            SetUnitActive(unitValue);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            enemyTurn.SetActive(true);
            timing = true;
        }
        if (timermin >= timermax)
        {
            enemyTurn.SetActive(false);
            Soldier0.GetComponent<ModelHexManager>().movementRange = survivorlist[0].ActionPoints;
            Soldier1.GetComponent<ModelHexManager>().movementRange = survivorlist[1].ActionPoints;
            Soldier2.GetComponent<ModelHexManager>().movementRange = survivorlist[2].ActionPoints;
            Soldier3.GetComponent<ModelHexManager>().movementRange = survivorlist[3].ActionPoints;
            Soldier4.GetComponent<ModelHexManager>().movementRange = survivorlist[4].ActionPoints;
            Soldier5.GetComponent<ModelHexManager>().movementRange = survivorlist[5].ActionPoints;
            //ActiveSoldier.GetComponent<ModelHexManager>().movementRange = survivorlist[unitValue].ActionPoints;
            timermin = 0;
            timing = false;
        }
        DeadCheck();//posible issue in the future if the player has lost enough people that there arnt 6 survivors remaining in the whole world
    }
    void SetUnitActive(int unitValue)
    {
        if(unitValue == 0)
        {
            DeactivateAllUnits();
            ActiveSoldier = Soldier0;
            ActiveSurvivor = survivorlist[0];
            ActiveLocationSelecter = Soldier0LocationSelector;
        }
        else if (unitValue == 1)
        {
            DeactivateAllUnits();
            ActiveSoldier = Soldier1;
            ActiveSurvivor = survivorlist[1];
            ActiveLocationSelecter = Soldier1LocationSelector;
        }
        else if (unitValue == 2)
        {
            DeactivateAllUnits();
            ActiveSoldier = Soldier2;
            ActiveSurvivor = survivorlist[2];
            ActiveLocationSelecter = Soldier2LocationSelector;
        }
        else if (unitValue == 3)
        {
            DeactivateAllUnits();
            ActiveSoldier = Soldier3;
            ActiveSurvivor = survivorlist[3];
            ActiveLocationSelecter = Soldier3LocationSelector;
        }
        else if (unitValue == 4)
        {
            DeactivateAllUnits();
            ActiveSoldier = Soldier4;
            ActiveSurvivor = survivorlist[4];
            ActiveLocationSelecter = Soldier4LocationSelector;
        }
        else if (unitValue == 5)
        {
            DeactivateAllUnits();
            ActiveSoldier = Soldier5;
            ActiveSurvivor = survivorlist[5];
            ActiveLocationSelecter = Soldier5LocationSelector;
        }
        ActiveSoldier.SetActive(true);
        ActiveLocationSelecter.SetActive(true);
    }
    void DeactivateAllUnits()
    {
        Soldier0.SetActive(false);
        Soldier1.SetActive(false);
        Soldier2.SetActive(false);
        Soldier3.SetActive(false);
        Soldier4.SetActive(false);
        Soldier5.SetActive(false);
        Soldier0LocationSelector.SetActive(false);
        Soldier1LocationSelector.SetActive(false);
        Soldier2LocationSelector.SetActive(false);
        Soldier3LocationSelector.SetActive(false);
        Soldier4LocationSelector.SetActive(false);
        Soldier5LocationSelector.SetActive(false);
    }
    public string SurvivorWeapon()
    {
        if(!GetComponent<SetActionButtions>().primary.interactable)
        {
            return ActiveSurvivor.Weapon1.Name;
        }
        else if (!GetComponent<SetActionButtions>().secondary.interactable)
        {
            return ActiveSurvivor.Weapon2.Name;
        }
        else if (!GetComponent<SetActionButtions>().utility1.interactable)
        {
            return ActiveSurvivor.Utility1.Name;
        }
        else if (!GetComponent<SetActionButtions>().utility2.interactable)
        {
            return ActiveSurvivor.Utility2.Name;
        }
        else
        {
            return ActiveSurvivor.Utility3.Name;
        }
    }
    public void DeadCheck()
    {
        if(!survivorlist[0].Alive)
        {
            Soldier0.SetActive(true);
            Soldier0.transform.parent.gameObject.SetActive(false);
            Soldier0.SetActive(false);
        }
        if (!survivorlist[1].Alive)
        {
            Soldier1.SetActive(true);
            Soldier1.transform.parent.gameObject.SetActive(false);
            Soldier1.SetActive(false);
        }
        if (!survivorlist[2].Alive)
        {
            Soldier2.SetActive(true);
            Soldier2.transform.parent.gameObject.SetActive(false);
            Soldier2.SetActive(false);
        }
        if (!survivorlist[3].Alive)
        {
            Soldier3.SetActive(true);
            Soldier3.transform.parent.gameObject.SetActive(false);
            Soldier3.SetActive(false);
        }
        if (!survivorlist[4].Alive)
        {
            Soldier4.SetActive(true);
            Soldier4.transform.parent.gameObject.SetActive(false);
            Soldier4.SetActive(false);
        }
        if (!survivorlist[5].Alive)
        {
            Soldier5.SetActive(true);
            Soldier5.transform.parent.gameObject.SetActive(false);
            Soldier5.SetActive(false);
        }
        //int temp = 0;
        //for (int i = 0; i < BetweenPhaseData.Survivors.Length; i++)
        //{
        //    if (BetweenPhaseData.Survivors[i].OnMission)
        //    {
        //        survivorlist[temp] = BetweenPhaseData.Survivors[i];
        //        temp++;
        //    }
        //}
        if(!survivorlist[0].Alive && !survivorlist[1].Alive && !survivorlist[2].Alive && !survivorlist[3].Alive && !survivorlist[4].Alive && !survivorlist[5].Alive)
        {
            ResetStatsBeforeReturningToPhaseOne();
            for (int i = 0; i < BetweenPhaseData.CurrentMaxSurvivorCountOnMission; i++)
            {
                if(survivorlist[0].Name.Equals(BetweenPhaseData.Survivors[i].Name))
                {
                    BetweenPhaseData.Survivors[i].EqualTo(survivorlist[0]);
                }
                if (survivorlist[1].Name.Equals(BetweenPhaseData.Survivors[i].Name))
                {
                    BetweenPhaseData.Survivors[i].EqualTo(survivorlist[1]);
                }
                if (survivorlist[2].Name.Equals(BetweenPhaseData.Survivors[i].Name))
                {
                    BetweenPhaseData.Survivors[i].EqualTo(survivorlist[2]);
                }
                if (survivorlist[3].Name.Equals(BetweenPhaseData.Survivors[i].Name))
                {
                    BetweenPhaseData.Survivors[i].EqualTo(survivorlist[3]);
                }
                if (survivorlist[4].Name.Equals(BetweenPhaseData.Survivors[i].Name))
                {
                    BetweenPhaseData.Survivors[i].EqualTo(survivorlist[4]);
                }
                if (survivorlist[5].Name.Equals(BetweenPhaseData.Survivors[i].Name))
                {
                    BetweenPhaseData.Survivors[i].EqualTo(survivorlist[5]);
                }
            }
            SceneManager.LoadScene("PhaseOne");
        }
    }
    public void Escape()
    {
        ResetStatsBeforeReturningToPhaseOne();
        for (int i = 0; i < BetweenPhaseData.CurrentMaxSurvivorCountOnMission; i++)
        {
            if (survivorlist[0].Name.Equals(BetweenPhaseData.Survivors[i].Name))
            {
                BetweenPhaseData.Survivors[i].EqualTo(survivorlist[0]);
            }
            if (survivorlist[1].Name.Equals(BetweenPhaseData.Survivors[i].Name))
            {
                BetweenPhaseData.Survivors[i].EqualTo(survivorlist[1]);
            }
            if (survivorlist[2].Name.Equals(BetweenPhaseData.Survivors[i].Name))
            {
                BetweenPhaseData.Survivors[i].EqualTo(survivorlist[2]);
            }
            if (survivorlist[3].Name.Equals(BetweenPhaseData.Survivors[i].Name))
            {
                BetweenPhaseData.Survivors[i].EqualTo(survivorlist[3]);
            }
            if (survivorlist[4].Name.Equals(BetweenPhaseData.Survivors[i].Name))
            {
                BetweenPhaseData.Survivors[i].EqualTo(survivorlist[4]);
            }
            if (survivorlist[5].Name.Equals(BetweenPhaseData.Survivors[i].Name))
            {
                BetweenPhaseData.Survivors[i].EqualTo(survivorlist[5]);
            }
        }
        SceneManager.LoadScene("PhaseOne");
    }
    public void ResetStatsBeforeReturningToPhaseOne()
    {
        for (int i = 0; i < BetweenPhaseData.CurrentMaxSurvivorCountOnMission; i++)
        {
            if (survivorlist[i].ActivePerks[7].active)
            {
                survivorlist[i].Influence += 5;
            }
            if (survivorlist[i].ActivePerks[8].active)
            {
                survivorlist[i].Influence += 5;
                survivorlist[i].Senses += 5;
            }
            if (survivorlist[i].ActivePerks[13].active)
            {
                survivorlist[i].Influence += 1;
            }
            if (survivorlist[i].ActivePerks[18].active)
            {
                survivorlist[i].Intelligence -= 5;
            }
        }
    }
}
