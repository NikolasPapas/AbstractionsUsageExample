using System.Runtime.Serialization;
using TestAbstractionsApplication.Common.Types.DataModels.BaseModels;

namespace TestAbstractionsApplication.Common.Company.Types.Models
{
    [DataContract]
    public class CompanyAddress : BaseAddress
    {
        [DataMember(Name = "isHeadQuarters")]
        public bool IsHeadQuarters { get; set; }
    }
}
