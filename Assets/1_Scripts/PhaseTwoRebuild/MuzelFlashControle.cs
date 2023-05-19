using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzelFlashControle : MonoBehaviour
{
    // Start is called before the first frame update
    private float timer;
    private bool sound = false;
    void Start()
    {
        GetComponent<Light>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(0, 1, 0);
        timer += Time.deltaTime;
        if (timer >= .3)
        {
            GetComponent<Light>().enabled = true;
            if (!sound)
            {
                GetComponent<AudioSource>().pitch = Random.Range(1, 2);
                GetComponent<AudioSource>().Play();
                sound = true;
            }
        }
        if (timer >= .35)
        {
            GetComponent<Light>().enabled = false;
        }
        if(timer>=.7f)
        {
            timer = 0f;
            sound = false;
            gameObject.SetActive(false);
        }
        
    }
}
