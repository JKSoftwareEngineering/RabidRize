using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempTargetFollowsMouse : MonoBehaviour
{
    // Start is called before the first frame update
    //this is a dummy file and functionality will eventually be moved to the MapActionAcotrole script
    private GameObject Mapcamera;
    void Start()
    {
        Mapcamera = GameObject.Find("Map Camera");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cam = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        Vector3 vec = new Vector3(cam.x,cam.y,-1f)*10;
        transform.position = vec;
        if(Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject.GetComponent<TempTargetFollowsMouse>());
        }
    }
}
