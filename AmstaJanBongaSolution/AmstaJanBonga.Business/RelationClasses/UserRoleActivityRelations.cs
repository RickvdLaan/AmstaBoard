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
using System.Collections;
using System.Collections.Generic;
using AmstaJanBonga.Business;
using AmstaJanBonga.Business.FactoryClasses;
using AmstaJanBonga.Business.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AmstaJanBonga.Business.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: UserRoleActivity. </summary>
	public partial class UserRoleActivityRelations
	{
		/// <summary>CTor</summary>
		public UserRoleActivityRelations()
		{
		}

		/// <summary>Gets all relations of the UserRoleActivityEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.UserActivityEntityUsingUserActivityName);
			toReturn.Add(this.UserRoleEntityUsingRoleTypeEnum);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between UserRoleActivityEntity and UserActivityEntity over the m:1 relation they have, using the relation between the fields:
		/// UserRoleActivity.UserActivityName - UserActivity.Name
		/// </summary>
		public virtual IEntityRelation UserActivityEntityUsingUserActivityName
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "UserActivity", false);
				relation.AddEntityFieldPair(UserActivityFields.Name, UserRoleActivityFields.UserActivityName);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserActivityEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserRoleActivityEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between UserRoleActivityEntity and UserRoleEntity over the m:1 relation they have, using the relation between the fields:
		/// UserRoleActivity.RoleTypeEnum - UserRole.RoleTypeEnum
		/// </summary>
		public virtual IEntityRelation UserRoleEntityUsingRoleTypeEnum
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "UserRole", false);
				relation.AddEntityFieldPair(UserRoleFields.RoleTypeEnum, UserRoleActivityFields.RoleTypeEnum);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserRoleEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserRoleActivityEntity", true);
				return relation;
			}
		}
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticUserRoleActivityRelations
	{
		internal static readonly IEntityRelation UserActivityEntityUsingUserActivityNameStatic = new UserRoleActivityRelations().UserActivityEntityUsingUserActivityName;
		internal static readonly IEntityRelation UserRoleEntityUsingRoleTypeEnumStatic = new UserRoleActivityRelations().UserRoleEntityUsingRoleTypeEnum;

		/// <summary>CTor</summary>
		static StaticUserRoleActivityRelations()
		{
		}
	}
}
