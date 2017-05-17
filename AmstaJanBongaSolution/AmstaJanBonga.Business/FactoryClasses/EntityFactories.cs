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
using System.Collections.Generic;
using AmstaJanBonga.Business.HelperClasses;
using AmstaJanBonga.Business.RelationClasses;
using AmstaJanBonga.Business.DaoClasses;

using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AmstaJanBonga.Business.FactoryClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>general base class for the generated factories</summary>
	[Serializable]
	public partial class EntityFactoryBase : EntityFactoryCore
	{
		private readonly AmstaJanBonga.Business.EntityType _typeOfEntity;
		
		/// <summary>CTor</summary>
		/// <param name="entityName">Name of the entity.</param>
		/// <param name="typeOfEntity">The type of entity.</param>
		public EntityFactoryBase(string entityName, AmstaJanBonga.Business.EntityType typeOfEntity) : base(entityName)
		{
			_typeOfEntity = typeOfEntity;
		}

		/// <summary>Creates a new entity instance using the GeneralEntityFactory in the generated code, using the passed in entitytype value</summary>
		/// <param name="entityTypeValue">The entity type value of the entity to create an instance for.</param>
		/// <returns>new IEntity instance</returns>
		public override IEntity CreateEntityFromEntityTypeValue(int entityTypeValue)
		{
			return GeneralEntityFactory.Create((AmstaJanBonga.Business.EntityType)entityTypeValue);
		}
		
		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public override IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(_typeOfEntity);
		}

		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <param name="objectAlias">The object alias to use for the elements in the relations.</param>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public override IRelationCollection CreateHierarchyRelations(string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetHierarchyRelations(ForEntityName, objectAlias);
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public override IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return (IEntityFactory)InheritanceInfoProviderSingleton.GetInstance().GetEntityFactory(ForEntityName, fieldValues, entityFieldStartIndexesPerEntity) ?? this;
		}
						
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public override IEntityCollection CreateEntityCollection()
		{
			return GeneralEntityCollectionFactory.Create(_typeOfEntity);
		}
	}
	
	/// <summary>Factory to create new, empty AgendaEventEntity objects.</summary>
	[Serializable]
	public partial class AgendaEventEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public AgendaEventEntityFactory() : base("AgendaEventEntity", AmstaJanBonga.Business.EntityType.AgendaEventEntity) { }

		/// <summary>Creates a new, empty AgendaEventEntity object.</summary>
		/// <returns>A new, empty AgendaEventEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new AgendaEventEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAgendaEvent
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty AgendaEventMetaEntity objects.</summary>
	[Serializable]
	public partial class AgendaEventMetaEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public AgendaEventMetaEntityFactory() : base("AgendaEventMetaEntity", AmstaJanBonga.Business.EntityType.AgendaEventMetaEntity) { }

		/// <summary>Creates a new, empty AgendaEventMetaEntity object.</summary>
		/// <returns>A new, empty AgendaEventMetaEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new AgendaEventMetaEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAgendaEventMeta
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty EmployeeEntity objects.</summary>
	[Serializable]
	public partial class EmployeeEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public EmployeeEntityFactory() : base("EmployeeEntity", AmstaJanBonga.Business.EntityType.EmployeeEntity) { }

		/// <summary>Creates a new, empty EmployeeEntity object.</summary>
		/// <returns>A new, empty EmployeeEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new EmployeeEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEmployee
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty IpEntity objects.</summary>
	[Serializable]
	public partial class IpEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public IpEntityFactory() : base("IpEntity", AmstaJanBonga.Business.EntityType.IpEntity) { }

		/// <summary>Creates a new, empty IpEntity object.</summary>
		/// <returns>A new, empty IpEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new IpEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewIp
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty LivingRoomEntity objects.</summary>
	[Serializable]
	public partial class LivingRoomEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public LivingRoomEntityFactory() : base("LivingRoomEntity", AmstaJanBonga.Business.EntityType.LivingRoomEntity) { }

		/// <summary>Creates a new, empty LivingRoomEntity object.</summary>
		/// <returns>A new, empty LivingRoomEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new LivingRoomEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLivingRoom
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty LivingRoomChoreEventEntity objects.</summary>
	[Serializable]
	public partial class LivingRoomChoreEventEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public LivingRoomChoreEventEntityFactory() : base("LivingRoomChoreEventEntity", AmstaJanBonga.Business.EntityType.LivingRoomChoreEventEntity) { }

		/// <summary>Creates a new, empty LivingRoomChoreEventEntity object.</summary>
		/// <returns>A new, empty LivingRoomChoreEventEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new LivingRoomChoreEventEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLivingRoomChoreEvent
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty LivingRoomGeneralEntity objects.</summary>
	[Serializable]
	public partial class LivingRoomGeneralEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public LivingRoomGeneralEntityFactory() : base("LivingRoomGeneralEntity", AmstaJanBonga.Business.EntityType.LivingRoomGeneralEntity) { }

		/// <summary>Creates a new, empty LivingRoomGeneralEntity object.</summary>
		/// <returns>A new, empty LivingRoomGeneralEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new LivingRoomGeneralEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLivingRoomGeneral
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty LivingRoomGeneralEventEntity objects.</summary>
	[Serializable]
	public partial class LivingRoomGeneralEventEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public LivingRoomGeneralEventEntityFactory() : base("LivingRoomGeneralEventEntity", AmstaJanBonga.Business.EntityType.LivingRoomGeneralEventEntity) { }

		/// <summary>Creates a new, empty LivingRoomGeneralEventEntity object.</summary>
		/// <returns>A new, empty LivingRoomGeneralEventEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new LivingRoomGeneralEventEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLivingRoomGeneralEvent
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty LivingRoomShiftEventEntity objects.</summary>
	[Serializable]
	public partial class LivingRoomShiftEventEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public LivingRoomShiftEventEntityFactory() : base("LivingRoomShiftEventEntity", AmstaJanBonga.Business.EntityType.LivingRoomShiftEventEntity) { }

		/// <summary>Creates a new, empty LivingRoomShiftEventEntity object.</summary>
		/// <returns>A new, empty LivingRoomShiftEventEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new LivingRoomShiftEventEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLivingRoomShiftEvent
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty PatientEntity objects.</summary>
	[Serializable]
	public partial class PatientEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public PatientEntityFactory() : base("PatientEntity", AmstaJanBonga.Business.EntityType.PatientEntity) { }

		/// <summary>Creates a new, empty PatientEntity object.</summary>
		/// <returns>A new, empty PatientEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new PatientEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPatient
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty UserEntity objects.</summary>
	[Serializable]
	public partial class UserEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public UserEntityFactory() : base("UserEntity", AmstaJanBonga.Business.EntityType.UserEntity) { }

		/// <summary>Creates a new, empty UserEntity object.</summary>
		/// <returns>A new, empty UserEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new UserEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUser
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty UserActivityEntity objects.</summary>
	[Serializable]
	public partial class UserActivityEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public UserActivityEntityFactory() : base("UserActivityEntity", AmstaJanBonga.Business.EntityType.UserActivityEntity) { }

		/// <summary>Creates a new, empty UserActivityEntity object.</summary>
		/// <returns>A new, empty UserActivityEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new UserActivityEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUserActivity
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty UserRoleEntity objects.</summary>
	[Serializable]
	public partial class UserRoleEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public UserRoleEntityFactory() : base("UserRoleEntity", AmstaJanBonga.Business.EntityType.UserRoleEntity) { }

		/// <summary>Creates a new, empty UserRoleEntity object.</summary>
		/// <returns>A new, empty UserRoleEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new UserRoleEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUserRole
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty UserRoleActivityEntity objects.</summary>
	[Serializable]
	public partial class UserRoleActivityEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public UserRoleActivityEntityFactory() : base("UserRoleActivityEntity", AmstaJanBonga.Business.EntityType.UserRoleActivityEntity) { }

		/// <summary>Creates a new, empty UserRoleActivityEntity object.</summary>
		/// <returns>A new, empty UserRoleActivityEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new UserRoleActivityEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUserRoleActivity
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new entity collection objects</summary>
	[Serializable]
	public partial class GeneralEntityCollectionFactory
	{
		/// <summary>Creates a new entity collection</summary>
		/// <param name="typeToUse">The entity type to create the collection for.</param>
		/// <returns>A new entity collection object.</returns>
		public static IEntityCollection Create(AmstaJanBonga.Business.EntityType typeToUse)
		{
			switch(typeToUse)
			{
				case AmstaJanBonga.Business.EntityType.AgendaEventEntity:
					return new AgendaEventCollection();
				case AmstaJanBonga.Business.EntityType.AgendaEventMetaEntity:
					return new AgendaEventMetaCollection();
				case AmstaJanBonga.Business.EntityType.EmployeeEntity:
					return new EmployeeCollection();
				case AmstaJanBonga.Business.EntityType.IpEntity:
					return new IpCollection();
				case AmstaJanBonga.Business.EntityType.LivingRoomEntity:
					return new LivingRoomCollection();
				case AmstaJanBonga.Business.EntityType.LivingRoomChoreEventEntity:
					return new LivingRoomChoreEventCollection();
				case AmstaJanBonga.Business.EntityType.LivingRoomGeneralEntity:
					return new LivingRoomGeneralCollection();
				case AmstaJanBonga.Business.EntityType.LivingRoomGeneralEventEntity:
					return new LivingRoomGeneralEventCollection();
				case AmstaJanBonga.Business.EntityType.LivingRoomShiftEventEntity:
					return new LivingRoomShiftEventCollection();
				case AmstaJanBonga.Business.EntityType.PatientEntity:
					return new PatientCollection();
				case AmstaJanBonga.Business.EntityType.UserEntity:
					return new UserCollection();
				case AmstaJanBonga.Business.EntityType.UserActivityEntity:
					return new UserActivityCollection();
				case AmstaJanBonga.Business.EntityType.UserRoleEntity:
					return new UserRoleCollection();
				case AmstaJanBonga.Business.EntityType.UserRoleActivityEntity:
					return new UserRoleActivityCollection();
				default:
					return null;
			}
		}		
	}
	
	/// <summary>Factory to create new, empty Entity objects based on the entity type specified. Uses entity specific factory objects</summary>
	[Serializable]
	public partial class GeneralEntityFactory
	{
		/// <summary>Creates a new, empty Entity object of the type specified</summary>
		/// <param name="entityTypeToCreate">The entity type to create.</param>
		/// <returns>A new, empty Entity object.</returns>
		public static IEntity Create(AmstaJanBonga.Business.EntityType entityTypeToCreate)
		{
			IEntityFactory factoryToUse = null;
			switch(entityTypeToCreate)
			{
				case AmstaJanBonga.Business.EntityType.AgendaEventEntity:
					factoryToUse = new AgendaEventEntityFactory();
					break;
				case AmstaJanBonga.Business.EntityType.AgendaEventMetaEntity:
					factoryToUse = new AgendaEventMetaEntityFactory();
					break;
				case AmstaJanBonga.Business.EntityType.EmployeeEntity:
					factoryToUse = new EmployeeEntityFactory();
					break;
				case AmstaJanBonga.Business.EntityType.IpEntity:
					factoryToUse = new IpEntityFactory();
					break;
				case AmstaJanBonga.Business.EntityType.LivingRoomEntity:
					factoryToUse = new LivingRoomEntityFactory();
					break;
				case AmstaJanBonga.Business.EntityType.LivingRoomChoreEventEntity:
					factoryToUse = new LivingRoomChoreEventEntityFactory();
					break;
				case AmstaJanBonga.Business.EntityType.LivingRoomGeneralEntity:
					factoryToUse = new LivingRoomGeneralEntityFactory();
					break;
				case AmstaJanBonga.Business.EntityType.LivingRoomGeneralEventEntity:
					factoryToUse = new LivingRoomGeneralEventEntityFactory();
					break;
				case AmstaJanBonga.Business.EntityType.LivingRoomShiftEventEntity:
					factoryToUse = new LivingRoomShiftEventEntityFactory();
					break;
				case AmstaJanBonga.Business.EntityType.PatientEntity:
					factoryToUse = new PatientEntityFactory();
					break;
				case AmstaJanBonga.Business.EntityType.UserEntity:
					factoryToUse = new UserEntityFactory();
					break;
				case AmstaJanBonga.Business.EntityType.UserActivityEntity:
					factoryToUse = new UserActivityEntityFactory();
					break;
				case AmstaJanBonga.Business.EntityType.UserRoleEntity:
					factoryToUse = new UserRoleEntityFactory();
					break;
				case AmstaJanBonga.Business.EntityType.UserRoleActivityEntity:
					factoryToUse = new UserRoleActivityEntityFactory();
					break;
			}
			IEntity toReturn = null;
			if(factoryToUse != null)
			{
				toReturn = factoryToUse.Create();
			}
			return toReturn;
		}		
	}
	
	/// <summary>Class which is used to obtain the entity factory based on the .NET type of the entity. </summary>
	[Serializable]
	public static class EntityFactoryFactory
	{
		private static readonly Dictionary<Type, IEntityFactory> _factoryPerType = new Dictionary<Type, IEntityFactory>();

		/// <summary>Initializes the <see cref="EntityFactoryFactory"/> class.</summary>
		static EntityFactoryFactory()
		{
			Array entityTypeValues = Enum.GetValues(typeof(AmstaJanBonga.Business.EntityType));
			foreach(int entityTypeValue in entityTypeValues)
			{
				IEntity dummy = GeneralEntityFactory.Create((AmstaJanBonga.Business.EntityType)entityTypeValue);
				_factoryPerType.Add(dummy.GetType(), dummy.GetEntityFactory());
			}
		}

		/// <summary>Gets the factory of the entity with the .NET type specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(Type typeOfEntity)
		{
			IEntityFactory toReturn = null;
			_factoryPerType.TryGetValue(typeOfEntity, out toReturn);
			return toReturn;
		}

		/// <summary>Gets the factory of the entity with the AmstaJanBonga.Business.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(AmstaJanBonga.Business.EntityType typeOfEntity)
		{
			return GetFactory(GeneralEntityFactory.Create(typeOfEntity).GetType());
		}
	}
	
	/// <summary>Element creator for creating project elements from somewhere else, like inside Linq providers.</summary>
	public class ElementCreator : ElementCreatorBase, IElementCreator
	{
		/// <summary>Gets the factory of the Entity type with the AmstaJanBonga.Business.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory GetFactory(int entityTypeValue)
		{
			return (IEntityFactory)this.GetFactoryImpl(entityTypeValue);
		}

		/// <summary>Gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory GetFactory(Type typeOfEntity)
		{
			return (IEntityFactory)this.GetFactoryImpl(typeOfEntity);
		}

		/// <summary>Creates a new resultset fields object with the number of field slots reserved as specified</summary>
		/// <param name="numberOfFields">The number of fields.</param>
		/// <returns>ready to use resultsetfields object</returns>
		public IEntityFields CreateResultsetFields(int numberOfFields)
		{
			return new ResultsetFields(numberOfFields);
		}
		
		/// <summary>Gets an instance of the TypedListDAO class to execute dynamic lists and projections.</summary>
		/// <returns>ready to use typedlistDAO</returns>
		public IDao GetTypedListDao()
		{
			return new TypedListDAO();
		}
		
		/// <summary>Obtains the inheritance info provider instance from the singleton </summary>
		/// <returns>The singleton instance of the inheritance info provider</returns>
		public override IInheritanceInfoProvider ObtainInheritanceInfoProviderInstance()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}


		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand)
		{
			return new DynamicRelation(leftOperand);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperand">The right operand.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperand">The right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(IEntityFieldCore leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, string aliasLeftOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, aliasLeftOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (AmstaJanBonga.Business.EntityType)Enum.Parse(typeof(AmstaJanBonga.Business.EntityType), rightOperandEntityName, false), aliasRightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperandEntityName">Name of the entity which is used as the left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(string leftOperandEntityName, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation((AmstaJanBonga.Business.EntityType)Enum.Parse(typeof(AmstaJanBonga.Business.EntityType), leftOperandEntityName, false), joinType, (AmstaJanBonga.Business.EntityType)Enum.Parse(typeof(AmstaJanBonga.Business.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(IEntityFieldCore leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (AmstaJanBonga.Business.EntityType)Enum.Parse(typeof(AmstaJanBonga.Business.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the AmstaJanBonga.Business.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(int entityTypeValue)
		{
			return EntityFactoryFactory.GetFactory((AmstaJanBonga.Business.EntityType)entityTypeValue);
		}
	
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(Type typeOfEntity)
		{
			return EntityFactoryFactory.GetFactory(typeOfEntity);
		}

	}
}
