using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelNavMeshConnection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.GetComponent<UnityEngine.AI.NavMeshAgent>().destination = gameObject.GetComponent<PhaseTwoMovementManager>().humanContainer.GetComponent<ModelMouseManager>().MoveTo.transform.position;
    }
}
