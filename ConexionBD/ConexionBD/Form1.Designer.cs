
namespace ConexionBD
{
    partial class Form1
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
            this.bdconexion = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.failToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chromeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLoseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdconexion
            // 
            this.bdconexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdconexion.Location = new System.Drawing.Point(480, 77);
            this.bdconexion.Name = "bdconexion";
            this.bdconexion.Size = new System.Drawing.Size(105, 27);
            this.bdconexion.TabIndex = 1;
            this.bdconexion.Text = "Conexión";
            this.bdconexion.UseVisualStyleBackColor = true;
            this.bdconexion.Click += new System.EventHandler(this.bdconexion_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(41, 77);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 17);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(41, 109);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(58, 17);
            this.labelApellido.TabIndex = 3;
            this.labelApellido.Text = "Apellido";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdad.Location = new System.Drawing.Point(41, 143);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(41, 17);
            this.labelEdad.TabIndex = 4;
            this.labelEdad.Text = "Edad";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(132, 109);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(177, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(132, 142);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(177, 20);
            this.txtAge.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(397, 216);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(493, 216);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 9;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(588, 216);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(682, 216);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(482, 40);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 27);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(527, 118);
            this.dataGridView1.TabIndex = 13;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(68, 221);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(177, 20);
            this.txtsearch.TabIndex = 15;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(41, 222);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 17);
            this.labelID.TabIndex = 14;
            this.labelID.Text = "ID";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(265, 219);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.failToolStripMenuItem,
            this.toolBoxToolStripMenuItem,
            this.cLoseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // failToolStripMenuItem
            // 
            this.failToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.failToolStripMenuItem.Name = "failToolStripMenuItem";
            this.failToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.failToolStripMenuItem.Text = "File";
            this.failToolStripMenuItem.Click += new System.EventHandler(this.failToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // toolBoxToolStripMenuItem
            // 
            this.toolBoxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordToolStripMenuItem,
            this.chromeToolStripMenuItem,
            this.excelToolStripMenuItem,
            this.calculadoraToolStripMenuItem});
            this.toolBoxToolStripMenuItem.Name = "toolBoxToolStripMenuItem";
            this.toolBoxToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.toolBoxToolStripMenuItem.Text = "ToolBox";
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.wordToolStripMenuItem.Text = "Word";
            this.wordToolStripMenuItem.Click += new System.EventHandler(this.wordToolStripMenuItem_Click);
            // 
            // chromeToolStripMenuItem
            // 
            this.chromeToolStripMenuItem.Name = "chromeToolStripMenuItem";
            this.chromeToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.chromeToolStripMenuItem.Text = "Chrome";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // cLoseToolStripMenuItem
            // 
            this.cLoseToolStripMenuItem.Name = "cLoseToolStripMenuItem";
            this.cLoseToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.cLoseToolStripMenuItem.Text = "CLose";
            this.cLoseToolStripMenuItem.Click += new System.EventHandler(this.cLoseToolStripMenuItem_Click);
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid.Location = new System.Drawing.Point(44, 40);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(19, 17);
            this.lbid.TabIndex = 18;
            this.lbid.Text = "Id";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(132, 47);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(177, 20);
            this.txtid.TabIndex = 19;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(480, 110);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 27);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.bdconexion);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bdconexion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem failToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLoseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chromeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnClear;
    }
}

