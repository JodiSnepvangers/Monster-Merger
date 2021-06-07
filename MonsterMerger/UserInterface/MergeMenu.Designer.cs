namespace MonsterMerger.UserInterface {
    partial class MergeMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MergeMenu));
            this.ListMods = new System.Windows.Forms.ListBox();
            this.LabelMods = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonAddMod = new System.Windows.Forms.Button();
            this.RichTextAddModDescription = new System.Windows.Forms.RichTextBox();
            this.LabelAddModDescription = new System.Windows.Forms.Label();
            this.LabelAddModCatagory = new System.Windows.Forms.Label();
            this.ComboAddModCatagory = new System.Windows.Forms.ComboBox();
            this.LabelAddModName = new System.Windows.Forms.Label();
            this.ComboAddModName = new System.Windows.Forms.ComboBox();
            this.LabelAddMod = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButtonOptionsMoveDown = new System.Windows.Forms.Button();
            this.ButtonOptionsMoveUp = new System.Windows.Forms.Button();
            this.ButtonUnused = new System.Windows.Forms.Button();
            this.ButtonOptionsRemove = new System.Windows.Forms.Button();
            this.ButtonOptionsEdit = new System.Windows.Forms.Button();
            this.ButtonOptionsView = new System.Windows.Forms.Button();
            this.LabelModSelectedName = new System.Windows.Forms.Label();
            this.LabelModOptions = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CheckRecalcFocus = new System.Windows.Forms.CheckBox();
            this.CheckRecalcVitality = new System.Windows.Forms.CheckBox();
            this.ButtonSimplifiedMerge = new System.Windows.Forms.Button();
            this.ButtonFullMerge = new System.Windows.Forms.Button();
            this.LabelFinalCalcDescription = new System.Windows.Forms.Label();
            this.LabelMergeCalc = new System.Windows.Forms.Label();
            this.LabelSetMonster = new System.Windows.Forms.Label();
            this.LabelCatagorySetMonster = new System.Windows.Forms.Label();
            this.ComboMonsterCatagory = new System.Windows.Forms.ComboBox();
            this.LabelNameSetMonster = new System.Windows.Forms.Label();
            this.ComboMonsterName = new System.Windows.Forms.ComboBox();
            this.ButtonSetMonster = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonRemovePreset = new System.Windows.Forms.Button();
            this.ButtonSavePreset = new System.Windows.Forms.Button();
            this.ButtonLoadPreset = new System.Windows.Forms.Button();
            this.LabelNameLoadPreset = new System.Windows.Forms.Label();
            this.LabelPresets = new System.Windows.Forms.Label();
            this.ComboPreset = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.RichTextMonsterDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListMods
            // 
            resources.ApplyResources(this.ListMods, "ListMods");
            this.ListMods.FormattingEnabled = true;
            this.ListMods.Name = "ListMods";
            this.ListMods.SelectedIndexChanged += new System.EventHandler(this.ListMods_SelectedIndexChanged);
            // 
            // LabelMods
            // 
            resources.ApplyResources(this.LabelMods, "LabelMods");
            this.LabelMods.Name = "LabelMods";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ButtonAddMod);
            this.panel1.Controls.Add(this.RichTextAddModDescription);
            this.panel1.Controls.Add(this.LabelAddModDescription);
            this.panel1.Controls.Add(this.LabelAddModCatagory);
            this.panel1.Controls.Add(this.ComboAddModCatagory);
            this.panel1.Controls.Add(this.LabelAddModName);
            this.panel1.Controls.Add(this.ComboAddModName);
            this.panel1.Controls.Add(this.LabelAddMod);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // ButtonAddMod
            // 
            resources.ApplyResources(this.ButtonAddMod, "ButtonAddMod");
            this.ButtonAddMod.Name = "ButtonAddMod";
            this.toolTip1.SetToolTip(this.ButtonAddMod, resources.GetString("ButtonAddMod.ToolTip"));
            this.ButtonAddMod.UseVisualStyleBackColor = true;
            this.ButtonAddMod.Click += new System.EventHandler(this.ButtonAddMod_Click);
            // 
            // RichTextAddModDescription
            // 
            resources.ApplyResources(this.RichTextAddModDescription, "RichTextAddModDescription");
            this.RichTextAddModDescription.Name = "RichTextAddModDescription";
            this.RichTextAddModDescription.ReadOnly = true;
            // 
            // LabelAddModDescription
            // 
            resources.ApplyResources(this.LabelAddModDescription, "LabelAddModDescription");
            this.LabelAddModDescription.Name = "LabelAddModDescription";
            // 
            // LabelAddModCatagory
            // 
            resources.ApplyResources(this.LabelAddModCatagory, "LabelAddModCatagory");
            this.LabelAddModCatagory.Name = "LabelAddModCatagory";
            this.toolTip1.SetToolTip(this.LabelAddModCatagory, resources.GetString("LabelAddModCatagory.ToolTip"));
            // 
            // ComboAddModCatagory
            // 
            this.ComboAddModCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.ComboAddModCatagory, "ComboAddModCatagory");
            this.ComboAddModCatagory.FormattingEnabled = true;
            this.ComboAddModCatagory.Name = "ComboAddModCatagory";
            this.ComboAddModCatagory.Sorted = true;
            this.ComboAddModCatagory.SelectedIndexChanged += new System.EventHandler(this.ComboAddModCatagory_SelectedIndexChanged);
            // 
            // LabelAddModName
            // 
            resources.ApplyResources(this.LabelAddModName, "LabelAddModName");
            this.LabelAddModName.Name = "LabelAddModName";
            this.toolTip1.SetToolTip(this.LabelAddModName, resources.GetString("LabelAddModName.ToolTip"));
            // 
            // ComboAddModName
            // 
            this.ComboAddModName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.ComboAddModName, "ComboAddModName");
            this.ComboAddModName.FormattingEnabled = true;
            this.ComboAddModName.Name = "ComboAddModName";
            this.ComboAddModName.Sorted = true;
            this.ComboAddModName.SelectedIndexChanged += new System.EventHandler(this.ComboAddModName_SelectedIndexChanged);
            // 
            // LabelAddMod
            // 
            resources.ApplyResources(this.LabelAddMod, "LabelAddMod");
            this.LabelAddMod.Name = "LabelAddMod";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ListMods);
            this.panel2.Controls.Add(this.LabelMods);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ButtonOptionsMoveDown);
            this.panel3.Controls.Add(this.ButtonOptionsMoveUp);
            this.panel3.Controls.Add(this.ButtonUnused);
            this.panel3.Controls.Add(this.ButtonOptionsRemove);
            this.panel3.Controls.Add(this.ButtonOptionsEdit);
            this.panel3.Controls.Add(this.ButtonOptionsView);
            this.panel3.Controls.Add(this.LabelModSelectedName);
            this.panel3.Controls.Add(this.LabelModOptions);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // ButtonOptionsMoveDown
            // 
            resources.ApplyResources(this.ButtonOptionsMoveDown, "ButtonOptionsMoveDown");
            this.ButtonOptionsMoveDown.Name = "ButtonOptionsMoveDown";
            this.toolTip1.SetToolTip(this.ButtonOptionsMoveDown, resources.GetString("ButtonOptionsMoveDown.ToolTip"));
            this.ButtonOptionsMoveDown.UseVisualStyleBackColor = true;
            this.ButtonOptionsMoveDown.Click += new System.EventHandler(this.ButtonOptionsMoveDown_Click);
            // 
            // ButtonOptionsMoveUp
            // 
            resources.ApplyResources(this.ButtonOptionsMoveUp, "ButtonOptionsMoveUp");
            this.ButtonOptionsMoveUp.Name = "ButtonOptionsMoveUp";
            this.toolTip1.SetToolTip(this.ButtonOptionsMoveUp, resources.GetString("ButtonOptionsMoveUp.ToolTip"));
            this.ButtonOptionsMoveUp.UseVisualStyleBackColor = true;
            this.ButtonOptionsMoveUp.Click += new System.EventHandler(this.ButtonOptionsMoveUp_Click);
            // 
            // ButtonUnused
            // 
            resources.ApplyResources(this.ButtonUnused, "ButtonUnused");
            this.ButtonUnused.Name = "ButtonUnused";
            this.ButtonUnused.UseVisualStyleBackColor = true;
            // 
            // ButtonOptionsRemove
            // 
            resources.ApplyResources(this.ButtonOptionsRemove, "ButtonOptionsRemove");
            this.ButtonOptionsRemove.Name = "ButtonOptionsRemove";
            this.toolTip1.SetToolTip(this.ButtonOptionsRemove, resources.GetString("ButtonOptionsRemove.ToolTip"));
            this.ButtonOptionsRemove.UseVisualStyleBackColor = true;
            this.ButtonOptionsRemove.Click += new System.EventHandler(this.ButtonOptionsRemove_Click);
            // 
            // ButtonOptionsEdit
            // 
            resources.ApplyResources(this.ButtonOptionsEdit, "ButtonOptionsEdit");
            this.ButtonOptionsEdit.Name = "ButtonOptionsEdit";
            this.toolTip1.SetToolTip(this.ButtonOptionsEdit, resources.GetString("ButtonOptionsEdit.ToolTip"));
            this.ButtonOptionsEdit.UseVisualStyleBackColor = true;
            this.ButtonOptionsEdit.Click += new System.EventHandler(this.ButtonOptionsEdit_Click);
            // 
            // ButtonOptionsView
            // 
            resources.ApplyResources(this.ButtonOptionsView, "ButtonOptionsView");
            this.ButtonOptionsView.Name = "ButtonOptionsView";
            this.toolTip1.SetToolTip(this.ButtonOptionsView, resources.GetString("ButtonOptionsView.ToolTip"));
            this.ButtonOptionsView.UseVisualStyleBackColor = true;
            this.ButtonOptionsView.Click += new System.EventHandler(this.ButtonOptionsView_Click);
            // 
            // LabelModSelectedName
            // 
            resources.ApplyResources(this.LabelModSelectedName, "LabelModSelectedName");
            this.LabelModSelectedName.Name = "LabelModSelectedName";
            this.toolTip1.SetToolTip(this.LabelModSelectedName, resources.GetString("LabelModSelectedName.ToolTip"));
            // 
            // LabelModOptions
            // 
            resources.ApplyResources(this.LabelModOptions, "LabelModOptions");
            this.LabelModOptions.Name = "LabelModOptions";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.CheckRecalcFocus);
            this.panel4.Controls.Add(this.CheckRecalcVitality);
            this.panel4.Controls.Add(this.ButtonSimplifiedMerge);
            this.panel4.Controls.Add(this.ButtonFullMerge);
            this.panel4.Controls.Add(this.LabelFinalCalcDescription);
            this.panel4.Controls.Add(this.LabelMergeCalc);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // CheckRecalcFocus
            // 
            resources.ApplyResources(this.CheckRecalcFocus, "CheckRecalcFocus");
            this.CheckRecalcFocus.Checked = true;
            this.CheckRecalcFocus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckRecalcFocus.Name = "CheckRecalcFocus";
            this.toolTip1.SetToolTip(this.CheckRecalcFocus, resources.GetString("CheckRecalcFocus.ToolTip"));
            this.CheckRecalcFocus.UseVisualStyleBackColor = true;
            // 
            // CheckRecalcVitality
            // 
            resources.ApplyResources(this.CheckRecalcVitality, "CheckRecalcVitality");
            this.CheckRecalcVitality.Checked = true;
            this.CheckRecalcVitality.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckRecalcVitality.Name = "CheckRecalcVitality";
            this.toolTip1.SetToolTip(this.CheckRecalcVitality, resources.GetString("CheckRecalcVitality.ToolTip"));
            this.CheckRecalcVitality.UseVisualStyleBackColor = true;
            // 
            // ButtonSimplifiedMerge
            // 
            resources.ApplyResources(this.ButtonSimplifiedMerge, "ButtonSimplifiedMerge");
            this.ButtonSimplifiedMerge.Name = "ButtonSimplifiedMerge";
            this.toolTip1.SetToolTip(this.ButtonSimplifiedMerge, resources.GetString("ButtonSimplifiedMerge.ToolTip"));
            this.ButtonSimplifiedMerge.UseVisualStyleBackColor = true;
            this.ButtonSimplifiedMerge.Click += new System.EventHandler(this.ButtonSimplifiedMerge_Click);
            // 
            // ButtonFullMerge
            // 
            resources.ApplyResources(this.ButtonFullMerge, "ButtonFullMerge");
            this.ButtonFullMerge.Name = "ButtonFullMerge";
            this.toolTip1.SetToolTip(this.ButtonFullMerge, resources.GetString("ButtonFullMerge.ToolTip"));
            this.ButtonFullMerge.UseVisualStyleBackColor = true;
            this.ButtonFullMerge.Click += new System.EventHandler(this.ButtonFullMerge_Click);
            // 
            // LabelFinalCalcDescription
            // 
            resources.ApplyResources(this.LabelFinalCalcDescription, "LabelFinalCalcDescription");
            this.LabelFinalCalcDescription.Name = "LabelFinalCalcDescription";
            // 
            // LabelMergeCalc
            // 
            resources.ApplyResources(this.LabelMergeCalc, "LabelMergeCalc");
            this.LabelMergeCalc.Name = "LabelMergeCalc";
            // 
            // LabelSetMonster
            // 
            resources.ApplyResources(this.LabelSetMonster, "LabelSetMonster");
            this.LabelSetMonster.Name = "LabelSetMonster";
            // 
            // LabelCatagorySetMonster
            // 
            resources.ApplyResources(this.LabelCatagorySetMonster, "LabelCatagorySetMonster");
            this.LabelCatagorySetMonster.Name = "LabelCatagorySetMonster";
            this.toolTip1.SetToolTip(this.LabelCatagorySetMonster, resources.GetString("LabelCatagorySetMonster.ToolTip"));
            // 
            // ComboMonsterCatagory
            // 
            this.ComboMonsterCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.ComboMonsterCatagory, "ComboMonsterCatagory");
            this.ComboMonsterCatagory.FormattingEnabled = true;
            this.ComboMonsterCatagory.Name = "ComboMonsterCatagory";
            this.ComboMonsterCatagory.Sorted = true;
            this.ComboMonsterCatagory.SelectedIndexChanged += new System.EventHandler(this.ComboCatagoryMonster_SelectedIndexChanged);
            // 
            // LabelNameSetMonster
            // 
            resources.ApplyResources(this.LabelNameSetMonster, "LabelNameSetMonster");
            this.LabelNameSetMonster.Name = "LabelNameSetMonster";
            this.toolTip1.SetToolTip(this.LabelNameSetMonster, resources.GetString("LabelNameSetMonster.ToolTip"));
            // 
            // ComboMonsterName
            // 
            this.ComboMonsterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.ComboMonsterName, "ComboMonsterName");
            this.ComboMonsterName.FormattingEnabled = true;
            this.ComboMonsterName.Name = "ComboMonsterName";
            this.ComboMonsterName.Sorted = true;
            this.ComboMonsterName.SelectedIndexChanged += new System.EventHandler(this.ComboMonsterName_SelectedIndexChanged);
            // 
            // ButtonSetMonster
            // 
            resources.ApplyResources(this.ButtonSetMonster, "ButtonSetMonster");
            this.ButtonSetMonster.Name = "ButtonSetMonster";
            this.toolTip1.SetToolTip(this.ButtonSetMonster, resources.GetString("ButtonSetMonster.ToolTip"));
            this.ButtonSetMonster.UseVisualStyleBackColor = true;
            this.ButtonSetMonster.Click += new System.EventHandler(this.ButtonSetMonster_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.ButtonRemovePreset);
            this.panel5.Controls.Add(this.ButtonSavePreset);
            this.panel5.Controls.Add(this.ButtonLoadPreset);
            this.panel5.Controls.Add(this.LabelNameLoadPreset);
            this.panel5.Controls.Add(this.LabelPresets);
            this.panel5.Controls.Add(this.ComboPreset);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            // 
            // ButtonRemovePreset
            // 
            resources.ApplyResources(this.ButtonRemovePreset, "ButtonRemovePreset");
            this.ButtonRemovePreset.Name = "ButtonRemovePreset";
            this.toolTip1.SetToolTip(this.ButtonRemovePreset, resources.GetString("ButtonRemovePreset.ToolTip"));
            this.ButtonRemovePreset.UseVisualStyleBackColor = true;
            this.ButtonRemovePreset.Click += new System.EventHandler(this.ButtonRemovePreset_Click);
            // 
            // ButtonSavePreset
            // 
            resources.ApplyResources(this.ButtonSavePreset, "ButtonSavePreset");
            this.ButtonSavePreset.Name = "ButtonSavePreset";
            this.toolTip1.SetToolTip(this.ButtonSavePreset, resources.GetString("ButtonSavePreset.ToolTip"));
            this.ButtonSavePreset.UseVisualStyleBackColor = true;
            this.ButtonSavePreset.Click += new System.EventHandler(this.ButtonSavePreset_Click);
            // 
            // ButtonLoadPreset
            // 
            resources.ApplyResources(this.ButtonLoadPreset, "ButtonLoadPreset");
            this.ButtonLoadPreset.Name = "ButtonLoadPreset";
            this.toolTip1.SetToolTip(this.ButtonLoadPreset, resources.GetString("ButtonLoadPreset.ToolTip"));
            this.ButtonLoadPreset.UseVisualStyleBackColor = true;
            this.ButtonLoadPreset.Click += new System.EventHandler(this.ButtonLoadPreset_Click);
            // 
            // LabelNameLoadPreset
            // 
            resources.ApplyResources(this.LabelNameLoadPreset, "LabelNameLoadPreset");
            this.LabelNameLoadPreset.Name = "LabelNameLoadPreset";
            this.toolTip1.SetToolTip(this.LabelNameLoadPreset, resources.GetString("LabelNameLoadPreset.ToolTip"));
            // 
            // LabelPresets
            // 
            resources.ApplyResources(this.LabelPresets, "LabelPresets");
            this.LabelPresets.Name = "LabelPresets";
            this.toolTip1.SetToolTip(this.LabelPresets, resources.GetString("LabelPresets.ToolTip"));
            // 
            // ComboPreset
            // 
            resources.ApplyResources(this.ComboPreset, "ComboPreset");
            this.ComboPreset.FormattingEnabled = true;
            this.ComboPreset.Name = "ComboPreset";
            this.ComboPreset.Sorted = true;
            this.ComboPreset.SelectedIndexChanged += new System.EventHandler(this.ComboLoadPreset_SelectedIndexChanged);
            // 
            // RichTextMonsterDescription
            // 
            resources.ApplyResources(this.RichTextMonsterDescription, "RichTextMonsterDescription");
            this.RichTextMonsterDescription.Name = "RichTextMonsterDescription";
            this.RichTextMonsterDescription.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // MergeMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RichTextMonsterDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSetMonster);
            this.Controls.Add(this.LabelCatagorySetMonster);
            this.Controls.Add(this.LabelSetMonster);
            this.Controls.Add(this.ComboMonsterCatagory);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.LabelNameSetMonster);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ComboMonsterName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MergeMenu";
            this.Load += new System.EventHandler(this.MergeMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListMods;
        private System.Windows.Forms.Label LabelMods;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ComboAddModName;
        private System.Windows.Forms.Label LabelAddMod;
        private System.Windows.Forms.Label LabelAddModName;
        private System.Windows.Forms.Label LabelAddModCatagory;
        private System.Windows.Forms.ComboBox ComboAddModCatagory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButtonAddMod;
        private System.Windows.Forms.RichTextBox RichTextAddModDescription;
        private System.Windows.Forms.Label LabelAddModDescription;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ButtonOptionsMoveDown;
        private System.Windows.Forms.Button ButtonOptionsMoveUp;
        private System.Windows.Forms.Button ButtonUnused;
        private System.Windows.Forms.Button ButtonOptionsRemove;
        private System.Windows.Forms.Button ButtonOptionsEdit;
        private System.Windows.Forms.Button ButtonOptionsView;
        private System.Windows.Forms.Label LabelModSelectedName;
        private System.Windows.Forms.Label LabelModOptions;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button ButtonSimplifiedMerge;
        private System.Windows.Forms.Button ButtonFullMerge;
        private System.Windows.Forms.Label LabelFinalCalcDescription;
        private System.Windows.Forms.Label LabelMergeCalc;
        private System.Windows.Forms.Label LabelSetMonster;
        private System.Windows.Forms.Label LabelCatagorySetMonster;
        private System.Windows.Forms.ComboBox ComboMonsterCatagory;
        private System.Windows.Forms.Label LabelNameSetMonster;
        private System.Windows.Forms.ComboBox ComboMonsterName;
        private System.Windows.Forms.Button ButtonSetMonster;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button ButtonSavePreset;
        private System.Windows.Forms.Button ButtonLoadPreset;
        private System.Windows.Forms.Label LabelNameLoadPreset;
        private System.Windows.Forms.Label LabelPresets;
        private System.Windows.Forms.ComboBox ComboPreset;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox RichTextMonsterDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckRecalcFocus;
        private System.Windows.Forms.CheckBox CheckRecalcVitality;
        private System.Windows.Forms.Button ButtonRemovePreset;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}