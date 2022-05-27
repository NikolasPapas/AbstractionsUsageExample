using System.Runtime.Serialization;

namespace TestAbstractionsApplication.Common.Types.DataModels.BaseModels
{
    [DataContract]
    public class BaseAddress
    {
        [DataMember(Name = "country")]
        public string Country { get; set; }

        [DataMember(Name = "street")]
        public string Street { get; set; }

        [DataMember(Name = "postalCode")]
        public string ZipCode { get; set; }

        [DataMember(Name = "number")]
        public int Number { get; set; }

        [DataMember(Name = "isActive")]
        public bool IsActive
        {
            get
            {
                return ActiveFrom < DateTime.Now.Date && DateTime.Now.Date < ActiveTo;
            }
        }

        [DataMember(Name = "activeFrom")]
        public DateTime ActiveFrom { get; set; }

        [DataMember(Name = "activeTo")]
        public DateTime ActiveTo { get; set; }
    }
}
