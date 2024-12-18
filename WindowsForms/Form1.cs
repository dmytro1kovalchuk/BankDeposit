using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bankDeposit;



namespace WindowsForms
{
    public partial class Form1 : Form
    {
        private DepositContainer depositContainer;
        public Form1()
        {
            InitializeComponent();
            depositContainer = new DepositContainer();
            type_combobox.SelectedIndexChanged += type_combobox_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (type_combobox.SelectedItem == null && type_combobox.Items.Count > 0)
            {
                type_combobox.SelectedIndex = 0; 
            }

            string initialDepositType = type_combobox.SelectedItem?.ToString();
            UpdateUIForDepositType(initialDepositType);
        }

        private void UpdateUIForDepositType(string depositType)
        {
            monthtime_textbox.Visible = false;
            currency_textbox.Visible = false;
            currencyRate_textbox.Visible = false;
            AgeRetire_textBox.Visible = false;
            age_textbox.Visible = false;
            penalty_textbox.Visible = false;
            monthtime_label.Visible = false;
            age_label.Visible = false;
            Currency.Visible = false;
            CurrencyRate.Visible = false;
            label2.Visible = false;
            label1.Visible = false;
            switch (depositType)
            {
                case "Строковий депозит":
                    monthtime_label.Visible = true;
                    monthtime_textbox.Visible = true;
                    break;

                case "Валютний депозит":
                    Currency.Visible = true;
                    CurrencyRate.Visible = true;
                    currency_textbox.Visible = true;
                    currencyRate_textbox.Visible = true;
                    break;

                case "Пенсійний депозит":
                    age_label.Visible = true;
                    label1.Visible = true;
                    AgeRetire_textBox.Visible = true;
                    age_textbox.Visible = true;
                    break;

                case "Достроковий депозит":
                    penalty_textbox.Visible = true;
                    label2.Visible = true;
                    break;

                default:
                    break;
            }
        }
        private void type_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDepositType = type_combobox.SelectedItem?.ToString();

            UpdateUIForDepositType(selectedDepositType);
        }

        private void add_button_Click(object sender, EventArgs e)
        {
      
            string name = nameDeposit_textBox.Text;
            string ownerName = name_textbox.Text;
            decimal balance = decimal.Parse(balance_textbox.Text, System.Globalization.CultureInfo.InvariantCulture);
            decimal interestRate = decimal.Parse(percent_textbox.Text, System.Globalization.CultureInfo.InvariantCulture);
            string depositType = type_combobox.SelectedItem.ToString();

            Deposit deposit = null;

            switch (depositType)
            {
                case "Строковий депозит":
                    int termMonth = int.Parse(monthtime_textbox.Text);
                    deposit = new TermDeposit(name, ownerName, balance, interestRate, termMonth);
                    break;

                case "Заощаджувальний депозит":
                    deposit = new SavingDeposit(name, ownerName, balance, interestRate);
                    break;

                case "Валютний депозит":
                    string currency = currency_textbox.Text;
                    decimal exchangeRate = decimal.Parse(currencyRate_textbox.Text, System.Globalization.CultureInfo.InvariantCulture);
                    deposit = new CurrencyDeposit(name, ownerName, balance, interestRate, currency, exchangeRate);
                    break;

                case "Капіталізований депозит":
                    deposit = new CapitalizedDeposit(name, ownerName, balance, interestRate);
                    break;

                case "Пенсійний депозит":
                    int retirementAge = int.Parse(AgeRetire_textBox.Text);
                    int ageAtDeposit = int.Parse(age_textbox.Text);
                    deposit = new PensionDeposit(name, ownerName, balance, interestRate, retirementAge, ageAtDeposit);
                    break;

                case "Достроковий депозит":
                    decimal earlyWithdrawalPenalty = decimal.Parse(penalty_textbox.Text, System.Globalization.CultureInfo.InvariantCulture);
                    deposit = new EarlyWithdrawalDeposit(name, ownerName, balance, interestRate, earlyWithdrawalPenalty);
                    break;

                default:
                    MessageBox.Show("Вибраний тип депозиту не підтримується.");
                    return;
            }

            depositContainer.AddDeposit(deposit);

            PopulateOwnerComboBox();

            PopulateNameComboBox();
            PopulateNameDepositComboBox();
            PopulateWithdrawDepositComboBox();

            string depositInfo = $"Депозит додано:\n" +
                                 $"Тип: {deposit.GetType().Name}\n" +
                                 $"Ім'я: {deposit.Name}\n" +
                                 $"Власник: {deposit.OwnerName}\n" +
                                 $"Баланс: {deposit.Balance}\n" +
                                 $"Відсоткова ставка: {deposit.InterestRate}\n";

            if (deposit is TermDeposit termDeposit)
            {
                depositInfo += $"Термін (місяців): {termDeposit.TermMonth}\n";
            }
            else if (deposit is CurrencyDeposit currencyDeposit)
            {
                depositInfo += $"Валюта: {currencyDeposit.DepositCurrency}\n" +
                               $"Курс валюти: {currencyDeposit.ConvertToCurrency(currencyDeposit.DepositCurrency, 1)}\n";
            }
            else if (deposit is PensionDeposit pensionDeposit)
            {
                depositInfo += $"Вік при відкритті: {pensionDeposit.AgeAtDeposit}\n" +
                               $"Пенсійний вік: {pensionDeposit.RetirementAge}\n";
            }
            else if (deposit is EarlyWithdrawalDeposit earlyWithdrawalDeposit)
            {
                depositInfo += $"Штраф за дострокове зняття: {earlyWithdrawalDeposit.EarlyWithdrawalPenalty}\n";
            }

            Result_Label.Text = depositInfo;


        }

