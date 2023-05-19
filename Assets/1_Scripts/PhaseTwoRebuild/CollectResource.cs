﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectResource : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject survivorModel1;
    public GameObject survivorModel2;
    public GameObject survivorModel3;
    public GameObject survivorModel4;
    public GameObject survivorModel5;
    public GameObject survivorModel6;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, survivorModel1.transform.position) < 4 
            || Vector3.Distance(transform.position, survivorModel2.transform.position) < 4
            || Vector3.Distance(transform.position, survivorModel3.transform.position) < 4
            || Vector3.Distance(transform.position, survivorModel4.transform.position) < 4
            || Vector3.Distance(transform.position, survivorModel5.transform.position) < 4
            || Vector3.Distance(transform.position, survivorModel6.transform.position) < 4)
        {
            // i know i destroy the thing that is keeping count and therefor counting is pointless more conseptiual than anything else
            BetweenPhaseData.fuel += 50;
            Destroy(gameObject);
        }
    }
}
