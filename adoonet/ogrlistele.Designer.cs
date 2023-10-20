namespace adoonet
{
    partial class ogrlistele
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
            this.button1 = new System.Windows.Forms.Button();
            this.ogrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.okulnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isimsoyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ogrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(640, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // okulnoDataGridViewTextBoxColumn
            // 
            this.okulnoDataGridViewTextBoxColumn.DataPropertyName = "okulno";
            this.okulnoDataGridViewTextBoxColumn.HeaderText = "okulno";
            this.okulnoDataGridViewTextBoxColumn.Name = "okulnoDataGridViewTextBoxColumn";
            // 
            // isimsoyisimDataGridViewTextBoxColumn
            // 
            this.isimsoyisimDataGridViewTextBoxColumn.DataPropertyName = "isimsoyisim";
            this.isimsoyisimDataGridViewTextBoxColumn.HeaderText = "isimsoyisim";
            this.isimsoyisimDataGridViewTextBoxColumn.Name = "isimsoyisimDataGridViewTextBoxColumn";
            // 
            // cepnoDataGridViewTextBoxColumn
            // 
            this.cepnoDataGridViewTextBoxColumn.DataPropertyName = "cepno";
            this.cepnoDataGridViewTextBoxColumn.HeaderText = "cepno";
            this.cepnoDataGridViewTextBoxColumn.Name = "cepnoDataGridViewTextBoxColumn";
            // 
            // bolumDataGridViewTextBoxColumn
            // 
            this.bolumDataGridViewTextBoxColumn.DataPropertyName = "bolum";
            this.bolumDataGridViewTextBoxColumn.HeaderText = "bolum";
            this.bolumDataGridViewTextBoxColumn.Name = "bolumDataGridViewTextBoxColumn";
            // 
            // sinifDataGridViewTextBoxColumn
            // 
            this.sinifDataGridViewTextBoxColumn.DataPropertyName = "sinif";
            this.sinifDataGridViewTextBoxColumn.HeaderText = "sinif";
            this.sinifDataGridViewTextBoxColumn.Name = "sinifDataGridViewTextBoxColumn";
            // 
            // ogrlistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 364);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "ogrlistele";
            this.Text = "ogrlistele";
            ((System.ComponentModel.ISupportInitialize)(this.ogrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource ogrBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn okulnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isimsoyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifDataGridViewTextBoxColumn;
    }
}