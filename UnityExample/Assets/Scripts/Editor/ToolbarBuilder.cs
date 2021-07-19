////////////////////////////////////////////////////////////
/////   ToolbarBuilder.cs
/////   James McNeil - 2021
////////////////////////////////////////////////////////////

using UnityEditor;
using UnityEngine;

public static class ToolbarBuilder
{
    [MenuItem("TechDebt/Create HTML File")]
    public static void OutputTechDebt()
    {
        TechDebtTracker.DebtFormatter.CreateHTMLDebtList("Assets/outputHtml.html");
        AssetDatabase.Refresh();
        Debug.Log($"Finished writing to file");
    }
}
