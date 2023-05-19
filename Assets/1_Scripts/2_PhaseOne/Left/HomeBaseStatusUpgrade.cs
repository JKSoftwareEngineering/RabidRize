using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//need a base object to modify that can also be called from the button press
public class HomeBaseStatusUpgrade : MonoBehaviour
{
    [SerializeField] private GameObject Poloroid;
    [SerializeField] private TextMeshProUGUI BaseName;
    [SerializeField] private TextMeshProUGUI UpgradeListFront;
    [SerializeField] private TextMeshProUGUI UpgradeListBack;
    [SerializeField] private Button BuildNorthTower;
    [SerializeField] private Button BuildSouthTower;
    [SerializeField] private Button BuildWestTower;
    [SerializeField] private Button BuildEastTower;
    [SerializeField] private Button BuildNorthBaracades;
    [SerializeField] private Button BuildSouthBaracades;
    [SerializeField] private Button BuildWestBaracades;
    [SerializeField] private Button BuildEastBaracades;
    [SerializeField] private Button BuildInfermery;
    [SerializeField] private TextMeshProUGUI TextBuildNorthTower;
    [SerializeField] private TextMeshProUGUI TextBuildSouthTower;
    [SerializeField] private TextMeshProUGUI TextBuildWestTower;
    [SerializeField] private TextMeshProUGUI TextBuildEastTower;
    [SerializeField] private TextMeshProUGUI TextBuildNorthBaracades;
    [SerializeField] private TextMeshProUGUI TextBuildSouthBaracades;
    [SerializeField] private TextMeshProUGUI TextBuildWestBaracades;
    [SerializeField] private TextMeshProUGUI TextBuildEastBaracades;
    [SerializeField] private TextMeshProUGUI TextBuildInfermery;

    void Update()
    {
        if (gameObject.GetComponent<LeftFolderControle>().LPageNumber == 0)
        {
            Poloroid.SetActive(true);
            BaseName.gameObject.SetActive(true);
            BaseName.text = "Location";
            UpgradeListFront.text = "\n" +
                                    "\n" +
                                    "\n" +
                                    "\n" +
                                    "\n" +
                                    "\n" +
                                    "\n" +
                                    "\n" +
                                    "\n" +
                                    "Build North Tower\n" +
                                    "Build South Tower\n" +
                                    "Build West Tower\n" +
                                    "Build East Tower\n" +
                                    "Build North Baracades\n" +
                                    "Build South Baracades\n" +
                                    "Build West Baracades\n" +
                                    "Build East Baracades\n" +
                                    "Build Infermery\n" +
                                    "\n" +
                                    "\n" +
                                    "\n";

            UpgradeListBack.text = "";
        }
    }
    public void BuildNorthTowerButton()
    {
        if (BetweenPhaseData.rawMaterial >= 100)
        {
            BetweenPhaseData.rawMaterial -= 100;
            TextBuildNorthTower.text = "";
            BuildNorthTower.interactable = false;
        }
    }
    public void BuildSouthTowerButton()
    {
        if (BetweenPhaseData.rawMaterial >= 100)
        {
            BetweenPhaseData.rawMaterial -= 100;
            TextBuildSouthTower.text = "";
            BuildSouthTower.interactable = false;
        }
    }
    public void BuildWestTowerButton()
    {
        if (BetweenPhaseData.rawMaterial >= 100)
        {
            BetweenPhaseData.rawMaterial -= 100;
            TextBuildWestTower.text = "";
            BuildWestTower.interactable = false;
        }
    }
    public void BuildEastTowerButton()
    {
        if (BetweenPhaseData.rawMaterial >= 100)
        {
            BetweenPhaseData.rawMaterial -= 100;
            TextBuildEastTower.text = "";
            BuildEastTower.interactable = false;
        }
    }
    public void BuildNorthBaracadesButton()
    {
        if (BetweenPhaseData.rawMaterial >= 100)
        {
            BetweenPhaseData.rawMaterial -= 100;
            TextBuildNorthBaracades.text = "";
            BuildNorthBaracades.interactable = false;
        }
    }
    public void BuildSouthBaracadesButton()
    {
        if (BetweenPhaseData.rawMaterial >= 100)
        {
            BetweenPhaseData.rawMaterial -= 100;
            TextBuildSouthBaracades.text = "";
            BuildSouthBaracades.interactable = false;
        }
    }
    public void BuildWestBaracadesButton()
    {
        if (BetweenPhaseData.rawMaterial >= 100)
        {
            BetweenPhaseData.rawMaterial -= 100;
            TextBuildWestBaracades.text = "";
            BuildWestBaracades.interactable = false;
        }
    }
    public void BuildEastBaracadesButton()
    {
        if (BetweenPhaseData.rawMaterial >= 100)
        {
            BetweenPhaseData.rawMaterial -= 100;
            TextBuildEastBaracades.text = "";
            BuildEastBaracades.interactable = false;
        }
    }
    public void BuildInfermeryButton()
    {
        if (BetweenPhaseData.rawMaterial >= 100)
        {
            BetweenPhaseData.rawMaterial -= 100;
            TextBuildInfermery.text = "";
            BuildInfermery.interactable = false;
        }
    }
}
