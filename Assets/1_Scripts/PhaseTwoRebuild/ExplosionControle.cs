using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionControle : MonoBehaviour
{
    // Start is called before the first frame update
    private float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2.5f)
        {
            timer = 0f;
            gameObject.SetActive(false);
        }
    }
}
