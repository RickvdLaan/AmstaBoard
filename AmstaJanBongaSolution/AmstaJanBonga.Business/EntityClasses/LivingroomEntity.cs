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

	/// <summary>Entity class which represents the entity 'LivingRoom'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class LivingRoomEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AmstaJanBonga.Business.CollectionClasses.EmployeeCollection	_employees;
		private bool	_alwaysFetchEmployees, _alreadyFetchedEmployees;
		private AmstaJanBonga.Business.CollectionClasses.LivingRoomChoreEventCollection	_livingRoomChoreEvents;
		private bool	_alwaysFetchLivingRoomChoreEvents, _alreadyFetchedLivingRoomChoreEvents;
		private AmstaJanBonga.Business.CollectionClasses.LivingRoomShiftEventCollection	_livingRoomShiftEvents;
		private bool	_alwaysFetchLivingRoomShiftEvents, _alreadyFetchedLivingRoomShiftEvents;
		private AmstaJanBonga.Business.CollectionClasses.PatientCollection	_patients;
		private bool	_alwaysFetchPatients, _alreadyFetchedPatients;
		private LivingRoomGeneralEntity _livingRoomGeneral;
		private bool	_alwaysFetchLivingRoomGeneral, _alreadyFetchedLivingRoomGeneral, _livingRoomGeneralReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Employees</summary>
			public static readonly string Employees = "Employees";
			/// <summary>Member name LivingRoomChoreEvents</summary>
			public static readonly string LivingRoomChoreEvents = "LivingRoomChoreEvents";
			/// <summary>Member name LivingRoomShiftEvents</summary>
			public static readonly string LivingRoomShiftEvents = "LivingRoomShiftEvents";
			/// <summary>Member name Patients</summary>
			public static readonly string Patients = "Patients";
			/// <summary>Member name LivingRoomGeneral</summary>
			public static readonly string LivingRoomGeneral = "LivingRoomGeneral";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static LivingRoomEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public LivingRoomEntity() :base("LivingRoomEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="id">PK value for LivingRoom which data should be fetched into this LivingRoom object</param>
		public LivingRoomEntity(System.Int32 id):base("LivingRoomEntity")
		{
			InitClassFetch(id, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for LivingRoom which data should be fetched into this LivingRoom object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public LivingRoomEntity(System.Int32 id, IPrefetchPath prefetchPathToUse):base("LivingRoomEntity")
		{
			InitClassFetch(id, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for LivingRoom which data should be fetched into this LivingRoom object</param>
		/// <param name="validator">The custom validator object for this LivingRoomEntity</param>
		public LivingRoomEntity(System.Int32 id, IValidator validator):base("LivingRoomEntity")
		{
			InitClassFetch(id, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected LivingRoomEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_employees = (AmstaJanBonga.Business.CollectionClasses.EmployeeCollection)info.GetValue("_employees", typeof(AmstaJanBonga.Business.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployees = info.GetBoolean("_alwaysFetchEmployees");
			_alreadyFetchedEmployees = info.GetBoolean("_alreadyFetchedEmployees");

			_livingRoomChoreEvents = (AmstaJanBonga.Business.CollectionClasses.LivingRoomChoreEventCollection)info.GetValue("_livingRoomChoreEvents", typeof(AmstaJanBonga.Business.CollectionClasses.LivingRoomChoreEventCollection));
			_alwaysFetchLivingRoomChoreEvents = info.GetBoolean("_alwaysFetchLivingRoomChoreEvents");
			_alreadyFetchedLivingRoomChoreEvents = info.GetBoolean("_alreadyFetchedLivingRoomChoreEvents");

			_livingRoomShiftEvents = (AmstaJanBonga.Business.CollectionClasses.LivingRoomShiftEventCollection)info.GetValue("_livingRoomShiftEvents", typeof(AmstaJanBonga.Business.CollectionClasses.LivingRoomShiftEventCollection));
			_alwaysFetchLivingRoomShiftEvents = info.GetBoolean("_alwaysFetchLivingRoomShiftEvents");
			_alreadyFetchedLivingRoomShiftEvents = info.GetBoolean("_alreadyFetchedLivingRoomShiftEvents");

			_patients = (AmstaJanBonga.Business.CollectionClasses.PatientCollection)info.GetValue("_patients", typeof(AmstaJanBonga.Business.CollectionClasses.PatientCollection));
			_alwaysFetchPatients = info.GetBoolean("_alwaysFetchPatients");
			_alreadyFetchedPatients = info.GetBoolean("_alreadyFetchedPatients");
			_livingRoomGeneral = (LivingRoomGeneralEntity)info.GetValue("_livingRoomGeneral", typeof(LivingRoomGeneralEntity));
			if(_livingRoomGeneral!=null)
			{
				_livingRoomGeneral.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_livingRoomGeneralReturnsNewIfNotFound = info.GetBoolean("_livingRoomGeneralReturnsNewIfNotFound");
			_alwaysFetchLivingRoomGeneral = info.GetBoolean("_alwaysFetchLivingRoomGeneral");
			_alreadyFetchedLivingRoomGeneral = info.GetBoolean("_alreadyFetchedLivingRoomGeneral");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedEmployees = (_employees.Count > 0);
			_alreadyFetchedLivingRoomChoreEvents = (_livingRoomChoreEvents.Count > 0);
			_alreadyFetchedLivingRoomShiftEvents = (_livingRoomShiftEvents.Count > 0);
			_alreadyFetchedPatients = (_patients.Count > 0);
			_alreadyFetchedLivingRoomGeneral = (_livingRoomGeneral != null);
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
				case "Employees":
					toReturn.Add(Relations.EmployeeEntityUsingLivingRoomId);
					break;
				case "LivingRoomChoreEvents":
					toReturn.Add(Relations.LivingRoomChoreEventEntityUsingLivingRoomId);
					break;
				case "LivingRoomShiftEvents":
					toReturn.Add(Relations.LivingRoomShiftEventEntityUsingLivingRoomId);
					break;
				case "Patients":
					toReturn.Add(Relations.PatientEntityUsingLivingRoomId);
					break;
				case "LivingRoomGeneral":
					toReturn.Add(Relations.LivingRoomGeneralEntityUsingLivingRoomId);
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
			info.AddValue("_livingRoomChoreEvents", (!this.MarkedForDeletion?_livingRoomChoreEvents:null));
			info.AddValue("_alwaysFetchLivingRoomChoreEvents", _alwaysFetchLivingRoomChoreEvents);
			info.AddValue("_alreadyFetchedLivingRoomChoreEvents", _alreadyFetchedLivingRoomChoreEvents);
			info.AddValue("_livingRoomShiftEvents", (!this.MarkedForDeletion?_livingRoomShiftEvents:null));
			info.AddValue("_alwaysFetchLivingRoomShiftEvents", _alwaysFetchLivingRoomShiftEvents);
			info.AddValue("_alreadyFetchedLivingRoomShiftEvents", _alreadyFetchedLivingRoomShiftEvents);
			info.AddValue("_patients", (!this.MarkedForDeletion?_patients:null));
			info.AddValue("_alwaysFetchPatients", _alwaysFetchPatients);
			info.AddValue("_alreadyFetchedPatients", _alreadyFetchedPatients);

			info.AddValue("_livingRoomGeneral", (!this.MarkedForDeletion?_livingRoomGeneral:null));
			info.AddValue("_livingRoomGeneralReturnsNewIfNotFound", _livingRoomGeneralReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchLivingRoomGeneral", _alwaysFetchLivingRoomGeneral);
			info.AddValue("_alreadyFetchedLivingRoomGeneral", _alreadyFetchedLivingRoomGeneral);

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
				case "Employees":
					_alreadyFetchedEmployees = true;
					if(entity!=null)
					{
						this.Employees.Add((EmployeeEntity)entity);
					}
					break;
				case "LivingRoomChoreEvents":
					_alreadyFetchedLivingRoomChoreEvents = true;
					if(entity!=null)
					{
						this.LivingRoomChoreEvents.Add((LivingRoomChoreEventEntity)entity);
					}
					break;
				case "LivingRoomShiftEvents":
					_alreadyFetchedLivingRoomShiftEvents = true;
					if(entity!=null)
					{
						this.LivingRoomShiftEvents.Add((LivingRoomShiftEventEntity)entity);
					}
					break;
				case "Patients":
					_alreadyFetchedPatients = true;
					if(entity!=null)
					{
						this.Patients.Add((PatientEntity)entity);
					}
					break;
				case "LivingRoomGeneral":
					_alreadyFetchedLivingRoomGeneral = true;
					this.LivingRoomGeneral = (LivingRoomGeneralEntity)entity;
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
				case "Employees":
					_employees.Add((EmployeeEntity)relatedEntity);
					break;
				case "LivingRoomChoreEvents":
					_livingRoomChoreEvents.Add((LivingRoomChoreEventEntity)relatedEntity);
					break;
				case "LivingRoomShiftEvents":
					_livingRoomShiftEvents.Add((LivingRoomShiftEventEntity)relatedEntity);
					break;
				case "Patients":
					_patients.Add((PatientEntity)relatedEntity);
					break;
				case "LivingRoomGeneral":
					SetupSyncLivingRoomGeneral(relatedEntity);
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
				case "Employees":
					this.PerformRelatedEntityRemoval(_employees, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "LivingRoomChoreEvents":
					this.PerformRelatedEntityRemoval(_livingRoomChoreEvents, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "LivingRoomShiftEvents":
					this.PerformRelatedEntityRemoval(_livingRoomShiftEvents, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Patients":
					this.PerformRelatedEntityRemoval(_patients, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "LivingRoomGeneral":
					DesetupSyncLivingRoomGeneral(false, true);
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
			if(_livingRoomGeneral!=null)
			{
				toReturn.Add(_livingRoomGeneral);
			}
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
			toReturn.Add(_employees);
			toReturn.Add(_livingRoomChoreEvents);
			toReturn.Add(_livingRoomShiftEvents);
			toReturn.Add(_patients);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for LivingRoom which data should be fetched into this LivingRoom object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id)
		{
			return FetchUsingPK(id, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for LivingRoom which data should be fetched into this LivingRoom object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for LivingRoom which data should be fetched into this LivingRoom object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for LivingRoom which data should be fetched into this LivingRoom object</param>
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
			return new LivingRoomRelations().GetAllRelations();
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
				_employees.GetMultiManyToOne(this, null, filter);
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

		/// <summary> Retrieves all related entities of type 'LivingRoomChoreEventEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'LivingRoomChoreEventEntity'</returns>
		public AmstaJanBonga.Business.CollectionClasses.LivingRoomChoreEventCollection GetMultiLivingRoomChoreEvents(bool forceFetch)
		{
			return GetMultiLivingRoomChoreEvents(forceFetch, _livingRoomChoreEvents.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'LivingRoomChoreEventEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'LivingRoomChoreEventEntity'</returns>
		public AmstaJanBonga.Business.CollectionClasses.LivingRoomChoreEventCollection GetMultiLivingRoomChoreEvents(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiLivingRoomChoreEvents(forceFetch, _livingRoomChoreEvents.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'LivingRoomChoreEventEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AmstaJanBonga.Business.CollectionClasses.LivingRoomChoreEventCollection GetMultiLivingRoomChoreEvents(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiLivingRoomChoreEvents(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'LivingRoomChoreEventEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AmstaJanBonga.Business.CollectionClasses.LivingRoomChoreEventCollection GetMultiLivingRoomChoreEvents(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedLivingRoomChoreEvents || forceFetch || _alwaysFetchLivingRoomChoreEvents) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_livingRoomChoreEvents);
				_livingRoomChoreEvents.SuppressClearInGetMulti=!forceFetch;
				_livingRoomChoreEvents.EntityFactoryToUse = entityFactoryToUse;
				_livingRoomChoreEvents.GetMultiManyToOne(this, null, filter);
				_livingRoomChoreEvents.SuppressClearInGetMulti=false;
				_alreadyFetchedLivingRoomChoreEvents = true;
			}
			return _livingRoomChoreEvents;
		}

		/// <summary> Sets the collection parameters for the collection for 'LivingRoomChoreEvents'. These settings will be taken into account
		/// when the property LivingRoomChoreEvents is requested or GetMultiLivingRoomChoreEvents is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersLivingRoomChoreEvents(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_livingRoomChoreEvents.SortClauses=sortClauses;
			_livingRoomChoreEvents.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_livingRoomShiftEvents.GetMultiManyToOne(null, this, filter);
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

		/// <summary> Retrieves all related entities of type 'PatientEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'PatientEntity'</returns>
		public AmstaJanBonga.Business.CollectionClasses.PatientCollection GetMultiPatients(bool forceFetch)
		{
			return GetMultiPatients(forceFetch, _patients.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'PatientEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'PatientEntity'</returns>
		public AmstaJanBonga.Business.CollectionClasses.PatientCollection GetMultiPatients(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiPatients(forceFetch, _patients.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'PatientEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AmstaJanBonga.Business.CollectionClasses.PatientCollection GetMultiPatients(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiPatients(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'PatientEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AmstaJanBonga.Business.CollectionClasses.PatientCollection GetMultiPatients(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedPatients || forceFetch || _alwaysFetchPatients) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_patients);
				_patients.SuppressClearInGetMulti=!forceFetch;
				_patients.EntityFactoryToUse = entityFactoryToUse;
				_patients.GetMultiManyToOne(this, filter);
				_patients.SuppressClearInGetMulti=false;
				_alreadyFetchedPatients = true;
			}
			return _patients;
		}

		/// <summary> Sets the collection parameters for the collection for 'Patients'. These settings will be taken into account
		/// when the property Patients is requested or GetMultiPatients is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersPatients(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_patients.SortClauses=sortClauses;
			_patients.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'LivingRoomGeneralEntity', using a relation of type '1:1'</summary>
		/// <returns>A fetched entity of type 'LivingRoomGeneralEntity' which is related to this entity.</returns>
		public LivingRoomGeneralEntity GetSingleLivingRoomGeneral()
		{
			return GetSingleLivingRoomGeneral(false);
		}
		
		/// <summary> Retrieves the related entity of type 'LivingRoomGeneralEntity', using a relation of type '1:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'LivingRoomGeneralEntity' which is related to this entity.</returns>
		public virtual LivingRoomGeneralEntity GetSingleLivingRoomGeneral(bool forceFetch)
		{
			if( ( !_alreadyFetchedLivingRoomGeneral || forceFetch || _alwaysFetchLivingRoomGeneral) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode )
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.LivingRoomGeneralEntityUsingLivingRoomId);
				LivingRoomGeneralEntity newEntity = new LivingRoomGeneralEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.Id);
				}
				if(fetchResult)
				{
					newEntity = (LivingRoomGeneralEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_livingRoomGeneralReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.LivingRoomGeneral = newEntity;
				_alreadyFetchedLivingRoomGeneral = fetchResult;
			}
			return _livingRoomGeneral;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Employees", _employees);
			toReturn.Add("LivingRoomChoreEvents", _livingRoomChoreEvents);
			toReturn.Add("LivingRoomShiftEvents", _livingRoomShiftEvents);
			toReturn.Add("Patients", _patients);
			toReturn.Add("LivingRoomGeneral", _livingRoomGeneral);
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
		/// <param name="id">PK value for LivingRoom which data should be fetched into this LivingRoom object</param>
		/// <param name="validator">The validator object for this LivingRoomEntity</param>
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
			_employees.SetContainingEntityInfo(this, "LivingRoom");

			_livingRoomChoreEvents = new AmstaJanBonga.Business.CollectionClasses.LivingRoomChoreEventCollection();
			_livingRoomChoreEvents.SetContainingEntityInfo(this, "LivingRoom");

			_livingRoomShiftEvents = new AmstaJanBonga.Business.CollectionClasses.LivingRoomShiftEventCollection();
			_livingRoomShiftEvents.SetContainingEntityInfo(this, "LivingRoom");

			_patients = new AmstaJanBonga.Business.CollectionClasses.PatientCollection();
			_patients.SetContainingEntityInfo(this, "LivingRoom");
			_livingRoomGeneralReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("ColourTypeEnum", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateCreated", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateDeleted", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateLastModified", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateLastModifiedByUserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Id", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsMarkedAsDeleted", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _livingRoomGeneral</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncLivingRoomGeneral(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _livingRoomGeneral, new PropertyChangedEventHandler( OnLivingRoomGeneralPropertyChanged ), "LivingRoomGeneral", AmstaJanBonga.Business.RelationClasses.StaticLivingRoomRelations.LivingRoomGeneralEntityUsingLivingRoomIdStatic, false, signalRelatedEntity, "LivingRoom", false, new int[] { (int)LivingRoomFieldIndex.Id } );
			_livingRoomGeneral = null;
		}
	
		/// <summary> setups the sync logic for member _livingRoomGeneral</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncLivingRoomGeneral(IEntityCore relatedEntity)
		{
			if(_livingRoomGeneral!=relatedEntity)
			{
				DesetupSyncLivingRoomGeneral(true, true);
				_livingRoomGeneral = (LivingRoomGeneralEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _livingRoomGeneral, new PropertyChangedEventHandler( OnLivingRoomGeneralPropertyChanged ), "LivingRoomGeneral", AmstaJanBonga.Business.RelationClasses.StaticLivingRoomRelations.LivingRoomGeneralEntityUsingLivingRoomIdStatic, false, ref _alreadyFetchedLivingRoomGeneral, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnLivingRoomGeneralPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="id">PK value for LivingRoom which data should be fetched into this LivingRoom object</param>
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
				this.Fields[(int)LivingRoomFieldIndex.Id].ForcedCurrentValueWrite(id);
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
			return DAOFactory.CreateLivingRoomDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new LivingRoomEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static LivingRoomRelations Relations
		{
			get	{ return new LivingRoomRelations(); }
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
			get { return new PrefetchPathElement(new AmstaJanBonga.Business.CollectionClasses.EmployeeCollection(), (IEntityRelation)GetRelationsForField("Employees")[0], (int)AmstaJanBonga.Business.EntityType.LivingRoomEntity, (int)AmstaJanBonga.Business.EntityType.EmployeeEntity, 0, null, null, null, "Employees", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'LivingRoomChoreEvent' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathLivingRoomChoreEvents
		{
			get { return new PrefetchPathElement(new AmstaJanBonga.Business.CollectionClasses.LivingRoomChoreEventCollection(), (IEntityRelation)GetRelationsForField("LivingRoomChoreEvents")[0], (int)AmstaJanBonga.Business.EntityType.LivingRoomEntity, (int)AmstaJanBonga.Business.EntityType.LivingRoomChoreEventEntity, 0, null, null, null, "LivingRoomChoreEvents", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'LivingRoomShiftEvent' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathLivingRoomShiftEvents
		{
			get { return new PrefetchPathElement(new AmstaJanBonga.Business.CollectionClasses.LivingRoomShiftEventCollection(), (IEntityRelation)GetRelationsForField("LivingRoomShiftEvents")[0], (int)AmstaJanBonga.Business.EntityType.LivingRoomEntity, (int)AmstaJanBonga.Business.EntityType.LivingRoomShiftEventEntity, 0, null, null, null, "LivingRoomShiftEvents", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Patient' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathPatients
		{
			get { return new PrefetchPathElement(new AmstaJanBonga.Business.CollectionClasses.PatientCollection(), (IEntityRelation)GetRelationsForField("Patients")[0], (int)AmstaJanBonga.Business.EntityType.LivingRoomEntity, (int)AmstaJanBonga.Business.EntityType.PatientEntity, 0, null, null, null, "Patients", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'LivingRoomGeneral'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathLivingRoomGeneral
		{
			get	{ return new PrefetchPathElement(new AmstaJanBonga.Business.CollectionClasses.LivingRoomGeneralCollection(), (IEntityRelation)GetRelationsForField("LivingRoomGeneral")[0], (int)AmstaJanBonga.Business.EntityType.LivingRoomEntity, (int)AmstaJanBonga.Business.EntityType.LivingRoomGeneralEntity, 0, null, null, null, "LivingRoomGeneral", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);	}
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

		/// <summary> The ColourTypeEnum property of the Entity LivingRoom<br/><br/></summary>
		/// <remarks>Mapped on  table field: "LivingRoom"."ColourTypeEnum"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte ColourTypeEnum
		{
			get { return (System.Byte)GetValue((int)LivingRoomFieldIndex.ColourTypeEnum, true); }
			set	{ SetValue((int)LivingRoomFieldIndex.ColourTypeEnum, value, true); }
		}

		/// <summary> The DateCreated property of the Entity LivingRoom<br/><br/></summary>
		/// <remarks>Mapped on  table field: "LivingRoom"."DateCreated"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DateCreated
		{
			get { return (System.DateTime)GetValue((int)LivingRoomFieldIndex.DateCreated, true); }
			set	{ SetValue((int)LivingRoomFieldIndex.DateCreated, value, true); }
		}

		/// <summary> The DateDeleted property of the Entity LivingRoom<br/><br/></summary>
		/// <remarks>Mapped on  table field: "LivingRoom"."DateDeleted"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateDeleted
		{
			get { return (Nullable<System.DateTime>)GetValue((int)LivingRoomFieldIndex.DateDeleted, false); }
			set	{ SetValue((int)LivingRoomFieldIndex.DateDeleted, value, true); }
		}

		/// <summary> The DateLastModified property of the Entity LivingRoom<br/><br/></summary>
		/// <remarks>Mapped on  table field: "LivingRoom"."DateLastModified"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateLastModified
		{
			get { return (Nullable<System.DateTime>)GetValue((int)LivingRoomFieldIndex.DateLastModified, false); }
			set	{ SetValue((int)LivingRoomFieldIndex.DateLastModified, value, true); }
		}

		/// <summary> The DateLastModifiedByUserId property of the Entity LivingRoom<br/><br/></summary>
		/// <remarks>Mapped on  table field: "LivingRoom"."DateLastModifiedByUserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> DateLastModifiedByUserId
		{
			get { return (Nullable<System.Int32>)GetValue((int)LivingRoomFieldIndex.DateLastModifiedByUserId, false); }
			set	{ SetValue((int)LivingRoomFieldIndex.DateLastModifiedByUserId, value, true); }
		}

		/// <summary> The Id property of the Entity LivingRoom<br/><br/></summary>
		/// <remarks>Mapped on  table field: "LivingRoom"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)LivingRoomFieldIndex.Id, true); }
			set	{ SetValue((int)LivingRoomFieldIndex.Id, value, true); }
		}

		/// <summary> The IsMarkedAsDeleted property of the Entity LivingRoom<br/><br/></summary>
		/// <remarks>Mapped on  table field: "LivingRoom"."IsMarkedAsDeleted"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsMarkedAsDeleted
		{
			get { return (System.Boolean)GetValue((int)LivingRoomFieldIndex.IsMarkedAsDeleted, true); }
			set	{ SetValue((int)LivingRoomFieldIndex.IsMarkedAsDeleted, value, true); }
		}

		/// <summary> The Name property of the Entity LivingRoom<br/><br/></summary>
		/// <remarks>Mapped on  table field: "LivingRoom"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)LivingRoomFieldIndex.Name, true); }
			set	{ SetValue((int)LivingRoomFieldIndex.Name, value, true); }
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
		/// <summary> Retrieves all related entities of type 'LivingRoomChoreEventEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiLivingRoomChoreEvents()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AmstaJanBonga.Business.CollectionClasses.LivingRoomChoreEventCollection LivingRoomChoreEvents
		{
			get	{ return GetMultiLivingRoomChoreEvents(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for LivingRoomChoreEvents. When set to true, LivingRoomChoreEvents is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time LivingRoomChoreEvents is accessed. You can always execute/ a forced fetch by calling GetMultiLivingRoomChoreEvents(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchLivingRoomChoreEvents
		{
			get	{ return _alwaysFetchLivingRoomChoreEvents; }
			set	{ _alwaysFetchLivingRoomChoreEvents = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property LivingRoomChoreEvents already has been fetched. Setting this property to false when LivingRoomChoreEvents has been fetched
		/// will clear the LivingRoomChoreEvents collection well. Setting this property to true while LivingRoomChoreEvents hasn't been fetched disables lazy loading for LivingRoomChoreEvents</summary>
		[Browsable(false)]
		public bool AlreadyFetchedLivingRoomChoreEvents
		{
			get { return _alreadyFetchedLivingRoomChoreEvents;}
			set 
			{
				if(_alreadyFetchedLivingRoomChoreEvents && !value && (_livingRoomChoreEvents != null))
				{
					_livingRoomChoreEvents.Clear();
				}
				_alreadyFetchedLivingRoomChoreEvents = value;
			}
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
		/// <summary> Retrieves all related entities of type 'PatientEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPatients()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AmstaJanBonga.Business.CollectionClasses.PatientCollection Patients
		{
			get	{ return GetMultiPatients(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Patients. When set to true, Patients is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Patients is accessed. You can always execute/ a forced fetch by calling GetMultiPatients(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchPatients
		{
			get	{ return _alwaysFetchPatients; }
			set	{ _alwaysFetchPatients = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Patients already has been fetched. Setting this property to false when Patients has been fetched
		/// will clear the Patients collection well. Setting this property to true while Patients hasn't been fetched disables lazy loading for Patients</summary>
		[Browsable(false)]
		public bool AlreadyFetchedPatients
		{
			get { return _alreadyFetchedPatients;}
			set 
			{
				if(_alreadyFetchedPatients && !value && (_patients != null))
				{
					_patients.Clear();
				}
				_alreadyFetchedPatients = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'LivingRoomGeneralEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/></summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleLivingRoomGeneral()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual LivingRoomGeneralEntity LivingRoomGeneral
		{
			get	{ return GetSingleLivingRoomGeneral(false); }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncLivingRoomGeneral(value);
				}
				else
				{
					if(value==null)
					{
						bool raisePropertyChanged = (_livingRoomGeneral !=null);
						DesetupSyncLivingRoomGeneral(true, true);
						if(raisePropertyChanged)
						{
							OnPropertyChanged("LivingRoomGeneral");
						}
					}
					else
					{
						if(_livingRoomGeneral!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "LivingRoom");
							SetupSyncLivingRoomGeneral(value);
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for LivingRoomGeneral. When set to true, LivingRoomGeneral is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time LivingRoomGeneral is accessed. You can always execute a forced fetch by calling GetSingleLivingRoomGeneral(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchLivingRoomGeneral
		{
			get	{ return _alwaysFetchLivingRoomGeneral; }
			set	{ _alwaysFetchLivingRoomGeneral = value; }	
		}
		
		/// <summary>Gets / Sets the lazy loading flag if the property LivingRoomGeneral already has been fetched. Setting this property to false when LivingRoomGeneral has been fetched
		/// will set LivingRoomGeneral to null as well. Setting this property to true while LivingRoomGeneral hasn't been fetched disables lazy loading for LivingRoomGeneral</summary>
		[Browsable(false)]
		public bool AlreadyFetchedLivingRoomGeneral
		{
			get { return _alreadyFetchedLivingRoomGeneral;}
			set 
			{
				if(_alreadyFetchedLivingRoomGeneral && !value)
				{
					this.LivingRoomGeneral = null;
				}
				_alreadyFetchedLivingRoomGeneral = value;
			}
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property LivingRoomGeneral is not found
		/// in the database. When set to true, LivingRoomGeneral will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool LivingRoomGeneralReturnsNewIfNotFound
		{
			get	{ return _livingRoomGeneralReturnsNewIfNotFound; }
			set	{ _livingRoomGeneralReturnsNewIfNotFound = value; }	
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
			get { return (int)AmstaJanBonga.Business.EntityType.LivingRoomEntity; }
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
