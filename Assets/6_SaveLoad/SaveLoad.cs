using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

//this file manages all data moving in and out of the files
public class SaveLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        save();
        //load();
    }
    public void load()
    {
        string path = Application.dataPath + "/6_SaveLoad//Log.txt";
        if (File.Exists(path))
        {
            // can use an array and loop for large amouts of save data
            FileInfo f = new FileInfo(path);
            StreamReader read = f.OpenText();

            string sIn = read.ReadLine();
            int val;
            int.TryParse(sIn, out val);
            //GameObject.Find("Player").GetComponent<PlayerStats>().scoreIn = val;
        }
        if (!File.Exists(path))
        {
            string s = "Info goes here \n";
            File.AppendAllText(path, s);
        }
    }
    public void save()
    {
        string path = Application.dataPath + "/6_SaveLoad//Log.txt";
        if (!File.Exists(path))
        {
            string s = "Info goes here \n";
            File.AppendAllText(path, s);
        }
        if (File.Exists(path))
        {
            File.WriteAllText(path, "");//this removes all saved data
            for (int i = 0; i < 20; i++)
            {
                string s = BetweenPhaseData.food + "\n";
                File.AppendAllText(path, s);
                s = BetweenPhaseData.fuel + "\n";
                File.AppendAllText(path, s);
                s = BetweenPhaseData.medical + "\n";
                File.AppendAllText(path, s);
                s = BetweenPhaseData.rawMaterial + "\n";
                File.AppendAllText(path, s);
                s = 20 + "\n";//this is the active survivor count for now im just going to give acess to all of them
                File.AppendAllText(path, s);
                s = BetweenPhaseData.Survivors[i].Name + "\n";
                File.AppendAllText(path, s);
                s = BetweenPhaseData.Survivors[i].Level + "\n";
                File.AppendAllText(path, s);
                s = BetweenPhaseData.Survivors[i].XP + "\n";
                File.AppendAllText(path, s);
                s = BetweenPhaseData.Survivors[i].Level + "\n";
                File.AppendAllText(path, s);
                s = BetweenPhaseData.Survivors[i].Health + "\n";
                File.AppendAllText(path, s);
                s = BetweenPhaseData.Survivors[i].ActionPoints + "\n";
                File.AppendAllText(path, s);
                s = BetweenPhaseData.Survivors[i].Body + "\n";
                File.AppendAllText(path, s);
                s = BetweenPhaseData.Survivors[i].Brawn + "\n";
                File.AppendAllText(path, s);
                s = BetweenPhaseData.Survivors[i].Skill + "\n";
                File.AppendAllText(path, s);
                s = BetweenPhaseData.Survivors[i].Senses + "\n";
                File.AppendAllText(path, s);
                s = BetweenPhaseData.Survivors[i].Intelligence + "\n";
                File.AppendAllText(path, s);
                s = BetweenPhaseData.Survivors[i].Influence + "\n";
                File.AppendAllText(path, s);
                s = BetweenPhaseData.Survivors[i].Weapon1.Name + "\n";
                File.AppendAllText(path, s);
                s = BetweenPhaseData.Survivors[i].Weapon2.Name + "\n";
                File.AppendAllText(path, s);
                s = BetweenPhaseData.Survivors[i].Utility1.Name + "\n";
                File.AppendAllText(path, s);
                s = BetweenPhaseData.Survivors[i].Utility2.Name + "\n";
                File.AppendAllText(path, s);
                s = BetweenPhaseData.Survivors[i].Utility3.Name + "\n";
                File.AppendAllText(path, s);
                s = BetweenPhaseData.Survivors[i].ArmorHead.Name + "\n";
                File.AppendAllText(path, s);
                s = BetweenPhaseData.Survivors[i].ArmorHand.Name + "\n";
                File.AppendAllText(path, s);
                //---------------------will need to loop later-------------
                for (int j = 0; j < 30; j++)
                {
                    s = BetweenPhaseData.Survivors[i].ActivePerks[j].Name + "\n";
                    File.AppendAllText(path, s);
                }
                for (int j = 0; j < 30; j++)
                {
                    s = BetweenPhaseData.Survivors[i].ActiveConditions[j].Name + "\n";
                    File.AppendAllText(path, s);
                }
                //---------------------------------------------------------
            }
            //-------------------Weapons-------------------------------
            for (int i = 0; i < 100; i++)
            {
                string s = BetweenPhaseData.WeaponsOwned[i].Name + "\n";
                File.AppendAllText(path, s);
            }
            //-------------------Armor--------------------------------
            for (int i = 0; i < 100; i++)
            {
                string s = BetweenPhaseData.ArmorOwned[i].Name + "\n";
                File.AppendAllText(path, s);
            }
            //-------------------Utility-------------------------------
            for (int i = 0; i < 100; i++)
            {
                string s = BetweenPhaseData.UtilityOwned[i].Name + "\n";
                File.AppendAllText(path, s);
            }
        }
    }
}
