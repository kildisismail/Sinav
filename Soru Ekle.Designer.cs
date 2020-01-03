namespace Sınav
{
    partial class Soru_Ekle
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.soruRichTextBox = new System.Windows.Forms.RichTextBox();
            this.aRichTextBox = new System.Windows.Forms.RichTextBox();
            this.bRichTextBox = new System.Windows.Forms.RichTextBox();
            this.cRichTextBox = new System.Windows.Forms.RichTextBox();
            this.dRichTextBox = new System.Windows.Forms.RichTextBox();
            this.boldCheck = new System.Windows.Forms.CheckBox();
            this.altıCiziliCheck = new System.Windows.Forms.CheckBox();
            this.soruEkle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fotoTextBox1 = new System.Windows.Forms.TextBox();
            this.konularDataSet1 = new Sınav.konularDataSet1();
            this.konularDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fotoEkle = new System.Windows.Forms.Button();
            this.dogruRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.konularDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.konularDataSet3 = new Sınav.konularDataSet3();
            this.lblUzunluk = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVeriAnalizi = new System.Windows.Forms.Button();
            this.btnOlasilik = new System.Windows.Forms.Button();
            this.btnEsitsizlik = new System.Windows.Forms.Button();
            this.btnDogrusalDenklemler = new System.Windows.Forms.Button();
            this.btnCarpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konularDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konularDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konularDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konularDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "D)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "C)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "B)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "A)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 145);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // soruRichTextBox
            // 
            this.soruRichTextBox.Location = new System.Drawing.Point(137, 9);
            this.soruRichTextBox.Name = "soruRichTextBox";
            this.soruRichTextBox.Size = new System.Drawing.Size(565, 196);
            this.soruRichTextBox.TabIndex = 30;
            this.soruRichTextBox.Text = "";
            this.soruRichTextBox.TextChanged += new System.EventHandler(this.soruRichTextBox_TextChanged);
            // 
            // aRichTextBox
            // 
            this.aRichTextBox.Location = new System.Drawing.Point(137, 234);
            this.aRichTextBox.Name = "aRichTextBox";
            this.aRichTextBox.Size = new System.Drawing.Size(565, 31);
            this.aRichTextBox.TabIndex = 31;
            this.aRichTextBox.Text = "";
            this.aRichTextBox.TextChanged += new System.EventHandler(this.aRichTextBox_TextChanged);
            // 
            // bRichTextBox
            // 
            this.bRichTextBox.Location = new System.Drawing.Point(137, 295);
            this.bRichTextBox.Name = "bRichTextBox";
            this.bRichTextBox.Size = new System.Drawing.Size(565, 31);
            this.bRichTextBox.TabIndex = 32;
            this.bRichTextBox.Text = "";
            this.bRichTextBox.TextChanged += new System.EventHandler(this.bRichTextBox_TextChanged);
            // 
            // cRichTextBox
            // 
            this.cRichTextBox.Location = new System.Drawing.Point(137, 354);
            this.cRichTextBox.Name = "cRichTextBox";
            this.cRichTextBox.Size = new System.Drawing.Size(565, 31);
            this.cRichTextBox.TabIndex = 33;
            this.cRichTextBox.Text = "";
            this.cRichTextBox.TextChanged += new System.EventHandler(this.cRichTextBox_TextChanged);
            // 
            // dRichTextBox
            // 
            this.dRichTextBox.Location = new System.Drawing.Point(137, 410);
            this.dRichTextBox.Name = "dRichTextBox";
            this.dRichTextBox.Size = new System.Drawing.Size(565, 31);
            this.dRichTextBox.TabIndex = 34;
            this.dRichTextBox.Text = "";
            this.dRichTextBox.TextChanged += new System.EventHandler(this.dRichTextBox_TextChanged);
            // 
            // boldCheck
            // 
            this.boldCheck.AutoSize = true;
            this.boldCheck.Location = new System.Drawing.Point(708, 27);
            this.boldCheck.Name = "boldCheck";
            this.boldCheck.Size = new System.Drawing.Size(61, 21);
            this.boldCheck.TabIndex = 35;
            this.boldCheck.Text = "Kalın";
            this.boldCheck.UseVisualStyleBackColor = true;
            this.boldCheck.CheckedChanged += new System.EventHandler(this.boldCheck_CheckedChanged);
            // 
            // altıCiziliCheck
            // 
            this.altıCiziliCheck.AutoSize = true;
            this.altıCiziliCheck.Location = new System.Drawing.Point(708, 69);
            this.altıCiziliCheck.Name = "altıCiziliCheck";
            this.altıCiziliCheck.Size = new System.Drawing.Size(81, 21);
            this.altıCiziliCheck.TabIndex = 36;
            this.altıCiziliCheck.Text = "Altı Çizili";
            this.altıCiziliCheck.UseVisualStyleBackColor = true;
            this.altıCiziliCheck.CheckedChanged += new System.EventHandler(this.altıCiziliCheck_CheckedChanged);
            // 
            // soruEkle
            // 
            this.soruEkle.Location = new System.Drawing.Point(708, 125);
            this.soruEkle.Name = "soruEkle";
            this.soruEkle.Size = new System.Drawing.Size(81, 80);
            this.soruEkle.TabIndex = 37;
            this.soruEkle.Text = "SORU EKLE";
            this.soruEkle.UseVisualStyleBackColor = true;
            this.soruEkle.Click += new System.EventHandler(this.soruEkle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fotoTextBox1
            // 
            this.fotoTextBox1.Location = new System.Drawing.Point(10, 154);
            this.fotoTextBox1.Name = "fotoTextBox1";
            this.fotoTextBox1.Size = new System.Drawing.Size(121, 22);
            this.fotoTextBox1.TabIndex = 38;
            // 
            // konularDataSet1
            // 
            this.konularDataSet1.DataSetName = "konularDataSet1";
            this.konularDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // konularDataSet1BindingSource
            // 
            this.konularDataSet1BindingSource.DataSource = this.konularDataSet1;
            this.konularDataSet1BindingSource.Position = 0;
            // 
            // fotoEkle
            // 
            this.fotoEkle.Location = new System.Drawing.Point(10, 173);
            this.fotoEkle.Name = "fotoEkle";
            this.fotoEkle.Size = new System.Drawing.Size(121, 32);
            this.fotoEkle.TabIndex = 39;
            this.fotoEkle.Text = "Fotoğraf Yükle";
            this.fotoEkle.UseVisualStyleBackColor = true;
            this.fotoEkle.Click += new System.EventHandler(this.fotoEkle_Click_1);
            // 
            // dogruRichTextBox1
            // 
            this.dogruRichTextBox1.Location = new System.Drawing.Point(137, 465);
            this.dogruRichTextBox1.Name = "dogruRichTextBox1";
            this.dogruRichTextBox1.Size = new System.Drawing.Size(565, 31);
            this.dogruRichTextBox1.TabIndex = 41;
            this.dogruRichTextBox1.Text = "";
            this.dogruRichTextBox1.TextChanged += new System.EventHandler(this.dogruRichTextBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(25, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Doğru)";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(708, 410);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(81, 80);
            this.btnCikis.TabIndex = 42;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // konularDataSet3BindingSource
            // 
            this.konularDataSet3BindingSource.DataSource = this.konularDataSet3;
            this.konularDataSet3BindingSource.Position = 0;
            // 
            // konularDataSet3
            // 
            this.konularDataSet3.DataSetName = "konularDataSet3";
            this.konularDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblUzunluk
            // 
            this.lblUzunluk.AutoSize = true;
            this.lblUzunluk.Location = new System.Drawing.Point(519, 181);
            this.lblUzunluk.Name = "lblUzunluk";
            this.lblUzunluk.Size = new System.Drawing.Size(0, 17);
            this.lblUzunluk.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblUzunluk);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.dogruRichTextBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.fotoEkle);
            this.panel1.Controls.Add(this.fotoTextBox1);
            this.panel1.Controls.Add(this.soruEkle);
            this.panel1.Controls.Add(this.altıCiziliCheck);
            this.panel1.Controls.Add(this.boldCheck);
            this.panel1.Controls.Add(this.dRichTextBox);
            this.panel1.Controls.Add(this.cRichTextBox);
            this.panel1.Controls.Add(this.bRichTextBox);
            this.panel1.Controls.Add(this.aRichTextBox);
            this.panel1.Controls.Add(this.soruRichTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 511);
            this.panel1.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnVeriAnalizi);
            this.panel2.Controls.Add(this.btnOlasilik);
            this.panel2.Controls.Add(this.btnEsitsizlik);
            this.panel2.Controls.Add(this.btnDogrusalDenklemler);
            this.panel2.Controls.Add(this.btnCarpan);
            this.panel2.Location = new System.Drawing.Point(605, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 243);
            this.panel2.TabIndex = 45;
            this.panel2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(67, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Üniteler";
            // 
            // btnVeriAnalizi
            // 
            this.btnVeriAnalizi.Location = new System.Drawing.Point(0, 198);
            this.btnVeriAnalizi.Name = "btnVeriAnalizi";
            this.btnVeriAnalizi.Size = new System.Drawing.Size(204, 33);
            this.btnVeriAnalizi.TabIndex = 4;
            this.btnVeriAnalizi.Text = "Veri Analizi";
            this.btnVeriAnalizi.UseVisualStyleBackColor = true;
            this.btnVeriAnalizi.Click += new System.EventHandler(this.btnVeriAnalizi_Click);
            // 
            // btnOlasilik
            // 
            this.btnOlasilik.Location = new System.Drawing.Point(0, 159);
            this.btnOlasilik.Name = "btnOlasilik";
            this.btnOlasilik.Size = new System.Drawing.Size(204, 33);
            this.btnOlasilik.TabIndex = 3;
            this.btnOlasilik.Text = "Olasılık";
            this.btnOlasilik.UseVisualStyleBackColor = true;
            this.btnOlasilik.Click += new System.EventHandler(this.btnOlasilik_Click);
            // 
            // btnEsitsizlik
            // 
            this.btnEsitsizlik.Location = new System.Drawing.Point(0, 120);
            this.btnEsitsizlik.Name = "btnEsitsizlik";
            this.btnEsitsizlik.Size = new System.Drawing.Size(204, 33);
            this.btnEsitsizlik.TabIndex = 2;
            this.btnEsitsizlik.Text = "Eşitsizlikler";
            this.btnEsitsizlik.UseVisualStyleBackColor = true;
            this.btnEsitsizlik.Click += new System.EventHandler(this.btnEsitsizlik_Click);
            // 
            // btnDogrusalDenklemler
            // 
            this.btnDogrusalDenklemler.Location = new System.Drawing.Point(0, 81);
            this.btnDogrusalDenklemler.Name = "btnDogrusalDenklemler";
            this.btnDogrusalDenklemler.Size = new System.Drawing.Size(204, 33);
            this.btnDogrusalDenklemler.TabIndex = 1;
            this.btnDogrusalDenklemler.Text = "Doğrusal Denklemler";
            this.btnDogrusalDenklemler.UseVisualStyleBackColor = true;
            this.btnDogrusalDenklemler.Click += new System.EventHandler(this.btnDogrusalDenklemler_Click);
            // 
            // btnCarpan
            // 
            this.btnCarpan.Location = new System.Drawing.Point(0, 42);
            this.btnCarpan.Name = "btnCarpan";
            this.btnCarpan.Size = new System.Drawing.Size(204, 33);
            this.btnCarpan.TabIndex = 0;
            this.btnCarpan.Text = "Çarpanlar";
            this.btnCarpan.UseVisualStyleBackColor = true;
            this.btnCarpan.Click += new System.EventHandler(this.btnCarpan_Click);
            // 
            // Soru_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 511);
            this.Controls.Add(this.panel1);
            this.Name = "Soru_Ekle";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Soru_Ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konularDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konularDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konularDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konularDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox soruRichTextBox;
        private System.Windows.Forms.RichTextBox aRichTextBox;
        private System.Windows.Forms.RichTextBox bRichTextBox;
        private System.Windows.Forms.RichTextBox cRichTextBox;
        private System.Windows.Forms.RichTextBox dRichTextBox;
        private System.Windows.Forms.CheckBox boldCheck;
        private System.Windows.Forms.CheckBox altıCiziliCheck;
        private System.Windows.Forms.Button soruEkle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox fotoTextBox1;
        private konularDataSet1 konularDataSet1;
        private System.Windows.Forms.BindingSource konularDataSet1BindingSource;
        private System.Windows.Forms.Button fotoEkle;
        private System.Windows.Forms.RichTextBox dogruRichTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.BindingSource konularDataSet3BindingSource;
        private konularDataSet3 konularDataSet3;
        private System.Windows.Forms.Label lblUzunluk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVeriAnalizi;
        private System.Windows.Forms.Button btnOlasilik;
        private System.Windows.Forms.Button btnEsitsizlik;
        private System.Windows.Forms.Button btnDogrusalDenklemler;
        private System.Windows.Forms.Button btnCarpan;
        private System.Windows.Forms.Label label6;
    }
}