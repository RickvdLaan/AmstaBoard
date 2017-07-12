///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Data;
using System.Xml.Serialization;
using AmstaJanBonga.Business;
using AmstaJanBonga.Business.FactoryClasses;
using AmstaJanBonga.Business.DaoClasses;
using AmstaJanBonga.Business.RelationClasses;
using AmstaJanBonga.Business.HelperClasses;
using AmstaJanBonga.Business.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AmstaJanBonga.Business.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'User'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class UserEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AmstaJanBonga.Business.CollectionClasses.EmployeeCollection	_employees;
		private bool	_alwaysFetchEmployees, _alreadyFetchedEmployees;
		private UserRoleEntity _userRole;
		private bool	_alwaysFetchUserRole, _alreadyFetchedUserRole, _userRoleReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name UserRole</summary>
			public static readonly string UserRole = "UserRole";
			/// <summary>Member name Employees</summary>
			public static readonly string Employees = "Employees";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static UserEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public UserEntity() :base("UserEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="id">PK value for User which data should be fetched into this User object</param>
		public UserEntity(System.Int32 id):base("UserEntity")
		{
			InitClassFetch(id, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for User which data should be fetched into this User object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public UserEntity(System.Int32 id, IPrefetchPath prefetchPathToUse):base("UserEntity")
		{
			InitClassFetch(id, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for User which data should be fetched into this User object</param>
		/// <param name="validator">The custom validator object for this UserEntity</param>
		public UserEntity(System.Int32 id, IValidator validator):base("UserEntity")
		{
			InitClassFetch(id, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected UserEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_employees = (AmstaJanBonga.Business.CollectionClasses.EmployeeCollection)info.GetValue("_employees", typeof(AmstaJanBonga.Business.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployees = info.GetBoolean("_alwaysFetchEmployees");
			_alreadyFetchedEmployees = info.GetBoolean("_alreadyFetchedEmployees");
			_userRole = (UserRoleEntity)info.GetValue("_userRole", typeof(UserRoleEntity));
			if(_userRole!=null)
			{
				_userRole.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_userRoleReturnsNewIfNotFound = info.GetBoolean("_userRoleReturnsNewIfNotFound");
			_alwaysFetchUserRole = info.GetBoolean("_alwaysFetchUserRole");
			_alreadyFetchedUserRole = info.GetBoolean("_alreadyFetchedUserRole");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((UserFieldIndex)fieldIndex)
			{
				case UserFieldIndex.RoleTypeEnum:
					DesetupSyncUserRole(true, false);
					_alreadyFetchedUserRole = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedEmployees = (_employees.Count > 0);
			_alreadyFetchedUserRole = (_userRole != null);
		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "UserRole":
					toReturn.Add(Relations.UserRoleEntityUsingRoleTypeEnum);
					break;
				case "Employees":
					toReturn.Add(Relations.EmployeeEntityUsingUserId);
					break;
				default:
					break;				
			}
			return toReturn;
		}



		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_employees", (!this.MarkedForDeletion?_employees:null));
			info.AddValue("_alwaysFetchEmployees", _alwaysFetchEmployees);
			info.AddValue("_alreadyFetchedEmployees", _alreadyFetchedEmployees);
			info.AddValue("_userRole", (!this.MarkedForDeletion?_userRole:null));
			info.AddValue("_userRoleReturnsNewIfNotFound", _userRoleReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchUserRole", _alwaysFetchUserRole);
			info.AddValue("_alreadyFetchedUserRole", _alreadyFetchedUserRole);

			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "UserRole":
					_alreadyFetchedUserRole = true;
					this.UserRole = (UserRoleEntity)entity;
					break;
				case "Employees":
					_alreadyFetchedEmployees = true;
					if(entity!=null)
					{
						this.Employees.Add((EmployeeEntity)entity);
					}
					break;
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "UserRole":
					SetupSyncUserRole(relatedEntity);
					break;
				case "Employees":
					_employees.Add((EmployeeEntity)relatedEntity);
					break;
				default:
					break;
			}
		}
		
		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "UserRole":
					DesetupSyncUserRole(false, true);
					break;
				case "Employees":
					this.PerformRelatedEntityRemoval(_employees, relatedEntity, signalRelatedEntityManyToOne);
					break;
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		protected override List<IEntity> GetDependingRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		protected override List<IEntity> GetDependentRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			if(_userRole!=null)
			{
				toReturn.Add(_userRole);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_employees);

			return toReturn;
		}

		/// <summary> Method which will try to fetch the contents for this entity using a unique constraint. </summary>
		/// <remarks>All contents of the entity is lost.</remarks>
		/// <param name="username">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCUsername(System.String username)
		{
			return FetchUsingUCUsername( username, null, null, null);
		}

		/// <summary> Method which will try to fetch the contents for this entity using a unique constraint. </summary>
		/// <remarks>All contents of the entity is lost.</remarks>
		/// <param name="username">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCUsername(System.String username, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingUCUsername( username, prefetchPathToUse, null, null);
		}
	
		/// <summary> Method which will try to fetch the contents for this entity using a unique constraint. </summary>
		/// <remarks>All contents of the entity is lost.</remarks>
		/// <param name="username">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCUsername(System.String username, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingUCUsername( username, prefetchPathToUse, contextToUse, null);
		}
	
		/// <summary> Method which will try to fetch the contents for this entity using a unique constraint. </summary>
		/// <remarks>All contents of the entity is lost.</remarks>
		/// <param name="username">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCUsername(System.String username, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				((UserDAO)CreateDAOInstance()).FetchUserUsingUCUsername(this, this.Transaction, username, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (this.Fields.State == EntityState.Fetched);
			}
			finally
			{
				OnFetchComplete();
			}
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for User which data should be fetched into this User object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id)
		{
			return FetchUsingPK(id, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for User which data should be fetched into this User object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for User which data should be fetched into this User object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for User which data should be fetched into this User object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(id, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.Id, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new UserRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public AmstaJanBonga.Business.CollectionClasses.EmployeeCollection GetMultiEmployees(bool forceFetch)
		{
			return GetMultiEmployees(forceFetch, _employees.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public AmstaJanBonga.Business.CollectionClasses.EmployeeCollection GetMultiEmployees(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiEmployees(forceFetch, _employees.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AmstaJanBonga.Business.CollectionClasses.EmployeeCollection GetMultiEmployees(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiEmployees(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AmstaJanBonga.Business.CollectionClasses.EmployeeCollection GetMultiEmployees(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployees || forceFetch || _alwaysFetchEmployees) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_employees);
				_employees.SuppressClearInGetMulti=!forceFetch;
				_employees.EntityFactoryToUse = entityFactoryToUse;
				_employees.GetMultiManyToOne(null, this, filter);
				_employees.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployees = true;
			}
			return _employees;
		}

		/// <summary> Sets the collection parameters for the collection for 'Employees'. These settings will be taken into account
		/// when the property Employees is requested or GetMultiEmployees is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployees(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employees.SortClauses=sortClauses;
			_employees.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'UserRoleEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'UserRoleEntity' which is related to this entity.</returns>
		public UserRoleEntity GetSingleUserRole()
		{
			return GetSingleUserRole(false);
		}

		/// <summary> Retrieves the related entity of type 'UserRoleEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'UserRoleEntity' which is related to this entity.</returns>
		public virtual UserRoleEntity GetSingleUserRole(bool forceFetch)
		{
			if( ( !_alreadyFetchedUserRole || forceFetch || _alwaysFetchUserRole) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.UserRoleEntityUsingRoleTypeEnum);
				UserRoleEntity newEntity = new UserRoleEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.RoleTypeEnum);
				}
				if(fetchResult)
				{
					newEntity = (UserRoleEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_userRoleReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.UserRole = newEntity;
				_alreadyFetchedUserRole = fetchResult;
			}
			return _userRole;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("UserRole", _userRole);
			toReturn.Add("Employees", _employees);
			return toReturn;
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		private void InitClassEmpty(IValidator validatorToUse)
		{
			OnInitializing();
			this.Fields = CreateFields();
			this.Validator = validatorToUse;
			InitClassMembers();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="id">PK value for User which data should be fetched into this User object</param>
		/// <param name="validator">The validator object for this UserEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 id, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(id, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_employees = new AmstaJanBonga.Business.CollectionClasses.EmployeeCollection();
			_employees.SetContainingEntityInfo(this, "User");
			_userRoleReturnsNewIfNotFound = false;
			PerformDependencyInjection();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateCreated", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateDeleted", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateLastLogin", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateLastModified", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateLastModifiedByUserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Id", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsMarkedAsDeleted", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Iterations", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Password", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("RoleTypeEnum", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Salt", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Username", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _userRole</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUserRole(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _userRole, new PropertyChangedEventHandler( OnUserRolePropertyChanged ), "UserRole", AmstaJanBonga.Business.RelationClasses.StaticUserRelations.UserRoleEntityUsingRoleTypeEnumStatic, true, signalRelatedEntity, "Users", resetFKFields, new int[] { (int)UserFieldIndex.RoleTypeEnum } );		
			_userRole = null;
		}
		
		/// <summary> setups the sync logic for member _userRole</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUserRole(IEntityCore relatedEntity)
		{
			if(_userRole!=relatedEntity)
			{		
				DesetupSyncUserRole(true, true);
				_userRole = (UserRoleEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _userRole, new PropertyChangedEventHandler( OnUserRolePropertyChanged ), "UserRole", AmstaJanBonga.Business.RelationClasses.StaticUserRelations.UserRoleEntityUsingRoleTypeEnumStatic, true, ref _alreadyFetchedUserRole, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnUserRolePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="id">PK value for User which data should be fetched into this User object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)UserFieldIndex.Id].ForcedCurrentValueWrite(id);
				CreateDAOInstance().FetchExisting(this, this.Transaction, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (this.Fields.State == EntityState.Fetched);
			}
			finally
			{
				OnFetchComplete();
			}
		}

		/// <summary> Creates the DAO instance for this type</summary>
		/// <returns></returns>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateUserDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new UserEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static UserRelations Relations
		{
			get	{ return new UserRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployees
		{
			get { return new PrefetchPathElement(new AmstaJanBonga.Business.CollectionClasses.EmployeeCollection(), (IEntityRelation)GetRelationsForField("Employees")[0], (int)AmstaJanBonga.Business.EntityType.UserEntity, (int)AmstaJanBonga.Business.EntityType.EmployeeEntity, 0, null, null, null, "Employees", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UserRole'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserRole
		{
			get	{ return new PrefetchPathElement(new AmstaJanBonga.Business.CollectionClasses.UserRoleCollection(), (IEntityRelation)GetRelationsForField("UserRole")[0], (int)AmstaJanBonga.Business.EntityType.UserEntity, (int)AmstaJanBonga.Business.EntityType.UserRoleEntity, 0, null, null, null, "UserRole", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The DateCreated property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."DateCreated"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DateCreated
		{
			get { return (System.DateTime)GetValue((int)UserFieldIndex.DateCreated, true); }
			set	{ SetValue((int)UserFieldIndex.DateCreated, value, true); }
		}

		/// <summary> The DateDeleted property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."DateDeleted"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateDeleted
		{
			get { return (Nullable<System.DateTime>)GetValue((int)UserFieldIndex.DateDeleted, false); }
			set	{ SetValue((int)UserFieldIndex.DateDeleted, value, true); }
		}

		/// <summary> The DateLastLogin property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."DateLastLogin"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateLastLogin
		{
			get { return (Nullable<System.DateTime>)GetValue((int)UserFieldIndex.DateLastLogin, false); }
			set	{ SetValue((int)UserFieldIndex.DateLastLogin, value, true); }
		}

		/// <summary> The DateLastModified property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."DateLastModified"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateLastModified
		{
			get { return (Nullable<System.DateTime>)GetValue((int)UserFieldIndex.DateLastModified, false); }
			set	{ SetValue((int)UserFieldIndex.DateLastModified, value, true); }
		}

		/// <summary> The DateLastModifiedByUserId property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."DateLastModifiedByUserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> DateLastModifiedByUserId
		{
			get { return (Nullable<System.Int32>)GetValue((int)UserFieldIndex.DateLastModifiedByUserId, false); }
			set	{ SetValue((int)UserFieldIndex.DateLastModifiedByUserId, value, true); }
		}

		/// <summary> The Id property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)UserFieldIndex.Id, true); }
			set	{ SetValue((int)UserFieldIndex.Id, value, true); }
		}

		/// <summary> The IsMarkedAsDeleted property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."IsMarkedAsDeleted"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsMarkedAsDeleted
		{
			get { return (System.Boolean)GetValue((int)UserFieldIndex.IsMarkedAsDeleted, true); }
			set	{ SetValue((int)UserFieldIndex.IsMarkedAsDeleted, value, true); }
		}

		/// <summary> The Iterations property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."Iterations"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 Iterations
		{
			get { return (System.Int32)GetValue((int)UserFieldIndex.Iterations, true); }
			set	{ SetValue((int)UserFieldIndex.Iterations, value, true); }
		}

		/// <summary> The Password property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."Password"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Password
		{
			get { return (System.String)GetValue((int)UserFieldIndex.Password, true); }
			set	{ SetValue((int)UserFieldIndex.Password, value, true); }
		}

		/// <summary> The RoleTypeEnum property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."RoleTypeEnum"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte RoleTypeEnum
		{
			get { return (System.Byte)GetValue((int)UserFieldIndex.RoleTypeEnum, true); }
			set	{ SetValue((int)UserFieldIndex.RoleTypeEnum, value, true); }
		}

		/// <summary> The Salt property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."Salt"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Salt
		{
			get { return (System.String)GetValue((int)UserFieldIndex.Salt, true); }
			set	{ SetValue((int)UserFieldIndex.Salt, value, true); }
		}

		/// <summary> The Username property of the Entity User<br/><br/></summary>
		/// <remarks>Mapped on  table field: "User"."Username"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Username
		{
			get { return (System.String)GetValue((int)UserFieldIndex.Username, true); }
			set	{ SetValue((int)UserFieldIndex.Username, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployees()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AmstaJanBonga.Business.CollectionClasses.EmployeeCollection Employees
		{
			get	{ return GetMultiEmployees(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Employees. When set to true, Employees is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employees is accessed. You can always execute/ a forced fetch by calling GetMultiEmployees(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployees
		{
			get	{ return _alwaysFetchEmployees; }
			set	{ _alwaysFetchEmployees = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Employees already has been fetched. Setting this property to false when Employees has been fetched
		/// will clear the Employees collection well. Setting this property to true while Employees hasn't been fetched disables lazy loading for Employees</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployees
		{
			get { return _alreadyFetchedEmployees;}
			set 
			{
				if(_alreadyFetchedEmployees && !value && (_employees != null))
				{
					_employees.Clear();
				}
				_alreadyFetchedEmployees = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'UserRoleEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleUserRole()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual UserRoleEntity UserRole
		{
			get	{ return GetSingleUserRole(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncUserRole(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Users", "UserRole", _userRole, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for UserRole. When set to true, UserRole is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UserRole is accessed. You can always execute a forced fetch by calling GetSingleUserRole(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUserRole
		{
			get	{ return _alwaysFetchUserRole; }
			set	{ _alwaysFetchUserRole = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UserRole already has been fetched. Setting this property to false when UserRole has been fetched
		/// will set UserRole to null as well. Setting this property to true while UserRole hasn't been fetched disables lazy loading for UserRole</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUserRole
		{
			get { return _alreadyFetchedUserRole;}
			set 
			{
				if(_alreadyFetchedUserRole && !value)
				{
					this.UserRole = null;
				}
				_alreadyFetchedUserRole = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property UserRole is not found
		/// in the database. When set to true, UserRole will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool UserRoleReturnsNewIfNotFound
		{
			get	{ return _userRoleReturnsNewIfNotFound; }
			set { _userRoleReturnsNewIfNotFound = value; }	
		}


		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}

		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		[System.ComponentModel.Browsable(false), XmlIgnore]
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary>Returns the AmstaJanBonga.Business.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)AmstaJanBonga.Business.EntityType.UserEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
