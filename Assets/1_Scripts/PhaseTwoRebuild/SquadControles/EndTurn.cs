using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurn : MonoBehaviour
{
    // Start is called before the first frame update
    private int SquadActionPotential;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int temp = 0;
        SquadActionPotential = 0;
        for (int i = 0; i < BetweenPhaseData.Survivors.Length; i++)
        {
            if (BetweenPhaseData.Survivors[i].Name.Equals(gameObject.GetComponent<ChangeSelectedMember>().ActiveSurvivor.Name))
            {
                temp++;
                if (BetweenPhaseData.Survivors[i].ActionPoints >= 0)
                {
                    SquadActionPotential += BetweenPhaseData.Survivors[i].ActionPoints;
                }
            }
        }

        if(Input.GetKeyDown(KeyCode.Escape)||SquadActionPotential == 0)
        {
            //end this players squads turn and begin the enemy movement
        }
    }
}
