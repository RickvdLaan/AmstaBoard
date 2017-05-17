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

	/// <summary>Entity class which represents the entity 'Employee'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class EmployeeEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AmstaJanBonga.Business.CollectionClasses.LivingRoomShiftEventCollection	_livingRoomShiftEvents;
		private bool	_alwaysFetchLivingRoomShiftEvents, _alreadyFetchedLivingRoomShiftEvents;
		private LivingRoomEntity _livingRoom;
		private bool	_alwaysFetchLivingRoom, _alreadyFetchedLivingRoom, _livingRoomReturnsNewIfNotFound;
		private UserEntity _user;
		private bool	_alwaysFetchUser, _alreadyFetchedUser, _userReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name LivingRoom</summary>
			public static readonly string LivingRoom = "LivingRoom";
			/// <summary>Member name User</summary>
			public static readonly string User = "User";
			/// <summary>Member name LivingRoomShiftEvents</summary>
			public static readonly string LivingRoomShiftEvents = "LivingRoomShiftEvents";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static EmployeeEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public EmployeeEntity() :base("EmployeeEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="id">PK value for Employee which data should be fetched into this Employee object</param>
		public EmployeeEntity(System.Int32 id):base("EmployeeEntity")
		{
			InitClassFetch(id, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public EmployeeEntity(System.Int32 id, IPrefetchPath prefetchPathToUse):base("EmployeeEntity")
		{
			InitClassFetch(id, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="validator">The custom validator object for this EmployeeEntity</param>
		public EmployeeEntity(System.Int32 id, IValidator validator):base("EmployeeEntity")
		{
			InitClassFetch(id, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected EmployeeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_livingRoomShiftEvents = (AmstaJanBonga.Business.CollectionClasses.LivingRoomShiftEventCollection)info.GetValue("_livingRoomShiftEvents", typeof(AmstaJanBonga.Business.CollectionClasses.LivingRoomShiftEventCollection));
			_alwaysFetchLivingRoomShiftEvents = info.GetBoolean("_alwaysFetchLivingRoomShiftEvents");
			_alreadyFetchedLivingRoomShiftEvents = info.GetBoolean("_alreadyFetchedLivingRoomShiftEvents");
			_livingRoom = (LivingRoomEntity)info.GetValue("_livingRoom", typeof(LivingRoomEntity));
			if(_livingRoom!=null)
			{
				_livingRoom.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_livingRoomReturnsNewIfNotFound = info.GetBoolean("_livingRoomReturnsNewIfNotFound");
			_alwaysFetchLivingRoom = info.GetBoolean("_alwaysFetchLivingRoom");
			_alreadyFetchedLivingRoom = info.GetBoolean("_alreadyFetchedLivingRoom");

			_user = (UserEntity)info.GetValue("_user", typeof(UserEntity));
			if(_user!=null)
			{
				_user.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_userReturnsNewIfNotFound = info.GetBoolean("_userReturnsNewIfNotFound");
			_alwaysFetchUser = info.GetBoolean("_alwaysFetchUser");
			_alreadyFetchedUser = info.GetBoolean("_alreadyFetchedUser");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((EmployeeFieldIndex)fieldIndex)
			{
				case EmployeeFieldIndex.LivingRoomId:
					DesetupSyncLivingRoom(true, false);
					_alreadyFetchedLivingRoom = false;
					break;
				case EmployeeFieldIndex.UserId:
					DesetupSyncUser(true, false);
					_alreadyFetchedUser = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedLivingRoomShiftEvents = (_livingRoomShiftEvents.Count > 0);
			_alreadyFetchedLivingRoom = (_livingRoom != null);
			_alreadyFetchedUser = (_user != null);
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
				case "LivingRoom":
					toReturn.Add(Relations.LivingRoomEntityUsingLivingRoomId);
					break;
				case "User":
					toReturn.Add(Relations.UserEntityUsingUserId);
					break;
				case "LivingRoomShiftEvents":
					toReturn.Add(Relations.LivingRoomShiftEventEntityUsingEmployeeId);
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
			info.AddValue("_livingRoomShiftEvents", (!this.MarkedForDeletion?_livingRoomShiftEvents:null));
			info.AddValue("_alwaysFetchLivingRoomShiftEvents", _alwaysFetchLivingRoomShiftEvents);
			info.AddValue("_alreadyFetchedLivingRoomShiftEvents", _alreadyFetchedLivingRoomShiftEvents);
			info.AddValue("_livingRoom", (!this.MarkedForDeletion?_livingRoom:null));
			info.AddValue("_livingRoomReturnsNewIfNotFound", _livingRoomReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchLivingRoom", _alwaysFetchLivingRoom);
			info.AddValue("_alreadyFetchedLivingRoom", _alreadyFetchedLivingRoom);
			info.AddValue("_user", (!this.MarkedForDeletion?_user:null));
			info.AddValue("_userReturnsNewIfNotFound", _userReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchUser", _alwaysFetchUser);
			info.AddValue("_alreadyFetchedUser", _alreadyFetchedUser);

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
				case "LivingRoom":
					_alreadyFetchedLivingRoom = true;
					this.LivingRoom = (LivingRoomEntity)entity;
					break;
				case "User":
					_alreadyFetchedUser = true;
					this.User = (UserEntity)entity;
					break;
				case "LivingRoomShiftEvents":
					_alreadyFetchedLivingRoomShiftEvents = true;
					if(entity!=null)
					{
						this.LivingRoomShiftEvents.Add((LivingRoomShiftEventEntity)entity);
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
				case "LivingRoom":
					SetupSyncLivingRoom(relatedEntity);
					break;
				case "User":
					SetupSyncUser(relatedEntity);
					break;
				case "LivingRoomShiftEvents":
					_livingRoomShiftEvents.Add((LivingRoomShiftEventEntity)relatedEntity);
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
				case "LivingRoom":
					DesetupSyncLivingRoom(false, true);
					break;
				case "User":
					DesetupSyncUser(false, true);
					break;
				case "LivingRoomShiftEvents":
					this.PerformRelatedEntityRemoval(_livingRoomShiftEvents, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_livingRoom!=null)
			{
				toReturn.Add(_livingRoom);
			}
			if(_user!=null)
			{
				toReturn.Add(_user);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_livingRoomShiftEvents);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Employee which data should be fetched into this Employee object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id)
		{
			return FetchUsingPK(id, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Employee which data should be fetched into this Employee object</param>
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
			return new EmployeeRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'LivingRoomShiftEventEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'LivingRoomShiftEventEntity'</returns>
		public AmstaJanBonga.Business.CollectionClasses.LivingRoomShiftEventCollection GetMultiLivingRoomShiftEvents(bool forceFetch)
		{
			return GetMultiLivingRoomShiftEvents(forceFetch, _livingRoomShiftEvents.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'LivingRoomShiftEventEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'LivingRoomShiftEventEntity'</returns>
		public AmstaJanBonga.Business.CollectionClasses.LivingRoomShiftEventCollection GetMultiLivingRoomShiftEvents(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiLivingRoomShiftEvents(forceFetch, _livingRoomShiftEvents.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'LivingRoomShiftEventEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AmstaJanBonga.Business.CollectionClasses.LivingRoomShiftEventCollection GetMultiLivingRoomShiftEvents(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiLivingRoomShiftEvents(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'LivingRoomShiftEventEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AmstaJanBonga.Business.CollectionClasses.LivingRoomShiftEventCollection GetMultiLivingRoomShiftEvents(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedLivingRoomShiftEvents || forceFetch || _alwaysFetchLivingRoomShiftEvents) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_livingRoomShiftEvents);
				_livingRoomShiftEvents.SuppressClearInGetMulti=!forceFetch;
				_livingRoomShiftEvents.EntityFactoryToUse = entityFactoryToUse;
				_livingRoomShiftEvents.GetMultiManyToOne(this, null, filter);
				_livingRoomShiftEvents.SuppressClearInGetMulti=false;
				_alreadyFetchedLivingRoomShiftEvents = true;
			}
			return _livingRoomShiftEvents;
		}

		/// <summary> Sets the collection parameters for the collection for 'LivingRoomShiftEvents'. These settings will be taken into account
		/// when the property LivingRoomShiftEvents is requested or GetMultiLivingRoomShiftEvents is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersLivingRoomShiftEvents(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_livingRoomShiftEvents.SortClauses=sortClauses;
			_livingRoomShiftEvents.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'LivingRoomEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'LivingRoomEntity' which is related to this entity.</returns>
		public LivingRoomEntity GetSingleLivingRoom()
		{
			return GetSingleLivingRoom(false);
		}

		/// <summary> Retrieves the related entity of type 'LivingRoomEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'LivingRoomEntity' which is related to this entity.</returns>
		public virtual LivingRoomEntity GetSingleLivingRoom(bool forceFetch)
		{
			if( ( !_alreadyFetchedLivingRoom || forceFetch || _alwaysFetchLivingRoom) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.LivingRoomEntityUsingLivingRoomId);
				LivingRoomEntity newEntity = new LivingRoomEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.LivingRoomId);
				}
				if(fetchResult)
				{
					newEntity = (LivingRoomEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_livingRoomReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.LivingRoom = newEntity;
				_alreadyFetchedLivingRoom = fetchResult;
			}
			return _livingRoom;
		}


		/// <summary> Retrieves the related entity of type 'UserEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'UserEntity' which is related to this entity.</returns>
		public UserEntity GetSingleUser()
		{
			return GetSingleUser(false);
		}

		/// <summary> Retrieves the related entity of type 'UserEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'UserEntity' which is related to this entity.</returns>
		public virtual UserEntity GetSingleUser(bool forceFetch)
		{
			if( ( !_alreadyFetchedUser || forceFetch || _alwaysFetchUser) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.UserEntityUsingUserId);
				UserEntity newEntity = new UserEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.UserId.GetValueOrDefault());
				}
				if(fetchResult)
				{
					newEntity = (UserEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_userReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.User = newEntity;
				_alreadyFetchedUser = fetchResult;
			}
			return _user;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("LivingRoom", _livingRoom);
			toReturn.Add("User", _user);
			toReturn.Add("LivingRoomShiftEvents", _livingRoomShiftEvents);
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
		/// <param name="id">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="validator">The validator object for this EmployeeEntity</param>
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

			_livingRoomShiftEvents = new AmstaJanBonga.Business.CollectionClasses.LivingRoomShiftEventCollection();
			_livingRoomShiftEvents.SetContainingEntityInfo(this, "Employee");
			_livingRoomReturnsNewIfNotFound = false;
			_userReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("DateLastModified", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateLastModifiedByUserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FirstName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Id", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ImagePath", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsMarkedAsDeleted", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LivingRoomId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UserId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _livingRoom</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncLivingRoom(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _livingRoom, new PropertyChangedEventHandler( OnLivingRoomPropertyChanged ), "LivingRoom", AmstaJanBonga.Business.RelationClasses.StaticEmployeeRelations.LivingRoomEntityUsingLivingRoomIdStatic, true, signalRelatedEntity, "Employees", resetFKFields, new int[] { (int)EmployeeFieldIndex.LivingRoomId } );		
			_livingRoom = null;
		}
		
		/// <summary> setups the sync logic for member _livingRoom</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncLivingRoom(IEntityCore relatedEntity)
		{
			if(_livingRoom!=relatedEntity)
			{		
				DesetupSyncLivingRoom(true, true);
				_livingRoom = (LivingRoomEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _livingRoom, new PropertyChangedEventHandler( OnLivingRoomPropertyChanged ), "LivingRoom", AmstaJanBonga.Business.RelationClasses.StaticEmployeeRelations.LivingRoomEntityUsingLivingRoomIdStatic, true, ref _alreadyFetchedLivingRoom, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnLivingRoomPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _user</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUser(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _user, new PropertyChangedEventHandler( OnUserPropertyChanged ), "User", AmstaJanBonga.Business.RelationClasses.StaticEmployeeRelations.UserEntityUsingUserIdStatic, true, signalRelatedEntity, "Employees", resetFKFields, new int[] { (int)EmployeeFieldIndex.UserId } );		
			_user = null;
		}
		
		/// <summary> setups the sync logic for member _user</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUser(IEntityCore relatedEntity)
		{
			if(_user!=relatedEntity)
			{		
				DesetupSyncUser(true, true);
				_user = (UserEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _user, new PropertyChangedEventHandler( OnUserPropertyChanged ), "User", AmstaJanBonga.Business.RelationClasses.StaticEmployeeRelations.UserEntityUsingUserIdStatic, true, ref _alreadyFetchedUser, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnUserPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="id">PK value for Employee which data should be fetched into this Employee object</param>
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
				this.Fields[(int)EmployeeFieldIndex.Id].ForcedCurrentValueWrite(id);
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
			return DAOFactory.CreateEmployeeDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new EmployeeEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static EmployeeRelations Relations
		{
			get	{ return new EmployeeRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'LivingRoomShiftEvent' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathLivingRoomShiftEvents
		{
			get { return new PrefetchPathElement(new AmstaJanBonga.Business.CollectionClasses.LivingRoomShiftEventCollection(), (IEntityRelation)GetRelationsForField("LivingRoomShiftEvents")[0], (int)AmstaJanBonga.Business.EntityType.EmployeeEntity, (int)AmstaJanBonga.Business.EntityType.LivingRoomShiftEventEntity, 0, null, null, null, "LivingRoomShiftEvents", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'LivingRoom'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathLivingRoom
		{
			get	{ return new PrefetchPathElement(new AmstaJanBonga.Business.CollectionClasses.LivingRoomCollection(), (IEntityRelation)GetRelationsForField("LivingRoom")[0], (int)AmstaJanBonga.Business.EntityType.EmployeeEntity, (int)AmstaJanBonga.Business.EntityType.LivingRoomEntity, 0, null, null, null, "LivingRoom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUser
		{
			get	{ return new PrefetchPathElement(new AmstaJanBonga.Business.CollectionClasses.UserCollection(), (IEntityRelation)GetRelationsForField("User")[0], (int)AmstaJanBonga.Business.EntityType.EmployeeEntity, (int)AmstaJanBonga.Business.EntityType.UserEntity, 0, null, null, null, "User", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The DateCreated property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."DateCreated"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DateCreated
		{
			get { return (System.DateTime)GetValue((int)EmployeeFieldIndex.DateCreated, true); }
			set	{ SetValue((int)EmployeeFieldIndex.DateCreated, value, true); }
		}

		/// <summary> The DateDeleted property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."DateDeleted"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateDeleted
		{
			get { return (Nullable<System.DateTime>)GetValue((int)EmployeeFieldIndex.DateDeleted, false); }
			set	{ SetValue((int)EmployeeFieldIndex.DateDeleted, value, true); }
		}

		/// <summary> The DateLastModified property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."DateLastModified"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateLastModified
		{
			get { return (Nullable<System.DateTime>)GetValue((int)EmployeeFieldIndex.DateLastModified, false); }
			set	{ SetValue((int)EmployeeFieldIndex.DateLastModified, value, true); }
		}

		/// <summary> The DateLastModifiedByUserId property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."DateLastModifiedByUserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> DateLastModifiedByUserId
		{
			get { return (Nullable<System.Int32>)GetValue((int)EmployeeFieldIndex.DateLastModifiedByUserId, false); }
			set	{ SetValue((int)EmployeeFieldIndex.DateLastModifiedByUserId, value, true); }
		}

		/// <summary> The FirstName property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."FirstName"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String FirstName
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.FirstName, true); }
			set	{ SetValue((int)EmployeeFieldIndex.FirstName, value, true); }
		}

		/// <summary> The Id property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)EmployeeFieldIndex.Id, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Id, value, true); }
		}

		/// <summary> The ImagePath property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."ImagePath"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ImagePath
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.ImagePath, true); }
			set	{ SetValue((int)EmployeeFieldIndex.ImagePath, value, true); }
		}

		/// <summary> The IsMarkedAsDeleted property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."IsMarkedAsDeleted"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsMarkedAsDeleted
		{
			get { return (System.Boolean)GetValue((int)EmployeeFieldIndex.IsMarkedAsDeleted, true); }
			set	{ SetValue((int)EmployeeFieldIndex.IsMarkedAsDeleted, value, true); }
		}

		/// <summary> The LivingRoomId property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."LivingRoomId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 LivingRoomId
		{
			get { return (System.Int32)GetValue((int)EmployeeFieldIndex.LivingRoomId, true); }
			set	{ SetValue((int)EmployeeFieldIndex.LivingRoomId, value, true); }
		}

		/// <summary> The UserId property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."UserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> UserId
		{
			get { return (Nullable<System.Int32>)GetValue((int)EmployeeFieldIndex.UserId, false); }
			set	{ SetValue((int)EmployeeFieldIndex.UserId, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'LivingRoomShiftEventEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiLivingRoomShiftEvents()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AmstaJanBonga.Business.CollectionClasses.LivingRoomShiftEventCollection LivingRoomShiftEvents
		{
			get	{ return GetMultiLivingRoomShiftEvents(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for LivingRoomShiftEvents. When set to true, LivingRoomShiftEvents is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time LivingRoomShiftEvents is accessed. You can always execute/ a forced fetch by calling GetMultiLivingRoomShiftEvents(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchLivingRoomShiftEvents
		{
			get	{ return _alwaysFetchLivingRoomShiftEvents; }
			set	{ _alwaysFetchLivingRoomShiftEvents = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property LivingRoomShiftEvents already has been fetched. Setting this property to false when LivingRoomShiftEvents has been fetched
		/// will clear the LivingRoomShiftEvents collection well. Setting this property to true while LivingRoomShiftEvents hasn't been fetched disables lazy loading for LivingRoomShiftEvents</summary>
		[Browsable(false)]
		public bool AlreadyFetchedLivingRoomShiftEvents
		{
			get { return _alreadyFetchedLivingRoomShiftEvents;}
			set 
			{
				if(_alreadyFetchedLivingRoomShiftEvents && !value && (_livingRoomShiftEvents != null))
				{
					_livingRoomShiftEvents.Clear();
				}
				_alreadyFetchedLivingRoomShiftEvents = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'LivingRoomEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleLivingRoom()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual LivingRoomEntity LivingRoom
		{
			get	{ return GetSingleLivingRoom(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncLivingRoom(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Employees", "LivingRoom", _livingRoom, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for LivingRoom. When set to true, LivingRoom is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time LivingRoom is accessed. You can always execute a forced fetch by calling GetSingleLivingRoom(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchLivingRoom
		{
			get	{ return _alwaysFetchLivingRoom; }
			set	{ _alwaysFetchLivingRoom = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property LivingRoom already has been fetched. Setting this property to false when LivingRoom has been fetched
		/// will set LivingRoom to null as well. Setting this property to true while LivingRoom hasn't been fetched disables lazy loading for LivingRoom</summary>
		[Browsable(false)]
		public bool AlreadyFetchedLivingRoom
		{
			get { return _alreadyFetchedLivingRoom;}
			set 
			{
				if(_alreadyFetchedLivingRoom && !value)
				{
					this.LivingRoom = null;
				}
				_alreadyFetchedLivingRoom = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property LivingRoom is not found
		/// in the database. When set to true, LivingRoom will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool LivingRoomReturnsNewIfNotFound
		{
			get	{ return _livingRoomReturnsNewIfNotFound; }
			set { _livingRoomReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'UserEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleUser()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual UserEntity User
		{
			get	{ return GetSingleUser(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncUser(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Employees", "User", _user, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for User. When set to true, User is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time User is accessed. You can always execute a forced fetch by calling GetSingleUser(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUser
		{
			get	{ return _alwaysFetchUser; }
			set	{ _alwaysFetchUser = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property User already has been fetched. Setting this property to false when User has been fetched
		/// will set User to null as well. Setting this property to true while User hasn't been fetched disables lazy loading for User</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUser
		{
			get { return _alreadyFetchedUser;}
			set 
			{
				if(_alreadyFetchedUser && !value)
				{
					this.User = null;
				}
				_alreadyFetchedUser = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property User is not found
		/// in the database. When set to true, User will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool UserReturnsNewIfNotFound
		{
			get	{ return _userReturnsNewIfNotFound; }
			set { _userReturnsNewIfNotFound = value; }	
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
			get { return (int)AmstaJanBonga.Business.EntityType.EmployeeEntity; }
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
