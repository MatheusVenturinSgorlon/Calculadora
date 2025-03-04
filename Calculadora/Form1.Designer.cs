namespace Calculadora
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblOper = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbResultado = new System.Windows.Forms.Label();
            this.NumOper1 = new System.Windows.Forms.NumericUpDown();
            this.NumOper2 = new System.Windows.Forms.NumericUpDown();
            this.Btsoma = new System.Windows.Forms.Button();
            this.Btsubt = new System.Windows.Forms.Button();
            this.Btmult = new System.Windows.Forms.Button();
            this.Btdiv = new System.Windows.Forms.Button();
            this.ButIgual = new System.Windows.Forms.Button();
            this.BtSeguir = new System.Windows.Forms.Button();
            this.BtLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumOper1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOper2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operando 1:";
            // 
            // LblOper
            // 
            this.LblOper.AutoSize = true;
            this.LblOper.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOper.Location = new System.Drawing.Point(382, 84);
            this.LblOper.Name = "LblOper";
            this.LblOper.Size = new System.Drawing.Size(31, 29);
            this.LblOper.TabIndex = 1;
            this.LblOper.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operando 2:";
            // 
            // LbResultado
            // 
            this.LbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbResultado.Location = new System.Drawing.Point(12, 310);
            this.LbResultado.Name = "LbResultado";
            this.LbResultado.Size = new System.Drawing.Size(834, 29);
            this.LbResultado.TabIndex = 3;
            this.LbResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumOper1
            // 
            this.NumOper1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOper1.Location = new System.Drawing.Point(197, 20);
            this.NumOper1.Maximum = new decimal(new int[] {
            -159383552,
            46653770,
            5421,
            0});
            this.NumOper1.Minimum = new decimal(new int[] {
            -159383552,
            46653770,
            5421,
            -2147483648});
            this.NumOper1.Name = "NumOper1";
            this.NumOper1.Size = new System.Drawing.Size(120, 35);
            this.NumOper1.TabIndex = 5;
            // 
            // NumOper2
            // 
            this.NumOper2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOper2.Location = new System.Drawing.Point(197, 140);
            this.NumOper2.Maximum = new decimal(new int[] {
            -159383552,
            46653770,
            5421,
            0});
            this.NumOper2.Minimum = new decimal(new int[] {
            -159383552,
            46653770,
            5421,
            -2147483648});
            this.NumOper2.Name = "NumOper2";
            this.NumOper2.Size = new System.Drawing.Size(120, 35);
            this.NumOper2.TabIndex = 6;
            // 
            // Btsoma
            // 
            this.Btsoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btsoma.Location = new System.Drawing.Point(58, 78);
            this.Btsoma.Name = "Btsoma";
            this.Btsoma.Size = new System.Drawing.Size(88, 35);
            this.Btsoma.TabIndex = 7;
            this.Btsoma.Text = "+";
            this.Btsoma.UseVisualStyleBackColor = true;
            this.Btsoma.Click += new System.EventHandler(this.Btsoma_Click);
            // 
            // Btsubt
            // 
            this.Btsubt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btsubt.Location = new System.Drawing.Point(139, 78);
            this.Btsubt.Name = "Btsubt";
            this.Btsubt.Size = new System.Drawing.Size(86, 35);
            this.Btsubt.TabIndex = 8;
            this.Btsubt.Text = "-";
            this.Btsubt.UseVisualStyleBackColor = true;
            this.Btsubt.Click += new System.EventHandler(this.Btsubt_Click);
            // 
            // Btmult
            // 
            this.Btmult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btmult.Location = new System.Drawing.Point(220, 78);
            this.Btmult.Name = "Btmult";
            this.Btmult.Size = new System.Drawing.Size(88, 35);
            this.Btmult.TabIndex = 9;
            this.Btmult.Text = "X";
            this.Btmult.UseVisualStyleBackColor = true;
            this.Btmult.Click += new System.EventHandler(this.Btmult_Click);
            // 
            // Btdiv
            // 
            this.Btdiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btdiv.Location = new System.Drawing.Point(301, 78);
            this.Btdiv.Name = "Btdiv";
            this.Btdiv.Size = new System.Drawing.Size(75, 35);
            this.Btdiv.TabIndex = 10;
            this.Btdiv.Text = "÷";
            this.Btdiv.UseVisualStyleBackColor = true;
            this.Btdiv.Click += new System.EventHandler(this.Btdiv_Click);
            // 
            // ButIgual
            // 
            this.ButIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButIgual.Location = new System.Drawing.Point(96, 206);
            this.ButIgual.Name = "ButIgual";
            this.ButIgual.Size = new System.Drawing.Size(199, 46);
            this.ButIgual.TabIndex = 11;
            this.ButIgual.Text = "=";
            this.ButIgual.UseVisualStyleBackColor = true;
            this.ButIgual.Click += new System.EventHandler(this.ButIgual_Click);
            // 
            // BtSeguir
            // 
            this.BtSeguir.Location = new System.Drawing.Point(301, 206);
            this.BtSeguir.Name = "BtSeguir";
            this.BtSeguir.Size = new System.Drawing.Size(137, 46);
            this.BtSeguir.TabIndex = 12;
            this.BtSeguir.Text = "SEGUIR";
            this.BtSeguir.UseVisualStyleBackColor = true;
            this.BtSeguir.Click += new System.EventHandler(this.BtSeguir_Click);
            // 
            // BtLimpar
            // 
            this.BtLimpar.Location = new System.Drawing.Point(444, 206);
            this.BtLimpar.Name = "BtLimpar";
            this.BtLimpar.Size = new System.Drawing.Size(125, 46);
            this.BtLimpar.TabIndex = 13;
            this.BtLimpar.Text = "LIMPAR";
            this.BtLimpar.UseVisualStyleBackColor = true;
            this.BtLimpar.Click += new System.EventHandler(this.BtLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtLimpar);
            this.Controls.Add(this.BtSeguir);
            this.Controls.Add(this.ButIgual);
            this.Controls.Add(this.Btdiv);
            this.Controls.Add(this.Btmult);
            this.Controls.Add(this.Btsubt);
            this.Controls.Add(this.Btsoma);
            this.Controls.Add(this.NumOper2);
            this.Controls.Add(this.NumOper1);
            this.Controls.Add(this.LbResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblOper);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.NumOper1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOper2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblOper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbResultado;
        private System.Windows.Forms.NumericUpDown NumOper1;
        private System.Windows.Forms.NumericUpDown NumOper2;
        private System.Windows.Forms.Button Btsoma;
        private System.Windows.Forms.Button Btsubt;
        private System.Windows.Forms.Button Btmult;
        private System.Windows.Forms.Button Btdiv;
        private System.Windows.Forms.Button ButIgual;
        private System.Windows.Forms.Button BtSeguir;
        private System.Windows.Forms.Button BtLimpar;
    }
}

