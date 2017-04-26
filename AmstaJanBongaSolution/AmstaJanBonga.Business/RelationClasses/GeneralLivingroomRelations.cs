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
	/// <summary>Implements the relations factory for the entity: GeneralLivingroom. </summary>
	public partial class GeneralLivingroomRelations
	{
		/// <summary>CTor</summary>
		public GeneralLivingroomRelations()
		{
		}

		/// <summary>Gets all relations of the GeneralLivingroomEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.GeneralInformationEntityUsingLivingroomId);
			toReturn.Add(this.LivingroomEntityUsingLivingroomId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between GeneralLivingroomEntity and GeneralInformationEntity over the 1:n relation they have, using the relation between the fields:
		/// GeneralLivingroom.LivingroomId - GeneralInformation.LivingroomId
		/// </summary>
		public virtual IEntityRelation GeneralInformationEntityUsingLivingroomId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "GeneralInformations" , true);
				relation.AddEntityFieldPair(GeneralLivingroomFields.LivingroomId, GeneralInformationFields.LivingroomId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GeneralLivingroomEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GeneralInformationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between GeneralLivingroomEntity and LivingroomEntity over the 1:1 relation they have, using the relation between the fields:
		/// GeneralLivingroom.LivingroomId - Livingroom.Id
		/// </summary>
		public virtual IEntityRelation LivingroomEntityUsingLivingroomId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "Livingroom", false);



				relation.AddEntityFieldPair(LivingroomFields.Id, GeneralLivingroomFields.LivingroomId);

				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingroomEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GeneralLivingroomEntity", true);
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
	internal static class StaticGeneralLivingroomRelations
	{
		internal static readonly IEntityRelation GeneralInformationEntityUsingLivingroomIdStatic = new GeneralLivingroomRelations().GeneralInformationEntityUsingLivingroomId;
		internal static readonly IEntityRelation LivingroomEntityUsingLivingroomIdStatic = new GeneralLivingroomRelations().LivingroomEntityUsingLivingroomId;

		/// <summary>CTor</summary>
		static StaticGeneralLivingroomRelations()
		{
		}
	}
}
