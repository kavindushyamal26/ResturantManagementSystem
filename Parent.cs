using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nikadoResturant
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void PeopleRolesMenu_Click(object sender, EventArgs e)
        {
            RolesForm frmRoles = new RolesForm();
            frmRoles.ShowDialog();
        }

        private void RolesButton_Click(object sender, EventArgs e)
        {
            PeopleRolesMenu.PerformClick();
        }

        private void UtilityexitMenu_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Do you want to exit ?", this.Text, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            UtilityexitMenu.PerformClick();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            category ca = new category();
            ca.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFood af = new AddFood();
            af.Show();
        }

        private void dealerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dealer_info di = new Dealer_info();
            di.Show();
        }

        private void purchaseItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_info pi = new Purchase_info();
            pi.Show();
        }

        private void UtilityMenu_Click(object sender, EventArgs e)
        {

        }

        private void salesProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sales sa = new sales();
            sa.Show();
        }

        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_report gp = new Purchase_report();
            gp.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            categoriesToolStripMenuItem.PerformClick();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            addToolStripMenuItem.PerformClick();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            purchaseItemsToolStripMenuItem.PerformClick();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            salesProductToolStripMenuItem.PerformClick();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            dealerInfoToolStripMenuItem.PerformClick();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            purchaseReportToolStripMenuItem.PerformClick();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer welcomeAudio = new System.Media.SoundPlayer(Properties.Resources.hello_4);
            welcomeAudio.Play();

        }
    }
}
