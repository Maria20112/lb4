namespace Lb2
{
    partial class FormContainerLb2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            create_err = new Label();
            height = new TextBox();
            country = new TextBox();
            city = new TextBox();
            year_of_birth = new NumericUpDown();
            surname = new TextBox();
            name = new TextBox();
            addButton = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            woman = new RadioButton();
            man = new RadioButton();
            panel2 = new Panel();
            label1 = new Label();
            label12 = new Label();
            number = new NumericUpDown();
            panel3 = new Panel();
            data = new Label();
            deleteButton = new Button();
            groupBox2 = new GroupBox();
            showTable = new DataGridView();
            groupBox3 = new GroupBox();
            startTestingButton = new Button();
            testingTable = new ListView();
            addition = new ColumnHeader();
            sequentialChoice = new ColumnHeader();
            randomChoice = new ColumnHeader();
            cloneButton = new Button();
            ((System.ComponentModel.ISupportInitialize)year_of_birth).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)number).BeginInit();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)showTable).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // create_err
            // 
            create_err.AutoSize = true;
            create_err.Location = new Point(9, 383);
            create_err.Name = "create_err";
            create_err.Size = new Size(0, 20);
            create_err.TabIndex = 59;
            // 
            // height
            // 
            height.Location = new Point(88, 298);
            height.Name = "height";
            height.Size = new Size(125, 27);
            height.TabIndex = 58;
            // 
            // country
            // 
            country.Location = new Point(88, 265);
            country.Name = "country";
            country.Size = new Size(125, 27);
            country.TabIndex = 57;
            // 
            // city
            // 
            city.Location = new Point(88, 232);
            city.Name = "city";
            city.Size = new Size(125, 27);
            city.TabIndex = 56;
            // 
            // year_of_birth
            // 
            year_of_birth.Location = new Point(123, 199);
            year_of_birth.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            year_of_birth.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            year_of_birth.Name = "year_of_birth";
            year_of_birth.Size = new Size(150, 27);
            year_of_birth.TabIndex = 55;
            year_of_birth.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // surname
            // 
            surname.Location = new Point(88, 81);
            surname.Name = "surname";
            surname.Size = new Size(125, 27);
            surname.TabIndex = 52;
            // 
            // name
            // 
            name.Location = new Point(88, 48);
            name.Name = "name";
            name.Size = new Size(125, 27);
            name.TabIndex = 51;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addButton.Location = new Point(88, 331);
            addButton.Name = "addButton";
            addButton.Size = new Size(125, 48);
            addButton.TabIndex = 50;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 301);
            label11.Name = "label11";
            label11.Size = new Size(39, 20);
            label11.TabIndex = 49;
            label11.Text = "Рост";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 268);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 48;
            label10.Text = "Страна";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 238);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 47;
            label9.Text = "Город";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 201);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 46;
            label8.Text = "Год рождения";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 84);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 44;
            label6.Text = "Фамилия";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 51);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 43;
            label5.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(64, 12);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 42;
            label2.Text = "Добавление объекта";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(create_err);
            panel1.Controls.Add(height);
            panel1.Controls.Add(country);
            panel1.Controls.Add(city);
            panel1.Controls.Add(year_of_birth);
            panel1.Controls.Add(surname);
            panel1.Controls.Add(name);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 438);
            panel1.TabIndex = 60;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(woman);
            groupBox1.Controls.Add(man);
            groupBox1.Location = new Point(3, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 79);
            groupBox1.TabIndex = 60;
            groupBox1.TabStop = false;
            groupBox1.Text = "Пол";
            // 
            // woman
            // 
            woman.AutoSize = true;
            woman.Location = new Point(88, 44);
            woman.Name = "woman";
            woman.Size = new Size(90, 24);
            woman.TabIndex = 54;
            woman.Text = "женский";
            woman.UseVisualStyleBackColor = true;
            // 
            // man
            // 
            man.AutoSize = true;
            man.Checked = true;
            man.Location = new Point(88, 14);
            man.Name = "man";
            man.Size = new Size(91, 24);
            man.TabIndex = 53;
            man.TabStop = true;
            man.Text = "мужской";
            man.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(1059, 91);
            panel2.TabIndex = 61;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(417, 18);
            label1.Name = "label1";
            label1.Size = new Size(226, 60);
            label1.TabIndex = 62;
            label1.Text = "Лабораторная работа №2 \r\n23ВП1\r\nБояринова М.Г., Бычкова Н.Р.\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(83, 3);
            label12.Name = "label12";
            label12.Size = new Size(119, 20);
            label12.TabIndex = 64;
            label12.Text = "Введите номер ";
            // 
            // number
            // 
            number.Location = new Point(70, 26);
            number.Name = "number";
            number.Size = new Size(150, 27);
            number.TabIndex = 63;
            // 
            // panel3
            // 
            panel3.Controls.Add(cloneButton);
            panel3.Controls.Add(data);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(deleteButton);
            panel3.Controls.Add(number);
            panel3.Location = new Point(12, 575);
            panel3.Name = "panel3";
            panel3.Size = new Size(291, 165);
            panel3.TabIndex = 65;
            // 
            // data
            // 
            data.AutoSize = true;
            data.Location = new Point(28, 124);
            data.Name = "data";
            data.Size = new Size(0, 20);
            data.TabIndex = 67;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deleteButton.Location = new Point(28, 59);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(235, 29);
            deleteButton.TabIndex = 66;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(showTable);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(324, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(747, 451);
            groupBox2.TabIndex = 66;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод всех элементов коллекции";
            // 
            // showTable
            // 
            showTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            showTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            showTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            showTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            showTable.Location = new Point(17, 26);
            showTable.Name = "showTable";
            showTable.RowHeadersWidth = 51;
            showTable.Size = new Size(713, 412);
            showTable.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(startTestingButton);
            groupBox3.Controls.Add(testingTable);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox3.Location = new Point(325, 575);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(746, 165);
            groupBox3.TabIndex = 67;
            groupBox3.TabStop = false;
            groupBox3.Text = "Тестирование производительности";
            // 
            // startTestingButton
            // 
            startTestingButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            startTestingButton.Location = new Point(16, 23);
            startTestingButton.Name = "startTestingButton";
            startTestingButton.Size = new Size(95, 134);
            startTestingButton.TabIndex = 1;
            startTestingButton.Text = "Начать";
            startTestingButton.UseVisualStyleBackColor = true;
            startTestingButton.Click += startTestingButton_Click;
            // 
            // testingTable
            // 
            testingTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            testingTable.Columns.AddRange(new ColumnHeader[] { addition, sequentialChoice, randomChoice });
            testingTable.Location = new Point(117, 23);
            testingTable.Name = "testingTable";
            testingTable.Size = new Size(612, 134);
            testingTable.TabIndex = 0;
            testingTable.UseCompatibleStateImageBehavior = false;
            testingTable.View = View.Details;
            // 
            // addition
            // 
            addition.Text = "Добавление";
            // 
            // sequentialChoice
            // 
            sequentialChoice.Text = "Последовательный выбор";
            // 
            // randomChoice
            // 
            randomChoice.Text = "Случайный выбор";
            // 
            // cloneButton
            // 
            cloneButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cloneButton.Location = new Point(28, 87);
            cloneButton.Name = "cloneButton";
            cloneButton.Size = new Size(235, 29);
            cloneButton.TabIndex = 68;
            cloneButton.Text = "Клонировать";
            cloneButton.UseVisualStyleBackColor = true;
            cloneButton.Click += cloneButton_Click;
            // 
            // FormContainerLb2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 752);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(350, 799);
            Name = "FormContainerLb2";
            Text = "Lb2";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)year_of_birth).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)number).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)showTable).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label create_err;
        private TextBox height;
        private TextBox country;
        private TextBox city;
        private NumericUpDown year_of_birth;
        private TextBox surname;
        private TextBox name;
        private Button addButton;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label2;
        private Panel panel1;
        private GroupBox groupBox1;
        private RadioButton woman;
        private RadioButton man;
        private Panel panel2;
        private Label label1;
        private Label label12;
        private NumericUpDown number;
        private Panel panel3;
        private Label data;
        private Button deleteButton;
        private GroupBox groupBox2;
        private DataGridView showTable;
        private GroupBox groupBox3;
        private ListView testingTable;
        private Button startTestingButton;
        private ColumnHeader addition;
        private ColumnHeader sequentialChoice;
        private ColumnHeader randomChoice;
        private Button cloneButton;
    }
}
