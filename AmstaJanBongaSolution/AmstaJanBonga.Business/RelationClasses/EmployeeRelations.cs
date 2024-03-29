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
using System.Collections;
using System.Collections.Generic;
using AmstaJanBonga.Business;
using AmstaJanBonga.Business.FactoryClasses;
using AmstaJanBonga.Business.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AmstaJanBonga.Business.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Employee. </summary>
	public partial class EmployeeRelations
	{
		/// <summary>CTor</summary>
		public EmployeeRelations()
		{
		}

		/// <summary>Gets all relations of the EmployeeEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.LivingRoomShiftEventEntityUsingEmployeeId);
			toReturn.Add(this.LivingRoomEntityUsingLivingRoomId);
			toReturn.Add(this.UserEntityUsingUserId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and LivingRoomShiftEventEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.Id - LivingRoomShiftEvent.EmployeeId
		/// </summary>
		public virtual IEntityRelation LivingRoomShiftEventEntityUsingEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "LivingRoomShiftEvents" , true);
				relation.AddEntityFieldPair(EmployeeFields.Id, LivingRoomShiftEventFields.EmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingRoomShiftEventEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and LivingRoomEntity over the m:1 relation they have, using the relation between the fields:
		/// Employee.LivingRoomId - LivingRoom.Id
		/// </summary>
		public virtual IEntityRelation LivingRoomEntityUsingLivingRoomId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "LivingRoom", false);
				relation.AddEntityFieldPair(LivingRoomFields.Id, EmployeeFields.LivingRoomId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingRoomEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and UserEntity over the m:1 relation they have, using the relation between the fields:
		/// Employee.UserId - User.Id
		/// </summary>
		public virtual IEntityRelation UserEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "User", false);
				relation.AddEntityFieldPair(UserFields.Id, EmployeeFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
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
	internal static class StaticEmployeeRelations
	{
		internal static readonly IEntityRelation LivingRoomShiftEventEntityUsingEmployeeIdStatic = new EmployeeRelations().LivingRoomShiftEventEntityUsingEmployeeId;
		internal static readonly IEntityRelation LivingRoomEntityUsingLivingRoomIdStatic = new EmployeeRelations().LivingRoomEntityUsingLivingRoomId;
		internal static readonly IEntityRelation UserEntityUsingUserIdStatic = new EmployeeRelations().UserEntityUsingUserId;

		/// <summary>CTor</summary>
		static StaticEmployeeRelations()
		{
		}
	}
}
