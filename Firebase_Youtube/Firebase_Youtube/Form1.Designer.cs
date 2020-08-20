namespace Firebase_Youtube
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextID = new System.Windows.Forms.TextBox();
            this.TextName = new System.Windows.Forms.TextBox();
            this.TextAddress = new System.Windows.Forms.TextBox();
            this.TextAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonInsert = new System.Windows.Forms.Button();
            this.ButtonRetrive = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonDeleteAll = new System.Windows.Forms.Button();
            this.dataContacts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // TextID
            // 
            this.TextID.Location = new System.Drawing.Point(196, 11);
            this.TextID.Name = "TextID";
            this.TextID.Size = new System.Drawing.Size(100, 20);
            this.TextID.TabIndex = 0;
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(196, 49);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(292, 20);
            this.TextName.TabIndex = 1;
            // 
            // TextAddress
            // 
            this.TextAddress.Location = new System.Drawing.Point(196, 87);
            this.TextAddress.Name = "TextAddress";
            this.TextAddress.Size = new System.Drawing.Size(381, 20);
            this.TextAddress.TabIndex = 2;
            // 
            // TextAge
            // 
            this.TextAge.Location = new System.Drawing.Point(196, 125);
            this.TextAge.Name = "TextAge";
            this.TextAge.Size = new System.Drawing.Size(100, 20);
            this.TextAge.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Age";
            // 
            // ButtonInsert
            // 
            this.ButtonInsert.Location = new System.Drawing.Point(27, 168);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(100, 23);
            this.ButtonInsert.TabIndex = 8;
            this.ButtonInsert.Text = "Insert";
            this.ButtonInsert.UseVisualStyleBackColor = true;
            this.ButtonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // ButtonRetrive
            // 
            this.ButtonRetrive.Location = new System.Drawing.Point(133, 168);
            this.ButtonRetrive.Name = "ButtonRetrive";
            this.ButtonRetrive.Size = new System.Drawing.Size(100, 23);
            this.ButtonRetrive.TabIndex = 9;
            this.ButtonRetrive.Text = "Retrive";
            this.ButtonRetrive.UseVisualStyleBackColor = true;
            this.ButtonRetrive.Click += new System.EventHandler(this.ButtonRetrive_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(239, 168);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(100, 23);
            this.ButtonUpdate.TabIndex = 10;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(345, 168);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(100, 23);
            this.ButtonDelete.TabIndex = 11;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonDeleteAll
            // 
            this.ButtonDeleteAll.Location = new System.Drawing.Point(451, 168);
            this.ButtonDeleteAll.Name = "ButtonDeleteAll";
            this.ButtonDeleteAll.Size = new System.Drawing.Size(126, 23);
            this.ButtonDeleteAll.TabIndex = 12;
            this.ButtonDeleteAll.Text = "Delete All Elements";
            this.ButtonDeleteAll.UseVisualStyleBackColor = true;
            this.ButtonDeleteAll.Click += new System.EventHandler(this.ButtonDeleteAll_Click);
            // 
            // dataContacts
            // 
            this.dataContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataContacts.Location = new System.Drawing.Point(27, 216);
            this.dataContacts.Name = "dataContacts";
            this.dataContacts.Size = new System.Drawing.Size(550, 222);
            this.dataContacts.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.dataContacts);
            this.Controls.Add(this.ButtonDeleteAll);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonRetrive);
            this.Controls.Add(this.ButtonInsert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextAge);
            this.Controls.Add(this.TextAddress);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.TextID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextID;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.TextBox TextAddress;
        private System.Windows.Forms.TextBox TextAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonInsert;
        private System.Windows.Forms.Button ButtonRetrive;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonDeleteAll;
        private System.Windows.Forms.DataGridView dataContacts;
    }
}

