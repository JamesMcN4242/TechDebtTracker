////////////////////////////////////////////////////////////
/////   TechDebtCollector.cs
/////   James McNeil - 2021
////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;

namespace TechDebtTracker
{
    public static class TechDebtCollector
    {
        private const int k_listStartingCapacity = 30;

        public static List<TechDebtAttribute> CollectListedTechDebt()
        {
            List<TechDebtAttribute> techDebtList = new List<TechDebtAttribute>(k_listStartingCapacity);

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                CollectTechDebtFromAssembly(assembly, techDebtList);
            }

            return techDebtList;
        }

        public static List<TechDebtAttribute> CollectTechDebtFromAssembly(Assembly assembly, List<TechDebtAttribute> techDebtList = null)
        {
            techDebtList = techDebtList ?? new List<TechDebtAttribute>(k_listStartingCapacity);

            var attributes = Attribute.GetCustomAttributes(assembly, typeof(TechDebtAttribute));
            TryAddRange(techDebtList, attributes);

            var types = assembly.GetTypes();
            foreach(Type type in types)
            {
                CollectTechDebtFromType(type, techDebtList);
            }

            return techDebtList;
        }

        public static List<TechDebtAttribute> CollectTechDebtFromType(Type type, List<TechDebtAttribute> techDebtList = null)
        {
            techDebtList = techDebtList ?? new List<TechDebtAttribute>(k_listStartingCapacity);
            
            var attributes = Attribute.GetCustomAttributes(type, typeof(TechDebtAttribute));
            TryAddRange(techDebtList, attributes);

            var members = type.GetMembers(BindingFlags.Public | BindingFlags.Instance| BindingFlags.NonPublic | BindingFlags.Static);
            foreach(var member in members)
            {
                try
                {
                    TryAddRange(techDebtList, Attribute.GetCustomAttributes(member, typeof(TechDebtAttribute)));
                }
                catch(BadImageFormatException e)
                {
                    Console.WriteLine($"BadImageFormatException on member {member}");
                }
            }                       

            return techDebtList;
        }

        private static void TryAddRange(List<TechDebtAttribute> techDebt, Attribute[] debtArrayToAdd)
        {
            foreach(TechDebtAttribute debtAttribute in debtArrayToAdd)
            {
                techDebt.Add(debtAttribute);
            }
        }
    }
}
