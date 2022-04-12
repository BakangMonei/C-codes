
namespace Stem_Assignment
{
    partial class CustomerRegistration
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstnameTextBox1 = new System.Windows.Forms.TextBox();
            this.surnameTextBox2 = new System.Windows.Forms.TextBox();
            this.customerNumberTextBox3 = new System.Windows.Forms.TextBox();
            this.registerCustomerBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CustomerNumber";
            // 
            // firstnameTextBox1
            // 
            this.firstnameTextBox1.Location = new System.Drawing.Point(300, 73);
            this.firstnameTextBox1.Name = "firstnameTextBox1";
            this.firstnameTextBox1.Size = new System.Drawing.Size(100, 20);
            this.firstnameTextBox1.TabIndex = 4;
            // 
            // surnameTextBox2
            // 
            this.surnameTextBox2.Location = new System.Drawing.Point(300, 108);
            this.surnameTextBox2.Name = "surnameTextBox2";
            this.surnameTextBox2.Size = new System.Drawing.Size(100, 20);
            this.surnameTextBox2.TabIndex = 5;
            // 
            // customerNumberTextBox3
            // 
            this.customerNumberTextBox3.Location = new System.Drawing.Point(300, 143);
            this.customerNumberTextBox3.Name = "customerNumberTextBox3";
            this.customerNumberTextBox3.Size = new System.Drawing.Size(100, 20);
            this.customerNumberTextBox3.TabIndex = 6;
            // 
            // registerCustomerBtn
            // 
            this.registerCustomerBtn.Location = new System.Drawing.Point(228, 253);
            this.registerCustomerBtn.Name = "registerCustomerBtn";
            this.registerCustomerBtn.Size = new System.Drawing.Size(112, 23);
            this.registerCustomerBtn.TabIndex = 8;
            this.registerCustomerBtn.Text = "RegisterCustomer";
            this.registerCustomerBtn.UseVisualStyleBackColor = true;
            this.registerCustomerBtn.Click += new System.EventHandler(this.registerCustomerBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Return to main menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.registerCustomerBtn);
            this.Controls.Add(this.customerNumberTextBox3);
            this.Controls.Add(this.surnameTextBox2);
            this.Controls.Add(this.firstnameTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerRegistration";
            this.Text = "CustomerRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstnameTextBox1;
        private System.Windows.Forms.TextBox surnameTextBox2;
        private System.Windows.Forms.TextBox customerNumberTextBox3;
        private System.Windows.Forms.Button registerCustomerBtn;
        private System.Windows.Forms.Button button1;
    }
}