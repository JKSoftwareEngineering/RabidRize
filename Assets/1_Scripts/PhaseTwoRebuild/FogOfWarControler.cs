using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogOfWarControler : MonoBehaviour
{
    public GameObject player1;
    public GameObject FogContainer1;
    public GameObject player2;
    public GameObject FogContainer2;
    public GameObject player3;
    public GameObject FogContainer3;
    public GameObject player4;
    public GameObject FogContainer4;
    public GameObject player5;
    public GameObject FogContainer5;
    public GameObject player6;
    public GameObject FogContainer6;
    ChangeSelectedMember who;
    void Start()
    {
        who = GameObject.Find("GameControler").GetComponent<ChangeSelectedMember>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player1.activeInHierarchy)
        {
            FogContainer1.gameObject.transform.LookAt(new Vector3(player1.transform.position.x, player1.transform.position.y, player1.transform.position.z));
            FogContainer1.gameObject.transform.localScale = new Vector3(who.survivorlist[0].Senses * .07f, who.survivorlist[0].Senses * .07f, FogContainer1.gameObject.transform.localScale.z);
        }
        if (player2.activeInHierarchy)
        {
            FogContainer2.gameObject.transform.LookAt(new Vector3(player2.transform.position.x, player2.transform.position.y, player2.transform.position.z));
            FogContainer2.gameObject.transform.localScale = new Vector3(who.survivorlist[1].Senses * .07f, who.survivorlist[1].Senses * .07f, FogContainer2.gameObject.transform.localScale.z);
        }
        if (player3.activeInHierarchy)
        {
            FogContainer3.gameObject.transform.LookAt(new Vector3(player3.transform.position.x, player3.transform.position.y, player3.transform.position.z));
            FogContainer3.gameObject.transform.localScale = new Vector3(who.survivorlist[2].Senses * .07f, who.survivorlist[2].Senses * .07f, FogContainer3.gameObject.transform.localScale.z);
        }
        if (player4.activeInHierarchy)
        {
            FogContainer4.gameObject.transform.LookAt(new Vector3(player4.transform.position.x, player4.transform.position.y, player4.transform.position.z));
            FogContainer4.gameObject.transform.localScale = new Vector3(who.survivorlist[3].Senses * .07f, who.survivorlist[3].Senses * .07f, FogContainer4.gameObject.transform.localScale.z);
        }
        if (player5.activeInHierarchy)
        {
            FogContainer5.gameObject.transform.LookAt(new Vector3(player5.transform.position.x, player5.transform.position.y, player5.transform.position.z));
            FogContainer5.gameObject.transform.localScale = new Vector3(who.survivorlist[4].Senses * .07f, who.survivorlist[4].Senses * .07f, FogContainer5.gameObject.transform.localScale.z);
        }
        if (player6.activeInHierarchy)
        {
            FogContainer6.gameObject.transform.LookAt(new Vector3(player6.transform.position.x, player6.transform.position.y, player6.transform.position.z));
            FogContainer6.gameObject.transform.localScale = new Vector3(who.survivorlist[5].Senses * .07f, who.survivorlist[5].Senses * .07f, FogContainer6.gameObject.transform.localScale.z);
        }
        if(!player1.transform.parent.gameObject.activeInHierarchy)
        {
            FogContainer1.SetActive(false);
        }
        if (!player2.transform.parent.gameObject.activeInHierarchy)
        {
            FogContainer2.SetActive(false);
        }
        if (!player3.transform.parent.gameObject.activeInHierarchy)
        {
            FogContainer3.SetActive(false);
        }
        if (!player4.transform.parent.gameObject.activeInHierarchy)
        {
            FogContainer4.SetActive(false);
        }
        if (!player5.transform.parent.gameObject.activeInHierarchy)
        {
            FogContainer5.SetActive(false);
        }
        if (!player6.transform.parent.gameObject.activeInHierarchy)
        {
            FogContainer6.SetActive(false);
        }
    }
}
