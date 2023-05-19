using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeDetection : MonoBehaviour
{
    // Start is called before the first frame update
    /*[HideInInspector]*/ public GameObject target;
    /*[HideInInspector]*/ public GameObject target2;
    /*[HideInInspector]*/
    public int Range;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.transform.position, target2.transform.position);
        Range = (int)(distance/6.015f);
    }
}
