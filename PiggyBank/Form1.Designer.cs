namespace PiggyBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnParaKoy = new System.Windows.Forms.Button();
            this.cbMadeniPara = new System.Windows.Forms.ComboBox();
            this.cbKagıtPara = new System.Windows.Forms.ComboBox();
            this.btnSalla = new System.Windows.Forms.Button();
            this.btnKır = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sonucLabel = new System.Windows.Forms.Label();
            this.btnYapaistir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTopamHacim = new System.Windows.Forms.Label();
            this.lblParaHacim = new System.Windows.Forms.Label();
            this.lblParaEkstraHacim = new System.Windows.Forms.Label();
            this.lblMadeniParaSonuc = new System.Windows.Forms.Label();
            this.lblKagıtParaSonuc = new System.Windows.Forms.Label();
            this.btnMadeniParaKoy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnParaKoy
            // 
            this.btnParaKoy.Location = new System.Drawing.Point(12, 148);
            this.btnParaKoy.Name = "btnParaKoy";
            this.btnParaKoy.Size = new System.Drawing.Size(121, 23);
            this.btnParaKoy.TabIndex = 0;
            this.btnParaKoy.Text = "Para Koy!";
            this.btnParaKoy.UseVisualStyleBackColor = true;
            this.btnParaKoy.Click += new System.EventHandler(this.btnParaKoy_Click);
            // 
            // cbMadeniPara
            // 
            this.cbMadeniPara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMadeniPara.FormattingEnabled = true;
            this.cbMadeniPara.Location = new System.Drawing.Point(12, 54);
            this.cbMadeniPara.Name = "cbMadeniPara";
            this.cbMadeniPara.Size = new System.Drawing.Size(121, 21);
            this.cbMadeniPara.TabIndex = 1;
            // 
            // cbKagıtPara
            // 
            this.cbKagıtPara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKagıtPara.FormattingEnabled = true;
            this.cbKagıtPara.Location = new System.Drawing.Point(12, 121);
            this.cbKagıtPara.Name = "cbKagıtPara";
            this.cbKagıtPara.Size = new System.Drawing.Size(121, 21);
            this.cbKagıtPara.TabIndex = 2;
            // 
            // btnSalla
            // 
            this.btnSalla.Location = new System.Drawing.Point(649, 353);
            this.btnSalla.Name = "btnSalla";
            this.btnSalla.Size = new System.Drawing.Size(139, 23);
            this.btnSalla.TabIndex = 3;
            this.btnSalla.Text = "Salla!";
            this.btnSalla.UseVisualStyleBackColor = true;
            this.btnSalla.Click += new System.EventHandler(this.btnSalla_Click);
            // 
            // btnKır
            // 
            this.btnKır.Location = new System.Drawing.Point(12, 353);
            this.btnKır.Name = "btnKır";
            this.btnKır.Size = new System.Drawing.Size(133, 23);
            this.btnKır.TabIndex = 4;
            this.btnKır.Text = "Kır!";
            this.btnKır.UseVisualStyleBackColor = true;
            this.btnKır.Click += new System.EventHandler(this.btnKır_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Madeni Para";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kağıt Para";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(574, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Paraların Kapladığı Hacim :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(528, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Paraların Kapladığı Fazladan Hacim :";
            // 
            // sonucLabel
            // 
            this.sonucLabel.Location = new System.Drawing.Point(649, 38);
            this.sonucLabel.Name = "sonucLabel";
            this.sonucLabel.Size = new System.Drawing.Size(139, 311);
            this.sonucLabel.TabIndex = 8;
            // 
            // btnYapaistir
            // 
            this.btnYapaistir.Enabled = false;
            this.btnYapaistir.Location = new System.Drawing.Point(12, 382);
            this.btnYapaistir.Name = "btnYapaistir";
            this.btnYapaistir.Size = new System.Drawing.Size(133, 23);
            this.btnYapaistir.TabIndex = 9;
            this.btnYapaistir.Text = "Yapıştır!";
            this.btnYapaistir.UseVisualStyleBackColor = true;
            this.btnYapaistir.Click += new System.EventHandler(this.btnYapaistir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(605, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kumbaranın Hacmi :";
            // 
            // lblTopamHacim
            // 
            this.lblTopamHacim.AutoSize = true;
            this.lblTopamHacim.BackColor = System.Drawing.Color.Transparent;
            this.lblTopamHacim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTopamHacim.Location = new System.Drawing.Point(713, 387);
            this.lblTopamHacim.Name = "lblTopamHacim";
            this.lblTopamHacim.Size = new System.Drawing.Size(0, 13);
            this.lblTopamHacim.TabIndex = 11;
            // 
            // lblParaHacim
            // 
            this.lblParaHacim.AutoSize = true;
            this.lblParaHacim.BackColor = System.Drawing.Color.Transparent;
            this.lblParaHacim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblParaHacim.Location = new System.Drawing.Point(713, 404);
            this.lblParaHacim.Name = "lblParaHacim";
            this.lblParaHacim.Size = new System.Drawing.Size(0, 13);
            this.lblParaHacim.TabIndex = 12;
            // 
            // lblParaEkstraHacim
            // 
            this.lblParaEkstraHacim.AutoSize = true;
            this.lblParaEkstraHacim.BackColor = System.Drawing.Color.Transparent;
            this.lblParaEkstraHacim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblParaEkstraHacim.Location = new System.Drawing.Point(713, 428);
            this.lblParaEkstraHacim.Name = "lblParaEkstraHacim";
            this.lblParaEkstraHacim.Size = new System.Drawing.Size(0, 13);
            this.lblParaEkstraHacim.TabIndex = 13;
            // 
            // lblMadeniParaSonuc
            // 
            this.lblMadeniParaSonuc.AutoSize = true;
            this.lblMadeniParaSonuc.BackColor = System.Drawing.Color.Transparent;
            this.lblMadeniParaSonuc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMadeniParaSonuc.Location = new System.Drawing.Point(139, 57);
            this.lblMadeniParaSonuc.Name = "lblMadeniParaSonuc";
            this.lblMadeniParaSonuc.Size = new System.Drawing.Size(0, 13);
            this.lblMadeniParaSonuc.TabIndex = 14;
            // 
            // lblKagıtParaSonuc
            // 
            this.lblKagıtParaSonuc.AutoSize = true;
            this.lblKagıtParaSonuc.BackColor = System.Drawing.Color.Transparent;
            this.lblKagıtParaSonuc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKagıtParaSonuc.Location = new System.Drawing.Point(139, 129);
            this.lblKagıtParaSonuc.Name = "lblKagıtParaSonuc";
            this.lblKagıtParaSonuc.Size = new System.Drawing.Size(0, 13);
            this.lblKagıtParaSonuc.TabIndex = 15;
            // 
            // btnMadeniParaKoy
            // 
            this.btnMadeniParaKoy.Location = new System.Drawing.Point(12, 79);
            this.btnMadeniParaKoy.Name = "btnMadeniParaKoy";
            this.btnMadeniParaKoy.Size = new System.Drawing.Size(121, 23);
            this.btnMadeniParaKoy.TabIndex = 16;
            this.btnMadeniParaKoy.Text = "Para Koy!";
            this.btnMadeniParaKoy.UseVisualStyleBackColor = true;
            this.btnMadeniParaKoy.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PiggyBank.Properties.Resources.sağlam;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMadeniParaKoy);
            this.Controls.Add(this.lblKagıtParaSonuc);
            this.Controls.Add(this.lblMadeniParaSonuc);
            this.Controls.Add(this.lblParaEkstraHacim);
            this.Controls.Add(this.lblParaHacim);
            this.Controls.Add(this.lblTopamHacim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnYapaistir);
            this.Controls.Add(this.sonucLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKır);
            this.Controls.Add(this.btnSalla);
            this.Controls.Add(this.cbKagıtPara);
            this.Controls.Add(this.cbMadeniPara);
            this.Controls.Add(this.btnParaKoy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Piggy Bank";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParaKoy;
        private System.Windows.Forms.ComboBox cbMadeniPara;
        private System.Windows.Forms.ComboBox cbKagıtPara;
        private System.Windows.Forms.Button btnSalla;
        private System.Windows.Forms.Button btnKır;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sonucLabel;
        private System.Windows.Forms.Button btnYapaistir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTopamHacim;
        private System.Windows.Forms.Label lblParaHacim;
        private System.Windows.Forms.Label lblParaEkstraHacim;
        private System.Windows.Forms.Label lblMadeniParaSonuc;
        private System.Windows.Forms.Label lblKagıtParaSonuc;
        private System.Windows.Forms.Button btnMadeniParaKoy;
    }
}

