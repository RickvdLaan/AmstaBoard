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
	
	/// <summary>Factory to create new, empty EmployeeLivingroomEntity objects.</summary>
	[Serializable]
	public partial class EmployeeLivingroomEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public EmployeeLivingroomEntityFactory() : base("EmployeeLivingroomEntity", AmstaJanBonga.Business.EntityType.EmployeeLivingroomEntity) { }

		/// <summary>Creates a new, empty EmployeeLivingroomEntity object.</summary>
		/// <returns>A new, empty EmployeeLivingroomEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new EmployeeLivingroomEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEmployeeLivingroom
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty LivingroomEntity objects.</summary>
	[Serializable]
	public partial class LivingroomEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public LivingroomEntityFactory() : base("LivingroomEntity", AmstaJanBonga.Business.EntityType.LivingroomEntity) { }

		/// <summary>Creates a new, empty LivingroomEntity object.</summary>
		/// <returns>A new, empty LivingroomEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new LivingroomEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLivingroom
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty LivingroomChoreEventEntity objects.</summary>
	[Serializable]
	public partial class LivingroomChoreEventEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public LivingroomChoreEventEntityFactory() : base("LivingroomChoreEventEntity", AmstaJanBonga.Business.EntityType.LivingroomChoreEventEntity) { }

		/// <summary>Creates a new, empty LivingroomChoreEventEntity object.</summary>
		/// <returns>A new, empty LivingroomChoreEventEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new LivingroomChoreEventEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLivingroomChoreEvent
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty LivingroomGeneralEntity objects.</summary>
	[Serializable]
	public partial class LivingroomGeneralEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public LivingroomGeneralEntityFactory() : base("LivingroomGeneralEntity", AmstaJanBonga.Business.EntityType.LivingroomGeneralEntity) { }

		/// <summary>Creates a new, empty LivingroomGeneralEntity object.</summary>
		/// <returns>A new, empty LivingroomGeneralEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new LivingroomGeneralEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLivingroomGeneral
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty LivingroomGeneralEventEntity objects.</summary>
	[Serializable]
	public partial class LivingroomGeneralEventEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public LivingroomGeneralEventEntityFactory() : base("LivingroomGeneralEventEntity", AmstaJanBonga.Business.EntityType.LivingroomGeneralEventEntity) { }

		/// <summary>Creates a new, empty LivingroomGeneralEventEntity object.</summary>
		/// <returns>A new, empty LivingroomGeneralEventEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new LivingroomGeneralEventEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLivingroomGeneralEvent
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
				case AmstaJanBonga.Business.EntityType.EmployeeEntity:
					return new EmployeeCollection();
				case AmstaJanBonga.Business.EntityType.EmployeeLivingroomEntity:
					return new EmployeeLivingroomCollection();
				case AmstaJanBonga.Business.EntityType.LivingroomEntity:
					return new LivingroomCollection();
				case AmstaJanBonga.Business.EntityType.LivingroomChoreEventEntity:
					return new LivingroomChoreEventCollection();
				case AmstaJanBonga.Business.EntityType.LivingroomGeneralEntity:
					return new LivingroomGeneralCollection();
				case AmstaJanBonga.Business.EntityType.LivingroomGeneralEventEntity:
					return new LivingroomGeneralEventCollection();
				case AmstaJanBonga.Business.EntityType.PatientEntity:
					return new PatientCollection();
				case AmstaJanBonga.Business.EntityType.UserEntity:
					return new UserCollection();
				case AmstaJanBonga.Business.EntityType.UserRoleEntity:
					return new UserRoleCollection();
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
				case AmstaJanBonga.Business.EntityType.EmployeeEntity:
					factoryToUse = new EmployeeEntityFactory();
					break;
				case AmstaJanBonga.Business.EntityType.EmployeeLivingroomEntity:
					factoryToUse = new EmployeeLivingroomEntityFactory();
					break;
				case AmstaJanBonga.Business.EntityType.LivingroomEntity:
					factoryToUse = new LivingroomEntityFactory();
					break;
				case AmstaJanBonga.Business.EntityType.LivingroomChoreEventEntity:
					factoryToUse = new LivingroomChoreEventEntityFactory();
					break;
				case AmstaJanBonga.Business.EntityType.LivingroomGeneralEntity:
					factoryToUse = new LivingroomGeneralEntityFactory();
					break;
				case AmstaJanBonga.Business.EntityType.LivingroomGeneralEventEntity:
					factoryToUse = new LivingroomGeneralEventEntityFactory();
					break;
				case AmstaJanBonga.Business.EntityType.PatientEntity:
					factoryToUse = new PatientEntityFactory();
					break;
				case AmstaJanBonga.Business.EntityType.UserEntity:
					factoryToUse = new UserEntityFactory();
					break;
				case AmstaJanBonga.Business.EntityType.UserRoleEntity:
					factoryToUse = new UserRoleEntityFactory();
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
