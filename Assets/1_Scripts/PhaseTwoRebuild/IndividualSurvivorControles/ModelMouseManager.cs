using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ModelMouseManager : MonoBehaviour
{
    // Start is called before the first frame update
    [HideInInspector] public string target = "";
    [HideInInspector] public RaycastHit hitInfo;
    [SerializeField] private GameObject Model;
    [SerializeField] private GameObject LocationSelection;
    public GameObject MoveTo;
    [SerializeField] private GameObject cam;
    [HideInInspector] public bool attacking;
    [HideInInspector] public bool running;
    [HideInInspector] public bool idle;
    [HideInInspector] public bool Awesomeness = false;
    [SerializeField] private GameObject muzelflash;
    [SerializeField] private GameObject explosion;
    [SerializeField] private GameObject firePref;
    public float currentOdds;
    void Start()
    {
        cam = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        ChangeSelectedMember who = GameObject.Find("GameControler").GetComponent<ChangeSelectedMember>();
        SetEnemyListButtons opp = GameObject.Find("GameControler").GetComponent<SetEnemyListButtons>();
        SetActionButtions wep = GameObject.Find("GameControler").GetComponent<SetActionButtions>();

        if (Input.GetKeyDown(KeyCode.P)){Awesomeness = !Awesomeness;}
    
        if (!MouseOverUI())
        {
            #region Camera Control
            //-------------------Cam Zoom--------------------------------------------
            //cam.GetComponent<Camera>().orthographicSize = cam.GetComponent<Camera>().orthographicSize + (Input.mouseScrollDelta.y * -1);
            cam.GetComponent<Camera>().fieldOfView = cam.GetComponent<Camera>().fieldOfView + (Input.mouseScrollDelta.y * -1);
            //if (cam.GetComponent<Camera>().orthographicSize > 50)
            //{
            //    cam.GetComponent<Camera>().orthographicSize = 50;
            //}
            //if(cam.GetComponent<Camera>().orthographicSize < 10)
            //{
            //    cam.GetComponent<Camera>().orthographicSize = 10;
            //}
            if (cam.GetComponent<Camera>().fieldOfView > 25)
            {
                cam.GetComponent<Camera>().fieldOfView = 25;
            }
            if (cam.GetComponent<Camera>().fieldOfView < 4)
            {
                cam.GetComponent<Camera>().fieldOfView = 4;
            }
            //-----------------------------------------------------------------------
            #endregion
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            target = "";
            if (Physics.Raycast(ray, out hitInfo))
            {
                Debug.Log(hitInfo.collider.transform.parent.name);
                target = hitInfo.collider.transform.parent.name;
                if (CheckLocation(target))//vital it only goes after the imovable locations to if you still want to show targets
                {
                    LocationSelection.SetActive(true);
                    Vector3 newpos = new Vector3(GameObject.Find(target).transform.position.x, GameObject.Find(target).transform.position.y + .71f, GameObject.Find(target).transform.position.z);
                    LocationSelection.transform.position = newpos;
                }
                else
                {
                    LocationSelection.SetActive(false);
                }
                if (Input.GetMouseButtonDown(1))
                {
                    #region Gunslinger Modifier
                    if (gameObject.transform.parent.transform.GetChild(0).GetComponent<ModelHexManager>().movementRange - 1 > 0 && who.ActiveSurvivor.ActivePerks[18].active && (who.SurvivorWeapon().Equals("Revolver") || who.SurvivorWeapon().Equals("9mm")))
                    {
                        attacking = true;
                        running = false;
                        GetComponent<ModelHexManager>().movementRange -= 1;
                        transform.parent.gameObject.transform.GetChild(1).gameObject.transform.LookAt(opp.enemySelectedPosition.transform.position);
                        if (!who.SurvivorWeapon().Equals("Pipe Bomb") && !who.SurvivorWeapon().Equals("Molotov") && !who.SurvivorWeapon().Equals("Flash Bang") && !who.SurvivorWeapon().Equals("Granade"))
                        {
                            muzelflash.SetActive(true);
                            if (TargetHit())
                            {
                                opp.enemySelected.gameObject.GetComponent<InfectedAI>().LocalInfected.Health -= DamageOut();
                            }
                        }
                        else if (who.SurvivorWeapon().Equals("Pipe Bomb") || who.SurvivorWeapon().Equals("Granade"))
                        {
                            explosion.SetActive(true);
                            GetComponent<ModelHexManager>().movementRange -= 1;
                            explosion.transform.position = LocationSelection.transform.position;
                            if (!wep.utility1.interactable)
                            {
                                who.survivorlist[who.unitValue].Utility1._None();
                            }
                            if (!wep.utility2.interactable)
                            {
                                who.survivorlist[who.unitValue].Utility2._None();
                            }
                            if (!wep.utility3.interactable)
                            {
                                who.survivorlist[who.unitValue].Utility3._None();
                            }
                            foreach (GameObject n in opp.enemysAvailable)
                            {
                                if (Vector3.Distance(n.transform.position, explosion.transform.position) < 43.05f)//7*6.15
                                {
                                    n.gameObject.GetComponent<InfectedAI>().LocalInfected.Health -= 50;
                                }
                            }
                        }
                        else if (who.SurvivorWeapon().Equals("Molotov"))
                        {
                            Instantiate(firePref, LocationSelection.transform.position, Quaternion.identity);
                            GetComponent<ModelHexManager>().movementRange -= 1;
                            if (!wep.utility1.interactable)
                            {
                                who.survivorlist[who.unitValue].Utility1._None();
                            }
                            if (!wep.utility2.interactable)
                            {
                                who.survivorlist[who.unitValue].Utility2._None();
                            }
                            if (!wep.utility3.interactable)
                            {
                                who.survivorlist[who.unitValue].Utility3._None();
                            }
                            foreach (GameObject n in opp.enemysAvailable)
                            {
                                if (Vector3.Distance(n.transform.position, explosion.transform.position) < 53.35f)//9*6.15
                                {
                                    n.gameObject.GetComponent<InfectedAI>().LocalInfected.Health -= 20;
                                }
                            }
                        }
                    }
                    #endregion
                    #region Normal Attack
                    else if (gameObject.transform.parent.transform.GetChild(0).GetComponent<ModelHexManager>().movementRange - 2 > 0)
                    {
                        attacking = true;
                        running = false;
                        GetComponent<ModelHexManager>().movementRange -= 2;
                        transform.parent.gameObject.transform.GetChild(1).gameObject.transform.LookAt(opp.enemySelectedPosition.transform.position);
                        if (!who.SurvivorWeapon().Equals("Pipe Bomb") && !who.SurvivorWeapon().Equals("Molotov") && !who.SurvivorWeapon().Equals("Flash Bang") && !who.SurvivorWeapon().Equals("Granade") && !who.SurvivorWeapon().Equals("Bandage") && !who.SurvivorWeapon().Equals("Medkit") && !who.SurvivorWeapon().Equals("Trauma Bag"))
                        {
                            muzelflash.SetActive(true);
                            if (TargetHit())
                            {
                                opp.enemySelected.gameObject.GetComponent<InfectedAI>().LocalInfected.Health -= DamageOut();
                            }
                        }
                        else if(who.SurvivorWeapon().Equals("Bandage"))
                        {
                            if (!wep.utility1.interactable)
                            {
                                who.survivorlist[who.unitValue].Utility1._None();
                            }
                            if (!wep.utility2.interactable)
                            {
                                who.survivorlist[who.unitValue].Utility2._None();
                            }
                            if (!wep.utility3.interactable)
                            {
                                who.survivorlist[who.unitValue].Utility3._None();
                            }
                            who.ActiveSurvivor.ChangeHealth(false, 10);
                        }
                        else if (who.SurvivorWeapon().Equals("Medkit"))
                        {
                            if (!wep.utility1.interactable)
                            {
                                who.survivorlist[who.unitValue].Utility1._None();
                            }
                            if (!wep.utility2.interactable)
                            {
                                who.survivorlist[who.unitValue].Utility2._None();
                            }
                            if (!wep.utility3.interactable)
                            {
                                who.survivorlist[who.unitValue].Utility3._None();
                            }
                            who.ActiveSurvivor.ChangeHealth(false, 50);
                        }
                        else if (who.SurvivorWeapon().Equals("Trauma Bag"))
                        {
                            if (!wep.utility1.interactable)
                            {
                                who.survivorlist[who.unitValue].Utility1._None();
                            }
                            if (!wep.utility2.interactable)
                            {
                                who.survivorlist[who.unitValue].Utility2._None();
                            }
                            if (!wep.utility3.interactable)
                            {
                                who.survivorlist[who.unitValue].Utility3._None();
                            }
                            who.ActiveSurvivor.ChangeHealth(false, 100);
                        }
                        else if (who.SurvivorWeapon().Equals("Pipe Bomb") || who.SurvivorWeapon().Equals("Granade"))
                        {
                            explosion.SetActive(true);
                            explosion.transform.position = LocationSelection.transform.position;
                            if (!wep.utility1.interactable)
                            {
                                who.survivorlist[who.unitValue].Utility1._None();
                            }
                            if (!wep.utility2.interactable)
                            {
                                who.survivorlist[who.unitValue].Utility2._None();
                            }
                            if (!wep.utility3.interactable)
                            {
                                who.survivorlist[who.unitValue].Utility3._None();
                            }
                            foreach(GameObject n in opp.enemysAvailable)
                            {
                                if(Vector3.Distance(n.transform.position, explosion.transform.position) < 43.05f)//7*6.15
                                {
                                    n.gameObject.GetComponent<InfectedAI>().LocalInfected.Health -= 50;
                                }
                            }
                        }
                        else if (who.SurvivorWeapon().Equals("Molotov"))
                        {
                            Instantiate(firePref, LocationSelection.transform.position, Quaternion.identity);
                            if (!wep.utility1.interactable)
                            {
                                who.survivorlist[who.unitValue].Utility1._None();
                            }
                            if (!wep.utility2.interactable)
                            {
                                who.survivorlist[who.unitValue].Utility2._None();
                            }
                            if (!wep.utility3.interactable)
                            {
                                who.survivorlist[who.unitValue].Utility3._None();
                            }
                            foreach (GameObject n in opp.enemysAvailable)
                            {
                                if (Vector3.Distance(n.transform.position, explosion.transform.position) < 53.35f)//9*6.15
                                {
                                    n.gameObject.GetComponent<InfectedAI>().LocalInfected.Health -= 20;
                                }
                            }
                        }
                    }
                    #endregion
                }
                if (Input.GetMouseButtonDown(0))
                {
                    if (CheckLocation(target))
                    {
                        running = true;
                        if (transform.position != MoveTo.transform.position)
                        {
                            MoveTo.transform.position = GameObject.Find(target).transform.position;
                            //this updated to a designated location and is bound by the hex manager
                            if (CheckLocation(target))
                            {
                                //GetComponent<ModelHexManager>().movementRange -= //(int)(Vector3.Distance(transform.position, LocationSelection.transform.position));
                                GetComponent<ModelHexManager>().movementRange -= GetComponent<ModelHexManager>().flipRange(GetComponent<ModelHexManager>().movementRange-1);
                            }
                        }
                    }
                }
            }
        }
        TargetHit();
    }
    public bool CheckLocation(string s)
    {
        string[] list = new string[7];
        list[0] = "FloorContainer";
        list[1] = "LocationSelection";
        list[2] = "Environment";
        list[3] = "Street";
        list[4] = "Building";
        list[5] = "RoadBlock";
        list[6] = "Barrier";
        for (int i = 0; i < list.Length; i++)
        {
            if (s.Equals(list[i]))
            {
                return false;
            }
        }
        //individual constraints can be set to via a location name and then set to ture or false if in a radius to the player
        //looks weird with a circle on a hex when clear but fog of war will make this look more natural
        //else if (s.Equals("Pos1"))
        //{
        //    if (Vector3.Distance(transform.position, LocationSelection.transform.position) > GetComponent<ModelHexManager>().movementRange - 1)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        //if (Input.GetMouseButtonDown(0))
        //        //{
        //        //    GetComponent<ModelHexManager>().movementRange -= (int)(Vector3.Distance(transform.position, LocationSelection.transform.position));
        //        //}
        //        return true;
        //    }
        //}
        if (LocationRangeCheck(s))
        {
            if (Vector3.Distance(transform.position, LocationSelection.transform.position) > GetComponent<ModelHexManager>().movementRange - 1)
            {
                return false;
            }
            else
            {
                //if (Input.GetMouseButtonDown(0))
                //{
                //    GetComponent<ModelHexManager>().movementRange -= (int)(Vector3.Distance(transform.position, LocationSelection.transform.position));
                //}
                return true;
            }
        }
        else if (s.Equals("Wall"))
        {
            return false;
        }
        return true;
    }
    public bool LocationRangeCheck(string s)
    {
        string[] sublist = new string[3];
        sublist[0] = "Pos1";
        sublist[1] = "Pos2";
        sublist[1] = "Cover";
        for (int i = 0; i < sublist.Length; i++)
        {
            if(s.Equals(sublist[i]))
            {
                return true;
            }
        }
        return false;
    }
    public int MoveToSetLocation(Vector3 positionTo)
    {
        return 0;
    }
    public bool MouseOverUI()
    {
        return EventSystem.current.IsPointerOverGameObject();
    }
    public bool TargetHit()
    {
        ChangeSelectedMember who = GameObject.Find("GameControler").GetComponent<ChangeSelectedMember>();
        SetEnemyListButtons opp = GameObject.Find("GameControler").GetComponent<SetEnemyListButtons>();
        SetActionButtions wep = GameObject.Find("GameControler").GetComponent<SetActionButtions>();
        //the plan is to break the targeting script into three parts that will increase the r closer to being equal to the max
        //you will always have a 10% chance with 0 for the skill no matter how far away or what weapon
        //part one is the weapon compairable stats that at most will equal up to 90% at level max of 30
        //part two is the status effects and variables. [currently inactive]
        //part three is the out of range decrament that if outside rand will decrament the total of part one and two by half
        int maxOdds = 101;
        currentOdds = 10;
        int skillFactor = 0;
        //if weapon one is selected 
        //if weapon two is selected
        //if the weapon is of a skill clasification then this if
        if (!wep.primary.interactable)
        {
            if (who.survivorlist[who.unitValue].Weapon1.AssignedTrait.Equals("BRAWN"))
            {
                skillFactor = who.survivorlist[who.unitValue].Brawn * 3;
            }
            //if the weapon is of a brawn clasification then this if
            if (who.survivorlist[who.unitValue].Weapon1.AssignedTrait.Equals("SKILL"))
            {
                skillFactor = who.survivorlist[who.unitValue].Skill * 3;
            }
        }
        if (!wep.secondary.interactable)
        {
            if (who.survivorlist[who.unitValue].Weapon2.AssignedTrait.Equals("BRAWN"))
            {
                skillFactor = who.survivorlist[who.unitValue].Brawn * 3;
            }
            //if the weapon is of a brawn clasification then this if
            if (who.survivorlist[who.unitValue].Weapon2.AssignedTrait.Equals("SKILL"))
            {
                skillFactor = who.survivorlist[who.unitValue].Skill * 3;
            }
        }
        currentOdds += skillFactor;
        //factor in status variables [currently inactive]
        //factor in weapon range
        //if weapon one is selected 
        //if weapon two is selected
        //to determine if the weapon is ranged i plan to check if the weapon has a range greater than 1 since all melee weapons are of 1
        int tempRange = 0;
        if (!wep.primary.interactable)
        {
            tempRange = who.survivorlist[who.unitValue].Weapon1.Range;
            if (who.ActiveSurvivor.ActivePerks[15].active && tempRange > 1 && (who.ActiveSurvivor.Weapon1.Name.Equals("AK 47") || who.ActiveSurvivor.Weapon1.Name.Equals("Bolt Action Rifle") || who.ActiveSurvivor.Weapon1.Name.Equals("M16")))
            {
                tempRange = 1000; //this should be farther than you will ever be able to detect.
            }
        }
        if (!wep.secondary.interactable)
        {
            tempRange = who.survivorlist[who.unitValue].Weapon2.Range;
            if (who.ActiveSurvivor.ActivePerks[15].active && tempRange > 1 && (who.ActiveSurvivor.Weapon2.Name.Equals("AK 47") || who.ActiveSurvivor.Weapon2.Name.Equals("Bolt Action Rifle") || who.ActiveSurvivor.Weapon2.Name.Equals("M16")))
            {
                tempRange = 1000; //this should be farther than you will ever be able to detect.
            }
        }
        float distance = Vector3.Distance(transform.position, opp.enemySelectedPosition.transform.position) /6.15f;//6.15 is a uniform range in the hex generator
        if(who.ActiveSurvivor.ActivePerks[4].active && tempRange > 1)
        {
            currentOdds *= .4f;
        }
        if (distance > tempRange)
        {
            currentOdds /= 2;
        }
        if (who.ActiveSurvivor.ActivePerks[5].active)
        {
            currentOdds *= 1.1f;
        }
        if (who.ActiveSurvivor.ActivePerks[6].active)
        {
            currentOdds *= .9f;
        }
        //check range
        int r = (int)Random.Range(1, maxOdds);
        if (currentOdds >= r)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public int DamageOut()
    {
        ChangeSelectedMember who = GameObject.Find("GameControler").GetComponent<ChangeSelectedMember>();
        SetActionButtions wep = GameObject.Find("GameControler").GetComponent<SetActionButtions>();
        int damage = 0;
        if (!wep.primary.interactable)
        {
            damage = (int)Random.Range(who.survivorlist[who.unitValue].Weapon1.DamageMin, who.survivorlist[who.unitValue].Weapon1.DamageMax + 1);
            if (who.ActiveSurvivor.ActivePerks[7].active && who.survivorlist[who.unitValue].Weapon1.Range == 1)
            {
                damage += 1;
            }
        }
        if (!wep.secondary.interactable)
        {
            damage = (int)Random.Range(who.survivorlist[who.unitValue].Weapon2.DamageMin, who.survivorlist[who.unitValue].Weapon2.DamageMax + 1);
            if (who.ActiveSurvivor.ActivePerks[7].active && who.survivorlist[who.unitValue].Weapon2.Range == 1)
            {
                damage += 1;
            }
        }
        return damage;
    }
}
