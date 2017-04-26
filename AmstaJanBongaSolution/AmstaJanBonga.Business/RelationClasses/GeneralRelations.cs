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
	/// <summary>Implements the relations factory for the entity: General. </summary>
	public partial class GeneralRelations
	{
		/// <summary>CTor</summary>
		public GeneralRelations()
		{
		}

		/// <summary>Gets all relations of the GeneralEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.GeneralInformationEntityUsingLivingroomId);
			toReturn.Add(this.LivingroomEntityUsingLivingroomId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between GeneralEntity and GeneralInformationEntity over the 1:n relation they have, using the relation between the fields:
		/// General.LivingroomId - GeneralInformation.LivingroomId
		/// </summary>
		public virtual IEntityRelation GeneralInformationEntityUsingLivingroomId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "GeneralInformations" , true);
				relation.AddEntityFieldPair(GeneralFields.LivingroomId, GeneralInformationFields.LivingroomId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GeneralEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GeneralInformationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between GeneralEntity and LivingroomEntity over the 1:1 relation they have, using the relation between the fields:
		/// General.LivingroomId - Livingroom.Id
		/// </summary>
		public virtual IEntityRelation LivingroomEntityUsingLivingroomId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "Livingroom", false);



				relation.AddEntityFieldPair(LivingroomFields.Id, GeneralFields.LivingroomId);

				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LivingroomEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GeneralEntity", true);
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
	internal static class StaticGeneralRelations
	{
		internal static readonly IEntityRelation GeneralInformationEntityUsingLivingroomIdStatic = new GeneralRelations().GeneralInformationEntityUsingLivingroomId;
		internal static readonly IEntityRelation LivingroomEntityUsingLivingroomIdStatic = new GeneralRelations().LivingroomEntityUsingLivingroomId;

		/// <summary>CTor</summary>
		static StaticGeneralRelations()
		{
		}
	}
}
