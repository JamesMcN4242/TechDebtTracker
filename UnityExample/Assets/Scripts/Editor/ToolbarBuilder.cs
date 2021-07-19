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
        TechDebtTracker.DebtOutputter.CreateHTMLDebtList("Assets/Output/HTML.html");
        AssetDatabase.Refresh();
        Debug.Log($"Finished writing to file");
    }

    [MenuItem("TechDebt/Create CSV File")]
    public static void OutputTechDebtCSV()
    {
        TechDebtTracker.DebtOutputter.CreateCSVDebtList("Assets/Output/CSV.csv");
        AssetDatabase.Refresh();
        Debug.Log($"Finished writing to file");
    }
}
