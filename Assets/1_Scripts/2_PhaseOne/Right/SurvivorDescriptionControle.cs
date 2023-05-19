using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SurvivorObject;
using TMPro;

public class SurvivorDescriptionControle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject PoloroidFront;
    [SerializeField] private GameObject PoloroidBack;
    [SerializeField] private TextMeshProUGUI survivorDescriptionFront;
    [SerializeField] private TextMeshProUGUI survivorDescriptionBack;
    [SerializeField] private TextMeshProUGUI survivorNameFront;
    [SerializeField] private TextMeshProUGUI survivorNameBack;
    private Survivor[] localList = new Survivor[BetweenPhaseData.MaxSurvivorsInWorld];
    void Start()
    {
        for (int i = 0; i < BetweenPhaseData.MaxSurvivorsInWorld; i++)
        {
            localList[i] = new Survivor();
        }
        int tracker = 0;
        for(int i = 0; i < BetweenPhaseData.MaxSurvivorsInWorld; i++)
        {
            if(BetweenPhaseData.Survivors[i].Alive)
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
            survivorNameFront.text = localList[0].Name;
            
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
                                      "This is a backStory of this survivor\n";

            PoloroidBack.SetActive(false);
            survivorNameBack.gameObject.SetActive(false);
            survivorDescriptionBack.text = "";
        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 1)
        {
            PoloroidFront.SetActive(true);
            survivorNameFront.gameObject.SetActive(true);
            survivorNameFront.text = localList[1].Name;

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
                                      "This is a backStory of this survivor\n";

            PoloroidBack.SetActive(true);
            survivorNameBack.gameObject.SetActive(true);
            survivorNameBack.text = localList[2].Name;

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
                                      "This is a backStory of this survivor\n";
        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 2)
        {
            PoloroidFront.SetActive(true);
            survivorNameFront.gameObject.SetActive(true);
            survivorNameFront.text = localList[3].Name;

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
                                      "This is a backStory of this survivor\n";

            PoloroidBack.SetActive(true);
            survivorNameBack.gameObject.SetActive(true);
            survivorNameBack.text = localList[4].Name;

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
                                      "This is a backStory of this survivor\n";
        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 3)
        {
            PoloroidFront.SetActive(true);
            survivorNameFront.gameObject.SetActive(true);
            survivorNameFront.text = localList[5].Name;

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
                                      "This is a backStory of this survivor\n";

            PoloroidBack.SetActive(true);
            survivorNameBack.gameObject.SetActive(true);
            survivorNameBack.text = localList[6].Name;

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
                                      "This is a backStory of this survivor\n";
        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 4)
        {
            PoloroidFront.SetActive(true);
            survivorNameFront.gameObject.SetActive(true);
            survivorNameFront.text = localList[7].Name;

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
                                      "This is a backStory of this survivor\n";

            PoloroidBack.SetActive(true);
            survivorNameBack.gameObject.SetActive(true);
            survivorNameBack.text = localList[8].Name;

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
                                      "This is a backStory of this survivor\n";
        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 5)
        {
            PoloroidFront.SetActive(true);
            survivorNameFront.gameObject.SetActive(true);
            survivorNameFront.text = localList[9].Name;

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
                                      "This is a backStory of this survivor\n";

            PoloroidBack.SetActive(true);
            survivorNameBack.gameObject.SetActive(true);
            survivorNameBack.text = localList[10].Name;

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
                                      "This is a backStory of this survivor\n";
        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 6)
        {
            PoloroidFront.SetActive(true);
            survivorNameFront.gameObject.SetActive(true);
            survivorNameFront.text = localList[11].Name;

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
                                      "This is a backStory of this survivor\n";

            PoloroidBack.SetActive(true);
            survivorNameBack.gameObject.SetActive(true);
            survivorNameBack.text = localList[12].Name;

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
                                      "This is a backStory of this survivor\n";
        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 7)
        {
            PoloroidFront.SetActive(true);
            survivorNameFront.gameObject.SetActive(true);
            survivorNameFront.text = localList[13].Name;

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
                                      "This is a backStory of this survivor\n";

            PoloroidBack.SetActive(true);
            survivorNameBack.gameObject.SetActive(true);
            survivorNameBack.text = localList[14].Name;

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
                                      "This is a backStory of this survivor\n";
        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 8)
        {
            PoloroidFront.SetActive(true);
            survivorNameFront.gameObject.SetActive(true);
            survivorNameFront.text = localList[15].Name;

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
                                      "This is a backStory of this survivor\n";

            PoloroidBack.SetActive(true);
            survivorNameBack.gameObject.SetActive(true);
            survivorNameBack.text = localList[16].Name;

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
                                      "This is a backStory of this survivor\n";
        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 9)
        {
            PoloroidFront.SetActive(true);
            survivorNameFront.gameObject.SetActive(true);
            survivorNameFront.text = localList[17].Name;

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
                                      "This is a backStory of this survivor\n";

            PoloroidBack.SetActive(true);
            survivorNameBack.gameObject.SetActive(true);
            survivorNameBack.text = localList[18].Name;

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
                                      "This is a backStory of this survivor\n";
        }
        if (gameObject.GetComponent<RigthFolderControle>().RPageNumber == 10)
        {
            PoloroidFront.SetActive(false);
            survivorNameFront.gameObject.SetActive(false);

            survivorDescriptionFront.text = "";

            if (!localList[19].Name.Equals(""))
            {
                PoloroidBack.SetActive(true);
                survivorNameBack.gameObject.SetActive(true);
                survivorNameBack.text = localList[19].Name;

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
                                          "This is a backStory of this survivor\n";
            }
        }
        
    }
}
