using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InformationControle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenUrlLink()
    {
        Application.OpenURL("https://sites.google.com/view/rabid-rize");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    //sites.google.com/view/rabidrize-survivors
    //sites.google.com/view/rabidrize-weapons
    //sites.google.com/view/rabidrize-utility
    //sites.google.com/view/rabidrize-armor
}
