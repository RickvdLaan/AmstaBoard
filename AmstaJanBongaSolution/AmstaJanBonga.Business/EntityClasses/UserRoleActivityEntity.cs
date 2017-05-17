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

	/// <summary>Entity class which represents the entity 'UserRoleActivity'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class UserRoleActivityEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private UserActivityEntity _userActivity;
		private bool	_alwaysFetchUserActivity, _alreadyFetchedUserActivity, _userActivityReturnsNewIfNotFound;
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
			/// <summary>Member name UserActivity</summary>
			public static readonly string UserActivity = "UserActivity";
			/// <summary>Member name UserRole</summary>
			public static readonly string UserRole = "UserRole";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static UserRoleActivityEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public UserRoleActivityEntity() :base("UserRoleActivityEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="roleTypeEnum">PK value for UserRoleActivity which data should be fetched into this UserRoleActivity object</param>
		/// <param name="userActivityName">PK value for UserRoleActivity which data should be fetched into this UserRoleActivity object</param>
		public UserRoleActivityEntity(System.Byte roleTypeEnum, System.String userActivityName):base("UserRoleActivityEntity")
		{
			InitClassFetch(roleTypeEnum, userActivityName, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="roleTypeEnum">PK value for UserRoleActivity which data should be fetched into this UserRoleActivity object</param>
		/// <param name="userActivityName">PK value for UserRoleActivity which data should be fetched into this UserRoleActivity object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public UserRoleActivityEntity(System.Byte roleTypeEnum, System.String userActivityName, IPrefetchPath prefetchPathToUse):base("UserRoleActivityEntity")
		{
			InitClassFetch(roleTypeEnum, userActivityName, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="roleTypeEnum">PK value for UserRoleActivity which data should be fetched into this UserRoleActivity object</param>
		/// <param name="userActivityName">PK value for UserRoleActivity which data should be fetched into this UserRoleActivity object</param>
		/// <param name="validator">The custom validator object for this UserRoleActivityEntity</param>
		public UserRoleActivityEntity(System.Byte roleTypeEnum, System.String userActivityName, IValidator validator):base("UserRoleActivityEntity")
		{
			InitClassFetch(roleTypeEnum, userActivityName, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected UserRoleActivityEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_userActivity = (UserActivityEntity)info.GetValue("_userActivity", typeof(UserActivityEntity));
			if(_userActivity!=null)
			{
				_userActivity.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_userActivityReturnsNewIfNotFound = info.GetBoolean("_userActivityReturnsNewIfNotFound");
			_alwaysFetchUserActivity = info.GetBoolean("_alwaysFetchUserActivity");
			_alreadyFetchedUserActivity = info.GetBoolean("_alreadyFetchedUserActivity");

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
			switch((UserRoleActivityFieldIndex)fieldIndex)
			{
				case UserRoleActivityFieldIndex.RoleTypeEnum:
					DesetupSyncUserRole(true, false);
					_alreadyFetchedUserRole = false;
					break;
				case UserRoleActivityFieldIndex.UserActivityName:
					DesetupSyncUserActivity(true, false);
					_alreadyFetchedUserActivity = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedUserActivity = (_userActivity != null);
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
				case "UserActivity":
					toReturn.Add(Relations.UserActivityEntityUsingUserActivityName);
					break;
				case "UserRole":
					toReturn.Add(Relations.UserRoleEntityUsingRoleTypeEnum);
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
			info.AddValue("_userActivity", (!this.MarkedForDeletion?_userActivity:null));
			info.AddValue("_userActivityReturnsNewIfNotFound", _userActivityReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchUserActivity", _alwaysFetchUserActivity);
			info.AddValue("_alreadyFetchedUserActivity", _alreadyFetchedUserActivity);
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
				case "UserActivity":
					_alreadyFetchedUserActivity = true;
					this.UserActivity = (UserActivityEntity)entity;
					break;
				case "UserRole":
					_alreadyFetchedUserRole = true;
					this.UserRole = (UserRoleEntity)entity;
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
				case "UserActivity":
					SetupSyncUserActivity(relatedEntity);
					break;
				case "UserRole":
					SetupSyncUserRole(relatedEntity);
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
				case "UserActivity":
					DesetupSyncUserActivity(false, true);
					break;
				case "UserRole":
					DesetupSyncUserRole(false, true);
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
			if(_userActivity!=null)
			{
				toReturn.Add(_userActivity);
			}
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


			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="roleTypeEnum">PK value for UserRoleActivity which data should be fetched into this UserRoleActivity object</param>
		/// <param name="userActivityName">PK value for UserRoleActivity which data should be fetched into this UserRoleActivity object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Byte roleTypeEnum, System.String userActivityName)
		{
			return FetchUsingPK(roleTypeEnum, userActivityName, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="roleTypeEnum">PK value for UserRoleActivity which data should be fetched into this UserRoleActivity object</param>
		/// <param name="userActivityName">PK value for UserRoleActivity which data should be fetched into this UserRoleActivity object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Byte roleTypeEnum, System.String userActivityName, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(roleTypeEnum, userActivityName, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="roleTypeEnum">PK value for UserRoleActivity which data should be fetched into this UserRoleActivity object</param>
		/// <param name="userActivityName">PK value for UserRoleActivity which data should be fetched into this UserRoleActivity object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Byte roleTypeEnum, System.String userActivityName, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(roleTypeEnum, userActivityName, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="roleTypeEnum">PK value for UserRoleActivity which data should be fetched into this UserRoleActivity object</param>
		/// <param name="userActivityName">PK value for UserRoleActivity which data should be fetched into this UserRoleActivity object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Byte roleTypeEnum, System.String userActivityName, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(roleTypeEnum, userActivityName, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.RoleTypeEnum, this.UserActivityName, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new UserRoleActivityRelations().GetAllRelations();
		}

		/// <summary> Retrieves the related entity of type 'UserActivityEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'UserActivityEntity' which is related to this entity.</returns>
		public UserActivityEntity GetSingleUserActivity()
		{
			return GetSingleUserActivity(false);
		}

		/// <summary> Retrieves the related entity of type 'UserActivityEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'UserActivityEntity' which is related to this entity.</returns>
		public virtual UserActivityEntity GetSingleUserActivity(bool forceFetch)
		{
			if( ( !_alreadyFetchedUserActivity || forceFetch || _alwaysFetchUserActivity) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.UserActivityEntityUsingUserActivityName);
				UserActivityEntity newEntity = new UserActivityEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.UserActivityName);
				}
				if(fetchResult)
				{
					newEntity = (UserActivityEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_userActivityReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.UserActivity = newEntity;
				_alreadyFetchedUserActivity = fetchResult;
			}
			return _userActivity;
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
			toReturn.Add("UserActivity", _userActivity);
			toReturn.Add("UserRole", _userRole);
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
		/// <param name="roleTypeEnum">PK value for UserRoleActivity which data should be fetched into this UserRoleActivity object</param>
		/// <param name="userActivityName">PK value for UserRoleActivity which data should be fetched into this UserRoleActivity object</param>
		/// <param name="validator">The validator object for this UserRoleActivityEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Byte roleTypeEnum, System.String userActivityName, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(roleTypeEnum, userActivityName, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_userActivityReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("RoleTypeEnum", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UserActivityName", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _userActivity</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUserActivity(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _userActivity, new PropertyChangedEventHandler( OnUserActivityPropertyChanged ), "UserActivity", AmstaJanBonga.Business.RelationClasses.StaticUserRoleActivityRelations.UserActivityEntityUsingUserActivityNameStatic, true, signalRelatedEntity, "UserRoleActivities", resetFKFields, new int[] { (int)UserRoleActivityFieldIndex.UserActivityName } );		
			_userActivity = null;
		}
		
		/// <summary> setups the sync logic for member _userActivity</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUserActivity(IEntityCore relatedEntity)
		{
			if(_userActivity!=relatedEntity)
			{		
				DesetupSyncUserActivity(true, true);
				_userActivity = (UserActivityEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _userActivity, new PropertyChangedEventHandler( OnUserActivityPropertyChanged ), "UserActivity", AmstaJanBonga.Business.RelationClasses.StaticUserRoleActivityRelations.UserActivityEntityUsingUserActivityNameStatic, true, ref _alreadyFetchedUserActivity, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnUserActivityPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _userRole</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUserRole(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _userRole, new PropertyChangedEventHandler( OnUserRolePropertyChanged ), "UserRole", AmstaJanBonga.Business.RelationClasses.StaticUserRoleActivityRelations.UserRoleEntityUsingRoleTypeEnumStatic, true, signalRelatedEntity, "UserRoleActivities", resetFKFields, new int[] { (int)UserRoleActivityFieldIndex.RoleTypeEnum } );		
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
				this.PerformSetupSyncRelatedEntity( _userRole, new PropertyChangedEventHandler( OnUserRolePropertyChanged ), "UserRole", AmstaJanBonga.Business.RelationClasses.StaticUserRoleActivityRelations.UserRoleEntityUsingRoleTypeEnumStatic, true, ref _alreadyFetchedUserRole, new string[] {  } );
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
		/// <param name="roleTypeEnum">PK value for UserRoleActivity which data should be fetched into this UserRoleActivity object</param>
		/// <param name="userActivityName">PK value for UserRoleActivity which data should be fetched into this UserRoleActivity object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Byte roleTypeEnum, System.String userActivityName, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)UserRoleActivityFieldIndex.RoleTypeEnum].ForcedCurrentValueWrite(roleTypeEnum);
				this.Fields[(int)UserRoleActivityFieldIndex.UserActivityName].ForcedCurrentValueWrite(userActivityName);
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
			return DAOFactory.CreateUserRoleActivityDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new UserRoleActivityEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static UserRoleActivityRelations Relations
		{
			get	{ return new UserRoleActivityRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UserActivity'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserActivity
		{
			get	{ return new PrefetchPathElement(new AmstaJanBonga.Business.CollectionClasses.UserActivityCollection(), (IEntityRelation)GetRelationsForField("UserActivity")[0], (int)AmstaJanBonga.Business.EntityType.UserRoleActivityEntity, (int)AmstaJanBonga.Business.EntityType.UserActivityEntity, 0, null, null, null, "UserActivity", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UserRole'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserRole
		{
			get	{ return new PrefetchPathElement(new AmstaJanBonga.Business.CollectionClasses.UserRoleCollection(), (IEntityRelation)GetRelationsForField("UserRole")[0], (int)AmstaJanBonga.Business.EntityType.UserRoleActivityEntity, (int)AmstaJanBonga.Business.EntityType.UserRoleEntity, 0, null, null, null, "UserRole", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The RoleTypeEnum property of the Entity UserRoleActivity<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserRoleActivity"."RoleTypeEnum"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Byte RoleTypeEnum
		{
			get { return (System.Byte)GetValue((int)UserRoleActivityFieldIndex.RoleTypeEnum, true); }
			set	{ SetValue((int)UserRoleActivityFieldIndex.RoleTypeEnum, value, true); }
		}

		/// <summary> The UserActivityName property of the Entity UserRoleActivity<br/><br/></summary>
		/// <remarks>Mapped on  table field: "UserRoleActivity"."UserActivityName"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String UserActivityName
		{
			get { return (System.String)GetValue((int)UserRoleActivityFieldIndex.UserActivityName, true); }
			set	{ SetValue((int)UserRoleActivityFieldIndex.UserActivityName, value, true); }
		}


		/// <summary> Gets / sets related entity of type 'UserActivityEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleUserActivity()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual UserActivityEntity UserActivity
		{
			get	{ return GetSingleUserActivity(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncUserActivity(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "UserRoleActivities", "UserActivity", _userActivity, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for UserActivity. When set to true, UserActivity is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UserActivity is accessed. You can always execute a forced fetch by calling GetSingleUserActivity(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUserActivity
		{
			get	{ return _alwaysFetchUserActivity; }
			set	{ _alwaysFetchUserActivity = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UserActivity already has been fetched. Setting this property to false when UserActivity has been fetched
		/// will set UserActivity to null as well. Setting this property to true while UserActivity hasn't been fetched disables lazy loading for UserActivity</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUserActivity
		{
			get { return _alreadyFetchedUserActivity;}
			set 
			{
				if(_alreadyFetchedUserActivity && !value)
				{
					this.UserActivity = null;
				}
				_alreadyFetchedUserActivity = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property UserActivity is not found
		/// in the database. When set to true, UserActivity will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool UserActivityReturnsNewIfNotFound
		{
			get	{ return _userActivityReturnsNewIfNotFound; }
			set { _userActivityReturnsNewIfNotFound = value; }	
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
					SetSingleRelatedEntityNavigator(value, "UserRoleActivities", "UserRole", _userRole, true); 
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
			get { return (int)AmstaJanBonga.Business.EntityType.UserRoleActivityEntity; }
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
