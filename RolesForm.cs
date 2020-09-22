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
    public partial class RolesForm : Form
    {
        public RolesForm()
        {
            InitializeComponent();
        }

        private void rolesTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rolesTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nikadoResturantDataSet);

        }

        private void RolesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nikadoResturantDataSet.userTable' table. You can move, or remove it, as needed.
            this.userTableTableAdapter.Fill(this.nikadoResturantDataSet.userTable);
            // TODO: This line of code loads data into the 'nikadoResturantDataSet.RolesTable' table. You can move, or remove it, as needed.
            this.rolesTableTableAdapter.Fill(this.nikadoResturantDataSet.RolesTable);

        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Photobutton_Click(object sender, EventArgs e)
        {
            PhotoopenDialog.FileName = "";
            if (PhotoopenDialog.ShowDialog() == DialogResult.OK)
            {
                photoPictureBox.Image = Image.FromFile(PhotoopenDialog.FileName);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            rolesTableBindingSource.CancelEdit();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void findbutton_Click(object sender, EventArgs e)
        {
            string value;
            int index;
            value = Microsoft.VisualBasic.Interaction.InputBox("Role_Id", "Find Role Info");
            index = rolesTableBindingSource.Find("r_Id", value);
            rolesTableBindingSource.Position = index;
        }
    }
}
