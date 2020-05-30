using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _50UnitedMapTool
{
    public partial class frmAddSector : Form
    {

        public frmMain main = new frmMain();

        public frmAddSector()
        {
            InitializeComponent();
            btnAdd.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;
        }

        public string getSector()
        {
            string sector;

            if (robPlus1.Checked)
            { 
                sector = "+" + txtCord1.Text;
            } else
            {
                sector = "-" + txtCord1.Text;
            }

            if (robPlus2.Checked)
            {
                sector = sector + "+" + txtCord2.Text;
            } else
            {
                sector = sector + "-" + txtCord2.Text;
            }

            return sector;
        }
    }
}
