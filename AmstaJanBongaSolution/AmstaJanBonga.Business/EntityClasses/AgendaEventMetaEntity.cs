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

	/// <summary>Entity class which represents the entity 'AgendaEventMeta'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class AgendaEventMetaEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AgendaEventEntity _agendaEvent;
		private bool	_alwaysFetchAgendaEvent, _alreadyFetchedAgendaEvent, _agendaEventReturnsNewIfNotFound;
		private PatientEntity _patient;
		private bool	_alwaysFetchPatient, _alreadyFetchedPatient, _patientReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name AgendaEvent</summary>
			public static readonly string AgendaEvent = "AgendaEvent";
			/// <summary>Member name Patient</summary>
			public static readonly string Patient = "Patient";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static AgendaEventMetaEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public AgendaEventMetaEntity() :base("AgendaEventMetaEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="id">PK value for AgendaEventMeta which data should be fetched into this AgendaEventMeta object</param>
		public AgendaEventMetaEntity(System.Int32 id):base("AgendaEventMetaEntity")
		{
			InitClassFetch(id, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for AgendaEventMeta which data should be fetched into this AgendaEventMeta object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public AgendaEventMetaEntity(System.Int32 id, IPrefetchPath prefetchPathToUse):base("AgendaEventMetaEntity")
		{
			InitClassFetch(id, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for AgendaEventMeta which data should be fetched into this AgendaEventMeta object</param>
		/// <param name="validator">The custom validator object for this AgendaEventMetaEntity</param>
		public AgendaEventMetaEntity(System.Int32 id, IValidator validator):base("AgendaEventMetaEntity")
		{
			InitClassFetch(id, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AgendaEventMetaEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_agendaEvent = (AgendaEventEntity)info.GetValue("_agendaEvent", typeof(AgendaEventEntity));
			if(_agendaEvent!=null)
			{
				_agendaEvent.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_agendaEventReturnsNewIfNotFound = info.GetBoolean("_agendaEventReturnsNewIfNotFound");
			_alwaysFetchAgendaEvent = info.GetBoolean("_alwaysFetchAgendaEvent");
			_alreadyFetchedAgendaEvent = info.GetBoolean("_alreadyFetchedAgendaEvent");

			_patient = (PatientEntity)info.GetValue("_patient", typeof(PatientEntity));
			if(_patient!=null)
			{
				_patient.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_patientReturnsNewIfNotFound = info.GetBoolean("_patientReturnsNewIfNotFound");
			_alwaysFetchPatient = info.GetBoolean("_alwaysFetchPatient");
			_alreadyFetchedPatient = info.GetBoolean("_alreadyFetchedPatient");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((AgendaEventMetaFieldIndex)fieldIndex)
			{
				case AgendaEventMetaFieldIndex.AgendaEventId:
					DesetupSyncAgendaEvent(true, false);
					_alreadyFetchedAgendaEvent = false;
					break;
				case AgendaEventMetaFieldIndex.PatientId:
					DesetupSyncPatient(true, false);
					_alreadyFetchedPatient = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedAgendaEvent = (_agendaEvent != null);
			_alreadyFetchedPatient = (_patient != null);
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
				case "AgendaEvent":
					toReturn.Add(Relations.AgendaEventEntityUsingAgendaEventId);
					break;
				case "Patient":
					toReturn.Add(Relations.PatientEntityUsingPatientId);
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
			info.AddValue("_agendaEvent", (!this.MarkedForDeletion?_agendaEvent:null));
			info.AddValue("_agendaEventReturnsNewIfNotFound", _agendaEventReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchAgendaEvent", _alwaysFetchAgendaEvent);
			info.AddValue("_alreadyFetchedAgendaEvent", _alreadyFetchedAgendaEvent);
			info.AddValue("_patient", (!this.MarkedForDeletion?_patient:null));
			info.AddValue("_patientReturnsNewIfNotFound", _patientReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchPatient", _alwaysFetchPatient);
			info.AddValue("_alreadyFetchedPatient", _alreadyFetchedPatient);

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
				case "AgendaEvent":
					_alreadyFetchedAgendaEvent = true;
					this.AgendaEvent = (AgendaEventEntity)entity;
					break;
				case "Patient":
					_alreadyFetchedPatient = true;
					this.Patient = (PatientEntity)entity;
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
				case "AgendaEvent":
					SetupSyncAgendaEvent(relatedEntity);
					break;
				case "Patient":
					SetupSyncPatient(relatedEntity);
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
				case "AgendaEvent":
					DesetupSyncAgendaEvent(false, true);
					break;
				case "Patient":
					DesetupSyncPatient(false, true);
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
			if(_agendaEvent!=null)
			{
				toReturn.Add(_agendaEvent);
			}
			if(_patient!=null)
			{
				toReturn.Add(_patient);
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
		/// <param name="id">PK value for AgendaEventMeta which data should be fetched into this AgendaEventMeta object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id)
		{
			return FetchUsingPK(id, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for AgendaEventMeta which data should be fetched into this AgendaEventMeta object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for AgendaEventMeta which data should be fetched into this AgendaEventMeta object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for AgendaEventMeta which data should be fetched into this AgendaEventMeta object</param>
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
			return new AgendaEventMetaRelations().GetAllRelations();
		}

		/// <summary> Retrieves the related entity of type 'AgendaEventEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'AgendaEventEntity' which is related to this entity.</returns>
		public AgendaEventEntity GetSingleAgendaEvent()
		{
			return GetSingleAgendaEvent(false);
		}

		/// <summary> Retrieves the related entity of type 'AgendaEventEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'AgendaEventEntity' which is related to this entity.</returns>
		public virtual AgendaEventEntity GetSingleAgendaEvent(bool forceFetch)
		{
			if( ( !_alreadyFetchedAgendaEvent || forceFetch || _alwaysFetchAgendaEvent) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.AgendaEventEntityUsingAgendaEventId);
				AgendaEventEntity newEntity = new AgendaEventEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.AgendaEventId);
				}
				if(fetchResult)
				{
					newEntity = (AgendaEventEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_agendaEventReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.AgendaEvent = newEntity;
				_alreadyFetchedAgendaEvent = fetchResult;
			}
			return _agendaEvent;
		}


		/// <summary> Retrieves the related entity of type 'PatientEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'PatientEntity' which is related to this entity.</returns>
		public PatientEntity GetSinglePatient()
		{
			return GetSinglePatient(false);
		}

		/// <summary> Retrieves the related entity of type 'PatientEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'PatientEntity' which is related to this entity.</returns>
		public virtual PatientEntity GetSinglePatient(bool forceFetch)
		{
			if( ( !_alreadyFetchedPatient || forceFetch || _alwaysFetchPatient) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.PatientEntityUsingPatientId);
				PatientEntity newEntity = new PatientEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.PatientId);
				}
				if(fetchResult)
				{
					newEntity = (PatientEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_patientReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Patient = newEntity;
				_alreadyFetchedPatient = fetchResult;
			}
			return _patient;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("AgendaEvent", _agendaEvent);
			toReturn.Add("Patient", _patient);
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
		/// <param name="id">PK value for AgendaEventMeta which data should be fetched into this AgendaEventMeta object</param>
		/// <param name="validator">The validator object for this AgendaEventMetaEntity</param>
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
			_agendaEventReturnsNewIfNotFound = false;
			_patientReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("AgendaEventId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateCreated", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateDeleted", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateLastModified", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateLastModifiedByUserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("EventUnixTimeStamp", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Id", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsMarkedAsDeleted", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PatientId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("RepeatInterval", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _agendaEvent</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAgendaEvent(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _agendaEvent, new PropertyChangedEventHandler( OnAgendaEventPropertyChanged ), "AgendaEvent", AmstaJanBonga.Business.RelationClasses.StaticAgendaEventMetaRelations.AgendaEventEntityUsingAgendaEventIdStatic, true, signalRelatedEntity, "AgendaEventMetas", resetFKFields, new int[] { (int)AgendaEventMetaFieldIndex.AgendaEventId } );		
			_agendaEvent = null;
		}
		
		/// <summary> setups the sync logic for member _agendaEvent</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAgendaEvent(IEntityCore relatedEntity)
		{
			if(_agendaEvent!=relatedEntity)
			{		
				DesetupSyncAgendaEvent(true, true);
				_agendaEvent = (AgendaEventEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _agendaEvent, new PropertyChangedEventHandler( OnAgendaEventPropertyChanged ), "AgendaEvent", AmstaJanBonga.Business.RelationClasses.StaticAgendaEventMetaRelations.AgendaEventEntityUsingAgendaEventIdStatic, true, ref _alreadyFetchedAgendaEvent, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAgendaEventPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _patient</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncPatient(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _patient, new PropertyChangedEventHandler( OnPatientPropertyChanged ), "Patient", AmstaJanBonga.Business.RelationClasses.StaticAgendaEventMetaRelations.PatientEntityUsingPatientIdStatic, true, signalRelatedEntity, "AgendaEventMetas", resetFKFields, new int[] { (int)AgendaEventMetaFieldIndex.PatientId } );		
			_patient = null;
		}
		
		/// <summary> setups the sync logic for member _patient</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncPatient(IEntityCore relatedEntity)
		{
			if(_patient!=relatedEntity)
			{		
				DesetupSyncPatient(true, true);
				_patient = (PatientEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _patient, new PropertyChangedEventHandler( OnPatientPropertyChanged ), "Patient", AmstaJanBonga.Business.RelationClasses.StaticAgendaEventMetaRelations.PatientEntityUsingPatientIdStatic, true, ref _alreadyFetchedPatient, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnPatientPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="id">PK value for AgendaEventMeta which data should be fetched into this AgendaEventMeta object</param>
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
				this.Fields[(int)AgendaEventMetaFieldIndex.Id].ForcedCurrentValueWrite(id);
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
			return DAOFactory.CreateAgendaEventMetaDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new AgendaEventMetaEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static AgendaEventMetaRelations Relations
		{
			get	{ return new AgendaEventMetaRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AgendaEvent'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAgendaEvent
		{
			get	{ return new PrefetchPathElement(new AmstaJanBonga.Business.CollectionClasses.AgendaEventCollection(), (IEntityRelation)GetRelationsForField("AgendaEvent")[0], (int)AmstaJanBonga.Business.EntityType.AgendaEventMetaEntity, (int)AmstaJanBonga.Business.EntityType.AgendaEventEntity, 0, null, null, null, "AgendaEvent", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Patient'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathPatient
		{
			get	{ return new PrefetchPathElement(new AmstaJanBonga.Business.CollectionClasses.PatientCollection(), (IEntityRelation)GetRelationsForField("Patient")[0], (int)AmstaJanBonga.Business.EntityType.AgendaEventMetaEntity, (int)AmstaJanBonga.Business.EntityType.PatientEntity, 0, null, null, null, "Patient", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The AgendaEventId property of the Entity AgendaEventMeta<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AgendaEventMeta"."AgendaEventId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 AgendaEventId
		{
			get { return (System.Int32)GetValue((int)AgendaEventMetaFieldIndex.AgendaEventId, true); }
			set	{ SetValue((int)AgendaEventMetaFieldIndex.AgendaEventId, value, true); }
		}

		/// <summary> The DateCreated property of the Entity AgendaEventMeta<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AgendaEventMeta"."DateCreated"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DateCreated
		{
			get { return (System.DateTime)GetValue((int)AgendaEventMetaFieldIndex.DateCreated, true); }
			set	{ SetValue((int)AgendaEventMetaFieldIndex.DateCreated, value, true); }
		}

		/// <summary> The DateDeleted property of the Entity AgendaEventMeta<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AgendaEventMeta"."DateDeleted"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateDeleted
		{
			get { return (Nullable<System.DateTime>)GetValue((int)AgendaEventMetaFieldIndex.DateDeleted, false); }
			set	{ SetValue((int)AgendaEventMetaFieldIndex.DateDeleted, value, true); }
		}

		/// <summary> The DateLastModified property of the Entity AgendaEventMeta<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AgendaEventMeta"."DateLastModified"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateLastModified
		{
			get { return (Nullable<System.DateTime>)GetValue((int)AgendaEventMetaFieldIndex.DateLastModified, false); }
			set	{ SetValue((int)AgendaEventMetaFieldIndex.DateLastModified, value, true); }
		}

		/// <summary> The DateLastModifiedByUserId property of the Entity AgendaEventMeta<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AgendaEventMeta"."DateLastModifiedByUserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> DateLastModifiedByUserId
		{
			get { return (Nullable<System.Int32>)GetValue((int)AgendaEventMetaFieldIndex.DateLastModifiedByUserId, false); }
			set	{ SetValue((int)AgendaEventMetaFieldIndex.DateLastModifiedByUserId, value, true); }
		}

		/// <summary> The EventUnixTimeStamp property of the Entity AgendaEventMeta<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AgendaEventMeta"."EventUnixTimeStamp"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 EventUnixTimeStamp
		{
			get { return (System.Int32)GetValue((int)AgendaEventMetaFieldIndex.EventUnixTimeStamp, true); }
			set	{ SetValue((int)AgendaEventMetaFieldIndex.EventUnixTimeStamp, value, true); }
		}

		/// <summary> The Id property of the Entity AgendaEventMeta<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AgendaEventMeta"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)AgendaEventMetaFieldIndex.Id, true); }
			set	{ SetValue((int)AgendaEventMetaFieldIndex.Id, value, true); }
		}

		/// <summary> The IsMarkedAsDeleted property of the Entity AgendaEventMeta<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AgendaEventMeta"."IsMarkedAsDeleted"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsMarkedAsDeleted
		{
			get { return (System.Boolean)GetValue((int)AgendaEventMetaFieldIndex.IsMarkedAsDeleted, true); }
			set	{ SetValue((int)AgendaEventMetaFieldIndex.IsMarkedAsDeleted, value, true); }
		}

		/// <summary> The PatientId property of the Entity AgendaEventMeta<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AgendaEventMeta"."PatientId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 PatientId
		{
			get { return (System.Int32)GetValue((int)AgendaEventMetaFieldIndex.PatientId, true); }
			set	{ SetValue((int)AgendaEventMetaFieldIndex.PatientId, value, true); }
		}

		/// <summary> The RepeatInterval property of the Entity AgendaEventMeta<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AgendaEventMeta"."RepeatInterval"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> RepeatInterval
		{
			get { return (Nullable<System.Int32>)GetValue((int)AgendaEventMetaFieldIndex.RepeatInterval, false); }
			set	{ SetValue((int)AgendaEventMetaFieldIndex.RepeatInterval, value, true); }
		}


		/// <summary> Gets / sets related entity of type 'AgendaEventEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAgendaEvent()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual AgendaEventEntity AgendaEvent
		{
			get	{ return GetSingleAgendaEvent(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncAgendaEvent(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "AgendaEventMetas", "AgendaEvent", _agendaEvent, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for AgendaEvent. When set to true, AgendaEvent is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AgendaEvent is accessed. You can always execute a forced fetch by calling GetSingleAgendaEvent(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAgendaEvent
		{
			get	{ return _alwaysFetchAgendaEvent; }
			set	{ _alwaysFetchAgendaEvent = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AgendaEvent already has been fetched. Setting this property to false when AgendaEvent has been fetched
		/// will set AgendaEvent to null as well. Setting this property to true while AgendaEvent hasn't been fetched disables lazy loading for AgendaEvent</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAgendaEvent
		{
			get { return _alreadyFetchedAgendaEvent;}
			set 
			{
				if(_alreadyFetchedAgendaEvent && !value)
				{
					this.AgendaEvent = null;
				}
				_alreadyFetchedAgendaEvent = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property AgendaEvent is not found
		/// in the database. When set to true, AgendaEvent will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool AgendaEventReturnsNewIfNotFound
		{
			get	{ return _agendaEventReturnsNewIfNotFound; }
			set { _agendaEventReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'PatientEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSinglePatient()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual PatientEntity Patient
		{
			get	{ return GetSinglePatient(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncPatient(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "AgendaEventMetas", "Patient", _patient, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Patient. When set to true, Patient is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Patient is accessed. You can always execute a forced fetch by calling GetSinglePatient(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchPatient
		{
			get	{ return _alwaysFetchPatient; }
			set	{ _alwaysFetchPatient = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Patient already has been fetched. Setting this property to false when Patient has been fetched
		/// will set Patient to null as well. Setting this property to true while Patient hasn't been fetched disables lazy loading for Patient</summary>
		[Browsable(false)]
		public bool AlreadyFetchedPatient
		{
			get { return _alreadyFetchedPatient;}
			set 
			{
				if(_alreadyFetchedPatient && !value)
				{
					this.Patient = null;
				}
				_alreadyFetchedPatient = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Patient is not found
		/// in the database. When set to true, Patient will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool PatientReturnsNewIfNotFound
		{
			get	{ return _patientReturnsNewIfNotFound; }
			set { _patientReturnsNewIfNotFound = value; }	
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
			get { return (int)AmstaJanBonga.Business.EntityType.AgendaEventMetaEntity; }
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