        private void PopulateOwnerComboBox()
        {
            owner_combo.Items.Clear();

            List<string> ownerNames = depositContainer.GetUniqueOwnerNames();

            owner_combo.Items.AddRange(ownerNames.ToArray());

            if (ownerNames.Count > 0)
            {
                owner_combo.SelectedIndex = 0;
            }
        }

        private void PopulateNameComboBox()
        {
            Name_combobox.Items.Clear();

            List<string> Names = depositContainer.GetUniqueNames();

            Name_combobox.Items.AddRange(Names.ToArray());

            if (Names.Count > 0)
            {
                Name_combobox.SelectedIndex = 0;
            }
        }

        private void PopulateWithdrawDepositComboBox()
        {
            WithdrawDeposit_combobox.Items.Clear();

            List<string> Names = depositContainer.GetUniqueNames();

            WithdrawDeposit_combobox.Items.AddRange(Names.ToArray());

            if (Names.Count > 0)
            {
                WithdrawDeposit_combobox.SelectedIndex = 0;
            }
        }

        private void PopulateNameDepositComboBox()
        {
            NameDeposit_combobox.Items.Clear();

            List<string> Names = depositContainer.GetUniqueNames();

            NameDeposit_combobox.Items.AddRange(Names.ToArray());

            if (Names.Count > 0)
            {
                NameDeposit_combobox.SelectedIndex = 0;
            }
        }
        private void ShowAll_button_Click(object sender, EventArgs e)
        {
            
            string allDepositsInfo = depositContainer.PrintAllDeposits();

            alldepos_label.Text = allDepositsInfo;

            decimal totalBalance = depositContainer.CalculateTotalBalance();
            decimal totalInterest = depositContainer.CalculateTotalInterest();

            summary_label.Text = $"Сума депозиту: {totalBalance}, Сума ставки: {Math.Round(totalInterest, 2)}";
        }

