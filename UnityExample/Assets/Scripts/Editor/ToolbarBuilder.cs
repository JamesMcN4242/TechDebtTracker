////////////////////////////////////////////////////////////
/////   ToolbarBuilder.cs
/////   James McNeil - 2021
////////////////////////////////////////////////////////////

using UnityEditor;
using UnityEngine;

public static class ToolbarBuilder
{
    [MenuItem("TechDebt/Create HTML File")]
    public static void OutputTechDebtHTML()
    {
        TechDebtTracker.DebtFormatter.CreateHTMLDebtList("Assets/Output/Html.html");
        AssetDatabase.Refresh();
        Debug.Log($"Finished writing to file");
    }

    [MenuItem("TechDebt/Create CSV File")]
    public static void OutputTechDebtCSV()
    {
        TechDebtTracker.DebtFormatter.CreateCSVDebtList("Assets/Output/CSV.csv");
        AssetDatabase.Refresh();
        Debug.Log($"Finished writing to file");
    }
}
