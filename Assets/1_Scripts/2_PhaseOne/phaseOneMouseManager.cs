using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phaseOneMouseManager : MonoBehaviour
{
    public Camera Cam;
    public GameObject ClickSound;
    private float PanSpeed = .3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        //Debug.Log("Vec "+vec.x+" "+vec.y+" "+vec.z);
        if(vec.x > 0.9f )
        {
            if (Cam.transform.position.x + PanSpeed < 16.1f)
            {
                Vector3 vec2 = new Vector3(Cam.transform.position.x + PanSpeed, Cam.transform.position.y, Cam.transform.position.z);
                Cam.transform.position = vec2;
            }
        }
        if (vec.x < 0.1f)
        {
            if (Cam.transform.position.x - PanSpeed > -6.1f)
            {
                Vector3 vec2 = new Vector3(Cam.transform.position.x - PanSpeed, Cam.transform.position.y, Cam.transform.position.z);
                Cam.transform.position = vec2;
            }
        }
        if(Input.GetMouseButtonDown(0))
        {
            ClickSound.SetActive(false);
            ClickSound.SetActive(true);
        }
    }
}
