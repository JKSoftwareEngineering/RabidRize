using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditsControie : MonoBehaviour
{
    [SerializeField] private Button openFolder;
    [SerializeField] private Button CloseFolder;
    [SerializeField] private Button Next;
    [SerializeField] private Button Previous;
    [SerializeField] private Button title;
    [SerializeField] private GameObject folderClosed;
    [SerializeField] private GameObject folderOnePage;
    [SerializeField] private GameObject folderTwoPage;
    [SerializeField] private GameObject Me;
    [SerializeField] private GameObject Dekota;
    [SerializeField] private GameObject Nick;
    [SerializeField] private GameObject Mackenzie;
    [SerializeField] private GameObject Luke;
    [SerializeField] private GameObject SpecialThanks;
    [SerializeField] private GameObject OtherResources;
    [SerializeField] private GameObject Hidden;
    [SerializeField] private GameObject pageTurn;
    private int credPNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region folderClosed
        if (credPNum == 0)
        {
            setAllFalse();
            folderClosed.SetActive(true);
            openFolder.gameObject.SetActive(true);
        }
        #endregion
        #region Me
        if (credPNum == 1)
        {
            setAllFalse();
            folderOnePage.SetActive(true);
            Me.SetActive(true);
            Next.gameObject.SetActive(true);
            CloseFolder.gameObject.SetActive(true);
        }
        #endregion
        #region Dekota, Nick
        if (credPNum == 2)
        {
            setAllFalse();
            folderTwoPage.SetActive(true);
            Dekota.SetActive(true);
            Nick.SetActive(true);
            Next.gameObject.SetActive(true);
            Previous.gameObject.SetActive(true);
            CloseFolder.gameObject.SetActive(true);
        }
        #endregion
        #region MacKenzie, Luke
        if (credPNum == 3)
        {
            setAllFalse();
            folderTwoPage.SetActive(true);
            Mackenzie.SetActive(true);
            Luke.SetActive(true);
            Next.gameObject.SetActive(true);
            Previous.gameObject.SetActive(true);
            CloseFolder.gameObject.SetActive(true);
        }
        #endregion
        #region Thanks, Resources
        if (credPNum == 4)
        {
            setAllFalse();
            folderTwoPage.SetActive(true);
            SpecialThanks.SetActive(true);
            OtherResources.SetActive(true);
            Previous.gameObject.SetActive(true);
            CloseFolder.gameObject.SetActive(true);
        }
        #endregion
        #region Hidden
        if (BetweenPhaseData.WasThereAwesomness)
        {
            Hidden.SetActive(true);
        }
        else
        {
            Hidden.SetActive(false);
        }
        #endregion
    }
    public void NextPage()
    {
        pageTurn.SetActive(false);
        pageTurn.SetActive(true);
        credPNum +=1;
    }
    public void PreviousPage()
    {
        pageTurn.SetActive(false);
        pageTurn.SetActive(true);
        credPNum -=1;
    }
    public void Close()
    {
        credPNum = 0;
    }
    public void ToTitle()
    {
        SceneManager.LoadScene("MainMenu");
    }
    void setAllFalse()
    {
        folderClosed.SetActive(false);
        folderOnePage.SetActive(false);
        folderTwoPage.SetActive(false);
        Me.SetActive(false);
        Dekota.SetActive(false);
        Nick.SetActive(false);
        Mackenzie.SetActive(false);
        Luke.SetActive(false);
        SpecialThanks.SetActive(false);
        OtherResources.SetActive(false);
        openFolder.gameObject.SetActive(false);
        CloseFolder.gameObject.SetActive(false);
        Next.gameObject.SetActive(false);
        Previous.gameObject.SetActive(false);
    }
}
