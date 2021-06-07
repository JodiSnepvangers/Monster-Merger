namespace MonsterMerger.UserInterface {
    partial class ListMenu {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListMenu));
            this.ListBoxResults = new System.Windows.Forms.ListBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RadioButtonModification = new System.Windows.Forms.RadioButton();
            this.RadioButtonMonster = new System.Windows.Forms.RadioButton();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelSelected = new System.Windows.Forms.Label();
            this.LabelType = new System.Windows.Forms.Label();
            this.ButtonEditor = new System.Windows.Forms.Button();
            this.ButtonErase = new System.Windows.Forms.Button();
            this.LabelNameEnter = new System.Windows.Forms.Label();
            this.LabelTypeEnter = new System.Windows.Forms.Label();
            this.ButtonConfirm = new System.Windows.Forms.Button();
            this.LabelWarning = new System.Windows.Forms.Label();
            this.RichTextDescription = new System.Windows.Forms.RichTextBox();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelCatagoryEnter = new System.Windows.Forms.Label();
            this.LabelCatagory = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxResults
            // 
            this.ListBoxResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxResults.FormattingEnabled = true;
            this.ListBoxResults.ItemHeight = 18;
            this.ListBoxResults.Location = new System.Drawing.Point(12, 48);
            this.ListBoxResults.Name = "ListBoxResults";
            this.ListBoxResults.Size = new System.Drawing.Size(165, 382);
            this.ListBoxResults.Sorted = true;
            this.ListBoxResults.TabIndex = 0;
            this.ListBoxResults.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.ListBoxResults.DoubleClick += new System.EventHandler(this.ListBoxResults_DoubleClick);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(147, 12);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(138, 20);
            this.TextBoxSearch.TabIndex = 1;
            this.toolTip1.SetToolTip(this.TextBoxSearch, "Searches the data for the words given.");
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearch.Location = new System.Drawing.Point(87, 16);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(54, 16);
            this.LabelSearch.TabIndex = 2;
            this.LabelSearch.Text = "Search:";
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(291, 12);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(18, 21);
            this.ButtonClear.TabIndex = 3;
            this.ButtonClear.Text = "X";
            this.toolTip1.SetToolTip(this.ButtonClear, "Erases everything in the search bar and makes it blank");
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RadioButtonModification);
            this.panel1.Controls.Add(this.RadioButtonMonster);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 41);
            this.panel1.TabIndex = 4;
            // 
            // RadioButtonModification
            // 
            this.RadioButtonModification.AutoSize = true;
            this.RadioButtonModification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonModification.Location = new System.Drawing.Point(3, 21);
            this.RadioButtonModification.Name = "RadioButtonModification";
            this.RadioButtonModification.Size = new System.Drawing.Size(81, 20);
            this.RadioButtonModification.TabIndex = 1;
            this.RadioButtonModification.Text = "Modifiers";
            this.toolTip1.SetToolTip(this.RadioButtonModification, "Selects the type of data shown below");
            this.RadioButtonModification.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMonster
            // 
            this.RadioButtonMonster.AutoSize = true;
            this.RadioButtonMonster.Checked = true;
            this.RadioButtonMonster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonMonster.Location = new System.Drawing.Point(3, 0);
            this.RadioButtonMonster.Name = "RadioButtonMonster";
            this.RadioButtonMonster.Size = new System.Drawing.Size(81, 20);
            this.RadioButtonMonster.TabIndex = 0;
            this.RadioButtonMonster.TabStop = true;
            this.RadioButtonMonster.Text = "Monsters";
            this.toolTip1.SetToolTip(this.RadioButtonMonster, "Selects the type of data shown below");
            this.RadioButtonMonster.UseVisualStyleBackColor = true;
            this.RadioButtonMonster.CheckedChanged += new System.EventHandler(this.RefreshList);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(183, 70);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(43, 13);
            this.LabelName.TabIndex = 5;
            this.LabelName.Text = "Name:";
            // 
            // LabelSelected
            // 
            this.LabelSelected.AutoSize = true;
            this.LabelSelected.Location = new System.Drawing.Point(183, 48);
            this.LabelSelected.Name = "LabelSelected";
            this.LabelSelected.Size = new System.Drawing.Size(52, 13);
            this.LabelSelected.TabIndex = 6;
            this.LabelSelected.Text = "Selected:";
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelType.Location = new System.Drawing.Point(183, 99);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(39, 13);
            this.LabelType.TabIndex = 7;
            this.LabelType.Text = "Type:";
            // 
            // ButtonEditor
            // 
            this.ButtonEditor.Enabled = false;
            this.ButtonEditor.Location = new System.Drawing.Point(261, 402);
            this.ButtonEditor.Name = "ButtonEditor";
            this.ButtonEditor.Size = new System.Drawing.Size(58, 23);
            this.ButtonEditor.TabIndex = 8;
            this.ButtonEditor.Text = "Edit";
            this.toolTip1.SetToolTip(this.ButtonEditor, "Opens the selected data inside the editor.");
            this.ButtonEditor.UseVisualStyleBackColor = true;
            this.ButtonEditor.Click += new System.EventHandler(this.ButtonEditor_Click);
            // 
            // ButtonErase
            // 
            this.ButtonErase.Enabled = false;
            this.ButtonErase.Location = new System.Drawing.Point(186, 402);
            this.ButtonErase.Name = "ButtonErase";
            this.ButtonErase.Size = new System.Drawing.Size(58, 23);
            this.ButtonErase.TabIndex = 9;
            this.ButtonErase.Text = "Delete";
            this.toolTip1.SetToolTip(this.ButtonErase, "Deletes the data from the database permanently");
            this.ButtonErase.UseVisualStyleBackColor = true;
            this.ButtonErase.Click += new System.EventHandler(this.ButtonErase_Click);
            // 
            // LabelNameEnter
            // 
            this.LabelNameEnter.AutoSize = true;
            this.LabelNameEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNameEnter.Location = new System.Drawing.Point(183, 83);
            this.LabelNameEnter.Name = "LabelNameEnter";
            this.LabelNameEnter.Size = new System.Drawing.Size(75, 16);
            this.LabelNameEnter.TabIndex = 10;
            this.LabelNameEnter.Text = "NameEntry";
            // 
            // LabelTypeEnter
            // 
            this.LabelTypeEnter.AutoSize = true;
            this.LabelTypeEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTypeEnter.Location = new System.Drawing.Point(183, 112);
            this.LabelTypeEnter.Name = "LabelTypeEnter";
            this.LabelTypeEnter.Size = new System.Drawing.Size(70, 16);
            this.LabelTypeEnter.TabIndex = 11;
            this.LabelTypeEnter.Text = "TypeEntry";
            // 
            // ButtonConfirm
            // 
            this.ButtonConfirm.BackColor = System.Drawing.Color.RosyBrown;
            this.ButtonConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.ButtonConfirm.FlatAppearance.BorderSize = 15;
            this.ButtonConfirm.Location = new System.Drawing.Point(186, 373);
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.Size = new System.Drawing.Size(58, 23);
            this.ButtonConfirm.TabIndex = 12;
            this.ButtonConfirm.Text = "Confirm";
            this.toolTip1.SetToolTip(this.ButtonConfirm, "Are you really sure?");
            this.ButtonConfirm.UseVisualStyleBackColor = false;
            this.ButtonConfirm.Visible = false;
            this.ButtonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // LabelWarning
            // 
            this.LabelWarning.AutoSize = true;
            this.LabelWarning.ForeColor = System.Drawing.Color.Red;
            this.LabelWarning.Location = new System.Drawing.Point(188, 357);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(97, 13);
            this.LabelWarning.TabIndex = 13;
            this.LabelWarning.Text = "cannot be undone!";
            this.LabelWarning.Visible = false;
            // 
            // RichTextDescription
            // 
            this.RichTextDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextDescription.Location = new System.Drawing.Point(186, 181);
            this.RichTextDescription.Name = "RichTextDescription";
            this.RichTextDescription.ReadOnly = true;
            this.RichTextDescription.Size = new System.Drawing.Size(133, 156);
            this.RichTextDescription.TabIndex = 14;
            this.RichTextDescription.Text = "";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescription.Location = new System.Drawing.Point(183, 165);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(75, 13);
            this.LabelDescription.TabIndex = 15;
            this.LabelDescription.Text = "Description:";
            // 
            // LabelCatagoryEnter
            // 
            this.LabelCatagoryEnter.AutoSize = true;
            this.LabelCatagoryEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCatagoryEnter.Location = new System.Drawing.Point(183, 141);
            this.LabelCatagoryEnter.Name = "LabelCatagoryEnter";
            this.LabelCatagoryEnter.Size = new System.Drawing.Size(93, 16);
            this.LabelCatagoryEnter.TabIndex = 17;
            this.LabelCatagoryEnter.Text = "CatagoryEntry";
            // 
            // LabelCatagory
            // 
            this.LabelCatagory.AutoSize = true;
            this.LabelCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCatagory.Location = new System.Drawing.Point(183, 128);
            this.LabelCatagory.Name = "LabelCatagory";
            this.LabelCatagory.Size = new System.Drawing.Size(61, 13);
            this.LabelCatagory.TabIndex = 16;
            this.LabelCatagory.Text = "Catagory:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 413);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 54);
            this.pictureBox1.TabIndex = 120;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "♫Myeow!♪");
            this.pictureBox1.Visible = false;
            // 
            // ListMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 437);
            this.Controls.Add(this.LabelCatagoryEnter);
            this.Controls.Add(this.LabelCatagory);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.RichTextDescription);
            this.Controls.Add(this.LabelWarning);
            this.Controls.Add(this.ButtonConfirm);
            this.Controls.Add(this.LabelTypeEnter);
            this.Controls.Add(this.LabelNameEnter);
            this.Controls.Add(this.ButtonErase);
            this.Controls.Add(this.ButtonEditor);
            this.Controls.Add(this.LabelType);
            this.Controls.Add(this.LabelSelected);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.ListBoxResults);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListMenu";
            this.Text = "List Menu";
            this.Load += new System.EventHandler(this.ListMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxResults;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RadioButtonModification;
        private System.Windows.Forms.RadioButton RadioButtonMonster;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelSelected;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.Button ButtonEditor;
        private System.Windows.Forms.Button ButtonErase;
        private System.Windows.Forms.Label LabelNameEnter;
        private System.Windows.Forms.Label LabelTypeEnter;
        private System.Windows.Forms.Button ButtonConfirm;
        private System.Windows.Forms.Label LabelWarning;
        private System.Windows.Forms.RichTextBox RichTextDescription;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Label LabelCatagoryEnter;
        private System.Windows.Forms.Label LabelCatagory;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}