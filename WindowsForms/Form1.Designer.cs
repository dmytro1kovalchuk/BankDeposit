using System.Drawing;

namespace WindowsForms
{
    partial class Form1
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
            this.name_label = new System.Windows.Forms.Label();
            this.type_label = new System.Windows.Forms.Label();
            this.percent_label = new System.Windows.Forms.Label();
            this.deposit_label = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.percent_textbox = new System.Windows.Forms.TextBox();
            this.balance_textbox = new System.Windows.Forms.TextBox();
            this.type_combobox = new System.Windows.Forms.ComboBox();
            this.age_label = new System.Windows.Forms.Label();
            this.monthtime_label = new System.Windows.Forms.Label();
            this.age_textbox = new System.Windows.Forms.TextBox();
            this.monthtime_textbox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Result_Label = new System.Windows.Forms.Label();
            this.penalty_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AgeRetire_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currency_textbox = new System.Windows.Forms.TextBox();
            this.nameDeposit_textBox = new System.Windows.Forms.TextBox();
            this.namedeposit_label = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.currencyRate_textbox = new System.Windows.Forms.TextBox();
            this.CurrencyRate = new System.Windows.Forms.Label();
            this.Currency = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.deposit2_label = new System.Windows.Forms.Label();
            this.withdraw_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Deposit_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NameDeposit_combobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.withdraw_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WithdrawDeposit_combobox = new System.Windows.Forms.ComboBox();
            this.Deposit_button = new System.Windows.Forms.Button();
            this.Withdraw_button = new System.Windows.Forms.Button();
            this.resault_deletion = new System.Windows.Forms.Label();
            this.result_calculation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.month_textBox = new System.Windows.Forms.TextBox();
            this.Name_combobox = new System.Windows.Forms.ComboBox();
            this.calculate_button = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.summary_label = new System.Windows.Forms.Label();
            this.showOwner_button = new System.Windows.Forms.Button();
            this.owner_combo = new System.Windows.Forms.ComboBox();
            this.ShowAll_button = new System.Windows.Forms.Button();
            this.alldepos_label = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_label.Location = new System.Drawing.Point(6, 14);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(66, 33);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "Ім\'я";
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_label.Location = new System.Drawing.Point(3, 165);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(197, 33);
            this.type_label.TabIndex = 2;
            this.type_label.Text = "Тип депозиту";
            // 
            // percent_label
            // 
            this.percent_label.AutoSize = true;
            this.percent_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percent_label.Location = new System.Drawing.Point(3, 351);
            this.percent_label.Name = "percent_label";
            this.percent_label.Size = new System.Drawing.Size(260, 33);
            this.percent_label.TabIndex = 3;
            this.percent_label.Text = "Процентна ставка";
            // 
            // deposit_label
            // 
            this.deposit_label.AutoSize = true;
            this.deposit_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deposit_label.Location = new System.Drawing.Point(3, 261);
            this.deposit_label.Name = "deposit_label";
            this.deposit_label.Size = new System.Drawing.Size(246, 33);
            this.deposit_label.TabIndex = 4;
            this.deposit_label.Text = "Баланс депозиту";
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_textbox.Location = new System.Drawing.Point(321, 11);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(382, 40);
            this.name_textbox.TabIndex = 5;
            // 
            // percent_textbox
            // 
            this.percent_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percent_textbox.Location = new System.Drawing.Point(321, 344);
            this.percent_textbox.Name = "percent_textbox";
            this.percent_textbox.Size = new System.Drawing.Size(382, 40);
            this.percent_textbox.TabIndex = 6;
            // 
            // balance_textbox
            // 
            this.balance_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balance_textbox.Location = new System.Drawing.Point(321, 258);
            this.balance_textbox.Name = "balance_textbox";
            this.balance_textbox.Size = new System.Drawing.Size(382, 40);
            this.balance_textbox.TabIndex = 7;
            // 
            // type_combobox
            // 
            this.type_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_combobox.FormattingEnabled = true;
            this.type_combobox.Items.AddRange(new object[] {
            "Строковий депозит",
            "Заощаджувальний депозит",
            "Валютний депозит",
            "Капіталізований депозит",
            "Пенсійний депозит",
            "Достроковий депозит"});
            this.type_combobox.Location = new System.Drawing.Point(321, 162);
            this.type_combobox.Name = "type_combobox";
            this.type_combobox.Size = new System.Drawing.Size(382, 41);
            this.type_combobox.TabIndex = 8;
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age_label.Location = new System.Drawing.Point(3, 516);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(142, 33);
            this.age_label.TabIndex = 9;
            this.age_label.Text = "Вік зараз";
            // 
            // monthtime_label
            // 
            this.monthtime_label.AutoSize = true;
            this.monthtime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthtime_label.Location = new System.Drawing.Point(3, 435);
            this.monthtime_label.Name = "monthtime_label";
            this.monthtime_label.Size = new System.Drawing.Size(199, 33);
            this.monthtime_label.TabIndex = 10;
            this.monthtime_label.Text = "Строк вкладу";
            // 
            // age_textbox
            // 
            this.age_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age_textbox.Location = new System.Drawing.Point(321, 509);
            this.age_textbox.Name = "age_textbox";
            this.age_textbox.Size = new System.Drawing.Size(382, 40);
            this.age_textbox.TabIndex = 11;
            // 
            // monthtime_textbox
            // 
            this.monthtime_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthtime_textbox.Location = new System.Drawing.Point(321, 435);
            this.monthtime_textbox.Name = "monthtime_textbox";
            this.monthtime_textbox.Size = new System.Drawing.Size(382, 40);
            this.monthtime_textbox.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1867, 1048);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Result_Label);
            this.tabPage1.Controls.Add(this.penalty_textbox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.AgeRetire_textBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.currency_textbox);
            this.tabPage1.Controls.Add(this.nameDeposit_textBox);
            this.tabPage1.Controls.Add(this.namedeposit_label);
            this.tabPage1.Controls.Add(this.add_button);
            this.tabPage1.Controls.Add(this.currencyRate_textbox);
            this.tabPage1.Controls.Add(this.CurrencyRate);
            this.tabPage1.Controls.Add(this.Currency);
            this.tabPage1.Controls.Add(this.name_label);
            this.tabPage1.Controls.Add(this.monthtime_textbox);
            this.tabPage1.Controls.Add(this.type_label);
            this.tabPage1.Controls.Add(this.age_textbox);
            this.tabPage1.Controls.Add(this.percent_label);
            this.tabPage1.Controls.Add(this.monthtime_label);
            this.tabPage1.Controls.Add(this.deposit_label);
            this.tabPage1.Controls.Add(this.age_label);
            this.tabPage1.Controls.Add(this.name_textbox);
            this.tabPage1.Controls.Add(this.type_combobox);
            this.tabPage1.Controls.Add(this.percent_textbox);
            this.tabPage1.Controls.Add(this.balance_textbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1859, 1022);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Result_Label
            // 
            this.Result_Label.AutoSize = true;
            this.Result_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result_Label.Location = new System.Drawing.Point(759, 594);
            this.Result_Label.Name = "Result_Label";
            this.Result_Label.Size = new System.Drawing.Size(0, 33);
            this.Result_Label.TabIndex = 25;
            // 
            // penalty_textbox
            // 
            this.penalty_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.penalty_textbox.Location = new System.Drawing.Point(1048, 438);
            this.penalty_textbox.Name = "penalty_textbox";
            this.penalty_textbox.Size = new System.Drawing.Size(382, 40);
            this.penalty_textbox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(730, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 33);
            this.label2.TabIndex = 23;
            this.label2.Text = "Штраф вкладу";
            // 
            // AgeRetire_textBox
            // 
            this.AgeRetire_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeRetire_textBox.Location = new System.Drawing.Point(1048, 509);
            this.AgeRetire_textBox.Name = "AgeRetire_textBox";
            this.AgeRetire_textBox.Size = new System.Drawing.Size(382, 40);
            this.AgeRetire_textBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(730, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 33);
            this.label1.TabIndex = 21;
            this.label1.Text = "Вік пенсії";
            // 
            // currency_textbox
            // 
            this.currency_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currency_textbox.Location = new System.Drawing.Point(321, 591);
            this.currency_textbox.Name = "currency_textbox";
            this.currency_textbox.Size = new System.Drawing.Size(382, 40);
            this.currency_textbox.TabIndex = 20;
            // 
            // nameDeposit_textBox
            // 
            this.nameDeposit_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameDeposit_textBox.Location = new System.Drawing.Point(321, 79);
            this.nameDeposit_textBox.Name = "nameDeposit_textBox";
            this.nameDeposit_textBox.Size = new System.Drawing.Size(382, 40);
            this.nameDeposit_textBox.TabIndex = 19;
            // 
            // namedeposit_label
            // 
            this.namedeposit_label.AutoSize = true;
            this.namedeposit_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namedeposit_label.Location = new System.Drawing.Point(6, 82);
            this.namedeposit_label.Name = "namedeposit_label";
            this.namedeposit_label.Size = new System.Drawing.Size(230, 33);
            this.namedeposit_label.TabIndex = 18;
            this.namedeposit_label.Text = "Назва депозиту";
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_button.Location = new System.Drawing.Point(12, 802);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(273, 103);
            this.add_button.TabIndex = 17;
            this.add_button.Text = "Додати депозит";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // currencyRate_textbox
            // 
            this.currencyRate_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currencyRate_textbox.Location = new System.Drawing.Point(321, 680);
            this.currencyRate_textbox.Name = "currencyRate_textbox";
            this.currencyRate_textbox.Size = new System.Drawing.Size(382, 40);
            this.currencyRate_textbox.TabIndex = 16;
            // 
            // CurrencyRate
            // 
            this.CurrencyRate.AutoSize = true;
            this.CurrencyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrencyRate.Location = new System.Drawing.Point(6, 683);
            this.CurrencyRate.Name = "CurrencyRate";
            this.CurrencyRate.Size = new System.Drawing.Size(187, 33);
            this.CurrencyRate.TabIndex = 15;
            this.CurrencyRate.Text = "Курс валюти";
            // 
            // Currency
            // 
            this.Currency.AutoSize = true;
            this.Currency.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Currency.Location = new System.Drawing.Point(3, 594);
            this.Currency.Name = "Currency";
            this.Currency.Size = new System.Drawing.Size(118, 33);
            this.Currency.TabIndex = 13;
            this.Currency.Text = "Валюта";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.deposit2_label);
            this.tabPage2.Controls.Add(this.withdraw_label);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.Deposit_textbox);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.NameDeposit_combobox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.withdraw_textBox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.WithdrawDeposit_combobox);
            this.tabPage2.Controls.Add(this.Deposit_button);
            this.tabPage2.Controls.Add(this.Withdraw_button);
            this.tabPage2.Controls.Add(this.resault_deletion);
            this.tabPage2.Controls.Add(this.result_calculation);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.month_textBox);
            this.tabPage2.Controls.Add(this.Name_combobox);
            this.tabPage2.Controls.Add(this.calculate_button);
            this.tabPage2.Controls.Add(this.delete_btn);
            this.tabPage2.Controls.Add(this.summary_label);
            this.tabPage2.Controls.Add(this.showOwner_button);
            this.tabPage2.Controls.Add(this.owner_combo);
            this.tabPage2.Controls.Add(this.ShowAll_button);
            this.tabPage2.Controls.Add(this.alldepos_label);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1859, 1022);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // deposit2_label
            // 
            this.deposit2_label.AutoSize = true;
            this.deposit2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deposit2_label.Location = new System.Drawing.Point(839, 821);
            this.deposit2_label.Name = "deposit2_label";
            this.deposit2_label.Size = new System.Drawing.Size(0, 33);
            this.deposit2_label.TabIndex = 24;
            // 
            // withdraw_label
            // 
            this.withdraw_label.AutoSize = true;
            this.withdraw_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.withdraw_label.Location = new System.Drawing.Point(9, 821);
            this.withdraw_label.Name = "withdraw_label";
            this.withdraw_label.Size = new System.Drawing.Size(0, 33);
            this.withdraw_label.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(872, 732);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 33);
            this.label7.TabIndex = 22;
            this.label7.Text = "Скілки покласти";
            // 
            // Deposit_textbox
            // 
            this.Deposit_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deposit_textbox.Location = new System.Drawing.Point(845, 778);
            this.Deposit_textbox.Name = "Deposit_textbox";
            this.Deposit_textbox.Size = new System.Drawing.Size(297, 40);
            this.Deposit_textbox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(872, 640);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 33);
            this.label8.TabIndex = 20;
            this.label8.Text = "Назва депозиту";
            // 
            // NameDeposit_combobox
            // 
            this.NameDeposit_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameDeposit_combobox.FormattingEnabled = true;
            this.NameDeposit_combobox.Location = new System.Drawing.Point(845, 688);
            this.NameDeposit_combobox.Name = "NameDeposit_combobox";
            this.NameDeposit_combobox.Size = new System.Drawing.Size(297, 41);
            this.NameDeposit_combobox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(30, 732);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 33);
            this.label6.TabIndex = 18;
            this.label6.Text = "Скілки зняти";
            // 
            // withdraw_textBox
            // 
            this.withdraw_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.withdraw_textBox.Location = new System.Drawing.Point(3, 778);
            this.withdraw_textBox.Name = "withdraw_textBox";
            this.withdraw_textBox.Size = new System.Drawing.Size(297, 40);
            this.withdraw_textBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(30, 640);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 33);
            this.label5.TabIndex = 16;
            this.label5.Text = "Назва депозиту";
            // 
            // WithdrawDeposit_combobox
            // 
            this.WithdrawDeposit_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WithdrawDeposit_combobox.FormattingEnabled = true;
            this.WithdrawDeposit_combobox.Location = new System.Drawing.Point(3, 688);
            this.WithdrawDeposit_combobox.Name = "WithdrawDeposit_combobox";
            this.WithdrawDeposit_combobox.Size = new System.Drawing.Size(297, 41);
            this.WithdrawDeposit_combobox.TabIndex = 15;
            // 
            // Deposit_button
            // 
            this.Deposit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deposit_button.Location = new System.Drawing.Point(845, 546);
            this.Deposit_button.Name = "Deposit_button";
            this.Deposit_button.Size = new System.Drawing.Size(297, 77);
            this.Deposit_button.TabIndex = 14;
            this.Deposit_button.Text = "Покласти гроші";
            this.Deposit_button.UseVisualStyleBackColor = true;
            this.Deposit_button.Click += new System.EventHandler(this.Deposit_button_Click);
            // 
            // Withdraw_button
            // 
            this.Withdraw_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Withdraw_button.Location = new System.Drawing.Point(3, 546);
            this.Withdraw_button.Name = "Withdraw_button";
            this.Withdraw_button.Size = new System.Drawing.Size(297, 77);
            this.Withdraw_button.TabIndex = 13;
            this.Withdraw_button.Text = "Зняти гроші";
            this.Withdraw_button.UseVisualStyleBackColor = true;
            this.Withdraw_button.Click += new System.EventHandler(this.Withdraw_button_Click);
            // 
            // resault_deletion
            // 
            this.resault_deletion.AutoSize = true;
            this.resault_deletion.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resault_deletion.Location = new System.Drawing.Point(9, 492);
            this.resault_deletion.Name = "resault_deletion";
            this.resault_deletion.Size = new System.Drawing.Size(0, 33);
            this.resault_deletion.TabIndex = 12;
            // 
            // result_calculation
            // 
            this.result_calculation.AutoSize = true;
            this.result_calculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_calculation.Location = new System.Drawing.Point(613, 492);
            this.result_calculation.Name = "result_calculation";
            this.result_calculation.Size = new System.Drawing.Size(0, 33);
            this.result_calculation.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(653, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "Кількість місяців";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Назва депозиту";
            // 
            // month_textBox
            // 
            this.month_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.month_textBox.Location = new System.Drawing.Point(619, 431);
            this.month_textBox.Name = "month_textBox";
            this.month_textBox.Size = new System.Drawing.Size(297, 40);
            this.month_textBox.TabIndex = 8;
            // 
            // Name_combobox
            // 
            this.Name_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_combobox.FormattingEnabled = true;
            this.Name_combobox.Location = new System.Drawing.Point(3, 431);
            this.Name_combobox.Name = "Name_combobox";
            this.Name_combobox.Size = new System.Drawing.Size(297, 41);
            this.Name_combobox.TabIndex = 7;
            // 
            // calculate_button
            // 
            this.calculate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculate_button.Location = new System.Drawing.Point(619, 293);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(297, 77);
            this.calculate_button.TabIndex = 6;
            this.calculate_button.Text = "Обчислити баланс";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_btn.Location = new System.Drawing.Point(3, 293);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(297, 77);
            this.delete_btn.TabIndex = 5;
            this.delete_btn.Text = "Видалити обраний депозит";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // summary_label
            // 
            this.summary_label.AutoSize = true;
            this.summary_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.summary_label.Location = new System.Drawing.Point(935, 45);
            this.summary_label.Name = "summary_label";
            this.summary_label.Size = new System.Drawing.Size(0, 31);
            this.summary_label.TabIndex = 4;
            // 
            // showOwner_button
            // 
            this.showOwner_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showOwner_button.Location = new System.Drawing.Point(619, 22);
            this.showOwner_button.Name = "showOwner_button";
            this.showOwner_button.Size = new System.Drawing.Size(297, 77);
            this.showOwner_button.TabIndex = 3;
            this.showOwner_button.Text = "Показати депозити користувача";
            this.showOwner_button.UseVisualStyleBackColor = true;
            this.showOwner_button.Click += new System.EventHandler(this.showOwner_button_Click);
            // 
            // owner_combo
            // 
            this.owner_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.owner_combo.FormattingEnabled = true;
            this.owner_combo.Location = new System.Drawing.Point(306, 41);
            this.owner_combo.Name = "owner_combo";
            this.owner_combo.Size = new System.Drawing.Size(293, 41);
            this.owner_combo.TabIndex = 2;
            // 
            // ShowAll_button
            // 
            this.ShowAll_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowAll_button.Location = new System.Drawing.Point(3, 22);
            this.ShowAll_button.Name = "ShowAll_button";
            this.ShowAll_button.Size = new System.Drawing.Size(297, 77);
            this.ShowAll_button.TabIndex = 1;
            this.ShowAll_button.Text = "Показати усі депозити";
            this.ShowAll_button.UseVisualStyleBackColor = true;
            this.ShowAll_button.Click += new System.EventHandler(this.ShowAll_button_Click);
            // 
            // alldepos_label
            // 
            this.alldepos_label.AutoSize = true;
            this.alldepos_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alldepos_label.Location = new System.Drawing.Point(9, 111);
            this.alldepos_label.Name = "alldepos_label";
            this.alldepos_label.Size = new System.Drawing.Size(0, 31);
            this.alldepos_label.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 1048);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Label percent_label;
        private System.Windows.Forms.Label deposit_label;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox percent_textbox;
        private System.Windows.Forms.TextBox balance_textbox;
        private System.Windows.Forms.ComboBox type_combobox;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.Label monthtime_label;
        private System.Windows.Forms.TextBox age_textbox;
        private System.Windows.Forms.TextBox monthtime_textbox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label CurrencyRate;
        private System.Windows.Forms.Label Currency;
        private System.Windows.Forms.TextBox currencyRate_textbox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label namedeposit_label;
        private System.Windows.Forms.TextBox nameDeposit_textBox;
        private System.Windows.Forms.TextBox currency_textbox;
        private System.Windows.Forms.TextBox AgeRetire_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox penalty_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Result_Label;
        private System.Windows.Forms.Label alldepos_label;
        private System.Windows.Forms.Button ShowAll_button;
        private System.Windows.Forms.ComboBox owner_combo;
        private System.Windows.Forms.Button showOwner_button;
        private System.Windows.Forms.Label summary_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox month_textBox;
        private System.Windows.Forms.ComboBox Name_combobox;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label resault_deletion;
        private System.Windows.Forms.Label result_calculation;
        private System.Windows.Forms.Button Withdraw_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox withdraw_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox WithdrawDeposit_combobox;
        private System.Windows.Forms.Button Deposit_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Deposit_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox NameDeposit_combobox;
        private System.Windows.Forms.Label deposit2_label;
        private System.Windows.Forms.Label withdraw_label;
    }
}

