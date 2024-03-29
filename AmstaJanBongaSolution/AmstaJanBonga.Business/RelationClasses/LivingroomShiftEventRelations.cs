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
	/// <summary>Implements the relations factory for the entity: LivingRoomShiftEvent. </summary>
	public partial class LivingRoomShiftEventRelations
	{
		/// <summary>CTor</summary>
		public LivingRoomShiftEventRelations()
		{
		}

		/// <summary>Gets all relations of the LivingRoomShiftEventEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.EmployeeEntityUsingEmployeeId);
			toReturn.Add(this.LivingRoomEntityUsingLivingRoomId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between LivingRoomShiftEventEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// LivingRoomShiftEvent.EmployeeId - Employee.Id
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee", false);
				relation.AddEntityFieldPair(EmployeeFields.Id, LivingRoomShiftEventFields.EmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingRoomShiftEventEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between LivingRoomShiftEventEntity and LivingRoomEntity over the m:1 relation they have, using the relation between the fields:
		/// LivingRoomShiftEvent.LivingRoomId - LivingRoom.Id
		/// </summary>
		public virtual IEntityRelation LivingRoomEntityUsingLivingRoomId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "LivingRoom", false);
				relation.AddEntityFieldPair(LivingRoomFields.Id, LivingRoomShiftEventFields.LivingRoomId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingRoomEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingRoomShiftEventEntity", true);
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
	internal static class StaticLivingRoomShiftEventRelations
	{
		internal static readonly IEntityRelation EmployeeEntityUsingEmployeeIdStatic = new LivingRoomShiftEventRelations().EmployeeEntityUsingEmployeeId;
		internal static readonly IEntityRelation LivingRoomEntityUsingLivingRoomIdStatic = new LivingRoomShiftEventRelations().LivingRoomEntityUsingLivingRoomId;

		/// <summary>CTor</summary>
		static StaticLivingRoomShiftEventRelations()
		{
		}
	}
}
