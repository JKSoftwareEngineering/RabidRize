using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseTwoMovementManager : MonoBehaviour
{
    //this is a model script for movemnt
    //all movement from this point will be model based
    public GameObject humanContainer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //force the container to follow the model
        humanContainer.transform.position = transform.position;
    }
}
