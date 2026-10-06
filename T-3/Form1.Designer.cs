namespace T_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCelsius = new TextBox();
            txtFahrenheit = new TextBox();
            txtKelvin = new TextBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 65);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Celsius";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 123);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Fahrenheit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 184);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Kelvin";
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(151, 62);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(219, 27);
            txtCelsius.TabIndex = 3;
            txtCelsius.TextChanged += txtCelsius_TextChanged;
            // 
            // txtFahrenheit
            // 
            txtFahrenheit.Location = new Point(151, 123);
            txtFahrenheit.Name = "txtFahrenheit";
            txtFahrenheit.Size = new Size(219, 27);
            txtFahrenheit.TabIndex = 4;
            // 
            // txtKelvin
            // 
            txtKelvin.Location = new Point(151, 184);
            txtKelvin.Name = "txtKelvin";
            txtKelvin.Size = new Size(219, 27);
            txtKelvin.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(73, 276);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(630, 78);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Temperatura";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(536, 26);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(70, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Kelvin";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(287, 26);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(98, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Fahrenheit";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(49, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Celsius";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.BackgroundImage = (Image)resources.GetObject("btnCalcular.BackgroundImage");
            btnCalcular.BackgroundImageLayout = ImageLayout.Stretch;
            btnCalcular.ForeColor = SystemColors.Control;
            btnCalcular.Location = new Point(45, 360);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(174, 117);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackgroundImage = Properties.Resources.maestro_limpio;
            btnLimpiar.BackgroundImageLayout = ImageLayout.Stretch;
            btnLimpiar.ForeColor = SystemColors.WindowText;
            btnLimpiar.Location = new Point(581, 360);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(174, 117);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_24_093647;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 495);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(groupBox1);
            Controls.Add(txtKelvin);
            Controls.Add(txtFahrenheit);
            Controls.Add(txtCelsius);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCelsius;
        private TextBox txtFahrenheit;
        private TextBox txtKelvin;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private Button btnCalcular;
        private Button btnLimpiar;
    }
}
