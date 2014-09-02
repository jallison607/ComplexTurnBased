namespace ComplexTurnBased.Windows
{
    partial class EffectsBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainBox = new System.Windows.Forms.GroupBox();
            this.subBox = new System.Windows.Forms.GroupBox();
            this.txtSpecial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditEffects = new System.Windows.Forms.Button();
            this.txtEffectValue = new System.Windows.Forms.TextBox();
            this.txtEffectStat = new System.Windows.Forms.TextBox();
            this.txtEffectType = new System.Windows.Forms.TextBox();
            this.txtEffectElement = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstEffects = new System.Windows.Forms.ListBox();
            this.cmbEffects = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtEffectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.mainBox.SuspendLayout();
            this.subBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainBox
            // 
            this.mainBox.Controls.Add(this.subBox);
            this.mainBox.Controls.Add(this.txtName);
            this.mainBox.Controls.Add(this.label1);
            this.mainBox.Location = new System.Drawing.Point(3, 3);
            this.mainBox.Name = "mainBox";
            this.mainBox.Size = new System.Drawing.Size(385, 303);
            this.mainBox.TabIndex = 3;
            this.mainBox.TabStop = false;
            this.mainBox.Text = "Ability Info";
            // 
            // subBox
            // 
            this.subBox.Controls.Add(this.txtDuration);
            this.subBox.Controls.Add(this.label7);
            this.subBox.Controls.Add(this.txtSpecial);
            this.subBox.Controls.Add(this.label6);
            this.subBox.Controls.Add(this.btnEditEffects);
            this.subBox.Controls.Add(this.txtEffectValue);
            this.subBox.Controls.Add(this.txtEffectStat);
            this.subBox.Controls.Add(this.txtEffectType);
            this.subBox.Controls.Add(this.txtEffectElement);
            this.subBox.Controls.Add(this.btnRemove);
            this.subBox.Controls.Add(this.label5);
            this.subBox.Controls.Add(this.lstEffects);
            this.subBox.Controls.Add(this.cmbEffects);
            this.subBox.Controls.Add(this.btnAdd);
            this.subBox.Controls.Add(this.txtEffectName);
            this.subBox.Controls.Add(this.label2);
            this.subBox.Controls.Add(this.label4);
            this.subBox.Controls.Add(this.label3);
            this.subBox.Location = new System.Drawing.Point(11, 51);
            this.subBox.Name = "subBox";
            this.subBox.Size = new System.Drawing.Size(360, 232);
            this.subBox.TabIndex = 2;
            this.subBox.TabStop = false;
            this.subBox.Text = "Effects";
            // 
            // txtSpecial
            // 
            this.txtSpecial.Location = new System.Drawing.Point(219, 203);
            this.txtSpecial.Name = "txtSpecial";
            this.txtSpecial.ReadOnly = true;
            this.txtSpecial.Size = new System.Drawing.Size(100, 20);
            this.txtSpecial.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Special:";
            // 
            // btnEditEffects
            // 
            this.btnEditEffects.Location = new System.Drawing.Point(181, 106);
            this.btnEditEffects.Name = "btnEditEffects";
            this.btnEditEffects.Size = new System.Drawing.Size(138, 23);
            this.btnEditEffects.TabIndex = 20;
            this.btnEditEffects.Text = "Edit Effects List";
            this.btnEditEffects.UseVisualStyleBackColor = true;
            // 
            // txtEffectValue
            // 
            this.txtEffectValue.Location = new System.Drawing.Point(251, 173);
            this.txtEffectValue.Name = "txtEffectValue";
            this.txtEffectValue.ReadOnly = true;
            this.txtEffectValue.Size = new System.Drawing.Size(68, 20);
            this.txtEffectValue.TabIndex = 19;
            // 
            // txtEffectStat
            // 
            this.txtEffectStat.Location = new System.Drawing.Point(119, 174);
            this.txtEffectStat.Name = "txtEffectStat";
            this.txtEffectStat.ReadOnly = true;
            this.txtEffectStat.Size = new System.Drawing.Size(100, 20);
            this.txtEffectStat.TabIndex = 18;
            // 
            // txtEffectType
            // 
            this.txtEffectType.Location = new System.Drawing.Point(12, 174);
            this.txtEffectType.Name = "txtEffectType";
            this.txtEffectType.ReadOnly = true;
            this.txtEffectType.Size = new System.Drawing.Size(100, 20);
            this.txtEffectType.TabIndex = 17;
            // 
            // txtEffectElement
            // 
            this.txtEffectElement.Location = new System.Drawing.Point(219, 144);
            this.txtEffectElement.Name = "txtEffectElement";
            this.txtEffectElement.ReadOnly = true;
            this.txtEffectElement.Size = new System.Drawing.Size(100, 20);
            this.txtEffectElement.TabIndex = 16;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(256, 20);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(63, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Effect:";
            // 
            // lstEffects
            // 
            this.lstEffects.BackColor = System.Drawing.SystemColors.Control;
            this.lstEffects.FormattingEnabled = true;
            this.lstEffects.Location = new System.Drawing.Point(7, 20);
            this.lstEffects.Name = "lstEffects";
            this.lstEffects.Size = new System.Drawing.Size(244, 69);
            this.lstEffects.TabIndex = 0;
            // 
            // cmbEffects
            // 
            this.cmbEffects.FormattingEnabled = true;
            this.cmbEffects.Location = new System.Drawing.Point(54, 108);
            this.cmbEffects.Name = "cmbEffects";
            this.cmbEffects.Size = new System.Drawing.Size(121, 21);
            this.cmbEffects.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(257, 49);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtEffectName
            // 
            this.txtEffectName.Location = new System.Drawing.Point(54, 144);
            this.txtEffectName.Name = "txtEffectName";
            this.txtEffectName.ReadOnly = true;
            this.txtEffectName.Size = new System.Drawing.Size(106, 20);
            this.txtEffectName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Element:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(52, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Duration:";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(70, 203);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.ReadOnly = true;
            this.txtDuration.Size = new System.Drawing.Size(90, 20);
            this.txtDuration.TabIndex = 24;
            // 
            // EffectsBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainBox);
            this.Name = "EffectsBox";
            this.Size = new System.Drawing.Size(393, 319);
            this.mainBox.ResumeLayout(false);
            this.mainBox.PerformLayout();
            this.subBox.ResumeLayout(false);
            this.subBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainBox;
        private System.Windows.Forms.GroupBox subBox;
        private System.Windows.Forms.TextBox txtSpecial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditEffects;
        private System.Windows.Forms.TextBox txtEffectValue;
        private System.Windows.Forms.TextBox txtEffectStat;
        private System.Windows.Forms.TextBox txtEffectType;
        private System.Windows.Forms.TextBox txtEffectElement;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstEffects;
        private System.Windows.Forms.ComboBox cmbEffects;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtEffectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label7;
    }
}
