using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using TestAbstractionsApplication.Common.Customer.Types.Models;
using TestAbstractionsApplication.Common.Types.DataModels;
using TestAbstractionsApplication.Common.Types.DataModels.BaseModels;

namespace TestAbstractionsApplication.Common.Customer.Types
{
	[DataContract]
	public class CustomerData : IData
    {
		[DataMember(Name = "id")]
		public Guid Id { get; set; }
        

		[IgnoreDataMember]
		[JsonIgnore]
		private TypedDataHelperContainer<CustomerDataModel> _DataContainer = new TypedDataHelperContainer<CustomerDataModel>();

		[IgnoreDataMember]
		[JsonIgnore]
		public CustomerDataModel DataModelTyped
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