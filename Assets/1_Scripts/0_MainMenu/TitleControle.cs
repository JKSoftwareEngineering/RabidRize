using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class TitleControle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Image background;
    [SerializeField] private GameObject activateButtons;
    private float timer = 0;
    private float timerMax = .1f;
    private int ImageRef = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= timerMax)
        {
            timer = 0;
            ImageRef++;
            if(ImageRef == 61)
            {
                ImageRef = 60;
                activateButtons.SetActive(true);
            }
        }
        background.sprite = Resources.Load<Sprite>("TitleInFrames\\"+ImageRef);
    }
}
