using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankDeposit
{
    public abstract class Deposit : IDeposit
    {
        public string Name { get; }
        public decimal Balance { get; protected set; }
        public decimal InterestRate { get; }

        public string OwnerName { get; }

        protected Deposit(string name, string ownerName, decimal balance, decimal interestRate)
        {
            Name = name;
            OwnerName = ownerName;
            Balance = balance;
            InterestRate = interestRate;
        }

        public abstract decimal CalculateInterest();


        public virtual void DepositMoney(decimal amount)
        {
            Balance += amount;
            Console.WriteLine("Поповнення на {amount}. Баланс: {Balance}");
        }

        public virtual void WithdrawMoney(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Знято {amount}. Баланс: {Balance}");
            }
            else
            {
                Console.WriteLine("Недостатньо коштів для зняття.");
            }
        }
        public abstract string PrintDetails();

    }

    public class TermDeposit : Deposit, ITermDeposit
    {
        public int TermMonth { get; }

        private int elapsedMonths;
        public override string PrintDetails()
        {
            return $"Тип: {GetType().Name}, Ім'я: {Name}, Власник: {OwnerName}, Баланс: {Balance}, Відсоткова ставка: {InterestRate}, Термін (місяців): {TermMonth}";
        }

        public TermDeposit(string name, string ownerName, decimal initialBalance, decimal interestRate, int termMonth) : base(name, ownerName, initialBalance, interestRate)
        {
            TermMonth = termMonth;
            elapsedMonths = 0;
        }

        public override void DepositMoney(decimal amount)
        {
            Console.WriteLine("Поповнення строкового вкладу неможливе.");
        }

        public override void WithdrawMoney(decimal amount)
        {
            Console.WriteLine("Зняття коштів зі строкового вкладу неможливе до закінчення терміну.");
        }

        public override decimal CalculateInterest()
        {
            return Balance * InterestRate * TermMonth / 12;
        }

        public bool isTermComplete()
        {
            return elapsedMonths >= TermMonth;
        }
    }

    public class SavingDeposit : Deposit, ISavingDeposit
    {
        public SavingDeposit(string name, string ownerName, decimal balance, decimal interestRate) : base(name, ownerName, balance, interestRate)
        { }

        public override string PrintDetails()
        {
            return $"Тип: {GetType().Name}, Ім'я: {Name}, Власник: {OwnerName}, Баланс: {Balance}, Відсоткова ставка: {InterestRate}";
        }
        public override decimal CalculateInterest()
        {
            return Balance * InterestRate / 12;
        }

        public void AddMonthlySavings(decimal amount)
        {
            DepositMoney(amount);
        }
    }

    public class CurrencyDeposit : Deposit, ICurrencyDeposit
    {
        public string DepositCurrency { get; }
        public decimal ExchangeRate { get; }
        public override string PrintDetails()
        {
            return $"Тип: {GetType().Name}, Ім'я: {Name}, Власник: {OwnerName}, Баланс: {Balance}, Відсоткова ставка: {InterestRate}, Валюта: {DepositCurrency}, Баланс за курсом: {Balance * ExchangeRate}";
        }
        public CurrencyDeposit(string name, string ownerName, decimal balance, decimal interestRate, string currency, decimal exchangeRate) : base(name, ownerName, balance, interestRate)
        {
            DepositCurrency = currency;
            ExchangeRate = exchangeRate;

        }

        public decimal ConvertToCurrency(string targetCurrency, decimal exchangeRate)
        {
            decimal convertedAmount = Balance * exchangeRate;
            Console.WriteLine($"Конвертовано {Balance} {DepositCurrency} в {convertedAmount} {targetCurrency} за курсом {exchangeRate}");
            return convertedAmount;
        }

        public override decimal CalculateInterest()
        {
            return Balance * InterestRate  / 12;
        }
    }

    public class CapitalizedDeposit : Deposit, ICapitalizedDeposit
    {
        public CapitalizedDeposit(string name, string ownerName, decimal initialBalance, decimal interestRate) : base(name, ownerName, initialBalance, interestRate)
        { }
        public override string PrintDetails()
        {
            return $"Тип: {GetType().Name}, Ім'я: {Name}, Власник: {OwnerName}, Баланс: {Balance}, Відсоткова ставка: {InterestRate}";
        }
        public void CapitalizeInterest()
        {
            decimal interest = CalculateInterest();
            Balance += interest;
            Console.WriteLine($"Капіталізовано відсотки: {interest}. Новий баланс: {Balance}");
        }

        public override decimal CalculateInterest()
        {
            return Balance * InterestRate / 12;
        }
    }

    public class PensionDeposit : Deposit, IPensionDeposit
    {
        public int RetirementAge { get; }
        public int AgeAtDeposit { get; }
        public override string PrintDetails()
        {
            return $"Тип: {GetType().Name}, Ім'я: {Name}, Власник: {OwnerName}, Баланс: {Balance}, Відсоткова ставка: {InterestRate}, Вік при відкритті: {AgeAtDeposit}, Пенсійний вік: {RetirementAge}";
        }
        public PensionDeposit(string name, string ownerName, decimal initialBalance, decimal interestRate, int retirementAge, int ageAtDeposit) : base(name, ownerName, initialBalance, interestRate)
        {
            RetirementAge = retirementAge;
            AgeAtDeposit = ageAtDeposit;
        }


        public bool IsEligibleForPension(int currentAge)
        {
            return currentAge >= (RetirementAge + AgeAtDeposit);
        }

        public void WithdrawPension(decimal amount, int currentAge)
        {
            if (IsEligibleForPension(currentAge))
            {
                WithdrawMoney(amount);
                Console.WriteLine($"Знято пенсійні кошти: {amount}. Баланс після пенсії: {Balance}");
            }
            else
            {
                Console.WriteLine($"Не можна зняти пенсійні кошти. Пенсійний вік ще не настав.");
            }
        }

        public override decimal CalculateInterest()
        {
            return Balance * InterestRate / 12;
        }
    }


    public class EarlyWithdrawalDeposit : Deposit, IEarlyWithdrawalDeposit
    {
        public decimal EarlyWithdrawalPenalty { get; }
        public EarlyWithdrawalDeposit(string name, string ownerName, decimal initialBalance, decimal interestRate, decimal earlyWithdrawalPenalty) : base(name, ownerName, initialBalance, interestRate)
        {
            EarlyWithdrawalPenalty = earlyWithdrawalPenalty;
        }

        public override string PrintDetails()
        {
            return $"Тип: {GetType().Name}, Ім'я: {Name}, Власник: {OwnerName}, Баланс: {Balance}, Відсоткова ставка: {InterestRate}, Штраф за дострокове зняття: {EarlyWithdrawalPenalty}";
        }
        public void WithdrawEarly(decimal amount)
        {
            if (amount <= Balance)
            {
                decimal penaltyAmount = amount * EarlyWithdrawalPenalty;
                decimal totalAmountToWithdraw = amount + penaltyAmount;
                if (totalAmountToWithdraw <= Balance)
                {
                    WithdrawMoney(totalAmountToWithdraw);
                    Console.WriteLine($"Знято {amount} з штрафом {penaltyAmount}. Баланс після дострокового зняття: {Balance}");
                }
                else
                {
                    Console.WriteLine("Недостатньо коштів для зняття з урахуванням штрафу.");
                }
            }
            else
            {
                Console.WriteLine("Недостатньо коштів для дострокового зняття.");
            }
        }

        public override decimal CalculateInterest()
        {
            return Balance * InterestRate / 12;
        }
    }


    public class DepositContainer : IDepositContainer
    {
        private List<Deposit> deposits;

        public DepositContainer()
        {
            deposits = new List<Deposit>();
        }

        public void AddDeposit(Deposit deposit)
        {
            deposits.Add(deposit);
            Console.WriteLine($"Додано депозит: {deposit.Name}, тип: {deposit.GetType().Name}, власник: {deposit.OwnerName}, баланс: {deposit.Balance}");
        }

        public bool RemoveDepositByName(string depositName)
        {
            var depositToRemove = deposits.FirstOrDefault(d => $"{d.OwnerName} - {d.Name}" == depositName);
            if (depositToRemove != null)
            {
                deposits.Remove(depositToRemove);
                return true;
            }
            return false;
        }

        public void RemoveDeposit(Deposit deposit)
        {
            deposits.Remove(deposit);
            Console.WriteLine($"Видалено депозит: {deposit.Name}, власник: {deposit.OwnerName}");
        }

        public decimal CalculateTotalBalance()
        {
            return deposits.Sum(d => d.Balance);
        }

        public decimal CalculateTotalInterest()
        {
            return deposits.Sum(d => d.CalculateInterest());
        }

        public string PrintAllDeposits()
        {
            StringBuilder result = new StringBuilder();
            foreach (var deposit in deposits)
            {
                result.AppendLine(deposit.PrintDetails());
            }
            return result.ToString();
        }

        public string PrintDepositsByOwner(string ownerName)
        {
            StringBuilder result = new StringBuilder();
            var ownerDeposits = deposits.Where(d => d.OwnerName == ownerName).ToList();
            if (ownerDeposits.Count > 0)
            {
                foreach (var deposit in ownerDeposits)
                {
                    result.AppendLine(deposit.PrintDetails());
                }
            }
            else
            {
                result.AppendLine($"Немає депозитів для власника з ім'ям {ownerName}.");
            }
            return result.ToString();
        }

        public decimal CalculateTotalBalanceByOwner(string ownerName)
        {
            return deposits.Where(d => d.OwnerName == ownerName).Sum(d => d.Balance);
        }
        public decimal CalculateTotalInterestByOwner(string ownerName)
        {
            return deposits.Where(d => d.OwnerName == ownerName).Sum(d => d.CalculateInterest());
        }

        public decimal CalculateBalanceAfterMonths(string depositName, int months)
        {
            var deposit = deposits.FirstOrDefault(d => $"{d.OwnerName} - {d.Name}" == depositName);
            if (deposit == null)
            {
                throw new ArgumentException($"Депозит з ім'ям {depositName} не знайдено.");
            }

            decimal interestPerMonth = deposit.CalculateInterest();

            decimal newBalance = deposit.Balance + interestPerMonth * months;

            return newBalance;
        }


        public List<string> GetUniqueOwnerNames()
        {
            return deposits.Select(d => d.OwnerName).Distinct().ToList();
        }

        public List<string> GetUniqueNames()
        {
            return deposits.Select(d => $"{d.OwnerName} - {d.Name}").Distinct().ToList();
        }



        public bool WithdrawFromDeposit(string depositName, decimal amount)
        {
            var deposit = deposits.FirstOrDefault(d => $"{d.OwnerName} - {d.Name}" == depositName);
            if (deposit == null)
            {
                return false;
            }

            if (deposit is TermDeposit termDeposit)
            {
                return false;
            }
            else if (deposit is SavingDeposit savingDeposit)
            {
                return false;
            }
            else if (deposit is EarlyWithdrawalDeposit earlyWithdrawalDeposit)
            {
                earlyWithdrawalDeposit.WithdrawEarly(amount);
                return true;
            }
            else
            {
                if (amount > deposit.Balance)
                {
                    return false; 
                }

                deposit.WithdrawMoney(amount);
                return true;
            }
        }
        public decimal GetDepositBalance(string depositName)
        {
            var deposit = deposits.FirstOrDefault(d => $"{d.OwnerName} - {d.Name}" == depositName);
            return deposit?.Balance ?? 0;
        }


        public bool DepositToDeposit(string depositName, decimal amount)
        {
            var deposit = deposits.FirstOrDefault(d => $"{d.OwnerName} - {d.Name}" == depositName);
            if (deposit == null)
            {
                return false; 
            }

            if (deposit is TermDeposit termDeposit)
            {
                return false;
            }

            deposit.DepositMoney(amount);
            return true;
        }
    }
}
