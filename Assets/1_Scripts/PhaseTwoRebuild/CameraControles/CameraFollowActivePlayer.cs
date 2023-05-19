using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowActivePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject cam;
    [SerializeField] private GameObject Soldier0;
    [SerializeField] private GameObject Soldier1;
    [SerializeField] private GameObject Soldier2;
    [SerializeField] private GameObject Soldier3;
    [SerializeField] private GameObject Soldier4;
    [SerializeField] private GameObject Soldier5;
    private int rotateCam = 0;
    private int rotateCamGoal = 0;
    private bool rotateLeft = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //----------------------Rotate Camera------------------------------------
        if (Input.GetKeyDown(KeyCode.Q))
        {
            rotateLeft = true;
            rotateCamGoal = rotateCam + 45;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            rotateLeft = false;
            rotateCamGoal = rotateCam - 45;
        }
        if(rotateLeft)
        {
            if(rotateCam < rotateCamGoal)
            {
                rotateCam += 5;
            }
        }
        else
        {
            if (rotateCam > rotateCamGoal)
            {
                rotateCam -= 5;
            }
        }
        cam.transform.eulerAngles = new Vector3(0, rotateCam, 0);
        //-----------------------------------------------------------------------
        if (GetComponent<ChangeSelectedMember>().unitValue == 0)
        {
            cam.transform.position = Soldier0.transform.position;
        }
        if (GetComponent<ChangeSelectedMember>().unitValue == 1)
        {
            cam.transform.position = Soldier1.transform.position;
        }
        if (GetComponent<ChangeSelectedMember>().unitValue == 2)
        {
            cam.transform.position = Soldier2.transform.position;
        }
        if (GetComponent<ChangeSelectedMember>().unitValue == 3)
        {
            cam.transform.position = Soldier3.transform.position;
        }
        if (GetComponent<ChangeSelectedMember>().unitValue == 4)
        {
            cam.transform.position = Soldier4.transform.position;
        }
        if (GetComponent<ChangeSelectedMember>().unitValue == 5)
        {
            cam.transform.position = Soldier5.transform.position;
        }
    }
}
