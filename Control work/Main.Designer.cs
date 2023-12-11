namespace Control_work
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_nextItem = new System.Windows.Forms.Button();
            this.listBox_zakaz = new System.Windows.Forms.ListBox();
            this.comboBox_sort = new System.Windows.Forms.ComboBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_dateCreate = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_save = new System.Windows.Forms.Button();
            this.label_ready = new System.Windows.Forms.Label();
            this.label_saveds = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_cost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_quant = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label_amout = new System.Windows.Forms.Label();
            this.listBox_filters = new System.Windows.Forms.ListBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button_filters = new System.Windows.Forms.Button();
            this.comboBox_filters = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker_filters = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quant)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_nextItem
            // 
            this.button_nextItem.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_nextItem.Location = new System.Drawing.Point(232, 287);
            this.button_nextItem.Name = "button_nextItem";
            this.button_nextItem.Size = new System.Drawing.Size(185, 27);
            this.button_nextItem.TabIndex = 0;
            this.button_nextItem.Text = "Добавити в корзину";
            this.button_nextItem.UseVisualStyleBackColor = true;
            this.button_nextItem.Click += new System.EventHandler(this.button_nextItem_Click);
            // 
            // listBox_zakaz
            // 
            this.listBox_zakaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listBox_zakaz.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_zakaz.FormattingEnabled = true;
            this.listBox_zakaz.ItemHeight = 20;
            this.listBox_zakaz.Location = new System.Drawing.Point(553, 65);
            this.listBox_zakaz.Name = "listBox_zakaz";
            this.listBox_zakaz.Size = new System.Drawing.Size(322, 284);
            this.listBox_zakaz.TabIndex = 1;
            // 
            // comboBox_sort
            // 
            this.comboBox_sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sort.Items.AddRange(new object[] {
            "I",
            "II",
            "III"});
            this.comboBox_sort.Location = new System.Drawing.Point(121, 104);
            this.comboBox_sort.Name = "comboBox_sort";
            this.comboBox_sort.Size = new System.Drawing.Size(128, 28);
            this.comboBox_sort.TabIndex = 2;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(90, 64);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(159, 27);
            this.textBox_name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ім\'я";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Сорт виробу:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(83, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Зробити замовлення";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата виготовлення:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(629, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ваше замовлення";
            // 
            // dateTimePicker_dateCreate
            // 
            this.dateTimePicker_dateCreate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dateCreate.Location = new System.Drawing.Point(176, 138);
            this.dateTimePicker_dateCreate.Name = "dateTimePicker_dateCreate";
            this.dateTimePicker_dateCreate.Size = new System.Drawing.Size(122, 27);
            this.dateTimePicker_dateCreate.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(895, 462);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label_amout);
            this.tabPage1.Controls.Add(this.button_save);
            this.tabPage1.Controls.Add(this.label_ready);
            this.tabPage1.Controls.Add(this.label_saveds);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBox_cost);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.numericUpDown_quant);
            this.tabPage1.Controls.Add(this.listBox_zakaz);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dateTimePicker_dateCreate);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox_name);
            this.tabPage1.Controls.Add(this.button_nextItem);
            this.tabPage1.Controls.Add(this.comboBox_sort);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.ForeColor = System.Drawing.Color.Navy;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(887, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Замовлення";
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.Location = new System.Drawing.Point(48, 287);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(122, 27);
            this.button_save.TabIndex = 18;
            this.button_save.Text = "Зберегти заказ";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_ready
            // 
            this.label_ready.AutoSize = true;
            this.label_ready.Font = new System.Drawing.Font("Segoe Script", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ready.Location = new System.Drawing.Point(292, 253);
            this.label_ready.Name = "label_ready";
            this.label_ready.Size = new System.Drawing.Size(76, 22);
            this.label_ready.TabIndex = 17;
            this.label_ready.Text = "*готово*";
            this.label_ready.Visible = false;
            // 
            // label_saveds
            // 
            this.label_saveds.AutoSize = true;
            this.label_saveds.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_saveds.Location = new System.Drawing.Point(30, 340);
            this.label_saveds.Name = "label_saveds";
            this.label_saveds.Size = new System.Drawing.Size(449, 22);
            this.label_saveds.TabIndex = 16;
            this.label_saveds.Text = "*перейдіть в другу вкладку для підтвердження заказу*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(20, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ціна 1 шт:";
            // 
            // textBox_cost
            // 
            this.textBox_cost.Location = new System.Drawing.Point(121, 220);
            this.textBox_cost.Name = "textBox_cost";
            this.textBox_cost.Size = new System.Drawing.Size(128, 27);
            this.textBox_cost.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Кількість:";
            // 
            // numericUpDown_quant
            // 
            this.numericUpDown_quant.Location = new System.Drawing.Point(121, 182);
            this.numericUpDown_quant.Name = "numericUpDown_quant";
            this.numericUpDown_quant.Size = new System.Drawing.Size(128, 27);
            this.numericUpDown_quant.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.dateTimePicker_filters);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.comboBox_filters);
            this.tabPage2.Controls.Add(this.button_filters);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.button_confirm);
            this.tabPage2.Controls.Add(this.listBox_filters);
            this.tabPage2.ForeColor = System.Drawing.Color.Navy;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(887, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Підтвердження замовлення";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // label_amout
            // 
            this.label_amout.AutoSize = true;
            this.label_amout.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_amout.Location = new System.Drawing.Point(580, 364);
            this.label_amout.Name = "label_amout";
            this.label_amout.Size = new System.Drawing.Size(0, 25);
            this.label_amout.TabIndex = 19;
            // 
            // listBox_filters
            // 
            this.listBox_filters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listBox_filters.FormattingEnabled = true;
            this.listBox_filters.ItemHeight = 20;
            this.listBox_filters.Location = new System.Drawing.Point(25, 21);
            this.listBox_filters.Name = "listBox_filters";
            this.listBox_filters.Size = new System.Drawing.Size(314, 344);
            this.listBox_filters.TabIndex = 0;
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(642, 386);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(215, 30);
            this.button_confirm.TabIndex = 1;
            this.button_confirm.Text = "Підтвердити замовлення";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(487, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 27);
            this.label8.TabIndex = 2;
            this.label8.Text = "Дякуємо за замовлення!";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(430, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Наші контакти:     +38(0**) *** -  ****   detal_info@gmail.com";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(398, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(419, 27);
            this.label10.TabIndex = 4;
            this.label10.Text = "Сподіваємося ви оцінете наше виробництво!";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(345, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(411, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Ви можете переглянути список замовлень за фільтрами:";
            // 
            // button_filters
            // 
            this.button_filters.Location = new System.Drawing.Point(371, 272);
            this.button_filters.Name = "button_filters";
            this.button_filters.Size = new System.Drawing.Size(264, 28);
            this.button_filters.TabIndex = 6;
            this.button_filters.Text = "Вивести результат за фільтрами";
            this.button_filters.UseVisualStyleBackColor = true;
            this.button_filters.Click += new System.EventHandler(this.button_filters_Click);
            // 
            // comboBox_filters
            // 
            this.comboBox_filters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_filters.Items.AddRange(new object[] {
            "I",
            "II",
            "III"});
            this.comboBox_filters.Location = new System.Drawing.Point(474, 170);
            this.comboBox_filters.Name = "comboBox_filters";
            this.comboBox_filters.Size = new System.Drawing.Size(128, 28);
            this.comboBox_filters.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(350, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Сорт виробу:";
            // 
            // dateTimePicker_filters
            // 
            this.dateTimePicker_filters.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_filters.Location = new System.Drawing.Point(522, 217);
            this.dateTimePicker_filters.Name = "dateTimePicker_filters";
            this.dateTimePicker_filters.Size = new System.Drawing.Size(126, 27);
            this.dateTimePicker_filters.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(350, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Дата виготовлення:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(186, 402);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(430, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Наші контакти:     +38(0**) *** -  ****   detal_info@gmail.com";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(367, 327);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 20);
            this.label15.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(892, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Main";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quant)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_nextItem;
        private System.Windows.Forms.ListBox listBox_zakaz;
        private System.Windows.Forms.ComboBox comboBox_sort;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateCreate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_quant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_cost;
        private System.Windows.Forms.Label label_saveds;
        private System.Windows.Forms.Label label_ready;
        private System.Windows.Forms.Timer timer_ready;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_amout;
        private System.Windows.Forms.ListBox listBox_filters;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_filters;
        private System.Windows.Forms.ComboBox comboBox_filters;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker_filters;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

