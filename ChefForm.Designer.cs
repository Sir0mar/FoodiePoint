namespace FoodiePointManagementSystem
{
    partial class ChefForm
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
            this.tabControlChef = new System.Windows.Forms.TabControl();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.btnUpdateOrderStatus = new System.Windows.Forms.Button();
            this.cmbOrderStatus = new System.Windows.Forms.ComboBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.foodiePointDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodiePointDBDataSet = new FoodiePointManagementSystem.FoodiePointDBDataSet();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.btnDeleteInventory = new System.Windows.Forms.Button();
            this.btnUpdateInventory = new System.Windows.Forms.Button();
            this.btnAddInventory = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtIngredientName = new System.Windows.Forms.TextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.txtProfilePassword = new System.Windows.Forms.TextBox();
            this.txtProfileEmail = new System.Windows.Forms.TextBox();
            this.tabControlChef.SuspendLayout();
            this.tabOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodiePointDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodiePointDBDataSet)).BeginInit();
            this.tabInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.tabProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlChef
            // 
            this.tabControlChef.Controls.Add(this.tabOrders);
            this.tabControlChef.Controls.Add(this.tabInventory);
            this.tabControlChef.Controls.Add(this.tabProfile);
            this.tabControlChef.Location = new System.Drawing.Point(12, -2);
            this.tabControlChef.Name = "tabControlChef";
            this.tabControlChef.SelectedIndex = 0;
            this.tabControlChef.Size = new System.Drawing.Size(776, 440);
            this.tabControlChef.TabIndex = 0;
            // 
            // tabOrders
            // 
            this.tabOrders.Controls.Add(this.btnUpdateOrderStatus);
            this.tabOrders.Controls.Add(this.cmbOrderStatus);
            this.tabOrders.Controls.Add(this.dgvOrders);
            this.tabOrders.Location = new System.Drawing.Point(4, 28);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrders.Size = new System.Drawing.Size(768, 408);
            this.tabOrders.TabIndex = 0;
            this.tabOrders.Text = "manege";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // btnUpdateOrderStatus
            // 
            this.btnUpdateOrderStatus.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnUpdateOrderStatus.Location = new System.Drawing.Point(256, 324);
            this.btnUpdateOrderStatus.Name = "btnUpdateOrderStatus";
            this.btnUpdateOrderStatus.Size = new System.Drawing.Size(196, 47);
            this.btnUpdateOrderStatus.TabIndex = 2;
            this.btnUpdateOrderStatus.Text = "Update Order Status";
            this.btnUpdateOrderStatus.UseVisualStyleBackColor = true;
       
            // 
            // cmbOrderStatus
            // 
            this.cmbOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderStatus.FormattingEnabled = true;
            this.cmbOrderStatus.Items.AddRange(new object[] {
            "Peding",
            "Inprogress",
            "Completed"});
            this.cmbOrderStatus.Location = new System.Drawing.Point(531, 275);
            this.cmbOrderStatus.Name = "cmbOrderStatus";
            this.cmbOrderStatus.Size = new System.Drawing.Size(157, 26);
            this.cmbOrderStatus.TabIndex = 1;
            this.cmbOrderStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvOrders
            // 
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(73, 26);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 62;
            this.dgvOrders.RowTemplate.Height = 27;
            this.dgvOrders.Size = new System.Drawing.Size(615, 217);
            this.dgvOrders.TabIndex = 0;
            // 
            // foodiePointDBDataSetBindingSource
            // 
            this.foodiePointDBDataSetBindingSource.DataSource = this.foodiePointDBDataSet;
            this.foodiePointDBDataSetBindingSource.Position = 0;
            // 
            // foodiePointDBDataSet
            // 
            this.foodiePointDBDataSet.DataSetName = "FoodiePointDBDataSet";
            this.foodiePointDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.btnDeleteInventory);
            this.tabInventory.Controls.Add(this.btnUpdateInventory);
            this.tabInventory.Controls.Add(this.btnAddInventory);
            this.tabInventory.Controls.Add(this.txtPrice);
            this.tabInventory.Controls.Add(this.txtQuantity);
            this.tabInventory.Controls.Add(this.txtIngredientName);
            this.tabInventory.Controls.Add(this.dgvInventory);
            this.tabInventory.Location = new System.Drawing.Point(4, 28);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(768, 408);
            this.tabInventory.TabIndex = 1;
            this.tabInventory.Text = "stock";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteInventory
            // 
            this.btnDeleteInventory.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnDeleteInventory.Location = new System.Drawing.Point(549, 360);
            this.btnDeleteInventory.Name = "btnDeleteInventory";
            this.btnDeleteInventory.Size = new System.Drawing.Size(132, 31);
            this.btnDeleteInventory.TabIndex = 6;
            this.btnDeleteInventory.Text = "Delete";
            this.btnDeleteInventory.UseVisualStyleBackColor = true;
            this.btnDeleteInventory.Click += new System.EventHandler(this.btnDeleteInventory_Click);
            // 
            // btnUpdateInventory
            // 
            this.btnUpdateInventory.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnUpdateInventory.Location = new System.Drawing.Point(299, 360);
            this.btnUpdateInventory.Name = "btnUpdateInventory";
            this.btnUpdateInventory.Size = new System.Drawing.Size(154, 31);
            this.btnUpdateInventory.TabIndex = 5;
            this.btnUpdateInventory.Text = "Update";
            this.btnUpdateInventory.UseVisualStyleBackColor = true;
            this.btnUpdateInventory.Click += new System.EventHandler(this.btnUpdateInventory_Click);
            // 
            // btnAddInventory
            // 
            this.btnAddInventory.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnAddInventory.Location = new System.Drawing.Point(97, 360);
            this.btnAddInventory.Name = "btnAddInventory";
            this.btnAddInventory.Size = new System.Drawing.Size(126, 31);
            this.btnAddInventory.TabIndex = 4;
            this.btnAddInventory.Text = "Add";
            this.btnAddInventory.UseVisualStyleBackColor = true;
            this.btnAddInventory.Click += new System.EventHandler(this.btnAddInventory_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.txtPrice.Location = new System.Drawing.Point(549, 304);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 29);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.Text = "Price";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.txtQuantity.Location = new System.Drawing.Point(299, 304);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(141, 29);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.Text = "Quantity";
            // 
            // txtIngredientName
            // 
            this.txtIngredientName.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.txtIngredientName.Location = new System.Drawing.Point(93, 304);
            this.txtIngredientName.Name = "txtIngredientName";
            this.txtIngredientName.Size = new System.Drawing.Size(130, 29);
            this.txtIngredientName.TabIndex = 1;
            this.txtIngredientName.Text = "Name";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(65, 32);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 62;
            this.dgvInventory.RowTemplate.Height = 27;
            this.dgvInventory.Size = new System.Drawing.Size(641, 238);
            this.dgvInventory.TabIndex = 0;
            this.dgvInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellContentClick);
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.label2);
            this.tabProfile.Controls.Add(this.label1);
            this.tabProfile.Controls.Add(this.btnUpdateProfile);
            this.tabProfile.Controls.Add(this.txtProfilePassword);
            this.tabProfile.Controls.Add(this.txtProfileEmail);
            this.tabProfile.Location = new System.Drawing.Point(4, 28);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(768, 408);
            this.tabProfile.TabIndex = 2;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label2.Location = new System.Drawing.Point(107, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label1.Location = new System.Drawing.Point(107, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email";
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.btnUpdateProfile.Location = new System.Drawing.Point(264, 342);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(227, 42);
            this.btnUpdateProfile.TabIndex = 2;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            // 
            // txtProfilePassword
            // 
            this.txtProfilePassword.Location = new System.Drawing.Point(289, 226);
            this.txtProfilePassword.Name = "txtProfilePassword";
            this.txtProfilePassword.Size = new System.Drawing.Size(343, 25);
            this.txtProfilePassword.TabIndex = 1;
            this.txtProfilePassword.UseSystemPasswordChar = true;
            this.txtProfilePassword.UseWaitCursor = true;
            // 
            // txtProfileEmail
            // 
            this.txtProfileEmail.Location = new System.Drawing.Point(289, 132);
            this.txtProfileEmail.Name = "txtProfileEmail";
            this.txtProfileEmail.Size = new System.Drawing.Size(343, 25);
            this.txtProfileEmail.TabIndex = 0;
            // 
            // ChefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 565);
            this.Controls.Add(this.tabControlChef);
            this.Name = "ChefForm";
            this.Text = "ChefForm";
            this.Load += new System.EventHandler(this.ChefForm_Load);
            this.tabControlChef.ResumeLayout(false);
            this.tabOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodiePointDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodiePointDBDataSet)).EndInit();
            this.tabInventory.ResumeLayout(false);
            this.tabInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.tabProfile.ResumeLayout(false);
            this.tabProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlChef;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.BindingSource foodiePointDBDataSetBindingSource;
        private FoodiePointDBDataSet foodiePointDBDataSet;
        private System.Windows.Forms.ComboBox cmbOrderStatus;
        private System.Windows.Forms.Button btnUpdateOrderStatus;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtIngredientName;
        private System.Windows.Forms.Button btnDeleteInventory;
        private System.Windows.Forms.Button btnUpdateInventory;
        private System.Windows.Forms.Button btnAddInventory;
        private System.Windows.Forms.TextBox txtProfilePassword;
        private System.Windows.Forms.TextBox txtProfileEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateProfile;
    }
}