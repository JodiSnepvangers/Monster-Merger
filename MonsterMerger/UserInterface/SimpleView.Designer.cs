namespace MonsterMerger.UserInterface {
    partial class SimpleView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleView));
            this.RichDescription = new System.Windows.Forms.RichTextBox();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelCatagory = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelChanges = new System.Windows.Forms.Label();
            this.LabelType = new System.Windows.Forms.Label();
            this.RichBigList = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RichDescription
            // 
            this.RichDescription.Location = new System.Drawing.Point(5, 76);
            this.RichDescription.Name = "RichDescription";
            this.RichDescription.ReadOnly = true;
            this.RichDescription.Size = new System.Drawing.Size(579, 136);
            this.RichDescription.TabIndex = 14;
            this.RichDescription.Text = "";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LabelDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDescription.Location = new System.Drawing.Point(12, 57);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(79, 16);
            this.LabelDescription.TabIndex = 13;
            this.LabelDescription.Text = "Description:";
            // 
            // LabelCatagory
            // 
            this.LabelCatagory.AutoSize = true;
            this.LabelCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LabelCatagory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelCatagory.Location = new System.Drawing.Point(12, 25);
            this.LabelCatagory.Name = "LabelCatagory";
            this.LabelCatagory.Size = new System.Drawing.Size(69, 16);
            this.LabelCatagory.TabIndex = 12;
            this.LabelCatagory.Text = "Catagory: ";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LabelName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelName.Location = new System.Drawing.Point(12, 9);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(51, 16);
            this.LabelName.TabIndex = 10;
            this.LabelName.Text = "Name: ";
            // 
            // LabelChanges
            // 
            this.LabelChanges.AutoSize = true;
            this.LabelChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LabelChanges.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelChanges.Location = new System.Drawing.Point(12, 222);
            this.LabelChanges.Name = "LabelChanges";
            this.LabelChanges.Size = new System.Drawing.Size(65, 16);
            this.LabelChanges.TabIndex = 16;
            this.LabelChanges.Text = "Changes:";
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LabelType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelType.Location = new System.Drawing.Point(12, 41);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(46, 16);
            this.LabelType.TabIndex = 17;
            this.LabelType.Text = "Type: ";
            // 
            // RichBigList
            // 
            this.RichBigList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichBigList.Location = new System.Drawing.Point(5, 241);
            this.RichBigList.Name = "RichBigList";
            this.RichBigList.Size = new System.Drawing.Size(579, 687);
            this.RichBigList.TabIndex = 18;
            this.RichBigList.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(494, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 50);
            this.pictureBox1.TabIndex = 120;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // SimpleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 931);
            this.Controls.Add(this.RichBigList);
            this.Controls.Add(this.LabelType);
            this.Controls.Add(this.LabelChanges);
            this.Controls.Add(this.RichDescription);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.LabelCatagory);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SimpleView";
            this.Text = "Simple View";
            this.Load += new System.EventHandler(this.SimpleView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichDescription;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Label LabelCatagory;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelChanges;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.RichTextBox RichBigList;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}