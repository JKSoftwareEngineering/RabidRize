using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetingCameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject cam;
    [SerializeField] private GameObject camPosition;
    [SerializeField] private GameObject ModelDirection;
    public GameObject target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            cam.GetComponent<Camera>().orthographicSize = 2;
            cam.transform.position = camPosition.transform.position;
            cam.transform.LookAt(target.transform.position);
            ModelDirection.transform.LookAt(target.transform.position);
        }
    }
}
