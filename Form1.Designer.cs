namespace flights_database
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
            destinationS = new TextBox();
            codeS = new TextBox();
            seatsS = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            button_2 = new Button();
            label2 = new Label();
            destinationC = new TextBox();
            seatsC = new TextBox();
            codeC = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // destinationS
            // 
            destinationS.Location = new Point(14, 45);
            destinationS.Name = "destinationS";
            destinationS.PlaceholderText = "Destino del vuelo";
            destinationS.Size = new Size(201, 23);
            destinationS.TabIndex = 0;
            // 
            // codeS
            // 
            codeS.Location = new Point(14, 74);
            codeS.Name = "codeS";
            codeS.PlaceholderText = "Código del vuelo";
            codeS.Size = new Size(201, 23);
            codeS.TabIndex = 1;
            // 
            // seatsS
            // 
            seatsS.Location = new Point(14, 113);
            seatsS.Name = "seatsS";
            seatsS.PlaceholderText = "Asientos";
            seatsS.Size = new Size(71, 23);
            seatsS.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(destinationS);
            panel1.Controls.Add(seatsS);
            panel1.Controls.Add(codeS);
            panel1.Location = new Point(4, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 162);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(276, 45);
            button1.Name = "button1";
            button1.Size = new Size(99, 91);
            button1.TabIndex = 5;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 0);
            label1.Name = "label1";
            label1.Size = new Size(363, 29);
            label1.TabIndex = 3;
            label1.Text = "Guardar información del vuelo";
            // 
            // panel2
            // 
            panel2.Controls.Add(button_2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(destinationC);
            panel2.Controls.Add(seatsC);
            panel2.Controls.Add(codeC);
            panel2.Location = new Point(4, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(404, 162);
            panel2.TabIndex = 4;
            // 
            // button_2
            // 
            button_2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold | FontStyle.Italic);
            button_2.Location = new Point(14, 70);
            button_2.Name = "button_2";
            button_2.Size = new Size(99, 61);
            button_2.TabIndex = 5;
            button_2.Text = "Consultar";
            button_2.UseVisualStyleBackColor = true;
            button_2.Click += button_2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 0);
            label2.Name = "label2";
            label2.Size = new Size(382, 29);
            label2.TabIndex = 3;
            label2.Text = "Consultar información del vuelo";
            // 
            // destinationC
            // 
            destinationC.Location = new Point(176, 32);
            destinationC.Name = "destinationC";
            destinationC.PlaceholderText = "Destino del vuelo";
            destinationC.Size = new Size(201, 23);
            destinationC.TabIndex = 0;
            // 
            // seatsC
            // 
            seatsC.Location = new Point(176, 70);
            seatsC.Name = "seatsC";
            seatsC.PlaceholderText = "Asientos";
            seatsC.Size = new Size(99, 23);
            seatsC.TabIndex = 2;
            // 
            // codeC
            // 
            codeC.Location = new Point(14, 32);
            codeC.Name = "codeC";
            codeC.PlaceholderText = "Código del vuelo";
            codeC.Size = new Size(99, 23);
            codeC.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 374);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox destinationS;
        private TextBox codeS;
        private TextBox seatsS;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private Panel panel2;
        private Button button_2;
        private Label label2;
        private TextBox destinationC;
        private TextBox seatsC;
        private TextBox codeC;
    }
}
