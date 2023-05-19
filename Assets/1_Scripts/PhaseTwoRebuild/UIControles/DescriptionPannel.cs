using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using SurvivorObject;

public class DescriptionPannel : MonoBehaviour
{
    // Start is called before the first frame update
    private bool activatePannel;
    [SerializeField] private Button pannel;
    [SerializeField] private TextMeshProUGUI pannelText;
    [SerializeField] private TextMeshProUGUI SurvivorName;
    [SerializeField] private TextMeshProUGUI WeaponSelected;
    [SerializeField] private TextMeshProUGUI SurvivorHp;
    [SerializeField] private TextMeshProUGUI SurvivorAp;
    [SerializeField] private TextMeshProUGUI EnemySelected;
    public TextMeshProUGUI EnemySelectedHealth;
    public TextMeshProUGUI EnemySelectedAction;
    [SerializeField] private TextMeshProUGUI OddsOfHit;

    //[SerializeField] private GameObject Soldier0;
    //[SerializeField] private GameObject Soldier1;
    //[SerializeField] private GameObject Soldier2;
    //[SerializeField] private GameObject Soldier3;
    //[SerializeField] private GameObject Soldier4;
    //[SerializeField] private GameObject Soldier5;

    private float DescriptionPannelspeed = 10f;
    void Start()
    {
        activatePannel = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (activatePannel)
        {
            if (pannel.GetComponent<RectTransform>().localPosition.x > 109)
            {
                Vector3 temp = new Vector3(pannel.GetComponent<RectTransform>().localPosition.x - DescriptionPannelspeed, pannel.GetComponent<RectTransform>().localPosition.y, pannel.GetComponent<RectTransform>().localPosition.z);
                pannel.GetComponent<RectTransform>().localPosition = temp;
                pannelText.text = ">";
            }
        }
        if (!activatePannel)
        {
            if (pannel.GetComponent<RectTransform>().localPosition.x < 387)
            {
                Vector3 temp = new Vector3(pannel.GetComponent<RectTransform>().localPosition.x + DescriptionPannelspeed, pannel.GetComponent<RectTransform>().localPosition.y, pannel.GetComponent<RectTransform>().localPosition.z);
                pannel.GetComponent<RectTransform>().localPosition = temp;
                pannelText.text = "<";
            }
        }
        if (GetComponent<ChangeSelectedMember>().ActiveSurvivor == null)
        {
            SurvivorName.text = "";
            WeaponSelected.text = "N/A";
            SurvivorHp.text = "HP: N/A";
            SurvivorAp.text = "AP: N/A";
        }
        else
        {
            SurvivorName.text = "" + GetComponent<ChangeSelectedMember>().ActiveSurvivor.Name;
            WeaponSelected.text = "" + GetComponent<ChangeSelectedMember>().SurvivorWeapon();
            SurvivorHp.text = "HP: " + GetComponent<ChangeSelectedMember>().ActiveSurvivor.Health;
            SurvivorAp.text = "AP: " + GetComponent<ChangeSelectedMember>().ActiveSurvivor.ActionPoints;
        }
        if (GetComponent<SetEnemyListButtons>().enemySelected == null)
        {
            EnemySelected.text = "";
            EnemySelectedHealth.text = "HP: N/A";
            EnemySelectedAction.text = "AP: N/A";
        }
        else
        {
            EnemySelected.text = "" + GetComponent<SetEnemyListButtons>().enemySelected.gameObject.GetComponent<InfectedAI>().LocalInfected.Name;
            EnemySelectedHealth.text = "HP: " + GetComponent<SetEnemyListButtons>().enemySelected.gameObject.GetComponent<InfectedAI>().LocalInfected.Health;
            EnemySelectedAction.text = "AP: " + GetComponent<SetEnemyListButtons>().enemySelected.gameObject.GetComponent<InfectedAI>().LocalInfected.ActionPoints;
        }
        OddsOfHit.text = "" + (int)GetComponent<ChangeSelectedMember>().ActiveSoldier.GetComponent<ModelMouseManager>().currentOdds + "%";
    }
    public void Activate()
    {
        activatePannel = !activatePannel;
    }
}
