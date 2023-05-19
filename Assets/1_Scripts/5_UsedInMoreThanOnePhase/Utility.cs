using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

namespace UtilityObject
{
    public class Utility
    {
        public string Name;
        public int effect; // for now im just going to put an int, i have no idea how many effects there will be
        public Sprite UtilityPic;
        public string Description;

        public Utility()
        {
            Name = "None";
            effect = 0;
            UtilityPic = null;
            Description = "";
        }
        public void _None()
        {
            Name = "None";
            effect = 0;
            UtilityPic = null;
            Description = "";
        }
        public void _PipeBomb()
        {
            Name = "Pipe Bomb";
            effect = 0;
            UtilityPic = Resources.Load<Sprite>("UtilityImages\\Pipe_Bomb");
            Description = Resources.Load<TextAsset>("_PipeBomb").text;
        }
        public void _Molotov()
        {
            Name = "Molotov";
            effect = 0;
            UtilityPic = Resources.Load<Sprite>("UtilityImages\\Molotov");
            Description = Resources.Load<TextAsset>("_Molotov").text;
        }
        public void _FlashBang()
        {
            Name = "Flash Bang";
            effect = 0;
            UtilityPic = Resources.Load<Sprite>("UtilityImages\\FlashBang");
            Description = Resources.Load<TextAsset>("_FlashBang").text;
        }
        public void _Medkit()
        {
            Name = "Medkit";
            effect = 0;
            UtilityPic = Resources.Load<Sprite>("UtilityImages\\Medkit");
            Description = Resources.Load<TextAsset>("_Medkit").text;
        }
        public void _TraumaBag()
        {
            Name = "Trauma Bag";
            effect = 0;
            UtilityPic = Resources.Load<Sprite>("UtilityImages\\Trama_Bag");
            Description = Resources.Load<TextAsset>("_TraumaBag").text;
        }
        public void _Granade()
        {
            Name = "Granade";
            effect = 0;
            UtilityPic = Resources.Load<Sprite>("UtilityImages\\Grenade");
            Description = Resources.Load<TextAsset>("_Grenade").text;
        }
        public void _Flare()
        {
            Name = "Flare";
            effect = 0;
            UtilityPic = Resources.Load<Sprite>("UtilityImages\\Flare");
            Description = Resources.Load<TextAsset>("_Flare").text;
        }
        public void _Disinfectant()
        {
            Name = "Disinfectant";
            effect = 0;
            UtilityPic = Resources.Load<Sprite>("UtilityImages\\Disinfectant");
            Description = Resources.Load<TextAsset>("_Disinfectant").text;
        }
        public void _Bandage()
        {
            Name = "Bandage";
            effect = 0;
            UtilityPic = Resources.Load<Sprite>("UtilityImages\\Bandage");
            Description = Resources.Load<TextAsset>("_Bandage").text;
        }
        public void _Antibiotic()
        {
            Name = "Antibiotic";
            effect = 0;
            UtilityPic = Resources.Load<Sprite>("UtilityImages\\antibiotic");
            Description = Resources.Load<TextAsset>("_Antibiotic").text;
        }
        public void Reset()
        {
            Name = "None";
            effect = 0;
            UtilityPic = null;
            Description = "";
        }
    }
}
