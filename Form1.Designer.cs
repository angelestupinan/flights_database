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
            panel3 = new Panel();
            addPas = new Button();
            idAddPas = new TextBox();
            ageAddPas = new TextBox();
            nameAddPas = new TextBox();
            button2 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            destinationText = new Label();
            label5 = new Label();
            capacityText = new Label();
            label3 = new Label();
            codeAddPas = new TextBox();
            panel4 = new Panel();
            listBox1 = new ListBox();
            button3 = new Button();
            consultPassengers = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
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
            // panel3
            // 
            panel3.Controls.Add(addPas);
            panel3.Controls.Add(idAddPas);
            panel3.Controls.Add(ageAddPas);
            panel3.Controls.Add(nameAddPas);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(codeAddPas);
            panel3.Location = new Point(414, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(404, 207);
            panel3.TabIndex = 5;
            // 
            // addPas
            // 
            addPas.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold | FontStyle.Italic);
            addPas.Location = new Point(285, 129);
            addPas.Name = "addPas";
            addPas.Size = new Size(100, 52);
            addPas.TabIndex = 10;
            addPas.Text = "Agregar";
            addPas.UseVisualStyleBackColor = true;
            addPas.Click += addPas_Click;
            // 
            // idAddPas
            // 
            idAddPas.Location = new Point(14, 158);
            idAddPas.Name = "idAddPas";
            idAddPas.PlaceholderText = "Id";
            idAddPas.Size = new Size(162, 23);
            idAddPas.TabIndex = 9;
            // 
            // ageAddPas
            // 
            ageAddPas.Location = new Point(182, 158);
            ageAddPas.Name = "ageAddPas";
            ageAddPas.PlaceholderText = "Edad";
            ageAddPas.Size = new Size(81, 23);
            ageAddPas.TabIndex = 8;
            // 
            // nameAddPas
            // 
            nameAddPas.Location = new Point(14, 129);
            nameAddPas.Name = "nameAddPas";
            nameAddPas.PlaceholderText = "Nombre";
            nameAddPas.Size = new Size(249, 23);
            nameAddPas.TabIndex = 7;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(14, 61);
            button2.Name = "button2";
            button2.Size = new Size(110, 36);
            button2.TabIndex = 6;
            button2.Text = "Consultar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.772728F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.227272F));
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(destinationText, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(capacityText, 1, 1);
            tableLayoutPanel1.Location = new Point(167, 45);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(237, 38);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 4;
            label4.Text = "Destino: ";
            // 
            // destinationText
            // 
            destinationText.AutoSize = true;
            destinationText.Location = new Point(97, 0);
            destinationText.Name = "destinationText";
            destinationText.Size = new Size(0, 15);
            destinationText.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 18);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 6;
            label5.Text = "Capacidad";
            // 
            // capacityText
            // 
            capacityText.AutoSize = true;
            capacityText.Location = new Point(97, 18);
            capacityText.Name = "capacityText";
            capacityText.Size = new Size(0, 15);
            capacityText.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 0);
            label3.Name = "label3";
            label3.Size = new Size(223, 29);
            label3.TabIndex = 3;
            label3.Text = "Agregar Pasajeros";
            // 
            // codeAddPas
            // 
            codeAddPas.Location = new Point(14, 30);
            codeAddPas.Name = "codeAddPas";
            codeAddPas.PlaceholderText = "Código del vuelo";
            codeAddPas.Size = new Size(110, 23);
            codeAddPas.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(listBox1);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(consultPassengers);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(414, 225);
            panel4.Name = "panel4";
            panel4.Size = new Size(404, 147);
            panel4.TabIndex = 6;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(130, 34);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(267, 94);
            listBox1.TabIndex = 8;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(14, 83);
            button3.Name = "button3";
            button3.Size = new Size(110, 36);
            button3.TabIndex = 7;
            button3.Text = "Consultar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // consultPassengers
            // 
            consultPassengers.Location = new Point(14, 45);
            consultPassengers.Name = "consultPassengers";
            consultPassengers.PlaceholderText = "Código del vuelo";
            consultPassengers.Size = new Size(110, 23);
            consultPassengers.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, -3);
            label6.Name = "label6";
            label6.Size = new Size(244, 29);
            label6.TabIndex = 4;
            label6.Text = "Consultar Pasajeros";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 374);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Panel panel3;
        private Label label3;
        private TextBox codeAddPas;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private Label destinationText;
        private Label label5;
        private Label capacityText;
        private Button button2;
        private TextBox nameAddPas;
        private TextBox ageAddPas;
        private TextBox idAddPas;
        private Button addPas;
        private Panel panel4;
        private Label label6;
        private Button button3;
        private TextBox consultPassengers;
        private ListBox listBox1;
    }
}
