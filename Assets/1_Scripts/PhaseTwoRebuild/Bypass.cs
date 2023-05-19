using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Bypass : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CharacterName1;
    public GameObject CharacterName2;
    public GameObject CharacterName3;
    public GameObject CharacterName4;
    public GameObject CharacterName5;
    public GameObject CharacterName6;
    private bool reset = true;
    //public GameObject humanModelConcealed;
    //GameObject ActiveHuman;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.A))
        //{
        //    GetComponent<TransparancyScript>().CutCutControle(supermarket.transform.GetChild(0).gameObject);
        //    GetComponent<TransparancyScript>().CutCutControle(supermarket.transform.GetChild(1).gameObject);
        //    GetComponent<TransparancyScript>().CutCutControle(supermarket.transform.GetChild(2).gameObject);
        //    GetComponent<TransparancyScript>().CutCutControle(supermarket.transform.GetChild(3).gameObject);
        //    GetComponent<TransparancyScript>().CutCutControle(supermarket.transform.GetChild(4).gameObject);
        //    GetComponent<TransparancyScript>().CutCutControle(supermarket.transform.GetChild(5).gameObject);
        //
        //    //humanModel.SetActive(!humanModel.activeInHierarchy);
        //    //humanModelConcealed.SetActive(!humanModelConcealed.activeInHierarchy);
        //}
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            CharacterName1.GetComponent<FollowOther>().enabled = true;
            CharacterName2.GetComponent<FollowOther>().enabled = true;
            CharacterName3.GetComponent<FollowOther>().enabled = true;
            CharacterName4.GetComponent<FollowOther>().enabled = true;
            CharacterName5.GetComponent<FollowOther>().enabled = true;
            CharacterName6.GetComponent<FollowOther>().enabled = true;
        }
        if(reset)
        {
            CharacterName1.GetComponent<FollowOther>().enabled = true;
            CharacterName2.GetComponent<FollowOther>().enabled = true;
            CharacterName3.GetComponent<FollowOther>().enabled = true;
            CharacterName4.GetComponent<FollowOther>().enabled = true;
            CharacterName5.GetComponent<FollowOther>().enabled = true;
            CharacterName6.GetComponent<FollowOther>().enabled = true;
            reset = false;
        }
        //cam.GetComponent<Camera>().orthographicSize = cam.GetComponent<Camera>().orthographicSize + (Input.mouseScrollDelta.y * -1); //zoom
        //camera should also rotate and pann away from the currently selected character

        if (Input.GetKeyDown(KeyCode.LeftShift)) //reset action points
        {
            //ActiveHuman.GetComponent<HexRangeMaker>().movementRange = 13;
        }

        if(Input.GetKeyDown(KeyCode.Space)) // automatically shoot the other character
        {
            //attack with selected weapon

            //extreamly Low odds every time
            //{
            //weapon ranged
            //Did you hit
            //Shot Accuracy: (Skill * 3%) + 20% + Status Effects  - Range Penalty = Percent Chance to Hit
            //float rootOdds = (ActiveHuman.transform.parent.transform.parent.GetComponent<HumanStatScript>().Skill * 1.03f);
            //float statusVariance = (rootOdds * 1.2f) + 0/*StatusEffect*/;
            //int r = ActiveHuman.transform.parent.GetComponent<HumanStatScript>().weaponRange;
            //int r2 = GetComponent<RangeDetection>().Range;
            //float rangeCalculation = 0;
            //if (r2>r)
            //{
            //    rangeCalculation = 100 / ((r2 - r) * 100)/* range penalty for every unit over range / 50%*/;
            //}
            //float rangeLoss = statusVariance - rangeCalculation;
            //float hitMiss = Random.Range(0, 100);
            ////if so damage done
            ////Shot Damage: Weapon Damage +Perks - Range Penalty = Damage 
            //if (hitMiss >= (rangeLoss * 100))
            //{
            //    float damageOut = ActiveHuman.transform.parent.GetComponent<HumanStatScript>().weaponDamage + 0 /*Perk variance*/ - rangeCalculation;
            //    ActiveHuman.transform.parent.GetComponent<HumanStatScript>().HitYesNo("HIT!");
            //}
            //else
            //{
            //    ActiveHuman.transform.parent.GetComponent<HumanStatScript>().HitYesNo("Miss");
            //}
            //}
            //50% test
            //float hitMiss = Random.Range(0, 100);
            //if (hitMiss >= 50)
            //{
            //    ActiveHuman.transform.parent.GetComponent<HumanStatScript>().HitYesNo("KILL!");
            //}
            //else
            //{
            //    ActiveHuman.transform.parent.GetComponent<HumanStatScript>().HitYesNo("Miss");
            //}
            //weapon melee
            //Did you hit
            //if so damage done
        }
        if (Input.GetKeyDown(KeyCode.Tab)) // switch controle of the character
        {
            //SwitchHuman = !SwitchHuman;
            //if(SwitchHuman)
            //{
            //    human.SetActive(true);
            //    humanLocationSelector.SetActive(true);
            //    ActiveHuman = human;
            //    human2.SetActive(false);
            //    human2LocationSelector.SetActive(false);
            //}
            //else if (!SwitchHuman)
            //{
            //    human2.SetActive(true);
            //    human2LocationSelector.SetActive(true);
            //    ActiveHuman = human2;
            //    human.SetActive(false);
            //    humanLocationSelector.SetActive(false);
            //}
        }
        //camera Switch
        //if(Input.GetKeyDown(KeyCode.Q))
        //{
        //    camPos--;
        //    if (camPos < 0)
        //    {
        //        camPos = 3;
        //    }
        //}
        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    camPos++;
        //    if(camPos > 3)
        //    {
        //        camPos = 0;
        //    }
        //}
        //cameraAlignment();
    }
    //void cameraAlignment()
    //{
    //    if (SwitchHuman)
    //    {
    //        if (camPos == 0)
    //        {
    //            MoveWith = camPos1;
    //        }
    //        else if (camPos == 1)
    //        {
    //            MoveWith = camPos1B;
    //        }
    //        else if (camPos == 2)
    //        {
    //            MoveWith = camPos1L;
    //        }
    //        else if (camPos == 3)
    //        {
    //            MoveWith = camPos1T;
    //        }
    //    }
    //    else
    //    {
    //        if (camPos == 0)
    //        {
    //            MoveWith = camPos2;
    //        }
    //        else if (camPos == 1)
    //        {
    //            MoveWith = camPos2B;
    //        }
    //        else if (camPos == 2)
    //        {
    //            MoveWith = camPos2L;
    //        }
    //        else if (camPos == 3)
    //        {
    //            MoveWith = camPos2T;
    //        }
    //    }
    //    if (cam.GetComponent<Camera>().orthographicSize < 2)
    //    {
    //        cam.GetComponent<Camera>().orthographicSize = 2;
    //    }
    //    if (cam.GetComponent<Camera>().orthographicSize > 10)
    //    {
    //        cam.GetComponent<Camera>().orthographicSize = 10;
    //    }
    //    cam.transform.position = MoveWith.position;
    //    cam.transform.rotation = MoveWith.rotation;
    //}
}
