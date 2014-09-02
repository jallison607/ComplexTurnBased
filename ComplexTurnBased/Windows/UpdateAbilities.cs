using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComplexTurnBased.Windows
{
    public partial class UpdateAbilities : Form
    {
        public UpdateAbilities()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbAbilityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAbilityList.SelectedIndex != cmbAbilityList.Items.Count - 1)
            {
                
            }
            else
            {

            }

        }

    }
}
