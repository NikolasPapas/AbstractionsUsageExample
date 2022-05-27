using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using TestAbstractionsApplication.Common.Company.Types.Models;
using TestAbstractionsApplication.Common.Types.DataModels;
using TestAbstractionsApplication.Common.Types.DataModels.BaseModels;

namespace TestAbstractionsApplication.Common.Company.Types
{
	[DataContract]
	public class CompanyData : IData
    {
		[DataMember(Name = "id")]
		public Guid Id { get; set; }
        

		[IgnoreDataMember]
		[JsonIgnore]
		private TypedDataHelperContainer<CompanyDataModel> _DataContainer = new TypedDataHelperContainer<CompanyDataModel>();

		[IgnoreDataMember]
		[JsonIgnore]
		public CompanyDataModel DataModelTyped
		{
			get { return _DataContainer.DataTyped; }
			set { _DataContainer.DataTyped = value; }
		}

		[IgnoreDataMember]
		[JsonIgnore]
		BaseDataModel IData.DataModelTyped
		{
			get { return _DataContainer.DataTyped; }
		}

		[DataMember(Name = "dataModel")]
		public object DataModel
		{
			get => _DataContainer.Data;
			set => _DataContainer.Data = value;
		}
	}
}