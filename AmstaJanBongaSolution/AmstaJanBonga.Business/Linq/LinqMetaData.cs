///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Linq;
using System.Collections.Generic;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

using AmstaJanBonga.Business;
using AmstaJanBonga.Business.DaoClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.FactoryClasses;
using AmstaJanBonga.Business.HelperClasses;
using AmstaJanBonga.Business.RelationClasses;

namespace AmstaJanBonga.Business.Linq
{
	/// <summary>Meta-data class for the construction of Linq queries which are to be executed using LLBLGen Pro code.</summary>
	public partial class LinqMetaData : ILinqMetaData
	{
		#region Class Member Declarations
		private ITransaction _transactionToUse;
		private FunctionMappingStore _customFunctionMappings;
		private Context _contextToUse;
		#endregion
		
		/// <summary>CTor. Using this ctor will leave the transaction object to use empty. This is ok if you're not executing queries created with this
		/// meta data inside a transaction. If you're executing the queries created with this meta-data inside a transaction, either set the Transaction property
		/// on the IQueryable.Provider instance of the created LLBLGenProQuery object prior to execution or use the ctor which accepts a transaction object.</summary>
		public LinqMetaData() : this(null, null)
		{
		}
		
		/// <summary>CTor. If you're executing the queries created with this meta-data inside a transaction, pass a live ITransaction object to this ctor.</summary>
		/// <param name="transactionToUse">the transaction to use in queries created with this meta-data</param>
		/// <remarks> Be aware that the ITransaction object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(ITransaction transactionToUse) : this(transactionToUse, null)
		{
		}
		
		/// <summary>CTor. If you're executing the queries created with this meta-data inside a transaction, pass a live ITransaction object to this ctor.</summary>
		/// <param name="transactionToUse">the transaction to use in queries created with this meta-data</param>
		/// <param name="customFunctionMappings">The custom function mappings to use. These take higher precedence than the ones in the DQE to use.</param>
		/// <remarks> Be aware that the ITransaction object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(ITransaction transactionToUse, FunctionMappingStore customFunctionMappings)
		{
			_transactionToUse = transactionToUse;
			_customFunctionMappings = customFunctionMappings;
		}
		
		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <param name="typeOfEntity">the type of the entity to get the datasource for</param>
		/// <returns>the requested datasource</returns>
		public IDataSource GetQueryableForEntity(int typeOfEntity)
		{
			IDataSource toReturn = null;
			switch((AmstaJanBonga.Business.EntityType)typeOfEntity)
			{
				case AmstaJanBonga.Business.EntityType.EmployeeEntity:
					toReturn = this.Employee;
					break;
				case AmstaJanBonga.Business.EntityType.IpEntity:
					toReturn = this.Ip;
					break;
				case AmstaJanBonga.Business.EntityType.LivingroomEntity:
					toReturn = this.Livingroom;
					break;
				case AmstaJanBonga.Business.EntityType.LivingroomChoreEventEntity:
					toReturn = this.LivingroomChoreEvent;
					break;
				case AmstaJanBonga.Business.EntityType.LivingroomGeneralEntity:
					toReturn = this.LivingroomGeneral;
					break;
				case AmstaJanBonga.Business.EntityType.LivingroomGeneralEventEntity:
					toReturn = this.LivingroomGeneralEvent;
					break;
				case AmstaJanBonga.Business.EntityType.LivingroomShiftEventEntity:
					toReturn = this.LivingroomShiftEvent;
					break;
				case AmstaJanBonga.Business.EntityType.PatientEntity:
					toReturn = this.Patient;
					break;
				case AmstaJanBonga.Business.EntityType.UserEntity:
					toReturn = this.User;
					break;
				case AmstaJanBonga.Business.EntityType.UserRoleEntity:
					toReturn = this.UserRole;
					break;
				default:
					toReturn = null;
					break;
			}
			return toReturn;
		}

		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <typeparam name="TEntity">the type of the entity to get the datasource for</typeparam>
		/// <returns>the requested datasource</returns>
		public DataSource<TEntity> GetQueryableForEntity<TEntity>()
			    where TEntity : class
		{
    		return new DataSource<TEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse);
		}

		/// <summary>returns the datasource to use in a Linq query when targeting EmployeeEntity instances in the database.</summary>
		public DataSource<EmployeeEntity> Employee
		{
			get { return new DataSource<EmployeeEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting IpEntity instances in the database.</summary>
		public DataSource<IpEntity> Ip
		{
			get { return new DataSource<IpEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting LivingroomEntity instances in the database.</summary>
		public DataSource<LivingroomEntity> Livingroom
		{
			get { return new DataSource<LivingroomEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting LivingroomChoreEventEntity instances in the database.</summary>
		public DataSource<LivingroomChoreEventEntity> LivingroomChoreEvent
		{
			get { return new DataSource<LivingroomChoreEventEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting LivingroomGeneralEntity instances in the database.</summary>
		public DataSource<LivingroomGeneralEntity> LivingroomGeneral
		{
			get { return new DataSource<LivingroomGeneralEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting LivingroomGeneralEventEntity instances in the database.</summary>
		public DataSource<LivingroomGeneralEventEntity> LivingroomGeneralEvent
		{
			get { return new DataSource<LivingroomGeneralEventEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting LivingroomShiftEventEntity instances in the database.</summary>
		public DataSource<LivingroomShiftEventEntity> LivingroomShiftEvent
		{
			get { return new DataSource<LivingroomShiftEventEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting PatientEntity instances in the database.</summary>
		public DataSource<PatientEntity> Patient
		{
			get { return new DataSource<PatientEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting UserEntity instances in the database.</summary>
		public DataSource<UserEntity> User
		{
			get { return new DataSource<UserEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting UserRoleEntity instances in the database.</summary>
		public DataSource<UserRoleEntity> UserRole
		{
			get { return new DataSource<UserRoleEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}

		#region Class Property Declarations
		/// <summary> Gets / sets the ITransaction to use for the queries created with this meta data object.</summary>
		/// <remarks> Be aware that the ITransaction object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public ITransaction TransactionToUse
		{
			get { return _transactionToUse;}
			set { _transactionToUse = value;}
		}

		/// <summary>Gets or sets the custom function mappings to use. These take higher precedence than the ones in the DQE to use</summary>
		public FunctionMappingStore CustomFunctionMappings
		{
			get { return _customFunctionMappings; }
			set { _customFunctionMappings = value; }
		}
		
		/// <summary>Gets or sets the Context instance to use for entity fetches.</summary>
		public Context ContextToUse
		{
			get { return _contextToUse;}
			set { _contextToUse = value;}
		}
		#endregion
	}
}