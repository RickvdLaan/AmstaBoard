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
	/// <summary>Implements the relations factory for the entity: UserRole. </summary>
	public partial class UserRoleRelations
	{
		/// <summary>CTor</summary>
		public UserRoleRelations()
		{
		}

		/// <summary>Gets all relations of the UserRoleEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.UserEntityUsingRoleTypeEnum);
			toReturn.Add(this.UserRoleActivityEntityUsingRoleTypeEnum);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between UserRoleEntity and UserEntity over the 1:n relation they have, using the relation between the fields:
		/// UserRole.RoleTypeEnum - User.RoleTypeEnum
		/// </summary>
		public virtual IEntityRelation UserEntityUsingRoleTypeEnum
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Users" , true);
				relation.AddEntityFieldPair(UserRoleFields.RoleTypeEnum, UserFields.RoleTypeEnum);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserRoleEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between UserRoleEntity and UserRoleActivityEntity over the 1:n relation they have, using the relation between the fields:
		/// UserRole.RoleTypeEnum - UserRoleActivity.RoleTypeEnum
		/// </summary>
		public virtual IEntityRelation UserRoleActivityEntityUsingRoleTypeEnum
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "UserRoleActivities" , true);
				relation.AddEntityFieldPair(UserRoleFields.RoleTypeEnum, UserRoleActivityFields.RoleTypeEnum);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserRoleEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserRoleActivityEntity", false);
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
	internal static class StaticUserRoleRelations
	{
		internal static readonly IEntityRelation UserEntityUsingRoleTypeEnumStatic = new UserRoleRelations().UserEntityUsingRoleTypeEnum;
		internal static readonly IEntityRelation UserRoleActivityEntityUsingRoleTypeEnumStatic = new UserRoleRelations().UserRoleActivityEntityUsingRoleTypeEnum;

		/// <summary>CTor</summary>
		static StaticUserRoleRelations()
		{
		}
	}
}
