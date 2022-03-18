namespace Session_11
{
    partial class FormCustomer
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
            this.gridCustomerList = new DevExpress.XtraGrid.GridControl();
            this.gridViewCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.ctrlName = new DevExpress.XtraEditors.TextEdit();
            this.ctrlSurname = new DevExpress.XtraEditors.TextEdit();
            this.ctrlFullname = new DevExpress.XtraEditors.TextEdit();
            this.ctrlTIN = new DevExpress.XtraEditors.TextEdit();
            this.ctrlPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTIN = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlFullname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTIN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPhoneNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCustomerList
            // 
            this.gridCustomerList.Location = new System.Drawing.Point(585, 179);
            this.gridCustomerList.MainView = this.gridViewCustomers;
            this.gridCustomerList.Name = "gridCustomerList";
            this.gridCustomerList.Size = new System.Drawing.Size(528, 259);
            this.gridCustomerList.TabIndex = 0;
            this.gridCustomerList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCustomers});
            // 
            // gridViewCustomers
            // 
            this.gridViewCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridName,
            this.gridSurname,
            this.gridPhone,
            this.gridTIN});
            this.gridViewCustomers.GridControl = this.gridCustomerList;
            this.gridViewCustomers.Name = "gridViewCustomers";
            this.gridViewCustomers.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewCustomers_FocusedRowChanged);
            // 
            // gridName
            // 
            this.gridName.Caption = "Name";
            this.gridName.FieldName = "Name";
            this.gridName.MinWidth = 25;
            this.gridName.Name = "gridName";
            this.gridName.Visible = true;
            this.gridName.VisibleIndex = 0;
            this.gridName.Width = 94;
            // 
            // gridSurname
            // 
            this.gridSurname.Caption = "Surname";
            this.gridSurname.FieldName = "Surname";
            this.gridSurname.MinWidth = 25;
            this.gridSurname.Name = "gridSurname";
            this.gridSurname.Visible = true;
            this.gridSurname.VisibleIndex = 1;
            this.gridSurname.Width = 94;
            // 
            // gridPhone
            // 
            this.gridPhone.Caption = "Phone";
            this.gridPhone.FieldName = "PhoneNumber";
            this.gridPhone.MinWidth = 25;
            this.gridPhone.Name = "gridPhone";
            this.gridPhone.Visible = true;
            this.gridPhone.VisibleIndex = 2;
            this.gridPhone.Width = 94;
            // 
            // gridTIN
            // 
            this.gridTIN.Caption = "TIN";
            this.gridTIN.FieldName = "Tin";
            this.gridTIN.MinWidth = 25;
            this.gridTIN.Name = "gridTIN";
            this.gridTIN.Visible = true;
            this.gridTIN.VisibleIndex = 3;
            this.gridTIN.Width = 94;
            // 
            // bsCustomers
            // 
            this.bsCustomers.CurrentChanged += new System.EventHandler(this.bindingPetShopCustomers_CurrentChanged);
            // 
            // ctrlName
            // 
            this.ctrlName.Location = new System.Drawing.Point(640, 57);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Size = new System.Drawing.Size(418, 22);
            this.ctrlName.TabIndex = 1;
            this.ctrlName.EditValueChanged += new System.EventHandler(this.ctrlName_EditValueChanged);
            this.ctrlName.TextChanged += new System.EventHandler(this.ctrlName_TextChanged);
            // 
            // ctrlSurname
            // 
            this.ctrlSurname.Location = new System.Drawing.Point(640, 85);
            this.ctrlSurname.Name = "ctrlSurname";
            this.ctrlSurname.Size = new System.Drawing.Size(418, 22);
            this.ctrlSurname.TabIndex = 2;
            // 
            // ctrlFullname
            // 
            this.ctrlFullname.Location = new System.Drawing.Point(640, 27);
            this.ctrlFullname.Name = "ctrlFullname";
            this.ctrlFullname.Size = new System.Drawing.Size(418, 22);
            this.ctrlFullname.TabIndex = 3;
            // 
            // ctrlTIN
            // 
            this.ctrlTIN.Location = new System.Drawing.Point(640, 141);
            this.ctrlTIN.Name = "ctrlTIN";
            this.ctrlTIN.Size = new System.Drawing.Size(418, 22);
            this.ctrlTIN.TabIndex = 4;
            // 
            // ctrlPhoneNumber
            // 
            this.ctrlPhoneNumber.Location = new System.Drawing.Point(640, 113);
            this.ctrlPhoneNumber.Name = "ctrlPhoneNumber";
            this.ctrlPhoneNumber.Size = new System.Drawing.Size(418, 22);
            this.ctrlPhoneNumber.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(402, 71);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 36);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFullName.Location = new System.Drawing.Point(569, 28);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(66, 19);
            this.labelFullName.TabIndex = 7;
            this.labelFullName.Text = "FullName";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(569, 59);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 19);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Name";
            // 
            // labelTIN
            // 
            this.labelTIN.AutoSize = true;
            this.labelTIN.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTIN.Location = new System.Drawing.Point(584, 142);
            this.labelTIN.Name = "labelTIN";
            this.labelTIN.Size = new System.Drawing.Size(30, 19);
            this.labelTIN.TabIndex = 9;
            this.labelTIN.Text = "TIN";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPhone.Location = new System.Drawing.Point(569, 115);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(48, 19);
            this.labelPhone.TabIndex = 10;
            this.labelPhone.Text = "Phone";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSurname.Location = new System.Drawing.Point(569, 86);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(63, 19);
            this.labelSurname.TabIndex = 11;
            this.labelSurname.Text = "Surname";
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 450);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelTIN);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrlPhoneNumber);
            this.Controls.Add(this.ctrlTIN);
            this.Controls.Add(this.ctrlFullname);
            this.Controls.Add(this.gridCustomerList);
            this.Controls.Add(this.ctrlSurname);
            this.Controls.Add(this.ctrlName);
            this.Name = "FormCustomer";
            this.Text = "FormCustomers";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlFullname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTIN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPhoneNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCustomerList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn gridName;
        private DevExpress.XtraGrid.Columns.GridColumn gridSurname;
        private DevExpress.XtraGrid.Columns.GridColumn gridPhone;
        private DevExpress.XtraGrid.Columns.GridColumn gridTIN;
        private BindingSource bsCustomers;
        private DevExpress.XtraEditors.TextEdit ctrlName;
        private DevExpress.XtraEditors.TextEdit ctrlSurname;
        private DevExpress.XtraEditors.TextEdit ctrlFullname;
        private DevExpress.XtraEditors.TextEdit ctrlTIN;
        private DevExpress.XtraEditors.TextEdit ctrlPhoneNumber;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private Label labelFullName;
        private Label labelName;
        private Label labelTIN;
        private Label labelPhone;
        private Label labelSurname;
    }
}