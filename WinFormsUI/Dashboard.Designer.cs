namespace WinFormsUI
{
    partial class Dashboard
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
            calculateSection = new GroupBox();
            result = new TextBox();
            divide = new Button();
            multiply = new Button();
            subtract = new Button();
            add = new Button();
            label2 = new Label();
            label1 = new Label();
            secondNumber = new NumericUpDown();
            firstNumber = new NumericUpDown();
            databaseSection = new GroupBox();
            addPerson = new Button();
            lastName = new TextBox();
            firstName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            users = new ComboBox();
            calculateSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)secondNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)firstNumber).BeginInit();
            databaseSection.SuspendLayout();
            SuspendLayout();
            // 
            // calculateSection
            // 
            calculateSection.Controls.Add(result);
            calculateSection.Controls.Add(divide);
            calculateSection.Controls.Add(multiply);
            calculateSection.Controls.Add(subtract);
            calculateSection.Controls.Add(add);
            calculateSection.Controls.Add(label2);
            calculateSection.Controls.Add(label1);
            calculateSection.Controls.Add(secondNumber);
            calculateSection.Controls.Add(firstNumber);
            calculateSection.Location = new Point(19, 43);
            calculateSection.Name = "calculateSection";
            calculateSection.Size = new Size(368, 298);
            calculateSection.TabIndex = 0;
            calculateSection.TabStop = false;
            calculateSection.Text = "Calculate Section";
            // 
            // result
            // 
            result.Location = new Point(194, 186);
            result.Name = "result";
            result.Size = new Size(150, 27);
            result.TabIndex = 8;
            // 
            // divide
            // 
            divide.Location = new Point(15, 247);
            divide.Name = "divide";
            divide.Size = new Size(135, 29);
            divide.TabIndex = 7;
            divide.Text = "Divide";
            divide.UseVisualStyleBackColor = true;
            divide.Click += divide_Click;
            // 
            // multiply
            // 
            multiply.Location = new Point(15, 209);
            multiply.Name = "multiply";
            multiply.Size = new Size(135, 29);
            multiply.TabIndex = 6;
            multiply.Text = "Multiply";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += multiply_Click;
            // 
            // subtract
            // 
            subtract.Location = new Point(15, 172);
            subtract.Name = "subtract";
            subtract.Size = new Size(135, 29);
            subtract.TabIndex = 5;
            subtract.Text = "Subtract";
            subtract.UseVisualStyleBackColor = true;
            subtract.Click += subtract_Click;
            // 
            // add
            // 
            add.Location = new Point(15, 135);
            add.Name = "add";
            add.Size = new Size(135, 29);
            add.TabIndex = 4;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 88);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 3;
            label2.Text = "Second Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 42);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 2;
            label1.Text = "First Number";
            // 
            // secondNumber
            // 
            secondNumber.Location = new Point(194, 81);
            secondNumber.Name = "secondNumber";
            secondNumber.Size = new Size(150, 27);
            secondNumber.TabIndex = 1;
            // 
            // firstNumber
            // 
            firstNumber.Location = new Point(194, 35);
            firstNumber.Name = "firstNumber";
            firstNumber.Size = new Size(151, 27);
            firstNumber.TabIndex = 0;
            // 
            // databaseSection
            // 
            databaseSection.Controls.Add(addPerson);
            databaseSection.Controls.Add(lastName);
            databaseSection.Controls.Add(firstName);
            databaseSection.Controls.Add(label5);
            databaseSection.Controls.Add(label4);
            databaseSection.Controls.Add(label3);
            databaseSection.Controls.Add(users);
            databaseSection.Location = new Point(412, 43);
            databaseSection.Name = "databaseSection";
            databaseSection.Size = new Size(394, 298);
            databaseSection.TabIndex = 1;
            databaseSection.TabStop = false;
            databaseSection.Text = "Database Section";
            // 
            // addPerson
            // 
            addPerson.Location = new Point(64, 200);
            addPerson.Name = "addPerson";
            addPerson.Size = new Size(212, 29);
            addPerson.TabIndex = 6;
            addPerson.Text = "Add Person";
            addPerson.UseVisualStyleBackColor = true;
            addPerson.Click += addPerson_Click;
            // 
            // lastName
            // 
            lastName.Location = new Point(129, 144);
            lastName.Name = "lastName";
            lastName.Size = new Size(234, 27);
            lastName.TabIndex = 5;
            // 
            // firstName
            // 
            firstName.Location = new Point(129, 108);
            firstName.Name = "firstName";
            firstName.Size = new Size(234, 27);
            firstName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 144);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 3;
            label5.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 108);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 2;
            label4.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 50);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 1;
            label3.Text = "Users";
            // 
            // users
            // 
            users.FormattingEnabled = true;
            users.Location = new Point(129, 50);
            users.Name = "users";
            users.Size = new Size(234, 28);
            users.TabIndex = 0;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 390);
            Controls.Add(databaseSection);
            Controls.Add(calculateSection);
            Name = "Dashboard";
            Text = "Demo Dashboard by Mathews";
            Load += Dashboard_Load;
            calculateSection.ResumeLayout(false);
            calculateSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)secondNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)firstNumber).EndInit();
            databaseSection.ResumeLayout(false);
            databaseSection.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox calculateSection;
        private Label label1;
        private NumericUpDown secondNumber;
        private NumericUpDown firstNumber;
        private Button subtract;
        private Button add;
        private Label label2;
        private TextBox result;
        private Button divide;
        private Button multiply;
        private GroupBox databaseSection;
        private Label label3;
        private ComboBox users;
        private Button addPerson;
        private TextBox lastName;
        private TextBox firstName;
        private Label label5;
        private Label label4;
    }
}