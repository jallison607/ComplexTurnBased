namespace ComplexTurnBased.Windows
{
    partial class UpdateAbilities
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbAbilityList = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.effectsBox1 = new ComplexTurnBased.Windows.EffectsBox();
            this.SuspendLayout();
            // 
            // cmbAbilityList
            // 
            this.cmbAbilityList.FormattingEnabled = true;
            this.cmbAbilityList.Location = new System.Drawing.Point(12, 11);
            this.cmbAbilityList.Name = "cmbAbilityList";
            this.cmbAbilityList.Size = new System.Drawing.Size(262, 21);
            this.cmbAbilityList.TabIndex = 0;
            this.cmbAbilityList.SelectedIndexChanged += new System.EventHandler(this.cmbAbilityList_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(280, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(213, 366);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // effectsBox1
            // 
            this.effectsBox1.Location = new System.Drawing.Point(2, 40);
            this.effectsBox1.Name = "effectsBox1";
            this.effectsBox1.Size = new System.Drawing.Size(393, 320);
            this.effectsBox1.TabIndex = 2;
            // 
            // UpdateAbilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 405);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.effectsBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbAbilityList);
            this.Name = "UpdateAbilities";
            this.Text = "Modify Ability List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAbilityList;
        private System.Windows.Forms.Button btnDelete;
        private EffectsBox effectsBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
    }
}