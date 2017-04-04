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
	/// <summary>Implements the relations factory for the entity: Livingroom. </summary>
	public partial class LivingroomRelations
	{
		/// <summary>CTor</summary>
		public LivingroomRelations()
		{
		}

		/// <summary>Gets all relations of the LivingroomEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ChoreEntityUsingLivingroomId);
			toReturn.Add(this.EmployeeLivingroomEntityUsingLivingroomId);
			toReturn.Add(this.PatientEntityUsingLivingroomId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between LivingroomEntity and ChoreEntity over the 1:n relation they have, using the relation between the fields:
		/// Livingroom.Id - Chore.LivingroomId
		/// </summary>
		public virtual IEntityRelation ChoreEntityUsingLivingroomId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Chores" , true);
				relation.AddEntityFieldPair(LivingroomFields.Id, ChoreFields.LivingroomId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingroomEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChoreEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LivingroomEntity and EmployeeLivingroomEntity over the 1:n relation they have, using the relation between the fields:
		/// Livingroom.Id - EmployeeLivingroom.LivingroomId
		/// </summary>
		public virtual IEntityRelation EmployeeLivingroomEntityUsingLivingroomId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "EmployeeLivingrooms" , true);
				relation.AddEntityFieldPair(LivingroomFields.Id, EmployeeLivingroomFields.LivingroomId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingroomEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeLivingroomEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LivingroomEntity and PatientEntity over the 1:n relation they have, using the relation between the fields:
		/// Livingroom.Id - Patient.LivingroomId
		/// </summary>
		public virtual IEntityRelation PatientEntityUsingLivingroomId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Patients" , true);
				relation.AddEntityFieldPair(LivingroomFields.Id, PatientFields.LivingroomId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingroomEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PatientEntity", false);
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
	internal static class StaticLivingroomRelations
	{
		internal static readonly IEntityRelation ChoreEntityUsingLivingroomIdStatic = new LivingroomRelations().ChoreEntityUsingLivingroomId;
		internal static readonly IEntityRelation EmployeeLivingroomEntityUsingLivingroomIdStatic = new LivingroomRelations().EmployeeLivingroomEntityUsingLivingroomId;
		internal static readonly IEntityRelation PatientEntityUsingLivingroomIdStatic = new LivingroomRelations().PatientEntityUsingLivingroomId;

		/// <summary>CTor</summary>
		static StaticLivingroomRelations()
		{
		}
	}
}
