
namespace WindowsFormsMysql
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Insert = new System.Windows.Forms.Button();
            this.textBox_Tipus = new System.Windows.Forms.TextBox();
            this.textBox_Gyartmany = new System.Windows.Forms.TextBox();
            this.textBox_Rendszam = new System.Windows.Forms.TextBox();
            this.textBox_Kod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Autok = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Tipus);
            this.groupBox1.Controls.Add(this.textBox_Gyartmany);
            this.groupBox1.Controls.Add(this.textBox_Rendszam);
            this.groupBox1.Controls.Add(this.textBox_Kod);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autó adatai";
            // 
            // button_Update
            // 
            this.button_Update.AutoSize = true;
            this.button_Update.Location = new System.Drawing.Point(12, 318);
            this.button_Update.Name = "button_Update";
            this.button_Update.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button_Update.Size = new System.Drawing.Size(273, 33);
            this.button_Update.TabIndex = 6;
            this.button_Update.Text = "Módosít";
            this.button_Update.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.AutoSize = true;
            this.button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Delete.Location = new System.Drawing.Point(12, 281);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button_Delete.Size = new System.Drawing.Size(273, 33);
            this.button_Delete.TabIndex = 6;
            this.button_Delete.Text = "Töröl";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Insert
            // 
            this.button_Insert.AutoSize = true;
            this.button_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_Insert.Location = new System.Drawing.Point(13, 241);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button_Insert.Size = new System.Drawing.Size(272, 33);
            this.button_Insert.TabIndex = 6;
            this.button_Insert.Text = "Rögzít";
            this.button_Insert.UseVisualStyleBackColor = false;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // textBox_Tipus
            // 
            this.textBox_Tipus.Location = new System.Drawing.Point(75, 155);
            this.textBox_Tipus.Name = "textBox_Tipus";
            this.textBox_Tipus.Size = new System.Drawing.Size(115, 20);
            this.textBox_Tipus.TabIndex = 5;
            // 
            // textBox_Gyartmany
            // 
            this.textBox_Gyartmany.Location = new System.Drawing.Point(75, 115);
            this.textBox_Gyartmany.Name = "textBox_Gyartmany";
            this.textBox_Gyartmany.Size = new System.Drawing.Size(115, 20);
            this.textBox_Gyartmany.TabIndex = 4;
            // 
            // textBox_Rendszam
            // 
            this.textBox_Rendszam.Location = new System.Drawing.Point(75, 75);
            this.textBox_Rendszam.Name = "textBox_Rendszam";
            this.textBox_Rendszam.Size = new System.Drawing.Size(115, 20);
            this.textBox_Rendszam.TabIndex = 3;
            // 
            // textBox_Kod
            // 
            this.textBox_Kod.Location = new System.Drawing.Point(75, 35);
            this.textBox_Kod.Name = "textBox_Kod";
            this.textBox_Kod.Size = new System.Drawing.Size(115, 20);
            this.textBox_Kod.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kód";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gyártmány";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rendszám";
            // 
            // listBox_Autok
            // 
            this.listBox_Autok.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox_Autok.FormattingEnabled = true;
            this.listBox_Autok.Location = new System.Drawing.Point(315, 0);
            this.listBox_Autok.Name = "listBox_Autok";
            this.listBox_Autok.Size = new System.Drawing.Size(276, 368);
            this.listBox_Autok.TabIndex = 1;
            this.listBox_Autok.SelectedIndexChanged += new System.EventHandler(this.listBox_Autok_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 368);
            this.Controls.Add(this.button_Insert);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.listBox_Autok);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Autók adatainak kezelése";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.TextBox textBox_Tipus;
        private System.Windows.Forms.TextBox textBox_Gyartmany;
        private System.Windows.Forms.TextBox textBox_Rendszam;
        private System.Windows.Forms.TextBox textBox_Kod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Autok;
    }
}

