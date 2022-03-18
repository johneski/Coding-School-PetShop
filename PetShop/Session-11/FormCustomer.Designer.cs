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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.gridCustomerList.Location = new System.Drawing.Point(59, 188);
            this.gridCustomerList.MainView = this.gridView1;
            this.gridCustomerList.Name = "gridCustomerList";
            this.gridCustomerList.Size = new System.Drawing.Size(500, 250);
            this.gridCustomerList.TabIndex = 0;
            this.gridCustomerList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridName,
            this.gridSurname,
            this.gridPhone,
            this.gridTIN});
            this.gridView1.GridControl = this.gridCustomerList;
            this.gridView1.Name = "gridView1";
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
            this.ctrlName.Location = new System.Drawing.Point(59, 21);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Size = new System.Drawing.Size(156, 22);
            this.ctrlName.TabIndex = 1;
            // 
            // ctrlSurname
            // 
            this.ctrlSurname.Location = new System.Drawing.Point(59, 60);
            this.ctrlSurname.Name = "ctrlSurname";
            this.ctrlSurname.Size = new System.Drawing.Size(156, 22);
            this.ctrlSurname.TabIndex = 2;
            // 
            // ctrlFullname
            // 
            this.ctrlFullname.Location = new System.Drawing.Point(59, 97);
            this.ctrlFullname.Name = "ctrlFullname";
            this.ctrlFullname.Size = new System.Drawing.Size(156, 22);
            this.ctrlFullname.TabIndex = 3;
            // 
            // ctrlTIN
            // 
            this.ctrlTIN.Location = new System.Drawing.Point(59, 125);
            this.ctrlTIN.Name = "ctrlTIN";
            this.ctrlTIN.Size = new System.Drawing.Size(156, 22);
            this.ctrlTIN.TabIndex = 4;
            // 
            // ctrlPhoneNumber
            // 
            this.ctrlPhoneNumber.Location = new System.Drawing.Point(59, 162);
            this.ctrlPhoneNumber.Name = "ctrlPhoneNumber";
            this.ctrlPhoneNumber.Size = new System.Drawing.Size(156, 22);
            this.ctrlPhoneNumber.TabIndex = 5;
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlPhoneNumber);
            this.Controls.Add(this.ctrlTIN);
            this.Controls.Add(this.ctrlFullname);
            this.Controls.Add(this.ctrlSurname);
            this.Controls.Add(this.ctrlName);
            this.Controls.Add(this.gridCustomerList);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlFullname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTIN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPhoneNumber.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCustomerList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
    }
}