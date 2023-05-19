using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparancyScript : MonoBehaviour
{
    void Start(){}
    void Update(){}
    //switch object  between fade and opaque on each call
    //i think i will use the cutout for the buildings and fade for concealed, ghosted, and objects of interest
    public void CutCutControle(GameObject Object)
    {
        if (Object.GetComponent<Renderer>() == null)
        {
            return;
        }
        else if (Object.GetComponent<Renderer>().material == null)
        {
            return;
        }
        Color C = Object.GetComponent<Renderer>().material.color;
        if (C.a == 1f)
        {
            C.a = .25f;
            Object.GetComponent<Renderer>().material.DisableKeyword("_ALPHABLEND_ON");
            Object.GetComponent<Renderer>().material.EnableKeyword("_ALPHATEST_ON");
            Object.GetComponent<Renderer>().material.DisableKeyword("_ALPHAPREMULTIPLY_ON");
            Object.GetComponent<Renderer>().material.color = C;
        }
        else
        {
            C.a = 1;
            Object.GetComponent<Renderer>().material.DisableKeyword("_ALPHABLEND_ON");
            Object.GetComponent<Renderer>().material.DisableKeyword("_ALPHATEST_ON");
            Object.GetComponent<Renderer>().material.DisableKeyword("_ALPHAPREMULTIPLY_ON");
            Object.GetComponent<Renderer>().material.color = C;
        }
    }
    public void TransparentControle(GameObject Object)
    {
        if (Object.GetComponent<Renderer>() == null)
        {
            return;
        }
        else if (Object.GetComponent<Renderer>().material == null)
        {
            return;
        }
        Color C = Object.GetComponent<Renderer>().material.color;
        if (C.a == 1f)
        {
            C.a = .01f;
            Object.GetComponent<Renderer>().material.DisableKeyword("_ALPHABLEND_ON");
            Object.GetComponent<Renderer>().material.DisableKeyword("_ALPHATEST_ON");
            Object.GetComponent<Renderer>().material.EnableKeyword("_ALPHAPREMULTIPLY_ON");
            Object.GetComponent<Renderer>().material.color = C;
        }
        else
        {
            C.a = 1;
            Object.GetComponent<Renderer>().material.DisableKeyword("_ALPHABLEND_ON");
            Object.GetComponent<Renderer>().material.DisableKeyword("_ALPHATEST_ON");
            Object.GetComponent<Renderer>().material.DisableKeyword("_ALPHAPREMULTIPLY_ON");
            Object.GetComponent<Renderer>().material.color = C;
        }
    }
}
