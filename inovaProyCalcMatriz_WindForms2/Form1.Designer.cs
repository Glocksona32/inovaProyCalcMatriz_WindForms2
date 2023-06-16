namespace inovaProyCalcMatriz_WindForms2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MatA = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.MatriB = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatriA = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.MatriC = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.MatriD = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MatA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatriB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatriA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatriC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatriD)).BeginInit();
            this.SuspendLayout();
            // 
            // MatA
            // 
            this.MatA.ColumnHeadersHeight = 29;
            this.MatA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.MatA.Location = new System.Drawing.Point(12, 12);
            this.MatA.Name = "MatA";
            this.MatA.RowHeadersWidth = 51;
            this.MatA.RowTemplate.Height = 24;
            this.MatA.Size = new System.Drawing.Size(247, 210);
            this.MatA.TabIndex = 0;
            this.MatA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MatA_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 90;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(270, 48);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(227, 45);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "DIMENSIÓN DE LA MATRIZ";
            // 
            // MatriB
            // 
            this.MatriB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatriB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.MatriB.Location = new System.Drawing.Point(12, 459);
            this.MatriB.Name = "MatriB";
            this.MatriB.RowHeadersWidth = 51;
            this.MatriB.RowTemplate.Height = 24;
            this.MatriB.Size = new System.Drawing.Size(224, 148);
            this.MatriB.TabIndex = 3;
            this.MatriB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 90;
            // 
            // MatriA
            // 
            this.MatriA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatriA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3});
            this.MatriA.Location = new System.Drawing.Point(12, 277);
            this.MatriA.Name = "MatriA";
            this.MatriA.RowHeadersWidth = 51;
            this.MatriA.RowTemplate.Height = 24;
            this.MatriA.Size = new System.Drawing.Size(224, 157);
            this.MatriA.TabIndex = 4;
            this.MatriA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 90;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(276, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(319, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(276, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 44);
            this.button3.TabIndex = 7;
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(320, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 44);
            this.button4.TabIndex = 8;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(503, 109);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 34);
            this.button5.TabIndex = 9;
            this.button5.Text = "INVERSA";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(408, 155);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(197, 34);
            this.button6.TabIndex = 10;
            this.button6.Text = "DETERMINANTE";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // MatriC
            // 
            this.MatriC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatriC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4});
            this.MatriC.Location = new System.Drawing.Point(344, 277);
            this.MatriC.Name = "MatriC";
            this.MatriC.RowHeadersWidth = 51;
            this.MatriC.RowTemplate.Height = 24;
            this.MatriC.Size = new System.Drawing.Size(207, 157);
            this.MatriC.TabIndex = 11;
            this.MatriC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MatriC_CellContentClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 90;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(440, 187);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(8, 8);
            this.button8.TabIndex = 14;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(364, 149);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(38, 44);
            this.button7.TabIndex = 12;
            this.button7.Text = "=";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(364, 109);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(133, 34);
            this.button9.TabIndex = 15;
            this.button9.Text = "LLENADO";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.llenado9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(270, 199);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(68, 38);
            this.button10.TabIndex = 16;
            this.button10.Text = "R1";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(344, 199);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(65, 38);
            this.button11.TabIndex = 17;
            this.button11.Text = "R2";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(415, 199);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(66, 38);
            this.button12.TabIndex = 18;
            this.button12.Text = "R3";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // MatriD
            // 
            this.MatriD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatriD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.MatriD.Location = new System.Drawing.Point(344, 459);
            this.MatriD.Name = "MatriD";
            this.MatriD.RowHeadersWidth = 51;
            this.MatriD.RowTemplate.Height = 24;
            this.MatriD.Size = new System.Drawing.Size(207, 157);
            this.MatriD.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column5";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 641);
            this.Controls.Add(this.MatriD);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.MatriC);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MatriA);
            this.Controls.Add(this.MatriB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.MatA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MatA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatriB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatriA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatriC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatriD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MatA;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MatriB;
        private System.Windows.Forms.DataGridView MatriA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView MatriC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.DataGridView MatriD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

