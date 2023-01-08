
namespace OverPutty
{
    partial class ConfigForm
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
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDatabaseFileSelect = new System.Windows.Forms.Button();
            this.listBoxUslugi = new System.Windows.Forms.ListBox();
            this.buttonAddUslugi = new System.Windows.Forms.Button();
            this.buttonEdytujUslugi = new System.Windows.Forms.Button();
            this.buttonKasujUslugi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonKasujSlowniki = new System.Windows.Forms.Button();
            this.buttonEdytujSlowniki = new System.Windows.Forms.Button();
            this.buttonDodajSlowniki = new System.Windows.Forms.Button();
            this.listBoxSlowniki = new System.Windows.Forms.ListBox();
            this.buttonWartosciSlowniki = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonKasujCechy = new System.Windows.Forms.Button();
            this.buttonEdytujCechy = new System.Windows.Forms.Button();
            this.buttonDodajCechy = new System.Windows.Forms.Button();
            this.listBoxCechy = new System.Windows.Forms.ListBox();
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(16, 24);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(286, 20);
            this.textBoxDatabase.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Baza danych programu";
            // 
            // buttonDatabaseFileSelect
            // 
            this.buttonDatabaseFileSelect.Location = new System.Drawing.Point(308, 24);
            this.buttonDatabaseFileSelect.Name = "buttonDatabaseFileSelect";
            this.buttonDatabaseFileSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonDatabaseFileSelect.TabIndex = 2;
            this.buttonDatabaseFileSelect.Text = "Wybierz";
            this.buttonDatabaseFileSelect.UseVisualStyleBackColor = true;
            this.buttonDatabaseFileSelect.Click += new System.EventHandler(this.buttonDatabaseFileSelect_Click);
            // 
            // listBoxUslugi
            // 
            this.listBoxUslugi.FormattingEnabled = true;
            this.listBoxUslugi.Location = new System.Drawing.Point(16, 75);
            this.listBoxUslugi.Name = "listBoxUslugi";
            this.listBoxUslugi.Size = new System.Drawing.Size(286, 95);
            this.listBoxUslugi.TabIndex = 3;
            // 
            // buttonAddUslugi
            // 
            this.buttonAddUslugi.Location = new System.Drawing.Point(308, 75);
            this.buttonAddUslugi.Name = "buttonAddUslugi";
            this.buttonAddUslugi.Size = new System.Drawing.Size(75, 23);
            this.buttonAddUslugi.TabIndex = 4;
            this.buttonAddUslugi.Text = "Dodaj";
            this.buttonAddUslugi.UseVisualStyleBackColor = true;
            this.buttonAddUslugi.Click += new System.EventHandler(this.buttonUslugiDodaj_Click);
            // 
            // buttonEdytujUslugi
            // 
            this.buttonEdytujUslugi.Location = new System.Drawing.Point(308, 104);
            this.buttonEdytujUslugi.Name = "buttonEdytujUslugi";
            this.buttonEdytujUslugi.Size = new System.Drawing.Size(75, 23);
            this.buttonEdytujUslugi.TabIndex = 5;
            this.buttonEdytujUslugi.Text = "Edytuj";
            this.buttonEdytujUslugi.UseVisualStyleBackColor = true;
            this.buttonEdytujUslugi.Click += new System.EventHandler(this.buttonEdytujUslugi_Click);
            // 
            // buttonKasujUslugi
            // 
            this.buttonKasujUslugi.Location = new System.Drawing.Point(308, 133);
            this.buttonKasujUslugi.Name = "buttonKasujUslugi";
            this.buttonKasujUslugi.Size = new System.Drawing.Size(75, 23);
            this.buttonKasujUslugi.TabIndex = 6;
            this.buttonKasujUslugi.Text = "Kasuj";
            this.buttonKasujUslugi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usługi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Słowniki";
            // 
            // buttonKasujSlowniki
            // 
            this.buttonKasujSlowniki.Location = new System.Drawing.Point(308, 253);
            this.buttonKasujSlowniki.Name = "buttonKasujSlowniki";
            this.buttonKasujSlowniki.Size = new System.Drawing.Size(75, 23);
            this.buttonKasujSlowniki.TabIndex = 11;
            this.buttonKasujSlowniki.Text = "Kasuj";
            this.buttonKasujSlowniki.UseVisualStyleBackColor = true;
            // 
            // buttonEdytujSlowniki
            // 
            this.buttonEdytujSlowniki.Location = new System.Drawing.Point(308, 224);
            this.buttonEdytujSlowniki.Name = "buttonEdytujSlowniki";
            this.buttonEdytujSlowniki.Size = new System.Drawing.Size(75, 23);
            this.buttonEdytujSlowniki.TabIndex = 10;
            this.buttonEdytujSlowniki.Text = "Edytuj";
            this.buttonEdytujSlowniki.UseVisualStyleBackColor = true;
            this.buttonEdytujSlowniki.Click += new System.EventHandler(this.buttonEdytujSlowniki_Click);
            // 
            // buttonDodajSlowniki
            // 
            this.buttonDodajSlowniki.Location = new System.Drawing.Point(308, 195);
            this.buttonDodajSlowniki.Name = "buttonDodajSlowniki";
            this.buttonDodajSlowniki.Size = new System.Drawing.Size(75, 23);
            this.buttonDodajSlowniki.TabIndex = 9;
            this.buttonDodajSlowniki.Text = "Dodaj";
            this.buttonDodajSlowniki.UseVisualStyleBackColor = true;
            this.buttonDodajSlowniki.Click += new System.EventHandler(this.buttonDodajSlowniki_Click);
            // 
            // listBoxSlowniki
            // 
            this.listBoxSlowniki.FormattingEnabled = true;
            this.listBoxSlowniki.Location = new System.Drawing.Point(16, 195);
            this.listBoxSlowniki.Name = "listBoxSlowniki";
            this.listBoxSlowniki.Size = new System.Drawing.Size(286, 108);
            this.listBoxSlowniki.TabIndex = 8;
            // 
            // buttonWartosciSlowniki
            // 
            this.buttonWartosciSlowniki.Location = new System.Drawing.Point(308, 280);
            this.buttonWartosciSlowniki.Name = "buttonWartosciSlowniki";
            this.buttonWartosciSlowniki.Size = new System.Drawing.Size(75, 23);
            this.buttonWartosciSlowniki.TabIndex = 13;
            this.buttonWartosciSlowniki.Text = "Wartości";
            this.buttonWartosciSlowniki.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cechy";
            // 
            // buttonKasujCechy
            // 
            this.buttonKasujCechy.Location = new System.Drawing.Point(308, 385);
            this.buttonKasujCechy.Name = "buttonKasujCechy";
            this.buttonKasujCechy.Size = new System.Drawing.Size(75, 23);
            this.buttonKasujCechy.TabIndex = 17;
            this.buttonKasujCechy.Text = "Kasuj";
            this.buttonKasujCechy.UseVisualStyleBackColor = true;
            // 
            // buttonEdytujCechy
            // 
            this.buttonEdytujCechy.Location = new System.Drawing.Point(308, 356);
            this.buttonEdytujCechy.Name = "buttonEdytujCechy";
            this.buttonEdytujCechy.Size = new System.Drawing.Size(75, 23);
            this.buttonEdytujCechy.TabIndex = 16;
            this.buttonEdytujCechy.Text = "Edytuj";
            this.buttonEdytujCechy.UseVisualStyleBackColor = true;
            this.buttonEdytujCechy.Click += new System.EventHandler(this.buttonEdytujCechy_Click);
            // 
            // buttonDodajCechy
            // 
            this.buttonDodajCechy.Location = new System.Drawing.Point(308, 327);
            this.buttonDodajCechy.Name = "buttonDodajCechy";
            this.buttonDodajCechy.Size = new System.Drawing.Size(75, 23);
            this.buttonDodajCechy.TabIndex = 15;
            this.buttonDodajCechy.Text = "Dodaj";
            this.buttonDodajCechy.UseVisualStyleBackColor = true;
            this.buttonDodajCechy.Click += new System.EventHandler(this.buttonDodajCechy_Click);
            // 
            // listBoxCechy
            // 
            this.listBoxCechy.FormattingEnabled = true;
            this.listBoxCechy.Location = new System.Drawing.Point(16, 327);
            this.listBoxCechy.Name = "listBoxCechy";
            this.listBoxCechy.Size = new System.Drawing.Size(286, 95);
            this.listBoxCechy.TabIndex = 14;
            // 
            // buttonZamknij
            // 
            this.buttonZamknij.Location = new System.Drawing.Point(325, 443);
            this.buttonZamknij.Name = "buttonZamknij";
            this.buttonZamknij.Size = new System.Drawing.Size(75, 23);
            this.buttonZamknij.TabIndex = 19;
            this.buttonZamknij.Text = "Zamknij";
            this.buttonZamknij.UseVisualStyleBackColor = true;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 466);
            this.Controls.Add(this.buttonZamknij);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonKasujCechy);
            this.Controls.Add(this.buttonEdytujCechy);
            this.Controls.Add(this.buttonDodajCechy);
            this.Controls.Add(this.listBoxCechy);
            this.Controls.Add(this.buttonWartosciSlowniki);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonKasujSlowniki);
            this.Controls.Add(this.buttonEdytujSlowniki);
            this.Controls.Add(this.buttonDodajSlowniki);
            this.Controls.Add(this.listBoxSlowniki);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonKasujUslugi);
            this.Controls.Add(this.buttonEdytujUslugi);
            this.Controls.Add(this.buttonAddUslugi);
            this.Controls.Add(this.listBoxUslugi);
            this.Controls.Add(this.buttonDatabaseFileSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDatabase);
            this.Name = "ConfigForm";
            this.Text = "Konfiguracja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDatabaseFileSelect;
        private System.Windows.Forms.ListBox listBoxUslugi;
        private System.Windows.Forms.Button buttonAddUslugi;
        private System.Windows.Forms.Button buttonEdytujUslugi;
        private System.Windows.Forms.Button buttonKasujUslugi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonKasujSlowniki;
        private System.Windows.Forms.Button buttonEdytujSlowniki;
        private System.Windows.Forms.Button buttonDodajSlowniki;
        private System.Windows.Forms.ListBox listBoxSlowniki;
        private System.Windows.Forms.Button buttonWartosciSlowniki;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonKasujCechy;
        private System.Windows.Forms.Button buttonEdytujCechy;
        private System.Windows.Forms.Button buttonDodajCechy;
        private System.Windows.Forms.ListBox listBoxCechy;
        private System.Windows.Forms.Button buttonZamknij;
    }
}