///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Runtime.Serialization;
using AmstaJanBonga.Business;
using AmstaJanBonga.Business.HelperClasses;
using AmstaJanBonga.Business.DaoClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.FactoryClasses;
using AmstaJanBonga.Business.StoredProcedureCallerClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AmstaJanBonga.Business.TypedViewClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces 
	// __LLBLGENPRO_USER_CODE_REGION_END 
	/// <summary>Typed datatable for the view 'GetAllEventsByDateAndByPatientIdResult'.</summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class GetAllEventsByDateAndByPatientIdResultTypedView : TypedViewBase<GetAllEventsByDateAndByPatientIdResultRow>
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView 
	// __LLBLGENPRO_USER_CODE_REGION_END 
	{
		#region Class Member Declarations
		private DataColumn _columnId;
		private DataColumn _columnTitle;
		private DataColumn _columnLocation;
		private DataColumn _columnTimeStart;
		private DataColumn _columnTimeEnd;
		private DataColumn _columnDescription;
		private DataColumn _columnIsMarkedAsDeleted;
		private DataColumn _columnDateCreated;
		private DataColumn _columnDateLastModified;
		private DataColumn _columnDateLastModifiedByUserId;
		private DataColumn _columnDateDeleted;
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers 
	// __LLBLGENPRO_USER_CODE_REGION_END 
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		private const int AmountOfFields = 11;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static GetAllEventsByDateAndByPatientIdResultTypedView()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public GetAllEventsByDateAndByPatientIdResultTypedView():base("GetAllEventsByDateAndByPatientIdResult")
		{
			InitClass();
		}
		
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected GetAllEventsByDateAndByPatientIdResultTypedView(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}

		/// <summary>Fills itself with data obtained from the resultset this typedview is mapped on.</summary>
		/// <param name="transactionToUse">The transaction to use.</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill(ITransaction transactionToUse, System.Int32 unix, System.Int32 patientId)
		{
			return RetrievalProcedures.FetchGetAllEventsByDateAndByPatientIdResultTypedView(transactionToUse, GetFields(), this, unix, patientId);
		}

		/// <summary>Gets the fields of this typed view</summary>
		/// <returns>IEntityFields object</returns>
		public virtual IEntityFields GetFields()
		{
			return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.GetAllEventsByDateAndByPatientIdResultTypedView);
		}

		/// <summary>Creates a new typed row during the build of the datatable during a Fill session by a dataadapter.</summary>
		/// <param name="rowBuilder">supplied row builder to pass to the typed row</param>
		/// <returns>the new typed datarow</returns>
		protected override DataRow NewRowFromBuilder(DataRowBuilder rowBuilder) 
		{
			return new GetAllEventsByDateAndByPatientIdResultRow(rowBuilder);
		}

		/// <summary>Initializes the hashtables for the typed view type and typed view field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Hashtable();
			_fieldsCustomProperties = new Hashtable();
			Hashtable fieldHashtable;
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Id", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Title", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Location", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("TimeStart", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("TimeEnd", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("IsMarkedAsDeleted", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("DateCreated", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("DateLastModified", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("DateLastModifiedByUserId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("DateDeleted", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		protected override void InitClass()
		{
			TableName = "GetAllEventsByDateAndByPatientIdResult";
			_columnId = GeneralUtils.CreateTypedDataTableColumn("Id", @"Id", typeof(System.Int32), this.Columns);
			_columnTitle = GeneralUtils.CreateTypedDataTableColumn("Title", @"Title", typeof(System.String), this.Columns);
			_columnLocation = GeneralUtils.CreateTypedDataTableColumn("Location", @"Location", typeof(System.String), this.Columns);
			_columnTimeStart = GeneralUtils.CreateTypedDataTableColumn("TimeStart", @"TimeStart", typeof(System.Int32), this.Columns);
			_columnTimeEnd = GeneralUtils.CreateTypedDataTableColumn("TimeEnd", @"TimeEnd", typeof(System.Int32), this.Columns);
			_columnDescription = GeneralUtils.CreateTypedDataTableColumn("Description", @"Description", typeof(System.String), this.Columns);
			_columnIsMarkedAsDeleted = GeneralUtils.CreateTypedDataTableColumn("IsMarkedAsDeleted", @"IsMarkedAsDeleted", typeof(System.Boolean), this.Columns);
			_columnDateCreated = GeneralUtils.CreateTypedDataTableColumn("DateCreated", @"DateCreated", typeof(System.DateTime), this.Columns);
			_columnDateLastModified = GeneralUtils.CreateTypedDataTableColumn("DateLastModified", @"DateLastModified", typeof(System.DateTime), this.Columns);
			_columnDateLastModifiedByUserId = GeneralUtils.CreateTypedDataTableColumn("DateLastModifiedByUserId", @"DateLastModifiedByUserId", typeof(System.Int32), this.Columns);
			_columnDateDeleted = GeneralUtils.CreateTypedDataTableColumn("DateDeleted", @"DateDeleted", typeof(System.DateTime), this.Columns);
	// __LLBLGENPRO_USER_CODE_REGION_START InitClass 
	// __LLBLGENPRO_USER_CODE_REGION_END 
			OnInitialized();
		}

		/// <summary>Initializes the members, after a clone action.</summary>
		private void InitMembers()
		{
			_columnId = this.Columns["Id"];
			_columnTitle = this.Columns["Title"];
			_columnLocation = this.Columns["Location"];
			_columnTimeStart = this.Columns["TimeStart"];
			_columnTimeEnd = this.Columns["TimeEnd"];
			_columnDescription = this.Columns["Description"];
			_columnIsMarkedAsDeleted = this.Columns["IsMarkedAsDeleted"];
			_columnDateCreated = this.Columns["DateCreated"];
			_columnDateLastModified = this.Columns["DateLastModified"];
			_columnDateLastModifiedByUserId = this.Columns["DateLastModifiedByUserId"];
			_columnDateDeleted = this.Columns["DateDeleted"];
	// __LLBLGENPRO_USER_CODE_REGION_START InitMembers 
	// __LLBLGENPRO_USER_CODE_REGION_END 
		}

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			GetAllEventsByDateAndByPatientIdResultTypedView cloneToReturn = ((GetAllEventsByDateAndByPatientIdResultTypedView)(base.Clone()));
			cloneToReturn.InitMembers();
			return cloneToReturn;
		}

		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new GetAllEventsByDateAndByPatientIdResultTypedView();
		}

		#region Class Property Declarations
		/// <summary>The custom properties for this TypedView type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public static Hashtable CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary>The custom properties for the type of this TypedView instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[System.ComponentModel.Browsable(false)]
		public virtual Hashtable CustomPropertiesOfType
		{
			get { return GetAllEventsByDateAndByPatientIdResultTypedView.CustomProperties;}
		}

		/// <summary>The custom properties for the fields of this TypedView type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public static Hashtable FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary>The custom properties for the fields of the type of this TypedView instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[System.ComponentModel.Browsable(false)]
		public virtual Hashtable FieldsCustomPropertiesOfType
		{
			get { return GetAllEventsByDateAndByPatientIdResultTypedView.FieldsCustomProperties;}
		}
		
		/// <summary>Returns the column object belonging to the TypedView field 'Id'</summary>
		internal DataColumn IdColumn 
		{
			get { return _columnId; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'Title'</summary>
		internal DataColumn TitleColumn 
		{
			get { return _columnTitle; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'Location'</summary>
		internal DataColumn LocationColumn 
		{
			get { return _columnLocation; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'TimeStart'</summary>
		internal DataColumn TimeStartColumn 
		{
			get { return _columnTimeStart; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'TimeEnd'</summary>
		internal DataColumn TimeEndColumn 
		{
			get { return _columnTimeEnd; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'Description'</summary>
		internal DataColumn DescriptionColumn 
		{
			get { return _columnDescription; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'IsMarkedAsDeleted'</summary>
		internal DataColumn IsMarkedAsDeletedColumn 
		{
			get { return _columnIsMarkedAsDeleted; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'DateCreated'</summary>
		internal DataColumn DateCreatedColumn 
		{
			get { return _columnDateCreated; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'DateLastModified'</summary>
		internal DataColumn DateLastModifiedColumn 
		{
			get { return _columnDateLastModified; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'DateLastModifiedByUserId'</summary>
		internal DataColumn DateLastModifiedByUserIdColumn 
		{
			get { return _columnDateLastModifiedByUserId; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'DateDeleted'</summary>
		internal DataColumn DateDeletedColumn 
		{
			get { return _columnDateDeleted; }
		}
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalColumnProperties 
	// __LLBLGENPRO_USER_CODE_REGION_END 
 		#endregion
		
		#region Custom Typed View code
	// __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewCode 
	// __LLBLGENPRO_USER_CODE_REGION_END 
		#endregion

		#region Included Code

		#endregion
	}


	/// <summary>Typed datarow for the typed datatable GetAllEventsByDateAndByPatientIdResult</summary>
	public partial class GetAllEventsByDateAndByPatientIdResultRow : DataRow
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow 
	// __LLBLGENPRO_USER_CODE_REGION_END 
	{
		#region Class Member Declarations
		private GetAllEventsByDateAndByPatientIdResultTypedView	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal GetAllEventsByDateAndByPatientIdResultRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((GetAllEventsByDateAndByPatientIdResultTypedView)(this.Table));
		}

		#region Class Property Declarations
		/// <summary>Gets / sets the value of the TypedView field Id</summary>
		/// <remarks>Mapped on view field: "Resultset1"."Id"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 Id
		{
			get { return IsIdNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.IdColumn]; }
			set { this[_parent.IdColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field Id is NULL, false otherwise.</summary>
		public bool IsIdNull() 
		{
			return IsNull(_parent.IdColumn);
		}

		/// <summary>Sets the TypedView field Id to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetIdNull() 
		{
			this[_parent.IdColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field Title</summary>
		/// <remarks>Mapped on view field: "Resultset1"."Title"<br/>
		/// View field characteristics (type, precision, scale, length): VarChar, 0, 0, 50</remarks>
		public System.String Title
		{
			get { return IsTitleNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.TitleColumn]; }
			set { this[_parent.TitleColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field Title is NULL, false otherwise.</summary>
		public bool IsTitleNull() 
		{
			return IsNull(_parent.TitleColumn);
		}

		/// <summary>Sets the TypedView field Title to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetTitleNull() 
		{
			this[_parent.TitleColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field Location</summary>
		/// <remarks>Mapped on view field: "Resultset1"."Location"<br/>
		/// View field characteristics (type, precision, scale, length): VarChar, 0, 0, 50</remarks>
		public System.String Location
		{
			get { return IsLocationNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.LocationColumn]; }
			set { this[_parent.LocationColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field Location is NULL, false otherwise.</summary>
		public bool IsLocationNull() 
		{
			return IsNull(_parent.LocationColumn);
		}

		/// <summary>Sets the TypedView field Location to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetLocationNull() 
		{
			this[_parent.LocationColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field TimeStart</summary>
		/// <remarks>Mapped on view field: "Resultset1"."TimeStart"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 TimeStart
		{
			get { return IsTimeStartNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.TimeStartColumn]; }
			set { this[_parent.TimeStartColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field TimeStart is NULL, false otherwise.</summary>
		public bool IsTimeStartNull() 
		{
			return IsNull(_parent.TimeStartColumn);
		}

		/// <summary>Sets the TypedView field TimeStart to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetTimeStartNull() 
		{
			this[_parent.TimeStartColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field TimeEnd</summary>
		/// <remarks>Mapped on view field: "Resultset1"."TimeEnd"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 TimeEnd
		{
			get { return IsTimeEndNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.TimeEndColumn]; }
			set { this[_parent.TimeEndColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field TimeEnd is NULL, false otherwise.</summary>
		public bool IsTimeEndNull() 
		{
			return IsNull(_parent.TimeEndColumn);
		}

		/// <summary>Sets the TypedView field TimeEnd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetTimeEndNull() 
		{
			this[_parent.TimeEndColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field Description</summary>
		/// <remarks>Mapped on view field: "Resultset1"."Description"<br/>
		/// View field characteristics (type, precision, scale, length): VarChar, 0, 0, 500</remarks>
		public System.String Description
		{
			get { return IsDescriptionNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.DescriptionColumn]; }
			set { this[_parent.DescriptionColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field Description is NULL, false otherwise.</summary>
		public bool IsDescriptionNull() 
		{
			return IsNull(_parent.DescriptionColumn);
		}

		/// <summary>Sets the TypedView field Description to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetDescriptionNull() 
		{
			this[_parent.DescriptionColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field IsMarkedAsDeleted</summary>
		/// <remarks>Mapped on view field: "Resultset1"."IsMarkedAsDeleted"<br/>
		/// View field characteristics (type, precision, scale, length): Bit, 0, 0, 0</remarks>
		public System.Boolean IsMarkedAsDeleted
		{
			get { return IsIsMarkedAsDeletedNull() ? (System.Boolean)TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)) : (System.Boolean)this[_parent.IsMarkedAsDeletedColumn]; }
			set { this[_parent.IsMarkedAsDeletedColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field IsMarkedAsDeleted is NULL, false otherwise.</summary>
		public bool IsIsMarkedAsDeletedNull() 
		{
			return IsNull(_parent.IsMarkedAsDeletedColumn);
		}

		/// <summary>Sets the TypedView field IsMarkedAsDeleted to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetIsMarkedAsDeletedNull() 
		{
			this[_parent.IsMarkedAsDeletedColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field DateCreated</summary>
		/// <remarks>Mapped on view field: "Resultset1"."DateCreated"<br/>
		/// View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0</remarks>
		public System.DateTime DateCreated
		{
			get { return IsDateCreatedNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.DateCreatedColumn]; }
			set { this[_parent.DateCreatedColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field DateCreated is NULL, false otherwise.</summary>
		public bool IsDateCreatedNull() 
		{
			return IsNull(_parent.DateCreatedColumn);
		}

		/// <summary>Sets the TypedView field DateCreated to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetDateCreatedNull() 
		{
			this[_parent.DateCreatedColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field DateLastModified</summary>
		/// <remarks>Mapped on view field: "Resultset1"."DateLastModified"<br/>
		/// View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0</remarks>
		public System.DateTime DateLastModified
		{
			get { return IsDateLastModifiedNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.DateLastModifiedColumn]; }
			set { this[_parent.DateLastModifiedColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field DateLastModified is NULL, false otherwise.</summary>
		public bool IsDateLastModifiedNull() 
		{
			return IsNull(_parent.DateLastModifiedColumn);
		}

		/// <summary>Sets the TypedView field DateLastModified to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetDateLastModifiedNull() 
		{
			this[_parent.DateLastModifiedColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field DateLastModifiedByUserId</summary>
		/// <remarks>Mapped on view field: "Resultset1"."DateLastModifiedByUserId"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 DateLastModifiedByUserId
		{
			get { return IsDateLastModifiedByUserIdNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.DateLastModifiedByUserIdColumn]; }
			set { this[_parent.DateLastModifiedByUserIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field DateLastModifiedByUserId is NULL, false otherwise.</summary>
		public bool IsDateLastModifiedByUserIdNull() 
		{
			return IsNull(_parent.DateLastModifiedByUserIdColumn);
		}

		/// <summary>Sets the TypedView field DateLastModifiedByUserId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetDateLastModifiedByUserIdNull() 
		{
			this[_parent.DateLastModifiedByUserIdColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field DateDeleted</summary>
		/// <remarks>Mapped on view field: "Resultset1"."DateDeleted"<br/>
		/// View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0</remarks>
		public System.DateTime DateDeleted
		{
			get { return IsDateDeletedNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.DateDeletedColumn]; }
			set { this[_parent.DateDeletedColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field DateDeleted is NULL, false otherwise.</summary>
		public bool IsDateDeletedNull() 
		{
			return IsNull(_parent.DateDeletedColumn);
		}

		/// <summary>Sets the TypedView field DateDeleted to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetDateDeletedNull() 
		{
			this[_parent.DateDeletedColumn] = System.Convert.DBNull;
		}
		
		#endregion
		
		#region Custom Typed View Row Code
	// __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode 
	// __LLBLGENPRO_USER_CODE_REGION_END 
		#endregion
		
		#region Included Row Code

		#endregion		
	}
}
