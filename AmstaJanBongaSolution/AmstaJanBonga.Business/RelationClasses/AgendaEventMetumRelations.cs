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
	/// <summary>Implements the relations factory for the entity: AgendaEventMetum. </summary>
	public partial class AgendaEventMetumRelations
	{
		/// <summary>CTor</summary>
		public AgendaEventMetumRelations()
		{
		}

		/// <summary>Gets all relations of the AgendaEventMetumEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AgendaEventEntityUsingAgendaEventId);
			toReturn.Add(this.PatientEntityUsingPatientId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between AgendaEventMetumEntity and AgendaEventEntity over the m:1 relation they have, using the relation between the fields:
		/// AgendaEventMetum.AgendaEventId - AgendaEvent.Id
		/// </summary>
		public virtual IEntityRelation AgendaEventEntityUsingAgendaEventId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AgendaEvent", false);
				relation.AddEntityFieldPair(AgendaEventFields.Id, AgendaEventMetumFields.AgendaEventId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AgendaEventEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AgendaEventMetumEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between AgendaEventMetumEntity and PatientEntity over the m:1 relation they have, using the relation between the fields:
		/// AgendaEventMetum.PatientId - Patient.Id
		/// </summary>
		public virtual IEntityRelation PatientEntityUsingPatientId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Patient", false);
				relation.AddEntityFieldPair(PatientFields.Id, AgendaEventMetumFields.PatientId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PatientEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AgendaEventMetumEntity", true);
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
	internal static class StaticAgendaEventMetumRelations
	{
		internal static readonly IEntityRelation AgendaEventEntityUsingAgendaEventIdStatic = new AgendaEventMetumRelations().AgendaEventEntityUsingAgendaEventId;
		internal static readonly IEntityRelation PatientEntityUsingPatientIdStatic = new AgendaEventMetumRelations().PatientEntityUsingPatientId;

		/// <summary>CTor</summary>
		static StaticAgendaEventMetumRelations()
		{
		}
	}
}
