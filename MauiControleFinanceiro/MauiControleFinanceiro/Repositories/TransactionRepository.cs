using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MauiControleFinanceiro.Repositories
{
    internal class TransactionRepository : ITransactionRepository
    {
        public TransactionRepository() { }
        public List<Transaction> GetAll() { }
        public void Add(Transaction transaction) { }
        public void Update(Transaction transaction) { }
        public void Delete(Transaction transaction) { }
    }
}
