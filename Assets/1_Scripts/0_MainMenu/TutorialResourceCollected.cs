using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialResourceCollected : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject survivorModel1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, survivorModel1.transform.position) < 4)
        {
            // i know i destroy the thing that is keeping count and therefor counting is pointless more conseptiual than anything else
            BetweenPhaseData.fuel += 50;
            GameObject.Find("GameControler").GetComponent<TutorialStoryControle>().GasCanCollected = true;
            Destroy(gameObject);
        }
    }
}
