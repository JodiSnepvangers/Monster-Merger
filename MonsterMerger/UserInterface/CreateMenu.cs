using MonsterMerger.CustomObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MonsterMerger.UserInterface {
    public partial class CreateMenu : Form {

        DataBaseClass displayData;
        InfoContainer replacementData = null;

        bool mergeDictionary = false;

        static bool lastEditState = true;

        bool readOnly = false;
        bool writeDirectly = false;

        //can be given a data class to be displayed!~ if set to null, create a new class instead
        public CreateMenu(DataBaseClass displayData) {
            InitializeComponent();

            //check if data is null. if so, create new data
            if(displayData == null) {


                Text = "Create New";

                if(lastEditState) {
                    displayData = new DataBaseClass(DataManager.DataType.Monsters);
                    displayData.infoContainer.SkillAthletics = 1;
                    displayData.infoContainer.SkillAuthority = 1;
                    displayData.infoContainer.SkillLogic = 1;
                    displayData.infoContainer.SkillPanache = 1;
                    displayData.infoContainer.SkillPerception = 1;
                    displayData.infoContainer.SkillResolve = 1;
                } else {
                    displayData = new DataBaseClass(DataManager.DataType.Modifications);
                }
            }
            //save data to variable
            this.displayData = displayData;
            UpdateDisplay();

            //set status text to empty
            LabelStatus.Text = "";
        }


        public CreateMenu(DataBaseClass displayData, InfoContainer info) {
            readOnly = true;
            InitializeComponent();
            //save data to variable
            this.displayData = displayData;
            this.replacementData = info;
            mergeDictionary = true;
            UpdateDisplay(info);


            //set status text to empty
            LabelStatus.Text = "";
            Text = "View Results";
            AllowWriting(false);
        }


        public CreateMenu(InfoContainer info, bool unusedBool) {
            InitializeComponent();
            //save data to variable
            this.displayData = new DataBaseClass(DataManager.DataType.Modifications);
            displayData.infoContainer = info;
            UpdateDisplay(info);
            writeDirectly = true;

            //set status text to empty
            LabelStatus.Text = "";
            panel8.Visible = false;
        }
        private void UpdateDisplay() {
            if(replacementData ==null){
                UpdateDisplay(displayData.infoContainer);
            } else {
                UpdateDisplay(replacementData);
            }
            
        }

        private void UpdateDisplay(InfoContainer infoContainer) {
            //load data to display:
            //loading general data
            if(displayData.dataType == DataManager.DataType.Monsters) {
                radioButtonMonster.Checked = true;
            } else {
                radioButtonModifier.Checked = true;
            }

            TextBoxCatagory.Text = displayData.catagory;
            TextBoxName.Text = displayData.name;
            RichTextDescription.Text = displayData.description;

            //load main stats:
            IntPutSet(IntPutBody, infoContainer.MainStatBody);
            IntPutSet(IntPutConviction, infoContainer.MainStatConviction);
            IntPutSet(IntPutCunning, infoContainer.MainStatCunning);
            IntPutSet(IntPutPassion, infoContainer.MainStatPassion);
            IntPutSet(IntPutReason, infoContainer.MainStatReason);
            IntPutSet(IntPutProwess, infoContainer.MainStatProwess);
            IntPutSet(IntPutFate, infoContainer.MainStatFate);
            IntPutSet(IntPutMaxFocus, infoContainer.MainStatFocus);

            //load natural skills:
            IntPutSet(IntPutAthletics, infoContainer.SkillAthletics);
            IntPutSet(IntPutAuthority, infoContainer.SkillAuthority);
            IntPutSet(IntPutLogic, infoContainer.SkillLogic);
            IntPutSet(IntPutPanache, infoContainer.SkillPanache);
            IntPutSet(IntPutPerception, infoContainer.SkillPerception);
            IntPutSet(IntPutResolve, infoContainer.SkillResolve);
            //load learnt skills
            IntPutSet(IntPutCrafts, infoContainer.SkillCrafts);
            IntPutSet(IntPutKeening, infoContainer.SkillKeening);
            IntPutSet(IntPutKnowledge, infoContainer.SkillKnowledge);
            IntPutSet(IntPutMedicine, infoContainer.SkillMedicine);
            IntPutSet(IntPutStealth, infoContainer.SkillStealth);
            IntPutSet(IntPutSurvival, infoContainer.SkillSurvival);
            //load combat skills
            IntPutSet(IntPutArchery, infoContainer.SkillArchery);
            IntPutSet(IntPutFight, infoContainer.SkillFight);
            IntPutSet(IntPutMarksmanship, infoContainer.SkillMarksmanship);
            IntPutSet(IntPutMelee, infoContainer.SkillMelee);
            //load generic skills
            IntPutSet(IntPutGenericNatural, infoContainer.SkillGenericNatural);
            IntPutSet(IntPutGenericLearnt, infoContainer.SkillGenericLearnt);
            IntPutSet(IntPutGenericCombat, infoContainer.SkillGenericCombat);

            //load qualities and specialties
            WriteTextFromDictionary(RichTextQualities, infoContainer.Qualities);
            WriteTextFromDictionary(RichTextSpecialties, infoContainer.Specialties);

            //load Vitality data
            IntPutSet(IntPutMaxInjured, infoContainer.VitalityMaxInjured);
            IntPutSet(IntPutThresInjured, infoContainer.VitalityThresInjured);
            TextBoxMarkInjured.Text = infoContainer.VitalityMarkInjured;

            IntPutSet(IntPutMaxMauled, infoContainer.VitalityMaxMauled);
            IntPutSet(IntPutThresMauled, infoContainer.VitalityThresMauled);
            TextBoxMarkMauled.Text = infoContainer.VitalityMarkMauled;

            IntPutSet(IntPutMaxCritical, infoContainer.VitalityMaxCritical);
            IntPutSet(IntPutThresCritical, infoContainer.VitalityThresCritical);
            TextBoxMarkCritical.Text = infoContainer.VitalityMarkCritical;

            IntPutSet(IntPutMaxDeadly, infoContainer.VitalityMaxDeadly);
            IntPutSet(IntPutThresDeadly, infoContainer.VitalityThresDeadly);
            TextBoxMarkDeadly.Text = infoContainer.VitalityMarkDeadly;

            IntPutSet(IntPutThresOverkill, infoContainer.VitalityThresOverkill);
            TextBoxMarkOverkill.Text = infoContainer.VitalityMarkOverkill;

            IntPutSet(IntPutResilience, infoContainer.VitalityResilience);
            TextBoxResilience.Text = infoContainer.VitalityMarkResilience;

            //load nemmisary data:
            WriteTextFromDictionary(RichTextArrietta, infoContainer.NemmisaryArietta);
            TextBoxCreedName.Text = infoContainer.NemmisaryNameCreed;
            IntPutSet(IntPutCreed, infoContainer.NemmisaryAmountCreed);
            TextBoxSpiteName.Text = infoContainer.NemmisaryNameSpite;
            IntPutSet(IntPutSpite, infoContainer.NemmisaryAmountSpite);

            IntPutSet(IntPutAnimaLight, infoContainer.NemmisaryLightAnima);
            IntPutSet(IntPutAnimaNeutral, infoContainer.NemmisaryNeutralAnima);
            IntPutSet(IntPutAnimaDark, infoContainer.NemmisaryDarkAnima);

            CheckBoxSwitch.Checked = infoContainer.BroodIsBrood;
            IntPutSet(IntPutSynergy, infoContainer.BroodSynergy);

            //load inventory and combat:
            WriteTextFromDictionary(RichTextInventory, infoContainer.Inventory);
            WriteTextFromDictionary(RichTextCombat, infoContainer.Combat);

            UpdateError();

            //debug:
            //IntPutAnimaDark.Controls[0].Visible = false;
        }

        private void UpdateError() {
            //handle error message
            DataManager.DataType dataType;
            if(radioButtonMonster.Checked) {
                dataType = DataManager.DataType.Monsters;
            } else {
                dataType = DataManager.DataType.Modifications;
            }

            //check if text box needs to be displayed:
            bool displayError = Program.dataManager.NameExists(TextBoxName.Text, dataType);
            if(TextBoxName.Text.ToLower() == displayData.name.ToLower()) displayError = false;

            //display error
            LabelError.Visible = displayError;
        }

        private void SaveToDatabase() {
            //erase old data from database
            if(writeDirectly == false)Program.dataManager.Delete(displayData);
            

            //edit data with create form
            DataManager.DataType dataType;
            if(radioButtonMonster.Checked) {
                dataType = DataManager.DataType.Monsters;
            } else {
                dataType = DataManager.DataType.Modifications;
            }
            displayData.dataType = dataType;

            //deal with name and catagory:
            displayData.catagory = TextBoxCatagory.Text.Trim();
            displayData.name = TextBoxName.Text.Trim();
            displayData.description = RichTextDescription.Text.Trim();

            //save main stats
            InfoContainer infoContainer = displayData.infoContainer;
            infoContainer.MainStatBody = (int)IntPutBody.Value;
            infoContainer.MainStatConviction = (int)IntPutConviction.Value;
            infoContainer.MainStatCunning = (int)IntPutCunning.Value;
            infoContainer.MainStatPassion = (int)IntPutPassion.Value;
            infoContainer.MainStatReason = (int)IntPutReason.Value;
            infoContainer.MainStatProwess = (int)IntPutProwess.Value;
            infoContainer.MainStatFate = (int)IntPutFate.Value;
            infoContainer.MainStatFocus = (int)IntPutMaxFocus.Value;

            //save natural skills:
            infoContainer.SkillAthletics = (int)IntPutAthletics.Value;
            infoContainer.SkillAuthority = (int)IntPutAuthority.Value;
            infoContainer.SkillLogic = (int)IntPutLogic.Value;
            infoContainer.SkillPanache = (int)IntPutPanache.Value;
            infoContainer.SkillPerception = (int)IntPutPerception.Value;
            infoContainer.SkillResolve = (int)IntPutResolve.Value;

            //save learnt skills
            infoContainer.SkillCrafts = (int)IntPutCrafts.Value;
            infoContainer.SkillKeening = (int)IntPutKeening.Value;
            infoContainer.SkillKnowledge = (int)IntPutKnowledge.Value;
            infoContainer.SkillMedicine = (int)IntPutMedicine.Value;
            infoContainer.SkillStealth = (int)IntPutStealth.Value;
            infoContainer.SkillSurvival = (int)IntPutSurvival.Value;

            //save combat skills
            infoContainer.SkillArchery = (int)IntPutArchery.Value;
            infoContainer.SkillFight = (int)IntPutFight.Value;
            infoContainer.SkillMarksmanship = (int)IntPutMarksmanship.Value;
            infoContainer.SkillMelee = (int)IntPutMelee.Value;

            //save generic skills
            infoContainer.SkillGenericNatural = (int)IntPutGenericNatural.Value;
            infoContainer.SkillGenericLearnt = (int)IntPutGenericLearnt.Value;
            infoContainer.SkillGenericCombat = (int)IntPutGenericCombat.Value;

            //Save Qualities and specialties
            WriteTextToDictionary(RichTextQualities, infoContainer.Qualities);
            WriteTextToDictionary(RichTextSpecialties, infoContainer.Specialties);

            //save Vitality data
            infoContainer.VitalityMaxInjured = (int)IntPutMaxInjured.Value;
            infoContainer.VitalityThresInjured = (int)IntPutThresInjured.Value;
            infoContainer.VitalityMarkInjured = TextBoxMarkInjured.Text;

            infoContainer.VitalityMaxMauled = (int)IntPutMaxMauled.Value;
            infoContainer.VitalityThresMauled = (int)IntPutThresMauled.Value;
            infoContainer.VitalityMarkMauled = TextBoxMarkMauled.Text;

            infoContainer.VitalityMaxCritical = (int)IntPutMaxCritical.Value;
            infoContainer.VitalityThresCritical = (int)IntPutThresCritical.Value;
            infoContainer.VitalityMarkCritical = TextBoxMarkCritical.Text;

            infoContainer.VitalityMaxDeadly = (int)IntPutMaxDeadly.Value;
            infoContainer.VitalityThresDeadly = (int)IntPutThresDeadly.Value;
            infoContainer.VitalityMarkDeadly = TextBoxMarkDeadly.Text;

            infoContainer.VitalityThresOverkill = (int)IntPutThresOverkill.Value;
            infoContainer.VitalityMarkOverkill = TextBoxMarkOverkill.Text;

            infoContainer.VitalityResilience = (int)IntPutResilience.Value;
            infoContainer.VitalityMarkResilience = TextBoxResilience.Text;

            //save Nemmisary Data:
            WriteTextToDictionary(RichTextArrietta, infoContainer.NemmisaryArietta);
            infoContainer.NemmisaryNameCreed = TextBoxCreedName.Text;
            infoContainer.NemmisaryAmountCreed = (int)IntPutCreed.Value;
            infoContainer.NemmisaryNameSpite = TextBoxSpiteName.Text;
            infoContainer.NemmisaryAmountSpite = (int)IntPutSpite.Value;

            infoContainer.NemmisaryLightAnima = (int)IntPutAnimaLight.Value;
            infoContainer.NemmisaryNeutralAnima = (int)IntPutAnimaNeutral.Value;
            infoContainer.NemmisaryDarkAnima = (int)IntPutAnimaDark.Value;

            infoContainer.BroodIsBrood = CheckBoxSwitch.Checked;
            infoContainer.BroodSynergy = (int)IntPutSynergy.Value;

            //save inventory and combat:
            WriteTextToDictionary(RichTextInventory, infoContainer.Inventory);
            WriteTextToDictionary(RichTextCombat, infoContainer.Combat);

            //save data to database
            if(writeDirectly == false) Program.dataManager.Save(displayData);
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            if(TextBoxName.Text.Trim() == "") {
                LabelStatus.ForeColor = Color.Red;
                LabelStatus.Text = "Name Empty";
            } else {
                SaveToDatabase();
                LabelStatus.Text = "Save";
                SaveTimer.Enabled = true;
                Close();
            }
        }

        private void CreateMenu_Load(object sender, EventArgs e) {

        }

        private void TextBoxName_TextChanged(object sender, EventArgs e) {
            UpdateError();
            var textboxSender = (TextBox)sender;
            var cursorPosition = textboxSender.SelectionStart;
            textboxSender.Text = Regex.Replace(textboxSender.Text, "[^0-9a-zA-Z ]", "");
            textboxSender.SelectionStart = cursorPosition;
        }

        private void radioButtonMonster_CheckedChanged(object sender, EventArgs e) {
            UpdateError();
            if(radioButtonMonster.Checked) {
                CheckBoxVisibleCalc.Checked = true;
                IntPutAdd(IntPutAthletics, 1);
                IntPutAdd(IntPutAuthority, 1);
                IntPutAdd(IntPutLogic, 1);
                IntPutAdd(IntPutPanache, 1);
                IntPutAdd(IntPutPerception, 1);
                IntPutAdd(IntPutResolve, 1);
                lastEditState = true;
            }
        }

        private void radioButtonModifier_CheckedChanged(object sender, EventArgs e) {
            UpdateError();
            if(radioButtonModifier.Checked) {
                CheckBoxVisibleCalc.Checked = false;
                IntPutAdd(IntPutAthletics, -1);
                IntPutAdd(IntPutAuthority, -1);
                IntPutAdd(IntPutLogic, -1);
                IntPutAdd(IntPutPanache, -1);
                IntPutAdd(IntPutPerception, -1);
                IntPutAdd(IntPutResolve, -1);
                lastEditState = false;
            }

        }

        private void buttonLoad_Click(object sender, EventArgs e) {
            UpdateDisplay();
            LabelStatus.ForeColor = Color.Green;
            LabelStatus.Text = "Reverted";
            SaveTimer.Enabled = true;
        }



        //utility methods:
        //sets intput while respecting its min and max values
        private void IntPutSet(NumericUpDown field, int input) {
            field.Value = Math.Max(Math.Min(input, field.Maximum), field.Minimum);
        }

        //adds to the IntPut while respecting its min and max values
        private void IntPutAdd(NumericUpDown input, int number) {
            number += (int)input.Value;
            IntPutSet(input, number);
        }

        private void WriteTextFromDictionary(RichTextBox textBox, Dictionary<string, int> dictionary) {
            textBox.Clear();
            foreach(string keyString in dictionary.Keys) {
                int amount = dictionary[keyString];
                if(keyString.Trim() == "") continue;
                if(mergeDictionary) {
                    if(amount > 1) {
                        textBox.Text += keyString + " (x" + amount + ")\n";
                    } else {
                        textBox.Text += keyString + "\n";
                    }
                } else {
                    for(int i = 0; i < amount; i++) {
                        textBox.Text += keyString + "\n";
                    }
                }
                
            }
        }

        private void WriteTextToDictionary(RichTextBox textBox, Dictionary<string, int> dictionary) {
            dictionary.Clear();
            foreach(string currentString in textBox.Text.Split(Environment.NewLine.ToCharArray())) {
                if(currentString.Trim() == "") continue;
                if(dictionary.ContainsKey(currentString)) {
                    dictionary[currentString] += 1;
                } else {
                    dictionary.Add(currentString, 1);
                }
            }
        }









        //Skill calculation events:



        //sets all caluclation labels visible or invisible:
        private void SetAllCalcVisible(bool state) {
            LabelAthleticsCalc.Visible = state;
            LabelAuthorityCalc.Visible = state;
            LabelLogicCalc.Visible = state;
            LabelPanacheCalc.Visible = state;
            LabelPerceptionCalc.Visible = state;
            LabelResolveCalc.Visible = state;
            LabelCraftsCalc.Visible = state;
            LabelKeeningCalc.Visible = state;
            LabelKnowledgeCalc.Visible = state;
            LabelMedicineCalc.Visible = state;
            LabelStealthCalc.Visible = state;
            LabelSurvivalCalc.Visible = state;
            LabelArcheryCalc.Visible = state;
            LabelFightCalc.Visible = state;
            LabelMarksmanshipCalc.Visible = state;
            LabelMeleeCalc.Visible = state;
        }

        //generic calculation method
        private void CalculateDisplay(NumericUpDown input, Label display) {
            if(input.Value == 0) {
                display.Text = "2x 6+";
            } else {
                display.Text = (7 - input.Value) + "+";
            }
        }

        private void IntPutSkillAthletics_ValueChanged(object sender, EventArgs e) {
            CalculateDisplay(IntPutAthletics, LabelAthleticsCalc);
            if(readOnly) {
                UpdateDisplay();
            }
        }

        private void IntPutAuthority_ValueChanged(object sender, EventArgs e) {
            CalculateDisplay(IntPutAuthority, LabelAuthorityCalc);
            if(readOnly) {
                UpdateDisplay();
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e) {
            CalculateDisplay(IntPutLogic, LabelLogicCalc);
            if(readOnly) {
                UpdateDisplay();
            }
        }

        private void IntPutPanache_ValueChanged(object sender, EventArgs e) {
            CalculateDisplay(IntPutPanache, LabelPanacheCalc);
            if(readOnly) {
                UpdateDisplay();
            }
        }

        private void IntPutPerception_ValueChanged(object sender, EventArgs e) {
            CalculateDisplay(IntPutPerception, LabelPerceptionCalc);
            if(readOnly) {
                UpdateDisplay();
            }
        }

        private void IntPutResolve_ValueChanged(object sender, EventArgs e) {
            CalculateDisplay(IntPutResolve, LabelResolveCalc);
            if(readOnly) {
                UpdateDisplay();
            }
        }

        private void IntPutCrafts_ValueChanged(object sender, EventArgs e) {
            CalculateDisplay(IntPutCrafts, LabelCraftsCalc);
            if(readOnly) {
                UpdateDisplay();
            }
        }

        private void IntPutKeening_ValueChanged(object sender, EventArgs e) {
            CalculateDisplay(IntPutKeening, LabelKeeningCalc);
            if(readOnly) {
                UpdateDisplay();
            }
        }

        private void IntPutKnowledge_ValueChanged(object sender, EventArgs e) {
            CalculateDisplay(IntPutKnowledge, LabelKnowledgeCalc);
            if(readOnly) {
                UpdateDisplay();
            }
        }

        private void IntPutMedicine_ValueChanged(object sender, EventArgs e) {
            CalculateDisplay(IntPutMedicine, LabelMedicineCalc);
            if(readOnly) {
                UpdateDisplay();
            }
        }

        private void IntPutStealth_ValueChanged(object sender, EventArgs e) {
            CalculateDisplay(IntPutStealth, LabelStealthCalc);
            if(readOnly) {
                UpdateDisplay();
            }
        }

        private void IntPutSurvival_ValueChanged(object sender, EventArgs e) {
            CalculateDisplay(IntPutSurvival, LabelSurvivalCalc);
            if(readOnly) {
                UpdateDisplay();
            }
        }

        private void IntPutArchery_ValueChanged(object sender, EventArgs e) {
            CalculateDisplay(IntPutArchery, LabelArcheryCalc);
            if(readOnly) {
                UpdateDisplay();
            }
        }

        private void IntPutFight_ValueChanged(object sender, EventArgs e) {
            CalculateDisplay(IntPutFight, LabelFightCalc);
            if(readOnly) {
                UpdateDisplay();
            }
        }

        private void IntPutMarksmanship_ValueChanged(object sender, EventArgs e) {
            CalculateDisplay(IntPutMarksmanship, LabelMarksmanshipCalc);
            if(readOnly) {
                UpdateDisplay();
            }
        }

        private void IntPutMelee_ValueChanged(object sender, EventArgs e) {
            CalculateDisplay(IntPutMelee, LabelMeleeCalc); 
            if(readOnly) {
                UpdateDisplay();
            }
        }

        private void CheckBoxVisibleCalc_CheckedChanged(object sender, EventArgs e) {
            SetAllCalcVisible(CheckBoxVisibleCalc.Checked);
        }

        private void ButtonCalculate_Click(object sender, EventArgs e) {
            IntPutMaxFocus.Value = displayData.infoContainer.CalculateFocus((int)IntPutFate.Value, (int)IntPutConviction.Value, (int)IntPutCunning.Value);
        }

        private void SaveTimer_Tick(object sender, EventArgs e) {
            SaveTimer.Enabled = false;
            LabelStatus.ForeColor = Color.Green;
            LabelStatus.Text = "";
        }

        private void panelVitality_Paint(object sender, PaintEventArgs e) {
            Pen pen = new Pen(Color.Black);
            //pen.DashPattern = new float[] { 4.0F, 4.0F};
            pen.Width = 1;

            //general pen settings:
            int lenght = 141;

            //make a line for maximum:
            Point location = LabelVitalityMaximum.Location;
            int xOffset = 30;
            e.Graphics.DrawLine(pen, location.X + xOffset, location.Y, location.X + xOffset, location.Y + lenght);

            //make line for threshold
            location = LabelVitalityThreshold.Location;
            xOffset = 30;
            e.Graphics.DrawLine(pen, location.X + xOffset, location.Y, location.X + xOffset, location.Y + lenght);

            //make line for mark
            location = LabelVitalityMark.Location;
            xOffset = 15;
            e.Graphics.DrawLine(pen, location.X + xOffset, location.Y, location.X + xOffset, location.Y + lenght);


            //change width:
            pen.Width = 1;
            lenght = 180;
            xOffset = 40;

            //make line for injured:
            location = LabelInjured.Location;
            int yoffset = 9;
            e.Graphics.DrawLine(pen, xOffset, location.Y + yoffset, xOffset + lenght, location.Y + yoffset);

            //make line for mauled:
            location = LabelMauled.Location;
            yoffset = 9;
            e.Graphics.DrawLine(pen, xOffset, location.Y + yoffset, xOffset + lenght, location.Y + yoffset);

            //make line for Critical:
            location = LabelCritical.Location;
            yoffset = 9;
            e.Graphics.DrawLine(pen, xOffset, location.Y + yoffset, xOffset + lenght, location.Y + yoffset);

            //make line for Deadly:
            location = LabelDeadly.Location;
            yoffset = 9;
            e.Graphics.DrawLine(pen, xOffset, location.Y + yoffset, xOffset + lenght, location.Y + yoffset);

            //make line for Overkill:
            location = LabelOverkill.Location;
            yoffset = 9;
            e.Graphics.DrawLine(pen, xOffset, location.Y + yoffset, xOffset + lenght, location.Y + yoffset);
            pen.Dispose();
        }

        private void ButtonVitalityCalculate_Click(object sender, EventArgs e) {
            //calculates vitality based on displayed numbers
            InfoContainer infoContainer = displayData.infoContainer;

            //calculate maximum:
            IntPutSet(IntPutMaxInjured, infoContainer.CalculateVitality(true, 0, (int)IntPutConviction.Value));
            IntPutSet(IntPutMaxMauled, infoContainer.CalculateVitality(true, 1, (int)IntPutConviction.Value));
            IntPutSet(IntPutMaxCritical, infoContainer.CalculateVitality(true, 2, (int)IntPutConviction.Value));
            IntPutSet(IntPutMaxDeadly, infoContainer.CalculateVitality(true, 3, (int)IntPutConviction.Value));

            //calculate Threshold:
            IntPutSet(IntPutThresInjured, infoContainer.CalculateVitality(false, 0, (int)IntPutBody.Value));
            IntPutSet(IntPutThresMauled, infoContainer.CalculateVitality(false, 1, (int)IntPutBody.Value));
            IntPutSet(IntPutThresCritical, infoContainer.CalculateVitality(false, 2, (int)IntPutBody.Value));
            IntPutSet(IntPutThresDeadly, infoContainer.CalculateVitality(false, 3, (int)IntPutBody.Value));
            IntPutSet(IntPutThresOverkill, infoContainer.CalculateVitality(false, 4, (int)IntPutBody.Value));
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void CheckBoxSwitch_CheckedChanged(object sender, EventArgs e) {
            //switch brood and nemmesary
            LabelCreedName.Visible = !CheckBoxSwitch.Checked;
            TextBoxCreedName.Visible = !CheckBoxSwitch.Checked;
            LabelCreedAmount.Visible = !CheckBoxSwitch.Checked;
            IntPutCreed.Visible = !CheckBoxSwitch.Checked;

            LabelSpite.Visible = !CheckBoxSwitch.Checked;
            LabelSpiteName.Visible = !CheckBoxSwitch.Checked;
            TextBoxSpiteName.Visible = !CheckBoxSwitch.Checked;
            LabelSpiteAmount.Visible = !CheckBoxSwitch.Checked;
            IntPutSpite.Visible = !CheckBoxSwitch.Checked;

            //switch skills for generic:
            PanelSkillsNatural.Visible = !CheckBoxSwitch.Checked;
            PanelSkillsLearnt.Visible = !CheckBoxSwitch.Checked;
            PanelSkillsCombat.Visible = !CheckBoxSwitch.Checked;
            CheckBoxVisibleCalc.Visible = !CheckBoxSwitch.Checked;

            IntPutGenericNatural.Visible = CheckBoxSwitch.Checked;
            IntPutGenericLearnt.Visible = CheckBoxSwitch.Checked;
            IntPutGenericCombat.Visible = CheckBoxSwitch.Checked;

            if(CheckBoxSwitch.Checked) {
                LabelNemmisarys.Text = "Brood:";
                LabelCreed.Text = "Synergy:";
            } else {
                LabelNemmisarys.Text = "Nemmisarys:";
                LabelCreed.Text = "Creed:";
            }

            LabelSynergyAmount.Visible = CheckBoxSwitch.Checked;
            IntPutSynergy.Visible = CheckBoxSwitch.Checked;
        }



        //makes ALL input fields read only and removes the save and load button
        private void AllowWriting(bool state) {
            //buttons:
            buttonSave.Visible = state;
            buttonLoad.Visible = state;
            ButtonCalculate.Visible = state;
            ButtonVitalityCalculate.Visible = state;

            //main stats:
            setInputFieldWriting(IntPutBody, state);
            setInputFieldWriting(IntPutConviction, state);
            setInputFieldWriting(IntPutCunning, state);
            setInputFieldWriting(IntPutPassion, state);
            setInputFieldWriting(IntPutReason, state);
            setInputFieldWriting(IntPutProwess, state);
            setInputFieldWriting(IntPutFate, state);
            setInputFieldWriting(IntPutMaxFocus, state);

            //natural skills
            setInputFieldWriting(IntPutAthletics, state);
            setInputFieldWriting(IntPutAuthority, state);
            setInputFieldWriting(IntPutLogic, state);
            setInputFieldWriting(IntPutPanache, state);
            setInputFieldWriting(IntPutPerception, state);
            setInputFieldWriting(IntPutResolve, state);

            //learnt skills
            setInputFieldWriting(IntPutCrafts, state);
            setInputFieldWriting(IntPutKeening, state);
            setInputFieldWriting(IntPutKnowledge, state);
            setInputFieldWriting(IntPutMedicine, state);
            setInputFieldWriting(IntPutStealth, state);
            setInputFieldWriting(IntPutSurvival, state);

            //Combat Skills:
            setInputFieldWriting(IntPutArchery, state);
            setInputFieldWriting(IntPutFight, state);
            setInputFieldWriting(IntPutMarksmanship, state);
            setInputFieldWriting(IntPutMelee, state);

            //Generic Skills:
            setInputFieldWriting(IntPutGenericNatural, state);
            setInputFieldWriting(IntPutGenericLearnt, state);
            setInputFieldWriting(IntPutGenericCombat, state);

            //Vitality:
            setInputFieldWriting(IntPutMaxInjured, state);
            setInputFieldWriting(IntPutThresInjured, state);
            TextBoxMarkInjured.ReadOnly = !state;
            setInputFieldWriting(IntPutMaxMauled, state);
            setInputFieldWriting(IntPutThresMauled, state);
            TextBoxMarkMauled.ReadOnly = !state;
            setInputFieldWriting(IntPutMaxCritical, state);
            setInputFieldWriting(IntPutThresCritical, state);
            TextBoxMarkCritical.ReadOnly = !state;
            setInputFieldWriting(IntPutMaxDeadly, state);
            setInputFieldWriting(IntPutThresDeadly, state);
            TextBoxMarkDeadly.ReadOnly = !state;
            setInputFieldWriting(IntPutThresOverkill, state);
            TextBoxMarkOverkill.ReadOnly = !state;
            setInputFieldWriting(IntPutResilience, state);
            TextBoxResilience.ReadOnly = !state;

            //nemmisary:
            setInputFieldWriting(IntPutCreed, state);
            setInputFieldWriting(IntPutSpite, state);
            setInputFieldWriting(IntPutAnimaDark, state);
            setInputFieldWriting(IntPutAnimaLight, state);
            setInputFieldWriting(IntPutAnimaNeutral, state);
            RichTextArrietta.ReadOnly = !state;
            TextBoxCreedName.ReadOnly = !state;
            TextBoxSpiteName.ReadOnly = !state;
            setInputFieldWriting(IntPutSynergy, state);

            //text fields;

            RichTextQualities.ReadOnly = !state;
            RichTextSpecialties.ReadOnly = !state;
            RichTextInventory.ReadOnly = !state;
            RichTextCombat.ReadOnly = !state;
            TextBoxName.ReadOnly = !state;
            TextBoxCatagory.ReadOnly = !state;
            RichTextDescription.ReadOnly = !state;
            CheckBoxSwitch.Visible = state;
            radioButtonModifier.Visible = state;
            radioButtonMonster.Visible = state;

        }

        private void setInputFieldWriting(NumericUpDown intPut,bool state) {
            intPut.ReadOnly = !state;
            intPut.Controls[0].Enabled = state;
        }

        private void ValueChangedKeyBlocker(object sender, EventArgs e) {
            if(readOnly) {
                UpdateDisplay();
            }
        }

        private void TextBoxCatagory_TextChanged(object sender, EventArgs e) {

        }
    }
}
