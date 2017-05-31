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
	/// <summary>Implements the relations factory for the entity: AgendaEvent. </summary>
	public partial class AgendaEventRelations
	{
		/// <summary>CTor</summary>
		public AgendaEventRelations()
		{
		}

		/// <summary>Gets all relations of the AgendaEventEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AgendaEventMetaEntityUsingAgendaEventId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between AgendaEventEntity and AgendaEventMetaEntity over the 1:n relation they have, using the relation between the fields:
		/// AgendaEvent.Id - AgendaEventMeta.AgendaEventId
		/// </summary>
		public virtual IEntityRelation AgendaEventMetaEntityUsingAgendaEventId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AgendaEventMeta" , true);
				relation.AddEntityFieldPair(AgendaEventFields.Id, AgendaEventMetaFields.AgendaEventId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AgendaEventEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AgendaEventMetaEntity", false);
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
	internal static class StaticAgendaEventRelations
	{
		internal static readonly IEntityRelation AgendaEventMetaEntityUsingAgendaEventIdStatic = new AgendaEventRelations().AgendaEventMetaEntityUsingAgendaEventId;

		/// <summary>CTor</summary>
		static StaticAgendaEventRelations()
		{
		}
	}
}
