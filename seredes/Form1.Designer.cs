namespace seredes
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Create = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.Delate = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.Visudati = new System.Windows.Forms.ListBox();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(15, 189);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(108, 53);
            this.Create.TabIndex = 0;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(15, 248);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(108, 54);
            this.Read.TabIndex = 1;
            this.Read.Text = "Read";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Delate
            // 
            this.Delate.Location = new System.Drawing.Point(129, 248);
            this.Delate.Name = "Delate";
            this.Delate.Size = new System.Drawing.Size(102, 54);
            this.Delate.TabIndex = 2;
            this.Delate.Text = "Delate";
            this.Delate.UseVisualStyleBackColor = true;
            this.Delate.Click += new System.EventHandler(this.Delate_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(129, 189);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(102, 53);
            this.Update.TabIndex = 3;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 40);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(137, 20);
            this.name.TabIndex = 4;
            this.name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(12, 85);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(137, 20);
            this.Surname.TabIndex = 5;
            this.Surname.TextChanged += new System.EventHandler(this.Surname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Age";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(15, 124);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(134, 20);
            this.Age.TabIndex = 9;
            // 
            // Visudati
            // 
            this.Visudati.FormattingEnabled = true;
            this.Visudati.Location = new System.Drawing.Point(310, 24);
            this.Visudati.Name = "Visudati";
            this.Visudati.Size = new System.Drawing.Size(403, 355);
            this.Visudati.TabIndex = 10;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(15, 308);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(108, 54);
            this.Save.TabIndex = 11;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Visudati);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delate);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.Create);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button Delate;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.ListBox Visudati;
        private System.Windows.Forms.Button Save;
    }
}

