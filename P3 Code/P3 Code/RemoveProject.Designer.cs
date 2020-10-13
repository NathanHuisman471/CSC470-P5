namespace P3_Code
{
    partial class RemoveProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveProjectCancelButton = new System.Windows.Forms.Button();
            this.RemoveProjectRemoveButton = new System.Windows.Forms.Button();
            this.ProjectToBeRemovedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project to remove: ";
            // 
            // RemoveProjectCancelButton
            // 
            this.RemoveProjectCancelButton.Location = new System.Drawing.Point(157, 103);
            this.RemoveProjectCancelButton.Name = "RemoveProjectCancelButton";
            this.RemoveProjectCancelButton.Size = new System.Drawing.Size(115, 23);
            this.RemoveProjectCancelButton.TabIndex = 1;
            this.RemoveProjectCancelButton.Text = "Cancel";
            this.RemoveProjectCancelButton.UseVisualStyleBackColor = true;
            this.RemoveProjectCancelButton.Click += new System.EventHandler(this.RemoveProjectCancelButton_Click);
            // 
            // RemoveProjectRemoveButton
            // 
            this.RemoveProjectRemoveButton.Location = new System.Drawing.Point(307, 103);
            this.RemoveProjectRemoveButton.Name = "RemoveProjectRemoveButton";
            this.RemoveProjectRemoveButton.Size = new System.Drawing.Size(116, 23);
            this.RemoveProjectRemoveButton.TabIndex = 2;
            this.RemoveProjectRemoveButton.Text = "Remove Project";
            this.RemoveProjectRemoveButton.UseVisualStyleBackColor = true;
            this.RemoveProjectRemoveButton.Click += new System.EventHandler(this.RemoveProjectRemoveButton_Click);
            // 
            // ProjectToBeRemovedLabel
            // 
            this.ProjectToBeRemovedLabel.AutoSize = true;
            this.ProjectToBeRemovedLabel.Location = new System.Drawing.Point(154, 45);
            this.ProjectToBeRemovedLabel.Name = "ProjectToBeRemovedLabel";
            this.ProjectToBeRemovedLabel.Size = new System.Drawing.Size(35, 13);
            this.ProjectToBeRemovedLabel.TabIndex = 3;
            this.ProjectToBeRemovedLabel.Text = "label2";
            // 
            // RemoveProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 151);
            this.Controls.Add(this.ProjectToBeRemovedLabel);
            this.Controls.Add(this.RemoveProjectRemoveButton);
            this.Controls.Add(this.RemoveProjectCancelButton);
            this.Controls.Add(this.label1);
            this.Name = "RemoveProject";
            this.Text = "Remove Project";
            this.Load += new System.EventHandler(this.RemoveProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveProjectCancelButton;
        private System.Windows.Forms.Button RemoveProjectRemoveButton;
        private System.Windows.Forms.Label ProjectToBeRemovedLabel;
    }
}