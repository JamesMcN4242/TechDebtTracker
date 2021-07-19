////////////////////////////////////////////////////////////
/////   ToolbarBuilder.cs
/////   James McNeil - 2021
////////////////////////////////////////////////////////////

using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public static class ToolbarBuilder
{
    [MenuItem("TechDebt/Display")]
    public static void OutputTechDebt()
    {
        List<TechDebtTracker.TechDebtAttribute> attributes = TechDebtTracker.TechDebtCollector.CollectListedTechDebt();
        Debug.Log($"Retrieved a total of {attributes.Count} attributes");
    }
}
