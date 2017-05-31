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
	/// <summary>Implements the relations factory for the entity: LivingRoom. </summary>
	public partial class LivingRoomRelations
	{
		/// <summary>CTor</summary>
		public LivingRoomRelations()
		{
		}

		/// <summary>Gets all relations of the LivingRoomEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.EmployeeEntityUsingLivingRoomId);
			toReturn.Add(this.LivingRoomChoreEventEntityUsingLivingRoomId);
			toReturn.Add(this.LivingRoomGeneralEventEntityUsingLivingRoomId);
			toReturn.Add(this.LivingRoomShiftEventEntityUsingLivingRoomId);
			toReturn.Add(this.PatientEntityUsingLivingRoomId);
			toReturn.Add(this.LivingRoomGeneralEntityUsingLivingRoomId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between LivingRoomEntity and EmployeeEntity over the 1:n relation they have, using the relation between the fields:
		/// LivingRoom.Id - Employee.LivingRoomId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingLivingRoomId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Employees" , true);
				relation.AddEntityFieldPair(LivingRoomFields.Id, EmployeeFields.LivingRoomId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingRoomEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LivingRoomEntity and LivingRoomChoreEventEntity over the 1:n relation they have, using the relation between the fields:
		/// LivingRoom.Id - LivingRoomChoreEvent.LivingRoomId
		/// </summary>
		public virtual IEntityRelation LivingRoomChoreEventEntityUsingLivingRoomId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "LivingRoomChoreEvents" , true);
				relation.AddEntityFieldPair(LivingRoomFields.Id, LivingRoomChoreEventFields.LivingRoomId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingRoomEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingRoomChoreEventEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LivingRoomEntity and LivingRoomGeneralEventEntity over the 1:n relation they have, using the relation between the fields:
		/// LivingRoom.Id - LivingRoomGeneralEvent.LivingRoomId
		/// </summary>
		public virtual IEntityRelation LivingRoomGeneralEventEntityUsingLivingRoomId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "LivingRoomGeneralEvents" , true);
				relation.AddEntityFieldPair(LivingRoomFields.Id, LivingRoomGeneralEventFields.LivingRoomId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingRoomEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingRoomGeneralEventEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LivingRoomEntity and LivingRoomShiftEventEntity over the 1:n relation they have, using the relation between the fields:
		/// LivingRoom.Id - LivingRoomShiftEvent.LivingRoomId
		/// </summary>
		public virtual IEntityRelation LivingRoomShiftEventEntityUsingLivingRoomId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "LivingRoomShiftEvents" , true);
				relation.AddEntityFieldPair(LivingRoomFields.Id, LivingRoomShiftEventFields.LivingRoomId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingRoomEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingRoomShiftEventEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LivingRoomEntity and PatientEntity over the 1:n relation they have, using the relation between the fields:
		/// LivingRoom.Id - Patient.LivingRoomId
		/// </summary>
		public virtual IEntityRelation PatientEntityUsingLivingRoomId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Patients" , true);
				relation.AddEntityFieldPair(LivingRoomFields.Id, PatientFields.LivingRoomId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingRoomEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PatientEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LivingRoomEntity and LivingRoomGeneralEntity over the 1:1 relation they have, using the relation between the fields:
		/// LivingRoom.Id - LivingRoomGeneral.LivingRoomId
		/// </summary>
		public virtual IEntityRelation LivingRoomGeneralEntityUsingLivingRoomId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "LivingRoomGeneral", true);

				relation.AddEntityFieldPair(LivingRoomFields.Id, LivingRoomGeneralFields.LivingRoomId);



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingRoomEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingRoomGeneralEntity", false);
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
	internal static class StaticLivingRoomRelations
	{
		internal static readonly IEntityRelation EmployeeEntityUsingLivingRoomIdStatic = new LivingRoomRelations().EmployeeEntityUsingLivingRoomId;
		internal static readonly IEntityRelation LivingRoomChoreEventEntityUsingLivingRoomIdStatic = new LivingRoomRelations().LivingRoomChoreEventEntityUsingLivingRoomId;
		internal static readonly IEntityRelation LivingRoomGeneralEventEntityUsingLivingRoomIdStatic = new LivingRoomRelations().LivingRoomGeneralEventEntityUsingLivingRoomId;
		internal static readonly IEntityRelation LivingRoomShiftEventEntityUsingLivingRoomIdStatic = new LivingRoomRelations().LivingRoomShiftEventEntityUsingLivingRoomId;
		internal static readonly IEntityRelation PatientEntityUsingLivingRoomIdStatic = new LivingRoomRelations().PatientEntityUsingLivingRoomId;
		internal static readonly IEntityRelation LivingRoomGeneralEntityUsingLivingRoomIdStatic = new LivingRoomRelations().LivingRoomGeneralEntityUsingLivingRoomId;

		/// <summary>CTor</summary>
		static StaticLivingRoomRelations()
		{
		}
	}
}
