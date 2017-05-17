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
	/// <summary>Implements the relations factory for the entity: Patient. </summary>
	public partial class PatientRelations
	{
		/// <summary>CTor</summary>
		public PatientRelations()
		{
		}

		/// <summary>Gets all relations of the PatientEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AgendaEventEntityUsingPatientId);
			toReturn.Add(this.LivingRoomChoreEventEntityUsingPatientId);
			toReturn.Add(this.LivingRoomEntityUsingLivingRoomId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between PatientEntity and AgendaEventEntity over the 1:n relation they have, using the relation between the fields:
		/// Patient.Id - AgendaEvent.PatientId
		/// </summary>
		public virtual IEntityRelation AgendaEventEntityUsingPatientId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AgendaEvents" , true);
				relation.AddEntityFieldPair(PatientFields.Id, AgendaEventFields.PatientId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PatientEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AgendaEventEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PatientEntity and LivingRoomChoreEventEntity over the 1:n relation they have, using the relation between the fields:
		/// Patient.Id - LivingRoomChoreEvent.PatientId
		/// </summary>
		public virtual IEntityRelation LivingRoomChoreEventEntityUsingPatientId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "LivingRoomChoreEvents" , true);
				relation.AddEntityFieldPair(PatientFields.Id, LivingRoomChoreEventFields.PatientId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PatientEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingRoomChoreEventEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between PatientEntity and LivingRoomEntity over the m:1 relation they have, using the relation between the fields:
		/// Patient.LivingRoomId - LivingRoom.Id
		/// </summary>
		public virtual IEntityRelation LivingRoomEntityUsingLivingRoomId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "LivingRoom", false);
				relation.AddEntityFieldPair(LivingRoomFields.Id, PatientFields.LivingRoomId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingRoomEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PatientEntity", true);
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
	internal static class StaticPatientRelations
	{
		internal static readonly IEntityRelation AgendaEventEntityUsingPatientIdStatic = new PatientRelations().AgendaEventEntityUsingPatientId;
		internal static readonly IEntityRelation LivingRoomChoreEventEntityUsingPatientIdStatic = new PatientRelations().LivingRoomChoreEventEntityUsingPatientId;
		internal static readonly IEntityRelation LivingRoomEntityUsingLivingRoomIdStatic = new PatientRelations().LivingRoomEntityUsingLivingRoomId;

		/// <summary>CTor</summary>
		static StaticPatientRelations()
		{
		}
	}
}
