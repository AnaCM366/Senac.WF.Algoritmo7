﻿namespace WF.Login
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panel1 = new Panel();
            btnEntregas = new Button();
            btnPagamento = new Button();
            btnClientes = new Button();
            btnProdutos = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnEntregas);
            panel1.Controls.Add(btnPagamento);
            panel1.Controls.Add(btnClientes);
            panel1.Controls.Add(btnProdutos);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 580);
            panel1.TabIndex = 0;
            // 
            // btnEntregas
            // 
            btnEntregas.FlatAppearance.BorderSize = 0;
            btnEntregas.FlatStyle = FlatStyle.Flat;
            btnEntregas.Font = new Font("Rockwell", 12F);
            btnEntregas.ForeColor = Color.White;
            btnEntregas.Image = (Image)resources.GetObject("btnEntregas.Image");
            btnEntregas.ImageAlign = ContentAlignment.MiddleLeft;
            btnEntregas.Location = new Point(12, 393);
            btnEntregas.Name = "btnEntregas";
            btnEntregas.Size = new Size(270, 59);
            btnEntregas.TabIndex = 4;
            btnEntregas.Text = "Entregas";
            btnEntregas.UseVisualStyleBackColor = true;
            // 
            // btnPagamento
            // 
            btnPagamento.FlatAppearance.BorderSize = 0;
            btnPagamento.FlatStyle = FlatStyle.Flat;
            btnPagamento.Font = new Font("Rockwell", 12F);
            btnPagamento.ForeColor = Color.White;
            btnPagamento.Image = (Image)resources.GetObject("btnPagamento.Image");
            btnPagamento.ImageAlign = ContentAlignment.MiddleLeft;
            btnPagamento.Location = new Point(12, 314);
            btnPagamento.Name = "btnPagamento";
            btnPagamento.Size = new Size(270, 59);
            btnPagamento.TabIndex = 3;
            btnPagamento.Text = "Pagamento";
            btnPagamento.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Rockwell", 12F);
            btnClientes.ForeColor = Color.White;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(12, 235);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(270, 59);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnProdutos
            // 
            btnProdutos.FlatAppearance.BorderSize = 0;
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Font = new Font("Rockwell", 12F);
            btnProdutos.ForeColor = Color.White;
            btnProdutos.Image = Properties.Resources._1760345_food_pizza_snack_icon__1_;
            btnProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdutos.Location = new Point(12, 156);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(270, 59);
            btnProdutos.TabIndex = 1;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Rockwell", 12F);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 81);
            button1.Name = "button1";
            button1.Size = new Size(270, 59);
            button1.TabIndex = 0;
            button1.Text = "Início";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Location = new Point(299, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(626, 32);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 0);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(342, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(161, 156);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 126);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 3;
            label1.Text = "Senac food";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._3558094_bake_bread_fast_food_pizza_icon__1_;
            pictureBox1.Location = new Point(16, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 15F);
            label2.Location = new Point(509, 46);
            label2.Name = "label2";
            label2.Size = new Size(281, 35);
            label2.TabIndex = 3;
            label2.Text = "Gestão de delivery";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._1298747_instagram_brand_logo_social_media_icon;
            pictureBox2.Location = new Point(796, 45);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(830, 45);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(864, 45);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(28, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(454, 240);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 7;
            textBox1.Text = "Principal";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 580);
            Controls.Add(textBox1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Senac foods";
            Load += FormPrincipal_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnProdutos;
        private Button button1;
        private Button btnEntregas;
        private Button btnPagamento;
        private Button btnClientes;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private TextBox textBox1;
    }
}