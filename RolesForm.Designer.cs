namespace nikadoResturant
{
    partial class RolesForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label r_IdLabel;
            System.Windows.Forms.Label u_IdLabel;
            System.Windows.Forms.Label r_nameLabel;
            System.Windows.Forms.Label dobLabel;
            System.Windows.Forms.Label nICLabel;
            System.Windows.Forms.Label photoLabel;
            System.Windows.Forms.Label salleryLabel;
            System.Windows.Forms.Label w_hrsLabel;
            System.Windows.Forms.Label maleLabel;
            System.Windows.Forms.Label femaleLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RolesForm));
            this.nikadoResturantDataSet = new nikadoResturant.NikadoResturantDataSet();
            this.rolesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableTableAdapter = new nikadoResturant.NikadoResturantDataSetTableAdapters.RolesTableTableAdapter();
            this.tableAdapterManager = new nikadoResturant.NikadoResturantDataSetTableAdapters.TableAdapterManager();
            this.userTableTableAdapter = new nikadoResturant.NikadoResturantDataSetTableAdapters.userTableTableAdapter();
            this.rolesTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rolesTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.r_IdMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.u_IdComboBox = new System.Windows.Forms.ComboBox();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.r_nameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nICMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.salleryMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.w_hrsMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PhotoopenDialog = new System.Windows.Forms.OpenFileDialog();
            this.Photobutton = new System.Windows.Forms.Button();
            this.findbutton = new System.Windows.Forms.Button();
            this.rolesTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            r_IdLabel = new System.Windows.Forms.Label();
            u_IdLabel = new System.Windows.Forms.Label();
            r_nameLabel = new System.Windows.Forms.Label();
            dobLabel = new System.Windows.Forms.Label();
            nICLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            salleryLabel = new System.Windows.Forms.Label();
            w_hrsLabel = new System.Windows.Forms.Label();
            maleLabel = new System.Windows.Forms.Label();
            femaleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nikadoResturantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesTableBindingNavigator)).BeginInit();
            this.rolesTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // r_IdLabel
            // 
            r_IdLabel.AutoSize = true;
            r_IdLabel.Location = new System.Drawing.Point(31, 58);
            r_IdLabel.Name = "r_IdLabel";
            r_IdLabel.Size = new System.Drawing.Size(45, 25);
            r_IdLabel.TabIndex = 1;
            r_IdLabel.Text = "r Id:";
            // 
            // u_IdLabel
            // 
            u_IdLabel.AutoSize = true;
            u_IdLabel.Location = new System.Drawing.Point(32, 94);
            u_IdLabel.Name = "u_IdLabel";
            u_IdLabel.Size = new System.Drawing.Size(50, 25);
            u_IdLabel.TabIndex = 3;
            u_IdLabel.Text = "u Id:";
            // 
            // r_nameLabel
            // 
            r_nameLabel.AutoSize = true;
            r_nameLabel.Location = new System.Drawing.Point(31, 131);
            r_nameLabel.Name = "r_nameLabel";
            r_nameLabel.Size = new System.Drawing.Size(78, 25);
            r_nameLabel.TabIndex = 5;
            r_nameLabel.Text = "r name:";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new System.Drawing.Point(31, 261);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new System.Drawing.Size(51, 25);
            dobLabel.TabIndex = 7;
            dobLabel.Text = "dob:";
            // 
            // nICLabel
            // 
            nICLabel.AutoSize = true;
            nICLabel.Location = new System.Drawing.Point(31, 165);
            nICLabel.Name = "nICLabel";
            nICLabel.Size = new System.Drawing.Size(52, 25);
            nICLabel.TabIndex = 9;
            nICLabel.Text = "NIC:";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(613, 77);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(67, 25);
            photoLabel.TabIndex = 11;
            photoLabel.Text = "photo:";
            // 
            // salleryLabel
            // 
            salleryLabel.AutoSize = true;
            salleryLabel.Location = new System.Drawing.Point(31, 203);
            salleryLabel.Name = "salleryLabel";
            salleryLabel.Size = new System.Drawing.Size(74, 25);
            salleryLabel.TabIndex = 13;
            salleryLabel.Text = "sallery:";
            // 
            // w_hrsLabel
            // 
            w_hrsLabel.AutoSize = true;
            w_hrsLabel.Location = new System.Drawing.Point(32, 298);
            w_hrsLabel.Name = "w_hrsLabel";
            w_hrsLabel.Size = new System.Drawing.Size(64, 25);
            w_hrsLabel.TabIndex = 15;
            w_hrsLabel.Text = "w hrs:";
            // 
            // maleLabel
            // 
            maleLabel.AutoSize = true;
            maleLabel.Location = new System.Drawing.Point(25, 34);
            maleLabel.Name = "maleLabel";
            maleLabel.Size = new System.Drawing.Size(61, 25);
            maleLabel.TabIndex = 17;
            maleLabel.Text = "Male:";
            // 
            // femaleLabel
            // 
            femaleLabel.AutoSize = true;
            femaleLabel.Location = new System.Drawing.Point(25, 66);
            femaleLabel.Name = "femaleLabel";
            femaleLabel.Size = new System.Drawing.Size(83, 25);
            femaleLabel.TabIndex = 19;
            femaleLabel.Text = "Female:";
            // 
            // nikadoResturantDataSet
            // 
            this.nikadoResturantDataSet.DataSetName = "NikadoResturantDataSet";
            this.nikadoResturantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolesTableBindingSource
            // 
            this.rolesTableBindingSource.DataMember = "RolesTable";
            this.rolesTableBindingSource.DataSource = this.nikadoResturantDataSet;
            // 
            // rolesTableTableAdapter
            // 
            this.rolesTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RolesTableTableAdapter = this.rolesTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = nikadoResturant.NikadoResturantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableTableAdapter = this.userTableTableAdapter;
            // 
            // userTableTableAdapter
            // 
            this.userTableTableAdapter.ClearBeforeFill = true;
            // 
            // rolesTableBindingNavigator
            // 
            this.rolesTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rolesTableBindingNavigator.BindingSource = this.rolesTableBindingSource;
            this.rolesTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rolesTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rolesTableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rolesTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.rolesTableBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.rolesTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rolesTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rolesTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rolesTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rolesTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rolesTableBindingNavigator.Name = "rolesTableBindingNavigator";
            this.rolesTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rolesTableBindingNavigator.Size = new System.Drawing.Size(864, 31);
            this.rolesTableBindingNavigator.TabIndex = 0;
            this.rolesTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // rolesTableBindingNavigatorSaveItem
            // 
            this.rolesTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rolesTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rolesTableBindingNavigatorSaveItem.Image")));
            this.rolesTableBindingNavigatorSaveItem.Name = "rolesTableBindingNavigatorSaveItem";
            this.rolesTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.rolesTableBindingNavigatorSaveItem.Text = "Save Data";
            this.rolesTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.rolesTableBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "Cancel";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // r_IdMaskedTextBox
            // 
            this.r_IdMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolesTableBindingSource, "r_Id", true));
            this.r_IdMaskedTextBox.Location = new System.Drawing.Point(133, 53);
            this.r_IdMaskedTextBox.Name = "r_IdMaskedTextBox";
            this.r_IdMaskedTextBox.Size = new System.Drawing.Size(285, 30);
            this.r_IdMaskedTextBox.TabIndex = 2;
            // 
            // u_IdComboBox
            // 
            this.u_IdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rolesTableBindingSource, "u_Id", true));
            this.u_IdComboBox.DataSource = this.userTableBindingSource;
            this.u_IdComboBox.DisplayMember = "u_name";
            this.u_IdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.u_IdComboBox.FormattingEnabled = true;
            this.u_IdComboBox.Location = new System.Drawing.Point(133, 91);
            this.u_IdComboBox.Name = "u_IdComboBox";
            this.u_IdComboBox.Size = new System.Drawing.Size(285, 33);
            this.u_IdComboBox.TabIndex = 4;
            // 
            // userTableBindingSource
            // 
            this.userTableBindingSource.DataMember = "userTable";
            this.userTableBindingSource.DataSource = this.nikadoResturantDataSet;
            // 
            // r_nameMaskedTextBox
            // 
            this.r_nameMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolesTableBindingSource, "r_name", true));
            this.r_nameMaskedTextBox.Location = new System.Drawing.Point(133, 126);
            this.r_nameMaskedTextBox.Name = "r_nameMaskedTextBox";
            this.r_nameMaskedTextBox.Size = new System.Drawing.Size(285, 30);
            this.r_nameMaskedTextBox.TabIndex = 6;
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rolesTableBindingSource, "dob", true));
            this.dobDateTimePicker.Location = new System.Drawing.Point(133, 256);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(473, 30);
            this.dobDateTimePicker.TabIndex = 8;
            // 
            // nICMaskedTextBox
            // 
            this.nICMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolesTableBindingSource, "NIC", true));
            this.nICMaskedTextBox.Location = new System.Drawing.Point(133, 162);
            this.nICMaskedTextBox.Name = "nICMaskedTextBox";
            this.nICMaskedTextBox.Size = new System.Drawing.Size(285, 30);
            this.nICMaskedTextBox.TabIndex = 10;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BackColor = System.Drawing.Color.White;
            this.photoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.rolesTableBindingSource, "photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(449, 105);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(231, 145);
            this.photoPictureBox.TabIndex = 12;
            this.photoPictureBox.TabStop = false;
            // 
            // salleryMaskedTextBox
            // 
            this.salleryMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolesTableBindingSource, "sallery", true));
            this.salleryMaskedTextBox.Location = new System.Drawing.Point(133, 198);
            this.salleryMaskedTextBox.Name = "salleryMaskedTextBox";
            this.salleryMaskedTextBox.Size = new System.Drawing.Size(285, 30);
            this.salleryMaskedTextBox.TabIndex = 14;
            // 
            // w_hrsMaskedTextBox
            // 
            this.w_hrsMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolesTableBindingSource, "w_hrs", true));
            this.w_hrsMaskedTextBox.Location = new System.Drawing.Point(133, 295);
            this.w_hrsMaskedTextBox.Name = "w_hrsMaskedTextBox";
            this.w_hrsMaskedTextBox.Size = new System.Drawing.Size(625, 30);
            this.w_hrsMaskedTextBox.TabIndex = 16;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.rolesTableBindingSource, "Male", true));
            this.maleRadioButton.Location = new System.Drawing.Point(125, 27);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(583, 39);
            this.maleRadioButton.TabIndex = 18;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.UseVisualStyleBackColor = true;
            this.maleRadioButton.CheckedChanged += new System.EventHandler(this.maleRadioButton_CheckedChanged);
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.rolesTableBindingSource, "Female", true));
            this.femaleRadioButton.Location = new System.Drawing.Point(125, 58);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(625, 41);
            this.femaleRadioButton.TabIndex = 20;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(maleLabel);
            this.groupBox1.Controls.Add(femaleLabel);
            this.groupBox1.Controls.Add(this.maleRadioButton);
            this.groupBox1.Controls.Add(this.femaleRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(37, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // PhotoopenDialog
            // 
            this.PhotoopenDialog.FileName = "openFileDialog1";
            this.PhotoopenDialog.Filter = "image Files | *.bmp; *.jpg; *.gif; *.png";
            // 
            // Photobutton
            // 
            this.Photobutton.Location = new System.Drawing.Point(686, 207);
            this.Photobutton.Name = "Photobutton";
            this.Photobutton.Size = new System.Drawing.Size(114, 43);
            this.Photobutton.TabIndex = 22;
            this.Photobutton.Text = "Browse....";
            this.Photobutton.UseVisualStyleBackColor = true;
            this.Photobutton.Click += new System.EventHandler(this.Photobutton_Click);
            // 
            // findbutton
            // 
            this.findbutton.Location = new System.Drawing.Point(436, 53);
            this.findbutton.Name = "findbutton";
            this.findbutton.Size = new System.Drawing.Size(89, 30);
            this.findbutton.TabIndex = 23;
            this.findbutton.Text = "Find";
            this.findbutton.UseVisualStyleBackColor = true;
            this.findbutton.Click += new System.EventHandler(this.findbutton_Click);
            // 
            // rolesTableDataGridView
            // 
            this.rolesTableDataGridView.AllowUserToAddRows = false;
            this.rolesTableDataGridView.AllowUserToDeleteRows = false;
            this.rolesTableDataGridView.AutoGenerateColumns = false;
            this.rolesTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.rolesTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2});
            this.rolesTableDataGridView.DataSource = this.rolesTableBindingSource;
            this.rolesTableDataGridView.Location = new System.Drawing.Point(36, 466);
            this.rolesTableDataGridView.Name = "rolesTableDataGridView";
            this.rolesTableDataGridView.ReadOnly = true;
            this.rolesTableDataGridView.RowHeadersWidth = 51;
            this.rolesTableDataGridView.RowTemplate.Height = 24;
            this.rolesTableDataGridView.Size = new System.Drawing.Size(789, 163);
            this.rolesTableDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "r_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "r_Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 74;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "u_Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "u_Id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 79;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "r_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "r_name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 107;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dob";
            this.dataGridViewTextBoxColumn4.HeaderText = "dob";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 74;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NIC";
            this.dataGridViewTextBoxColumn5.HeaderText = "NIC";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "photo";
            this.dataGridViewImageColumn1.HeaderText = "photo";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 67;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "sallery";
            this.dataGridViewTextBoxColumn6.HeaderText = "sallery";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 97;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "w_hrs";
            this.dataGridViewTextBoxColumn7.HeaderText = "w_hrs";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 93;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Male";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Male";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 61;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Female";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Female";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Width = 83;
            // 
            // RolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(864, 671);
            this.Controls.Add(this.rolesTableDataGridView);
            this.Controls.Add(this.findbutton);
            this.Controls.Add(this.Photobutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(r_IdLabel);
            this.Controls.Add(this.r_IdMaskedTextBox);
            this.Controls.Add(u_IdLabel);
            this.Controls.Add(this.u_IdComboBox);
            this.Controls.Add(r_nameLabel);
            this.Controls.Add(this.r_nameMaskedTextBox);
            this.Controls.Add(dobLabel);
            this.Controls.Add(this.dobDateTimePicker);
            this.Controls.Add(nICLabel);
            this.Controls.Add(this.nICMaskedTextBox);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(salleryLabel);
            this.Controls.Add(this.salleryMaskedTextBox);
            this.Controls.Add(w_hrsLabel);
            this.Controls.Add(this.w_hrsMaskedTextBox);
            this.Controls.Add(this.rolesTableBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RolesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.RolesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nikadoResturantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesTableBindingNavigator)).EndInit();
            this.rolesTableBindingNavigator.ResumeLayout(false);
            this.rolesTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NikadoResturantDataSet nikadoResturantDataSet;
        private System.Windows.Forms.BindingSource rolesTableBindingSource;
        private NikadoResturantDataSetTableAdapters.RolesTableTableAdapter rolesTableTableAdapter;
        private NikadoResturantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rolesTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton rolesTableBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox r_IdMaskedTextBox;
        private System.Windows.Forms.ComboBox u_IdComboBox;
        private System.Windows.Forms.MaskedTextBox r_nameMaskedTextBox;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.MaskedTextBox nICMaskedTextBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.MaskedTextBox salleryMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox w_hrsMaskedTextBox;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private NikadoResturantDataSetTableAdapters.userTableTableAdapter userTableTableAdapter;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private System.Windows.Forms.OpenFileDialog PhotoopenDialog;
        private System.Windows.Forms.Button Photobutton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button findbutton;
        private System.Windows.Forms.DataGridView rolesTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
    }
}