using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InfectedObject;

public class TutorialInfectedSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    private int SpawnCount = 30;
    void Start()
    {
        for (int i = 0; i < SpawnCount; i++)
        {
            GameObject infected = Instantiate(prefab, new Vector3(transform.position.x + Random.Range(-200, 200f), 0, transform.position.z + Random.Range(-200, 200f)), prefab.transform.rotation);
            Infected zed = new Infected();
            infected.name = zed.Name;
            zed.ActionPoints = Random.Range(5, 10);
            zed.Health = (int)Random.Range(20, 80);
            infected.GetComponent<InfectedAI>().LocalInfected = zed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
