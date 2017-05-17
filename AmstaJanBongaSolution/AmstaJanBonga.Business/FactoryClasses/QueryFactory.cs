///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
////////////////////////////////////////////////////////////// 
using System;
using System.Linq;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec;

namespace AmstaJanBonga.Business.FactoryClasses
{
	/// <summary>Factory class to produce DynamicQuery instances and EntityQuery instances</summary>
	public partial class QueryFactory
	{
		private int _aliasCounter = 0;

		/// <summary>Creates a new DynamicQuery instance with no alias set.</summary>
		/// <returns>Ready to use DynamicQuery instance</returns>
		public DynamicQuery Create()
		{
			return Create(string.Empty);
		}

		/// <summary>Creates a new DynamicQuery instance with the alias specified as the alias set.</summary>
		/// <param name="alias">The alias.</param>
		/// <returns>Ready to use DynamicQuery instance</returns>
		public DynamicQuery Create(string alias)
		{
			return new DynamicQuery(new ElementCreator(), alias, this.GetNextAliasCounterValue());
		}

		/// <summary>Creates a new DynamicQuery which wraps the specified TableValuedFunction call</summary>
		/// <param name="toWrap">The table valued function call to wrap.</param>
		/// <returns>toWrap wrapped in a DynamicQuery.</returns>
		public DynamicQuery Create(TableValuedFunctionCall toWrap)
		{
			return this.Create().From(new TvfCallWrapper(toWrap)).Select(toWrap.GetFieldsAsArray().Select(f => this.Field(toWrap.Alias, f.Alias)).ToArray());
		}

		/// <summary>Creates a new EntityQuery for the entity of the type specified with no alias set.</summary>
		/// <typeparam name="TEntity">The type of the entity to produce the query for.</typeparam>
		/// <returns>ready to use EntityQuery instance</returns>
		public EntityQuery<TEntity> Create<TEntity>()
			where TEntity : IEntityCore
		{
			return Create<TEntity>(string.Empty);
		}

		/// <summary>Creates a new EntityQuery for the entity of the type specified with the alias specified as the alias set.</summary>
		/// <typeparam name="TEntity">The type of the entity to produce the query for.</typeparam>
		/// <param name="alias">The alias.</param>
		/// <returns>ready to use EntityQuery instance</returns>
		public EntityQuery<TEntity> Create<TEntity>(string alias)
			where TEntity : IEntityCore
		{
			return new EntityQuery<TEntity>(new ElementCreator(), alias, this.GetNextAliasCounterValue());
		}
				
		/// <summary>Creates a new field object with the name specified and of resulttype 'object'. Used for referring to aliased fields in another projection.</summary>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField Field(string fieldName)
		{
			return Field<object>(string.Empty, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'object'. Used for referring to aliased fields in another projection.</summary>
		/// <param name="targetAlias">The alias of the table/query to target.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField Field(string targetAlias, string fieldName)
		{
			return Field<object>(targetAlias, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'TValue'. Used for referring to aliased fields in another projection.</summary>
		/// <typeparam name="TValue">The type of the value represented by the field.</typeparam>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField Field<TValue>(string fieldName)
		{
			return Field<TValue>(string.Empty, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'TValue'. Used for referring to aliased fields in another projection.</summary>
		/// <typeparam name="TValue">The type of the value.</typeparam>
		/// <param name="targetAlias">The alias of the table/query to target.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField Field<TValue>(string targetAlias, string fieldName)
		{
			return new EntityField(fieldName, targetAlias, typeof(TValue));
		}
						
		/// <summary>Gets the next alias counter value to produce artifical aliases with</summary>
		private int GetNextAliasCounterValue()
		{
			_aliasCounter++;
			return _aliasCounter;
		}
		

		/// <summary>Creates and returns a new EntityQuery for the AgendaEvent entity</summary>
		public EntityQuery<AgendaEventEntity> AgendaEvent
		{
			get { return Create<AgendaEventEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AgendaEventMeta entity</summary>
		public EntityQuery<AgendaEventMetaEntity> AgendaEventMeta
		{
			get { return Create<AgendaEventMetaEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Employee entity</summary>
		public EntityQuery<EmployeeEntity> Employee
		{
			get { return Create<EmployeeEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Ip entity</summary>
		public EntityQuery<IpEntity> Ip
		{
			get { return Create<IpEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the LivingRoom entity</summary>
		public EntityQuery<LivingRoomEntity> LivingRoom
		{
			get { return Create<LivingRoomEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the LivingRoomChoreEvent entity</summary>
		public EntityQuery<LivingRoomChoreEventEntity> LivingRoomChoreEvent
		{
			get { return Create<LivingRoomChoreEventEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the LivingRoomGeneral entity</summary>
		public EntityQuery<LivingRoomGeneralEntity> LivingRoomGeneral
		{
			get { return Create<LivingRoomGeneralEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the LivingRoomGeneralEvent entity</summary>
		public EntityQuery<LivingRoomGeneralEventEntity> LivingRoomGeneralEvent
		{
			get { return Create<LivingRoomGeneralEventEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the LivingRoomShiftEvent entity</summary>
		public EntityQuery<LivingRoomShiftEventEntity> LivingRoomShiftEvent
		{
			get { return Create<LivingRoomShiftEventEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Patient entity</summary>
		public EntityQuery<PatientEntity> Patient
		{
			get { return Create<PatientEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the User entity</summary>
		public EntityQuery<UserEntity> User
		{
			get { return Create<UserEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the UserActivity entity</summary>
		public EntityQuery<UserActivityEntity> UserActivity
		{
			get { return Create<UserActivityEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the UserRole entity</summary>
		public EntityQuery<UserRoleEntity> UserRole
		{
			get { return Create<UserRoleEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the UserRoleActivity entity</summary>
		public EntityQuery<UserRoleActivityEntity> UserRoleActivity
		{
			get { return Create<UserRoleActivityEntity>(); }
		}


 
	}
}