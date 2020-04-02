using System;
using System.Collections.Generic;
using System.Text;

namespace DNDProjekt
{
    public class Skill
    {
        private int StrengthModifier;
        private int DexterityModifier;
        private int ConsitiutionModifier;
        private int IntelligenceModifier;
        private int WisdomModifier;
        private int CharismaModifier;

        private string SkillName;
        private int Bonus;
        private int ProficiencyBonus;
        private bool JackOfAllTrades;

        private bool[] proficiency = new bool[18];

        public Skill(int StrengthModifier, int DexterityModifier, int ConstitutionModifier, int IntelligenceModifier, int WisdomModifier, int CharismaModifier, int ProficiencyBonus, int[] proficiencyEnabled)
        {
            this.StrengthModifier = StrengthModifier;
            this.DexterityModifier = DexterityModifier;
            this.ConsitiutionModifier = ConstitutionModifier;
            this.IntelligenceModifier = IntelligenceModifier;
            this.WisdomModifier = WisdomModifier;
            this.CharismaModifier = CharismaModifier;
            this.ProficiencyBonus = ProficiencyBonus;

            foreach (int index in proficiencyEnabled)
                proficiency[index] = true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Acrobatics " + Acrobatics + "\n");
            sb.Append("AnimalHandling " + AnimalHandling + "\n");
            sb.Append("Arcana " + Arcana + "\n");
            sb.Append("Athletics " + Athletics + "\n");
            sb.Append("Deception " + Deception + "\n");
            sb.Append("History " + History + "\n");
            sb.Append("Insight " + Insight + "\n");
            sb.Append("Intimidation " + Intimidation + "\n");
            sb.Append("Investigation " + Investigation + "\n");
            sb.Append("Medicine " + Medicine + "\n");
            sb.Append("Performance " + Performance + "\n");
            sb.Append("Persuasion " + Persuasion + "\n");
            sb.Append("Religion " + Religion + "\n");
            sb.Append("Sleight of Hand " + SleightOfHand + "\n");
            sb.Append("Stealth " + Stealth + "\n");
            sb.Append("Survival " + Survival + "\n");
            return sb.ToString();
        }

        public int Acrobatics
        {
            get { return DexterityModifier + (proficiency[0] ? ProficiencyBonus : 0); }
        }
        public int AnimalHandling
        {
            get { return WisdomModifier + (proficiency[1] ? ProficiencyBonus : 0); }
        }
        public int Arcana
        {
            get { return IntelligenceModifier + (proficiency[2] ? ProficiencyBonus : 0); }
        }
        public int Athletics
        {
            get { return StrengthModifier + (proficiency[3] ? ProficiencyBonus : 0); }
        }
        public int Deception
        {
            get { return CharismaModifier + (proficiency[4] ? ProficiencyBonus : 0); }
        }
        public int History
        {
            get { return IntelligenceModifier + (proficiency[5] ? ProficiencyBonus : 0); }
        }

        public int Insight
        {
            get { return WisdomModifier + (proficiency[6] ? ProficiencyBonus : 0); }
        }

        public int Intimidation
        {
            get { return CharismaModifier + (proficiency[7] ? ProficiencyBonus : 0); }
        }

        public int Investigation
        {
            get { return IntelligenceModifier + (proficiency[8] ? ProficiencyBonus : 0); }
        }

        public int Medicine
        {
            get { return WisdomModifier + (proficiency[9] ? ProficiencyBonus : 0); }
        }

        public int Nature
        {
            get { return IntelligenceModifier + (proficiency[10] ? ProficiencyBonus : 0); }
        }

        public int Perception
        {
            get { return WisdomModifier + (proficiency[11] ? ProficiencyBonus : 0); }
        }

        public int Performance
        {
            get { return CharismaModifier + (proficiency[12] ? ProficiencyBonus : 0); }
        }

        public int Persuasion
        {
            get { return CharismaModifier + (proficiency[13] ? ProficiencyBonus : 0); }
        }

        public int Religion
        {
            get { return IntelligenceModifier + (proficiency[14] ? ProficiencyBonus : 0); }
        }

        public int SleightOfHand
        {
            get { return DexterityModifier + (proficiency[15] ? ProficiencyBonus : 0); }
        }

        public int Stealth
        {
            get { return DexterityModifier + (proficiency[16] ? ProficiencyBonus : 0); }
        }

        public int Survival
        {
            get { return WisdomModifier + (proficiency[17] ? ProficiencyBonus : 0); }
        }
    }
}
