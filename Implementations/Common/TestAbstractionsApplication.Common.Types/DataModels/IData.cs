using System.Text.Json.Serialization;
using TestAbstractionsApplication.Common.Types.DataModels.BaseModels;

namespace TestAbstractionsApplication.Common.Types.DataModels
{
    public interface IData
    {
        Guid Id { get; set; }

        //[IgnoreDataMember]
        [JsonIgnore]
        object DataModel { get; set; }

        BaseDataModel DataModelTyped { get; }
    }
}
