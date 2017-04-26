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
	/// <summary>Implements the relations factory for the entity: LivingroomChoreEvent. </summary>
	public partial class LivingroomChoreEventRelations
	{
		/// <summary>CTor</summary>
		public LivingroomChoreEventRelations()
		{
		}

		/// <summary>Gets all relations of the LivingroomChoreEventEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.LivingroomEntityUsingLivingroomId);
			toReturn.Add(this.PatientEntityUsingPatientId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between LivingroomChoreEventEntity and LivingroomEntity over the m:1 relation they have, using the relation between the fields:
		/// LivingroomChoreEvent.LivingroomId - Livingroom.Id
		/// </summary>
		public virtual IEntityRelation LivingroomEntityUsingLivingroomId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Livingroom", false);
				relation.AddEntityFieldPair(LivingroomFields.Id, LivingroomChoreEventFields.LivingroomId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingroomEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingroomChoreEventEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between LivingroomChoreEventEntity and PatientEntity over the m:1 relation they have, using the relation between the fields:
		/// LivingroomChoreEvent.PatientId - Patient.Id
		/// </summary>
		public virtual IEntityRelation PatientEntityUsingPatientId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Patient", false);
				relation.AddEntityFieldPair(PatientFields.Id, LivingroomChoreEventFields.PatientId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PatientEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingroomChoreEventEntity", true);
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
	internal static class StaticLivingroomChoreEventRelations
	{
		internal static readonly IEntityRelation LivingroomEntityUsingLivingroomIdStatic = new LivingroomChoreEventRelations().LivingroomEntityUsingLivingroomId;
		internal static readonly IEntityRelation PatientEntityUsingPatientIdStatic = new LivingroomChoreEventRelations().PatientEntityUsingPatientId;

		/// <summary>CTor</summary>
		static StaticLivingroomChoreEventRelations()
		{
		}
	}
}
