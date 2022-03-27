
namespace Inheritance_Exercise___Employee
{
    partial class EmployeeInheritanceForm
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
            this.lblDetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumEmployees = new System.Windows.Forms.Label();
            this.lblTotalGrossPay = new System.Windows.Forms.Label();
            this.lblAverageGrossPay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(50, 44);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(49, 13);
            this.lblDetails.TabIndex = 0;
            this.lblDetails.Text = "lblDetails";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Average Gross Pay:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Gross Pay:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "# Employees:";
            // 
            // lblNumEmployees
            // 
            this.lblNumEmployees.AutoSize = true;
            this.lblNumEmployees.Location = new System.Drawing.Point(343, 44);
            this.lblNumEmployees.Name = "lblNumEmployees";
            this.lblNumEmployees.Size = new System.Drawing.Size(90, 13);
            this.lblNumEmployees.TabIndex = 4;
            this.lblNumEmployees.Text = "lblNumEmployees";
            // 
            // lblTotalGrossPay
            // 
            this.lblTotalGrossPay.AutoSize = true;
            this.lblTotalGrossPay.Location = new System.Drawing.Point(343, 84);
            this.lblTotalGrossPay.Name = "lblTotalGrossPay";
            this.lblTotalGrossPay.Size = new System.Drawing.Size(86, 13);
            this.lblTotalGrossPay.TabIndex = 5;
            this.lblTotalGrossPay.Text = "lblTotalGrossPay";
            // 
            // lblAverageGrossPay
            // 
            this.lblAverageGrossPay.AutoSize = true;
            this.lblAverageGrossPay.Location = new System.Drawing.Point(343, 123);
            this.lblAverageGrossPay.Name = "lblAverageGrossPay";
            this.lblAverageGrossPay.Size = new System.Drawing.Size(102, 13);
            this.lblAverageGrossPay.TabIndex = 6;
            this.lblAverageGrossPay.Text = "lblAverageGrossPay";
            // 
            // EmployeeInheritanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 193);
            this.Controls.Add(this.lblAverageGrossPay);
            this.Controls.Add(this.lblTotalGrossPay);
            this.Controls.Add(this.lblNumEmployees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDetails);
            this.Name = "EmployeeInheritanceForm";
            this.Text = "EmployeeInheritanceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumEmployees;
        private System.Windows.Forms.Label lblTotalGrossPay;
        private System.Windows.Forms.Label lblAverageGrossPay;
    }
}