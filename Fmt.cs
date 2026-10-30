using System;

namespace CapitalControl
{
    public static class Fmt
    {
        public static string Currency(decimal value) => value.ToString("C");
        public static string Money(decimal value) => value.ToString("C");
        public static string Number(decimal value) => value.ToString("N2");
        public static string Percent(double value) => (value * 100).ToString("F1") + "%";
        public static string Date(DateTime value) => value.ToShortDateString();
    }
}