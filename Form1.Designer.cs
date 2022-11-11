namespace _05_Perceptron_Iirs_Plant
{
    partial class Form1
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CBOpciones = new System.Windows.Forms.ComboBox();
            this.btPerceptron = new System.Windows.Forms.Button();
            this.lBdatos = new System.Windows.Forms.ListBox();
            this.lBresultados = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(20, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elegir Clases";
            // 
            // CBOpciones
            // 
            this.CBOpciones.FormattingEnabled = true;
            this.CBOpciones.Items.AddRange(new object[] {
            "Setosa-Versicolor",
            "Setosa-Virginica",
            "Versicolor-Virginica"});
            this.CBOpciones.Location = new System.Drawing.Point(12, 122);
            this.CBOpciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBOpciones.Name = "CBOpciones";
            this.CBOpciones.Size = new System.Drawing.Size(133, 23);
            this.CBOpciones.TabIndex = 1;
            // 
            // btPerceptron
            // 
            this.btPerceptron.BackColor = System.Drawing.Color.Cyan;
            this.btPerceptron.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btPerceptron.Location = new System.Drawing.Point(24, 189);
            this.btPerceptron.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btPerceptron.Name = "btPerceptron";
            this.btPerceptron.Size = new System.Drawing.Size(95, 56);
            this.btPerceptron.TabIndex = 2;
            this.btPerceptron.Text = "Perceptrón";
            this.btPerceptron.UseVisualStyleBackColor = false;
            this.btPerceptron.Click += new System.EventHandler(this.button1_Click);
            // 
            // lBdatos
            // 
            this.lBdatos.FormattingEnabled = true;
            this.lBdatos.ItemHeight = 15;
            this.lBdatos.Location = new System.Drawing.Point(171, 22);
            this.lBdatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lBdatos.Name = "lBdatos";
            this.lBdatos.Size = new System.Drawing.Size(244, 394);
            this.lBdatos.TabIndex = 3;
            // 
            // lBresultados
            // 
            this.lBresultados.FormattingEnabled = true;
            this.lBresultados.ItemHeight = 15;
            this.lBresultados.Location = new System.Drawing.Point(428, 22);
            this.lBresultados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lBresultados.Name = "lBresultados";
            this.lBresultados.Size = new System.Drawing.Size(244, 394);
            this.lBresultados.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(695, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(500, 393);
            this.dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1221, 427);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lBresultados);
            this.Controls.Add(this.lBdatos);
            this.Controls.Add(this.btPerceptron);
            this.Controls.Add(this.CBOpciones);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Perceptron Iris-Plant";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox CBOpciones;
        private Button btPerceptron;
        private ListBox lBdatos;
        private ListBox lBresultados;
        private DataGridView dataGridView1;
    }
}