using MonsterMerger.CustomObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterMerger.UserInterface {
    public partial class SimpleView : Form {

        private enum Operator {
            Add,
            Subtract,
            Set
        }

        bool isModifier = false;


        public SimpleView(DataBaseClass input) {
            InitializeComponent();

            //load basic information
            LabelName.Text += input.name;
            LabelCatagory.Text += input.catagory;
            LabelType.Text += input.dataType.ToString().Remove(input.dataType.ToString().Length - 1);
            RichDescription.Text += input.description;

            //check if its a modifier
            isModifier = input.dataType == DataManager.DataType.Modifications;

            //set labels correctly:
            if(!isModifier) {
                LabelChanges.Text = "Stats:";
            }

            //calculate changes:
            CalculateChanges(input.infoContainer);
        }

        public SimpleView(DataBaseClass input, InfoContainer info) {
            //loads this menu using external info
            InitializeComponent();

            //load basic information
            LabelName.Text += input.name;
            LabelCatagory.Text += input.catagory;
            LabelType.Text += input.dataType.ToString().Remove(input.dataType.ToString().Length - 1);
            RichDescription.Text += input.description;

            //check if its a modifier
            isModifier = input.dataType == DataManager.DataType.Modifications;

            //set labels correctly:
            if(!isModifier) {
                LabelChanges.Text = "Stats:";
            }

            //calculate changes:
            CalculateChanges(info);
        }

        private void CalculateChanges(InfoContainer info) {
            //determines what data is meaningless and what data should be displayed!
            //do main stats:
            writeNewLine("Main Stats:");
            bool nothingChanged = true;

            //go though main stats and check for changes:
            nothingChanged &= intTest(false, Operator.Add ,info.MainStatBody, "Body");
            nothingChanged &= intTest(false, Operator.Add, info.MainStatConviction, "Conviction");
            nothingChanged &= intTest(false, Operator.Add, info.MainStatCunning, "Cunning");
            nothingChanged &= intTest(false, Operator.Add, info.MainStatPassion, "Passion");
            nothingChanged &= intTest(false, Operator.Add, info.MainStatReason, "Reason");
            nothingChanged &= intTest(false, Operator.Add, info.MainStatProwess, "Prowess");
            nothingChanged &= intTest(false, Operator.Add, info.MainStatFate, "Fate");
            nothingChanged &= intTest(false, Operator.Add, info.MainStatFocus, "Focus");

            //check if anything changed:
            if(nothingChanged) {
                writeNewLine("     Nothing");
            }

            //add a empty line:
            writeNewLine("");

            //do Natural Skill stats:

            if(info.BroodIsBrood) {
                writeNewLine("Skills:");
                //show generic skill
                nothingChanged = false;
                nothingChanged &= intTest(false, true, Operator.Add, info.SkillGenericNatural, "Natural Skills");
            } else {
                writeNewLine("Natural Skills:");
                nothingChanged = true;
                //go though skill stats and check for changes:
                nothingChanged &= intTest(false, true, Operator.Add, info.SkillAthletics, "Athletics");
                nothingChanged &= intTest(false, true, Operator.Add, info.SkillAuthority, "Authority");
                nothingChanged &= intTest(false, true, Operator.Add, info.SkillLogic, "Logic");
                nothingChanged &= intTest(false, true, Operator.Add, info.SkillPanache, "Panache");
                nothingChanged &= intTest(false, true, Operator.Add, info.SkillPerception, "Perception");
                nothingChanged &= intTest(false, true, Operator.Add, info.SkillResolve, "Resolve");
            }
            

            //check if anything changed:
            if(nothingChanged) {
                writeNewLine("     Nothing");
            }

            //add a empty line:
            if(!info.BroodIsBrood) {
                writeNewLine("");
            }


            //do Learnt Skill stats:
            if(info.BroodIsBrood) {
                //show generic skill
                nothingChanged = false;
                nothingChanged &= intTest(false, true, Operator.Add, info.SkillGenericLearnt, "Learnt Skills");
            } else {
                writeNewLine("Learnt Skills:");
                nothingChanged = true;

                //go though main stats and check for changes:
                nothingChanged &= intTest(false, true, Operator.Add, info.SkillCrafts, "Crafts");
                nothingChanged &= intTest(false, true, Operator.Add, info.SkillKeening, "Keening");
                nothingChanged &= intTest(false, true, Operator.Add, info.SkillKnowledge, "Knowledge");
                nothingChanged &= intTest(false, true, Operator.Add, info.SkillMedicine, "Medicine");
                nothingChanged &= intTest(false, true, Operator.Add, info.SkillStealth, "Stealth");
                nothingChanged &= intTest(false, true, Operator.Add, info.SkillSurvival, "Survival");
            }
            

            //check if anything changed:
            if(nothingChanged) {
                writeNewLine("     Nothing");
            }

            //add a empty line:
            if(!info.BroodIsBrood) {
                writeNewLine("");
            }

            if(info.BroodIsBrood) {
                //show generic skill
                nothingChanged = false;
                nothingChanged &= intTest(false, true, Operator.Add, info.SkillGenericCombat, "Combat Skills");
            } else {
                //do Combat Skill stats:
                writeNewLine("Combat Skills:");
                nothingChanged = true;

                //go though main stats and check for changes:
                nothingChanged &= intTest(false, true, Operator.Add, info.SkillArchery, "Archery");
                nothingChanged &= intTest(false, true, Operator.Add, info.SkillFight, "Fight");
                nothingChanged &= intTest(false, true, Operator.Add, info.SkillMarksmanship, "Marksmanship");
                nothingChanged &= intTest(false, true, Operator.Add, info.SkillMelee, "Melee");
            }
            

            //check if anything changed:
            if(nothingChanged) {
                writeNewLine("     Nothing");
            }

            //add a empty line:
            writeNewLine("");



            //do Qualities and Specialties stats:
            writeNewLine("Qualities & Specialties:");
            nothingChanged = true;

            //go though main stats and check for changes:
            nothingChanged &= dictionaryTest(Operator.Add, info.Qualities, "Qualities");
            nothingChanged &= dictionaryTest(Operator.Add, info.Specialties, "Specialties");

            //check if anything changed:
            if(nothingChanged) {
                writeNewLine("     Nothing");
            }

            //add a empty line:
            writeNewLine("");


            //do Vitality stats:
            writeNewLine("Vitality:");
            nothingChanged = true;

            //if display item is monster, displayvitality stats:
            if(isModifier) {
                writeNewLine("     Wounds: ");
                    nothingChanged &= intTest(Operator.Add, info.VitalityMaxInjured, "      Injured");
                    nothingChanged &= intTest(Operator.Add, info.VitalityMaxMauled, "      Mauled");
                    nothingChanged &= intTest(Operator.Add, info.VitalityMaxCritical, "      Critical");
                    nothingChanged &= intTest(Operator.Add, info.VitalityMaxDeadly, "      Deadly");
                //check if anything changed:
                if(nothingChanged) {
                    writeNewLine("         Nothing");
                }
                nothingChanged = true;
                writeNewLine("     Thresholds: ");
                    nothingChanged &= intTest(Operator.Add, info.VitalityThresInjured, "      Injured");
                    nothingChanged &= intTest(Operator.Add, info.VitalityThresMauled, "      Mauled");
                    nothingChanged &= intTest(Operator.Add, info.VitalityThresCritical, "      Critical");
                    nothingChanged &= intTest(Operator.Add, info.VitalityThresDeadly, "      Deadly");
                    nothingChanged &= intTest(Operator.Add, info.VitalityThresOverkill, "      Overkill");
                //check if anything changed:
                if(nothingChanged) {
                    writeNewLine("         Nothing");
                }
                nothingChanged = true;
                writeNewLine("     Marks: ");
                    nothingChanged &= stringTest(Operator.Add, info.VitalityMarkInjured, "      Injured");
                    nothingChanged &= stringTest(Operator.Add, info.VitalityMarkMauled, "      Mauled");
                    nothingChanged &= stringTest(Operator.Add, info.VitalityMarkCritical, "      Critical");
                    nothingChanged &= stringTest(Operator.Add, info.VitalityMarkDeadly, "      Deadly");
                    nothingChanged &= stringTest(Operator.Add, info.VitalityMarkOverkill, "      Overkill");
                //check if anything changed:
                if(nothingChanged) {
                    writeNewLine("         Nothing");
                }
            } else {
                nothingChanged = false;
                writeNewLine("     Wounds: " + PlayerVitalitySimplifier(info, true));
                writeNewLine("     Thresholds: " + PlayerVitalitySimplifier(info, false));
            }

            //add a empty line:
            writeNewLine("");




            //check if nemmisary or brood:
            nothingChanged = true;
            if(info.BroodIsBrood) {
                writeNewLine("Brood:");
                nothingChanged &= intTest(Operator.Add, info.BroodSynergy, "    Synergy");
            } else {
                writeNewLine("Nemmisaries:");
                nothingChanged &= stringTest(Operator.Set, info.NemmisaryNameCreed, "   Creed Name");
                nothingChanged &= intTest(Operator.Add, info.NemmisaryAmountCreed, "    Creed Amount");
                nothingChanged &= stringTest(Operator.Set, info.NemmisaryNameSpite, "   Spite Name");
                nothingChanged &= intTest(Operator.Add, info.NemmisaryAmountSpite, "    Spite Amount");
            }


            //go though main stats and check for changes:
            nothingChanged &= dictionaryTest(Operator.Add, info.NemmisaryArietta, "Arietta");

            nothingChanged &= intTest(Operator.Add, info.NemmisaryLightAnima, "    Light Anima");
            nothingChanged &= intTest(Operator.Add, info.NemmisaryNeutralAnima, "    Neutral Anima");
            nothingChanged &= intTest(Operator.Add, info.NemmisaryDarkAnima, "    Dark Anima");

            //check if anything changed:
            if(nothingChanged) {
                writeNewLine("     Nothing");
            }


            //add a empty line:
            writeNewLine("");


            //do Inventory And Combat stats:
            writeNewLine("Inventory & Combat:");
            nothingChanged = true;

            //go though main stats and check for changes:
            nothingChanged &= dictionaryTest(Operator.Add, info.Inventory, "Inventory");
            nothingChanged &= dictionaryTest(Operator.Add, info.Combat, "Combat");

            //check if anything changed:
            if(nothingChanged) {
                writeNewLine("     Nothing");
            }
        }
        private bool intTest(Operator oper, int input, string name) {
            return intTest(true, false, oper, input, name);
        }
        private bool intTest(bool allowStripping, Operator oper, int input, string name) {
            return intTest(allowStripping, false, oper, input, name);
        }

        private bool intTest(bool allowStripping, bool displayRoll, Operator oper, int input, string name) {
            //local variables
            string addition = "";

            //if modifier, needs added data and checks
            if(isModifier) {
                allowStripping = true;
            }
            if(allowStripping) {
                //if number is zero and operator is not set to 'set' then nothing will be changed and this can be ignored
                if(input == 0 && !(oper == Operator.Set)) {
                    return true;
                }

                if(isModifier) {
                    //calculate what string to add:     
                    switch(oper) {
                        case Operator.Add:
                            if(input < 0) {
                                addition = "";
                            } else {
                                addition = "+";
                            }
                            break;

                        case Operator.Subtract:
                            if(input < 0) {
                                input = input - (input * 2);
                                addition = "+";
                            } else {
                                addition = "-";
                            }
                            break;

                        case Operator.Set:
                            addition = "=";
                            break;
                    }
                }
                
            }

            //add stat to screen
            string rollDisplay = "";

            if(displayRoll) {
                rollDisplay = "     (" + CalculateDisplay(Math.Max(Math.Min(input, 6), 0)) + ")";
            }

            writeNewLine("     " + name + ": " + addition + input + rollDisplay);
            return false;
        }

        private string CalculateDisplay(int input) {
            string output;
            if(input == 0) {
                output = "2x 6+";
            } else {
                output = (7 - input) + "+";
            }
            return output;
        }

        private bool stringTest(Operator oper, string input, string name) {
            return stringTest(true, oper, input, name);
        }


        private bool stringTest(bool allowStripping, Operator oper, string input, string name) {
            //local variables
            string addition = "";
            //if modifier, needs added data and checks            
            if(isModifier) {
                allowStripping = true;
            }
            if(allowStripping) {
                //if number is zero and operator is not set to 'set' then nothing will be changed and this can be ignored
                if(input.Trim() == ""){// && !(oper == Operator.Set)) {
                    return true;
                }

                if(isModifier) {
                    //calculate what string to add:
                    switch(oper) {
                        case Operator.Add:
                                addition = "Adds: ";
                            break;

                        case Operator.Subtract:
                                addition = "Removes: ";
                            break;

                        case Operator.Set:
                            addition = "Set to:";
                            break;
                    }
                }
                
            }

            //add stat to screen

            if(input.Trim() == "") {
                writeNewLine("     " + name +  ": Nothing");
                return false;
            }
            writeNewLine("     " + name + ": " + addition);
            foreach(string subString in input.Split(Environment.NewLine.ToCharArray())) {
                if(subString.Trim() == "") continue;
                writeNewLine("         " + subString);
                Console.WriteLine(subString);
            }
            return false;
        }

        private bool dictionaryTest(Operator oper, Dictionary<string, int> input, string name) {
            return dictionaryTest(true, oper, input, name);
        }

        private bool dictionaryTest(bool allowStripping, Operator oper, Dictionary<string, int> input, string name) {
            //local variables
            string addition = "";
            //if modifier, needs added data and checks            
            if(isModifier) {
                allowStripping = true;
            }
            if(allowStripping) {
                //if number is zero and operator is not set to 'set' then nothing will be changed and this can be ignored
                if(input.Count == 0) {// && !(oper == Operator.Set)) {
                    return true;
                }

                if(isModifier) {
                    //calculate what string to add:
                    switch(oper) {
                        case Operator.Add:
                            addition = "Adds: ";
                            break;

                        case Operator.Subtract:
                            addition = "Removes: ";
                            break;

                        case Operator.Set:
                            addition = "Set to:";
                            break;
                    }
                }

            }

            //add stat to screen
            Console.WriteLine(input.Count);
            if(input.Count == 0) {
                writeNewLine("     " + name +  ": Nothing");
                return false;
            }
            writeNewLine("     " + name + ": " + addition);
            foreach(string keyString in input.Keys) {
                if(keyString.Trim() == "") continue;
                string amount = "";
                if(input[keyString] > 1) amount = " (x" + input[keyString] + ")";
                writeNewLine("         " + keyString + amount);
            }
            return false;
        }



        private void writeNewLine(string input) {
            RichBigList.Text += input + "\n";
        }




        //reduces and compacts the vitality data down into a easier format to read!
        public static string PlayerVitalitySimplifier(InfoContainer info, bool doMaximum) {
            string output = "";
            if(doMaximum) {
                output += info.VitalityMaxInjured + "/";
                output += info.VitalityMaxMauled + "/";
                output += info.VitalityMaxCritical + "/";
                output += info.VitalityMaxDeadly;
            } else {
                output += info.VitalityThresInjured + info.VitalityMarkInjured + "/";
                output += info.VitalityThresMauled + info.VitalityMarkMauled + "/";
                output += info.VitalityThresCritical + info.VitalityMarkCritical + "/";
                output += info.VitalityThresDeadly + info.VitalityMarkDeadly + "/";
                output += info.VitalityThresOverkill + info.VitalityMarkOverkill;
            }
            return output;
        }

        private void SimpleView_Load(object sender, EventArgs e) {

        }
    }
}
