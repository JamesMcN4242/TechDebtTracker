////////////////////////////////////////////////////////////
/////   DebtFormatter.cs
/////   James McNeil - 2021
////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Text;

namespace TechDebtTracker
{
    public static class DebtFormatter
    {
        public static void CreateHTMLDebtList(string outputLocation)
        {
            const string rowFormat = "<tr>\n<td>{0}</td>\n<td>{1}</td>\n<td>{2}</td>\n<td>{3}</td>\n</tr>\n";
            string htmlHeader = $"<!DOCTYPE html>\n<html>\n<head>\n<title>Tech Debt {DateTime.Today.Date.ToString("dd/MM/yyyy")}</title>\n</head>" +
                $"\n<body>\n<h1>Tech Debt {DateTime.Today.Date.ToString("dd/MM/yyyy")}</h1>\n\n" +
                $"<table>\n<tr>\n<th>Name</th>\n<th>Description</th>\n<th>Severity</th>\n<th>Growth Speed</th>\n</tr>\n";

            StringBuilder stringBuilder = new StringBuilder(htmlHeader);
            var techDebt = TechDebtCollector.CollectListedTechDebt();

            foreach (TechDebtAttribute debt in techDebt)
            {
                stringBuilder.AppendFormat(rowFormat, debt.Name, debt.Message, debt.Severity, debt.GrowthSpeed);
            }
            stringBuilder.Append("\n<body>\n</html>");

            File.WriteAllText(outputLocation, stringBuilder.ToString());
        }

        public static void CreateCSVDebtList(string outputLocation)
        {
            const string rowFormat = "{0},{1},{2},{3}\n";
            string csvHeader = $"Name,Description,Severity,Growth Speed\n,,\n";

            StringBuilder stringBuilder = new StringBuilder(csvHeader);
            var techDebt = TechDebtCollector.CollectListedTechDebt();

            foreach (TechDebtAttribute debt in techDebt)
            {
                stringBuilder.AppendFormat(rowFormat, debt.Name, debt.Message, debt.Severity, debt.GrowthSpeed);
            }

            File.WriteAllText(outputLocation, stringBuilder.ToString());
        }
    }
}
