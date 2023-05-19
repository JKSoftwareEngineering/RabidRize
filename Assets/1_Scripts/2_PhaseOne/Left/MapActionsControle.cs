using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MapActionsControle : MonoBehaviour
{
    [SerializeField] private Button fire;
    [SerializeField] private Button soundStrike;
    [SerializeField] private Button poweroutage;
    [SerializeField] private TextMeshProUGUI firetext;
    [SerializeField] private TextMeshProUGUI soundStriketext;
    [SerializeField] private TextMeshProUGUI poweroutagetext;
    [SerializeField] private GameObject target; // this is not going to be the long run selector need an icon or model to move around... can also use a fog effect (later when particle effects are used)
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Clicked()
    {
        //Instantiate(target, new Vector3(Input.mousePosition.x, 0.09f, Input.mousePosition.z), Quaternion.identity);
        BetweenPhaseData.rawMaterial -= 100;
        firetext.text = "";
        fire.interactable = false;
        soundStriketext.text = "";
        soundStrike.interactable = false;
        poweroutagetext.text = "";
        poweroutage.interactable = false;
    }
}
