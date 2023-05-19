using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerPhasetwo : MonoBehaviour
{
    public GameObject background1;
    public GameObject background2;
    public GameObject Combat;
    public bool CombatActive = false;
    private float timermin = 0;
    private float timermax;
    private int selected = 0;
    // Start is called before the first frame update
    void Start()
    {
        selected = (int)Random.Range(0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (selected == 0 && !CombatActive)
        {
            background1.SetActive(true);
            timermax = 283f;
            timermin += Time.deltaTime;
            if (timermin >= timermax)
            {
                background1.SetActive(false);
                selected = (int)Random.Range(0, 2);
                timermin = 0f;
            }
        }
        if (selected == 1 && !CombatActive)
        {
            background2.SetActive(true);
            timermax = 72f;
            timermin += Time.deltaTime;
            if (timermin >= timermax)
            {
                background2.SetActive(false);
                selected = (int)Random.Range(0, 2);
                timermin = 0f;
            }
        }
        if (CombatActive)
        {
            Combat.SetActive(true);
            timermax = 299f;
            timermin += Time.deltaTime;
            if (timermin >= timermax)
            {
                timermin = 0f;
                CombatActive = false;
                selected = (int)Random.Range(0, 2);
            }
        }
        if(!CombatActive)
        {
            Combat.SetActive(false);
        }
    }
}
