using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using TestAbstractionsApplication.Common.Employer.Types.Models;
using TestAbstractionsApplication.Common.Types.DataModels;
using TestAbstractionsApplication.Common.Types.DataModels.BaseModels;

namespace TestAbstractionsApplication.Common.Employer.Types
{
	[DataContract]
	public class EmployerData : IData
    {
		[DataMember(Name = "id")]
		public Guid Id { get; set; }


		[IgnoreDataMember]
		[JsonIgnore]
		private TypedDataHelperContainer<EmployerDataModel> _DataContainer = new TypedDataHelperContainer<EmployerDataModel>();

		[IgnoreDataMember]
		[JsonIgnore]
		public EmployerDataModel DataModelTyped
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