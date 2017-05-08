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
using System.Data;
using System.Data.Common;
using System.Collections;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.FactoryClasses;
using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.HelperClasses;
using AmstaJanBonga.Business;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.DQE.SqlServer;


namespace AmstaJanBonga.Business.DaoClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>General DAO class for the Employee Entity. It will perform database oriented actions for a entity of type 'EmployeeEntity'.</summary>
	public partial class EmployeeDAO : CommonDaoBase
	{
		/// <summary>CTor</summary>
		public EmployeeDAO() : base(InheritanceHierarchyType.None, "EmployeeEntity", new EmployeeEntityFactory())
		{
		}



		/// <summary>Retrieves in the calling EmployeeCollection object all EmployeeEntity objects which have data in common with the specified related Entities. If one is omitted, that entity is not used as a filter. </summary>
		/// <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or null if not.</param>
		/// <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. When set to 0, no limitations are specified.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="filter">Extra filter to limit the resultset. Predicate expression can be null, in which case it will be ignored.</param>
		/// <param name="livingroomInstance">LivingroomEntity instance to use as a filter for the EmployeeEntity objects to return</param>
		/// <param name="userInstance">UserEntity instance to use as a filter for the EmployeeEntity objects to return</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		public bool GetMulti(ITransaction containingTransaction, IEntityCollection collectionToFill, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IEntityFactory entityFactoryToUse, IPredicateExpression filter, IEntity livingroomInstance, IEntity userInstance, int pageNumber, int pageSize)
		{
			this.EntityFactoryToUse = entityFactoryToUse;
			IEntityFields fieldsToReturn = EntityFieldsFactory.CreateEntityFieldsObject(AmstaJanBonga.Business.EntityType.EmployeeEntity);
			IPredicateExpression selectFilter = CreateFilterUsingForeignKeys(livingroomInstance, userInstance, fieldsToReturn);
			if(filter!=null)
			{
				selectFilter.AddWithAnd(filter);
			}
			return this.PerformGetMultiAction(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, selectFilter, null, null, null, pageNumber, pageSize);
		}




		/// <summary>Deletes from the persistent storage all 'Employee' entities which have data in common with the specified related Entities. If one is omitted, that entity is not used as a filter.</summary>
		/// <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or null if not.</param>
		/// <param name="livingroomInstance">LivingroomEntity instance to use as a filter for the EmployeeEntity objects to delete</param>
		/// <param name="userInstance">UserEntity instance to use as a filter for the EmployeeEntity objects to delete</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int DeleteMulti(ITransaction containingTransaction, IEntity livingroomInstance, IEntity userInstance)
		{
			IEntityFields fields = EntityFieldsFactory.CreateEntityFieldsObject(AmstaJanBonga.Business.EntityType.EmployeeEntity);
			IPredicateExpression deleteFilter = CreateFilterUsingForeignKeys(livingroomInstance, userInstance, fields);
			return this.DeleteMulti(containingTransaction, deleteFilter);
		}

		/// <summary>Updates all entities of the same type or subtype of the entity <i>entityWithNewValues</i> directly in the persistent storage if they match the filter
		/// supplied in <i>filterBucket</i>. Only the fields changed in entityWithNewValues are updated for these fields. Entities of a subtype of the type
		/// of <i>entityWithNewValues</i> which are affected by the filterBucket's filter will thus also be updated.</summary>
		/// <param name="entityWithNewValues">IEntity instance which holds the new values for the matching entities to update. Only changed fields are taken into account</param>
		/// <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or null if not.</param>
		/// <param name="livingroomInstance">LivingroomEntity instance to use as a filter for the EmployeeEntity objects to update</param>
		/// <param name="userInstance">UserEntity instance to use as a filter for the EmployeeEntity objects to update</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int UpdateMulti(IEntity entityWithNewValues, ITransaction containingTransaction, IEntity livingroomInstance, IEntity userInstance)
		{
			IEntityFields fields = EntityFieldsFactory.CreateEntityFieldsObject(AmstaJanBonga.Business.EntityType.EmployeeEntity);
			IPredicateExpression updateFilter = CreateFilterUsingForeignKeys(livingroomInstance, userInstance, fields);
			return this.UpdateMulti(entityWithNewValues, containingTransaction, updateFilter);
		}

		/// <summary>Creates a PredicateExpression which should be used as a filter when any combination of available foreign keys is specified.</summary>
		/// <param name="livingroomInstance">LivingroomEntity instance to use as a filter for the EmployeeEntity objects</param>
		/// <param name="userInstance">UserEntity instance to use as a filter for the EmployeeEntity objects</param>
		/// <param name="fieldsToReturn">IEntityFields implementation which forms the definition of the fieldset of the target entity.</param>
		/// <returns>A ready to use PredicateExpression based on the passed in foreign key value holders.</returns>
		private IPredicateExpression CreateFilterUsingForeignKeys(IEntity livingroomInstance, IEntity userInstance, IEntityFields fieldsToReturn)
		{
			IPredicateExpression selectFilter = new PredicateExpression();
			
			if(livingroomInstance != null)
			{
				selectFilter.Add(new FieldCompareValuePredicate(fieldsToReturn[(int)EmployeeFieldIndex.LivingroomId], ComparisonOperator.Equal, ((LivingroomEntity)livingroomInstance).Id));
			}
			if(userInstance != null)
			{
				selectFilter.Add(new FieldCompareValuePredicate(fieldsToReturn[(int)EmployeeFieldIndex.UserId], ComparisonOperator.Equal, ((UserEntity)userInstance).Id));
			}
			return selectFilter;
		}
		
		#region Custom DAO code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomDAOCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Included Code

		#endregion
	}
}
