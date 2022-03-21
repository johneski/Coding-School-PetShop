namespace Session_11
{
    partial class AddNewPetForm
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
            this.ctrlAnimalType = new DevExpress.XtraEditors.LabelControl();
            this.ctrlBreed = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.cmbAnimalType = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtBreed = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtCost = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBreed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCost.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlAnimalType
            // 
            this.ctrlAnimalType.Location = new System.Drawing.Point(12, 32);
            this.ctrlAnimalType.Name = "ctrlAnimalType";
            this.ctrlAnimalType.Size = new System.Drawing.Size(55, 13);
            this.ctrlAnimalType.TabIndex = 6;
            this.ctrlAnimalType.Text = "AnimalType";
            // 
            // ctrlBreed
            // 
            this.ctrlBreed.Location = new System.Drawing.Point(12, 67);
            this.ctrlBreed.Name = "ctrlBreed";
            this.ctrlBreed.Size = new System.Drawing.Size(28, 13);
            this.ctrlBreed.TabIndex = 7;
            this.ctrlBreed.Text = "Breed";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 107);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Status";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(38, 224);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(190, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbAnimalType
            // 
            this.cmbAnimalType.FormattingEnabled = true;
            this.cmbAnimalType.Location = new System.Drawing.Point(94, 28);
            this.cmbAnimalType.Name = "cmbAnimalType";
            this.cmbAnimalType.Size = new System.Drawing.Size(159, 23);
            this.cmbAnimalType.TabIndex = 12;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(94, 97);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(159, 23);
            this.cmbStatus.TabIndex = 13;
            // 
            // txtBreed
            // 
            this.txtBreed.Location = new System.Drawing.Point(94, 60);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(158, 20);
            this.txtBreed.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 148);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 13);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Price";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 184);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(22, 13);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Cost";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(94, 141);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.DisplayFormat.FormatString = "c2";
            this.txtPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPrice.Properties.EditFormat.FormatString = "c2";
            this.txtPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPrice.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtPrice.Size = new System.Drawing.Size(55, 20);
            this.txtPrice.TabIndex = 18;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(94, 177);
            this.txtCost.Name = "txtCost";
            this.txtCost.Properties.DisplayFormat.FormatString = "c2";
            this.txtCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCost.Properties.EditFormat.FormatString = "c2";
            this.txtCost.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCost.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCost.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtCost.Size = new System.Drawing.Size(55, 20);
            this.txtCost.TabIndex = 19;
            // 
            // AddNewPetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 266);
            this.ControlBox = false;
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtBreed);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbAnimalType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.ctrlBreed);
            this.Controls.Add(this.ctrlAnimalType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewPetForm";
            this.Text = "New Pet";
            this.Load += new System.EventHandler(this.AddNewPetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBreed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCost.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl ctrlAnimalType;
        private DevExpress.XtraEditors.LabelControl ctrlBreed;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private ComboBox cmbAnimalType;
        private ComboBox cmbStatus;
        private DevExpress.XtraEditors.TextEdit txtBreed;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.TextEdit txtCost;
    }
}