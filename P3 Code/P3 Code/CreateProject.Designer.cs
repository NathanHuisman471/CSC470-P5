namespace P3_Code
{
    partial class CreateProject
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
            this.CreateProjectAddButton = new System.Windows.Forms.Button();
            this.CreateProjectCancelButton = new System.Windows.Forms.Button();
            this.CreateProjectTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateProjectAddButton
            // 
            this.CreateProjectAddButton.Location = new System.Drawing.Point(312, 84);
            this.CreateProjectAddButton.Name = "CreateProjectAddButton";
            this.CreateProjectAddButton.Size = new System.Drawing.Size(75, 23);
            this.CreateProjectAddButton.TabIndex = 0;
            this.CreateProjectAddButton.Text = "Add";
            this.CreateProjectAddButton.UseVisualStyleBackColor = true;
            this.CreateProjectAddButton.Click += new System.EventHandler(this.CreateProjectAddButton_Click);
            // 
            // CreateProjectCancelButton
            // 
            this.CreateProjectCancelButton.Location = new System.Drawing.Point(180, 84);
            this.CreateProjectCancelButton.Name = "CreateProjectCancelButton";
            this.CreateProjectCancelButton.Size = new System.Drawing.Size(75, 23);
            this.CreateProjectCancelButton.TabIndex = 1;
            this.CreateProjectCancelButton.Text = "Cancel";
            this.CreateProjectCancelButton.UseVisualStyleBackColor = true;
            this.CreateProjectCancelButton.Click += new System.EventHandler(this.CreateProjectCancelButton_Click);
            // 
            // CreateProjectTextBox
            // 
            this.CreateProjectTextBox.Location = new System.Drawing.Point(115, 36);
            this.CreateProjectTextBox.Name = "CreateProjectTextBox";
            this.CreateProjectTextBox.Size = new System.Drawing.Size(272, 20);
            this.CreateProjectTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Project Name:";
            // 
            // CreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 144);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateProjectTextBox);
            this.Controls.Add(this.CreateProjectCancelButton);
            this.Controls.Add(this.CreateProjectAddButton);
            this.Name = "CreateProject";
            this.Text = "Create Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateProjectAddButton;
        private System.Windows.Forms.Button CreateProjectCancelButton;
        private System.Windows.Forms.TextBox CreateProjectTextBox;
        private System.Windows.Forms.Label label1;
    }
}