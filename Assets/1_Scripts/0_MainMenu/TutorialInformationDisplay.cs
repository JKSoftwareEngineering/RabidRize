using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialInformationDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject Explosives;
    [SerializeField] private GameObject Movement;
    [SerializeField] private GameObject Attacking;
    [SerializeField] private GameObject Detection;
    [SerializeField] private GameObject Range;
    [SerializeField] private GameObject Medicine;
    [SerializeField] private GameObject NonInteractable;
    private int tutorialNum = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tutorialNum == 0)
        {
            close();
        }
        if (tutorialNum == 1)
        {
            close();
            Explosives.SetActive(true);
        }
        if (tutorialNum == 2)
        {
            close();
            Movement.SetActive(true);
        }
        if (tutorialNum == 3)
        {
            close();
            Attacking.SetActive(true);
        }
        if (tutorialNum == 4)
        {
            close();
            Detection.SetActive(true);
        }
        if (tutorialNum == 5)
        {
            close();
            Range.SetActive(true);
        }
        if (tutorialNum == 6)
        {
            close();
            Medicine.SetActive(true);
        }
        if (tutorialNum == 7)
        {
            close();
            NonInteractable.SetActive(true);
        }
        if(tutorialNum > 7)
        {
            tutorialNum = 7;
        }
        if (tutorialNum < 0)
        {
            tutorialNum = 0;
        }
    }
    public void next()
    {
        tutorialNum++;
    }
    public void previous()
    {
        tutorialNum--;
    }
    public void close()
    {
        Explosives.SetActive(false);
        Movement.SetActive(false);
        Attacking.SetActive(false);
        Detection.SetActive(false);
        Range.SetActive(false);
        Medicine.SetActive(false);
        NonInteractable.SetActive(false);
    }
    public void pageReset()
    {
        tutorialNum = 0;
    }
}
