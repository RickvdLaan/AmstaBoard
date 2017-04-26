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
	/// <summary>Implements the relations factory for the entity: GeneralInformation. </summary>
	public partial class GeneralInformationRelations
	{
		/// <summary>CTor</summary>
		public GeneralInformationRelations()
		{
		}

		/// <summary>Gets all relations of the GeneralInformationEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.GeneralLivingroomEntityUsingLivingroomId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between GeneralInformationEntity and GeneralLivingroomEntity over the m:1 relation they have, using the relation between the fields:
		/// GeneralInformation.LivingroomId - GeneralLivingroom.LivingroomId
		/// </summary>
		public virtual IEntityRelation GeneralLivingroomEntityUsingLivingroomId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "GeneralLivingroom", false);
				relation.AddEntityFieldPair(GeneralLivingroomFields.LivingroomId, GeneralInformationFields.LivingroomId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GeneralLivingroomEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GeneralInformationEntity", true);
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
	internal static class StaticGeneralInformationRelations
	{
		internal static readonly IEntityRelation GeneralLivingroomEntityUsingLivingroomIdStatic = new GeneralInformationRelations().GeneralLivingroomEntityUsingLivingroomId;

		/// <summary>CTor</summary>
		static StaticGeneralInformationRelations()
		{
		}
	}
}
