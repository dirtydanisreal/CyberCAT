
using CyberCAT.Core.Classes.Mapping.Global;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("DropPointMappinRegistrationData")]
    public class DropPointMappinRegistrationData : IScriptable
    {
        [RealName("ownerID")]
        public EntEntityID OwnerID { get; set; }
        
        [RealName("position")]
        public Vector4 Position { get; set; }
        
        [RealName("mapinID")]
        public GameNewMappinID MapinID { get; set; }
        
        [RealName("trackingAlternativeMappinID")]
        public GameNewMappinID TrackingAlternativeMappinID { get; set; }
    }
}
