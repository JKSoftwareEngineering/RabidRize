using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using SurvivorObject;

public class SurvivorLostControle : MonoBehaviour
{
    [SerializeField] private GameObject PoloroidFront;
    [SerializeField] private GameObject PoloroidBack;
    [SerializeField] private TextMeshProUGUI survivorDescriptionFront;
    [SerializeField] private TextMeshProUGUI survivorDescriptionBack;
    [SerializeField] private TextMeshProUGUI survivorNameFront;
    [SerializeField] private TextMeshProUGUI survivorNameBack;
    private Survivor[] localList = new Survivor[BetweenPhaseData.MaxSurvivorsInWorld];
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < BetweenPhaseData.MaxSurvivorsInWorld; i++)
        {
            localList[i] = new Survivor();
        }
        int tracker = 0;
        for (int i = 0; i < BetweenPhaseData.MaxSurvivorsInWorld; i++)
        {
            if (!(BetweenPhaseData.Survivors[i].Alive))
            {
                localList[tracker] = BetweenPhaseData.Survivors[i];
                tracker++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 0)
        {
            PoloroidFront.SetActive(true);
            survivorNameFront.gameObject.SetActive(true);
            if (localList[0].Name.Equals(""))
            {
                PoloroidFront.SetActive(false);
                survivorNameFront.gameObject.SetActive(false);
            }
            survivorNameFront.text = localList[0].Name;
            if (!localList[0].Name.Equals(""))
            {
                survivorDescriptionFront.text = "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "This person is dead\n";
            }
            PoloroidBack.SetActive(false);
            survivorNameBack.gameObject.SetActive(false);
            survivorDescriptionBack.text = "";
        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 1)
        {
            PoloroidFront.SetActive(true);
            survivorNameFront.gameObject.SetActive(true);
            if (localList[1].Name.Equals(""))
            {
                PoloroidFront.SetActive(false);
                survivorNameFront.gameObject.SetActive(false);
            }
            survivorNameFront.text = localList[1].Name;
            if (!localList[1].Name.Equals(""))
            {
                survivorDescriptionFront.text = "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "This person is dead\n";
            }
            else
            {
                survivorDescriptionFront.text = ""; // placeholder for text control for the presentation
            }
            PoloroidBack.SetActive(true);
            survivorNameBack.gameObject.SetActive(true);
            if (localList[2].Name.Equals(""))
            {
                PoloroidBack.SetActive(false);
                survivorNameBack.gameObject.SetActive(false);
            }
            survivorNameBack.text = localList[2].Name;
            if (!localList[2].Name.Equals(""))
            {
                survivorDescriptionBack.text = "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "This person is dead\n";
            }
        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 2)
        {
            PoloroidFront.SetActive(true);
            survivorNameFront.gameObject.SetActive(true);
            if (localList[3].Name.Equals(""))
            {
                PoloroidFront.SetActive(false);
                survivorNameFront.gameObject.SetActive(false);
            }
            survivorNameFront.text = localList[3].Name;
            if (!localList[3].Name.Equals(""))
            {
                survivorDescriptionFront.text = "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "This person is dead\n";
            }
            PoloroidBack.SetActive(true);
            survivorNameBack.gameObject.SetActive(true);
            if (localList[4].Name.Equals(""))
            {
                PoloroidBack.SetActive(false);
                survivorNameBack.gameObject.SetActive(false);
            }
            survivorNameBack.text = localList[4].Name;
            if (!localList[4].Name.Equals(""))
            {
                survivorDescriptionBack.text = "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "This person is dead\n";
            }
        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 3)
        {
            PoloroidFront.SetActive(true);
            survivorNameFront.gameObject.SetActive(true);
            if (localList[5].Name.Equals(""))
            {
                PoloroidFront.SetActive(false);
                survivorNameFront.gameObject.SetActive(false);
            }
            survivorNameFront.text = localList[5].Name;
            if (!localList[5].Name.Equals(""))
            {
                survivorDescriptionFront.text = "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "This person is dead\n";
            }
            PoloroidBack.SetActive(true);
            survivorNameBack.gameObject.SetActive(true);
            if (localList[6].Name.Equals(""))
            {
                PoloroidBack.SetActive(false);
                survivorNameBack.gameObject.SetActive(false);
            }
            survivorNameBack.text = localList[6].Name;
            if (!localList[6].Name.Equals(""))
            {
                survivorDescriptionBack.text = "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "This person is dead\n";
            }
        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 4)
        {
            PoloroidFront.SetActive(true);
            survivorNameFront.gameObject.SetActive(true);
            if (localList[7].Name.Equals(""))
            {
                PoloroidFront.SetActive(false);
                survivorNameFront.gameObject.SetActive(false);
            }
            survivorNameFront.text = localList[7].Name;
            if (!localList[7].Name.Equals(""))
            {
                survivorDescriptionFront.text = "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "This person is dead\n";
            }

            PoloroidBack.SetActive(true);
            survivorNameBack.gameObject.SetActive(true);
            if (localList[8].Name.Equals(""))
            {
                PoloroidBack.SetActive(false);
                survivorNameBack.gameObject.SetActive(false);
            }
            survivorNameBack.text = localList[8].Name;
            if (!localList[8].Name.Equals(""))
            {
                survivorDescriptionBack.text = "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "This person is dead\n";
            }
        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 5)
        {
            PoloroidFront.SetActive(true);
            survivorNameFront.gameObject.SetActive(true);
            if (localList[9].Name.Equals(""))
            {
                PoloroidFront.SetActive(false);
                survivorNameFront.gameObject.SetActive(false);
            }
            survivorNameFront.text = localList[9].Name;
            if (!localList[9].Name.Equals(""))
            {
                survivorDescriptionFront.text = "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "This person is dead\n";
            }
            PoloroidBack.SetActive(true);
            survivorNameBack.gameObject.SetActive(true);
            if (localList[10].Name.Equals(""))
            {
                PoloroidBack.SetActive(false);
                survivorNameBack.gameObject.SetActive(false);
            }
            survivorNameBack.text = localList[10].Name;
            if (!localList[10].Name.Equals(""))
            {
                survivorDescriptionBack.text = "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "This person is dead\n";
            }
        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 6)
        {
            PoloroidFront.SetActive(true);
            survivorNameFront.gameObject.SetActive(true);
            if (localList[11].Name.Equals(""))
            {
                PoloroidFront.SetActive(false);
                survivorNameFront.gameObject.SetActive(false);
            }
            survivorNameFront.text = localList[11].Name;
            if (!localList[11].Name.Equals(""))
            {
                survivorDescriptionFront.text = "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "This person is dead\n";
            }
            PoloroidBack.SetActive(true);
            survivorNameBack.gameObject.SetActive(true);
            if (localList[12].Name.Equals(""))
            {
                PoloroidBack.SetActive(false);
                survivorNameBack.gameObject.SetActive(false);
            }
            survivorNameBack.text = localList[12].Name;
            if (!localList[12].Name.Equals(""))
            {
                survivorDescriptionBack.text = "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "This person is dead\n";
            }
        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 7)
        {
            PoloroidFront.SetActive(true);
            survivorNameFront.gameObject.SetActive(true);
            if (localList[13].Name.Equals(""))
            {
                PoloroidFront.SetActive(false);
                survivorNameFront.gameObject.SetActive(false);
            }
            survivorNameFront.text = localList[13].Name;
            if (!localList[13].Name.Equals(""))
            {
                survivorDescriptionFront.text = "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "This person is dead\n";
            }
            PoloroidBack.SetActive(true);
            survivorNameBack.gameObject.SetActive(true);
            if (localList[14].Name.Equals(""))
            {
                PoloroidBack.SetActive(false);
                survivorNameBack.gameObject.SetActive(false);
            }
            survivorNameBack.text = localList[14].Name;
            if (!localList[14].Name.Equals(""))
            {
                survivorDescriptionBack.text = "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "This person is dead\n";
            }
        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 8)
        {
            PoloroidFront.SetActive(true);
            survivorNameFront.gameObject.SetActive(true);
            if (localList[15].Name.Equals(""))
            {
                PoloroidFront.SetActive(false);
                survivorNameFront.gameObject.SetActive(false);
            }
            survivorNameFront.text = localList[15].Name;
            if (!localList[15].Name.Equals(""))
            {
                survivorDescriptionFront.text = "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "This person is dead\n";
            }
            PoloroidBack.SetActive(true);
            survivorNameBack.gameObject.SetActive(true);
            if (localList[16].Name.Equals(""))
            {
                PoloroidBack.SetActive(false);
                survivorNameBack.gameObject.SetActive(false);
            }
            survivorNameBack.text = localList[16].Name;
            if (!localList[16].Name.Equals(""))
            {
                survivorDescriptionBack.text = "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "This person is dead\n";
            }
        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 9)
        {
            PoloroidFront.SetActive(true);
            survivorNameFront.gameObject.SetActive(true);
            if (localList[17].Name.Equals(""))
            {
                PoloroidFront.SetActive(false);
                survivorNameFront.gameObject.SetActive(false);
            }
            survivorNameFront.text = localList[17].Name;
            if (!localList[17].Name.Equals(""))
            {
                survivorDescriptionFront.text = "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "This person is dead\n";
            }
            PoloroidBack.SetActive(true);
            survivorNameBack.gameObject.SetActive(true);
            if (localList[18].Name.Equals(""))
            {
                PoloroidBack.SetActive(false);
                survivorNameBack.gameObject.SetActive(false);
            }
            survivorNameBack.text = localList[18].Name;
            if (!localList[18].Name.Equals(""))
            {
                survivorDescriptionBack.text = "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "This person is dead\n";
            }
        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 10)
        {
            PoloroidFront.SetActive(false);
            survivorNameFront.gameObject.SetActive(false);

            survivorDescriptionFront.text = "";

            PoloroidBack.SetActive(true);
            survivorNameBack.gameObject.SetActive(true);
            if (localList[19].Name.Equals(""))
            {
                PoloroidBack.SetActive(false);
                survivorNameBack.gameObject.SetActive(false);
            }
            survivorNameBack.text = localList[19].Name;
            if (!localList[19].Name.Equals(""))
            {
                survivorDescriptionBack.text = "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "This person is dead\n";
            }
        }
    }
}
