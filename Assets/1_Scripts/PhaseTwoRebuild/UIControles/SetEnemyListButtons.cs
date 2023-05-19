using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetEnemyListButtons : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Button[] enemyList = new Button [16];
    [HideInInspector] public GameObject[] enemysAvailable;
    private GameObject[] SurvivorEnemiesAvailable = new GameObject[16];
    public GameObject enemySelected;
    public GameObject enemySelectedPosition;
    private int ButtonCounter = 0;
    void Start()
    {
        enemySelected = null;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Vector3.Distance(enemysAvailable[i].transform.position, GetComponent<ChangeSelectedMember>().ActiveSoldier.transform.position) > 61.5f)
        //{
        //}
        enemysAvailable = GameObject.FindGameObjectsWithTag("Enemy");
        ButtonCounter = 0;
        for(int i = 0; i < 16; i++)
        {
            enemyList[i].gameObject.SetActive(false);
        }
        for(int i = 0; i < enemysAvailable.Length; i++)
        {
            if (Vector3.Distance(enemysAvailable[i].transform.position, GetComponent<ChangeSelectedMember>().ActiveSoldier.transform.position) < 61.5f)
            {
                enemyList[ButtonCounter].gameObject.SetActive(true);
                SurvivorEnemiesAvailable[ButtonCounter] = enemysAvailable[i];
                ButtonCounter++;
            }
            if(ButtonCounter > 16)
            {
                break;
            }
        }
        //for(int i = enemysAvailable.Length; i < 16; i++)
        //{
        //    enemyList[i].gameObject.SetActive(false);
        //}

        for(int i = 0; i < enemyList.Length; i++)
        {
            if (enemyList[i].interactable == false)
            {
                enemySelected = SurvivorEnemiesAvailable[i];
                enemySelectedPosition.transform.position = SurvivorEnemiesAvailable[i].transform.position;
                enemySelected.transform.GetChild(1).gameObject.SetActive(true);
            }
        }
    }

    public void enemy1()
    {
        Deactivate();
        enemyList[0].interactable = false;
    }
    public void enemy2()
    {
        Deactivate();
        enemyList[1].interactable = false;
    }
    public void enemy3()
    {
        Deactivate();
        enemyList[2].interactable = false;
    }
    public void enemy4()
    {
        Deactivate();
        enemyList[3].interactable = false;
    }
    public void enemy5()
    {
        Deactivate();
        enemyList[4].interactable = false;
    }
    public void enemy6()
    {
        Deactivate();
        enemyList[5].interactable = false;
    }
    public void enemy7()
    {
        Deactivate();
        enemyList[6].interactable = false;
    }
    public void enemy8()
    {
        Deactivate();
        enemyList[7].interactable = false;
    }
    public void enemy9()
    {
        Deactivate();
        enemyList[8].interactable = false;
    }
    public void enemy10()
    {
        Deactivate();
        enemyList[9].interactable = false;
    }
    public void enemy11()
    {
        Deactivate();
        enemyList[10].interactable = false;
    }
    public void enemy12()
    {
        Deactivate();
        enemyList[11].interactable = false;
    }
    public void enemy13()
    {
        Deactivate();
        enemyList[12].interactable = false;
    }
    public void enemy14()
    {
        Deactivate();
        enemyList[13].interactable = false;
    }
    public void enemy15()
    {
        Deactivate();
        enemyList[14].interactable = false;
    }
    public void enemy16()
    {
        Deactivate();
        enemyList[15].interactable = false;
    }
    public void Deactivate()
    {
        for(int i = 0; i < 16; i++)
        {
            enemyList[i].interactable = true;
        }
        for (int i = 0; i < enemysAvailable.Length; i++)
        {
            enemysAvailable[i].transform.GetChild(1).gameObject.SetActive(false); ;
        }
    }
}
