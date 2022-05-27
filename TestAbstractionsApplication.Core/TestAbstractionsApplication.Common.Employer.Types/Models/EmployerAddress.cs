using System.Runtime.Serialization;
using TestAbstractionsApplication.Common.Types.DataModels.BaseModels;

namespace TestAbstractionsApplication.Common.Employer.Types.Models
{
    [DataContract]
    public class EmployerAddress : BaseAddress
    {
        [DataMember(Name = "isWorkingFromHome")]
        public bool IsWorkingFromHome { get; set; }

        [DataMember(Name = "workingHoures")]
        public WorkingHoures WorkingHoures { get; set; }
    }
}
