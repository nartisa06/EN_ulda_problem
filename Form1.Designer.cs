namespace EN_ulda_problem_23012024
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
            this.tb_vards = new System.Windows.Forms.TextBox();
            this.tb_veltijums = new System.Windows.Forms.TextBox();
            this.tb_ladites_garums = new System.Windows.Forms.TextBox();
            this.tb_rekins = new System.Windows.Forms.TextBox();
            this.tb_ladites_platums = new System.Windows.Forms.TextBox();
            this.b_aprekinat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_kokmaterials = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_augstums = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rtb_rekins = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.b_dzest = new System.Windows.Forms.Button();
            this.tb_dzest_id = new System.Windows.Forms.TextBox();
            this.b_apskatit = new System.Windows.Forms.Button();
            this.dgv_apskatit = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_apskatit)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_vards
            // 
            this.tb_vards.Location = new System.Drawing.Point(98, 103);
            this.tb_vards.Name = "tb_vards";
            this.tb_vards.Size = new System.Drawing.Size(100, 20);
            this.tb_vards.TabIndex = 0;
            // 
            // tb_veltijums
            // 
            this.tb_veltijums.Location = new System.Drawing.Point(98, 126);
            this.tb_veltijums.Name = "tb_veltijums";
            this.tb_veltijums.Size = new System.Drawing.Size(100, 20);
            this.tb_veltijums.TabIndex = 1;
            // 
            // tb_ladites_garums
            // 
            this.tb_ladites_garums.Location = new System.Drawing.Point(98, 152);
            this.tb_ladites_garums.Name = "tb_ladites_garums";
            this.tb_ladites_garums.Size = new System.Drawing.Size(100, 20);
            this.tb_ladites_garums.TabIndex = 2;
            // 
            // tb_rekins
            // 
            this.tb_rekins.Location = new System.Drawing.Point(136, 296);
            this.tb_rekins.Name = "tb_rekins";
            this.tb_rekins.Size = new System.Drawing.Size(100, 20);
            this.tb_rekins.TabIndex = 4;
            // 
            // tb_ladites_platums
            // 
            this.tb_ladites_platums.Location = new System.Drawing.Point(98, 178);
            this.tb_ladites_platums.Name = "tb_ladites_platums";
            this.tb_ladites_platums.Size = new System.Drawing.Size(100, 20);
            this.tb_ladites_platums.TabIndex = 5;
            // 
            // b_aprekinat
            // 
            this.b_aprekinat.Location = new System.Drawing.Point(136, 318);
            this.b_aprekinat.Name = "b_aprekinat";
            this.b_aprekinat.Size = new System.Drawing.Size(114, 23);
            this.b_aprekinat.TabIndex = 6;
            this.b_aprekinat.Text = "aprēķināt izmaksas";
            this.b_aprekinat.UseVisualStyleBackColor = true;
            this.b_aprekinat.Click += new System.EventHandler(this.b_aprekinat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Klienta vārds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "vēlējums";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Lādītes garums";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lādītes platums";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "kopējā summa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "kokmateriāla cena";
            // 
            // tb_kokmaterials
            // 
            this.tb_kokmaterials.Location = new System.Drawing.Point(136, 237);
            this.tb_kokmaterials.Name = "tb_kokmaterials";
            this.tb_kokmaterials.Size = new System.Drawing.Size(100, 20);
            this.tb_kokmaterials.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "lodītes augstums";
            // 
            // tb_augstums
            // 
            this.tb_augstums.Location = new System.Drawing.Point(107, 208);
            this.tb_augstums.Name = "tb_augstums";
            this.tb_augstums.Size = new System.Drawing.Size(100, 20);
            this.tb_augstums.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "veidot rēķinu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtb_rekins
            // 
            this.rtb_rekins.Location = new System.Drawing.Point(297, 58);
            this.rtb_rekins.Name = "rtb_rekins";
            this.rtb_rekins.Size = new System.Drawing.Size(145, 156);
            this.rtb_rekins.TabIndex = 18;
            this.rtb_rekins.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "eiro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(486, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "dzēst ID";
            // 
            // b_dzest
            // 
            this.b_dzest.Location = new System.Drawing.Point(644, 299);
            this.b_dzest.Name = "b_dzest";
            this.b_dzest.Size = new System.Drawing.Size(75, 23);
            this.b_dzest.TabIndex = 22;
            this.b_dzest.Text = "dzest";
            this.b_dzest.UseVisualStyleBackColor = true;
            this.b_dzest.Click += new System.EventHandler(this.b_dzest_Click);
            // 
            // tb_dzest_id
            // 
            this.tb_dzest_id.Location = new System.Drawing.Point(538, 300);
            this.tb_dzest_id.Name = "tb_dzest_id";
            this.tb_dzest_id.Size = new System.Drawing.Size(100, 20);
            this.tb_dzest_id.TabIndex = 23;
            // 
            // b_apskatit
            // 
            this.b_apskatit.Location = new System.Drawing.Point(489, 233);
            this.b_apskatit.Name = "b_apskatit";
            this.b_apskatit.Size = new System.Drawing.Size(166, 23);
            this.b_apskatit.TabIndex = 24;
            this.b_apskatit.Text = "apskatīt datus";
            this.b_apskatit.UseVisualStyleBackColor = true;
            this.b_apskatit.Click += new System.EventHandler(this.b_apskatit_Click);
            // 
            // dgv_apskatit
            // 
            this.dgv_apskatit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_apskatit.Location = new System.Drawing.Point(489, 64);
            this.dgv_apskatit.Name = "dgv_apskatit";
            this.dgv_apskatit.Size = new System.Drawing.Size(240, 150);
            this.dgv_apskatit.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_apskatit);
            this.Controls.Add(this.b_apskatit);
            this.Controls.Add(this.tb_dzest_id);
            this.Controls.Add(this.b_dzest);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rtb_rekins);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_augstums);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_kokmaterials);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_aprekinat);
            this.Controls.Add(this.tb_ladites_platums);
            this.Controls.Add(this.tb_rekins);
            this.Controls.Add(this.tb_ladites_garums);
            this.Controls.Add(this.tb_veltijums);
            this.Controls.Add(this.tb_vards);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_apskatit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_vards;
        private System.Windows.Forms.TextBox tb_veltijums;
        private System.Windows.Forms.TextBox tb_ladites_garums;
        private System.Windows.Forms.TextBox tb_rekins;
        private System.Windows.Forms.TextBox tb_ladites_platums;
        private System.Windows.Forms.Button b_aprekinat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_kokmaterials;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_augstums;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtb_rekins;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button b_dzest;
        private System.Windows.Forms.TextBox tb_dzest_id;
        private System.Windows.Forms.Button b_apskatit;
        private System.Windows.Forms.DataGridView dgv_apskatit;
    }
}

