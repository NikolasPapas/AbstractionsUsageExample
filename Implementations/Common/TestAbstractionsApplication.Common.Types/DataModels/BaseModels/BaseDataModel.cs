using System.Runtime.Serialization;

namespace TestAbstractionsApplication.Common.Types.DataModels.BaseModels
{
    [DataContract]
    public abstract class BaseDataModel
    {

        [DataMember(Name = "name")]
        public abstract string Name { get; set; }

        [DataMember(Name = "createOn")]
        public abstract DateTime CreateOn { get; set; }

        [DataMember(Name = "address")]
        public abstract BaseAddress Address { get; set; }
    }
}
