////////////////////////////////////////////////////////////
/////   TestScript.cs
/////   James McNeil - 2021
////////////////////////////////////////////////////////////

using UnityEngine;
using TechDebtTracker;

[TechDebt(Name = "Class Type", Description = "The body goes here", Severity = SeverityLevel.EXTREME, GrowthSpeed = GrowthSpeed.MEDIUM)]
public class TestScript : MonoBehaviour
{
    [TechDebt(Name = "Class Variable")]
    private string temp;

    [TechDebt(Name = "Private Static Variable")]
    private static TargetJoint2D target;

    [TechDebt(Name = "Public Static Variable")]
    public static TestScript instance;

    // Start is called before the first frame update
    [TechDebt(Name = "Class Method")]
    void Start()
    {
    }

    // Update is called once per frame
    [TechDebt(Name = "Public Static Method")]
    public static void Update()
    {
        
    }

    // Update is called once per frame
    [TechDebt(Name = "Private Static Method")]
    private static void PrivateStaticMethod()
    {

    }
}

[TechDebt(Name = "Interface Type")]
public interface IIntroExample
{
    [TechDebt(Name = "Interface Method")]
    public void InterfaceMethod();
}

[TechDebt(Name = "Enum Type")]
public enum EnumVal
{ ONE_VAL, TWO_VAL }


[TechDebt(Name = "Struct Type")]
public struct StructTest { }