        private void showOwner_button_Click(object sender, EventArgs e)
        {
            string selectedOwner = owner_combo.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedOwner))
            {
                MessageBox.Show("Будь ласка, оберіть власника зі списку.");
                return;
            }

            string ownerDepositsInfo = depositContainer.PrintDepositsByOwner(selectedOwner);

            alldepos_label.Text = ownerDepositsInfo;

            decimal totalBalance = depositContainer.CalculateTotalBalanceByOwner(selectedOwner);
            decimal totalInterest = depositContainer.CalculateTotalInterestByOwner(selectedOwner);

            summary_label.Text = $"Сума депозиту: {totalBalance}, Сума ставки: {Math.Round(totalInterest, 2)}";
        }

        

        private void calculate_button_Click(object sender, EventArgs e)
        {
            string selectedDeposit = Name_combobox.SelectedItem?.ToString();

            resault_deletion.Text = "";

            if (string.IsNullOrEmpty(selectedDeposit))
            {
                MessageBox.Show("Будь ласка, оберіть депозит зі списку.");
                return;
            }

            if (!int.TryParse(month_textBox.Text, out int months))
            {
                MessageBox.Show("Будь ласка, введіть коректну кількість місяців.");
                return;
            }

            try
            {
                decimal newBalance = depositContainer.CalculateBalanceAfterMonths(selectedDeposit, months);

                result_calculation.Text = $"Баланс депозиту {selectedDeposit} через {months} місяців: {Math.Round(newBalance, 2)}";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string selectedDeposit = Name_combobox.SelectedItem?.ToString();
            result_calculation.Text = "";
            if (string.IsNullOrEmpty(selectedDeposit))
            {
                resault_deletion.Text = "Будь ласка, оберіть депозит для видалення.";
                return;
            }

            bool isRemoved = depositContainer.RemoveDepositByName(selectedDeposit);

            if (isRemoved)
            {
                resault_deletion.Text = $"Депозит '{selectedDeposit}' успішно видалено.";
            }
            else
            {
                resault_deletion.Text = $"Депозит '{selectedDeposit}' не знайдено.";
            }

            PopulateNameComboBox();
            PopulateNameDepositComboBox();
            PopulateWithdrawDepositComboBox();
        }

        private void Deposit_button_Click(object sender, EventArgs e)
        {
            string selectedDeposit = NameDeposit_combobox.SelectedItem?.ToString();
            withdraw_label.Text = "";
            if (string.IsNullOrEmpty(selectedDeposit))
            {
                deposit2_label.Text = "Будь ласка, оберіть депозит для поповнення.";
                return;
            }

            if (!decimal.TryParse(Deposit_textbox.Text, out decimal amount))
            {
                deposit2_label.Text = "Будь ласка, введіть коректну суму для поповнення.";
                return;
            }

            bool isDeposited = depositContainer.DepositToDeposit(selectedDeposit, amount);

            if (isDeposited)
            {
                deposit2_label.Text = $"Поповнено {amount} на депозит '{selectedDeposit}'. Новий баланс: {depositContainer.GetDepositBalance(selectedDeposit)}";
            }
            else
            {
                deposit2_label.Text = $"Не вдалося поповнити депозит '{selectedDeposit}'. Перевірте обмеження.";

            }
        }

        private void Withdraw_button_Click(object sender, EventArgs e)
        {
            string selectedDeposit = WithdrawDeposit_combobox.SelectedItem?.ToString();
            deposit2_label.Text = "";
            if (string.IsNullOrEmpty(selectedDeposit))
            {
                withdraw_label.Text = "Будь ласка, оберіть депозит для зняття грошей.";
                return;
            }

            if (!decimal.TryParse(withdraw_textBox.Text, out decimal amount))
            {
                withdraw_label.Text = "Будь ласка, введіть коректну суму для зняття.";
                return;
            }

            bool isWithdrawn = depositContainer.WithdrawFromDeposit(selectedDeposit, amount);

            if (isWithdrawn)
            {
                withdraw_label.Text = $"Знято {amount} з депозиту '{selectedDeposit}'. Новий баланс: {depositContainer.GetDepositBalance(selectedDeposit)}";
            }
            else
            {
                withdraw_label.Text = $"Не вдалося зняти гроші з депозиту '{selectedDeposit}'. Перевірте обмеження або баланс.";
            }
        }
    }
}
