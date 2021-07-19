////////////////////////////////////////////////////////////
/////   TechDebtAttribute.cs
/////   James McNeil - 2021
////////////////////////////////////////////////////////////

using System;

namespace TechDebtTracker
{
    public class TechDebtAttribute : Attribute
    {
        private string m_name = "";
        private string m_message = "";
        private SeverityLevel m_severity = SeverityLevel.UNSET;
        private GrowthSpeed m_growthSpeed = GrowthSpeed.UNSET;
        
        public TechDebtAttribute() { }

        public virtual string Name
        {
            get => m_name;
            set => m_name = value;
        }

        public virtual string Message
        {
            get => m_message;
            set => m_message = value;
        }

        public virtual SeverityLevel Severity
        {
            get => m_severity;
            set => m_severity = value;
        }

        public virtual GrowthSpeed GrowthSpeed
        {
            get => m_growthSpeed;
            set => m_growthSpeed = value;
        }
    }
}
