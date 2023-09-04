namespace Recursion
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "Obtener la suma de los primeros N enteros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 68);
            this.button2.TabIndex = 1;
            this.button2.Text = "Devuelve los primeros N pares";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(337, 124);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 464);
            this.listBox1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(613, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 68);
            this.button3.TabIndex = 3;
            this.button3.Text = "Potencia recursiva";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(898, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 68);
            this.button4.TabIndex = 4;
            this.button4.Text = "Obtener los primeros N numeros de Fibonacci";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(924, 124);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(150, 464);
            this.listBox2.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1244, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 85);
            this.button5.TabIndex = 6;
            this.button5.Text = "Suma desde N hasta M";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1429, 36);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 129);
            this.button6.TabIndex = 7;
            this.button6.Text = "Suma los pares desde N hasta 2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1429, 224);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 129);
            this.button7.TabIndex = 8;
            this.button7.Text = "funcion Aparear()";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1429, 382);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(137, 129);
            this.button8.TabIndex = 9;
            this.button8.Text = "funcion Mayuscula()";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1231, 548);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(137, 129);
            this.button9.TabIndex = 10;
            this.button9.Text = "Ingrese un entero y obtenga el binario correspondiente";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1429, 548);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(137, 129);
            this.button10.TabIndex = 11;
            this.button10.Text = "Ingrese un binario y obtenga el entero correspondiente";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1629, 548);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(137, 129);
            this.button11.TabIndex = 12;
            this.button11.Text = "¿Es palindromo?";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1813, 770);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private Button button3;
        private Button button4;
        private ListBox listBox2;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
    }
}