
namespace Contacts
{
    partial class ContactDetails
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
            this.FirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(23, 30);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(111, 24);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "First Name :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(153, 25);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(204, 29);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtxFirstName_TextChanged);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(23, 70);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(109, 24);
            this.LastName.TabIndex = 0;
            this.LastName.Text = "Last Name :";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(153, 65);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(204, 29);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtxFirstName_TextChanged);
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(23, 108);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(76, 24);
            this.Phone.TabIndex = 0;
            this.Phone.Text = "Phone :";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(153, 103);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(204, 29);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtxFirstName_TextChanged);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(23, 144);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(90, 24);
            this.Address.TabIndex = 0;
            this.Address.Text = "Address :";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(153, 139);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(204, 29);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtxFirstName_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(153, 197);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(261, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ContactDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 304);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Name = "ContactDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactDeatails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}