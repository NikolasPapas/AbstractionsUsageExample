using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TestAbstractionsApplication.Common.Types.DataModels.BaseModels;

namespace TestAbstractionsApplication.Common.Company.Types.Models
{
    [DataContract]
    public class CompanyDataModel : BaseDataModel
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
                if (value != null && !(value is CompanyAddress))
                    throw new ArgumentException($"Incorrect type provided. Expected: {typeof(CompanyAddress).Name}.", nameof(BaseAddress));
                AddressTyped = value as CompanyAddress;
            }
        }

        [DataMember(Name = "address")]
        public CompanyAddress AddressTyped { get; set; }
    }
}
