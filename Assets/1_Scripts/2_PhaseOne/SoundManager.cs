using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject background1;
    public GameObject background2;
    public GameObject pageTurn;
    private float timermin = 0;
    private float timermax;
    private int selected = 0;
    void Start()
    {
        selected = (int)Random.Range(0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        pageTurn.GetComponent<AudioSource>().pitch = Random.Range(1f, 2f);
        if (selected == 0)
        {
            background1.SetActive(true);
            timermax = 283f;
            timermin += Time.deltaTime;
            if(timermin >= timermax)
            {
                background1.SetActive(false);
                selected = (int)Random.Range(0, 2);
                timermin = 0f;
            }
        }
        if (selected == 1)
        {
            background2.SetActive(true);
            timermax = 123f;
            timermin += Time.deltaTime;
            if (timermin >= timermax)
            {
                background2.SetActive(false);
                selected = (int)Random.Range(0, 2);
                timermin = 0f;
            }
        }
        
    }
}
