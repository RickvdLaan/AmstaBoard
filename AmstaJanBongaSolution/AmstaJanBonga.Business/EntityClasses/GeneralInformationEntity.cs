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

	/// <summary>Entity class which represents the entity 'GeneralInformation'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class GeneralInformationEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private GeneralLivingroomEntity _generalLivingroom;
		private bool	_alwaysFetchGeneralLivingroom, _alreadyFetchedGeneralLivingroom, _generalLivingroomReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name GeneralLivingroom</summary>
			public static readonly string GeneralLivingroom = "GeneralLivingroom";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static GeneralInformationEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public GeneralInformationEntity() :base("GeneralInformationEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="date">PK value for GeneralInformation which data should be fetched into this GeneralInformation object</param>
		/// <param name="livingroomId">PK value for GeneralInformation which data should be fetched into this GeneralInformation object</param>
		public GeneralInformationEntity(System.DateTime date, System.Int32 livingroomId):base("GeneralInformationEntity")
		{
			InitClassFetch(date, livingroomId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="date">PK value for GeneralInformation which data should be fetched into this GeneralInformation object</param>
		/// <param name="livingroomId">PK value for GeneralInformation which data should be fetched into this GeneralInformation object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public GeneralInformationEntity(System.DateTime date, System.Int32 livingroomId, IPrefetchPath prefetchPathToUse):base("GeneralInformationEntity")
		{
			InitClassFetch(date, livingroomId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="date">PK value for GeneralInformation which data should be fetched into this GeneralInformation object</param>
		/// <param name="livingroomId">PK value for GeneralInformation which data should be fetched into this GeneralInformation object</param>
		/// <param name="validator">The custom validator object for this GeneralInformationEntity</param>
		public GeneralInformationEntity(System.DateTime date, System.Int32 livingroomId, IValidator validator):base("GeneralInformationEntity")
		{
			InitClassFetch(date, livingroomId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected GeneralInformationEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_generalLivingroom = (GeneralLivingroomEntity)info.GetValue("_generalLivingroom", typeof(GeneralLivingroomEntity));
			if(_generalLivingroom!=null)
			{
				_generalLivingroom.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_generalLivingroomReturnsNewIfNotFound = info.GetBoolean("_generalLivingroomReturnsNewIfNotFound");
			_alwaysFetchGeneralLivingroom = info.GetBoolean("_alwaysFetchGeneralLivingroom");
			_alreadyFetchedGeneralLivingroom = info.GetBoolean("_alreadyFetchedGeneralLivingroom");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((GeneralInformationFieldIndex)fieldIndex)
			{
				case GeneralInformationFieldIndex.LivingroomId:
					DesetupSyncGeneralLivingroom(true, false);
					_alreadyFetchedGeneralLivingroom = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedGeneralLivingroom = (_generalLivingroom != null);
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
				case "GeneralLivingroom":
					toReturn.Add(Relations.GeneralLivingroomEntityUsingLivingroomId);
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
			info.AddValue("_generalLivingroom", (!this.MarkedForDeletion?_generalLivingroom:null));
			info.AddValue("_generalLivingroomReturnsNewIfNotFound", _generalLivingroomReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchGeneralLivingroom", _alwaysFetchGeneralLivingroom);
			info.AddValue("_alreadyFetchedGeneralLivingroom", _alreadyFetchedGeneralLivingroom);

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
				case "GeneralLivingroom":
					_alreadyFetchedGeneralLivingroom = true;
					this.GeneralLivingroom = (GeneralLivingroomEntity)entity;
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
				case "GeneralLivingroom":
					SetupSyncGeneralLivingroom(relatedEntity);
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
				case "GeneralLivingroom":
					DesetupSyncGeneralLivingroom(false, true);
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
			if(_generalLivingroom!=null)
			{
				toReturn.Add(_generalLivingroom);
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
		/// <param name="date">PK value for GeneralInformation which data should be fetched into this GeneralInformation object</param>
		/// <param name="livingroomId">PK value for GeneralInformation which data should be fetched into this GeneralInformation object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.DateTime date, System.Int32 livingroomId)
		{
			return FetchUsingPK(date, livingroomId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="date">PK value for GeneralInformation which data should be fetched into this GeneralInformation object</param>
		/// <param name="livingroomId">PK value for GeneralInformation which data should be fetched into this GeneralInformation object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.DateTime date, System.Int32 livingroomId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(date, livingroomId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="date">PK value for GeneralInformation which data should be fetched into this GeneralInformation object</param>
		/// <param name="livingroomId">PK value for GeneralInformation which data should be fetched into this GeneralInformation object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.DateTime date, System.Int32 livingroomId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(date, livingroomId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="date">PK value for GeneralInformation which data should be fetched into this GeneralInformation object</param>
		/// <param name="livingroomId">PK value for GeneralInformation which data should be fetched into this GeneralInformation object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.DateTime date, System.Int32 livingroomId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(date, livingroomId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.Date, this.LivingroomId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new GeneralInformationRelations().GetAllRelations();
		}

		/// <summary> Retrieves the related entity of type 'GeneralLivingroomEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'GeneralLivingroomEntity' which is related to this entity.</returns>
		public GeneralLivingroomEntity GetSingleGeneralLivingroom()
		{
			return GetSingleGeneralLivingroom(false);
		}

		/// <summary> Retrieves the related entity of type 'GeneralLivingroomEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'GeneralLivingroomEntity' which is related to this entity.</returns>
		public virtual GeneralLivingroomEntity GetSingleGeneralLivingroom(bool forceFetch)
		{
			if( ( !_alreadyFetchedGeneralLivingroom || forceFetch || _alwaysFetchGeneralLivingroom) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.GeneralLivingroomEntityUsingLivingroomId);
				GeneralLivingroomEntity newEntity = new GeneralLivingroomEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.LivingroomId);
				}
				if(fetchResult)
				{
					newEntity = (GeneralLivingroomEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_generalLivingroomReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.GeneralLivingroom = newEntity;
				_alreadyFetchedGeneralLivingroom = fetchResult;
			}
			return _generalLivingroom;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("GeneralLivingroom", _generalLivingroom);
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
		/// <param name="date">PK value for GeneralInformation which data should be fetched into this GeneralInformation object</param>
		/// <param name="livingroomId">PK value for GeneralInformation which data should be fetched into this GeneralInformation object</param>
		/// <param name="validator">The validator object for this GeneralInformationEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.DateTime date, System.Int32 livingroomId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(date, livingroomId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_generalLivingroomReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("DateDeleted", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateLastModified", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateLastModifiedByUserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsActive", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsMarkedAsDeleted", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LivingroomId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _generalLivingroom</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncGeneralLivingroom(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _generalLivingroom, new PropertyChangedEventHandler( OnGeneralLivingroomPropertyChanged ), "GeneralLivingroom", AmstaJanBonga.Business.RelationClasses.StaticGeneralInformationRelations.GeneralLivingroomEntityUsingLivingroomIdStatic, true, signalRelatedEntity, "GeneralInformations", resetFKFields, new int[] { (int)GeneralInformationFieldIndex.LivingroomId } );		
			_generalLivingroom = null;
		}
		
		/// <summary> setups the sync logic for member _generalLivingroom</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncGeneralLivingroom(IEntityCore relatedEntity)
		{
			if(_generalLivingroom!=relatedEntity)
			{		
				DesetupSyncGeneralLivingroom(true, true);
				_generalLivingroom = (GeneralLivingroomEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _generalLivingroom, new PropertyChangedEventHandler( OnGeneralLivingroomPropertyChanged ), "GeneralLivingroom", AmstaJanBonga.Business.RelationClasses.StaticGeneralInformationRelations.GeneralLivingroomEntityUsingLivingroomIdStatic, true, ref _alreadyFetchedGeneralLivingroom, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnGeneralLivingroomPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="date">PK value for GeneralInformation which data should be fetched into this GeneralInformation object</param>
		/// <param name="livingroomId">PK value for GeneralInformation which data should be fetched into this GeneralInformation object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.DateTime date, System.Int32 livingroomId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)GeneralInformationFieldIndex.Date].ForcedCurrentValueWrite(date);
				this.Fields[(int)GeneralInformationFieldIndex.LivingroomId].ForcedCurrentValueWrite(livingroomId);
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
			return DAOFactory.CreateGeneralInformationDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new GeneralInformationEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static GeneralInformationRelations Relations
		{
			get	{ return new GeneralInformationRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'GeneralLivingroom'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathGeneralLivingroom
		{
			get	{ return new PrefetchPathElement(new AmstaJanBonga.Business.CollectionClasses.GeneralLivingroomCollection(), (IEntityRelation)GetRelationsForField("GeneralLivingroom")[0], (int)AmstaJanBonga.Business.EntityType.GeneralInformationEntity, (int)AmstaJanBonga.Business.EntityType.GeneralLivingroomEntity, 0, null, null, null, "GeneralLivingroom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The Date property of the Entity GeneralInformation<br/><br/></summary>
		/// <remarks>Mapped on  table field: "GeneralInformation"."Date"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.DateTime Date
		{
			get { return (System.DateTime)GetValue((int)GeneralInformationFieldIndex.Date, true); }
			set	{ SetValue((int)GeneralInformationFieldIndex.Date, value, true); }
		}

		/// <summary> The DateCreated property of the Entity GeneralInformation<br/><br/></summary>
		/// <remarks>Mapped on  table field: "GeneralInformation"."DateCreated"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DateCreated
		{
			get { return (System.DateTime)GetValue((int)GeneralInformationFieldIndex.DateCreated, true); }
			set	{ SetValue((int)GeneralInformationFieldIndex.DateCreated, value, true); }
		}

		/// <summary> The DateDeleted property of the Entity GeneralInformation<br/><br/></summary>
		/// <remarks>Mapped on  table field: "GeneralInformation"."DateDeleted"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateDeleted
		{
			get { return (Nullable<System.DateTime>)GetValue((int)GeneralInformationFieldIndex.DateDeleted, false); }
			set	{ SetValue((int)GeneralInformationFieldIndex.DateDeleted, value, true); }
		}

		/// <summary> The DateLastModified property of the Entity GeneralInformation<br/><br/></summary>
		/// <remarks>Mapped on  table field: "GeneralInformation"."DateLastModified"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateLastModified
		{
			get { return (Nullable<System.DateTime>)GetValue((int)GeneralInformationFieldIndex.DateLastModified, false); }
			set	{ SetValue((int)GeneralInformationFieldIndex.DateLastModified, value, true); }
		}

		/// <summary> The DateLastModifiedByUserId property of the Entity GeneralInformation<br/><br/></summary>
		/// <remarks>Mapped on  table field: "GeneralInformation"."DateLastModifiedByUserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> DateLastModifiedByUserId
		{
			get { return (Nullable<System.Int32>)GetValue((int)GeneralInformationFieldIndex.DateLastModifiedByUserId, false); }
			set	{ SetValue((int)GeneralInformationFieldIndex.DateLastModifiedByUserId, value, true); }
		}

		/// <summary> The Description property of the Entity GeneralInformation<br/><br/></summary>
		/// <remarks>Mapped on  table field: "GeneralInformation"."Description"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)GeneralInformationFieldIndex.Description, true); }
			set	{ SetValue((int)GeneralInformationFieldIndex.Description, value, true); }
		}

		/// <summary> The IsActive property of the Entity GeneralInformation<br/><br/></summary>
		/// <remarks>Mapped on  table field: "GeneralInformation"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)GeneralInformationFieldIndex.IsActive, true); }
			set	{ SetValue((int)GeneralInformationFieldIndex.IsActive, value, true); }
		}

		/// <summary> The IsMarkedAsDeleted property of the Entity GeneralInformation<br/><br/></summary>
		/// <remarks>Mapped on  table field: "GeneralInformation"."IsMarkedAsDeleted"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsMarkedAsDeleted
		{
			get { return (System.Boolean)GetValue((int)GeneralInformationFieldIndex.IsMarkedAsDeleted, true); }
			set	{ SetValue((int)GeneralInformationFieldIndex.IsMarkedAsDeleted, value, true); }
		}

		/// <summary> The LivingroomId property of the Entity GeneralInformation<br/><br/></summary>
		/// <remarks>Mapped on  table field: "GeneralInformation"."LivingroomId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 LivingroomId
		{
			get { return (System.Int32)GetValue((int)GeneralInformationFieldIndex.LivingroomId, true); }
			set	{ SetValue((int)GeneralInformationFieldIndex.LivingroomId, value, true); }
		}


		/// <summary> Gets / sets related entity of type 'GeneralLivingroomEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleGeneralLivingroom()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual GeneralLivingroomEntity GeneralLivingroom
		{
			get	{ return GetSingleGeneralLivingroom(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncGeneralLivingroom(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "GeneralInformations", "GeneralLivingroom", _generalLivingroom, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for GeneralLivingroom. When set to true, GeneralLivingroom is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time GeneralLivingroom is accessed. You can always execute a forced fetch by calling GetSingleGeneralLivingroom(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchGeneralLivingroom
		{
			get	{ return _alwaysFetchGeneralLivingroom; }
			set	{ _alwaysFetchGeneralLivingroom = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property GeneralLivingroom already has been fetched. Setting this property to false when GeneralLivingroom has been fetched
		/// will set GeneralLivingroom to null as well. Setting this property to true while GeneralLivingroom hasn't been fetched disables lazy loading for GeneralLivingroom</summary>
		[Browsable(false)]
		public bool AlreadyFetchedGeneralLivingroom
		{
			get { return _alreadyFetchedGeneralLivingroom;}
			set 
			{
				if(_alreadyFetchedGeneralLivingroom && !value)
				{
					this.GeneralLivingroom = null;
				}
				_alreadyFetchedGeneralLivingroom = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property GeneralLivingroom is not found
		/// in the database. When set to true, GeneralLivingroom will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool GeneralLivingroomReturnsNewIfNotFound
		{
			get	{ return _generalLivingroomReturnsNewIfNotFound; }
			set { _generalLivingroomReturnsNewIfNotFound = value; }	
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
			get { return (int)AmstaJanBonga.Business.EntityType.GeneralInformationEntity; }
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
