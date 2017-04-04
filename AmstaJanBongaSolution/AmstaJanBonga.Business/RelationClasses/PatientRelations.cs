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
			toReturn.Add(this.ChoreEntityUsingPatientIdLivingroomId);
			toReturn.Add(this.LivingroomEntityUsingLivingroomId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between PatientEntity and ChoreEntity over the 1:n relation they have, using the relation between the fields:
		/// Patient.Id - Chore.PatientId
		/// Patient.LivingroomId - Chore.LivingroomId
		/// </summary>
		public virtual IEntityRelation ChoreEntityUsingPatientIdLivingroomId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Chores" , true);
				relation.AddEntityFieldPair(PatientFields.Id, ChoreFields.PatientId);
				relation.AddEntityFieldPair(PatientFields.LivingroomId, ChoreFields.LivingroomId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PatientEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChoreEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between PatientEntity and LivingroomEntity over the m:1 relation they have, using the relation between the fields:
		/// Patient.LivingroomId - Livingroom.Id
		/// </summary>
		public virtual IEntityRelation LivingroomEntityUsingLivingroomId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Livingroom", false);
				relation.AddEntityFieldPair(LivingroomFields.Id, PatientFields.LivingroomId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingroomEntity", false);
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
		internal static readonly IEntityRelation ChoreEntityUsingPatientIdLivingroomIdStatic = new PatientRelations().ChoreEntityUsingPatientIdLivingroomId;
		internal static readonly IEntityRelation LivingroomEntityUsingLivingroomIdStatic = new PatientRelations().LivingroomEntityUsingLivingroomId;

		/// <summary>CTor</summary>
		static StaticPatientRelations()
		{
		}
	}
}
