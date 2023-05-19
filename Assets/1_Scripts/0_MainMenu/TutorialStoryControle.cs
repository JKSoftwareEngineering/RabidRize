using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialStoryControle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject StoryPage1;
    [SerializeField] private GameObject StoryPage2;
    public bool GasCanCollected;
    [SerializeField] private GameObject TutorialCar;
    [SerializeField] private GameObject TutorialCarFire;
    private bool NearCar;
    [SerializeField] private GameObject player;

    void Start()
    {
        StoryPage1.SetActive(true);
        StoryPage2.SetActive(false);
        TutorialCarFire.SetActive(false);
        GasCanCollected = false;
        NearCar = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(TutorialCar.transform.position,player.transform.position) < 22f)
        {
            NearCar = true;
        }
        else
        {
            NearCar = false;
        }

        if(GasCanCollected && NearCar)
        {
            StoryPage2.SetActive(true);
            TutorialCarFire.SetActive(true);
            GasCanCollected = false;
        }

    }
    public void Story1()
    {
        StoryPage1.SetActive(false);
    }
    public void Story2()
    {
        StoryPage2.SetActive(false);
    }
}
