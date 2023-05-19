using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MissionObject;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MissionControle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject page;
    [SerializeField] GameObject missionButton;
    [SerializeField] GameObject placePageSound;
    [SerializeField] Button LoadPhaseTwo;
    public TextMeshProUGUI CostVal;
    public TextMeshProUGUI RewardsVal;
    public Slider Light;
    public Slider Noise;
    public Slider Contagion;
    private static Mission foodMission = new Mission();
    private static Mission fuelMission = new Mission();
    private static Mission medicineMission = new Mission();
    private static Mission rawMaterialMission = new Mission();

    void Start()
    {
        foodMission.GenerateRandomCost();
        foodMission.RewardFood = (int)Random.Range(50, 101);
        foodMission.Name = " Food";
        foodMission.GenerateRandomConditions();

        fuelMission.GenerateRandomCost();
        fuelMission.RewardFuel = (int)Random.Range(50, 101);
        fuelMission.Name = " Fuel";
        fuelMission.GenerateRandomConditions();

        medicineMission.GenerateRandomCost();
        medicineMission.RewardMedicine = (int)Random.Range(50, 101);
        medicineMission.Name = " Medicine";
        medicineMission.GenerateRandomConditions();

        rawMaterialMission.GenerateRandomCost();
        rawMaterialMission.RewardRawMaterials = (int)Random.Range(50, 101);
        rawMaterialMission.Name = " Supplys";
        rawMaterialMission.GenerateRandomConditions();
    }

    public void addPage()
    {
        page.SetActive(true);
        PlacePageSound();
    }
    public void addPageFood()
    {
        AssembleTheMission(foodMission);
    }
    public void addPageFuel()
    {
        AssembleTheMission(fuelMission);
    }
    public void addPageMedicine()
    {
        AssembleTheMission(medicineMission);
    }
    public void addPageRawMaterials()
    {
        AssembleTheMission(rawMaterialMission);
    }
    public void ResourceCostWithinBounds(Mission mission)
    {
        //missions will either cost food if close to the base or fuel if far from the base
        //if no fuel and far from the base then cost a lot of food.
        if (mission.CostFood > 0)
        {
            CostVal.text = "" + mission.CostFood + " Food";
        }
        else
        {
            CostVal.text = "" + mission.CostFuel + " Fuel";
        }
    }
    public void AssembleTheMission(Mission mission)
    { 
        addPage();
        ResourceCostWithinBounds(mission);
        RewardsVal.text = "" + mission.RewardFood + mission.Name;
        Light.value = mission.Light;
        Noise.value = mission.Noise;
        Contagion.value = mission.Contagion;
    }
    public void RemovePage()
    {
        page.SetActive(false);
    }
    public void PlacePageSound()
    {
        //sound is based on a onAwake gameObject
        placePageSound.SetActive(false);
        placePageSound.SetActive(true);
    }
    public void PhaseTwoLoad()
    {
        //------loads the test map------
        //SceneManager.LoadScene("PhaseTwoRebuild");
        //------------------------------
        SceneManager.LoadScene("PhaseTwo");
    }
}
