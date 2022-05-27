using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using TestAbstractionsApplication.Common.Types.DataModels.BaseModels;

namespace TestAbstractionsApplication.Common.Employer.Types.Models
{
    [DataContract]
    public class EmployerDataModel : BaseDataModel
    {
        [DataMember(Name = "name")]
        public override string Name { get; set; }

        [DataMember(Name = "createOn")]
        public override DateTime CreateOn { get; set; }

        [IgnoreDataMember]
        [JsonIgnore]
        public override BaseAddress Address
        {
            get { return AddressTyped; }
            set
            {
                if (value != null && !(value is EmployerAddress))
                    throw new ArgumentException($"Incorrect type provided. Expected: {typeof(EmployerAddress).Name}.", nameof(BaseAddress));
                AddressTyped = value as EmployerAddress;
            }
        }

        [DataMember(Name = "address")]
        public EmployerAddress AddressTyped { get; set; }
    }
}
