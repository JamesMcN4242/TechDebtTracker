# TechDebtTracker
A C# package which adds the ability to use `[TechDebt]` attributes in your code. 
These attributes can then be collected from the full codebase or a specific assembly/type.

Additionally some help methods have been added via the DebtOutputter class to output the results in very basic HTML or a CSV format. The results can also be grabbed by the user to apply any formatting they prefer.

### The Package
The package can be found in the 'Package' directory. It is a DLL built on .NET Standard 2.0 and should be easily hooked into any project.

### Using `[TechDebt]`
The `[TechDebt]` attribute can used on Classes, Enums, Interfaces, Methods, Structs, Variables, etc.
It contains 4 optional properties of: Name, Description, Severity and Growth Speed.

An example use can be seen below:
```C#

using TechDebtTracker;

[TechDebt(Name = "Telemetry Hack", Description = "Dummy backend for our data", Severity = SeverityLevel.HIGH)]
public class TelemetryHack
{
  //...
}
```
