using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagementDND
{
    interface IWeapon
    {
        void AttackBonusCalc(); 
    }

    public class Rapier : IWeapon
    {
        public string Properties = "Finesse";
        public int DexterityModifier = 2; // placeholder
        public string ItemName = "Rapier";
        public string Range = "5.ft";
        public string Damage = "1D8";
        public string DamageType = "Pierce";
        public int AttackBonus;
        public int ItemWeight = 2;
        public bool ItemEquipped; 
        public bool Proficiency;
        public int ProficiencyModifier = 2; // Placeholder
        
        public void AttackBonusCalc()
        {
            if (Proficiency == true)
            {
                AttackBonus = DexterityModifier + ProficiencyModifier;
            } 
            else
            {
                AttackBonus = DexterityModifier;
            }
          
        }
    }
}

