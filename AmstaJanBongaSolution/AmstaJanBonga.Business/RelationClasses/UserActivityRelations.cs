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
	/// <summary>Implements the relations factory for the entity: UserActivity. </summary>
	public partial class UserActivityRelations
	{
		/// <summary>CTor</summary>
		public UserActivityRelations()
		{
		}

		/// <summary>Gets all relations of the UserActivityEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.UserRoleActivityEntityUsingUserActivityName);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between UserActivityEntity and UserRoleActivityEntity over the 1:n relation they have, using the relation between the fields:
		/// UserActivity.Name - UserRoleActivity.UserActivityName
		/// </summary>
		public virtual IEntityRelation UserRoleActivityEntityUsingUserActivityName
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "UserRoleActivities" , true);
				relation.AddEntityFieldPair(UserActivityFields.Name, UserRoleActivityFields.UserActivityName);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserActivityEntity", true);
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
	internal static class StaticUserActivityRelations
	{
		internal static readonly IEntityRelation UserRoleActivityEntityUsingUserActivityNameStatic = new UserActivityRelations().UserRoleActivityEntityUsingUserActivityName;

		/// <summary>CTor</summary>
		static StaticUserActivityRelations()
		{
		}
	}
}
