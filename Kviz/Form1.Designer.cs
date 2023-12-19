namespace Kviz
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
            this.components = new System.ComponentModel.Container();
            this.labelaVrijeme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelaPrviPribrojnik = new System.Windows.Forms.Label();
            this.labelaDrugiPribrojnik = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.zbroj = new System.Windows.Forms.NumericUpDown();
            this.razlika = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelaUmanjitelj = new System.Windows.Forms.Label();
            this.labelaUmanjenik = new System.Windows.Forms.Label();
            this.umnožak = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelaDrugiFaktor = new System.Windows.Forms.Label();
            this.labelaPrviFaktor = new System.Windows.Forms.Label();
            this.kvocijent = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelaDjelitelj = new System.Windows.Forms.Label();
            this.labelaDjeljenik = new System.Windows.Forms.Label();
            this.gumbPočetak = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.zbroj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.razlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umnožak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvocijent)).BeginInit();
            this.SuspendLayout();
            // 
            // labelaVrijeme
            // 
            this.labelaVrijeme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelaVrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaVrijeme.Location = new System.Drawing.Point(270, 22);
            this.labelaVrijeme.Name = "labelaVrijeme";
            this.labelaVrijeme.Size = new System.Drawing.Size(200, 30);
            this.labelaVrijeme.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Preostalo vrijeme";
            // 
            // labelaPrviPribrojnik
            // 
            this.labelaPrviPribrojnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaPrviPribrojnik.Location = new System.Drawing.Point(57, 75);
            this.labelaPrviPribrojnik.Name = "labelaPrviPribrojnik";
            this.labelaPrviPribrojnik.Size = new System.Drawing.Size(60, 50);
            this.labelaPrviPribrojnik.TabIndex = 2;
            this.labelaPrviPribrojnik.Text = "?";
            this.labelaPrviPribrojnik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelaDrugiPribrojnik
            // 
            this.labelaDrugiPribrojnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaDrugiPribrojnik.Location = new System.Drawing.Point(193, 75);
            this.labelaDrugiPribrojnik.Name = "labelaDrugiPribrojnik";
            this.labelaDrugiPribrojnik.Size = new System.Drawing.Size(60, 50);
            this.labelaDrugiPribrojnik.TabIndex = 3;
            this.labelaDrugiPribrojnik.Text = "?";
            this.labelaDrugiPribrojnik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 4;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 5;
            this.label5.Text = "+";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zbroj
            // 
            this.zbroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zbroj.Location = new System.Drawing.Point(325, 80);
            this.zbroj.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.zbroj.Name = "zbroj";
            this.zbroj.Size = new System.Drawing.Size(100, 41);
            this.zbroj.TabIndex = 1;
            this.zbroj.ValueChanged += new System.EventHandler(this.zbroj_ValueChanged);
            this.zbroj.Enter += new System.EventHandler(this.unosEnter);
            // 
            // razlika
            // 
            this.razlika.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.razlika.Location = new System.Drawing.Point(325, 130);
            this.razlika.Name = "razlika";
            this.razlika.Size = new System.Drawing.Size(100, 41);
            this.razlika.TabIndex = 2;
            this.razlika.ValueChanged += new System.EventHandler(this.razlika_ValueChanged);
            this.razlika.Enter += new System.EventHandler(this.unosEnter);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(123, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 50);
            this.label6.TabIndex = 10;
            this.label6.Text = "-";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(259, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 50);
            this.label7.TabIndex = 9;
            this.label7.Text = "=";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelaUmanjitelj
            // 
            this.labelaUmanjitelj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaUmanjitelj.Location = new System.Drawing.Point(193, 125);
            this.labelaUmanjitelj.Name = "labelaUmanjitelj";
            this.labelaUmanjitelj.Size = new System.Drawing.Size(60, 50);
            this.labelaUmanjitelj.TabIndex = 8;
            this.labelaUmanjitelj.Text = "?";
            this.labelaUmanjitelj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelaUmanjenik
            // 
            this.labelaUmanjenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaUmanjenik.Location = new System.Drawing.Point(57, 125);
            this.labelaUmanjenik.Name = "labelaUmanjenik";
            this.labelaUmanjenik.Size = new System.Drawing.Size(60, 50);
            this.labelaUmanjenik.TabIndex = 7;
            this.labelaUmanjenik.Text = "?";
            this.labelaUmanjenik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // umnožak
            // 
            this.umnožak.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.umnožak.Location = new System.Drawing.Point(325, 177);
            this.umnožak.Name = "umnožak";
            this.umnožak.Size = new System.Drawing.Size(100, 41);
            this.umnožak.TabIndex = 3;
            this.umnožak.ValueChanged += new System.EventHandler(this.umnožak_ValueChanged);
            this.umnožak.Enter += new System.EventHandler(this.unosEnter);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(123, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 50);
            this.label10.TabIndex = 15;
            this.label10.Text = "*";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(259, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 50);
            this.label11.TabIndex = 14;
            this.label11.Text = "=";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelaDrugiFaktor
            // 
            this.labelaDrugiFaktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaDrugiFaktor.Location = new System.Drawing.Point(193, 172);
            this.labelaDrugiFaktor.Name = "labelaDrugiFaktor";
            this.labelaDrugiFaktor.Size = new System.Drawing.Size(60, 50);
            this.labelaDrugiFaktor.TabIndex = 13;
            this.labelaDrugiFaktor.Text = "?";
            this.labelaDrugiFaktor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelaPrviFaktor
            // 
            this.labelaPrviFaktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaPrviFaktor.Location = new System.Drawing.Point(57, 172);
            this.labelaPrviFaktor.Name = "labelaPrviFaktor";
            this.labelaPrviFaktor.Size = new System.Drawing.Size(60, 50);
            this.labelaPrviFaktor.TabIndex = 12;
            this.labelaPrviFaktor.Text = "?";
            this.labelaPrviFaktor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kvocijent
            // 
            this.kvocijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kvocijent.Location = new System.Drawing.Point(325, 224);
            this.kvocijent.Name = "kvocijent";
            this.kvocijent.Size = new System.Drawing.Size(100, 41);
            this.kvocijent.TabIndex = 4;
            this.kvocijent.ValueChanged += new System.EventHandler(this.kvocijent_ValueChanged);
            this.kvocijent.Enter += new System.EventHandler(this.unosEnter);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(123, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 50);
            this.label14.TabIndex = 20;
            this.label14.Text = "/";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(259, 219);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 50);
            this.label15.TabIndex = 19;
            this.label15.Text = "=";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelaDjelitelj
            // 
            this.labelaDjelitelj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaDjelitelj.Location = new System.Drawing.Point(193, 219);
            this.labelaDjelitelj.Name = "labelaDjelitelj";
            this.labelaDjelitelj.Size = new System.Drawing.Size(60, 50);
            this.labelaDjelitelj.TabIndex = 18;
            this.labelaDjelitelj.Text = "?";
            this.labelaDjelitelj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelaDjeljenik
            // 
            this.labelaDjeljenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaDjeljenik.Location = new System.Drawing.Point(57, 219);
            this.labelaDjeljenik.Name = "labelaDjeljenik";
            this.labelaDjeljenik.Size = new System.Drawing.Size(60, 50);
            this.labelaDjeljenik.TabIndex = 17;
            this.labelaDjeljenik.Text = "?";
            this.labelaDjeljenik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gumbPočetak
            // 
            this.gumbPočetak.AutoSize = true;
            this.gumbPočetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gumbPočetak.Location = new System.Drawing.Point(129, 283);
            this.gumbPočetak.Name = "gumbPočetak";
            this.gumbPočetak.Size = new System.Drawing.Size(200, 46);
            this.gumbPočetak.TabIndex = 0;
            this.gumbPočetak.Text = "Započni kviz!";
            this.gumbPočetak.UseVisualStyleBackColor = true;
            this.gumbPočetak.Click += new System.EventHandler(this.gumbPočetak_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.gumbPočetak);
            this.Controls.Add(this.kvocijent);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.labelaDjelitelj);
            this.Controls.Add(this.labelaDjeljenik);
            this.Controls.Add(this.umnožak);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelaDrugiFaktor);
            this.Controls.Add(this.labelaPrviFaktor);
            this.Controls.Add(this.razlika);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelaUmanjitelj);
            this.Controls.Add(this.labelaUmanjenik);
            this.Controls.Add(this.zbroj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelaDrugiPribrojnik);
            this.Controls.Add(this.labelaPrviPribrojnik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelaVrijeme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Matematički kviz";
            ((System.ComponentModel.ISupportInitialize)(this.zbroj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.razlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umnožak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvocijent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelaVrijeme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelaPrviPribrojnik;
        private System.Windows.Forms.Label labelaDrugiPribrojnik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown zbroj;
        private System.Windows.Forms.NumericUpDown razlika;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelaUmanjitelj;
        private System.Windows.Forms.Label labelaUmanjenik;
        private System.Windows.Forms.NumericUpDown umnožak;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelaDrugiFaktor;
        private System.Windows.Forms.Label labelaPrviFaktor;
        private System.Windows.Forms.NumericUpDown kvocijent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelaDjelitelj;
        private System.Windows.Forms.Label labelaDjeljenik;
        private System.Windows.Forms.Button gumbPočetak;
        private System.Windows.Forms.Timer timer1;
    }
}

