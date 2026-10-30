using System.Collections.Generic;
using CapitalControl.Models;

namespace CapitalControl.Services
{
    public static class AppData
    {
        static AppData()
        {
            foreach (TxType t in System.Enum.GetValues(typeof(TxType)))
            {
                Categories[t] = new List<string>();
            }
        }

        public static string UserEmail { get; set; }
        public static string UserName { get; set; }
        public static List<Debt> Debts { get; } = new List<Debt>();
        public static List<Transaction> Transactions { get; } = new List<Transaction>();
        public static List<Subscription> Subscriptions { get; } = new List<Subscription>();
        public static List<SavingsGoal> Goals { get; } = new List<SavingsGoal>();
        public static Dictionary<TxType, List<string>> Categories { get; } = new Dictionary<TxType, List<string>>();
        public static decimal Balance { get; set; }
    }
}