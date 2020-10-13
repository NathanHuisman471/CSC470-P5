namespace P3_Code
{
    partial class ModifyProject
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
            this.ModifyProjectModifyButton = new System.Windows.Forms.Button();
            this.ModifyProjectCancelButton = new System.Windows.Forms.Button();
            this.ModifyProjectTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ModifyProjectModifyButton
            // 
            this.ModifyProjectModifyButton.Location = new System.Drawing.Point(325, 94);
            this.ModifyProjectModifyButton.Name = "ModifyProjectModifyButton";
            this.ModifyProjectModifyButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyProjectModifyButton.TabIndex = 0;
            this.ModifyProjectModifyButton.Text = "Modify";
            this.ModifyProjectModifyButton.UseVisualStyleBackColor = true;
            this.ModifyProjectModifyButton.Click += new System.EventHandler(this.ModifyProjectModifyButton_Click);
            // 
            // ModifyProjectCancelButton
            // 
            this.ModifyProjectCancelButton.Location = new System.Drawing.Point(205, 94);
            this.ModifyProjectCancelButton.Name = "ModifyProjectCancelButton";
            this.ModifyProjectCancelButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyProjectCancelButton.TabIndex = 1;
            this.ModifyProjectCancelButton.Text = "Cancel";
            this.ModifyProjectCancelButton.UseVisualStyleBackColor = true;
            this.ModifyProjectCancelButton.Click += new System.EventHandler(this.ModifyProjectCancelButton_Click);
            // 
            // ModifyProjectTextBox
            // 
            this.ModifyProjectTextBox.Location = new System.Drawing.Point(119, 50);
            this.ModifyProjectTextBox.Name = "ModifyProjectTextBox";
            this.ModifyProjectTextBox.Size = new System.Drawing.Size(281, 20);
            this.ModifyProjectTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Project Name";
            // 
            // ModifyProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 163);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModifyProjectTextBox);
            this.Controls.Add(this.ModifyProjectCancelButton);
            this.Controls.Add(this.ModifyProjectModifyButton);
            this.Name = "ModifyProject";
            this.Text = "Modify Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModifyProjectModifyButton;
        private System.Windows.Forms.Button ModifyProjectCancelButton;
        private System.Windows.Forms.TextBox ModifyProjectTextBox;
        private System.Windows.Forms.Label label1;
    }
}