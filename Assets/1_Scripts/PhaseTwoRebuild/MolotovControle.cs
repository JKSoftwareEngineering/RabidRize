using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MolotovControle : MonoBehaviour
{
    // Start is called before the first frame update
    SetEnemyListButtons opp;
    private float timer = 1000;
    void Start()
    {
        opp = GameObject.Find("GameControler").GetComponent<SetEnemyListButtons>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            timer = 0f;
        }
        if(timer <= 2f)
        {
            foreach (GameObject n in opp.enemysAvailable)
            {
                if (Vector3.Distance(n.transform.position, transform.position) < 53.35f)//9*6.15
                {
                    n.gameObject.GetComponent<InfectedAI>().LocalInfected.Health -= 1;
                }
            }
        }
    }
}
