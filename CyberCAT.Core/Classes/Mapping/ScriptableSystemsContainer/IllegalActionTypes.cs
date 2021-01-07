using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("IllegalActionTypes")]
    public class IllegalActionTypes : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("regularActions")]
        [RealType("Bool")]
        public bool RegularActions { get; set; }
        
        [RealName("quickHacks")]
        [RealType("Bool")]
        public bool QuickHacks { get; set; }
        
        [RealName("skillChecks")]
        [RealType("Bool")]
        public bool SkillChecks { get; set; }
    }
}