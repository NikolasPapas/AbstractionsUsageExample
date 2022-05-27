using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using TestAbstractionsApplication.Common.Types.DataModels.BaseModels;

namespace TestAbstractionsApplication.Common.Customer.Types.Models
{
    [DataContract]
    public class CustomerDataModel : BaseDataModel
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
                if (value != null && !(value is CustomerAddress))
                    throw new ArgumentException($"Incorrect type provided. Expected: {typeof(CustomerAddress).Name}.", nameof(BaseAddress));
                AddressTyped = value as CustomerAddress;
            }
        }

        [DataMember(Name = "address")]
        public CustomerAddress AddressTyped { get; set; }
    }
}
