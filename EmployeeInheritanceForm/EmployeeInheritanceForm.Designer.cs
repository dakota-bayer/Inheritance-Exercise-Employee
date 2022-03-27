
namespace EmployeeInheritanceForm
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
            this.lblAverageGrossPay = new System.Windows.Forms.Label();
            this.lblTotalGrossPay = new System.Windows.Forms.Label();
            this.lblNumEmployees = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAverageGrossPay
            // 
            this.lblAverageGrossPay.AutoSize = true;
            this.lblAverageGrossPay.Location = new System.Drawing.Point(447, 118);
            this.lblAverageGrossPay.Name = "lblAverageGrossPay";
            this.lblAverageGrossPay.Size = new System.Drawing.Size(102, 13);
            this.lblAverageGrossPay.TabIndex = 13;
            this.lblAverageGrossPay.Text = "lblAverageGrossPay";
            // 
            // lblTotalGrossPay
            // 
            this.lblTotalGrossPay.AutoSize = true;
            this.lblTotalGrossPay.Location = new System.Drawing.Point(447, 79);
            this.lblTotalGrossPay.Name = "lblTotalGrossPay";
            this.lblTotalGrossPay.Size = new System.Drawing.Size(86, 13);
            this.lblTotalGrossPay.TabIndex = 12;
            this.lblTotalGrossPay.Text = "lblTotalGrossPay";
            // 
            // lblNumEmployees
            // 
            this.lblNumEmployees.AutoSize = true;
            this.lblNumEmployees.Location = new System.Drawing.Point(447, 39);
            this.lblNumEmployees.Name = "lblNumEmployees";
            this.lblNumEmployees.Size = new System.Drawing.Size(90, 13);
            this.lblNumEmployees.TabIndex = 11;
            this.lblNumEmployees.Text = "lblNumEmployees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "# Employees:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total Gross Pay:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Average Gross Pay:";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(39, 39);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(49, 13);
            this.lblDetails.TabIndex = 7;
            this.lblDetails.Text = "lblDetails";
            // 
            // EmployeeInheritanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 173);
            this.Controls.Add(this.lblAverageGrossPay);
            this.Controls.Add(this.lblTotalGrossPay);
            this.Controls.Add(this.lblNumEmployees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDetails);
            this.Name = "EmployeeInheritanceForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAverageGrossPay;
        private System.Windows.Forms.Label lblTotalGrossPay;
        private System.Windows.Forms.Label lblNumEmployees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDetails;
    }
}

