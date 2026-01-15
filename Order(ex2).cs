using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace POOsuite
{
    internal class Order
    {
        //Attributs et Proprietes

        public string CustomerName { get; set; }
        public decimal Amount { get; set; }
        public bool IsCancelled { get; private set; }
        public static int CreatedOrdersCount { get; private set; } //NBR Total de commandes créées
        public static int CancelledOrdersCount { get; private set; } //NBR Total de commandes annulées
        public static decimal TotalAmountCreated { get; private set; } //Somme des montants de toutes les commandes créées

        //Constructeur
        public Order(string customerName, decimal amount)
        {
            CustomerName = customerName;
            Amount = amount;
            IsCancelled = false;
            CreatedOrdersCount++;
            TotalAmountCreated += amount;
        }

        //Méthode
        public void Cancel()
        {
            {
                IsCancelled = true;
                CancelledOrdersCount++;
                TotalAmountCreated -= Amount;
            }
        }
        public void DisplayOrderInfo()
        {
            Console.WriteLine($"Client: {CustomerName}, Montant: {Amount} $, Annulée: {IsCancelled}");
        }
    }
}
