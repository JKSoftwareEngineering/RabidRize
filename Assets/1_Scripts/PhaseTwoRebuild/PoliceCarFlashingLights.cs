using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceCarFlashingLights : MonoBehaviour
{
    // Start is called before the first frame update
    public Light Red;
    public Light Blue;
    private float timer;
    private float RandomWait;
    void Start()
    {
        RandomWait = Random.Range(0f, 20f);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= RandomWait)
        {
            Red.gameObject.SetActive(true);
            Blue.gameObject.SetActive(false);
        }
        if(timer >= .5f + RandomWait)
        {
            Red.gameObject.SetActive(false);
            Blue.gameObject.SetActive(true);
            timer = RandomWait - .5f;
        }
    }
}
