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

    //Loads all data as a list and lets the user scroll though it. 
    public partial class ListMenu : Form {


        DataBaseClass selectedObject = null;


        public ListMenu() {
            InitializeComponent();

            CalculateListResult();
            UpdateSelected();
        }

        private void CalculateListResult() {
            //reset list box
            ListBoxResults.Items.Clear();

            //fill list box with results
            if(RadioButtonMonster.Checked) {
                fillListBox(DataManager.DataType.Monsters);
            }
            if(RadioButtonModification.Checked) {
                fillListBox(DataManager.DataType.Modifications);
            }


        }

        private void fillListBox(DataManager.DataType dataType) {
            foreach(string text in Program.dataManager.GetNameList(dataType)) {
                if(text.ToLower().Contains(TextBoxSearch.Text.ToLower())) {
                    ListBoxResults.Items.Add(text);// + ": " + dataType);
                }
            }
        }


        //update selected type and updates the screen

        private void UpdateSelected() {
            if(ListBoxResults.SelectedItem == null) {
                //no item was selected!
                ButtonErase.Enabled = false;
                ButtonEditor.Enabled = false;
                ButtonConfirm.Visible = false;
                LabelWarning.Visible = false;
                LabelNameEnter.Text = "";
                LabelTypeEnter.Text = "";
                LabelCatagoryEnter.Text = "";
                selectedObject = null;
                return;
            }
            //item was selected. enable edit buttons
            ButtonErase.Enabled = true;
            ButtonEditor.Enabled = true;

            //make confirm button and warning invisisble
            ButtonConfirm.Visible = false;
            LabelWarning.Visible = false;

            //fill text info and load current loaded object to memory:
            string objectName = ListBoxResults.SelectedItem.ToString();
            LabelNameEnter.Text = objectName;
            if(RadioButtonMonster.Checked) {
                LabelTypeEnter.Text = "Monster";
                selectedObject = Program.dataManager.Load(objectName, DataManager.DataType.Monsters);
            } else {
                LabelTypeEnter.Text = "Modifier";
                selectedObject = Program.dataManager.Load(objectName, DataManager.DataType.Modifications);
            }
            RichTextDescription.Text = selectedObject.description;
            LabelCatagoryEnter.Text = selectedObject.catagory;
        }




        private void ListMenu_Load(object sender, EventArgs e) {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateSelected();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e) {
            //listen for text changes
            CalculateListResult();
        }

        private void ButtonClear_Click(object sender, EventArgs e) {
            TextBoxSearch.Text = "";
            ListBoxResults.ClearSelected();
        }

        private void RefreshList(object sender, EventArgs e) {
            CalculateListResult();
        }


        //erases the selected object after confirm
        private void ButtonErase_Click(object sender, EventArgs e) {
            ButtonConfirm.Visible = true;
            LabelWarning.Visible = true;
        }

        private void ButtonConfirm_Click(object sender, EventArgs e) {
            Program.dataManager.Delete(selectedObject);
            CalculateListResult();
            UpdateSelected();
        }

        private void ButtonEditor_Click(object sender, EventArgs e) {
            new CreateMenu(selectedObject).ShowDialog();
            CalculateListResult();
            UpdateSelected();
        }

        private void ListBoxResults_DoubleClick(object sender, EventArgs e) {
            if(selectedObject != null) {
                new CreateMenu(selectedObject).ShowDialog();
                CalculateListResult();
                UpdateSelected();
            }
        }
    }
}
