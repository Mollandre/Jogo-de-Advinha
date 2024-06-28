namespace Jogo_de_Advinha
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
            Confirma = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            facil = new Button();
            medio = new Button();
            dificil = new Button();
            SuspendLayout();
            // 
            // Confirma
            // 
            Confirma.BackColor = Color.White;
            Confirma.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            Confirma.Location = new Point(60, 322);
            Confirma.Name = "Confirma";
            Confirma.Size = new Size(89, 33);
            Confirma.TabIndex = 0;
            Confirma.Text = "Confirma";
            Confirma.UseVisualStyleBackColor = false;
            Confirma.Visible = false;
            Confirma.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.Location = new Point(146, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(30, 36);
            textBox1.TabIndex = 1;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 226);
            label1.Name = "label1";
            label1.Size = new Size(222, 19);
            label1.TabIndex = 2;
            label1.Text = "Aperte Soteio Para começar";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 248);
            label2.Name = "label2";
            label2.Size = new Size(0, 19);
            label2.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Arial Black", 10F);
            button2.Location = new Point(180, 323);
            button2.Name = "button2";
            button2.Size = new Size(88, 32);
            button2.TabIndex = 4;
            button2.Text = "Sorteio";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 18F);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(20, 21);
            label3.Name = "label3";
            label3.Size = new Size(304, 33);
            label3.TabIndex = 5;
            label3.Text = " Jogo da Adivinhação ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 10F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(39, 87);
            label4.Name = "label4";
            label4.Size = new Size(260, 19);
            label4.TabIndex = 6;
            label4.Text = "Adivinhe o número que eu pensei";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(36, 106);
            label5.Name = "label5";
            label5.Size = new Size(271, 19);
            label5.TabIndex = 7;
            label5.Text = "(Dica: o número está entre 1 e 10):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 10F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(18, 270);
            label6.Name = "label6";
            label6.Size = new Size(0, 19);
            label6.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 10F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(60, 370);
            label7.Name = "label7";
            label7.Size = new Size(0, 19);
            label7.TabIndex = 9;
            // 
            // facil
            // 
            facil.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            facil.Location = new Point(31, 403);
            facil.Name = "facil";
            facil.Size = new Size(75, 23);
            facil.TabIndex = 10;
            facil.Text = "FÁCIL";
            facil.UseVisualStyleBackColor = true;
            facil.Visible = false;
            facil.Click += facil_Click;
            // 
            // medio
            // 
            medio.Font = new Font("Times New Roman", 10F);
            medio.Location = new Point(126, 403);
            medio.Name = "medio";
            medio.Size = new Size(75, 23);
            medio.TabIndex = 11;
            medio.Text = "MÉDIO";
            medio.UseVisualStyleBackColor = true;
            medio.Visible = false;
            medio.Click += medio_Click;
            // 
            // dificil
            // 
            dificil.Font = new Font("Times New Roman", 10F);
            dificil.Location = new Point(224, 403);
            dificil.Name = "dificil";
            dificil.Size = new Size(75, 23);
            dificil.TabIndex = 12;
            dificil.Text = "DIFÍCIL";
            dificil.UseVisualStyleBackColor = true;
            dificil.Visible = false;
            dificil.Click += dificil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(335, 450);
            Controls.Add(dificil);
            Controls.Add(medio);
            Controls.Add(facil);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(Confirma);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Confirma;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button facil;
        private Button medio;
        private Button dificil;
    }
}
