using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

namespace WeaponObject
{
    public class Weapon
    {
        public int DamageMin;
        public int DamageMax;
        public int Range;
        public int Volume;
        public string Name;
        public string AssignedTrait;
        public Sprite WeaponPic;
        public string Description;

        public Weapon()
        {
            DamageMin = 0;
            DamageMax = 0;
            Range = 0;
            Volume = 0;
            Name = "None";
            AssignedTrait = "";
            WeaponPic = null;
            Description = "";
        }

        public void _12GaugeShotgun()
        {
            DamageMin = 15;
            DamageMax = 25;
            Range = 4;
            Volume = 4;
            Name = "12 Gauge Shotgun";
            AssignedTrait = "BRAWN";
            WeaponPic = Resources.Load<Sprite>("WeaponImages\\Shotgun1-1.png");
            // set the description from a file
            Description = Resources.Load<TextAsset>("_12GaugeShotgun").text;
        }
        public void _20GuageShotgun()
        {
            DamageMin = 8;
            DamageMax = 16;
            Range = 4;
            Volume = 4;
            Name = "20 Guage Shotgun";
            AssignedTrait = "BRAWN";
            WeaponPic = Resources.Load<Sprite>("WeaponImages\\Shotgun1-1.png");
            Description = Resources.Load<TextAsset>("_20GaugeShotgun").text;
        }
        public void _2X4()
        {
            DamageMin = 3;
            DamageMax = 4;
            Range = 1;
            Volume = 1;
            Name = "2X4";
            AssignedTrait = "BRAWN";
            WeaponPic = Resources.Load<Sprite>("WeaponImages\\2X4");
            Description = Resources.Load<TextAsset>("_2X4").text;
        }
        public void _AK47()
        {
            DamageMin = 10;
            DamageMax = 16;
            Range = 9;
            Volume = 2;
            Name = "AK 47";
            AssignedTrait = "SKILL";
            WeaponPic = Resources.Load<Sprite>("WeaponImages\\AK-47-1.png");
            Description = Resources.Load<TextAsset>("_AK47").text;
        }
        public void _BaseballBat()
        {
            DamageMin = 5;
            DamageMax = 9;
            Range = 1;
            Volume = 1;
            Name = "Baseball Bat";
            AssignedTrait = "BRAWN";
            WeaponPic = Resources.Load<Sprite>("WeaponImages\\BaseBallBat");
            Description = Resources.Load<TextAsset>("_BaseballBat").text;
        }
        public void _BoltactionRifle()
        {
            DamageMin = 10;
            DamageMax = 13;
            Range = 10;
            Volume = 2;
            Name = "Bolt Action Rifle";
            AssignedTrait = "SKILL";
            WeaponPic = Resources.Load<Sprite>("WeaponImages\\Sniper_Rifle-1.png");
            Description = Resources.Load<TextAsset>("_BoltActionRifle").text;
        }
        public void _KitchenKnife()
        {
            DamageMin = 1;
            DamageMax = 3; 
            Range = 1;
            Volume = 0;
            Name = "Kitchen Knife";
            AssignedTrait = "SKILL";
            WeaponPic = Resources.Load<Sprite>("WeaponImages\\Kitchen_Knife");
            Description = Resources.Load<TextAsset>("_KitchenKnife").text;
        }
        public void _CombatKnife()
        {
            DamageMin = 3;
            DamageMax = 5;
            Range = 1;
            Volume = 0;
            Name = "Combat Knife";
            AssignedTrait = "SKILL";
            WeaponPic = Resources.Load<Sprite>("WeaponImages\\Combat_Knife-1.png");
            Description = Resources.Load<TextAsset>("_CombatKnife").text;
        }
        public void _M16()
        {
            DamageMin = 10;
            DamageMax = 14;
            Range = 9;
            Volume = 3;
            Name = "M16";
            AssignedTrait = "SKILL";
            WeaponPic = Resources.Load<Sprite>("WeaponImages\\M16");
            Description = Resources.Load<TextAsset>("_M16").text;
        }
        public void _Machete()
        {
            DamageMin = 6;
            DamageMax = 7;
            Range = 1;
            Volume = 1;
            Name = "Machete";
            AssignedTrait = "BRAWN";
            WeaponPic = Resources.Load<Sprite>("WeaponImages\\Machete-1.png");
            Description = Resources.Load<TextAsset>("_Machete").text;
        }
        public void _9mmPistol()
        {
            DamageMin = 5;
            DamageMax = 10;
            Range = 4;
            Volume = 2;
            Name = "9mm";
            AssignedTrait = "SKILL";
            WeaponPic = Resources.Load<Sprite>("WeaponImages\\9mm-1.png");
            Description = Resources.Load<TextAsset>("_Pistol").text;
        }
        public void _Revolver()
        {
            DamageMin = 6;
            DamageMax = 12;
            Range = 4;
            Volume = 3;
            Name = "Revolver";
            AssignedTrait = "SKILL";
            WeaponPic = Resources.Load<Sprite>("WeaponImages\\Revolver-1.png");
            Description = Resources.Load<TextAsset>("_Revolver").text;
        }
        public void _SledgeHammer()
        {
            DamageMin = 10;
            DamageMax = 15;
            Range = 1;
            Volume = 3;
            Name = "Sledge Hammer";
            AssignedTrait = "BRAWN";
            WeaponPic = Resources.Load<Sprite>("WeaponImages\\Sledge_Hammer");
            Description = Resources.Load<TextAsset>("_SledgeHammer").text;
        }
        public void Reset()
        {
            DamageMin = 0;
            DamageMax = 0;
            Range = 0;
            Volume = 0;
            Name = "None";
            AssignedTrait = "";
            WeaponPic = null;
            Description = "";
        }
    }
}
