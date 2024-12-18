using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankDeposit
{
    public interface IDeposit
    {
        string Name { get; }
        string OwnerName { get; }
        decimal Balance { get; }
        decimal InterestRate { get; }

        void DepositMoney(decimal amount);
        void WithdrawMoney(decimal amount);
        decimal CalculateInterest();
    }



    public interface ITermDeposit : IDeposit
    {
        int TermMonth { get; }
        bool isTermComplete();
    }



    public interface ISavingDeposit : IDeposit
    {
        void AddMonthlySavings(decimal amount);
    }

    public interface ICurrencyDeposit : IDeposit
    {
        string DepositCurrency { get; }
        decimal ConvertToCurrency(string targetCurrency, decimal exchangeRate);
    }

    public interface ICapitalizedDeposit : IDeposit
    {
        void CapitalizeInterest();
    }

    public interface IPensionDeposit : IDeposit
    {
        int RetirementAge { get; } 
        bool IsEligibleForPension(int currentAge); 
        void WithdrawPension(decimal amount, int currentAge); 
    }

    public interface IEarlyWithdrawalDeposit : IDeposit
    {
        decimal EarlyWithdrawalPenalty { get; } 
        void WithdrawEarly(decimal amount);
    }

    public interface IDepositContainer
    {
        void AddDeposit(Deposit deposit);
        void RemoveDeposit(Deposit deposit);
        decimal CalculateTotalBalance();
        decimal CalculateTotalInterest();
        string PrintAllDeposits();
        string PrintDepositsByOwner(string ownerName);
        decimal CalculateTotalBalanceByOwner(string ownerName);
        decimal CalculateTotalInterestByOwner(string ownerName);
        decimal CalculateBalanceAfterMonths(string depositName, int months);
    }
}