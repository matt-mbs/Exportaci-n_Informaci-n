namespace Exportación_Información
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void InitializeComponent()
        {
            this.btnLoadDB = new System.Windows.Forms.Button();
            this.comboTables = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExportTXT = new System.Windows.Forms.Button();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.btnExportXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadDB
            // 
            this.btnLoadDB.Location = new System.Drawing.Point(12, 12);
            this.btnLoadDB.Name = "btnLoadDB";
            this.btnLoadDB.Size = new System.Drawing.Size(140, 30);
            this.btnLoadDB.TabIndex = 0;
            this.btnLoadDB.Text = "Cargar SQLite";
            this.btnLoadDB.UseVisualStyleBackColor = true;
            this.btnLoadDB.Click += new System.EventHandler(this.btnLoadDB_Click);
            // 
            // comboTables
            // 
            this.comboTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTables.FormattingEnabled = true;
            this.comboTables.Location = new System.Drawing.Point(170, 15);
            this.comboTables.Name = "comboTables";
            this.comboTables.Size = new System.Drawing.Size(250, 23);
            this.comboTables.TabIndex = 1;
            this.comboTables.SelectedIndexChanged += new System.EventHandler(this.comboTables_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                                | System.Windows.Forms.AnchorStyles.Left)
                                                                                | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 350);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnExportTXT
            // 
            this.btnExportTXT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExportTXT.Location = new System.Drawing.Point(150, 420);
            this.btnExportTXT.Name = "btnExportTXT";
            this.btnExportTXT.Size = new System.Drawing.Size(140, 30);
            this.btnExportTXT.TabIndex = 3;
            this.btnExportTXT.Text = "Exportar a TXT";
            this.btnExportTXT.UseVisualStyleBackColor = true;
            this.btnExportTXT.Click += new System.EventHandler(this.btnExportTXT_Click);
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExportCSV.Location = new System.Drawing.Point(310, 420);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(140, 30);
            this.btnExportCSV.TabIndex = 4;
            this.btnExportCSV.Text = "Exportar a CSV";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // btnExportXML
            // 
            this.btnExportXML.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExportXML.Location = new System.Drawing.Point(470, 420);
            this.btnExportXML.Name = "btnExportXML";
            this.btnExportXML.Size = new System.Drawing.Size(140, 30);
            this.btnExportXML.TabIndex = 5;
            this.btnExportXML.Text = "Exportar a XML";
            this.btnExportXML.UseVisualStyleBackColor = true;
            this.btnExportXML.Click += new System.EventHandler(this.btnExportXML_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnExportXML);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.btnExportTXT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboTables);
            this.Controls.Add(this.btnLoadDB);
            this.Name = "Form1";
            this.Text = "Exportador SQLite";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnLoadDB;
        private System.Windows.Forms.ComboBox comboTables;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExportTXT;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Button btnExportXML;
    }
}
