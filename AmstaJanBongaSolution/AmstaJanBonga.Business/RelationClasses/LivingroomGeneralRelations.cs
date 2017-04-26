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
	/// <summary>Implements the relations factory for the entity: LivingroomGeneral. </summary>
	public partial class LivingroomGeneralRelations
	{
		/// <summary>CTor</summary>
		public LivingroomGeneralRelations()
		{
		}

		/// <summary>Gets all relations of the LivingroomGeneralEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.LivingroomGeneralEventEntityUsingLivingroomId);
			toReturn.Add(this.LivingroomEntityUsingLivingroomId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between LivingroomGeneralEntity and LivingroomGeneralEventEntity over the 1:n relation they have, using the relation between the fields:
		/// LivingroomGeneral.LivingroomId - LivingroomGeneralEvent.LivingroomId
		/// </summary>
		public virtual IEntityRelation LivingroomGeneralEventEntityUsingLivingroomId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "LivingroomGeneralEvents" , true);
				relation.AddEntityFieldPair(LivingroomGeneralFields.LivingroomId, LivingroomGeneralEventFields.LivingroomId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingroomGeneralEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingroomGeneralEventEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LivingroomGeneralEntity and LivingroomEntity over the 1:1 relation they have, using the relation between the fields:
		/// LivingroomGeneral.LivingroomId - Livingroom.Id
		/// </summary>
		public virtual IEntityRelation LivingroomEntityUsingLivingroomId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "Livingroom", false);



				relation.AddEntityFieldPair(LivingroomFields.Id, LivingroomGeneralFields.LivingroomId);

				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingroomEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingroomGeneralEntity", true);
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
	internal static class StaticLivingroomGeneralRelations
	{
		internal static readonly IEntityRelation LivingroomGeneralEventEntityUsingLivingroomIdStatic = new LivingroomGeneralRelations().LivingroomGeneralEventEntityUsingLivingroomId;
		internal static readonly IEntityRelation LivingroomEntityUsingLivingroomIdStatic = new LivingroomGeneralRelations().LivingroomEntityUsingLivingroomId;

		/// <summary>CTor</summary>
		static StaticLivingroomGeneralRelations()
		{
		}
	}
}
