using System;
using System.Collections.Generic;
using System.Text;

namespace DNDProjekt
{
    public class SkillList
    {
        public int acrobatics;
        public int animalHandling;
        public int arcana;
        public int athletics;
        public int deception;
        public int history;
        public int insight;
        public int intimidation;
        public int inevstigation;
        public int medicine;
        public int nature;
        public int perception;
        public int performance;
        public int persuation;
        public int religion;
        public int sleightOfHand;
        public int stealth;
        public int survival;
        public int passivePerception;

        public SkillList(int acrobatics, int animalHandling, int arcana, int athletics, int deception, int history,
            int insight, int intimidation, int inevstigation, int medicine, int nature, int perception,
            int performance, int persuation, int religion, int sleightOfHand, int stealth, int survival, int passivePerception)
        {
            this.acrobatics = acrobatics;
            this.animalHandling = animalHandling;
            this.arcana = arcana;
            this.athletics = athletics;
            this.deception = deception;
            this.history = history;
            this.insight = insight;
            this.intimidation = intimidation;
            this.inevstigation = inevstigation;
            this.medicine = medicine;
            this.nature = nature;
            this.perception = perception;
            this.performance = performance;
            this.persuation = persuation;
            this.religion = religion;
            this.sleightOfHand = sleightOfHand;
            this.stealth = stealth;
            this.survival = survival;
            this.passivePerception = passivePerception;
        }
    }
}
