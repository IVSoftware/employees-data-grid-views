namespace KURSACH
{
    partial class AddEmployeeForm
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
            tableLayoutPanel = new TableLayoutPanel();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            maskedTextBoxSalary = new MaskedTextBox();
            textBoxPosition = new TextBox();
            maskedTextBoxAge = new MaskedTextBox();
            labelAge = new Label();
            labelSalary = new Label();
            buttonCancel = new Button();
            buttonOK = new Button();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 304F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Controls.Add(textBoxName, 0, 0);
            tableLayoutPanel.Controls.Add(textBoxSurname, 0, 1);
            tableLayoutPanel.Controls.Add(maskedTextBoxAge, 1, 2);
            tableLayoutPanel.Controls.Add(maskedTextBoxSalary, 1, 3);
            tableLayoutPanel.Controls.Add(textBoxPosition, 0, 4);
            tableLayoutPanel.Controls.Add(labelAge, 0, 2);
            tableLayoutPanel.Controls.Add(labelSalary, 0, 3);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(10, 10);
            tableLayoutPanel.Margin = new Padding(0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 6;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.Size = new Size(468, 254);
            tableLayoutPanel.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.SetColumnSpan(textBoxName, 2);
            textBoxName.Font = new Font("Segoe UI", 12F);
            textBoxName.Location = new Point(3, 45);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Name";
            textBoxName.Size = new Size(462, 39);
            textBoxName.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.SetColumnSpan(textBoxSurname, 2);
            textBoxSurname.Font = new Font("Segoe UI", 12F);
            textBoxSurname.Location = new Point(3, 87);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.PlaceholderText = "Surname";
            textBoxSurname.Size = new Size(462, 39);
            textBoxSurname.TabIndex = 2;
            // 
            // maskedTextBoxSalary
            // 
            maskedTextBoxSalary.Font = new Font("Segoe UI", 12F);
            maskedTextBoxSalary.Location = new Point(167, 171);
            maskedTextBoxSalary.Name = "maskedTextBoxSalary";
            maskedTextBoxSalary.Size = new Size(160, 39);
            maskedTextBoxSalary.TabIndex = 4;
            // 
            // textBoxPosition
            // 
            textBoxPosition.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.SetColumnSpan(textBoxPosition, 2);
            textBoxPosition.Font = new Font("Segoe UI", 12F);
            textBoxPosition.Location = new Point(3, 213);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.PlaceholderText = "Position";
            textBoxPosition.Size = new Size(462, 39);
            textBoxPosition.TabIndex = 5;
            // 
            // maskedTextBoxAge
            // 
            maskedTextBoxAge.Font = new Font("Segoe UI", 12F);
            maskedTextBoxAge.Location = new Point(167, 129);
            maskedTextBoxAge.Name = "maskedTextBoxAge";
            maskedTextBoxAge.Size = new Size(160, 39);
            maskedTextBoxAge.TabIndex = 3;
            // 
            // labelAge
            // 
            labelAge.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAge.AutoSize = true;
            labelAge.Location = new Point(3, 126);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(158, 42);
            labelAge.TabIndex = 6;
            labelAge.Text = "Age";
            labelAge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSalary
            // 
            labelSalary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelSalary.AutoSize = true;
            labelSalary.Location = new Point(3, 168);
            labelSalary.Name = "labelSalary";
            labelSalary.Size = new Size(158, 42);
            labelSalary.TabIndex = 6;
            labelSalary.Text = "Salary";
            labelSalary.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(204, 290);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 1;
            buttonCancel.TabStop = false;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(337, 290);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(112, 34);
            buttonOK.TabIndex = 0;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            // 
            // AddEmployeeForm
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(478, 344);
            Controls.Add(buttonOK);
            Controls.Add(buttonCancel);
            Controls.Add(tableLayoutPanel);
            Name = "AddEmployeeForm";
            Padding = new Padding(10, 10, 0, 80);
            Text = "Add Employee";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private MaskedTextBox maskedTextBoxSalary;
        private TextBox textBoxPosition;
        private MaskedTextBox maskedTextBoxAge;
        private Button buttonCancel;
        private Button buttonOK;
        private Label labelAge;
        private Label labelSalary;
    }
}