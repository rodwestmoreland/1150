﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces.Currency
{
    class Transaction
    {
        private readonly ICurrency _currency;
        public DateTimeOffset DateOfTransaction { get; }

        public Transaction(ICurrency currency)
        {
            _currency = currency;
            DateOfTransaction = DateTimeOffset.Now;
        }

        public decimal GetTransactionAmount() =>    _currency.Value;
        public string  GetTransactionType() =>      _currency.Name;

    }// \Transaction class


}// ns