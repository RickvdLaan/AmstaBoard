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
	/// <summary>Implements the relations factory for the entity: LivingRoomGeneralEvent. </summary>
	public partial class LivingRoomGeneralEventRelations
	{
		/// <summary>CTor</summary>
		public LivingRoomGeneralEventRelations()
		{
		}

		/// <summary>Gets all relations of the LivingRoomGeneralEventEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.LivingRoomGeneralEntityUsingLivingRoomId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between LivingRoomGeneralEventEntity and LivingRoomGeneralEntity over the m:1 relation they have, using the relation between the fields:
		/// LivingRoomGeneralEvent.LivingRoomId - LivingRoomGeneral.LivingRoomId
		/// </summary>
		public virtual IEntityRelation LivingRoomGeneralEntityUsingLivingRoomId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "LivingRoomGeneral", false);
				relation.AddEntityFieldPair(LivingRoomGeneralFields.LivingRoomId, LivingRoomGeneralEventFields.LivingRoomId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingRoomGeneralEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingRoomGeneralEventEntity", true);
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
	internal static class StaticLivingRoomGeneralEventRelations
	{
		internal static readonly IEntityRelation LivingRoomGeneralEntityUsingLivingRoomIdStatic = new LivingRoomGeneralEventRelations().LivingRoomGeneralEntityUsingLivingRoomId;

		/// <summary>CTor</summary>
		static StaticLivingRoomGeneralEventRelations()
		{
		}
	}
}
