namespace MonsterMerger.UserInterface {
    partial class MainMenu {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMerge = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.labelSave = new System.Windows.Forms.Label();
            this.buttonSaveAll = new System.Windows.Forms.Button();
            this.buttonLoadAll = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select what you wish to do;";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonMerge
            // 
            this.buttonMerge.Location = new System.Drawing.Point(28, 31);
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Size = new System.Drawing.Size(75, 23);
            this.buttonMerge.TabIndex = 1;
            this.buttonMerge.Text = "Merge";
            this.toolTip1.SetToolTip(this.buttonMerge, "Merge Menu: Lets you merge monsters and modifiers together, and the program will " +
        "calculate the outcome.");
            this.buttonMerge.UseVisualStyleBackColor = true;
            this.buttonMerge.Click += new System.EventHandler(this.buttonMerge_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(28, 60);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Create";
            this.toolTip1.SetToolTip(this.buttonCreate, "Allows creation of new monsters and modifiers");
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(28, 89);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 23);
            this.buttonModify.TabIndex = 3;
            this.buttonModify.Text = "Modify";
            this.toolTip1.SetToolTip(this.buttonModify, "Modify the existing data found in the database");
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // labelSave
            // 
            this.labelSave.AllowDrop = true;
            this.labelSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSave.Location = new System.Drawing.Point(151, 31);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(103, 93);
            this.labelSave.TabIndex = 4;
            this.labelSave.Text = "Data Management";
            this.labelSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonSaveAll
            // 
            this.buttonSaveAll.Location = new System.Drawing.Point(165, 59);
            this.buttonSaveAll.Name = "buttonSaveAll";
            this.buttonSaveAll.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveAll.TabIndex = 5;
            this.buttonSaveAll.Text = "Save All";
            this.toolTip1.SetToolTip(this.buttonSaveAll, "Saves all data to disk. this is also done when the program is closed");
            this.buttonSaveAll.UseVisualStyleBackColor = true;
            this.buttonSaveAll.Click += new System.EventHandler(this.buttonSaveAll_Click);
            // 
            // buttonLoadAll
            // 
            this.buttonLoadAll.Location = new System.Drawing.Point(165, 89);
            this.buttonLoadAll.Name = "buttonLoadAll";
            this.buttonLoadAll.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadAll.TabIndex = 6;
            this.buttonLoadAll.Text = "Load All";
            this.toolTip1.SetToolTip(this.buttonLoadAll, "loads all data from disk. this is also done at startup");
            this.buttonLoadAll.UseVisualStyleBackColor = true;
            this.buttonLoadAll.Click += new System.EventHandler(this.buttonLoadAll_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 50);
            this.pictureBox1.TabIndex = 120;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "♫Myeow!♪");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(1, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 121;
            this.label2.Text = "Made By: Kitty Soldier";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 169);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLoadAll);
            this.Controls.Add(this.buttonSaveAll);
            this.Controls.Add(this.labelSave);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonMerge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(298, 212);
            this.MinimumSize = new System.Drawing.Size(298, 212);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMerge;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Label labelSave;
        private System.Windows.Forms.Button buttonSaveAll;
        private System.Windows.Forms.Button buttonLoadAll;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}