using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceManager : MonoBehaviour
{
    //this is a display script only with no functionality
    [SerializeField] TextMeshProUGUI Food;
    [SerializeField] TextMeshProUGUI Fuel;
    [SerializeField] TextMeshProUGUI Medical;
    [SerializeField] TextMeshProUGUI RawMaterial;
    // Update is called once per frame
    void Update()
    {
        Food.text = "" + BetweenPhaseData.food;
        Fuel.text = "" + BetweenPhaseData.fuel;
        Medical.text = "" + BetweenPhaseData.medical;
        RawMaterial.text = "" + BetweenPhaseData.rawMaterial;
    }
}
