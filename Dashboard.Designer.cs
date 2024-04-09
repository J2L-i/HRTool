namespace HRTool
{
    partial class Dashboard
    {
       
        private System.ComponentModel.IContainer components = null;

      
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EmployeesListView = new System.Windows.Forms.ListView();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.RolesComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.OffTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.RequestButton = new System.Windows.Forms.Button();
            this.EmpNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ViewHierarchyButton = new System.Windows.Forms.Button();
            this.HierarchyTextBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ProcessRequestsButton = new System.Windows.Forms.Button();
            this.OffRequestsListView = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(44, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(944, 471);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.EmployeesListView);
            this.tabPage1.Controls.Add(this.AddEmployeeButton);
            this.tabPage1.Controls.Add(this.RolesComboBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.NameTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(936, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Register Employee";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // EmployeesListView
            // 
            this.EmployeesListView.HideSelection = false;
            this.EmployeesListView.Location = new System.Drawing.Point(27, 210);
            this.EmployeesListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmployeesListView.Name = "EmployeesListView";
            this.EmployeesListView.Size = new System.Drawing.Size(887, 221);
            this.EmployeesListView.TabIndex = 5;
            this.EmployeesListView.UseCompatibleStateImageBehavior = false;
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(544, 47);
            this.AddEmployeeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(163, 36);
            this.AddEmployeeButton.TabIndex = 4;
            this.AddEmployeeButton.Text = "Add";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // RolesComboBox
            // 
            this.RolesComboBox.FormattingEnabled = true;
            this.RolesComboBox.Location = new System.Drawing.Point(93, 110);
            this.RolesComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RolesComboBox.Name = "RolesComboBox";
            this.RolesComboBox.Size = new System.Drawing.Size(192, 24);
            this.RolesComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Role";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(93, 47);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(303, 22);
            this.NameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.OffTypeComboBox);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.EndDateTimePicker);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.StartDateTimePicker);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.RequestButton);
            this.tabPage2.Controls.Add(this.EmpNameTextBox);
            this.tabPage2.Controls.Add(this.EmployeeIdTextBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(936, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Request Off";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // OffTypeComboBox
            // 
            this.OffTypeComboBox.FormattingEnabled = true;
            this.OffTypeComboBox.Location = new System.Drawing.Point(119, 246);
            this.OffTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OffTypeComboBox.Name = "OffTypeComboBox";
            this.OffTypeComboBox.Size = new System.Drawing.Size(257, 24);
            this.OffTypeComboBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 250);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Off Type";
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Location = new System.Drawing.Point(119, 172);
            this.EndDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(257, 22);
            this.EndDateTimePicker.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "End Date";
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Location = new System.Drawing.Point(119, 108);
            this.StartDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(257, 22);
            this.StartDateTimePicker.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Start Date";
            // 
            // RequestButton
            // 
            this.RequestButton.Location = new System.Drawing.Point(12, 327);
            this.RequestButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RequestButton.Name = "RequestButton";
            this.RequestButton.Size = new System.Drawing.Size(107, 37);
            this.RequestButton.TabIndex = 5;
            this.RequestButton.Text = "Request";
            this.RequestButton.UseVisualStyleBackColor = true;
            this.RequestButton.Click += new System.EventHandler(this.RequestButton_Click);
            // 
            // EmpNameTextBox
            // 
            this.EmpNameTextBox.Location = new System.Drawing.Point(272, 34);
            this.EmpNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpNameTextBox.Name = "EmpNameTextBox";
            this.EmpNameTextBox.Size = new System.Drawing.Size(381, 22);
            this.EmpNameTextBox.TabIndex = 2;
            // 
            // EmployeeIdTextBox
            // 
            this.EmployeeIdTextBox.Location = new System.Drawing.Point(119, 34);
            this.EmployeeIdTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmployeeIdTextBox.Name = "EmployeeIdTextBox";
            this.EmployeeIdTextBox.Size = new System.Drawing.Size(111, 22);
            this.EmployeeIdTextBox.TabIndex = 1;
            this.EmployeeIdTextBox.TextChanged += new System.EventHandler(this.EmployeeIdTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Employee Id";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ViewHierarchyButton);
            this.tabPage3.Controls.Add(this.HierarchyTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(936, 442);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Personnel Hierarchy";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ViewHierarchyButton
            // 
            this.ViewHierarchyButton.Location = new System.Drawing.Point(97, 375);
            this.ViewHierarchyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewHierarchyButton.Name = "ViewHierarchyButton";
            this.ViewHierarchyButton.Size = new System.Drawing.Size(161, 46);
            this.ViewHierarchyButton.TabIndex = 1;
            this.ViewHierarchyButton.Text = "View Hierarchy";
            this.ViewHierarchyButton.UseVisualStyleBackColor = true;
            this.ViewHierarchyButton.Click += new System.EventHandler(this.ViewHierarchyButton_Click);
            // 
            // HierarchyTextBox
            // 
            this.HierarchyTextBox.Location = new System.Drawing.Point(97, 42);
            this.HierarchyTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HierarchyTextBox.Multiline = true;
            this.HierarchyTextBox.Name = "HierarchyTextBox";
            this.HierarchyTextBox.Size = new System.Drawing.Size(673, 325);
            this.HierarchyTextBox.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ProcessRequestsButton);
            this.tabPage4.Controls.Add(this.OffRequestsListView);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Size = new System.Drawing.Size(936, 442);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Time-Off Requests";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ProcessRequestsButton
            // 
            this.ProcessRequestsButton.Location = new System.Drawing.Point(375, 377);
            this.ProcessRequestsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessRequestsButton.Name = "ProcessRequestsButton";
            this.ProcessRequestsButton.Size = new System.Drawing.Size(156, 46);
            this.ProcessRequestsButton.TabIndex = 1;
            this.ProcessRequestsButton.Text = "Process Requests";
            this.ProcessRequestsButton.UseVisualStyleBackColor = true;
            this.ProcessRequestsButton.Click += new System.EventHandler(this.ProcessRequestsButton_Click);
            // 
            // OffRequestsListView
            // 
            this.OffRequestsListView.HideSelection = false;
            this.OffRequestsListView.Location = new System.Drawing.Point(21, 26);
            this.OffRequestsListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OffRequestsListView.Name = "OffRequestsListView";
            this.OffRequestsListView.Size = new System.Drawing.Size(885, 334);
            this.OffRequestsListView.TabIndex = 0;
            this.OffRequestsListView.UseCompatibleStateImageBehavior = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 498);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RolesComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.ListView EmployeesListView;
        private System.Windows.Forms.TextBox EmployeeIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmpNameTextBox;
        private System.Windows.Forms.Button RequestButton;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox OffTypeComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox HierarchyTextBox;
        private System.Windows.Forms.Button ViewHierarchyButton;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView OffRequestsListView;
        private System.Windows.Forms.Button ProcessRequestsButton;
    }
}

