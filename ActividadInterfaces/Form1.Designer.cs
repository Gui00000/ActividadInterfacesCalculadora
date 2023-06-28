namespace ActividadInterfaces
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
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            btnSuma = new Button();
            btnResta = new Button();
            btnMulti = new Button();
            btnDivision = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(48, 73);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(48, 140);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 1;
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(269, 72);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(99, 23);
            btnSuma.TabIndex = 2;
            btnSuma.Text = "Suma";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(269, 110);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(99, 23);
            btnResta.TabIndex = 3;
            btnResta.Text = "Resta";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(269, 149);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(99, 23);
            btnMulti.TabIndex = 4;
            btnMulti.Text = "Multiplicación";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(269, 188);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(99, 23);
            btnDivision.TabIndex = 5;
            btnDivision.Text = "División";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BorderStyle = BorderStyle.FixedSingle;
            lblResultado.Location = new Point(444, 72);
            lblResultado.MinimumSize = new Size(100, 50);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(100, 50);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnDivision);
            Controls.Add(btnMulti);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button btnSuma;
        private Button btnResta;
        private Button btnMulti;
        private Button btnDivision;
        private Label lblResultado;
    }
}