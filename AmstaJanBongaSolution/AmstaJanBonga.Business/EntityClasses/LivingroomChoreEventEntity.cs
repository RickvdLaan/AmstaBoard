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

	/// <summary>Entity class which represents the entity 'LivingroomChoreEvent'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class LivingroomChoreEventEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private LivingroomEntity _livingroom;
		private bool	_alwaysFetchLivingroom, _alreadyFetchedLivingroom, _livingroomReturnsNewIfNotFound;
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
			/// <summary>Member name Livingroom</summary>
			public static readonly string Livingroom = "Livingroom";
			/// <summary>Member name Patient</summary>
			public static readonly string Patient = "Patient";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static LivingroomChoreEventEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public LivingroomChoreEventEntity() :base("LivingroomChoreEventEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="date">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="livingroomId">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="patientId">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="timeOfDayTypeEnum">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		public LivingroomChoreEventEntity(System.DateTime date, System.Int32 livingroomId, System.Int32 patientId, System.Byte timeOfDayTypeEnum):base("LivingroomChoreEventEntity")
		{
			InitClassFetch(date, livingroomId, patientId, timeOfDayTypeEnum, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="date">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="livingroomId">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="patientId">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="timeOfDayTypeEnum">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public LivingroomChoreEventEntity(System.DateTime date, System.Int32 livingroomId, System.Int32 patientId, System.Byte timeOfDayTypeEnum, IPrefetchPath prefetchPathToUse):base("LivingroomChoreEventEntity")
		{
			InitClassFetch(date, livingroomId, patientId, timeOfDayTypeEnum, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="date">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="livingroomId">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="patientId">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="timeOfDayTypeEnum">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="validator">The custom validator object for this LivingroomChoreEventEntity</param>
		public LivingroomChoreEventEntity(System.DateTime date, System.Int32 livingroomId, System.Int32 patientId, System.Byte timeOfDayTypeEnum, IValidator validator):base("LivingroomChoreEventEntity")
		{
			InitClassFetch(date, livingroomId, patientId, timeOfDayTypeEnum, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected LivingroomChoreEventEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_livingroom = (LivingroomEntity)info.GetValue("_livingroom", typeof(LivingroomEntity));
			if(_livingroom!=null)
			{
				_livingroom.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_livingroomReturnsNewIfNotFound = info.GetBoolean("_livingroomReturnsNewIfNotFound");
			_alwaysFetchLivingroom = info.GetBoolean("_alwaysFetchLivingroom");
			_alreadyFetchedLivingroom = info.GetBoolean("_alreadyFetchedLivingroom");

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
			switch((LivingroomChoreEventFieldIndex)fieldIndex)
			{
				case LivingroomChoreEventFieldIndex.LivingroomId:
					DesetupSyncLivingroom(true, false);
					_alreadyFetchedLivingroom = false;
					break;
				case LivingroomChoreEventFieldIndex.PatientId:
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
			_alreadyFetchedLivingroom = (_livingroom != null);
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
				case "Livingroom":
					toReturn.Add(Relations.LivingroomEntityUsingLivingroomId);
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
			info.AddValue("_livingroom", (!this.MarkedForDeletion?_livingroom:null));
			info.AddValue("_livingroomReturnsNewIfNotFound", _livingroomReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchLivingroom", _alwaysFetchLivingroom);
			info.AddValue("_alreadyFetchedLivingroom", _alreadyFetchedLivingroom);
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
				case "Livingroom":
					_alreadyFetchedLivingroom = true;
					this.Livingroom = (LivingroomEntity)entity;
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
				case "Livingroom":
					SetupSyncLivingroom(relatedEntity);
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
				case "Livingroom":
					DesetupSyncLivingroom(false, true);
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
			if(_livingroom!=null)
			{
				toReturn.Add(_livingroom);
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
		/// <param name="date">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="livingroomId">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="patientId">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="timeOfDayTypeEnum">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.DateTime date, System.Int32 livingroomId, System.Int32 patientId, System.Byte timeOfDayTypeEnum)
		{
			return FetchUsingPK(date, livingroomId, patientId, timeOfDayTypeEnum, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="date">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="livingroomId">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="patientId">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="timeOfDayTypeEnum">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.DateTime date, System.Int32 livingroomId, System.Int32 patientId, System.Byte timeOfDayTypeEnum, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(date, livingroomId, patientId, timeOfDayTypeEnum, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="date">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="livingroomId">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="patientId">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="timeOfDayTypeEnum">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.DateTime date, System.Int32 livingroomId, System.Int32 patientId, System.Byte timeOfDayTypeEnum, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(date, livingroomId, patientId, timeOfDayTypeEnum, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="date">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="livingroomId">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="patientId">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="timeOfDayTypeEnum">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.DateTime date, System.Int32 livingroomId, System.Int32 patientId, System.Byte timeOfDayTypeEnum, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(date, livingroomId, patientId, timeOfDayTypeEnum, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.Date, this.LivingroomId, this.PatientId, this.TimeOfDayTypeEnum, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new LivingroomChoreEventRelations().GetAllRelations();
		}

		/// <summary> Retrieves the related entity of type 'LivingroomEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'LivingroomEntity' which is related to this entity.</returns>
		public LivingroomEntity GetSingleLivingroom()
		{
			return GetSingleLivingroom(false);
		}

		/// <summary> Retrieves the related entity of type 'LivingroomEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'LivingroomEntity' which is related to this entity.</returns>
		public virtual LivingroomEntity GetSingleLivingroom(bool forceFetch)
		{
			if( ( !_alreadyFetchedLivingroom || forceFetch || _alwaysFetchLivingroom) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.LivingroomEntityUsingLivingroomId);
				LivingroomEntity newEntity = new LivingroomEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.LivingroomId);
				}
				if(fetchResult)
				{
					newEntity = (LivingroomEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_livingroomReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Livingroom = newEntity;
				_alreadyFetchedLivingroom = fetchResult;
			}
			return _livingroom;
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
			toReturn.Add("Livingroom", _livingroom);
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
		/// <param name="date">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="livingroomId">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="patientId">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="timeOfDayTypeEnum">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="validator">The validator object for this LivingroomChoreEventEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.DateTime date, System.Int32 livingroomId, System.Int32 patientId, System.Byte timeOfDayTypeEnum, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(date, livingroomId, patientId, timeOfDayTypeEnum, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_livingroomReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("Date", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateCreated", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateLastModified", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateLastModifiedByUserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LivingroomId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PatientId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TimeOfDayTypeEnum", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _livingroom</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncLivingroom(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _livingroom, new PropertyChangedEventHandler( OnLivingroomPropertyChanged ), "Livingroom", AmstaJanBonga.Business.RelationClasses.StaticLivingroomChoreEventRelations.LivingroomEntityUsingLivingroomIdStatic, true, signalRelatedEntity, "LivingroomChoreEvents", resetFKFields, new int[] { (int)LivingroomChoreEventFieldIndex.LivingroomId } );		
			_livingroom = null;
		}
		
		/// <summary> setups the sync logic for member _livingroom</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncLivingroom(IEntityCore relatedEntity)
		{
			if(_livingroom!=relatedEntity)
			{		
				DesetupSyncLivingroom(true, true);
				_livingroom = (LivingroomEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _livingroom, new PropertyChangedEventHandler( OnLivingroomPropertyChanged ), "Livingroom", AmstaJanBonga.Business.RelationClasses.StaticLivingroomChoreEventRelations.LivingroomEntityUsingLivingroomIdStatic, true, ref _alreadyFetchedLivingroom, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnLivingroomPropertyChanged( object sender, PropertyChangedEventArgs e )
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
			this.PerformDesetupSyncRelatedEntity( _patient, new PropertyChangedEventHandler( OnPatientPropertyChanged ), "Patient", AmstaJanBonga.Business.RelationClasses.StaticLivingroomChoreEventRelations.PatientEntityUsingPatientIdStatic, true, signalRelatedEntity, "LivingroomChoreEvents", resetFKFields, new int[] { (int)LivingroomChoreEventFieldIndex.PatientId } );		
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
				this.PerformSetupSyncRelatedEntity( _patient, new PropertyChangedEventHandler( OnPatientPropertyChanged ), "Patient", AmstaJanBonga.Business.RelationClasses.StaticLivingroomChoreEventRelations.PatientEntityUsingPatientIdStatic, true, ref _alreadyFetchedPatient, new string[] {  } );
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
		/// <param name="date">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="livingroomId">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="patientId">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="timeOfDayTypeEnum">PK value for LivingroomChoreEvent which data should be fetched into this LivingroomChoreEvent object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.DateTime date, System.Int32 livingroomId, System.Int32 patientId, System.Byte timeOfDayTypeEnum, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)LivingroomChoreEventFieldIndex.Date].ForcedCurrentValueWrite(date);
				this.Fields[(int)LivingroomChoreEventFieldIndex.LivingroomId].ForcedCurrentValueWrite(livingroomId);
				this.Fields[(int)LivingroomChoreEventFieldIndex.PatientId].ForcedCurrentValueWrite(patientId);
				this.Fields[(int)LivingroomChoreEventFieldIndex.TimeOfDayTypeEnum].ForcedCurrentValueWrite(timeOfDayTypeEnum);
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
			return DAOFactory.CreateLivingroomChoreEventDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new LivingroomChoreEventEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static LivingroomChoreEventRelations Relations
		{
			get	{ return new LivingroomChoreEventRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Livingroom'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathLivingroom
		{
			get	{ return new PrefetchPathElement(new AmstaJanBonga.Business.CollectionClasses.LivingroomCollection(), (IEntityRelation)GetRelationsForField("Livingroom")[0], (int)AmstaJanBonga.Business.EntityType.LivingroomChoreEventEntity, (int)AmstaJanBonga.Business.EntityType.LivingroomEntity, 0, null, null, null, "Livingroom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Patient'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathPatient
		{
			get	{ return new PrefetchPathElement(new AmstaJanBonga.Business.CollectionClasses.PatientCollection(), (IEntityRelation)GetRelationsForField("Patient")[0], (int)AmstaJanBonga.Business.EntityType.LivingroomChoreEventEntity, (int)AmstaJanBonga.Business.EntityType.PatientEntity, 0, null, null, null, "Patient", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The Date property of the Entity LivingroomChoreEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "LivingroomChoreEvent"."Date"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.DateTime Date
		{
			get { return (System.DateTime)GetValue((int)LivingroomChoreEventFieldIndex.Date, true); }
			set	{ SetValue((int)LivingroomChoreEventFieldIndex.Date, value, true); }
		}

		/// <summary> The DateCreated property of the Entity LivingroomChoreEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "LivingroomChoreEvent"."DateCreated"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DateCreated
		{
			get { return (System.DateTime)GetValue((int)LivingroomChoreEventFieldIndex.DateCreated, true); }
			set	{ SetValue((int)LivingroomChoreEventFieldIndex.DateCreated, value, true); }
		}

		/// <summary> The DateLastModified property of the Entity LivingroomChoreEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "LivingroomChoreEvent"."DateLastModified"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateLastModified
		{
			get { return (Nullable<System.DateTime>)GetValue((int)LivingroomChoreEventFieldIndex.DateLastModified, false); }
			set	{ SetValue((int)LivingroomChoreEventFieldIndex.DateLastModified, value, true); }
		}

		/// <summary> The DateLastModifiedByUserId property of the Entity LivingroomChoreEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "LivingroomChoreEvent"."DateLastModifiedByUserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> DateLastModifiedByUserId
		{
			get { return (Nullable<System.Int32>)GetValue((int)LivingroomChoreEventFieldIndex.DateLastModifiedByUserId, false); }
			set	{ SetValue((int)LivingroomChoreEventFieldIndex.DateLastModifiedByUserId, value, true); }
		}

		/// <summary> The LivingroomId property of the Entity LivingroomChoreEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "LivingroomChoreEvent"."LivingroomId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 LivingroomId
		{
			get { return (System.Int32)GetValue((int)LivingroomChoreEventFieldIndex.LivingroomId, true); }
			set	{ SetValue((int)LivingroomChoreEventFieldIndex.LivingroomId, value, true); }
		}

		/// <summary> The PatientId property of the Entity LivingroomChoreEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "LivingroomChoreEvent"."PatientId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 PatientId
		{
			get { return (System.Int32)GetValue((int)LivingroomChoreEventFieldIndex.PatientId, true); }
			set	{ SetValue((int)LivingroomChoreEventFieldIndex.PatientId, value, true); }
		}

		/// <summary> The TimeOfDayTypeEnum property of the Entity LivingroomChoreEvent<br/><br/></summary>
		/// <remarks>Mapped on  table field: "LivingroomChoreEvent"."TimeOfDayTypeEnum"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Byte TimeOfDayTypeEnum
		{
			get { return (System.Byte)GetValue((int)LivingroomChoreEventFieldIndex.TimeOfDayTypeEnum, true); }
			set	{ SetValue((int)LivingroomChoreEventFieldIndex.TimeOfDayTypeEnum, value, true); }
		}


		/// <summary> Gets / sets related entity of type 'LivingroomEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleLivingroom()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual LivingroomEntity Livingroom
		{
			get	{ return GetSingleLivingroom(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncLivingroom(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "LivingroomChoreEvents", "Livingroom", _livingroom, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Livingroom. When set to true, Livingroom is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Livingroom is accessed. You can always execute a forced fetch by calling GetSingleLivingroom(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchLivingroom
		{
			get	{ return _alwaysFetchLivingroom; }
			set	{ _alwaysFetchLivingroom = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Livingroom already has been fetched. Setting this property to false when Livingroom has been fetched
		/// will set Livingroom to null as well. Setting this property to true while Livingroom hasn't been fetched disables lazy loading for Livingroom</summary>
		[Browsable(false)]
		public bool AlreadyFetchedLivingroom
		{
			get { return _alreadyFetchedLivingroom;}
			set 
			{
				if(_alreadyFetchedLivingroom && !value)
				{
					this.Livingroom = null;
				}
				_alreadyFetchedLivingroom = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Livingroom is not found
		/// in the database. When set to true, Livingroom will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool LivingroomReturnsNewIfNotFound
		{
			get	{ return _livingroomReturnsNewIfNotFound; }
			set { _livingroomReturnsNewIfNotFound = value; }	
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
					SetSingleRelatedEntityNavigator(value, "LivingroomChoreEvents", "Patient", _patient, true); 
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
			get { return (int)AmstaJanBonga.Business.EntityType.LivingroomChoreEventEntity; }
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
