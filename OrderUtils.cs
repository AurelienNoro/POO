using System;
using System.Collections.Generic;
using System.Text;

namespace POOsuite
{
//Classe OrderUtils(classe static)

//Méthodes :
//string NormalizeCustomerName(string name) : trim + met la première lettre en majuscule, le reste en minuscules
//bool IsValidCustomerName(string name) : true si non vide et longueur >= 2
    internal static class OrderUtils
    {

        public static string NormalizeCustomerName(string name)
            {
            name = name.Trim();
            return char.ToUpper(name[0]) + name.Substring(1).ToLower();
        }

        public static bool IsValidCustomerName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && name.Trim().Length >= 2;
        }
    }
}
