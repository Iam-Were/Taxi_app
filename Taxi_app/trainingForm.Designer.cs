namespace Taxi_app
{
    partial class trainingForm
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
            this.deleteButton2 = new System.Windows.Forms.Button();
            this.createButton2 = new System.Windows.Forms.Button();
            this.updateButton2 = new System.Windows.Forms.Button();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteButton2
            // 
            this.deleteButton2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton2.Location = new System.Drawing.Point(48, 534);
            this.deleteButton2.Name = "deleteButton2";
            this.deleteButton2.Size = new System.Drawing.Size(289, 41);
            this.deleteButton2.TabIndex = 11;
            this.deleteButton2.Text = "Delete";
            this.deleteButton2.UseVisualStyleBackColor = true;
            // 
            // createButton2
            // 
            this.createButton2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton2.Location = new System.Drawing.Point(48, 440);
            this.createButton2.Name = "createButton2";
            this.createButton2.Size = new System.Drawing.Size(289, 41);
            this.createButton2.TabIndex = 12;
            this.createButton2.Text = "Create";
            this.createButton2.UseVisualStyleBackColor = true;
            // 
            // updateButton2
            // 
            this.updateButton2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton2.Location = new System.Drawing.Point(48, 487);
            this.updateButton2.Name = "updateButton2";
            this.updateButton2.Size = new System.Drawing.Size(289, 41);
            this.updateButton2.TabIndex = 13;
            this.updateButton2.Text = "Update";
            this.updateButton2.UseVisualStyleBackColor = true;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Font = new System.Drawing.Font("Cambria Math", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextbox.Location = new System.Drawing.Point(168, 198);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(159, 26);
            this.nameTextbox.TabIndex = 14;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(83, 205);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(66, 19);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Training";
            // 
            // trainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 649);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.updateButton2);
            this.Controls.Add(this.createButton2);
            this.Controls.Add(this.deleteButton2);
            this.Name = "trainingForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton2;
        private System.Windows.Forms.Button createButton2;
        private System.Windows.Forms.Button updateButton2;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label nameLabel;
    }
}