using System.Runtime.Serialization;
using TestAbstractionsApplication.Common.Types.DataModels.BaseModels;

namespace TestAbstractionsApplication.Common.Customer.Types.Models
{
    [DataContract]
    public class CustomerAddress : BaseAddress
    {
        [DataMember(Name = "isPermanentAddress")]
        public bool IsPermanentAddress { get; set; }

        [DataMember(Name = "personsInApartment")]
        public int PersonsInApartment { get; set; }
    }
}
