using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

namespace AromorObject
{
    public class Armor
    {
        public float Protection;
        public int Reduction;
        public string Name;
        public string Utility;
        public Sprite ArmorPic;
        public string Description;

        public Armor()
        {
            Protection = 0;
            Reduction = 0;
            Name = "None";
            Utility = "";
            ArmorPic = null;
            Description = "";
        }
        public void _None()
        {
            Protection = 0;
            Reduction = 0;
            Name = "None";
            Utility = "";
            ArmorPic = null;
            Description = "";
        }
        public void _BallCap()
        {
            Protection = 0;
            Reduction = 0;
            Name = "Ball Cap";
            Utility = "SENSES+2";
            ArmorPic = Resources.Load<Sprite>("ArmorImages\\BaseballCap"); ;
            Description = Resources.Load<TextAsset>("_BallCap").text;
        }
        public void _HardHat()
        {
            Protection = .05f;
            Reduction = 1;
            Name = "Hard Hat";
            Utility = "LIGHT+1";
            ArmorPic = null;
            Description = Resources.Load<TextAsset>("_HardHat").text;
        }
        public void _FaceMask()
        {
            Protection = .05f;
            Reduction = 2;
            Name = "Face Mask";
            Utility = "SENSES-3";
            ArmorPic = Resources.Load<Sprite>("ArmorImages\\Medical_Mask");
            Description = Resources.Load<TextAsset>("_FaceMask").text;
        }
        public void _GasMask()
        {
            Protection = 0;
            Reduction = 0;
            Name = "Gas Mask";
            Utility = "DISEASERESISTANCE+.5";
            ArmorPic = Resources.Load<Sprite>("ArmorImages\\Gas_Mask");
            Description = Resources.Load<TextAsset>("_GasMask").text;
        }
        public void _RiotShield()
        {
            Protection = .1f;
            Reduction = 3;
            Name = "Riot Shield";
            Utility = "IGNOREEXPLOSIVES";
            ArmorPic = Resources.Load<Sprite>("ArmorImages\\Riot_Shield");
            Description = Resources.Load<TextAsset>("_RiotShield").text;
        }
        public void _ThickGloves()
        {
            Protection = 0;
            Reduction = 0;
            Name = "Thick Gloves";
            Utility = "DISEASERESISTANCE+.5";
            ArmorPic = Resources.Load<Sprite>("ArmorImages\\work_glove");
            Description = Resources.Load<TextAsset>("_ThickGloves").text;
        }
        public void _Bandalear()
        {
            Protection = 0;
            Reduction = 0;
            Name = "Bandalear";
            Utility = "EQUIPMENTSLOT+1";
            ArmorPic = Resources.Load<Sprite>("ArmorImages\\Bandalier");
            Description = Resources.Load<TextAsset>("_Bandalear").text;
        }
        public void _SportsPadding()
        {
            Protection = .15f;
            Reduction = 0;
            Name = "Sports Padding";
            Utility = "NONE";
            ArmorPic = Resources.Load<Sprite>("ArmorImages\\sportsPadding");
            Description = Resources.Load<TextAsset>("_SportsPadding").text;
        }
        public void _ChestPlate()
        {
            Protection = .1f;
            Reduction = 2;
            Name = "Chest Plate";
            Utility = "NONE";
            ArmorPic = Resources.Load<Sprite>("ArmorImages\\Chestplate-1");
            Description = Resources.Load<TextAsset>("_ChestPlate").text;
        }
        public void _PoliceVest()
        {
            Protection = .15f;
            Reduction = 4;
            Name = "Police Vest";
            Utility = "EQUIPMENTSLOT+1";
            ArmorPic = Resources.Load<Sprite>("ArmorImages\\bulletproof-1");
            Description = Resources.Load<TextAsset>("_PoliceVest").text;
        }
        public void _DoctorsScrubs()
        {
            Protection = .05f;
            Reduction = 1;
            Name = "Doctors Scrubs";
            Utility = "DISEASERESISTANCE+.25";
            ArmorPic = Resources.Load<Sprite>("ArmorImages\\Doctor_Scrubs"); 
            Description = Resources.Load<TextAsset>("_DoctorsScrubs").text;
        }
        public void _SportsGear()
        {
            Protection = .05f;
            Reduction = 4;
            Name = "Sports Gear";
            Utility = "IGNOREPRONE+.5";
            ArmorPic = null;
            Description = Resources.Load<TextAsset>("_SportsGear").text;
        }
        public void _MetalSuit()
        {
            Protection = .05f;
            Reduction = 6;
            Name = "Metal Suit";
            Utility = "NONE";
            ArmorPic = Resources.Load<Sprite>("ArmorImages\\Metal_Vest-1");
            Description = Resources.Load<TextAsset>("_MetalSuit").text;
        }
        public void _RiotGear()
        {
            Protection = .1f;
            Reduction = 10;
            Name = "Riot Gear";
            Utility = "IGNORETUSSLING";
            ArmorPic = Resources.Load<Sprite>("ArmorImages\\RIot_Gear");
            Description = Resources.Load<TextAsset>("_RiotGear").text;
        }
        public void _HazmatSuit()
        {
            Protection = .1f;
            Reduction = 2;
            Name = "Hazmat Suit";
            Utility = "DISEASERESISTANCE+.5";
            ArmorPic = Resources.Load<Sprite>("ArmorImages\\Hazmat_suit");
            Description = Resources.Load<TextAsset>("_HazmatSuit").text;
        }
        public void Reset()
        {
            Protection = 0;
            Reduction = 0;
            Name = "None";
            Utility = "";
            ArmorPic = null;
            Description = "";
        }
    }
}
