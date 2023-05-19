using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelHexManager : MonoBehaviour
{
    [SerializeField] private GameObject HexPref;
    [SerializeField] private GameObject HumanModel;
    public int movementRange = 1;
    private int turn = 0;
    private int num;
    private float HexY = .7f;
    private float HumanXPos;
    private float HumanZPos;
    // Start is called before the first frame update
    void Start()
    {
        HexY = HumanModel.transform.position.y + .7f;
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.position = new Vector3(HumanModel.transform.position.x, HumanModel.transform.position.y, HumanModel.transform.position.z);
        HumanXPos = HumanModel.transform.position.x;
        HumanZPos = HumanModel.transform.position.z - 1.3f;
        if (movementRange == 13)
        {
            Ring12();
        }
        if (movementRange == 12)
        {
            Ring11();
        }
        if (movementRange == 11)
        {
            Ring10();
        }
        if (movementRange == 10)
        {
            Ring9();
        }
        if (movementRange == 9)
        {
            Ring8();
        }
        if (movementRange == 8)
        {
            Ring7();
        }
        if (movementRange == 7)
        {
            Ring6();
        }
        if (movementRange == 6)
        {
            Ring5();
        }
        if (movementRange == 5)
        {
            Ring4();
        }
        if (movementRange == 4)
        {
            Ring3();
        }
        if (movementRange == 3)
        {
            Ring2();
        }
        if (movementRange == 2)
        {
            Ring1();
        }
        //this will update the movent range and is boud by the mouse manager target and will be moved to the mouse manager eventually
        if (Input.GetMouseButtonDown(0) && !GetComponent<ModelMouseManager>().CheckLocation(GetComponent<ModelMouseManager>().target))
        {
            bool i = int.TryParse(gameObject.GetComponent<ModelMouseManager>().target, out num);
            if (i)
            { 
                movementRange = rangeModifyer(movementRange, num, (movementRange - 1));
            }
        }
        transform.localPosition = new Vector3(0, 0, 4f);
    }
    public void Ring1()
    {
        //GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + 0, HexY, HumanZPos - 5.5f), Quaternion.identity);
        //hexVal.transform.SetParent(transform);
        //GameObject hexVal1 = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + 0, HexY, HumanZPos + 5.5f), Quaternion.identity);
        //hexVal1.transform.SetParent(transform);
        //GameObject hexVal2 = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + 6.05f, HexY, HumanZPos - 2.86f), Quaternion.identity);
        //hexVal2.transform.SetParent(transform);
        //GameObject hexVal3 = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + 6.05f, HexY, HumanZPos + 2.86f), Quaternion.identity);
        //hexVal3.transform.SetParent(transform);
        //GameObject hexVal4 = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos - 6.05f, HexY, HumanZPos + 2.86f), Quaternion.identity);
        //hexVal4.transform.SetParent(transform);
        //GameObject hexVal5 = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos - 6.05f, HexY, HumanZPos - 2.86f), Quaternion.identity);
        //hexVal5.transform.SetParent(transform);
        for (int j = -1; j < 2; j++)
        {
            if (j != 0)
            {
                for (int i = 1; i < 5; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 1 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 1)), Quaternion.identity);
                    hexVal.name = (1 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
            }
            if (j == 0)
            {
                for (int i = 0; i < 6; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 0 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 1)), Quaternion.identity);
                    hexVal.name = (2 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
            }
        }
    }
    public void Ring2()
    {
        for (int j = -1; j < 2; j++)
        {
            if (j != 0)
            {
                for (int i = 2; i < 8; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 2 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 2)), Quaternion.identity);
                    hexVal.name = (2 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 1; i < 9; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 1 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 2)), Quaternion.identity);
                    hexVal.name = (1 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
            }
            if (j == 0)
            {
                for (int i = 0; i < 10; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 0 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 2)), Quaternion.identity);
                    hexVal.name = (3 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
            }
        }
    }
    public void Ring3()
    {
        for (int j = -1; j < 2; j++)
        {
            if (j != 0)
            {
                for (int i = 3; i < 11; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 3 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 3)), Quaternion.identity);
                    hexVal.name = (3 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 2; i < 12; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 2 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 3)), Quaternion.identity);
                    hexVal.name = (2 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 1; i < 13; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 1 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 3)), Quaternion.identity);
                    hexVal.name = (1 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
            }
            if (j == 0)
            {
                for (int i = 0; i < 14; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 0 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 3)), Quaternion.identity);
                    hexVal.name = (4 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
            }
        }
    }
    public void Ring4()
    {
        for (int j = -1; j < 2; j++)
        {
            if (j != 0)
            {
                for (int i = 4; i < 14; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 4 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 4)), Quaternion.identity);
                    hexVal.name = (4 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 3; i < 15; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 3 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 4)), Quaternion.identity);
                    hexVal.name = (3 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 2; i < 16; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 2 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 4)), Quaternion.identity);
                    hexVal.name = (2 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 1; i < 17; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 1 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 4)), Quaternion.identity);
                    hexVal.name = (1 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
            }
            if (j == 0)
            {
                for (int i = 0; i < 18; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 0 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 4)), Quaternion.identity);
                    hexVal.name = (5 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
            }
        }
    }
    public void Ring5()
    {
        for (int j = -1; j < 2; j++)
        {
            if (j != 0)
            {
                for (int i = 5; i < 17; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 5 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 5)), Quaternion.identity);
                    hexVal.name = (5 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 4; i < 18; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 4 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 5)), Quaternion.identity);
                    hexVal.name = (4 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 3; i < 19; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 3 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 5)), Quaternion.identity);
                    hexVal.name = (3 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 2; i < 20; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 2 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 5)), Quaternion.identity);
                    hexVal.name = (2 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 1; i < 21; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 1 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 5)), Quaternion.identity);
                    hexVal.name = (1 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
            }
            if (j == 0)
            {
                for (int i = 0; i < 22; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 0 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 5)), Quaternion.identity);
                    hexVal.name = (6 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
            }
        }
    }
    public void Ring6()
    {
        for (int j = -1; j < 2; j++)
        {
            if (j != 0)
            {
                for (int i = 6; i < 20; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 6 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 6)), Quaternion.identity);
                    hexVal.name = (6 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 5; i < 21; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 5 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 6)), Quaternion.identity);
                    hexVal.name = (5 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 4; i < 22; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 4 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 6)), Quaternion.identity);
                    hexVal.name = (4 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 3; i < 23; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 3 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 6)), Quaternion.identity);
                    hexVal.name = (3 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 2; i < 24; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 2 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 6)), Quaternion.identity);
                    hexVal.name = (2 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 1; i < 25; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 1 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 6)), Quaternion.identity);
                    hexVal.name = (1 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
            }
            if (j == 0)
            {
                for (int i = 0; i < 26; i += 2)
                {
                    if (i != 22 && i != 24)
                    {
                        GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 0 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 6)), Quaternion.identity);
                        hexVal.name = (7 * j) + "" + i;
                        hexVal.transform.SetParent(transform);
                    }
                    else
                    {
                        //only change the name not the location generated
                        int temp = i * 1000;
                        GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 0 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 6)), Quaternion.identity);
                        hexVal.name = (7 * j) + "" + temp;
                        hexVal.transform.SetParent(transform);
                    }
                }
            }
        }
    }
    public void Ring7()
    {
        for (int j = -1; j < 2; j++)
        {
            if (j != 0)
            {
                for (int i = 7; i < 23; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 7 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 7)), Quaternion.identity);
                    hexVal.name = (7 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 6; i < 24; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 6 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 7)), Quaternion.identity);
                    hexVal.name = (6 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 5; i < 25; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 5 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 7)), Quaternion.identity);
                    hexVal.name = (5 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 4; i < 26; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 4 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 7)), Quaternion.identity);
                    hexVal.name = (4 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 3; i < 27; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 3 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 7)), Quaternion.identity);
                    hexVal.name = (3 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 2; i < 28; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 2 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 7)), Quaternion.identity);
                    hexVal.name = (2 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 1; i < 29; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 1 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 7)), Quaternion.identity);
                    hexVal.name = (1 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
            }
            if (j == 0)
            {
                for (int i = 0; i < 30; i += 2)
                {
                    if (i != 22 && i != 24 && i != 26 && i != 28)
                    {
                        GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 0 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 7)), Quaternion.identity);
                        hexVal.name = (8 * j) + "" + i;
                        hexVal.transform.SetParent(transform);
                    }
                    else
                    {
                        //only change the name not the location generated
                        int temp = i * 1000;
                        GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 0 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 7)), Quaternion.identity);
                        hexVal.name = (8 * j) + "" + temp;
                        hexVal.transform.SetParent(transform);
                    }
                }
            }
        }
    }
    public void Ring8()
    {
        for (int j = -1; j < 2; j++)
        {
            if (j != 0)
            {
                for (int i = 8; i < 26; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 8 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 8)), Quaternion.identity);
                    hexVal.name = (8 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 7; i < 27; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 7 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 8)), Quaternion.identity);
                    hexVal.name = (7 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 6; i < 28; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 6 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 8)), Quaternion.identity);
                    hexVal.name = (6 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 5; i < 29; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 5 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 8)), Quaternion.identity);
                    hexVal.name = (5 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 4; i < 30; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 4 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 8)), Quaternion.identity);
                    hexVal.name = (4 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 3; i < 31; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 3 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 8)), Quaternion.identity);
                    hexVal.name = (3 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 2; i < 32; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 2 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 8)), Quaternion.identity);
                    hexVal.name = (2 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 1; i < 33; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 1 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 8)), Quaternion.identity);
                    hexVal.name = (1 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
            }
            if (j == 0)
            {
                for (int i = 0; i < 34; i += 2)
                {
                    if (i != 22 && i != 24 && i != 26 && i != 28)
                    {
                        GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 0 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 8)), Quaternion.identity);
                        hexVal.name = (9 * j) + "" + i;
                        hexVal.transform.SetParent(transform);
                    }
                    else
                    {
                        //only change the name not the location generated
                        int temp = i * 1000;
                        GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 0 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 8)), Quaternion.identity);
                        hexVal.name = (9 * j) + "" + temp;
                        hexVal.transform.SetParent(transform);
                    }
                }
            }
        }
    }
    public void Ring9()
    {
        for (int j = -1; j < 2; j++)
        {
            if (j != 0)
            {
                for (int i = 9; i < 29; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 9 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 9)), Quaternion.identity);
                    hexVal.name = (9 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 8; i < 30; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 8 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 9)), Quaternion.identity);
                    hexVal.name = (8 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 7; i < 31; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 7 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 9)), Quaternion.identity);
                    hexVal.name = (7 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 6; i < 32; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 6 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 9)), Quaternion.identity);
                    hexVal.name = (6 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 5; i < 33; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 5 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 9)), Quaternion.identity);
                    hexVal.name = (5 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 4; i < 34; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 4 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 9)), Quaternion.identity);
                    hexVal.name = (4 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 3; i < 35; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 3 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 9)), Quaternion.identity);
                    hexVal.name = (3 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 2; i < 36; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 2 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 9)), Quaternion.identity);
                    hexVal.name = (2 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 1; i < 37; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 1 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 9)), Quaternion.identity);
                    hexVal.name = (1 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }

            }
            if (j == 0)
            {
                for (int i = 0; i < 38; i += 2)
                {
                    if (i != 22 && i != 24 && i != 26 && i != 28)
                    {
                        GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 0 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 9)), Quaternion.identity);
                        hexVal.name = (10 * j) + "" + i;
                        hexVal.transform.SetParent(transform);
                    }
                    else
                    {
                        //only change the name not the location generated
                        int temp = i * 1000;
                        GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 0 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 9)), Quaternion.identity);
                        hexVal.name = (10 * j) + "" + temp;
                        hexVal.transform.SetParent(transform);
                    }
                }
            }
        }
    }
    public void Ring10()
    {
        for (int j = -1; j < 2; j++)
        {
            if (j != 0)
            {
                for (int i = 10; i < 32; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 10 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 10)), Quaternion.identity);
                    hexVal.name = (10 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 9; i < 33; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 9 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 10)), Quaternion.identity);
                    hexVal.name = (9 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 8; i < 34; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 8 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 10)), Quaternion.identity);
                    hexVal.name = (8 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 7; i < 35; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 7 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 10)), Quaternion.identity);
                    hexVal.name = (7 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 6; i < 36; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 6 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 10)), Quaternion.identity);
                    hexVal.name = (6 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 5; i < 37; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 5 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 10)), Quaternion.identity);
                    hexVal.name = (5 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 4; i < 38; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 4 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 10)), Quaternion.identity);
                    hexVal.name = (4 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 3; i < 39; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 3 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 10)), Quaternion.identity);
                    hexVal.name = (3 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 2; i < 40; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 2 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 10)), Quaternion.identity);
                    hexVal.name = (2 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 1; i < 41; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 1 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 10)), Quaternion.identity);
                    hexVal.name = (1 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
            }
            if (j == 0)
            {
                for (int i = 0; i < 42; i += 2)
                {
                    if (i != 22 && i != 24 && i != 26 && i != 28)
                    {
                        GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 0 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 10)), Quaternion.identity);
                        hexVal.name = (11 * j) + "" + i;
                        hexVal.transform.SetParent(transform);
                    }
                    else
                    {
                        //only change the name not the location generated
                        int temp = i * 1000;
                        GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 0 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 10)), Quaternion.identity);
                        hexVal.name = (11 * j) + "" + temp;
                        hexVal.transform.SetParent(transform);
                    }
                }
            }
        }
    }
    public void Ring11()
    {
        for (int j = -1; j < 2; j++)
        {
            if (j != 0)
            {
                for (int i = 11; i < 35; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 11 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 11)), Quaternion.identity);
                    hexVal.name = (11 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 10; i < 36; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 10 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 11)), Quaternion.identity);
                    hexVal.name = (10 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 9; i < 37; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 9 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 11)), Quaternion.identity);
                    hexVal.name = (9 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 8; i < 38; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 8 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 11)), Quaternion.identity);
                    hexVal.name = (8 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 7; i < 39; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 7 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 11)), Quaternion.identity);
                    hexVal.name = (7 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 6; i < 40; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 6 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 11)), Quaternion.identity);
                    hexVal.name = (6 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 5; i < 41; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 5 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 11)), Quaternion.identity);
                    hexVal.name = (5 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 4; i < 42; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 4 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 11)), Quaternion.identity);
                    hexVal.name = (4 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 3; i < 43; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 3 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 11)), Quaternion.identity);
                    hexVal.name = (3 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 2; i < 44; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 2 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 11)), Quaternion.identity);
                    hexVal.name = (2 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 1; i < 45; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 1 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 11)), Quaternion.identity);
                    hexVal.name = (1 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
            }
            if (j == 0)
            {
                for (int i = 0; i < 46; i += 2)
                {
                    if (i != 22 && i != 24 && i != 26 && i != 28 && i != 44)
                    {
                        GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 0 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 11)), Quaternion.identity);
                        hexVal.name = (12 * j) + "" + i;
                        hexVal.transform.SetParent(transform);
                    }
                    else
                    {
                        //only change the name not the location generated
                        int temp = i * 1000;
                        GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 0 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 11)), Quaternion.identity);
                        hexVal.name = (12 * j) + "" + temp;
                        hexVal.transform.SetParent(transform);
                    }
                }
            }
        }
    }
    public void Ring12()
    {
        for (int j = -1; j < 2; j++)
        {
            if (j != 0)
            {
                for (int i = 12; i < 38; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 12 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 12)), Quaternion.identity);
                    hexVal.name = (12 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 11; i < 39; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 11 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 12)), Quaternion.identity);
                    hexVal.name = (11 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 10; i < 40; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 10 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 12)), Quaternion.identity);
                    hexVal.name = (10 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 9; i < 41; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 9 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 12)), Quaternion.identity);
                    hexVal.name = (9 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 8; i < 42; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 8 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 12)), Quaternion.identity);
                    hexVal.name = (8 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 7; i < 43; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 7 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 12)), Quaternion.identity);
                    hexVal.name = (7 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 6; i < 44; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 6 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 12)), Quaternion.identity);
                    hexVal.name = (6 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 5; i < 45; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 5 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 12)), Quaternion.identity);
                    hexVal.name = (5 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 4; i < 46; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 4 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 12)), Quaternion.identity);
                    hexVal.name = (4 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 3; i < 47; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 3 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 12)), Quaternion.identity);
                    hexVal.name = (3 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 2; i < 48; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 2 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 12)), Quaternion.identity);
                    hexVal.name = (2 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
                for (int i = 1; i < 49; i += 2)
                {
                    GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 1 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 12)), Quaternion.identity);
                    hexVal.name = (1 * j) + "" + i;
                    hexVal.transform.SetParent(transform);
                }
            }
            if (j == 0)
            {
                for (int i = 0; i < 50; i += 2)
                {
                    if (i != 22 && i != 24 && i != 26 && i != 28 && i != 44 && i != 46 && i != 48)
                    {
                        GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 0 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 12)), Quaternion.identity);
                        hexVal.name = (13 * j) + "" + i;
                        hexVal.transform.SetParent(transform);
                    }
                    else
                    {
                        //only change the name not the location generated
                        int temp = i * 1000;
                        GameObject hexVal = (GameObject)Instantiate(HexPref, new Vector3(HumanXPos + (6.15f * 0 * j), HexY, HumanZPos + (2.86f * i) - (5.5f * 12)), Quaternion.identity);
                        hexVal.name = (13 * j) + "" + temp;
                        hexVal.transform.SetParent(transform);
                    }
                }
            }
        }
    }
    public int rangeModifyer(int currentMovement, int locationVal, int activeRing)
    {
        int temp = Mathf.Abs(locationVal);
        //((Brawn + Skill) / 5)  (30+30)/5 = 12
        // need to return or send out the amout of action poinst that the move would cost if the action was made
        if (activeRing == 12)
        {
            if (temp == 1212)
                currentMovement -= 12;
            if (temp == 1214)
                currentMovement -= 12;
            if (temp == 1216)
                currentMovement -= 12;
            if (temp == 1218)
                currentMovement -= 12;
            if (temp == 1220)
                currentMovement -= 12;
            if (temp == 1222)
                currentMovement -= 12;
            if (temp == 1224)
                currentMovement -= 12;
            if (temp == 1226)
                currentMovement -= 12;
            if (temp == 1228)
                currentMovement -= 12;
            if (temp == 1230)
                currentMovement -= 12;
            if (temp == 1232)
                currentMovement -= 12;
            if (temp == 1234)
                currentMovement -= 12;
            if (temp == 1236)
                currentMovement -= 12;

            if (temp == 1111)
                currentMovement -= 12;
            if (temp == 1113)
                currentMovement -= 11;
            if (temp == 1115)
                currentMovement -= 11;
            if (temp == 1117)
                currentMovement -= 11;
            if (temp == 1119)
                currentMovement -= 11;
            if (temp == 1121)
                currentMovement -= 11;
            if (temp == 1123)
                currentMovement -= 11;
            if (temp == 1125)
                currentMovement -= 11;
            if (temp == 1127)
                currentMovement -= 11;
            if (temp == 1129)
                currentMovement -= 11;
            if (temp == 1131)
                currentMovement -= 11;
            if (temp == 1133)
                currentMovement -= 11;
            if (temp == 1135)
                currentMovement -= 11;
            if (temp == 1137)
                currentMovement -= 12;

            if (temp == 1010)
                currentMovement -= 12;
            if (temp == 1012)
                currentMovement -= 11;
            if (temp == 1014)
                currentMovement -= 10;
            if (temp == 1016)
                currentMovement -= 10;
            if (temp == 1018)
                currentMovement -= 10;
            if (temp == 1020)
                currentMovement -= 10;
            if (temp == 1022)
                currentMovement -= 10;
            if (temp == 1024)
                currentMovement -= 10;
            if (temp == 1026)
                currentMovement -= 10;
            if (temp == 1028)
                currentMovement -= 10;
            if (temp == 1030)
                currentMovement -= 10;
            if (temp == 1032)
                currentMovement -= 10;
            if (temp == 1034)
                currentMovement -= 10;
            if (temp == 1036)
                currentMovement -= 11;
            if (temp == 1038)
                currentMovement -= 12;

            if (temp == 99)
                currentMovement -= 12;
            if (temp == 911)
                currentMovement -= 11;
            if (temp == 913)
                currentMovement -= 10;
            if (temp == 915)
                currentMovement -= 9;
            if (temp == 917)
                currentMovement -= 9;
            if (temp == 919)
                currentMovement -= 9;
            if (temp == 921)
                currentMovement -= 9;
            if (temp == 923)
                currentMovement -= 9;
            if (temp == 925)
                currentMovement -= 9;
            if (temp == 927)
                currentMovement -= 9;
            if (temp == 929)
                currentMovement -= 9;
            if (temp == 931)
                currentMovement -= 9;
            if (temp == 933)
                currentMovement -= 9;
            if (temp == 935)
                currentMovement -= 10;
            if (temp == 937)
                currentMovement -= 11;
            if (temp == 939)
                currentMovement -= 12;

            if (temp == 88)
                currentMovement -= 12;
            if (temp == 810)
                currentMovement -= 11;
            if (temp == 812)
                currentMovement -= 10;
            if (temp == 814)
                currentMovement -= 9;
            if (temp == 816)
                currentMovement -= 8;
            if (temp == 818)
                currentMovement -= 8;
            if (temp == 820)
                currentMovement -= 8;
            if (temp == 822)
                currentMovement -= 8;
            if (temp == 824)
                currentMovement -= 8;
            if (temp == 826)
                currentMovement -= 8;
            if (temp == 828)
                currentMovement -= 8;
            if (temp == 830)
                currentMovement -= 8;
            if (temp == 832)
                currentMovement -= 8;
            if (temp == 834)
                currentMovement -= 9;
            if (temp == 836)
                currentMovement -= 10;
            if (temp == 838)
                currentMovement -= 11;
            if (temp == 840)
                currentMovement -= 12;

            if (temp == 77)
                currentMovement -= 12;
            if (temp == 79)
                currentMovement -= 11;
            if (temp == 711)
                currentMovement -= 10;
            if (temp == 713)
                currentMovement -= 9;
            if (temp == 715)
                currentMovement -= 8;
            if (temp == 717)
                currentMovement -= 7;
            if (temp == 719)
                currentMovement -= 7;
            if (temp == 721)
                currentMovement -= 7;
            if (temp == 723)
                currentMovement -= 7;
            if (temp == 725)
                currentMovement -= 7;
            if (temp == 727)
                currentMovement -= 7;
            if (temp == 729)
                currentMovement -= 7;
            if (temp == 731)
                currentMovement -= 7;
            if (temp == 733)
                currentMovement -= 8;
            if (temp == 735)
                currentMovement -= 9;
            if (temp == 737)
                currentMovement -= 10;
            if (temp == 739)
                currentMovement -= 11;
            if (temp == 741)
                currentMovement -= 12;

            if (temp == 66)
                currentMovement -= 12;
            if (temp == 68)
                currentMovement -= 11;
            if (temp == 610)
                currentMovement -= 10;
            if (temp == 612)
                currentMovement -= 9;
            if (temp == 614)
                currentMovement -= 8;
            if (temp == 616)
                currentMovement -= 7;
            if (temp == 618)
                currentMovement -= 6;
            if (temp == 620)
                currentMovement -= 6;
            if (temp == 622)
                currentMovement -= 6;
            if (temp == 624)
                currentMovement -= 6;
            if (temp == 626)
                currentMovement -= 6;
            if (temp == 628)
                currentMovement -= 6;
            if (temp == 630)
                currentMovement -= 6;
            if (temp == 632)
                currentMovement -= 7;
            if (temp == 634)
                currentMovement -= 8;
            if (temp == 636)
                currentMovement -= 9;
            if (temp == 638)
                currentMovement -= 10;
            if (temp == 640)
                currentMovement -= 11;
            if (temp == 642)
                currentMovement -= 12;

            if (temp == 55)
                currentMovement -= 12;
            if (temp == 57)
                currentMovement -= 11;
            if (temp == 59)
                currentMovement -= 10;
            if (temp == 511)
                currentMovement -= 9;
            if (temp == 513)
                currentMovement -= 8;
            if (temp == 515)
                currentMovement -= 7;
            if (temp == 517)
                currentMovement -= 6;
            if (temp == 519)
                currentMovement -= 5;
            if (temp == 521)
                currentMovement -= 5;
            if (temp == 523)
                currentMovement -= 5;
            if (temp == 525)
                currentMovement -= 5;
            if (temp == 527)
                currentMovement -= 5;
            if (temp == 529)
                currentMovement -= 5;
            if (temp == 531)
                currentMovement -= 6;
            if (temp == 533)
                currentMovement -= 7;
            if (temp == 535)
                currentMovement -= 8;
            if (temp == 537)
                currentMovement -= 9;
            if (temp == 539)
                currentMovement -= 10;
            if (temp == 541)
                currentMovement -= 11;
            if (temp == 543)
                currentMovement -= 12;

            if (temp == 44)
                currentMovement -= 12;
            if (temp == 46)
                currentMovement -= 11;
            if (temp == 48)
                currentMovement -= 10;
            if (temp == 410)
                currentMovement -= 9;
            if (temp == 412)
                currentMovement -= 8;
            if (temp == 414)
                currentMovement -= 7;
            if (temp == 416)
                currentMovement -= 6;
            if (temp == 418)
                currentMovement -= 5;
            if (temp == 420)
                currentMovement -= 4;
            if (temp == 422)
                currentMovement -= 4;
            if (temp == 424)
                currentMovement -= 4;
            if (temp == 426)
                currentMovement -= 4;
            if (temp == 428)
                currentMovement -= 4;
            if (temp == 430)
                currentMovement -= 5;
            if (temp == 432)
                currentMovement -= 6;
            if (temp == 434)
                currentMovement -= 7;
            if (temp == 436)
                currentMovement -= 8;
            if (temp == 438)
                currentMovement -= 9;
            if (temp == 440)
                currentMovement -= 10;
            if (temp == 442)
                currentMovement -= 11;
            if (temp == 444)
                currentMovement -= 12;

            if (temp == 33)
                currentMovement -= 12;
            if (temp == 35)
                currentMovement -= 11;
            if (temp == 37)
                currentMovement -= 10;
            if (temp == 39)
                currentMovement -= 9;
            if (temp == 311)
                currentMovement -= 8;
            if (temp == 313)
                currentMovement -= 7;
            if (temp == 315)
                currentMovement -= 6;
            if (temp == 317)
                currentMovement -= 5;
            if (temp == 319)
                currentMovement -= 4;
            if (temp == 321)
                currentMovement -= 3;
            if (temp == 323)
                currentMovement -= 3;
            if (temp == 325)
                currentMovement -= 3;
            if (temp == 327)
                currentMovement -= 3;
            if (temp == 329)
                currentMovement -= 4;
            if (temp == 331)
                currentMovement -= 5;
            if (temp == 333)
                currentMovement -= 6;
            if (temp == 335)
                currentMovement -= 7;
            if (temp == 337)
                currentMovement -= 8;
            if (temp == 339)
                currentMovement -= 9;
            if (temp == 341)
                currentMovement -= 10;
            if (temp == 343)
                currentMovement -= 11;
            if (temp == 345)
                currentMovement -= 12;

            if (temp == 22)
                currentMovement -= 12;
            if (temp == 24)
                currentMovement -= 11;
            if (temp == 26)
                currentMovement -= 10;
            if (temp == 28)
                currentMovement -= 9;
            if (temp == 210)
                currentMovement -= 8;
            if (temp == 212)
                currentMovement -= 7;
            if (temp == 214)
                currentMovement -= 6;
            if (temp == 216)
                currentMovement -= 5;
            if (temp == 218)
                currentMovement -= 4;
            if (temp == 220)
                currentMovement -= 3;
            if (temp == 222)
                currentMovement -= 2;
            if (temp == 224)
                currentMovement -= 2;
            if (temp == 226)
                currentMovement -= 2;
            if (temp == 228)
                currentMovement -= 3;
            if (temp == 230)
                currentMovement -= 4;
            if (temp == 232)
                currentMovement -= 5;
            if (temp == 234)
                currentMovement -= 6;
            if (temp == 236)
                currentMovement -= 7;
            if (temp == 238)
                currentMovement -= 8;
            if (temp == 240)
                currentMovement -= 9;
            if (temp == 242)
                currentMovement -= 10;
            if (temp == 244)
                currentMovement -= 11;
            if (temp == 246)
                currentMovement -= 12;

            if (temp == 11)
                currentMovement -= 12;
            if (temp == 13)
                currentMovement -= 11;
            if (temp == 15)
                currentMovement -= 10;
            if (temp == 17)
                currentMovement -= 9;
            if (temp == 19)
                currentMovement -= 8;
            if (temp == 111)
                currentMovement -= 7;
            if (temp == 113)
                currentMovement -= 6;
            if (temp == 115)
                currentMovement -= 5;
            if (temp == 117)
                currentMovement -= 4;
            if (temp == 119)
                currentMovement -= 3;
            if (temp == 121)
                currentMovement -= 2;
            if (temp == 123)
                currentMovement -= 1;
            if (temp == 125)
                currentMovement -= 1;
            if (temp == 127)
                currentMovement -= 2;
            if (temp == 129)
                currentMovement -= 3;
            if (temp == 131)
                currentMovement -= 4;
            if (temp == 133)
                currentMovement -= 5;
            if (temp == 135)
                currentMovement -= 6;
            if (temp == 137)
                currentMovement -= 7;
            if (temp == 139)
                currentMovement -= 8;
            if (temp == 141)
                currentMovement -= 9;
            if (temp == 143)
                currentMovement -= 10;
            if (temp == 145)
                currentMovement -= 11;
            if (temp == 147)
                currentMovement -= 12;

            if (temp == 0)
                currentMovement -= 12;
            if (temp == 2)
                currentMovement -= 11;
            if (temp == 4)
                currentMovement -= 10;
            if (temp == 6)
                currentMovement -= 9;
            if (temp == 8)
                currentMovement -= 8;
            if (temp == 10)
                currentMovement -= 7;
            if (temp == 12)
                currentMovement -= 6;
            if (temp == 14)
                currentMovement -= 5;
            if (temp == 16)
                currentMovement -= 4;
            if (temp == 18)
                currentMovement -= 3;
            if (temp == 20)
                currentMovement -= 2;
            if (temp == 22000)
                currentMovement -= 1;
            if (temp == 24000)
                currentMovement -= 0;
            if (temp == 26000)
                currentMovement -= 1;
            if (temp == 28000)
                currentMovement -= 2;
            if (temp == 30)
                currentMovement -= 3;
            if (temp == 32)
                currentMovement -= 4;
            if (temp == 34)
                currentMovement -= 5;
            if (temp == 36)
                currentMovement -= 6;
            if (temp == 38)
                currentMovement -= 7;
            if (temp == 40)
                currentMovement -= 8;
            if (temp == 42)
                currentMovement -= 9;
            if (temp == 44000)
                currentMovement -= 10;
            if (temp == 46000)
                currentMovement -= 11;
            if (temp == 48000)
                currentMovement -= 12;
        }
        else if (activeRing == 11)
        {
            if (temp == 1111)
                currentMovement -= 11;
            if (temp == 1113)
                currentMovement -= 11;
            if (temp == 1115)
                currentMovement -= 11;
            if (temp == 1117)
                currentMovement -= 11;
            if (temp == 1119)
                currentMovement -= 11;
            if (temp == 1121)
                currentMovement -= 11;
            if (temp == 1123)
                currentMovement -= 11;
            if (temp == 1125)
                currentMovement -= 11;
            if (temp == 1127)
                currentMovement -= 11;
            if (temp == 1129)
                currentMovement -= 11;
            if (temp == 1131)
                currentMovement -= 11;
            if (temp == 1133)
                currentMovement -= 11;

            if (temp == 1010)
                currentMovement -= 11;
            if (temp == 1012)
                currentMovement -= 10;
            if (temp == 1014)
                currentMovement -= 10;
            if (temp == 1016)
                currentMovement -= 10;
            if (temp == 1018)
                currentMovement -= 10;
            if (temp == 1020)
                currentMovement -= 10;
            if (temp == 1022)
                currentMovement -= 10;
            if (temp == 1024)
                currentMovement -= 10;
            if (temp == 1026)
                currentMovement -= 10;
            if (temp == 1028)
                currentMovement -= 10;
            if (temp == 1030)
                currentMovement -= 10;
            if (temp == 1032)
                currentMovement -= 10;
            if (temp == 1034)
                currentMovement -= 11;

            if (temp == 99)
                currentMovement -= 11;
            if (temp == 911)
                currentMovement -= 10;
            if (temp == 913)
                currentMovement -= 9;
            if (temp == 915)
                currentMovement -= 9;
            if (temp == 917)
                currentMovement -= 9;
            if (temp == 919)
                currentMovement -= 9;
            if (temp == 921)
                currentMovement -= 9;
            if (temp == 923)
                currentMovement -= 9;
            if (temp == 925)
                currentMovement -= 9;
            if (temp == 927)
                currentMovement -= 9;
            if (temp == 929)
                currentMovement -= 9;
            if (temp == 931)
                currentMovement -= 9;
            if (temp == 933)
                currentMovement -= 10;
            if (temp == 935)
                currentMovement -= 11;

            if (temp == 88)
                currentMovement -= 11;
            if (temp == 810)
                currentMovement -= 10;
            if (temp == 812)
                currentMovement -= 9;
            if (temp == 814)
                currentMovement -= 8;
            if (temp == 816)
                currentMovement -= 8;
            if (temp == 818)
                currentMovement -= 8;
            if (temp == 820)
                currentMovement -= 8;
            if (temp == 822)
                currentMovement -= 8;
            if (temp == 824)
                currentMovement -= 8;
            if (temp == 826)
                currentMovement -= 8;
            if (temp == 828)
                currentMovement -= 8;
            if (temp == 830)
                currentMovement -= 8;
            if (temp == 832)
                currentMovement -= 9;
            if (temp == 834)
                currentMovement -= 10;
            if (temp == 836)
                currentMovement -= 11;

            if (temp == 77)
                currentMovement -= 11;
            if (temp == 79)
                currentMovement -= 10;
            if (temp == 711)
                currentMovement -= 9;
            if (temp == 713)
                currentMovement -= 8;
            if (temp == 715)
                currentMovement -= 7;
            if (temp == 717)
                currentMovement -= 7;
            if (temp == 719)
                currentMovement -= 7;
            if (temp == 721)
                currentMovement -= 7;
            if (temp == 723)
                currentMovement -= 7;
            if (temp == 725)
                currentMovement -= 7;
            if (temp == 727)
                currentMovement -= 7;
            if (temp == 729)
                currentMovement -= 7;
            if (temp == 731)
                currentMovement -= 8;
            if (temp == 733)
                currentMovement -= 9;
            if (temp == 735)
                currentMovement -= 10;
            if (temp == 737)
                currentMovement -= 11;

            if (temp == 66)
                currentMovement -= 11;
            if (temp == 68)
                currentMovement -= 10;
            if (temp == 610)
                currentMovement -= 9;
            if (temp == 612)
                currentMovement -= 8;
            if (temp == 614)
                currentMovement -= 7;
            if (temp == 616)
                currentMovement -= 6;
            if (temp == 618)
                currentMovement -= 6;
            if (temp == 620)
                currentMovement -= 6;
            if (temp == 622)
                currentMovement -= 6;
            if (temp == 624)
                currentMovement -= 6;
            if (temp == 626)
                currentMovement -= 6;
            if (temp == 628)
                currentMovement -= 6;
            if (temp == 630)
                currentMovement -= 7;
            if (temp == 632)
                currentMovement -= 8;
            if (temp == 634)
                currentMovement -= 9;
            if (temp == 636)
                currentMovement -= 10;
            if (temp == 638)
                currentMovement -= 11;

            if (temp == 55)
                currentMovement -= 11;
            if (temp == 57)
                currentMovement -= 10;
            if (temp == 59)
                currentMovement -= 9;
            if (temp == 511)
                currentMovement -= 8;
            if (temp == 513)
                currentMovement -= 7;
            if (temp == 515)
                currentMovement -= 6;
            if (temp == 517)
                currentMovement -= 5;
            if (temp == 519)
                currentMovement -= 5;
            if (temp == 521)
                currentMovement -= 5;
            if (temp == 523)
                currentMovement -= 5;
            if (temp == 525)
                currentMovement -= 5;
            if (temp == 527)
                currentMovement -= 5;
            if (temp == 529)
                currentMovement -= 5;
            if (temp == 531)
                currentMovement -= 6;
            if (temp == 533)
                currentMovement -= 8;
            if (temp == 535)
                currentMovement -= 9;
            if (temp == 537)
                currentMovement -= 10;
            if (temp == 539)
                currentMovement -= 11;

            if (temp == 44)
                currentMovement -= 11;
            if (temp == 46)
                currentMovement -= 10;
            if (temp == 48)
                currentMovement -= 9;
            if (temp == 410)
                currentMovement -= 8;
            if (temp == 412)
                currentMovement -= 7;
            if (temp == 414)
                currentMovement -= 6;
            if (temp == 416)
                currentMovement -= 5;
            if (temp == 418)
                currentMovement -= 4;
            if (temp == 420)
                currentMovement -= 4;
            if (temp == 422)
                currentMovement -= 4;
            if (temp == 424)
                currentMovement -= 4;
            if (temp == 426)
                currentMovement -= 4;
            if (temp == 428)
                currentMovement -= 5;
            if (temp == 430)
                currentMovement -= 6;
            if (temp == 432)
                currentMovement -= 7;
            if (temp == 434)
                currentMovement -= 8;
            if (temp == 436)
                currentMovement -= 9;
            if (temp == 438)
                currentMovement -= 10;
            if (temp == 440)
                currentMovement -= 11;

            if (temp == 33)
                currentMovement -= 11;
            if (temp == 35)
                currentMovement -= 10;
            if (temp == 37)
                currentMovement -= 9;
            if (temp == 39)
                currentMovement -= 8;
            if (temp == 311)
                currentMovement -= 7;
            if (temp == 313)
                currentMovement -= 6;
            if (temp == 315)
                currentMovement -= 5;
            if (temp == 317)
                currentMovement -= 4;
            if (temp == 319)
                currentMovement -= 3;
            if (temp == 321)
                currentMovement -= 3;
            if (temp == 323)
                currentMovement -= 3;
            if (temp == 325)
                currentMovement -= 3;
            if (temp == 327)
                currentMovement -= 4;
            if (temp == 329)
                currentMovement -= 5;
            if (temp == 331)
                currentMovement -= 6;
            if (temp == 333)
                currentMovement -= 7;
            if (temp == 335)
                currentMovement -= 8;
            if (temp == 337)
                currentMovement -= 9;
            if (temp == 339)
                currentMovement -= 10;
            if (temp == 341)
                currentMovement -= 11;

            if (temp == 22)
                currentMovement -= 11;
            if (temp == 24)
                currentMovement -= 10;
            if (temp == 26)
                currentMovement -= 9;
            if (temp == 28)
                currentMovement -= 8;
            if (temp == 210)
                currentMovement -= 7;
            if (temp == 212)
                currentMovement -= 6;
            if (temp == 214)
                currentMovement -= 5;
            if (temp == 216)
                currentMovement -= 4;
            if (temp == 218)
                currentMovement -= 3;
            if (temp == 220)
                currentMovement -= 2;
            if (temp == 222)
                currentMovement -= 2;
            if (temp == 224)
                currentMovement -= 2;
            if (temp == 226)
                currentMovement -= 3;
            if (temp == 228)
                currentMovement -= 4;
            if (temp == 230)
                currentMovement -= 5;
            if (temp == 232)
                currentMovement -= 6;
            if (temp == 234)
                currentMovement -= 7;
            if (temp == 236)
                currentMovement -= 8;
            if (temp == 238)
                currentMovement -= 9;
            if (temp == 240)
                currentMovement -= 10;
            if (temp == 242)
                currentMovement -= 11;

            if (temp == 11)
                currentMovement -= 11;
            if (temp == 13)
                currentMovement -= 10;
            if (temp == 15)
                currentMovement -= 9;
            if (temp == 17)
                currentMovement -= 8;
            if (temp == 19)
                currentMovement -= 7;
            if (temp == 111)
                currentMovement -= 6;
            if (temp == 113)
                currentMovement -= 5;
            if (temp == 115)
                currentMovement -= 4;
            if (temp == 117)
                currentMovement -= 3;
            if (temp == 119)
                currentMovement -= 2;
            if (temp == 121)
                currentMovement -= 1;
            if (temp == 123)
                currentMovement -= 1;
            if (temp == 125)
                currentMovement -= 2;
            if (temp == 127)
                currentMovement -= 3;
            if (temp == 129)
                currentMovement -= 4;
            if (temp == 131)
                currentMovement -= 5;
            if (temp == 133)
                currentMovement -= 6;
            if (temp == 135)
                currentMovement -= 7;
            if (temp == 137)
                currentMovement -= 8;
            if (temp == 139)
                currentMovement -= 9;
            if (temp == 141)
                currentMovement -= 10;
            if (temp == 143)
                currentMovement -= 11;

            if (temp == 0)
                currentMovement -= 11;
            if (temp == 2)
                currentMovement -= 10;
            if (temp == 4)
                currentMovement -= 9;
            if (temp == 6)
                currentMovement -= 8;
            if (temp == 8)
                currentMovement -= 7;
            if (temp == 10)
                currentMovement -= 6;
            if (temp == 12)
                currentMovement -= 5;
            if (temp == 14)
                currentMovement -= 4;
            if (temp == 16)
                currentMovement -= 3;
            if (temp == 18)
                currentMovement -= 2;
            if (temp == 20)
                currentMovement -= 1;
            if (temp == 22000)
                currentMovement -= 0;
            if (temp == 24000)
                currentMovement -= 1;
            if (temp == 26000)
                currentMovement -= 2;
            if (temp == 28000)
                currentMovement -= 3;
            if (temp == 30)
                currentMovement -= 4;
            if (temp == 32)
                currentMovement -= 5;
            if (temp == 34)
                currentMovement -= 6;
            if (temp == 36)
                currentMovement -= 7;
            if (temp == 38)
                currentMovement -= 8;
            if (temp == 40)
                currentMovement -= 9;
            if (temp == 42)
                currentMovement -= 10;
            if (temp == 44000)
                currentMovement -= 11;
        }
        else if (activeRing == 10)
        {
            if (temp == 1010)
                currentMovement -= 10;
            if (temp == 1012)
                currentMovement -= 10;
            if (temp == 1014)
                currentMovement -= 10;
            if (temp == 1016)
                currentMovement -= 10;
            if (temp == 1018)
                currentMovement -= 10;
            if (temp == 1020)
                currentMovement -= 10;
            if (temp == 1022)
                currentMovement -= 10;
            if (temp == 1024)
                currentMovement -= 10;
            if (temp == 1026)
                currentMovement -= 10;
            if (temp == 1028)
                currentMovement -= 10;
            if (temp == 1030)
                currentMovement -= 10;

            if (temp == 99)
                currentMovement -= 10;
            if (temp == 911)
                currentMovement -= 9;
            if (temp == 913)
                currentMovement -= 9;
            if (temp == 915)
                currentMovement -= 9;
            if (temp == 917)
                currentMovement -= 9;
            if (temp == 919)
                currentMovement -= 9;
            if (temp == 921)
                currentMovement -= 9;
            if (temp == 923)
                currentMovement -= 9;
            if (temp == 925)
                currentMovement -= 9;
            if (temp == 927)
                currentMovement -= 9;
            if (temp == 929)
                currentMovement -= 9;
            if (temp == 931)
                currentMovement -= 10;

            if (temp == 88)
                currentMovement -= 10;
            if (temp == 810)
                currentMovement -= 9;
            if (temp == 812)
                currentMovement -= 8;
            if (temp == 814)
                currentMovement -= 8;
            if (temp == 816)
                currentMovement -= 8;
            if (temp == 818)
                currentMovement -= 8;
            if (temp == 820)
                currentMovement -= 8;
            if (temp == 822)
                currentMovement -= 8;
            if (temp == 824)
                currentMovement -= 8;
            if (temp == 826)
                currentMovement -= 8;
            if (temp == 828)
                currentMovement -= 8;
            if (temp == 830)
                currentMovement -= 9;
            if (temp == 832)
                currentMovement -= 10;

            if (temp == 77)
                currentMovement -= 10;
            if (temp == 79)
                currentMovement -= 9;
            if (temp == 711)
                currentMovement -= 8;
            if (temp == 713)
                currentMovement -= 7;
            if (temp == 715)
                currentMovement -= 7;
            if (temp == 717)
                currentMovement -= 7;
            if (temp == 719)
                currentMovement -= 7;
            if (temp == 721)
                currentMovement -= 7;
            if (temp == 723)
                currentMovement -= 7;
            if (temp == 725)
                currentMovement -= 7;
            if (temp == 727)
                currentMovement -= 7;
            if (temp == 729)
                currentMovement -= 8;
            if (temp == 731)
                currentMovement -= 9;
            if (temp == 733)
                currentMovement -= 10;

            if (temp == 66)
                currentMovement -= 10;
            if (temp == 68)
                currentMovement -= 9;
            if (temp == 610)
                currentMovement -= 8;
            if (temp == 612)
                currentMovement -= 7;
            if (temp == 614)
                currentMovement -= 6;
            if (temp == 616)
                currentMovement -= 6;
            if (temp == 618)
                currentMovement -= 6;
            if (temp == 620)
                currentMovement -= 6;
            if (temp == 622)
                currentMovement -= 6;
            if (temp == 624)
                currentMovement -= 6;
            if (temp == 626)
                currentMovement -= 6;
            if (temp == 628)
                currentMovement -= 7;
            if (temp == 630)
                currentMovement -= 8;
            if (temp == 632)
                currentMovement -= 9;
            if (temp == 634)
                currentMovement -= 10;

            if (temp == 55)
                currentMovement -= 10;
            if (temp == 57)
                currentMovement -= 9;
            if (temp == 59)
                currentMovement -= 8;
            if (temp == 511)
                currentMovement -= 7;
            if (temp == 513)
                currentMovement -= 6;
            if (temp == 515)
                currentMovement -= 5;
            if (temp == 517)
                currentMovement -= 5;
            if (temp == 519)
                currentMovement -= 5;
            if (temp == 521)
                currentMovement -= 5;
            if (temp == 523)
                currentMovement -= 5;
            if (temp == 525)
                currentMovement -= 5;
            if (temp == 527)
                currentMovement -= 6;
            if (temp == 529)
                currentMovement -= 7;
            if (temp == 531)
                currentMovement -= 8;
            if (temp == 533)
                currentMovement -= 9;
            if (temp == 535)
                currentMovement -= 10;

            if (temp == 44)
                currentMovement -= 10;
            if (temp == 46)
                currentMovement -= 9;
            if (temp == 48)
                currentMovement -= 8;
            if (temp == 410)
                currentMovement -= 7;
            if (temp == 412)
                currentMovement -= 6;
            if (temp == 414)
                currentMovement -= 5;
            if (temp == 416)
                currentMovement -= 4;
            if (temp == 418)
                currentMovement -= 4;
            if (temp == 420)
                currentMovement -= 4;
            if (temp == 422)
                currentMovement -= 4;
            if (temp == 424)
                currentMovement -= 4;
            if (temp == 426)
                currentMovement -= 5;
            if (temp == 428)
                currentMovement -= 6;
            if (temp == 430)
                currentMovement -= 7;
            if (temp == 432)
                currentMovement -= 8;
            if (temp == 434)
                currentMovement -= 9;
            if (temp == 436)
                currentMovement -= 10;

            if (temp == 33)
                currentMovement -= 10;
            if (temp == 35)
                currentMovement -= 9;
            if (temp == 37)
                currentMovement -= 8;
            if (temp == 39)
                currentMovement -= 7;
            if (temp == 311)
                currentMovement -= 6;
            if (temp == 313)
                currentMovement -= 5;
            if (temp == 315)
                currentMovement -= 4;
            if (temp == 317)
                currentMovement -= 3;
            if (temp == 319)
                currentMovement -= 3;
            if (temp == 321)
                currentMovement -= 3;
            if (temp == 323)
                currentMovement -= 3;
            if (temp == 325)
                currentMovement -= 4;
            if (temp == 327)
                currentMovement -= 5;
            if (temp == 329)
                currentMovement -= 6;
            if (temp == 331)
                currentMovement -= 7;
            if (temp == 333)
                currentMovement -= 8;
            if (temp == 335)
                currentMovement -= 9;
            if (temp == 337)
                currentMovement -= 10;

            if (temp == 22)
                currentMovement -= 10;
            if (temp == 24)
                currentMovement -= 9;
            if (temp == 26)
                currentMovement -= 8;
            if (temp == 28)
                currentMovement -= 7;
            if (temp == 210)
                currentMovement -= 6;
            if (temp == 212)
                currentMovement -= 5;
            if (temp == 214)
                currentMovement -= 4;
            if (temp == 216)
                currentMovement -= 3;
            if (temp == 218)
                currentMovement -= 2;
            if (temp == 220)
                currentMovement -= 2;
            if (temp == 222)
                currentMovement -= 2;
            if (temp == 224)
                currentMovement -= 3;
            if (temp == 226)
                currentMovement -= 4;
            if (temp == 228)
                currentMovement -= 5;
            if (temp == 230)
                currentMovement -= 6;
            if (temp == 232)
                currentMovement -= 7;
            if (temp == 234)
                currentMovement -= 8;
            if (temp == 236)
                currentMovement -= 9;
            if (temp == 238)
                currentMovement -= 10;

            if (temp == 11)
                currentMovement -= 10;
            if (temp == 13)
                currentMovement -= 9;
            if (temp == 15)
                currentMovement -= 8;
            if (temp == 17)
                currentMovement -= 7;
            if (temp == 19)
                currentMovement -= 6;
            if (temp == 111)
                currentMovement -= 5;
            if (temp == 113)
                currentMovement -= 4;
            if (temp == 115)
                currentMovement -= 3;
            if (temp == 117)
                currentMovement -= 2;
            if (temp == 119)
                currentMovement -= 1;
            if (temp == 121)
                currentMovement -= 1;
            if (temp == 123)
                currentMovement -= 2;
            if (temp == 125)
                currentMovement -= 3;
            if (temp == 127)
                currentMovement -= 4;
            if (temp == 129)
                currentMovement -= 5;
            if (temp == 131)
                currentMovement -= 6;
            if (temp == 133)
                currentMovement -= 7;
            if (temp == 135)
                currentMovement -= 8;
            if (temp == 137)
                currentMovement -= 9;
            if (temp == 139)
                currentMovement -= 10;

            if (temp == 0)
                currentMovement -= 10;
            if (temp == 2)
                currentMovement -= 9;
            if (temp == 4)
                currentMovement -= 8;
            if (temp == 6)
                currentMovement -= 7;
            if (temp == 8)
                currentMovement -= 6;
            if (temp == 10)
                currentMovement -= 5;
            if (temp == 12)
                currentMovement -= 4;
            if (temp == 14)
                currentMovement -= 3;
            if (temp == 16)
                currentMovement -= 2;
            if (temp == 18)
                currentMovement -= 1;
            if (temp == 20)
                currentMovement -= 0;
            if (temp == 22000)
                currentMovement -= 1;
            if (temp == 24000)
                currentMovement -= 2;
            if (temp == 26000)
                currentMovement -= 3;
            if (temp == 28000)
                currentMovement -= 4;
            if (temp == 30)
                currentMovement -= 5;
            if (temp == 32)
                currentMovement -= 6;
            if (temp == 34)
                currentMovement -= 7;
            if (temp == 36)
                currentMovement -= 8;
            if (temp == 38)
                currentMovement -= 9;
            if (temp == 40)
                currentMovement -= 10;
        }
        else if (activeRing == 9)
        {
            if (temp == 99)
                currentMovement -= 9;
            if (temp == 911)
                currentMovement -= 9;
            if (temp == 913)
                currentMovement -= 9;
            if (temp == 915)
                currentMovement -= 9;
            if (temp == 917)
                currentMovement -= 9;
            if (temp == 919)
                currentMovement -= 9;
            if (temp == 921)
                currentMovement -= 9;
            if (temp == 923)
                currentMovement -= 9;
            if (temp == 925)
                currentMovement -= 9;
            if (temp == 927)
                currentMovement -= 9;

            if (temp == 88)
                currentMovement -= 9;
            if (temp == 810)
                currentMovement -= 8;
            if (temp == 812)
                currentMovement -= 8;
            if (temp == 814)
                currentMovement -= 8;
            if (temp == 816)
                currentMovement -= 8;
            if (temp == 818)
                currentMovement -= 8;
            if (temp == 820)
                currentMovement -= 8;
            if (temp == 822)
                currentMovement -= 8;
            if (temp == 824)
                currentMovement -= 8;
            if (temp == 826)
                currentMovement -= 8;
            if (temp == 828)
                currentMovement -= 9;

            if (temp == 77)
                currentMovement -= 9;
            if (temp == 79)
                currentMovement -= 8;
            if (temp == 711)
                currentMovement -= 7;
            if (temp == 713)
                currentMovement -= 7;
            if (temp == 715)
                currentMovement -= 7;
            if (temp == 717)
                currentMovement -= 7;
            if (temp == 719)
                currentMovement -= 7;
            if (temp == 721)
                currentMovement -= 7;
            if (temp == 723)
                currentMovement -= 7;
            if (temp == 725)
                currentMovement -= 7;
            if (temp == 727)
                currentMovement -= 8;
            if (temp == 729)
                currentMovement -= 9;

            if (temp == 66)
                currentMovement -= 9;
            if (temp == 68)
                currentMovement -= 8;
            if (temp == 610)
                currentMovement -= 7;
            if (temp == 612)
                currentMovement -= 6;
            if (temp == 614)
                currentMovement -= 6;
            if (temp == 616)
                currentMovement -= 6;
            if (temp == 618)
                currentMovement -= 6;
            if (temp == 620)
                currentMovement -= 6;
            if (temp == 622)
                currentMovement -= 6;
            if (temp == 624)
                currentMovement -= 6;
            if (temp == 626)
                currentMovement -= 7;
            if (temp == 628)
                currentMovement -= 8;
            if (temp == 630)
                currentMovement -= 9;

            if (temp == 55)
                currentMovement -= 9;
            if (temp == 57)
                currentMovement -= 8;
            if (temp == 59)
                currentMovement -= 7;
            if (temp == 511)
                currentMovement -= 6;
            if (temp == 513)
                currentMovement -= 5;
            if (temp == 515)
                currentMovement -= 5;
            if (temp == 517)
                currentMovement -= 5;
            if (temp == 519)
                currentMovement -= 5;
            if (temp == 521)
                currentMovement -= 5;
            if (temp == 523)
                currentMovement -= 5;
            if (temp == 525)
                currentMovement -= 6;
            if (temp == 527)
                currentMovement -= 7;
            if (temp == 529)
                currentMovement -= 8;
            if (temp == 531)
                currentMovement -= 9;

            if (temp == 44)
                currentMovement -= 9;
            if (temp == 46)
                currentMovement -= 8;
            if (temp == 48)
                currentMovement -= 7;
            if (temp == 410)
                currentMovement -= 6;
            if (temp == 412)
                currentMovement -= 5;
            if (temp == 414)
                currentMovement -= 4;
            if (temp == 416)
                currentMovement -= 4;
            if (temp == 418)
                currentMovement -= 4;
            if (temp == 420)
                currentMovement -= 4;
            if (temp == 422)
                currentMovement -= 4;
            if (temp == 424)
                currentMovement -= 5;
            if (temp == 426)
                currentMovement -= 6;
            if (temp == 428)
                currentMovement -= 7;
            if (temp == 430)
                currentMovement -= 8;
            if (temp == 432)
                currentMovement -= 9;

            if (temp == 33)
                currentMovement -= 9;
            if (temp == 35)
                currentMovement -= 8;
            if (temp == 37)
                currentMovement -= 7;
            if (temp == 39)
                currentMovement -= 6;
            if (temp == 311)
                currentMovement -= 5;
            if (temp == 313)
                currentMovement -= 4;
            if (temp == 315)
                currentMovement -= 3;
            if (temp == 317)
                currentMovement -= 3;
            if (temp == 319)
                currentMovement -= 3;
            if (temp == 321)
                currentMovement -= 3;
            if (temp == 323)
                currentMovement -= 4;
            if (temp == 325)
                currentMovement -= 5;
            if (temp == 327)
                currentMovement -= 6;
            if (temp == 329)
                currentMovement -= 7;
            if (temp == 331)
                currentMovement -= 8;
            if (temp == 333)
                currentMovement -= 9;

            if (temp == 22)
                currentMovement -= 8;
            if (temp == 24)
                currentMovement -= 7;
            if (temp == 26)
                currentMovement -= 6;
            if (temp == 28)
                currentMovement -= 5;
            if (temp == 210)
                currentMovement -= 4;
            if (temp == 212)
                currentMovement -= 3;
            if (temp == 214)
                currentMovement -= 2;
            if (temp == 216)
                currentMovement -= 2;
            if (temp == 218)
                currentMovement -= 2;
            if (temp == 220)
                currentMovement -= 2;
            if (temp == 222)
                currentMovement -= 3;
            if (temp == 224)
                currentMovement -= 4;
            if (temp == 226)
                currentMovement -= 5;
            if (temp == 228)
                currentMovement -= 6;
            if (temp == 230)
                currentMovement -= 7;
            if (temp == 232)
                currentMovement -= 8;
            if (temp == 234)
                currentMovement -= 9;

            if (temp == 11)
                currentMovement -= 9;
            if (temp == 13)
                currentMovement -= 8;
            if (temp == 15)
                currentMovement -= 7;
            if (temp == 17)
                currentMovement -= 6;
            if (temp == 19)
                currentMovement -= 5;
            if (temp == 111)
                currentMovement -= 4;
            if (temp == 113)
                currentMovement -= 3;
            if (temp == 115)
                currentMovement -= 2;
            if (temp == 117)
                currentMovement -= 1;
            if (temp == 119)
                currentMovement -= 1;
            if (temp == 121)
                currentMovement -= 2;
            if (temp == 123)
                currentMovement -= 3;
            if (temp == 125)
                currentMovement -= 4;
            if (temp == 127)
                currentMovement -= 5;
            if (temp == 129)
                currentMovement -= 6;
            if (temp == 131)
                currentMovement -= 7;
            if (temp == 133)
                currentMovement -= 8;
            if (temp == 135)
                currentMovement -= 9;

            if (temp == 0)
                currentMovement -= 9;
            if (temp == 2)
                currentMovement -= 8;
            if (temp == 4)
                currentMovement -= 7;
            if (temp == 6)
                currentMovement -= 6;
            if (temp == 8)
                currentMovement -= 5;
            if (temp == 10)
                currentMovement -= 4;
            if (temp == 12)
                currentMovement -= 3;
            if (temp == 14)
                currentMovement -= 2;
            if (temp == 16)
                currentMovement -= 1;
            if (temp == 18)
                currentMovement -= 0;
            if (temp == 20)
                currentMovement -= 1;
            if (temp == 22000)
                currentMovement -= 2;
            if (temp == 24000)
                currentMovement -= 3;
            if (temp == 26000)
                currentMovement -= 4;
            if (temp == 28000)
                currentMovement -= 5;
            if (temp == 30)
                currentMovement -= 6;
            if (temp == 32)
                currentMovement -= 7;
            if (temp == 34)
                currentMovement -= 8;
            if (temp == 36)
                currentMovement -= 9;
        }
        else if (activeRing == 8)
        {
            if (temp == 88)
                currentMovement -= 8;
            if (temp == 810)
                currentMovement -= 8;
            if (temp == 812)
                currentMovement -= 8;
            if (temp == 814)
                currentMovement -= 8;
            if (temp == 816)
                currentMovement -= 8;
            if (temp == 818)
                currentMovement -= 8;
            if (temp == 820)
                currentMovement -= 8;
            if (temp == 822)
                currentMovement -= 8;
            if (temp == 824)
                currentMovement -= 8;
            if (temp == 826)
                currentMovement -= 8;

            if (temp == 77)
                currentMovement -= 8;
            if (temp == 79)
                currentMovement -= 7;
            if (temp == 711)
                currentMovement -= 7;
            if (temp == 713)
                currentMovement -= 7;
            if (temp == 715)
                currentMovement -= 7;
            if (temp == 717)
                currentMovement -= 7;
            if (temp == 719)
                currentMovement -= 7;
            if (temp == 721)
                currentMovement -= 7;
            if (temp == 723)
                currentMovement -= 7;
            if (temp == 725)
                currentMovement -= 8;

            if (temp == 66)
                currentMovement -= 8;
            if (temp == 68)
                currentMovement -= 7;
            if (temp == 610)
                currentMovement -= 6;
            if (temp == 612)
                currentMovement -= 6;
            if (temp == 614)
                currentMovement -= 6;
            if (temp == 616)
                currentMovement -= 6;
            if (temp == 618)
                currentMovement -= 6;
            if (temp == 620)
                currentMovement -= 6;
            if (temp == 622)
                currentMovement -= 6;
            if (temp == 624)
                currentMovement -= 7;
            if (temp == 626)
                currentMovement -= 8;

            if (temp == 55)
                currentMovement -= 8;
            if (temp == 57)
                currentMovement -= 7;
            if (temp == 59)
                currentMovement -= 6;
            if (temp == 511)
                currentMovement -= 5;
            if (temp == 513)
                currentMovement -= 5;
            if (temp == 515)
                currentMovement -= 5;
            if (temp == 517)
                currentMovement -= 5;
            if (temp == 519)
                currentMovement -= 5;
            if (temp == 521)
                currentMovement -= 5;
            if (temp == 523)
                currentMovement -= 6;
            if (temp == 525)
                currentMovement -= 7;
            if (temp == 527)
                currentMovement -= 8;

            if (temp == 44)
                currentMovement -= 8;
            if (temp == 46)
                currentMovement -= 7;
            if (temp == 48)
                currentMovement -= 6;
            if (temp == 410)
                currentMovement -= 5;
            if (temp == 412)
                currentMovement -= 4;
            if (temp == 414)
                currentMovement -= 4;
            if (temp == 416)
                currentMovement -= 4;
            if (temp == 418)
                currentMovement -= 4;
            if (temp == 420)
                currentMovement -= 4;
            if (temp == 422)
                currentMovement -= 5;
            if (temp == 424)
                currentMovement -= 6;
            if (temp == 426)
                currentMovement -= 7;
            if (temp == 428)
                currentMovement -= 8;

            if (temp == 33)
                currentMovement -= 8;
            if (temp == 35)
                currentMovement -= 7;
            if (temp == 37)
                currentMovement -= 6;
            if (temp == 39)
                currentMovement -= 5;
            if (temp == 311)
                currentMovement -= 4;
            if (temp == 313)
                currentMovement -= 3;
            if (temp == 315)
                currentMovement -= 3;
            if (temp == 317)
                currentMovement -= 3;
            if (temp == 319)
                currentMovement -= 3;
            if (temp == 321)
                currentMovement -= 4;
            if (temp == 323)
                currentMovement -= 5;
            if (temp == 325)
                currentMovement -= 6;
            if (temp == 327)
                currentMovement -= 7;
            if (temp == 329)
                currentMovement -= 8;

            if (temp == 22)
                currentMovement -= 8;
            if (temp == 24)
                currentMovement -= 7;
            if (temp == 26)
                currentMovement -= 6;
            if (temp == 28)
                currentMovement -= 5;
            if (temp == 210)
                currentMovement -= 4;
            if (temp == 212)
                currentMovement -= 3;
            if (temp == 214)
                currentMovement -= 2;
            if (temp == 216)
                currentMovement -= 2;
            if (temp == 218)
                currentMovement -= 2;
            if (temp == 220)
                currentMovement -= 3;
            if (temp == 222)
                currentMovement -= 4;
            if (temp == 224)
                currentMovement -= 5;
            if (temp == 226)
                currentMovement -= 6;
            if (temp == 228)
                currentMovement -= 7;
            if (temp == 230)
                currentMovement -= 8;

            if (temp == 11)
                currentMovement -= 8;
            if (temp == 13)
                currentMovement -= 7;
            if (temp == 15)
                currentMovement -= 6;
            if (temp == 17)
                currentMovement -= 5;
            if (temp == 19)
                currentMovement -= 4;
            if (temp == 111)
                currentMovement -= 3;
            if (temp == 113)
                currentMovement -= 2;
            if (temp == 115)
                currentMovement -= 1;
            if (temp == 117)
                currentMovement -= 1;
            if (temp == 119)
                currentMovement -= 2;
            if (temp == 121)
                currentMovement -= 3;
            if (temp == 123)
                currentMovement -= 4;
            if (temp == 125)
                currentMovement -= 5;
            if (temp == 127)
                currentMovement -= 6;
            if (temp == 129)
                currentMovement -= 7;
            if (temp == 131)
                currentMovement -= 8;

            if (temp == 0)
                currentMovement -= 8;
            if (temp == 2)
                currentMovement -= 7;
            if (temp == 4)
                currentMovement -= 6;
            if (temp == 6)
                currentMovement -= 5;
            if (temp == 8)
                currentMovement -= 4;
            if (temp == 10)
                currentMovement -= 3;
            if (temp == 12)
                currentMovement -= 2;
            if (temp == 14)
                currentMovement -= 1;
            if (temp == 16)
                currentMovement -= 0;
            if (temp == 18)
                currentMovement -= 1;
            if (temp == 20)
                currentMovement -= 2;
            if (temp == 22000)
                currentMovement -= 3;
            if (temp == 24000)
                currentMovement -= 4;
            if (temp == 26000)
                currentMovement -= 5;
            if (temp == 28000)
                currentMovement -= 6;
            if (temp == 30)
                currentMovement -= 7;
            if (temp == 32)
                currentMovement -= 8;
        }
        else if (activeRing == 7)
        {
            if (temp == 77)
                currentMovement -= 7;
            if (temp == 79)
                currentMovement -= 7;
            if (temp == 711)
                currentMovement -= 7;
            if (temp == 713)
                currentMovement -= 7;
            if (temp == 715)
                currentMovement -= 7;
            if (temp == 717)
                currentMovement -= 7;
            if (temp == 719)
                currentMovement -= 7;
            if (temp == 721)
                currentMovement -= 7;

            if (temp == 66)
                currentMovement -= 7;
            if (temp == 68)
                currentMovement -= 6;
            if (temp == 610)
                currentMovement -= 6;
            if (temp == 612)
                currentMovement -= 6;
            if (temp == 614)
                currentMovement -= 6;
            if (temp == 616)
                currentMovement -= 6;
            if (temp == 618)
                currentMovement -= 6;
            if (temp == 620)
                currentMovement -= 6;
            if (temp == 622)
                currentMovement -= 7;

            if (temp == 55)
                currentMovement -= 7;
            if (temp == 57)
                currentMovement -= 6;
            if (temp == 59)
                currentMovement -= 5;
            if (temp == 511)
                currentMovement -= 5;
            if (temp == 513)
                currentMovement -= 5;
            if (temp == 515)
                currentMovement -= 5;
            if (temp == 517)
                currentMovement -= 5;
            if (temp == 519)
                currentMovement -= 5;
            if (temp == 521)
                currentMovement -= 6;
            if (temp == 523)
                currentMovement -= 7;

            if (temp == 44)
                currentMovement -= 7;
            if (temp == 46)
                currentMovement -= 6;
            if (temp == 48)
                currentMovement -= 5;
            if (temp == 410)
                currentMovement -= 4;
            if (temp == 412)
                currentMovement -= 4;
            if (temp == 414)
                currentMovement -= 4;
            if (temp == 416)
                currentMovement -= 4;
            if (temp == 418)
                currentMovement -= 4;
            if (temp == 420)
                currentMovement -= 5;
            if (temp == 422)
                currentMovement -= 6;
            if (temp == 424)
                currentMovement -= 7;

            if (temp == 33)
                currentMovement -= 7;
            if (temp == 35)
                currentMovement -= 6;
            if (temp == 37)
                currentMovement -= 5;
            if (temp == 39)
                currentMovement -= 4;
            if (temp == 311)
                currentMovement -= 3;
            if (temp == 313)
                currentMovement -= 3;
            if (temp == 315)
                currentMovement -= 3;
            if (temp == 317)
                currentMovement -= 3;
            if (temp == 319)
                currentMovement -= 4;
            if (temp == 321)
                currentMovement -= 5;
            if (temp == 323)
                currentMovement -= 6;
            if (temp == 325)
                currentMovement -= 7;

            if (temp == 22)
                currentMovement -= 7;
            if (temp == 24)
                currentMovement -= 6;
            if (temp == 26)
                currentMovement -= 5;
            if (temp == 28)
                currentMovement -= 4;
            if (temp == 210)
                currentMovement -= 3;
            if (temp == 212)
                currentMovement -= 2;
            if (temp == 214)
                currentMovement -= 2;
            if (temp == 216)
                currentMovement -= 2;
            if (temp == 218)
                currentMovement -= 3;
            if (temp == 220)
                currentMovement -= 4;
            if (temp == 222)
                currentMovement -= 5;
            if (temp == 224)
                currentMovement -= 6;
            if (temp == 226)
                currentMovement -= 7;

            if (temp == 11)
                currentMovement -= 7;
            if (temp == 13)
                currentMovement -= 6;
            if (temp == 15)
                currentMovement -= 5;
            if (temp == 17)
                currentMovement -= 4;
            if (temp == 19)
                currentMovement -= 3;
            if (temp == 111)
                currentMovement -= 2;
            if (temp == 113)
                currentMovement -= 1;
            if (temp == 115)
                currentMovement -= 1;
            if (temp == 117)
                currentMovement -= 2;
            if (temp == 119)
                currentMovement -= 3;
            if (temp == 121)
                currentMovement -= 4;
            if (temp == 123)
                currentMovement -= 5;
            if (temp == 125)
                currentMovement -= 6;
            if (temp == 127)
                currentMovement -= 7;

            if (temp == 0)
                currentMovement -= 7;
            if (temp == 2)
                currentMovement -= 6;
            if (temp == 4)
                currentMovement -= 5;
            if (temp == 6)
                currentMovement -= 4;
            if (temp == 8)
                currentMovement -= 3;
            if (temp == 10)
                currentMovement -= 2;
            if (temp == 12)
                currentMovement -= 1;
            if (temp == 14)
                currentMovement -= 0;
            if (temp == 16)
                currentMovement -= 1;
            if (temp == 18)
                currentMovement -= 2;
            if (temp == 20)
                currentMovement -= 3;
            if (temp == 22000)
                currentMovement -= 4;
            if (temp == 24000)
                currentMovement -= 5;
            if (temp == 26000)
                currentMovement -= 6;
            if (temp == 28000)
                currentMovement -= 7;
        }
        else if (activeRing == 6)//warning using larger systems requires extra variables to keep everything clean, there is 2 22s in 6 without modification that led to problems in testing since changed the name of conflicting variable in generation
        {
            if (temp == 66)
                currentMovement -= 6;
            if (temp == 68)
                currentMovement -= 6;
            if (temp == 610)
                currentMovement -= 6;
            if (temp == 612)
                currentMovement -= 6;
            if (temp == 614)
                currentMovement -= 6;
            if (temp == 616)
                currentMovement -= 6;
            if (temp == 618)
                currentMovement -= 6;

            if (temp == 55)
                currentMovement -= 6;
            if (temp == 57)
                currentMovement -= 5;
            if (temp == 59)
                currentMovement -= 5;
            if (temp == 511)
                currentMovement -= 5;
            if (temp == 513)
                currentMovement -= 5;
            if (temp == 515)
                currentMovement -= 5;
            if (temp == 517)
                currentMovement -= 5;
            if (temp == 519)
                currentMovement -= 6;

            if (temp == 44)
                currentMovement -= 6;
            if (temp == 46)
                currentMovement -= 5;
            if (temp == 48)
                currentMovement -= 4;
            if (temp == 410)
                currentMovement -= 4;
            if (temp == 412)
                currentMovement -= 4;
            if (temp == 414)
                currentMovement -= 4;
            if (temp == 416)
                currentMovement -= 4;
            if (temp == 418)
                currentMovement -= 5;
            if (temp == 420)
                currentMovement -= 6;

            if (temp == 33)
                currentMovement -= 6;
            if (temp == 35)
                currentMovement -= 5;
            if (temp == 37)
                currentMovement -= 4;
            if (temp == 39)
                currentMovement -= 3;
            if (temp == 311)
                currentMovement -= 3;
            if (temp == 313)
                currentMovement -= 3;
            if (temp == 315)
                currentMovement -= 3;
            if (temp == 317)
                currentMovement -= 4;
            if (temp == 319)
                currentMovement -= 5;
            if (temp == 321)
                currentMovement -= 6;

            if (temp == 22)
                currentMovement -= 6;
            if (temp == 24)
                currentMovement -= 5;
            if (temp == 26)
                currentMovement -= 4;
            if (temp == 28)
                currentMovement -= 3;
            if (temp == 210)
                currentMovement -= 2;
            if (temp == 212)
                currentMovement -= 2;
            if (temp == 214)
                currentMovement -= 2;
            if (temp == 216)
                currentMovement -= 3;
            if (temp == 218)
                currentMovement -= 4;
            if (temp == 220)
                currentMovement -= 5;
            if (temp == 222)
                currentMovement -= 6;

            if (temp == 11)
                currentMovement -= 6;
            if (temp == 13)
                currentMovement -= 5;
            if (temp == 15)
                currentMovement -= 4;
            if (temp == 17)
                currentMovement -= 3;
            if (temp == 19)
                currentMovement -= 2;
            if (temp == 111)
                currentMovement -= 1;
            if (temp == 113)
                currentMovement -= 1;
            if (temp == 115)
                currentMovement -= 2;
            if (temp == 117)
                currentMovement -= 3;
            if (temp == 119)
                currentMovement -= 4;
            if (temp == 121)
                currentMovement -= 5;
            if (temp == 123)
                currentMovement -= 6;

            if (temp == 0)
                currentMovement -= 6;
            if (temp == 2)
                currentMovement -= 5;
            if (temp == 4)
                currentMovement -= 4;
            if (temp == 6)
                currentMovement -= 3;
            if (temp == 8)
                currentMovement -= 2;
            if (temp == 10)
                currentMovement -= 1;
            if (temp == 12)
                currentMovement -= 0;
            if (temp == 14)
                currentMovement -= 1;
            if (temp == 16)
                currentMovement -= 2;
            if (temp == 18)
                currentMovement -= 3;
            if (temp == 20)
                currentMovement -= 4;
            if (temp == 22000)
                currentMovement -= 5;
            if (temp == 24000)
                currentMovement -= 6;
        }
        else if (activeRing == 5)
        {
            if (temp == 55)
                currentMovement -= 5;
            if (temp == 57)
                currentMovement -= 5;
            if (temp == 59)
                currentMovement -= 5;
            if (temp == 511)
                currentMovement -= 5;
            if (temp == 513)
                currentMovement -= 5;
            if (temp == 515)
                currentMovement -= 5;

            if (temp == 44)
                currentMovement -= 5;
            if (temp == 46)
                currentMovement -= 4;
            if (temp == 48)
                currentMovement -= 4;
            if (temp == 410)
                currentMovement -= 4;
            if (temp == 412)
                currentMovement -= 4;
            if (temp == 414)
                currentMovement -= 4;
            if (temp == 416)
                currentMovement -= 5;

            if (temp == 33)
                currentMovement -= 5;
            if (temp == 35)
                currentMovement -= 4;
            if (temp == 37)
                currentMovement -= 3;
            if (temp == 39)
                currentMovement -= 3;
            if (temp == 311)
                currentMovement -= 3;
            if (temp == 313)
                currentMovement -= 3;
            if (temp == 315)
                currentMovement -= 4;
            if (temp == 317)
                currentMovement -= 5;

            if (temp == 22)
                currentMovement -= 5;
            if (temp == 24)
                currentMovement -= 4;
            if (temp == 26)
                currentMovement -= 3;
            if (temp == 28)
                currentMovement -= 2;
            if (temp == 210)
                currentMovement -= 2;
            if (temp == 212)
                currentMovement -= 2;
            if (temp == 214)
                currentMovement -= 3;
            if (temp == 216)
                currentMovement -= 4;
            if (temp == 218)
                currentMovement -= 5;

            if (temp == 11)
                currentMovement -= 5;
            if (temp == 13)
                currentMovement -= 4;
            if (temp == 15)
                currentMovement -= 3;
            if (temp == 17)
                currentMovement -= 2;
            if (temp == 19)
                currentMovement -= 1;
            if (temp == 111)
                currentMovement -= 1;
            if (temp == 113)
                currentMovement -= 2;
            if (temp == 115)
                currentMovement -= 3;
            if (temp == 117)
                currentMovement -= 4;
            if (temp == 119)
                currentMovement -= 5;

            if (temp == 0)
                currentMovement -= 5;
            if (temp == 2)
                currentMovement -= 4;
            if (temp == 4)
                currentMovement -= 3;
            if (temp == 6)
                currentMovement -= 2;
            if (temp == 8)
                currentMovement -= 1;
            if (temp == 10)
                currentMovement -= 0;
            if (temp == 12)
                currentMovement -= 1;
            if (temp == 14)
                currentMovement -= 2;
            if (temp == 16)
                currentMovement -= 3;
            if (temp == 18)
                currentMovement -= 4;
            if (temp == 20)
                currentMovement -= 5;
        }
        else if (activeRing == 4)
        {
            if (temp == 44)
                currentMovement -= 4;
            if (temp == 46)
                currentMovement -= 4;
            if (temp == 48)
                currentMovement -= 4;
            if (temp == 410)
                currentMovement -= 4;
            if (temp == 412)
                currentMovement -= 4;

            if (temp == 33)
                currentMovement -= 4;
            if (temp == 35)
                currentMovement -= 3;
            if (temp == 37)
                currentMovement -= 3;
            if (temp == 39)
                currentMovement -= 3;
            if (temp == 311)
                currentMovement -= 3;
            if (temp == 313)
                currentMovement -= 4;

            if (temp == 22)
                currentMovement -= 4;
            if (temp == 24)
                currentMovement -= 3;
            if (temp == 26)
                currentMovement -= 2;
            if (temp == 28)
                currentMovement -= 2;
            if (temp == 210)
                currentMovement -= 2;
            if (temp == 212)
                currentMovement -= 3;
            if (temp == 214)
                currentMovement -= 4;

            if (temp == 11)
                currentMovement -= 4;
            if (temp == 13)
                currentMovement -= 3;
            if (temp == 15)
                currentMovement -= 2;
            if (temp == 17)
                currentMovement -= 1;
            if (temp == 19)
                currentMovement -= 1;
            if (temp == 111)
                currentMovement -= 2;
            if (temp == 113)
                currentMovement -= 3;
            if (temp == 115)
                currentMovement -= 4;

            if (temp == 0)
                currentMovement -= 4;
            if (temp == 2)
                currentMovement -= 3;
            if (temp == 4)
                currentMovement -= 2;
            if (temp == 6)
                currentMovement -= 1;
            if (temp == 8)
                currentMovement -= 0;
            if (temp == 10)
                currentMovement -= 1;
            if (temp == 12)
                currentMovement -= 2;
            if (temp == 14)
                currentMovement -= 3;
            if (temp == 16)
                currentMovement -= 4;
        }
        else if (activeRing == 3)
        {
            if (temp == 33)
                currentMovement -= 3;
            if (temp == 35)
                currentMovement -= 3;
            if (temp == 37)
                currentMovement -= 3;
            if (temp == 39)
                currentMovement -= 3;

            if (temp == 22)
                currentMovement -= 3;
            if (temp == 24)
                currentMovement -= 2;
            if (temp == 26)
                currentMovement -= 2;
            if (temp == 28)
                currentMovement -= 2;
            if (temp == 210)
                currentMovement -= 3;

            if (temp == 11)
                currentMovement -= 3;
            if (temp == 13)
                currentMovement -= 2;
            if (temp == 15)
                currentMovement -= 1;
            if (temp == 17)
                currentMovement -= 1;
            if (temp == 19)
                currentMovement -= 2;
            if (temp == 111)
                currentMovement -= 3;

            if (temp == 0)
                currentMovement -= 3;
            if (temp == 2)
                currentMovement -= 2;
            if (temp == 4)
                currentMovement -= 1;
            if (temp == 6)
                currentMovement -= 0;
            if (temp == 8)
                currentMovement -= 1;
            if (temp == 10)
                currentMovement -= 2;
            if (temp == 12)
                currentMovement -= 3;
        }
        else if (activeRing == 2)
        {
            if (temp == 22)
                currentMovement -= 2;
            if (temp == 24)
                currentMovement -= 2;
            if (temp == 26)
                currentMovement -= 2;

            if (temp == 11)
                currentMovement -= 2;
            if (temp == 13)
                currentMovement -= 1;
            if (temp == 15)
                currentMovement -= 1;
            if (temp == 17)
                currentMovement -= 2;

            if (temp == 0)
                currentMovement -= 2;
            if (temp == 2)
                currentMovement -= 1;
            if (temp == 4)
                currentMovement -= 0;
            if (temp == 6)
                currentMovement -= 1;
            if (temp == 8)
                currentMovement -= 2;

        }
        else if (activeRing == 1)
        {
            if (temp == 11)
                currentMovement -= 1;
            if (temp == 13)
                currentMovement -= 1;

            if (temp == 0)
                currentMovement -= 1;
            if (temp == 2)
                currentMovement -= 0;
            if (temp == 4)
                currentMovement -= 1;
        }
        return currentMovement;
    }
    public int flipRange(int activeRing)
    {
        int temp = 0;
        bool i = int.TryParse(gameObject.GetComponent<ModelMouseManager>().target, out num);
        if (i)
        {
            temp = Mathf.Abs(num);
            if (activeRing == 12)
            {
                if (temp == 1212)
                    return 12;
                if (temp == 1214)
                    return 12;
                if (temp == 1216)
                    return 12;
                if (temp == 1218)
                    return 12;
                if (temp == 1220)
                    return 12;
                if (temp == 1222)
                    return 12;
                if (temp == 1224)
                    return 12;
                if (temp == 1226)
                    return 12;
                if (temp == 1228)
                    return 12;
                if (temp == 1230)
                    return 12;
                if (temp == 1232)
                    return 12;
                if (temp == 1234)
                    return 12;
                if (temp == 1236)
                    return 12;

                if (temp == 1111)
                    return 12;
                if (temp == 1113)
                    return 11;
                if (temp == 1115)
                    return 11;
                if (temp == 1117)
                    return 11;
                if (temp == 1119)
                    return 11;
                if (temp == 1121)
                    return 11;
                if (temp == 1123)
                    return 11;
                if (temp == 1125)
                    return 11;
                if (temp == 1127)
                    return 11;
                if (temp == 1129)
                    return 11;
                if (temp == 1131)
                    return 11;
                if (temp == 1133)
                    return 11;
                if (temp == 1135)
                    return 11;
                if (temp == 1137)
                    return 12;

                if (temp == 1010)
                    return 12;
                if (temp == 1012)
                    return 11;
                if (temp == 1014)
                    return 10;
                if (temp == 1016)
                    return 10;
                if (temp == 1018)
                    return 10;
                if (temp == 1020)
                    return 10;
                if (temp == 1022)
                    return 10;
                if (temp == 1024)
                    return 10;
                if (temp == 1026)
                    return 10;
                if (temp == 1028)
                    return 10;
                if (temp == 1030)
                    return 10;
                if (temp == 1032)
                    return 10;
                if (temp == 1034)
                    return 10;
                if (temp == 1036)
                    return 11;
                if (temp == 1038)
                    return 12;

                if (temp == 99)
                    return 12;
                if (temp == 911)
                    return 11;
                if (temp == 913)
                    return 10;
                if (temp == 915)
                    return 9;
                if (temp == 917)
                    return 9;
                if (temp == 919)
                    return 9;
                if (temp == 921)
                    return 9;
                if (temp == 923)
                    return 9;
                if (temp == 925)
                    return 9;
                if (temp == 927)
                    return 9;
                if (temp == 929)
                    return 9;
                if (temp == 931)
                    return 9;
                if (temp == 933)
                    return 9;
                if (temp == 935)
                    return 10;
                if (temp == 937)
                    return 11;
                if (temp == 939)
                    return 12;

                if (temp == 88)
                    return 12;
                if (temp == 810)
                    return 11;
                if (temp == 812)
                    return 10;
                if (temp == 814)
                    return 9;
                if (temp == 816)
                    return 8;
                if (temp == 818)
                    return 8;
                if (temp == 820)
                    return 8;
                if (temp == 822)
                    return 8;
                if (temp == 824)
                    return 8;
                if (temp == 826)
                    return 8;
                if (temp == 828)
                    return 8;
                if (temp == 830)
                    return 8;
                if (temp == 832)
                    return 8;
                if (temp == 834)
                    return 9;
                if (temp == 836)
                    return 10;
                if (temp == 838)
                    return 11;
                if (temp == 840)
                    return 12;

                if (temp == 77)
                    return 12;
                if (temp == 79)
                    return 11;
                if (temp == 711)
                    return 10;
                if (temp == 713)
                    return 9;
                if (temp == 715)
                    return 8;
                if (temp == 717)
                    return 7;
                if (temp == 719)
                    return 7;
                if (temp == 721)
                    return 7;
                if (temp == 723)
                    return 7;
                if (temp == 725)
                    return 7;
                if (temp == 727)
                    return 7;
                if (temp == 729)
                    return 7;
                if (temp == 731)
                    return 7;
                if (temp == 733)
                    return 8;
                if (temp == 735)
                    return 9;
                if (temp == 737)
                    return 10;
                if (temp == 739)
                    return 11;
                if (temp == 741)
                    return 12;

                if (temp == 66)
                    return 12;
                if (temp == 68)
                    return 11;
                if (temp == 610)
                    return 10;
                if (temp == 612)
                    return 9;
                if (temp == 614)
                    return 8;
                if (temp == 616)
                    return 7;
                if (temp == 618)
                    return 6;
                if (temp == 620)
                    return 6;
                if (temp == 622)
                    return 6;
                if (temp == 624)
                    return 6;
                if (temp == 626)
                    return 6;
                if (temp == 628)
                    return 6;
                if (temp == 630)
                    return 6;
                if (temp == 632)
                    return 7;
                if (temp == 634)
                    return 8;
                if (temp == 636)
                    return 9;
                if (temp == 638)
                    return 10;
                if (temp == 640)
                    return 11;
                if (temp == 642)
                    return 12;

                if (temp == 55)
                    return 12;
                if (temp == 57)
                    return 11;
                if (temp == 59)
                    return 10;
                if (temp == 511)
                    return 9;
                if (temp == 513)
                    return 8;
                if (temp == 515)
                    return 7;
                if (temp == 517)
                    return 6;
                if (temp == 519)
                    return 5;
                if (temp == 521)
                    return 5;
                if (temp == 523)
                    return 5;
                if (temp == 525)
                    return 5;
                if (temp == 527)
                    return 5;
                if (temp == 529)
                    return 5;
                if (temp == 531)
                    return 6;
                if (temp == 533)
                    return 7;
                if (temp == 535)
                    return 8;
                if (temp == 537)
                    return 9;
                if (temp == 539)
                    return 10;
                if (temp == 541)
                    return 11;
                if (temp == 543)
                    return 12;

                if (temp == 44)
                    return 12;
                if (temp == 46)
                    return 11;
                if (temp == 48)
                    return 10;
                if (temp == 410)
                    return 9;
                if (temp == 412)
                    return 8;
                if (temp == 414)
                    return 7;
                if (temp == 416)
                    return 6;
                if (temp == 418)
                    return 5;
                if (temp == 420)
                    return 4;
                if (temp == 422)
                    return 4;
                if (temp == 424)
                    return 4;
                if (temp == 426)
                    return 4;
                if (temp == 428)
                    return 4;
                if (temp == 430)
                    return 5;
                if (temp == 432)
                    return 6;
                if (temp == 434)
                    return 7;
                if (temp == 436)
                    return 8;
                if (temp == 438)
                    return 9;
                if (temp == 440)
                    return 10;
                if (temp == 442)
                    return 11;
                if (temp == 444)
                    return 12;

                if (temp == 33)
                    return 12;
                if (temp == 35)
                    return 11;
                if (temp == 37)
                    return 10;
                if (temp == 39)
                    return 9;
                if (temp == 311)
                    return 8;
                if (temp == 313)
                    return 7;
                if (temp == 315)
                    return 6;
                if (temp == 317)
                    return 5;
                if (temp == 319)
                    return 4;
                if (temp == 321)
                    return 3;
                if (temp == 323)
                    return 3;
                if (temp == 325)
                    return 3;
                if (temp == 327)
                    return 3;
                if (temp == 329)
                    return 4;
                if (temp == 331)
                    return 5;
                if (temp == 333)
                    return 6;
                if (temp == 335)
                    return 7;
                if (temp == 337)
                    return 8;
                if (temp == 339)
                    return 9;
                if (temp == 341)
                    return 10;
                if (temp == 343)
                    return 11;
                if (temp == 345)
                    return 12;

                if (temp == 22)
                    return 12;
                if (temp == 24)
                    return 11;
                if (temp == 26)
                    return 10;
                if (temp == 28)
                    return 9;
                if (temp == 210)
                    return 8;
                if (temp == 212)
                    return 7;
                if (temp == 214)
                    return 6;
                if (temp == 216)
                    return 5;
                if (temp == 218)
                    return 4;
                if (temp == 220)
                    return 3;
                if (temp == 222)
                    return 2;
                if (temp == 224)
                    return 2;
                if (temp == 226)
                    return 2;
                if (temp == 228)
                    return 3;
                if (temp == 230)
                    return 4;
                if (temp == 232)
                    return 5;
                if (temp == 234)
                    return 6;
                if (temp == 236)
                    return 7;
                if (temp == 238)
                    return 8;
                if (temp == 240)
                    return 9;
                if (temp == 242)
                    return 10;
                if (temp == 244)
                    return 11;
                if (temp == 246)
                    return 12;

                if (temp == 11)
                    return 12;
                if (temp == 13)
                    return 11;
                if (temp == 15)
                    return 10;
                if (temp == 17)
                    return 9;
                if (temp == 19)
                    return 8;
                if (temp == 111)
                    return 7;
                if (temp == 113)
                    return 6;
                if (temp == 115)
                    return 5;
                if (temp == 117)
                    return 4;
                if (temp == 119)
                    return 3;
                if (temp == 121)
                    return 2;
                if (temp == 123)
                    return 1;
                if (temp == 125)
                    return 1;
                if (temp == 127)
                    return 2;
                if (temp == 129)
                    return 3;
                if (temp == 131)
                    return 4;
                if (temp == 133)
                    return 5;
                if (temp == 135)
                    return 6;
                if (temp == 137)
                    return 7;
                if (temp == 139)
                    return 8;
                if (temp == 141)
                    return 9;
                if (temp == 143)
                    return 10;
                if (temp == 145)
                    return 11;
                if (temp == 147)
                    return 12;

                if (temp == 0)
                    return 12;
                if (temp == 2)
                    return 11;
                if (temp == 4)
                    return 10;
                if (temp == 6)
                    return 9;
                if (temp == 8)
                    return 8;
                if (temp == 10)
                    return 7;
                if (temp == 12)
                    return 6;
                if (temp == 14)
                    return 5;
                if (temp == 16)
                    return 4;
                if (temp == 18)
                    return 3;
                if (temp == 20)
                    return 2;
                if (temp == 22000)
                    return 1;
                if (temp == 24000)
                    return 0;
                if (temp == 26000)
                    return 1;
                if (temp == 28000)
                    return 2;
                if (temp == 30)
                    return 3;
                if (temp == 32)
                    return 4;
                if (temp == 34)
                    return 5;
                if (temp == 36)
                    return 6;
                if (temp == 38)
                    return 7;
                if (temp == 40)
                    return 8;
                if (temp == 42)
                    return 9;
                if (temp == 44000)
                    return 10;
                if (temp == 46000)
                    return 11;
                if (temp == 48000)
                    return 12;
            }
            else if (activeRing == 11)
            {
                if (temp == 1111)
                    return 11;
                if (temp == 1113)
                    return 11;
                if (temp == 1115)
                    return 11;
                if (temp == 1117)
                    return 11;
                if (temp == 1119)
                    return 11;
                if (temp == 1121)
                    return 11;
                if (temp == 1123)
                    return 11;
                if (temp == 1125)
                    return 11;
                if (temp == 1127)
                    return 11;
                if (temp == 1129)
                    return 11;
                if (temp == 1131)
                    return 11;
                if (temp == 1133)
                    return 11;

                if (temp == 1010)
                    return 11;
                if (temp == 1012)
                    return 10;
                if (temp == 1014)
                    return 10;
                if (temp == 1016)
                    return 10;
                if (temp == 1018)
                    return 10;
                if (temp == 1020)
                    return 10;
                if (temp == 1022)
                    return 10;
                if (temp == 1024)
                    return 10;
                if (temp == 1026)
                    return 10;
                if (temp == 1028)
                    return 10;
                if (temp == 1030)
                    return 10;
                if (temp == 1032)
                    return 10;
                if (temp == 1034)
                    return 11;

                if (temp == 99)
                    return 11;
                if (temp == 911)
                    return 10;
                if (temp == 913)
                    return 9;
                if (temp == 915)
                    return 9;
                if (temp == 917)
                    return 9;
                if (temp == 919)
                    return 9;
                if (temp == 921)
                    return 9;
                if (temp == 923)
                    return 9;
                if (temp == 925)
                    return 9;
                if (temp == 927)
                    return 9;
                if (temp == 929)
                    return 9;
                if (temp == 931)
                    return 9;
                if (temp == 933)
                    return 10;
                if (temp == 935)
                    return 11;

                if (temp == 88)
                    return 11;
                if (temp == 810)
                    return 10;
                if (temp == 812)
                    return 9;
                if (temp == 814)
                    return 8;
                if (temp == 816)
                    return 8;
                if (temp == 818)
                    return 8;
                if (temp == 820)
                    return 8;
                if (temp == 822)
                    return 8;
                if (temp == 824)
                    return 8;
                if (temp == 826)
                    return 8;
                if (temp == 828)
                    return 8;
                if (temp == 830)
                    return 8;
                if (temp == 832)
                    return 9;
                if (temp == 834)
                    return 10;
                if (temp == 836)
                    return 11;

                if (temp == 77)
                    return 11;
                if (temp == 79)
                    return 10;
                if (temp == 711)
                    return 9;
                if (temp == 713)
                    return 8;
                if (temp == 715)
                    return 7;
                if (temp == 717)
                    return 7;
                if (temp == 719)
                    return 7;
                if (temp == 721)
                    return 7;
                if (temp == 723)
                    return 7;
                if (temp == 725)
                    return 7;
                if (temp == 727)
                    return 7;
                if (temp == 729)
                    return 7;
                if (temp == 731)
                    return 8;
                if (temp == 733)
                    return 9;
                if (temp == 735)
                    return 10;
                if (temp == 737)
                    return 11;

                if (temp == 66)
                    return 11;
                if (temp == 68)
                    return 10;
                if (temp == 610)
                    return 9;
                if (temp == 612)
                    return 8;
                if (temp == 614)
                    return 7;
                if (temp == 616)
                    return 6;
                if (temp == 618)
                    return 6;
                if (temp == 620)
                    return 6;
                if (temp == 622)
                    return 6;
                if (temp == 624)
                    return 6;
                if (temp == 626)
                    return 6;
                if (temp == 628)
                    return 6;
                if (temp == 630)
                    return 7;
                if (temp == 632)
                    return 8;
                if (temp == 634)
                    return 9;
                if (temp == 636)
                    return 10;
                if (temp == 638)
                    return 11;

                if (temp == 55)
                    return 11;
                if (temp == 57)
                    return 10;
                if (temp == 59)
                    return 9;
                if (temp == 511)
                    return 8;
                if (temp == 513)
                    return 7;
                if (temp == 515)
                    return 6;
                if (temp == 517)
                    return 5;
                if (temp == 519)
                    return 5;
                if (temp == 521)
                    return 5;
                if (temp == 523)
                    return 5;
                if (temp == 525)
                    return 5;
                if (temp == 527)
                    return 5;
                if (temp == 529)
                    return 5;
                if (temp == 531)
                    return 6;
                if (temp == 533)
                    return 8;
                if (temp == 535)
                    return 9;
                if (temp == 537)
                    return 10;
                if (temp == 539)
                    return 11;

                if (temp == 44)
                    return 11;
                if (temp == 46)
                    return 10;
                if (temp == 48)
                    return 9;
                if (temp == 410)
                    return 8;
                if (temp == 412)
                    return 7;
                if (temp == 414)
                    return 6;
                if (temp == 416)
                    return 5;
                if (temp == 418)
                    return 4;
                if (temp == 420)
                    return 4;
                if (temp == 422)
                    return 4;
                if (temp == 424)
                    return 4;
                if (temp == 426)
                    return 4;
                if (temp == 428)
                    return 5;
                if (temp == 430)
                    return 6;
                if (temp == 432)
                    return 7;
                if (temp == 434)
                    return 8;
                if (temp == 436)
                    return 9;
                if (temp == 438)
                    return 10;
                if (temp == 440)
                    return 11;

                if (temp == 33)
                    return 11;
                if (temp == 35)
                    return 10;
                if (temp == 37)
                    return 9;
                if (temp == 39)
                    return 8;
                if (temp == 311)
                    return 7;
                if (temp == 313)
                    return 6;
                if (temp == 315)
                    return 5;
                if (temp == 317)
                    return 4;
                if (temp == 319)
                    return 3;
                if (temp == 321)
                    return 3;
                if (temp == 323)
                    return 3;
                if (temp == 325)
                    return 3;
                if (temp == 327)
                    return 4;
                if (temp == 329)
                    return 5;
                if (temp == 331)
                    return 6;
                if (temp == 333)
                    return 7;
                if (temp == 335)
                    return 8;
                if (temp == 337)
                    return 9;
                if (temp == 339)
                    return 10;
                if (temp == 341)
                    return 11;

                if (temp == 22)
                    return 11;
                if (temp == 24)
                    return 10;
                if (temp == 26)
                    return 9;
                if (temp == 28)
                    return 8;
                if (temp == 210)
                    return 7;
                if (temp == 212)
                    return 6;
                if (temp == 214)
                    return 5;
                if (temp == 216)
                    return 4;
                if (temp == 218)
                    return 3;
                if (temp == 220)
                    return 2;
                if (temp == 222)
                    return 2;
                if (temp == 224)
                    return 2;
                if (temp == 226)
                    return 3;
                if (temp == 228)
                    return 4;
                if (temp == 230)
                    return 5;
                if (temp == 232)
                    return 6;
                if (temp == 234)
                    return 7;
                if (temp == 236)
                    return 8;
                if (temp == 238)
                    return 9;
                if (temp == 240)
                    return 10;
                if (temp == 242)
                    return 11;

                if (temp == 11)
                    return 11;
                if (temp == 13)
                    return 10;
                if (temp == 15)
                    return 9;
                if (temp == 17)
                    return 8;
                if (temp == 19)
                    return 7;
                if (temp == 111)
                    return 6;
                if (temp == 113)
                    return 5;
                if (temp == 115)
                    return 4;
                if (temp == 117)
                    return 3;
                if (temp == 119)
                    return 2;
                if (temp == 121)
                    return 1;
                if (temp == 123)
                    return 1;
                if (temp == 125)
                    return 2;
                if (temp == 127)
                    return 3;
                if (temp == 129)
                    return 4;
                if (temp == 131)
                    return 5;
                if (temp == 133)
                    return 6;
                if (temp == 135)
                    return 7;
                if (temp == 137)
                    return 8;
                if (temp == 139)
                    return 9;
                if (temp == 141)
                    return 10;
                if (temp == 143)
                    return 11;

                if (temp == 0)
                    return 11;
                if (temp == 2)
                    return 10;
                if (temp == 4)
                    return 9;
                if (temp == 6)
                    return 8;
                if (temp == 8)
                    return 7;
                if (temp == 10)
                    return 6;
                if (temp == 12)
                    return 5;
                if (temp == 14)
                    return 4;
                if (temp == 16)
                    return 3;
                if (temp == 18)
                    return 2;
                if (temp == 20)
                    return 1;
                if (temp == 22000)
                    return 0;
                if (temp == 24000)
                    return 1;
                if (temp == 26000)
                    return 2;
                if (temp == 28000)
                    return 3;
                if (temp == 30)
                    return 4;
                if (temp == 32)
                    return 5;
                if (temp == 34)
                    return 6;
                if (temp == 36)
                    return 7;
                if (temp == 38)
                    return 8;
                if (temp == 40)
                    return 9;
                if (temp == 42)
                    return 10;
                if (temp == 44000)
                    return 11;
            }
            else if (activeRing == 10)
            {
                if (temp == 1010)
                    return 10;
                if (temp == 1012)
                    return 10;
                if (temp == 1014)
                    return 10;
                if (temp == 1016)
                    return 10;
                if (temp == 1018)
                    return 10;
                if (temp == 1020)
                    return 10;
                if (temp == 1022)
                    return 10;
                if (temp == 1024)
                    return 10;
                if (temp == 1026)
                    return 10;
                if (temp == 1028)
                    return 10;
                if (temp == 1030)
                    return 10;

                if (temp == 99)
                    return 10;
                if (temp == 911)
                    return 9;
                if (temp == 913)
                    return 9;
                if (temp == 915)
                    return 9;
                if (temp == 917)
                    return 9;
                if (temp == 919)
                    return 9;
                if (temp == 921)
                    return 9;
                if (temp == 923)
                    return 9;
                if (temp == 925)
                    return 9;
                if (temp == 927)
                    return 9;
                if (temp == 929)
                    return 9;
                if (temp == 931)
                    return 10;

                if (temp == 88)
                    return 10;
                if (temp == 810)
                    return 9;
                if (temp == 812)
                    return 8;
                if (temp == 814)
                    return 8;
                if (temp == 816)
                    return 8;
                if (temp == 818)
                    return 8;
                if (temp == 820)
                    return 8;
                if (temp == 822)
                    return 8;
                if (temp == 824)
                    return 8;
                if (temp == 826)
                    return 8;
                if (temp == 828)
                    return 8;
                if (temp == 830)
                    return 9;
                if (temp == 832)
                    return 10;

                if (temp == 77)
                    return 10;
                if (temp == 79)
                    return 9;
                if (temp == 711)
                    return 8;
                if (temp == 713)
                    return 7;
                if (temp == 715)
                    return 7;
                if (temp == 717)
                    return 7;
                if (temp == 719)
                    return 7;
                if (temp == 721)
                    return 7;
                if (temp == 723)
                    return 7;
                if (temp == 725)
                    return 7;
                if (temp == 727)
                    return 7;
                if (temp == 729)
                    return 8;
                if (temp == 731)
                    return 9;
                if (temp == 733)
                    return 10;

                if (temp == 66)
                    return 10;
                if (temp == 68)
                    return 9;
                if (temp == 610)
                    return 8;
                if (temp == 612)
                    return 7;
                if (temp == 614)
                    return 6;
                if (temp == 616)
                    return 6;
                if (temp == 618)
                    return 6;
                if (temp == 620)
                    return 6;
                if (temp == 622)
                    return 6;
                if (temp == 624)
                    return 6;
                if (temp == 626)
                    return 6;
                if (temp == 628)
                    return 7;
                if (temp == 630)
                    return 8;
                if (temp == 632)
                    return 9;
                if (temp == 634)
                    return 10;

                if (temp == 55)
                    return 10;
                if (temp == 57)
                    return 9;
                if (temp == 59)
                    return 8;
                if (temp == 511)
                    return 7;
                if (temp == 513)
                    return 6;
                if (temp == 515)
                    return 5;
                if (temp == 517)
                    return 5;
                if (temp == 519)
                    return 5;
                if (temp == 521)
                    return 5;
                if (temp == 523)
                    return 5;
                if (temp == 525)
                    return 5;
                if (temp == 527)
                    return 6;
                if (temp == 529)
                    return 7;
                if (temp == 531)
                    return 8;
                if (temp == 533)
                    return 9;
                if (temp == 535)
                    return 10;

                if (temp == 44)
                    return 10;
                if (temp == 46)
                    return 9;
                if (temp == 48)
                    return 8;
                if (temp == 410)
                    return 7;
                if (temp == 412)
                    return 6;
                if (temp == 414)
                    return 5;
                if (temp == 416)
                    return 4;
                if (temp == 418)
                    return 4;
                if (temp == 420)
                    return 4;
                if (temp == 422)
                    return 4;
                if (temp == 424)
                    return 4;
                if (temp == 426)
                    return 5;
                if (temp == 428)
                    return 6;
                if (temp == 430)
                    return 7;
                if (temp == 432)
                    return 8;
                if (temp == 434)
                    return 9;
                if (temp == 436)
                    return 10;

                if (temp == 33)
                    return 10;
                if (temp == 35)
                    return 9;
                if (temp == 37)
                    return 8;
                if (temp == 39)
                    return 7;
                if (temp == 311)
                    return 6;
                if (temp == 313)
                    return 5;
                if (temp == 315)
                    return 4;
                if (temp == 317)
                    return 3;
                if (temp == 319)
                    return 3;
                if (temp == 321)
                    return 3;
                if (temp == 323)
                    return 3;
                if (temp == 325)
                    return 4;
                if (temp == 327)
                    return 5;
                if (temp == 329)
                    return 6;
                if (temp == 331)
                    return 7;
                if (temp == 333)
                    return 8;
                if (temp == 335)
                    return 9;
                if (temp == 337)
                    return 10;

                if (temp == 22)
                    return 10;
                if (temp == 24)
                    return 9;
                if (temp == 26)
                    return 8;
                if (temp == 28)
                    return 7;
                if (temp == 210)
                    return 6;
                if (temp == 212)
                    return 5;
                if (temp == 214)
                    return 4;
                if (temp == 216)
                    return 3;
                if (temp == 218)
                    return 2;
                if (temp == 220)
                    return 2;
                if (temp == 222)
                    return 2;
                if (temp == 224)
                    return 3;
                if (temp == 226)
                    return 4;
                if (temp == 228)
                    return 5;
                if (temp == 230)
                    return 6;
                if (temp == 232)
                    return 7;
                if (temp == 234)
                    return 8;
                if (temp == 236)
                    return 9;
                if (temp == 238)
                    return 10;

                if (temp == 11)
                    return 10;
                if (temp == 13)
                    return 9;
                if (temp == 15)
                    return 8;
                if (temp == 17)
                    return 7;
                if (temp == 19)
                    return 6;
                if (temp == 111)
                    return 5;
                if (temp == 113)
                    return 4;
                if (temp == 115)
                    return 3;
                if (temp == 117)
                    return 2;
                if (temp == 119)
                    return 1;
                if (temp == 121)
                    return 1;
                if (temp == 123)
                    return 2;
                if (temp == 125)
                    return 3;
                if (temp == 127)
                    return 4;
                if (temp == 129)
                    return 5;
                if (temp == 131)
                    return 6;
                if (temp == 133)
                    return 7;
                if (temp == 135)
                    return 8;
                if (temp == 137)
                    return 9;
                if (temp == 139)
                    return 10;

                if (temp == 0)
                    return 10;
                if (temp == 2)
                    return 9;
                if (temp == 4)
                    return 8;
                if (temp == 6)
                    return 7;
                if (temp == 8)
                    return 6;
                if (temp == 10)
                    return 5;
                if (temp == 12)
                    return 4;
                if (temp == 14)
                    return 3;
                if (temp == 16)
                    return 2;
                if (temp == 18)
                    return 1;
                if (temp == 20)
                    return 0;
                if (temp == 22000)
                    return 1;
                if (temp == 24000)
                    return 2;
                if (temp == 26000)
                    return 3;
                if (temp == 28000)
                    return 4;
                if (temp == 30)
                    return 5;
                if (temp == 32)
                    return 6;
                if (temp == 34)
                    return 7;
                if (temp == 36)
                    return 8;
                if (temp == 38)
                    return 9;
                if (temp == 40)
                    return 10;
            }
            else if (activeRing == 9)
            {
                if (temp == 99)
                    return 9;
                if (temp == 911)
                    return 9;
                if (temp == 913)
                    return 9;
                if (temp == 915)
                    return 9;
                if (temp == 917)
                    return 9;
                if (temp == 919)
                    return 9;
                if (temp == 921)
                    return 9;
                if (temp == 923)
                    return 9;
                if (temp == 925)
                    return 9;
                if (temp == 927)
                    return 9;

                if (temp == 88)
                    return 9;
                if (temp == 810)
                    return 8;
                if (temp == 812)
                    return 8;
                if (temp == 814)
                    return 8;
                if (temp == 816)
                    return 8;
                if (temp == 818)
                    return 8;
                if (temp == 820)
                    return 8;
                if (temp == 822)
                    return 8;
                if (temp == 824)
                    return 8;
                if (temp == 826)
                    return 8;
                if (temp == 828)
                    return 9;

                if (temp == 77)
                    return 9;
                if (temp == 79)
                    return 8;
                if (temp == 711)
                    return 7;
                if (temp == 713)
                    return 7;
                if (temp == 715)
                    return 7;
                if (temp == 717)
                    return 7;
                if (temp == 719)
                    return 7;
                if (temp == 721)
                    return 7;
                if (temp == 723)
                    return 7;
                if (temp == 725)
                    return 7;
                if (temp == 727)
                    return 8;
                if (temp == 729)
                    return 9;

                if (temp == 66)
                    return 9;
                if (temp == 68)
                    return 8;
                if (temp == 610)
                    return 7;
                if (temp == 612)
                    return 6;
                if (temp == 614)
                    return 6;
                if (temp == 616)
                    return 6;
                if (temp == 618)
                    return 6;
                if (temp == 620)
                    return 6;
                if (temp == 622)
                    return 6;
                if (temp == 624)
                    return 6;
                if (temp == 626)
                    return 7;
                if (temp == 628)
                    return 8;
                if (temp == 630)
                    return 9;

                if (temp == 55)
                    return 9;
                if (temp == 57)
                    return 8;
                if (temp == 59)
                    return 7;
                if (temp == 511)
                    return 6;
                if (temp == 513)
                    return 5;
                if (temp == 515)
                    return 5;
                if (temp == 517)
                    return 5;
                if (temp == 519)
                    return 5;
                if (temp == 521)
                    return 5;
                if (temp == 523)
                    return 5;
                if (temp == 525)
                    return 6;
                if (temp == 527)
                    return 7;
                if (temp == 529)
                    return 8;
                if (temp == 531)
                    return 9;

                if (temp == 44)
                    return 9;
                if (temp == 46)
                    return 8;
                if (temp == 48)
                    return 7;
                if (temp == 410)
                    return 6;
                if (temp == 412)
                    return 5;
                if (temp == 414)
                    return 4;
                if (temp == 416)
                    return 4;
                if (temp == 418)
                    return 4;
                if (temp == 420)
                    return 4;
                if (temp == 422)
                    return 4;
                if (temp == 424)
                    return 5;
                if (temp == 426)
                    return 6;
                if (temp == 428)
                    return 7;
                if (temp == 430)
                    return 8;
                if (temp == 432)
                    return 9;

                if (temp == 33)
                    return 9;
                if (temp == 35)
                    return 8;
                if (temp == 37)
                    return 7;
                if (temp == 39)
                    return 6;
                if (temp == 311)
                    return 5;
                if (temp == 313)
                    return 4;
                if (temp == 315)
                    return 3;
                if (temp == 317)
                    return 3;
                if (temp == 319)
                    return 3;
                if (temp == 321)
                    return 3;
                if (temp == 323)
                    return 4;
                if (temp == 325)
                    return 5;
                if (temp == 327)
                    return 6;
                if (temp == 329)
                    return 7;
                if (temp == 331)
                    return 8;
                if (temp == 333)
                    return 9;

                if (temp == 22)
                    return 8;
                if (temp == 24)
                    return 7;
                if (temp == 26)
                    return 6;
                if (temp == 28)
                    return 5;
                if (temp == 210)
                    return 4;
                if (temp == 212)
                    return 3;
                if (temp == 214)
                    return 2;
                if (temp == 216)
                    return 2;
                if (temp == 218)
                    return 2;
                if (temp == 220)
                    return 2;
                if (temp == 222)
                    return 3;
                if (temp == 224)
                    return 4;
                if (temp == 226)
                    return 5;
                if (temp == 228)
                    return 6;
                if (temp == 230)
                    return 7;
                if (temp == 232)
                    return 8;
                if (temp == 234)
                    return 9;

                if (temp == 11)
                    return 9;
                if (temp == 13)
                    return 8;
                if (temp == 15)
                    return 7;
                if (temp == 17)
                    return 6;
                if (temp == 19)
                    return 5;
                if (temp == 111)
                    return 4;
                if (temp == 113)
                    return 3;
                if (temp == 115)
                    return 2;
                if (temp == 117)
                    return 1;
                if (temp == 119)
                    return 1;
                if (temp == 121)
                    return 2;
                if (temp == 123)
                    return 3;
                if (temp == 125)
                    return 4;
                if (temp == 127)
                    return 5;
                if (temp == 129)
                    return 6;
                if (temp == 131)
                    return 7;
                if (temp == 133)
                    return 8;
                if (temp == 135)
                    return 9;

                if (temp == 0)
                    return 9;
                if (temp == 2)
                    return 8;
                if (temp == 4)
                    return 7;
                if (temp == 6)
                    return 6;
                if (temp == 8)
                    return 5;
                if (temp == 10)
                    return 4;
                if (temp == 12)
                    return 3;
                if (temp == 14)
                    return 2;
                if (temp == 16)
                    return 1;
                if (temp == 18)
                    return 0;
                if (temp == 20)
                    return 1;
                if (temp == 22000)
                    return 2;
                if (temp == 24000)
                    return 3;
                if (temp == 26000)
                    return 4;
                if (temp == 28000)
                    return 5;
                if (temp == 30)
                    return 6;
                if (temp == 32)
                    return 7;
                if (temp == 34)
                    return 8;
                if (temp == 36)
                    return 9;
            }
            else if (activeRing == 8)
            {
                if (temp == 88)
                    return 8;
                if (temp == 810)
                    return 8;
                if (temp == 812)
                    return 8;
                if (temp == 814)
                    return 8;
                if (temp == 816)
                    return 8;
                if (temp == 818)
                    return 8;
                if (temp == 820)
                    return 8;
                if (temp == 822)
                    return 8;
                if (temp == 824)
                    return 8;
                if (temp == 826)
                    return 8;

                if (temp == 77)
                    return 8;
                if (temp == 79)
                    return 7;
                if (temp == 711)
                    return 7;
                if (temp == 713)
                    return 7;
                if (temp == 715)
                    return 7;
                if (temp == 717)
                    return 7;
                if (temp == 719)
                    return 7;
                if (temp == 721)
                    return 7;
                if (temp == 723)
                    return 7;
                if (temp == 725)
                    return 8;

                if (temp == 66)
                    return 8;
                if (temp == 68)
                    return 7;
                if (temp == 610)
                    return 6;
                if (temp == 612)
                    return 6;
                if (temp == 614)
                    return 6;
                if (temp == 616)
                    return 6;
                if (temp == 618)
                    return 6;
                if (temp == 620)
                    return 6;
                if (temp == 622)
                    return 6;
                if (temp == 624)
                    return 7;
                if (temp == 626)
                    return 8;

                if (temp == 55)
                    return 8;
                if (temp == 57)
                    return 7;
                if (temp == 59)
                    return 6;
                if (temp == 511)
                    return 5;
                if (temp == 513)
                    return 5;
                if (temp == 515)
                    return 5;
                if (temp == 517)
                    return 5;
                if (temp == 519)
                    return 5;
                if (temp == 521)
                    return 5;
                if (temp == 523)
                    return 6;
                if (temp == 525)
                    return 7;
                if (temp == 527)
                    return 8;

                if (temp == 44)
                    return 8;
                if (temp == 46)
                    return 7;
                if (temp == 48)
                    return 6;
                if (temp == 410)
                    return 5;
                if (temp == 412)
                    return 4;
                if (temp == 414)
                    return 4;
                if (temp == 416)
                    return 4;
                if (temp == 418)
                    return 4;
                if (temp == 420)
                    return 4;
                if (temp == 422)
                    return 5;
                if (temp == 424)
                    return 6;
                if (temp == 426)
                    return 7;
                if (temp == 428)
                    return 8;

                if (temp == 33)
                    return 8;
                if (temp == 35)
                    return 7;
                if (temp == 37)
                    return 6;
                if (temp == 39)
                    return 5;
                if (temp == 311)
                    return 4;
                if (temp == 313)
                    return 3;
                if (temp == 315)
                    return 3;
                if (temp == 317)
                    return 3;
                if (temp == 319)
                    return 3;
                if (temp == 321)
                    return 4;
                if (temp == 323)
                    return 5;
                if (temp == 325)
                    return 6;
                if (temp == 327)
                    return 7;
                if (temp == 329)
                    return 8;

                if (temp == 22)
                    return 8;
                if (temp == 24)
                    return 7;
                if (temp == 26)
                    return 6;
                if (temp == 28)
                    return 5;
                if (temp == 210)
                    return 4;
                if (temp == 212)
                    return 3;
                if (temp == 214)
                    return 2;
                if (temp == 216)
                    return 2;
                if (temp == 218)
                    return 2;
                if (temp == 220)
                    return 3;
                if (temp == 222)
                    return 4;
                if (temp == 224)
                    return 5;
                if (temp == 226)
                    return 6;
                if (temp == 228)
                    return 7;
                if (temp == 230)
                    return 8;

                if (temp == 11)
                    return 8;
                if (temp == 13)
                    return 7;
                if (temp == 15)
                    return 6;
                if (temp == 17)
                    return 5;
                if (temp == 19)
                    return 4;
                if (temp == 111)
                    return 3;
                if (temp == 113)
                    return 2;
                if (temp == 115)
                    return 1;
                if (temp == 117)
                    return 1;
                if (temp == 119)
                    return 2;
                if (temp == 121)
                    return 3;
                if (temp == 123)
                    return 4;
                if (temp == 125)
                    return 5;
                if (temp == 127)
                    return 6;
                if (temp == 129)
                    return 7;
                if (temp == 131)
                    return 8;

                if (temp == 0)
                    return 8;
                if (temp == 2)
                    return 7;
                if (temp == 4)
                    return 6;
                if (temp == 6)
                    return 5;
                if (temp == 8)
                    return 4;
                if (temp == 10)
                    return 3;
                if (temp == 12)
                    return 2;
                if (temp == 14)
                    return 1;
                if (temp == 16)
                    return 0;
                if (temp == 18)
                    return 1;
                if (temp == 20)
                    return 2;
                if (temp == 22000)
                    return 3;
                if (temp == 24000)
                    return 4;
                if (temp == 26000)
                    return 5;
                if (temp == 28000)
                    return 6;
                if (temp == 30)
                    return 7;
                if (temp == 32)
                    return 8;
            }
            else if (activeRing == 7)
            {
                if (temp == 77)
                    return 7;
                if (temp == 79)
                    return 7;
                if (temp == 711)
                    return 7;
                if (temp == 713)
                    return 7;
                if (temp == 715)
                    return 7;
                if (temp == 717)
                    return 7;
                if (temp == 719)
                    return 7;
                if (temp == 721)
                    return 7;

                if (temp == 66)
                    return 7;
                if (temp == 68)
                    return 6;
                if (temp == 610)
                    return 6;
                if (temp == 612)
                    return 6;
                if (temp == 614)
                    return 6;
                if (temp == 616)
                    return 6;
                if (temp == 618)
                    return 6;
                if (temp == 620)
                    return 6;
                if (temp == 622)
                    return 7;

                if (temp == 55)
                    return 7;
                if (temp == 57)
                    return 6;
                if (temp == 59)
                    return 5;
                if (temp == 511)
                    return 5;
                if (temp == 513)
                    return 5;
                if (temp == 515)
                    return 5;
                if (temp == 517)
                    return 5;
                if (temp == 519)
                    return 5;
                if (temp == 521)
                    return 6;
                if (temp == 523)
                    return 7;

                if (temp == 44)
                    return 7;
                if (temp == 46)
                    return 6;
                if (temp == 48)
                    return 5;
                if (temp == 410)
                    return 4;
                if (temp == 412)
                    return 4;
                if (temp == 414)
                    return 4;
                if (temp == 416)
                    return 4;
                if (temp == 418)
                    return 4;
                if (temp == 420)
                    return 5;
                if (temp == 422)
                    return 6;
                if (temp == 424)
                    return 7;

                if (temp == 33)
                    return 7;
                if (temp == 35)
                    return 6;
                if (temp == 37)
                    return 5;
                if (temp == 39)
                    return 4;
                if (temp == 311)
                    return 3;
                if (temp == 313)
                    return 3;
                if (temp == 315)
                    return 3;
                if (temp == 317)
                    return 3;
                if (temp == 319)
                    return 4;
                if (temp == 321)
                    return 5;
                if (temp == 323)
                    return 6;
                if (temp == 325)
                    return 7;

                if (temp == 22)
                    return 7;
                if (temp == 24)
                    return 6;
                if (temp == 26)
                    return 5;
                if (temp == 28)
                    return 4;
                if (temp == 210)
                    return 3;
                if (temp == 212)
                    return 2;
                if (temp == 214)
                    return 2;
                if (temp == 216)
                    return 2;
                if (temp == 218)
                    return 3;
                if (temp == 220)
                    return 4;
                if (temp == 222)
                    return 5;
                if (temp == 224)
                    return 6;
                if (temp == 226)
                    return 7;

                if (temp == 11)
                    return 7;
                if (temp == 13)
                    return 6;
                if (temp == 15)
                    return 5;
                if (temp == 17)
                    return 4;
                if (temp == 19)
                    return 3;
                if (temp == 111)
                    return 2;
                if (temp == 113)
                    return 1;
                if (temp == 115)
                    return 1;
                if (temp == 117)
                    return 2;
                if (temp == 119)
                    return 3;
                if (temp == 121)
                    return 4;
                if (temp == 123)
                    return 5;
                if (temp == 125)
                    return 6;
                if (temp == 127)
                    return 7;

                if (temp == 0)
                    return 7;
                if (temp == 2)
                    return 6;
                if (temp == 4)
                    return 5;
                if (temp == 6)
                    return 4;
                if (temp == 8)
                    return 3;
                if (temp == 10)
                    return 2;
                if (temp == 12)
                    return 1;
                if (temp == 14)
                    return 0;
                if (temp == 16)
                    return 1;
                if (temp == 18)
                    return 2;
                if (temp == 20)
                    return 3;
                if (temp == 22000)
                    return 4;
                if (temp == 24000)
                    return 5;
                if (temp == 26000)
                    return 6;
                if (temp == 28000)
                    return 7;
            }
            else if (activeRing == 6)//warning using larger systems requires extra variables to keep everything clean, there is 2 22s in 6 without modification that led to problems in testing since changed the name of conflicting variable in generation
            {
                if (temp == 66)
                    return 6;
                if (temp == 68)
                    return 6;
                if (temp == 610)
                    return 6;
                if (temp == 612)
                    return 6;
                if (temp == 614)
                    return 6;
                if (temp == 616)
                    return 6;
                if (temp == 618)
                    return 6;

                if (temp == 55)
                    return 6;
                if (temp == 57)
                    return 5;
                if (temp == 59)
                    return 5;
                if (temp == 511)
                    return 5;
                if (temp == 513)
                    return 5;
                if (temp == 515)
                    return 5;
                if (temp == 517)
                    return 5;
                if (temp == 519)
                    return 6;

                if (temp == 44)
                    return 6;
                if (temp == 46)
                    return 5;
                if (temp == 48)
                    return 4;
                if (temp == 410)
                    return 4;
                if (temp == 412)
                    return 4;
                if (temp == 414)
                    return 4;
                if (temp == 416)
                    return 4;
                if (temp == 418)
                    return 5;
                if (temp == 420)
                    return 6;

                if (temp == 33)
                    return 6;
                if (temp == 35)
                    return 5;
                if (temp == 37)
                    return 4;
                if (temp == 39)
                    return 3;
                if (temp == 311)
                    return 3;
                if (temp == 313)
                    return 3;
                if (temp == 315)
                    return 3;
                if (temp == 317)
                    return 4;
                if (temp == 319)
                    return 5;
                if (temp == 321)
                    return 6;

                if (temp == 22)
                    return 6;
                if (temp == 24)
                    return 5;
                if (temp == 26)
                    return 4;
                if (temp == 28)
                    return 3;
                if (temp == 210)
                    return 2;
                if (temp == 212)
                    return 2;
                if (temp == 214)
                    return 2;
                if (temp == 216)
                    return 3;
                if (temp == 218)
                    return 4;
                if (temp == 220)
                    return 5;
                if (temp == 222)
                    return 6;

                if (temp == 11)
                    return 6;
                if (temp == 13)
                    return 5;
                if (temp == 15)
                    return 4;
                if (temp == 17)
                    return 3;
                if (temp == 19)
                    return 2;
                if (temp == 111)
                    return 1;
                if (temp == 113)
                    return 1;
                if (temp == 115)
                    return 2;
                if (temp == 117)
                    return 3;
                if (temp == 119)
                    return 4;
                if (temp == 121)
                    return 5;
                if (temp == 123)
                    return 6;

                if (temp == 0)
                    return 6;
                if (temp == 2)
                    return 5;
                if (temp == 4)
                    return 4;
                if (temp == 6)
                    return 3;
                if (temp == 8)
                    return 2;
                if (temp == 10)
                    return 1;
                if (temp == 12)
                    return 0;
                if (temp == 14)
                    return 1;
                if (temp == 16)
                    return 2;
                if (temp == 18)
                    return 3;
                if (temp == 20)
                    return 4;
                if (temp == 22000)
                    return 5;
                if (temp == 24000)
                    return 6;
            }
            else if (activeRing == 5)
            {
                if (temp == 55)
                    return 5;
                if (temp == 57)
                    return 5;
                if (temp == 59)
                    return 5;
                if (temp == 511)
                    return 5;
                if (temp == 513)
                    return 5;
                if (temp == 515)
                    return 5;

                if (temp == 44)
                    return 5;
                if (temp == 46)
                    return 4;
                if (temp == 48)
                    return 4;
                if (temp == 410)
                    return 4;
                if (temp == 412)
                    return 4;
                if (temp == 414)
                    return 4;
                if (temp == 416)
                    return 5;

                if (temp == 33)
                    return 5;
                if (temp == 35)
                    return 4;
                if (temp == 37)
                    return 3;
                if (temp == 39)
                    return 3;
                if (temp == 311)
                    return 3;
                if (temp == 313)
                    return 3;
                if (temp == 315)
                    return 4;
                if (temp == 317)
                    return 5;

                if (temp == 22)
                    return 5;
                if (temp == 24)
                    return 4;
                if (temp == 26)
                    return 3;
                if (temp == 28)
                    return 2;
                if (temp == 210)
                    return 2;
                if (temp == 212)
                    return 2;
                if (temp == 214)
                    return 3;
                if (temp == 216)
                    return 4;
                if (temp == 218)
                    return 5;

                if (temp == 11)
                    return 5;
                if (temp == 13)
                    return 4;
                if (temp == 15)
                    return 3;
                if (temp == 17)
                    return 2;
                if (temp == 19)
                    return 1;
                if (temp == 111)
                    return 1;
                if (temp == 113)
                    return 2;
                if (temp == 115)
                    return 3;
                if (temp == 117)
                    return 4;
                if (temp == 119)
                    return 5;

                if (temp == 0)
                    return 5;
                if (temp == 2)
                    return 4;
                if (temp == 4)
                    return 3;
                if (temp == 6)
                    return 2;
                if (temp == 8)
                    return 1;
                if (temp == 10)
                    return 0;
                if (temp == 12)
                    return 1;
                if (temp == 14)
                    return 2;
                if (temp == 16)
                    return 3;
                if (temp == 18)
                    return 4;
                if (temp == 20)
                    return 5;
            }
            else if (activeRing == 4)
            {
                if (temp == 44)
                    return 4;
                if (temp == 46)
                    return 4;
                if (temp == 48)
                    return 4;
                if (temp == 410)
                    return 4;
                if (temp == 412)
                    return 4;

                if (temp == 33)
                    return 4;
                if (temp == 35)
                    return 3;
                if (temp == 37)
                    return 3;
                if (temp == 39)
                    return 3;
                if (temp == 311)
                    return 3;
                if (temp == 313)
                    return 4;

                if (temp == 22)
                    return 4;
                if (temp == 24)
                    return 3;
                if (temp == 26)
                    return 2;
                if (temp == 28)
                    return 2;
                if (temp == 210)
                    return 2;
                if (temp == 212)
                    return 3;
                if (temp == 214)
                    return 4;

                if (temp == 11)
                    return 4;
                if (temp == 13)
                    return 3;
                if (temp == 15)
                    return 2;
                if (temp == 17)
                    return 1;
                if (temp == 19)
                    return 1;
                if (temp == 111)
                    return 2;
                if (temp == 113)
                    return 3;
                if (temp == 115)
                    return 4;

                if (temp == 0)
                    return 4;
                if (temp == 2)
                    return 3;
                if (temp == 4)
                    return 2;
                if (temp == 6)
                    return 1;
                if (temp == 8)
                    return 0;
                if (temp == 10)
                    return 1;
                if (temp == 12)
                    return 2;
                if (temp == 14)
                    return 3;
                if (temp == 16)
                    return 4;
            }
            else if (activeRing == 3)
            {
                if (temp == 33)
                    return 3;
                if (temp == 35)
                    return 3;
                if (temp == 37)
                    return 3;
                if (temp == 39)
                    return 3;

                if (temp == 22)
                    return 3;
                if (temp == 24)
                    return 2;
                if (temp == 26)
                    return 2;
                if (temp == 28)
                    return 2;
                if (temp == 210)
                    return 3;

                if (temp == 11)
                    return 3;
                if (temp == 13)
                    return 2;
                if (temp == 15)
                    return 1;
                if (temp == 17)
                    return 1;
                if (temp == 19)
                    return 2;
                if (temp == 111)
                    return 3;

                if (temp == 0)
                    return 3;
                if (temp == 2)
                    return 2;
                if (temp == 4)
                    return 1;
                if (temp == 6)
                    return 0;
                if (temp == 8)
                    return 1;
                if (temp == 10)
                    return 2;
                if (temp == 12)
                    return 3;
            }
            else if (activeRing == 2)
            {
                if (temp == 22)
                    return 2;
                if (temp == 24)
                    return 2;
                if (temp == 26)
                    return 2;

                if (temp == 11)
                    return 2;
                if (temp == 13)
                    return 1;
                if (temp == 15)
                    return 1;
                if (temp == 17)
                    return 2;

                if (temp == 0)
                    return 2;
                if (temp == 2)
                    return 1;
                if (temp == 4)
                    return 0;
                if (temp == 6)
                    return 1;
                if (temp == 8)
                    return 2;
            }
            else if (activeRing == 1)
            {
                if (temp == 11)
                    return 1;
                if (temp == 13)
                    return 1;
                if (temp == 0)
                    return 1;
                if (temp == 2)
                    return 0;
                if (temp == 4)
                    return 1;
            }
        }
        return 0;
    }
}
