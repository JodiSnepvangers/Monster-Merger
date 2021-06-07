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
    public partial class MergeMenu : Form {

        //global variables:
        DataBaseClass selectedMonster = null; //the current selected monster for the main list. this is were the base of the calculations start
        List<DataBaseClass> modList = new List<DataBaseClass>(); //the current mod list. is index sensitive

        DataBaseClass currentSelection = null; //currently selected item in the mod list. can be both a mod and a monster



        InfoContainer results = null; //results of last recalculation. should be set to null to recalculate

        DataBaseClass finalModifier = null;





        public MergeMenu() {
            InitializeComponent();
            //load database into combo box
            UpdateCatagoryBoxes(ComboMonsterCatagory, DataManager.DataType.Monsters);
            UpdateCatagoryBoxes(ComboAddModCatagory, DataManager.DataType.Modifications);

            //update main list
            UpdateMainList();


        }

        //updates the combo boxes. takes catagories into account. having a string of nothing allows everything
        private void UpdateComboBoxes(ComboBox control, ComboBox catagory, DataManager.DataType dataType) {
            //add data after clearing
            control.Items.Clear();
            foreach(string data in Program.dataManager.GetNameList(dataType)) {
                DataBaseClass dataObj = Program.dataManager.Load(data, dataType);

                //get catagory. test for null!
                string catagoryString = "All";
                if(catagory.SelectedItem != null) {
                    catagoryString = catagory.SelectedItem.ToString();
                }

                //check if catagory is correct. if "All", ignore check and save
                if(dataObj.catagory.Replace(" ", "").ToLower() == catagoryString.Replace(" ", "").ToLower() || catagoryString == "All"){
                    //string was correct. add data to name box
                    control.Items.Add(data);
                }
                
            }
            SelectFirstItem(control);
        }

        private void UpdateCatagoryBoxes(ComboBox catagory, DataManager.DataType dataType) {
            //add catagories:
            catagory.Items.Clear();
            catagory.Items.Add("All");
            foreach(string data in Program.dataManager.GetCatagoryList(dataType)) {

                if(data.Replace(" ", "").ToLower() != "all") {//filters out all the variants of 'all'
                    catagory.Items.Add(data);
                }
            }
            catagory.SelectedItem = "All";
        }

        private void SelectFirstItem(ComboBox control) {
            if(control.Items.Count > 0) {
                control.SelectedIndex = 0;
            }
        }

        private void ComboCatagoryMonster_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateComboBoxes(ComboMonsterName, ComboMonsterCatagory, DataManager.DataType.Monsters);
        }

        private void ComboAddModCatagory_SelectedIndexChanged(object sender, EventArgs e) {

            UpdateComboBoxes(ComboAddModName, ComboAddModCatagory, DataManager.DataType.Modifications);
        }

        private void ComboAddModName_SelectedIndexChanged(object sender, EventArgs e) {
            //load mod from database:
            DataBaseClass preparedData = Program.dataManager.Load(ComboAddModName.Text, DataManager.DataType.Modifications);

            //load description:
            RichTextAddModDescription.Text = preparedData.description;
        }

        private void ComboLoadPreset_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void ComboMonsterName_SelectedIndexChanged(object sender, EventArgs e) {
            //load mod from database:
            DataBaseClass preparedData = Program.dataManager.Load(ComboMonsterName.Text, DataManager.DataType.Monsters);

            //load description:
            RichTextMonsterDescription.Text = preparedData.description;
        }




        //list utilities:
        private void UpdateMainList() {
            ListMods.Items.Clear(); //ensures a clean list!
            results = null; //results are now invalid!
            if(selectedMonster == null) {
                ListMods.Items.Add("Please select a monster first!");
                ListMods.Enabled = false;
                setListButtonState(0);
                ButtonLoadPreset.Enabled = false;
                ButtonSavePreset.Enabled = false;
                ButtonRemovePreset.Enabled = false;
                ComboPreset.Enabled = false;
                ButtonSimplifiedMerge.Enabled = false;
                ButtonFullMerge.Enabled = false;
                ButtonAddMod.Enabled = false;
            } else {
                //enable list and start filling it with data
                ListMods.Enabled = true;
                ButtonAddMod.Enabled = true;
                ButtonLoadPreset.Enabled = true;
                ButtonSavePreset.Enabled = true;
                ComboPreset.Enabled = true;
                ButtonRemovePreset.Enabled = true;
                ButtonSimplifiedMerge.Enabled = true;
                ButtonFullMerge.Enabled = true;
                ListMods.Items.Add("Base: " + selectedMonster.name); //sets first index to monster name
            }


            //now add mods to list in order of calculation
            int index = 0; //keeps track of the order number
            foreach(DataBaseClass data in modList) {
                index++;
                ListMods.Items.Add(index + ": " + data.name);
            }

            //add final modifier:
            if(finalModifier != null) {
                ListMods.Items.Add("Final Modifier");
            }

            //ensure options are up to date:
            UpdateSelectedOptions();
        }

        //disables or enables list buttons depending on the state given:
        //0: all buttons are disabled
        //1: all but the edit and view buttons are disabled
        //2: all buttons are enabled

        private void setListButtonState(int state) {
            switch(state) {
                case 0:
                    ButtonOptionsEdit.Enabled = false;
                    ButtonOptionsView.Enabled = false;
                    ButtonOptionsMoveUp.Enabled = false;
                    ButtonOptionsMoveDown.Enabled = false;
                    ButtonOptionsRemove.Enabled = false;
                    break;
                case 1:
                    ButtonOptionsEdit.Enabled = true;
                    ButtonOptionsView.Enabled = true;
                    ButtonOptionsMoveUp.Enabled = false;
                    ButtonOptionsMoveDown.Enabled = false;
                    ButtonOptionsRemove.Enabled = true;
                    break;
                case 2:
                    ButtonOptionsEdit.Enabled = true;
                    ButtonOptionsView.Enabled = true;
                    ButtonOptionsMoveUp.Enabled = true;
                    ButtonOptionsMoveDown.Enabled = true;
                    ButtonOptionsRemove.Enabled = true;
                    break;
            }
        }

        private void ButtonSetMonster_Click(object sender, EventArgs e) {
            //saves monster to selected monster variable
            selectedMonster = Program.dataManager.Load(ComboMonsterName.Text, DataManager.DataType.Monsters);
            finalModifier = new DataBaseClass(DataManager.DataType.Modifications);
            UpdateMainList();

            UpdatePresetBox();
        }

        private void UpdatePresetBox() {
            //update preset list:
            ComboPreset.Items.Clear();
            foreach(string keyString in selectedMonster.PresetLibary.Keys) {
                ComboPreset.Items.Add(keyString);
            }
        }

        private void ButtonAddMod_Click(object sender, EventArgs e) {
            //adds a new modifier to the current
            if(ListMods.Enabled == false) return; //if mod list is not available, dont do anything
            modList.Add(Program.dataManager.Load(ComboAddModName.Text, DataManager.DataType.Modifications));
            UpdateMainList();
        }

        private void ListMods_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateSelectedOptions();
        }

        private void UpdateSelectedOptions() {
            int selectedIndex = ListMods.SelectedIndex; //the currently selected index
            if(selectedIndex == 0) {
                //the base monster was selected!
                setListButtonState(1);
                currentSelection = selectedMonster;
            } else if(selectedIndex == -1) {
                // nothing was selected!
                setListButtonState(0);
                currentSelection = null;

            } else if(selectedIndex == ListMods.Items.Count - 1) {
                // final was selected!
                setListButtonState(1);
                currentSelection = finalModifier;
            } else {
                //a mod was selected!
                setListButtonState(2);
                currentSelection = modList[selectedIndex - 1];
            }


            //set status test
            if(currentSelection == null) {
                LabelModSelectedName.Text = "Please select a modifier in the list.";
            } else {
                LabelModSelectedName.Text = "Name:" + currentSelection.name;
                if(currentSelection.catagory.Replace(" ", "") != "") LabelModSelectedName.Text += ". Catagory: " +  currentSelection.catagory + ".";
            }
        }

        private void ButtonOptionsMoveUp_Click(object sender, EventArgs e) {
            int currentIndex = ListMods.SelectedIndex - 1;
            if(currentIndex <= 0) return;
            MoveElementInList(modList, currentIndex, currentIndex - 1);
            UpdateMainList();
            ListMods.SelectedIndex = currentIndex;
        }

        private void ButtonOptionsMoveDown_Click(object sender, EventArgs e) {
            int currentIndex = ListMods.SelectedIndex - 1;
            if(currentIndex + 2 > modList.Count) return;
            MoveElementInList(modList, currentIndex, currentIndex + 1);
            UpdateMainList();
            if(currentIndex + 2 >= ListMods.Items.Count) {
                ListMods.SelectedIndex = ListMods.Items.Count - 1;
            } else {
                ListMods.SelectedIndex = currentIndex + 2;
            }

        }



        private void MoveElementInList(List<DataBaseClass> list, int oldIndex, int newIndex) {
            if(oldIndex < 0 || oldIndex > list.Count) return;//ensures oldIndex is within range
            if(newIndex < 0 || newIndex > list.Count) return;//ensures newIndex is within range

            //retrieve object for safe keeping
            DataBaseClass takenObj = list[oldIndex];

            //remove object at old location:
            list.RemoveAt(oldIndex);

            //insert object at new location
            if(newIndex > list.Count) {
                //new location was out of list. add it to end instead
                list.Add(takenObj);
            } else {
                list.Insert(newIndex, takenObj);
            }
        }

        private void ButtonOptionsRemove_Click(object sender, EventArgs e) {
            if(ListMods.SelectedIndex == 0) {
                selectedMonster = null;
            } else if(ListMods.SelectedIndex == ListMods.Items.Count - 1) {
                finalModifier = new DataBaseClass(DataManager.DataType.Modifications);
            } else {
                modList.Remove(currentSelection);
            }
            UpdateMainList();
        }

        private void ButtonOptionsEdit_Click(object sender, EventArgs e) {
            if(currentSelection == finalModifier) {
                new CreateMenu(currentSelection.infoContainer, true).ShowDialog();
            } else {
                new CreateMenu(currentSelection).ShowDialog();
                UpdateCatagoryBoxes(ComboMonsterCatagory, DataManager.DataType.Monsters);
                UpdateCatagoryBoxes(ComboAddModCatagory, DataManager.DataType.Modifications);
                UpdateMainList();
            }

        }

        private void ButtonOptionsView_Click(object sender, EventArgs e) {
            new SimpleView(currentSelection).ShowDialog();
        }

        private void ButtonSimplifiedMerge_Click(object sender, EventArgs e) {
            if(selectedMonster == null) return;
            startMerging();
            new SimpleView(selectedMonster, results).ShowDialog();
        }

        //handles the merging of data
        private void startMerging() {
            InfoContainer baseInfo = selectedMonster.infoContainer.merge(null);
            MergeAll(baseInfo);

            //if vitality needs recalculating, recalculate, then do all merging again and just add vitality
            //TODO: split up merging into multiple functions inside infocontainer
            if(CheckRecalcVitality.Checked) {
                baseInfo.CalculateVitality();
                MergeAll(new InfoContainer()).mergeVitality(baseInfo); //adds only vitality data after calculating what all mods add-
            }
            if(CheckRecalcFocus.Checked) {
                baseInfo.MainStatFocus = baseInfo.CalculateFocus();
                MergeAll(new InfoContainer()).mergeFocus(baseInfo); //adds only focus data after calculating what all mods add-
            }

            results = baseInfo;
        }

        //do all calculations. merges the monster and mods together and returns it
        private InfoContainer MergeAll(InfoContainer info) {
            foreach(DataBaseClass data in modList) {
                data.infoContainer.merge(info);
            }
            //merge with final
            if(finalModifier != null) finalModifier.infoContainer.merge(info);
            return info;
        }

        private void ButtonFullMerge_Click(object sender, EventArgs e) {
            if(selectedMonster == null) return;
            startMerging();
            new CreateMenu(selectedMonster, results).ShowDialog();
        }

        private void ButtonLoadPreset_Click(object sender, EventArgs e) {
            if(ComboPreset.Text.Trim() == "") return; //invalid was loaded
            if(selectedMonster.PresetLibary.ContainsKey(ComboPreset.Text.Trim()) == false) return; //invalid was loaded
            //atempt to load preset:
            bool loadFail = false;
            modList.Clear();
            foreach(string currentModifier in selectedMonster.PresetLibary[ComboPreset.Text.Trim()].ModifierList) {
                DataBaseClass loadedData = Program.dataManager.Load(currentModifier, DataManager.DataType.Modifications);
                if(loadedData == null) {
                    loadFail = true;
                } else {
                    modList.Add(loadedData);
                }
                this.finalModifier.infoContainer = selectedMonster.PresetLibary[ComboPreset.Text.Trim()].finalContainer;
            }

            //all data was loaded. see if error message needs to be shown:
            if(loadFail) {
                MessageBox.Show("One or multiple modifiers failed to be loaded.\nThis can be caused because they were renamed or removed", "Preset Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateMainList();
        }

        private void ButtonSavePreset_Click(object sender, EventArgs e) {
            if(ComboPreset.Text.Trim() == "") return; //invalid was loaded
            if(selectedMonster.PresetLibary.ContainsKey(ComboPreset.Text.Trim()) == false) {
                selectedMonster.PresetLibary.Add(ComboPreset.Text.Trim(), new Preset());
            }
            List<string> saveList = selectedMonster.PresetLibary[ComboPreset.Text.Trim()].ModifierList;
            saveList.Clear();
            //attempt to save preset
            foreach(DataBaseClass currentMod in modList){
                saveList.Add(currentMod.name);
            }
            selectedMonster.PresetLibary[ComboPreset.Text.Trim()].finalContainer = finalModifier.infoContainer;
        }

        private void ButtonRemovePreset_Click(object sender, EventArgs e) {
            if(ComboPreset.Text.Trim() == "") return; //invalid was loaded
            if(selectedMonster.PresetLibary.ContainsKey(ComboPreset.Text.Trim()) == false)return;

            selectedMonster.PresetLibary.Remove(ComboPreset.Text.Trim());
            UpdatePresetBox();
            ComboPreset.Text = "";
        }

        private void MergeMenu_Load(object sender, EventArgs e) {

        }
    }
}
