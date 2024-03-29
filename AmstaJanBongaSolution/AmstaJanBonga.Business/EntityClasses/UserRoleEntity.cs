﻿///////////////////////////////////////////////////////////////
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

	/// <summary>Entity class which represents the entity 'UserRole'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class UserRoleEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AmstaJanBonga.Business.CollectionClasses.UserCollection	_users;
		private bool	_alwaysFetchUsers, _alreadyFetchedUsers;
		private AmstaJanBonga.Business.CollectionClasses.UserRoleActivityCollection	_userRoleActivities;
		private bool	_alwaysFetchUserRoleActivities, _alreadyFetchedUserRoleActivities;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Users</summary>
			public static readonly string Users = "Users";
			/// <summary>Member name UserRoleActivities</summary>
			public static readonly string UserRoleActivities = "UserRoleActivities";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static UserRoleEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public UserRoleEntity() :base("UserRoleEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="roleTypeEnum">PK value for UserRole which data should be fetched into this UserRole object</param>
		public UserRoleEntity(System.Byte roleTypeEnum):base("UserRoleEntity")
		{
			InitClassFetch(roleTypeEnum, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="roleTypeEnum">PK value for UserRole which data should be fetched into this UserRole object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public UserRoleEntity(System.Byte roleTypeEnum, IPrefetchPath prefetchPathToUse):base("UserRoleEntity")
		{
			InitClassFetch(roleTypeEnum, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="roleTypeEnum">PK value for UserRole which data should be fetched into this UserRole object</param>
		/// <param name="validator">The custom validator object for this UserRoleEntity</param>
		public UserRoleEntity(System.Byte roleTypeEnum, IValidator validator):base("UserRoleEntity")
		{
			InitClassFetch(roleTypeEnum, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected UserRoleEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_users = (AmstaJanBonga.Business.CollectionClasses.UserCollection)info.GetValue("_users", typeof(AmstaJanBonga.Business.CollectionClasses.UserCollection));
			_alwaysFetchUsers = info.GetBoolean("_alwaysFetchUsers");
			_alreadyFetchedUsers = info.GetBoolean("_alreadyFetchedUsers");

			_userRoleActivities = (AmstaJanBonga.Business.CollectionClasses.UserRoleActivityCollection)info.GetValue("_userRoleActivities", typeof(AmstaJanBonga.Business.CollectionClasses.UserRoleActivityCollection));
			_alwaysFetchUserRoleActivities = info.GetBoolean("_alwaysFetchUserRoleActivities");
			_alreadyFetchedUserRoleActivities = info.GetBoolean("_alreadyFetchedUserRoleActivities");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedUsers = (_users.Count > 0);
			_alreadyFetchedUserRoleActivities = (_userRoleActivities.Count > 0);
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
				case "Users":
					toReturn.Add(Relations.UserEntityUsingRoleTypeEnum);
					break;
				case "UserRoleActivities":
					toReturn.Add(Relations.UserRoleActivityEntityUsingRoleTypeEnum);
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
			info.AddValue("_users", (!this.MarkedForDeletion?_users:null));
			info.AddValue("_alwaysFetchUsers", _alwaysFetchUsers);
			info.AddValue("_alreadyFetchedUsers", _alreadyFetchedUsers);
			info.AddValue("_userRoleActivities", (!this.MarkedForDeletion?_userRoleActivities:null));
			info.AddValue("_alwaysFetchUserRoleActivities", _alwaysFetchUserRoleActivities);
			info.AddValue("_alreadyFetchedUserRoleActivities", _alreadyFetchedUserRoleActivities);

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
				case "Users":
					_alreadyFetchedUsers = true;
					if(entity!=null)
					{
						this.Users.Add((UserEntity)entity);
					}
					break;
				case "UserRoleActivities":
					_alreadyFetchedUserRoleActivities = true;
					if(entity!=null)
					{
						this.UserRoleActivities.Add((UserRoleActivityEntity)entity);
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
				case "Users":
					_users.Add((UserEntity)relatedEntity);
					break;
				case "UserRoleActivities":
					_userRoleActivities.Add((UserRoleActivityEntity)relatedEntity);
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
				case "Users":
					this.PerformRelatedEntityRemoval(_users, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "UserRoleActivities":
					this.PerformRelatedEntityRemoval(_userRoleActivities, relatedEntity, signalRelatedEntityManyToOne);
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
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_users);
			toReturn.Add(_userRoleActivities);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="roleTypeEnum">PK value for UserRole which data should be fetched into this UserRole object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Byte roleTypeEnum)
		{
			return FetchUsingPK(roleTypeEnum, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="roleTypeEnum">PK value for UserRole which data should be fetched into this UserRole object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Byte roleTypeEnum, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(roleTypeEnum, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="roleTypeEnum">PK value for UserRole which data should be fetched into this UserRole object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Byte roleTypeEnum, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(roleTypeEnum, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="roleTypeEnum">PK value for UserRole which data should be fetched into this UserRole object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Byte roleTypeEnum, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(roleTypeEnum, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.RoleTypeEnum, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new UserRoleRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UserEntity'</returns>
		public AmstaJanBonga.Business.CollectionClasses.UserCollection GetMultiUsers(bool forceFetch)
		{
			return GetMultiUsers(forceFetch, _users.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'UserEntity'</returns>
		public AmstaJanBonga.Business.CollectionClasses.UserCollection GetMultiUsers(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiUsers(forceFetch, _users.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AmstaJanBonga.Business.CollectionClasses.UserCollection GetMultiUsers(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiUsers(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AmstaJanBonga.Business.CollectionClasses.UserCollection GetMultiUsers(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedUsers || forceFetch || _alwaysFetchUsers) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_users);
				_users.SuppressClearInGetMulti=!forceFetch;
				_users.EntityFactoryToUse = entityFactoryToUse;
				_users.GetMultiManyToOne(this, filter);
				_users.SuppressClearInGetMulti=false;
				_alreadyFetchedUsers = true;
			}
			return _users;
		}

		/// <summary> Sets the collection parameters for the collection for 'Users'. These settings will be taken into account
		/// when the property Users is requested or GetMultiUsers is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUsers(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_users.SortClauses=sortClauses;
			_users.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'UserRoleActivityEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UserRoleActivityEntity'</returns>
		public AmstaJanBonga.Business.CollectionClasses.UserRoleActivityCollection GetMultiUserRoleActivities(bool forceFetch)
		{
			return GetMultiUserRoleActivities(forceFetch, _userRoleActivities.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'UserRoleActivityEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'UserRoleActivityEntity'</returns>
		public AmstaJanBonga.Business.CollectionClasses.UserRoleActivityCollection GetMultiUserRoleActivities(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiUserRoleActivities(forceFetch, _userRoleActivities.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'UserRoleActivityEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AmstaJanBonga.Business.CollectionClasses.UserRoleActivityCollection GetMultiUserRoleActivities(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiUserRoleActivities(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'UserRoleActivityEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AmstaJanBonga.Business.CollectionClasses.UserRoleActivityCollection GetMultiUserRoleActivities(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedUserRoleActivities || forceFetch || _alwaysFetchUserRoleActivities) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_userRoleActivities);
				_userRoleActivities.SuppressClearInGetMulti=!forceFetch;
				_userRoleActivities.EntityFactoryToUse = entityFactoryToUse;
				_userRoleActivities.GetMultiManyToOne(null, this, filter);
				_userRoleActivities.SuppressClearInGetMulti=false;
				_alreadyFetchedUserRoleActivities = true;
			}
			return _userRoleActivities;
		}

		/// <summary> Sets the collection parameters for the collection for 'UserRoleActivities'. These settings will be taken into account
		/// when the property UserRoleActivities is requested or GetMultiUserRoleActivities is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUserRoleActivities(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_userRoleActivities.SortClauses=sortClauses;
			_userRoleActivities.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Users", _users);
			toReturn.Add("UserRoleActivities", _userRoleActivities);
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
		/// <param name="roleTypeEnum">PK value for UserRole which data should be fetched into this UserRole object</param>
		/// <param name="validator">The validator object for this UserRoleEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Byte roleTypeEnum, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(roleTypeEnum, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_users = new AmstaJanBonga.Business.CollectionClasses.UserCollection();
			_users.SetContainingEntityInfo(this, "UserRole");

			_userRoleActivities = new AmstaJanBonga.Business.CollectionClasses.UserRoleActivityCollection();
			_userRoleActivities.SetContainingEntityInfo(this, "UserRole");
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
			_fieldsCustomProperties.Add("DateLastModified", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateLastModifiedByUserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("RoleTypeEnum", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="roleTypeEnum">PK value for UserRole which data should be fetched into this UserRole object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Byte roleTypeEnum, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)UserRoleFieldIndex.RoleTypeEnum].ForcedCurrentValueWrite(roleTypeEnum);
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
			return DAOFactory.CreateUserRoleDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new UserRoleEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static UserRoleRelations Relations
		{
			get	{ return new UserRoleRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUsers
		{
			get { return new PrefetchPathElement(new AmstaJanBonga.Business.CollectionClasses.UserCollection(), (IEntityRelation)GetRelationsForField("Users")[0], (int)AmstaJanBonga.Business.EntityType.UserRoleEntity, (int)AmstaJanBonga.Business.EntityType.UserEntity, 0, null, null, null, "Users", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UserRoleActivity' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserRoleActivities
		{
			get { return new PrefetchPathElement(new AmstaJanBonga.Business.CollectionClasses.UserRoleActivityCollection(), (IEntityRelation)GetRelationsForField("UserRoleActivities")[0], (int)AmstaJanBonga.Business.EntityType.UserRoleEntity, (int)AmstaJanBonga.Business.EntityType.UserRoleActivityEntity, 0, null, null, null, "UserRoleActivities", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
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

		/// <summary> The DateCreated property of the Entity UserRole<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserRole"."DateCreated"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DateCreated
		{
			get { return (System.DateTime)GetValue((int)UserRoleFieldIndex.DateCreated, true); }
			set	{ SetValue((int)UserRoleFieldIndex.DateCreated, value, true); }
		}

		/// <summary> The DateLastModified property of the Entity UserRole<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserRole"."DateLastModified"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateLastModified
		{
			get { return (Nullable<System.DateTime>)GetValue((int)UserRoleFieldIndex.DateLastModified, false); }
			set	{ SetValue((int)UserRoleFieldIndex.DateLastModified, value, true); }
		}

		/// <summary> The DateLastModifiedByUserId property of the Entity UserRole<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserRole"."DateLastModifiedByUserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> DateLastModifiedByUserId
		{
			get { return (Nullable<System.Int32>)GetValue((int)UserRoleFieldIndex.DateLastModifiedByUserId, false); }
			set	{ SetValue((int)UserRoleFieldIndex.DateLastModifiedByUserId, value, true); }
		}

		/// <summary> The Name property of the Entity UserRole<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserRole"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)UserRoleFieldIndex.Name, true); }
			set	{ SetValue((int)UserRoleFieldIndex.Name, value, true); }
		}

		/// <summary> The RoleTypeEnum property of the Entity UserRole<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserRole"."RoleTypeEnum"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Byte RoleTypeEnum
		{
			get { return (System.Byte)GetValue((int)UserRoleFieldIndex.RoleTypeEnum, true); }
			set	{ SetValue((int)UserRoleFieldIndex.RoleTypeEnum, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsers()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AmstaJanBonga.Business.CollectionClasses.UserCollection Users
		{
			get	{ return GetMultiUsers(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Users. When set to true, Users is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Users is accessed. You can always execute/ a forced fetch by calling GetMultiUsers(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUsers
		{
			get	{ return _alwaysFetchUsers; }
			set	{ _alwaysFetchUsers = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Users already has been fetched. Setting this property to false when Users has been fetched
		/// will clear the Users collection well. Setting this property to true while Users hasn't been fetched disables lazy loading for Users</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUsers
		{
			get { return _alreadyFetchedUsers;}
			set 
			{
				if(_alreadyFetchedUsers && !value && (_users != null))
				{
					_users.Clear();
				}
				_alreadyFetchedUsers = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'UserRoleActivityEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUserRoleActivities()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AmstaJanBonga.Business.CollectionClasses.UserRoleActivityCollection UserRoleActivities
		{
			get	{ return GetMultiUserRoleActivities(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for UserRoleActivities. When set to true, UserRoleActivities is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UserRoleActivities is accessed. You can always execute/ a forced fetch by calling GetMultiUserRoleActivities(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUserRoleActivities
		{
			get	{ return _alwaysFetchUserRoleActivities; }
			set	{ _alwaysFetchUserRoleActivities = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property UserRoleActivities already has been fetched. Setting this property to false when UserRoleActivities has been fetched
		/// will clear the UserRoleActivities collection well. Setting this property to true while UserRoleActivities hasn't been fetched disables lazy loading for UserRoleActivities</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUserRoleActivities
		{
			get { return _alreadyFetchedUserRoleActivities;}
			set 
			{
				if(_alreadyFetchedUserRoleActivities && !value && (_userRoleActivities != null))
				{
					_userRoleActivities.Clear();
				}
				_alreadyFetchedUserRoleActivities = value;
			}
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
			get { return (int)AmstaJanBonga.Business.EntityType.UserRoleEntity; }
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
