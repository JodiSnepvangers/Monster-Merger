using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterMerger.CustomObjects {
    public class InfoContainer {
        public int MainStatBody { get; set; } = 0;
        public int MainStatConviction { get; set; } = 0;
        public int MainStatCunning { get; set; } = 0;
        public int MainStatPassion { get; set; } = 0;
        public int MainStatReason { get; set; } = 0;
        public int MainStatProwess { get; set; } = 0;
        public int MainStatFate { get; set; } = 0;
        public int MainStatFocus { get; set; } = 0;

        //skill stats:
        //Natural:
        public int SkillAthletics { get; set; } = 0;
        public int SkillAuthority { get; set; } = 0;
        public int SkillLogic { get; set; } = 0;
        public int SkillPanache { get; set; } = 0;
        public int SkillPerception { get; set; } = 0;
        public int SkillResolve { get; set; } = 0;
        //Learnt
        public int SkillCrafts { get; set; } = 0;
        public int SkillKeening { get; set; } = 0;
        public int SkillKnowledge { get; set; } = 0;
        public int SkillMedicine { get; set; } = 0;
        public int SkillStealth { get; set; } = 0;
        public int SkillSurvival { get; set; } = 0;
        //Combat
        public int SkillArchery { get; set; } = 0;
        public int SkillFight { get; set; } = 0;
        public int SkillMarksmanship { get; set; } = 0;
        public int SkillMelee { get; set; } = 0;
        //generic:
        public int SkillGenericNatural { get; set; } = 0;
        public int SkillGenericLearnt { get; set; } = 0;
        public int SkillGenericCombat { get; set; } = 0;




        //string storage
        public Dictionary<string, int> Qualities { get; set; } = new Dictionary<string, int>();
        public Dictionary<string, int> Specialties { get; set; } = new Dictionary<string, int>();

        //Vitality:
        public int VitalityMaxInjured { get; set; } = 0;
        public int VitalityThresInjured { get; set; } = 0;
        public string VitalityMarkInjured { get; set; } = "";

        public int VitalityMaxMauled { get; set; } = 0;
        public int VitalityThresMauled { get; set; } = 0;
        public string VitalityMarkMauled { get; set; } = "";

        public int VitalityMaxCritical { get; set; } = 0;
        public int VitalityThresCritical { get; set; } = 0;
        public string VitalityMarkCritical { get; set; } = "";

        public int VitalityMaxDeadly { get; set; } = 0;
        public int VitalityThresDeadly { get; set; } = 0;
        public string VitalityMarkDeadly { get; set; } = "";

        public int VitalityThresOverkill { get; set; } = 0;
        public string VitalityMarkOverkill { get; set; } = "";

        public int VitalityResilience { get; set; } = 0;
        public string VitalityMarkResilience { get; set; } = "";


        //Nemmisary/brood data:
        public Dictionary<string, int> NemmisaryArietta { get; set; } = new Dictionary<string, int>();
        public string NemmisaryNameCreed { get; set; } = "";
        public int NemmisaryAmountCreed { get; set; } = 0;
        public string NemmisaryNameSpite { get; set; } = "";
        public int NemmisaryAmountSpite { get; set; } = 0;
        public int NemmisaryLightAnima { get; set; } = 0;
        public int NemmisaryNeutralAnima { get; set; } = 0;
        public int NemmisaryDarkAnima { get; set; } = 0;
        public bool BroodIsBrood { get; set; } = false;
        public int BroodSynergy { get; set; } = 0;


        //Inventory & Combat data:
        public Dictionary<string, int> Inventory { get; set; } = new Dictionary<string, int>();
        public Dictionary<string, int> Combat { get; set; } = new Dictionary<string, int>();

        /**
         * merge: takes another InfoContainer as input, and merges the data of this container onto the one provided 
         * if given null, can output a copy of this info container
         */

        public InfoContainer merge(InfoContainer parentContainer) {

            //if given null, create new container:
            if(parentContainer == null) {
                parentContainer = new InfoContainer();
            }

            //add all main stats together:
            parentContainer.MainStatBody += this.MainStatBody;
            parentContainer.MainStatConviction += this.MainStatConviction;
            parentContainer.MainStatCunning += this.MainStatCunning;
            parentContainer.MainStatPassion += this.MainStatPassion;
            parentContainer.MainStatReason += this.MainStatReason;
            parentContainer.MainStatProwess += this.MainStatProwess;
            parentContainer.MainStatFate += this.MainStatFate;

            mergeFocus(parentContainer);

            //add all skills together

            parentContainer.SkillAthletics += this.SkillAthletics;
            parentContainer.SkillAuthority += this.SkillAuthority;
            parentContainer.SkillLogic += this.SkillLogic;
            parentContainer.SkillPanache += this.SkillPanache;
            parentContainer.SkillPerception += this.SkillPerception;
            parentContainer.SkillResolve += this.SkillResolve;

            parentContainer.SkillCrafts += this.SkillCrafts;
            parentContainer.SkillKeening += this.SkillKeening;
            parentContainer.SkillKnowledge += this.SkillKnowledge;
            parentContainer.SkillMedicine += this.SkillMedicine;
            parentContainer.SkillStealth += this.SkillStealth;
            parentContainer.SkillSurvival += this.SkillSurvival;

            parentContainer.SkillArchery += this.SkillArchery;
            parentContainer.SkillFight += this.SkillFight;
            parentContainer.SkillMarksmanship += this.SkillMarksmanship;
            parentContainer.SkillMelee += this.SkillMelee;

            parentContainer.SkillGenericNatural += this.SkillGenericNatural;
            parentContainer.SkillGenericLearnt += this.SkillGenericLearnt;
            parentContainer.SkillGenericCombat += this.SkillGenericCombat;

            //deal with qualities and specialties
            MergeDictionary(parentContainer.Qualities, this.Qualities);
            MergeDictionary(parentContainer.Specialties, this.Specialties);

            mergeVitality(parentContainer);

            //deal with nemmisary data:
            MergeDictionary(parentContainer.NemmisaryArietta, this.NemmisaryArietta);

            if(BroodIsBrood) {
                //is brood
                parentContainer.BroodSynergy= this.BroodSynergy;
                parentContainer.BroodIsBrood = true;
            } else {
                //is nemmisary
                parentContainer.NemmisaryNameCreed = this.NemmisaryNameCreed;
                parentContainer.NemmisaryAmountCreed += this.NemmisaryAmountCreed;
                parentContainer.NemmisaryNameSpite = this.NemmisaryNameSpite;
                parentContainer.NemmisaryAmountSpite += this.NemmisaryAmountSpite;
            }

            parentContainer.NemmisaryLightAnima += this.NemmisaryLightAnima;
            parentContainer.NemmisaryNeutralAnima += this.NemmisaryNeutralAnima;
            parentContainer.NemmisaryDarkAnima += this.NemmisaryDarkAnima;

            //deal with Inventory and Combat
            MergeDictionary(parentContainer.Inventory, this.Inventory);
            MergeDictionary(parentContainer.Combat, this.Combat);

            return parentContainer;
        }


        //calculates Vitality:
        public InfoContainer mergeVitality(InfoContainer info) {


            //Deal with Vitality

            info.VitalityMaxInjured += this.VitalityMaxInjured;
            info.VitalityThresInjured += this.VitalityThresInjured;
            info.VitalityMarkInjured += this.VitalityMarkInjured;

            info.VitalityMaxMauled += this.VitalityMaxMauled;
            info.VitalityThresMauled += this.VitalityThresMauled;
            info.VitalityMarkMauled += this.VitalityMarkMauled;

            info.VitalityMaxCritical += this.VitalityMaxCritical;
            info.VitalityThresCritical += this.VitalityThresCritical;
            info.VitalityMarkCritical += this.VitalityMarkCritical;

            info.VitalityMaxDeadly += this.VitalityMaxDeadly;
            info.VitalityThresDeadly += this.VitalityThresDeadly;
            info.VitalityMarkDeadly += this.VitalityMarkDeadly;

            info.VitalityThresOverkill += this.VitalityThresOverkill;
            info.VitalityMarkOverkill += this.VitalityMarkOverkill;

            info.VitalityResilience += this.VitalityResilience;
            info.VitalityMarkResilience += this.VitalityMarkResilience;

            return info;
        }


        public InfoContainer mergeFocus(InfoContainer info) {
            info.MainStatFocus += this.MainStatFocus;
            return info;
        }


        private void MergeDictionary(Dictionary<string, int> externalDictionary, Dictionary<string, int> internalDictionary) {
            foreach(string keyString in internalDictionary.Keys) {
                int amount = internalDictionary[keyString];

                if(externalDictionary.ContainsKey(keyString)) {
                    externalDictionary[keyString] += amount;
                } else {
                    externalDictionary.Add(keyString, amount);
                }
            }
        }









        //utility functions:

        //Focus Calculations: calculates focus dependant on outside numbers. returns the amount of focus

        public int CalculateFocus(int fate, int conviction, int cunning) {
        return (int)Math.Floor((decimal)(fate + ((conviction + cunning) / 2)));
        }

        //does the same, but uses internal numbers instead
        public int CalculateFocus() {
            return CalculateFocus(MainStatFate, MainStatConviction, MainStatCunning);
        }

        //Vitality Calculation: calculates vitality value given a int index:
        //0: Injured
        //1: Mauled
        //2: Critical
        //3: Deadly
        //4: Overkill

        //also has a boolean to decide what calculations to perform
        //true: Maximum
        //false: Threshold

        //required stat should be the stat meant for that calculation:
        //maximum: conviction
        //threshold: Body

        public int CalculateVitality(bool calcMax, int calcType, int requiredStat) {
            if(calcMax) {
                //calculating maximum:
                /** 
                    I: =conviction
                    M: conviction-1
                    C: conviction -2
                    D: only 1
                    O: only ever 1
                 */

                if(calcType >= 3) {
                    return 1;
                } else {
                    return requiredStat - calcType;
                }
            } else {
                //calculating Threshold:
                /**
                    I: 1+(body/2)
                    M: 1 + body
                    C: 1+ (body2)
                    D: 1+(body3)
                    O: 1+(body*4)
                 */
                if(calcType <= 0) {
                    return 1 + (requiredStat / 2);
                } else {
                    return 1 + (requiredStat * calcType);
                }
            }
        }

        //same but uses internal values:
        public int CalculateVitality(bool calcMax, int calcType) {
            if(calcMax) {
                return CalculateVitality(calcMax, calcType, MainStatConviction);
            } else {
                return CalculateVitality(calcMax, calcType, MainStatBody);
            }
        }


        //uses and sets internal values
        public void CalculateVitality() {
            VitalityMaxInjured = CalculateVitality(true, 0);
            VitalityMaxMauled = CalculateVitality(true, 1);
            VitalityMaxCritical = CalculateVitality(true, 2);
            VitalityMaxDeadly = CalculateVitality(true, 3);

            VitalityThresInjured = CalculateVitality(false, 0);
            VitalityThresMauled = CalculateVitality(false, 1);
            VitalityThresCritical = CalculateVitality(false, 2);
            VitalityThresDeadly = CalculateVitality(false, 3);
            VitalityThresOverkill = CalculateVitality(false, 4);
        }
    }
}
