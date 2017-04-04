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

	/// <summary>Entity class which represents the entity 'Livingroom'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class LivingroomEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AmstaJanBonga.Business.CollectionClasses.ChoreCollection	_chores;
		private bool	_alwaysFetchChores, _alreadyFetchedChores;
		private AmstaJanBonga.Business.CollectionClasses.EmployeeLivingroomCollection	_employeeLivingrooms;
		private bool	_alwaysFetchEmployeeLivingrooms, _alreadyFetchedEmployeeLivingrooms;
		private AmstaJanBonga.Business.CollectionClasses.PatientCollection	_patients;
		private bool	_alwaysFetchPatients, _alreadyFetchedPatients;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Chores</summary>
			public static readonly string Chores = "Chores";
			/// <summary>Member name EmployeeLivingrooms</summary>
			public static readonly string EmployeeLivingrooms = "EmployeeLivingrooms";
			/// <summary>Member name Patients</summary>
			public static readonly string Patients = "Patients";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static LivingroomEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public LivingroomEntity() :base("LivingroomEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="id">PK value for Livingroom which data should be fetched into this Livingroom object</param>
		public LivingroomEntity(System.Int32 id):base("LivingroomEntity")
		{
			InitClassFetch(id, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Livingroom which data should be fetched into this Livingroom object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public LivingroomEntity(System.Int32 id, IPrefetchPath prefetchPathToUse):base("LivingroomEntity")
		{
			InitClassFetch(id, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Livingroom which data should be fetched into this Livingroom object</param>
		/// <param name="validator">The custom validator object for this LivingroomEntity</param>
		public LivingroomEntity(System.Int32 id, IValidator validator):base("LivingroomEntity")
		{
			InitClassFetch(id, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected LivingroomEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_chores = (AmstaJanBonga.Business.CollectionClasses.ChoreCollection)info.GetValue("_chores", typeof(AmstaJanBonga.Business.CollectionClasses.ChoreCollection));
			_alwaysFetchChores = info.GetBoolean("_alwaysFetchChores");
			_alreadyFetchedChores = info.GetBoolean("_alreadyFetchedChores");

			_employeeLivingrooms = (AmstaJanBonga.Business.CollectionClasses.EmployeeLivingroomCollection)info.GetValue("_employeeLivingrooms", typeof(AmstaJanBonga.Business.CollectionClasses.EmployeeLivingroomCollection));
			_alwaysFetchEmployeeLivingrooms = info.GetBoolean("_alwaysFetchEmployeeLivingrooms");
			_alreadyFetchedEmployeeLivingrooms = info.GetBoolean("_alreadyFetchedEmployeeLivingrooms");

			_patients = (AmstaJanBonga.Business.CollectionClasses.PatientCollection)info.GetValue("_patients", typeof(AmstaJanBonga.Business.CollectionClasses.PatientCollection));
			_alwaysFetchPatients = info.GetBoolean("_alwaysFetchPatients");
			_alreadyFetchedPatients = info.GetBoolean("_alreadyFetchedPatients");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedChores = (_chores.Count > 0);
			_alreadyFetchedEmployeeLivingrooms = (_employeeLivingrooms.Count > 0);
			_alreadyFetchedPatients = (_patients.Count > 0);
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
				case "Chores":
					toReturn.Add(Relations.ChoreEntityUsingLivingroomId);
					break;
				case "EmployeeLivingrooms":
					toReturn.Add(Relations.EmployeeLivingroomEntityUsingLivingroomId);
					break;
				case "Patients":
					toReturn.Add(Relations.PatientEntityUsingLivingroomId);
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
			info.AddValue("_chores", (!this.MarkedForDeletion?_chores:null));
			info.AddValue("_alwaysFetchChores", _alwaysFetchChores);
			info.AddValue("_alreadyFetchedChores", _alreadyFetchedChores);
			info.AddValue("_employeeLivingrooms", (!this.MarkedForDeletion?_employeeLivingrooms:null));
			info.AddValue("_alwaysFetchEmployeeLivingrooms", _alwaysFetchEmployeeLivingrooms);
			info.AddValue("_alreadyFetchedEmployeeLivingrooms", _alreadyFetchedEmployeeLivingrooms);
			info.AddValue("_patients", (!this.MarkedForDeletion?_patients:null));
			info.AddValue("_alwaysFetchPatients", _alwaysFetchPatients);
			info.AddValue("_alreadyFetchedPatients", _alreadyFetchedPatients);

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
				case "Chores":
					_alreadyFetchedChores = true;
					if(entity!=null)
					{
						this.Chores.Add((ChoreEntity)entity);
					}
					break;
				case "EmployeeLivingrooms":
					_alreadyFetchedEmployeeLivingrooms = true;
					if(entity!=null)
					{
						this.EmployeeLivingrooms.Add((EmployeeLivingroomEntity)entity);
					}
					break;
				case "Patients":
					_alreadyFetchedPatients = true;
					if(entity!=null)
					{
						this.Patients.Add((PatientEntity)entity);
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
				case "Chores":
					_chores.Add((ChoreEntity)relatedEntity);
					break;
				case "EmployeeLivingrooms":
					_employeeLivingrooms.Add((EmployeeLivingroomEntity)relatedEntity);
					break;
				case "Patients":
					_patients.Add((PatientEntity)relatedEntity);
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
				case "Chores":
					this.PerformRelatedEntityRemoval(_chores, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "EmployeeLivingrooms":
					this.PerformRelatedEntityRemoval(_employeeLivingrooms, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Patients":
					this.PerformRelatedEntityRemoval(_patients, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_chores);
			toReturn.Add(_employeeLivingrooms);
			toReturn.Add(_patients);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Livingroom which data should be fetched into this Livingroom object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id)
		{
			return FetchUsingPK(id, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Livingroom which data should be fetched into this Livingroom object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Livingroom which data should be fetched into this Livingroom object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Livingroom which data should be fetched into this Livingroom object</param>
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
			return new LivingroomRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'ChoreEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ChoreEntity'</returns>
		public AmstaJanBonga.Business.CollectionClasses.ChoreCollection GetMultiChores(bool forceFetch)
		{
			return GetMultiChores(forceFetch, _chores.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ChoreEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ChoreEntity'</returns>
		public AmstaJanBonga.Business.CollectionClasses.ChoreCollection GetMultiChores(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiChores(forceFetch, _chores.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ChoreEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AmstaJanBonga.Business.CollectionClasses.ChoreCollection GetMultiChores(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiChores(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ChoreEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AmstaJanBonga.Business.CollectionClasses.ChoreCollection GetMultiChores(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedChores || forceFetch || _alwaysFetchChores) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_chores);
				_chores.SuppressClearInGetMulti=!forceFetch;
				_chores.EntityFactoryToUse = entityFactoryToUse;
				_chores.GetMultiManyToOne(this, null, filter);
				_chores.SuppressClearInGetMulti=false;
				_alreadyFetchedChores = true;
			}
			return _chores;
		}

		/// <summary> Sets the collection parameters for the collection for 'Chores'. These settings will be taken into account
		/// when the property Chores is requested or GetMultiChores is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersChores(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_chores.SortClauses=sortClauses;
			_chores.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeLivingroomEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeLivingroomEntity'</returns>
		public AmstaJanBonga.Business.CollectionClasses.EmployeeLivingroomCollection GetMultiEmployeeLivingrooms(bool forceFetch)
		{
			return GetMultiEmployeeLivingrooms(forceFetch, _employeeLivingrooms.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeLivingroomEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeLivingroomEntity'</returns>
		public AmstaJanBonga.Business.CollectionClasses.EmployeeLivingroomCollection GetMultiEmployeeLivingrooms(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiEmployeeLivingrooms(forceFetch, _employeeLivingrooms.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeLivingroomEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AmstaJanBonga.Business.CollectionClasses.EmployeeLivingroomCollection GetMultiEmployeeLivingrooms(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiEmployeeLivingrooms(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeLivingroomEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AmstaJanBonga.Business.CollectionClasses.EmployeeLivingroomCollection GetMultiEmployeeLivingrooms(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployeeLivingrooms || forceFetch || _alwaysFetchEmployeeLivingrooms) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_employeeLivingrooms);
				_employeeLivingrooms.SuppressClearInGetMulti=!forceFetch;
				_employeeLivingrooms.EntityFactoryToUse = entityFactoryToUse;
				_employeeLivingrooms.GetMultiManyToOne(null, this, filter);
				_employeeLivingrooms.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeLivingrooms = true;
			}
			return _employeeLivingrooms;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeLivingrooms'. These settings will be taken into account
		/// when the property EmployeeLivingrooms is requested or GetMultiEmployeeLivingrooms is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeLivingrooms(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeLivingrooms.SortClauses=sortClauses;
			_employeeLivingrooms.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Chores", _chores);
			toReturn.Add("EmployeeLivingrooms", _employeeLivingrooms);
			toReturn.Add("Patients", _patients);
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
		/// <param name="id">PK value for Livingroom which data should be fetched into this Livingroom object</param>
		/// <param name="validator">The validator object for this LivingroomEntity</param>
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

			_chores = new AmstaJanBonga.Business.CollectionClasses.ChoreCollection();
			_chores.SetContainingEntityInfo(this, "Livingroom");

			_employeeLivingrooms = new AmstaJanBonga.Business.CollectionClasses.EmployeeLivingroomCollection();
			_employeeLivingrooms.SetContainingEntityInfo(this, "Livingroom");

			_patients = new AmstaJanBonga.Business.CollectionClasses.PatientCollection();
			_patients.SetContainingEntityInfo(this, "Livingroom");
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
			_fieldsCustomProperties.Add("IsActive", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsMarkedAsDeleted", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="id">PK value for Livingroom which data should be fetched into this Livingroom object</param>
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
				this.Fields[(int)LivingroomFieldIndex.Id].ForcedCurrentValueWrite(id);
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
			return DAOFactory.CreateLivingroomDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new LivingroomEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static LivingroomRelations Relations
		{
			get	{ return new LivingroomRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Chore' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathChores
		{
			get { return new PrefetchPathElement(new AmstaJanBonga.Business.CollectionClasses.ChoreCollection(), (IEntityRelation)GetRelationsForField("Chores")[0], (int)AmstaJanBonga.Business.EntityType.LivingroomEntity, (int)AmstaJanBonga.Business.EntityType.ChoreEntity, 0, null, null, null, "Chores", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'EmployeeLivingroom' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeLivingrooms
		{
			get { return new PrefetchPathElement(new AmstaJanBonga.Business.CollectionClasses.EmployeeLivingroomCollection(), (IEntityRelation)GetRelationsForField("EmployeeLivingrooms")[0], (int)AmstaJanBonga.Business.EntityType.LivingroomEntity, (int)AmstaJanBonga.Business.EntityType.EmployeeLivingroomEntity, 0, null, null, null, "EmployeeLivingrooms", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Patient' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathPatients
		{
			get { return new PrefetchPathElement(new AmstaJanBonga.Business.CollectionClasses.PatientCollection(), (IEntityRelation)GetRelationsForField("Patients")[0], (int)AmstaJanBonga.Business.EntityType.LivingroomEntity, (int)AmstaJanBonga.Business.EntityType.PatientEntity, 0, null, null, null, "Patients", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
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

		/// <summary> The ColourTypeEnum property of the Entity Livingroom<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Livingroom"."ColourTypeEnum"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte ColourTypeEnum
		{
			get { return (System.Byte)GetValue((int)LivingroomFieldIndex.ColourTypeEnum, true); }
			set	{ SetValue((int)LivingroomFieldIndex.ColourTypeEnum, value, true); }
		}

		/// <summary> The DateCreated property of the Entity Livingroom<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Livingroom"."DateCreated"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DateCreated
		{
			get { return (System.DateTime)GetValue((int)LivingroomFieldIndex.DateCreated, true); }
			set	{ SetValue((int)LivingroomFieldIndex.DateCreated, value, true); }
		}

		/// <summary> The DateDeleted property of the Entity Livingroom<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Livingroom"."DateDeleted"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateDeleted
		{
			get { return (Nullable<System.DateTime>)GetValue((int)LivingroomFieldIndex.DateDeleted, false); }
			set	{ SetValue((int)LivingroomFieldIndex.DateDeleted, value, true); }
		}

		/// <summary> The DateLastModified property of the Entity Livingroom<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Livingroom"."DateLastModified"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateLastModified
		{
			get { return (Nullable<System.DateTime>)GetValue((int)LivingroomFieldIndex.DateLastModified, false); }
			set	{ SetValue((int)LivingroomFieldIndex.DateLastModified, value, true); }
		}

		/// <summary> The DateLastModifiedByUserId property of the Entity Livingroom<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Livingroom"."DateLastModifiedByUserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> DateLastModifiedByUserId
		{
			get { return (Nullable<System.Int32>)GetValue((int)LivingroomFieldIndex.DateLastModifiedByUserId, false); }
			set	{ SetValue((int)LivingroomFieldIndex.DateLastModifiedByUserId, value, true); }
		}

		/// <summary> The Id property of the Entity Livingroom<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Livingroom"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)LivingroomFieldIndex.Id, true); }
			set	{ SetValue((int)LivingroomFieldIndex.Id, value, true); }
		}

		/// <summary> The IsActive property of the Entity Livingroom<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Livingroom"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)LivingroomFieldIndex.IsActive, true); }
			set	{ SetValue((int)LivingroomFieldIndex.IsActive, value, true); }
		}

		/// <summary> The IsMarkedAsDeleted property of the Entity Livingroom<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Livingroom"."IsMarkedAsDeleted"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsMarkedAsDeleted
		{
			get { return (System.Boolean)GetValue((int)LivingroomFieldIndex.IsMarkedAsDeleted, true); }
			set	{ SetValue((int)LivingroomFieldIndex.IsMarkedAsDeleted, value, true); }
		}

		/// <summary> The Name property of the Entity Livingroom<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Livingroom"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)LivingroomFieldIndex.Name, true); }
			set	{ SetValue((int)LivingroomFieldIndex.Name, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'ChoreEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiChores()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AmstaJanBonga.Business.CollectionClasses.ChoreCollection Chores
		{
			get	{ return GetMultiChores(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Chores. When set to true, Chores is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Chores is accessed. You can always execute/ a forced fetch by calling GetMultiChores(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchChores
		{
			get	{ return _alwaysFetchChores; }
			set	{ _alwaysFetchChores = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Chores already has been fetched. Setting this property to false when Chores has been fetched
		/// will clear the Chores collection well. Setting this property to true while Chores hasn't been fetched disables lazy loading for Chores</summary>
		[Browsable(false)]
		public bool AlreadyFetchedChores
		{
			get { return _alreadyFetchedChores;}
			set 
			{
				if(_alreadyFetchedChores && !value && (_chores != null))
				{
					_chores.Clear();
				}
				_alreadyFetchedChores = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeLivingroomEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeLivingrooms()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AmstaJanBonga.Business.CollectionClasses.EmployeeLivingroomCollection EmployeeLivingrooms
		{
			get	{ return GetMultiEmployeeLivingrooms(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeLivingrooms. When set to true, EmployeeLivingrooms is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeLivingrooms is accessed. You can always execute/ a forced fetch by calling GetMultiEmployeeLivingrooms(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeLivingrooms
		{
			get	{ return _alwaysFetchEmployeeLivingrooms; }
			set	{ _alwaysFetchEmployeeLivingrooms = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeLivingrooms already has been fetched. Setting this property to false when EmployeeLivingrooms has been fetched
		/// will clear the EmployeeLivingrooms collection well. Setting this property to true while EmployeeLivingrooms hasn't been fetched disables lazy loading for EmployeeLivingrooms</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeLivingrooms
		{
			get { return _alreadyFetchedEmployeeLivingrooms;}
			set 
			{
				if(_alreadyFetchedEmployeeLivingrooms && !value && (_employeeLivingrooms != null))
				{
					_employeeLivingrooms.Clear();
				}
				_alreadyFetchedEmployeeLivingrooms = value;
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
			get { return (int)AmstaJanBonga.Business.EntityType.LivingroomEntity; }
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
