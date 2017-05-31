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
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AmstaJanBonga.Business.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal static class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass( (14 + 0));
			InitAgendaEventEntityInfos();
			InitAgendaEventMetaEntityInfos();
			InitEmployeeEntityInfos();
			InitIpEntityInfos();
			InitLivingRoomEntityInfos();
			InitLivingRoomChoreEventEntityInfos();
			InitLivingRoomGeneralEntityInfos();
			InitLivingRoomGeneralEventEntityInfos();
			InitLivingRoomShiftEventEntityInfos();
			InitPatientEntityInfos();
			InitUserEntityInfos();
			InitUserActivityEntityInfos();
			InitUserRoleEntityInfos();
			InitUserRoleActivityEntityInfos();

			this.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits AgendaEventEntity's FieldInfo objects</summary>
		private void InitAgendaEventEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AgendaEventFieldIndex), "AgendaEventEntity");
			this.AddElementFieldInfo("AgendaEventEntity", "Description", typeof(System.String), false, false, false, true,  (int)AgendaEventFieldIndex.Description, 500, 0, 0);
			this.AddElementFieldInfo("AgendaEventEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)AgendaEventFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("AgendaEventEntity", "Location", typeof(System.String), false, false, false, true,  (int)AgendaEventFieldIndex.Location, 50, 0, 0);
			this.AddElementFieldInfo("AgendaEventEntity", "TimeEnd", typeof(System.Int32), false, false, false, false,  (int)AgendaEventFieldIndex.TimeEnd, 0, 0, 10);
			this.AddElementFieldInfo("AgendaEventEntity", "TimeStart", typeof(System.Int32), false, false, false, false,  (int)AgendaEventFieldIndex.TimeStart, 0, 0, 10);
			this.AddElementFieldInfo("AgendaEventEntity", "Title", typeof(System.String), false, false, false, false,  (int)AgendaEventFieldIndex.Title, 50, 0, 0);
		}
		/// <summary>Inits AgendaEventMetaEntity's FieldInfo objects</summary>
		private void InitAgendaEventMetaEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AgendaEventMetaFieldIndex), "AgendaEventMetaEntity");
			this.AddElementFieldInfo("AgendaEventMetaEntity", "AgendaEventId", typeof(System.Int32), false, true, false, false,  (int)AgendaEventMetaFieldIndex.AgendaEventId, 0, 0, 10);
			this.AddElementFieldInfo("AgendaEventMetaEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)AgendaEventMetaFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("AgendaEventMetaEntity", "PatientId", typeof(System.Int32), false, true, false, false,  (int)AgendaEventMetaFieldIndex.PatientId, 0, 0, 10);
			this.AddElementFieldInfo("AgendaEventMetaEntity", "RepeatInterval", typeof(Nullable<System.Int32>), false, false, false, true,  (int)AgendaEventMetaFieldIndex.RepeatInterval, 0, 0, 10);
			this.AddElementFieldInfo("AgendaEventMetaEntity", "RepeatStart", typeof(Nullable<System.Int32>), false, false, false, true,  (int)AgendaEventMetaFieldIndex.RepeatStart, 0, 0, 10);
			this.AddElementFieldInfo("AgendaEventMetaEntity", "SingleEvent", typeof(Nullable<System.Int32>), false, false, false, true,  (int)AgendaEventMetaFieldIndex.SingleEvent, 0, 0, 10);
		}
		/// <summary>Inits EmployeeEntity's FieldInfo objects</summary>
		private void InitEmployeeEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(EmployeeFieldIndex), "EmployeeEntity");
			this.AddElementFieldInfo("EmployeeEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)EmployeeFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "DateDeleted", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)EmployeeFieldIndex.DateDeleted, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "DateLastModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)EmployeeFieldIndex.DateLastModified, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "DateLastModifiedByUserId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)EmployeeFieldIndex.DateLastModifiedByUserId, 0, 0, 10);
			this.AddElementFieldInfo("EmployeeEntity", "FirstName", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.FirstName, 50, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)EmployeeFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("EmployeeEntity", "ImagePath", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.ImagePath, 250, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "IsMarkedAsDeleted", typeof(System.Boolean), false, false, false, false,  (int)EmployeeFieldIndex.IsMarkedAsDeleted, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "LivingRoomId", typeof(System.Int32), false, true, false, false,  (int)EmployeeFieldIndex.LivingRoomId, 0, 0, 10);
			this.AddElementFieldInfo("EmployeeEntity", "UserId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)EmployeeFieldIndex.UserId, 0, 0, 10);
		}
		/// <summary>Inits IpEntity's FieldInfo objects</summary>
		private void InitIpEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(IpFieldIndex), "IpEntity");
			this.AddElementFieldInfo("IpEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)IpFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("IpEntity", "DateLastModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)IpFieldIndex.DateLastModified, 0, 0, 0);
			this.AddElementFieldInfo("IpEntity", "DateLastModifiedByUserId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)IpFieldIndex.DateLastModifiedByUserId, 0, 0, 10);
			this.AddElementFieldInfo("IpEntity", "Description", typeof(System.String), false, false, false, false,  (int)IpFieldIndex.Description, 250, 0, 0);
			this.AddElementFieldInfo("IpEntity", "Ipaddress", typeof(System.String), true, false, false, false,  (int)IpFieldIndex.Ipaddress, 20, 0, 0);
		}
		/// <summary>Inits LivingRoomEntity's FieldInfo objects</summary>
		private void InitLivingRoomEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(LivingRoomFieldIndex), "LivingRoomEntity");
			this.AddElementFieldInfo("LivingRoomEntity", "ColourTypeEnum", typeof(System.Byte), false, false, false, false,  (int)LivingRoomFieldIndex.ColourTypeEnum, 0, 0, 3);
			this.AddElementFieldInfo("LivingRoomEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)LivingRoomFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("LivingRoomEntity", "DateDeleted", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)LivingRoomFieldIndex.DateDeleted, 0, 0, 0);
			this.AddElementFieldInfo("LivingRoomEntity", "DateLastModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)LivingRoomFieldIndex.DateLastModified, 0, 0, 0);
			this.AddElementFieldInfo("LivingRoomEntity", "DateLastModifiedByUserId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)LivingRoomFieldIndex.DateLastModifiedByUserId, 0, 0, 10);
			this.AddElementFieldInfo("LivingRoomEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)LivingRoomFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("LivingRoomEntity", "IsMarkedAsDeleted", typeof(System.Boolean), false, false, false, false,  (int)LivingRoomFieldIndex.IsMarkedAsDeleted, 0, 0, 0);
			this.AddElementFieldInfo("LivingRoomEntity", "Name", typeof(System.String), false, false, false, false,  (int)LivingRoomFieldIndex.Name, 50, 0, 0);
		}
		/// <summary>Inits LivingRoomChoreEventEntity's FieldInfo objects</summary>
		private void InitLivingRoomChoreEventEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(LivingRoomChoreEventFieldIndex), "LivingRoomChoreEventEntity");
			this.AddElementFieldInfo("LivingRoomChoreEventEntity", "Date", typeof(System.DateTime), true, false, false, false,  (int)LivingRoomChoreEventFieldIndex.Date, 0, 0, 0);
			this.AddElementFieldInfo("LivingRoomChoreEventEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)LivingRoomChoreEventFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("LivingRoomChoreEventEntity", "DateLastModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)LivingRoomChoreEventFieldIndex.DateLastModified, 0, 0, 0);
			this.AddElementFieldInfo("LivingRoomChoreEventEntity", "DateLastModifiedByUserId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)LivingRoomChoreEventFieldIndex.DateLastModifiedByUserId, 0, 0, 10);
			this.AddElementFieldInfo("LivingRoomChoreEventEntity", "LivingRoomId", typeof(System.Int32), true, true, false, false,  (int)LivingRoomChoreEventFieldIndex.LivingRoomId, 0, 0, 10);
			this.AddElementFieldInfo("LivingRoomChoreEventEntity", "PatientId", typeof(System.Int32), true, true, false, false,  (int)LivingRoomChoreEventFieldIndex.PatientId, 0, 0, 10);
			this.AddElementFieldInfo("LivingRoomChoreEventEntity", "TimeOfDayTypeEnum", typeof(System.Byte), true, false, false, false,  (int)LivingRoomChoreEventFieldIndex.TimeOfDayTypeEnum, 0, 0, 3);
		}
		/// <summary>Inits LivingRoomGeneralEntity's FieldInfo objects</summary>
		private void InitLivingRoomGeneralEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(LivingRoomGeneralFieldIndex), "LivingRoomGeneralEntity");
			this.AddElementFieldInfo("LivingRoomGeneralEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)LivingRoomGeneralFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("LivingRoomGeneralEntity", "DateLastModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)LivingRoomGeneralFieldIndex.DateLastModified, 0, 0, 0);
			this.AddElementFieldInfo("LivingRoomGeneralEntity", "DateLastModifiedByUserId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)LivingRoomGeneralFieldIndex.DateLastModifiedByUserId, 0, 0, 10);
			this.AddElementFieldInfo("LivingRoomGeneralEntity", "Description", typeof(System.String), false, false, false, true,  (int)LivingRoomGeneralFieldIndex.Description, 50, 0, 0);
			this.AddElementFieldInfo("LivingRoomGeneralEntity", "LivingRoomId", typeof(System.Int32), true, true, false, false,  (int)LivingRoomGeneralFieldIndex.LivingRoomId, 0, 0, 10);
		}
		/// <summary>Inits LivingRoomGeneralEventEntity's FieldInfo objects</summary>
		private void InitLivingRoomGeneralEventEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(LivingRoomGeneralEventFieldIndex), "LivingRoomGeneralEventEntity");
			this.AddElementFieldInfo("LivingRoomGeneralEventEntity", "Date", typeof(System.DateTime), true, false, false, false,  (int)LivingRoomGeneralEventFieldIndex.Date, 0, 0, 0);
			this.AddElementFieldInfo("LivingRoomGeneralEventEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)LivingRoomGeneralEventFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("LivingRoomGeneralEventEntity", "DateLastModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)LivingRoomGeneralEventFieldIndex.DateLastModified, 0, 0, 0);
			this.AddElementFieldInfo("LivingRoomGeneralEventEntity", "DateLastModifiedByUserId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)LivingRoomGeneralEventFieldIndex.DateLastModifiedByUserId, 0, 0, 10);
			this.AddElementFieldInfo("LivingRoomGeneralEventEntity", "Description", typeof(System.String), false, false, false, false,  (int)LivingRoomGeneralEventFieldIndex.Description, 250, 0, 0);
			this.AddElementFieldInfo("LivingRoomGeneralEventEntity", "LivingRoomId", typeof(System.Int32), true, true, false, false,  (int)LivingRoomGeneralEventFieldIndex.LivingRoomId, 0, 0, 10);
		}
		/// <summary>Inits LivingRoomShiftEventEntity's FieldInfo objects</summary>
		private void InitLivingRoomShiftEventEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(LivingRoomShiftEventFieldIndex), "LivingRoomShiftEventEntity");
			this.AddElementFieldInfo("LivingRoomShiftEventEntity", "Date", typeof(System.DateTime), true, false, false, false,  (int)LivingRoomShiftEventFieldIndex.Date, 0, 0, 0);
			this.AddElementFieldInfo("LivingRoomShiftEventEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)LivingRoomShiftEventFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("LivingRoomShiftEventEntity", "DateLastModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)LivingRoomShiftEventFieldIndex.DateLastModified, 0, 0, 0);
			this.AddElementFieldInfo("LivingRoomShiftEventEntity", "DateLastModifiedByUserId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)LivingRoomShiftEventFieldIndex.DateLastModifiedByUserId, 0, 0, 10);
			this.AddElementFieldInfo("LivingRoomShiftEventEntity", "EmployeeId", typeof(System.Int32), true, true, false, false,  (int)LivingRoomShiftEventFieldIndex.EmployeeId, 0, 0, 10);
			this.AddElementFieldInfo("LivingRoomShiftEventEntity", "LivingRoomId", typeof(System.Int32), true, true, false, false,  (int)LivingRoomShiftEventFieldIndex.LivingRoomId, 0, 0, 10);
			this.AddElementFieldInfo("LivingRoomShiftEventEntity", "ShiftTypeEnum", typeof(System.Byte), true, false, false, false,  (int)LivingRoomShiftEventFieldIndex.ShiftTypeEnum, 0, 0, 3);
		}
		/// <summary>Inits PatientEntity's FieldInfo objects</summary>
		private void InitPatientEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PatientFieldIndex), "PatientEntity");
			this.AddElementFieldInfo("PatientEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)PatientFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("PatientEntity", "DateDeleted", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PatientFieldIndex.DateDeleted, 0, 0, 0);
			this.AddElementFieldInfo("PatientEntity", "DateLastModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PatientFieldIndex.DateLastModified, 0, 0, 0);
			this.AddElementFieldInfo("PatientEntity", "DateLastModifiedByUserId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)PatientFieldIndex.DateLastModifiedByUserId, 0, 0, 10);
			this.AddElementFieldInfo("PatientEntity", "FirstName", typeof(System.String), false, false, false, false,  (int)PatientFieldIndex.FirstName, 50, 0, 0);
			this.AddElementFieldInfo("PatientEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)PatientFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("PatientEntity", "ImagePath", typeof(System.String), false, false, false, false,  (int)PatientFieldIndex.ImagePath, 250, 0, 0);
			this.AddElementFieldInfo("PatientEntity", "IsMarkedAsDeleted", typeof(System.Boolean), false, false, false, false,  (int)PatientFieldIndex.IsMarkedAsDeleted, 0, 0, 0);
			this.AddElementFieldInfo("PatientEntity", "LivingRoomId", typeof(System.Int32), false, true, false, false,  (int)PatientFieldIndex.LivingRoomId, 0, 0, 10);
		}
		/// <summary>Inits UserEntity's FieldInfo objects</summary>
		private void InitUserEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(UserFieldIndex), "UserEntity");
			this.AddElementFieldInfo("UserEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)UserFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("UserEntity", "DateDeleted", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)UserFieldIndex.DateDeleted, 0, 0, 0);
			this.AddElementFieldInfo("UserEntity", "DateLastLogin", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)UserFieldIndex.DateLastLogin, 0, 0, 0);
			this.AddElementFieldInfo("UserEntity", "DateLastModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)UserFieldIndex.DateLastModified, 0, 0, 0);
			this.AddElementFieldInfo("UserEntity", "DateLastModifiedByUserId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)UserFieldIndex.DateLastModifiedByUserId, 0, 0, 10);
			this.AddElementFieldInfo("UserEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)UserFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("UserEntity", "IsMarkedAsDeleted", typeof(System.Boolean), false, false, false, false,  (int)UserFieldIndex.IsMarkedAsDeleted, 0, 0, 0);
			this.AddElementFieldInfo("UserEntity", "Password", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Password, 250, 0, 0);
			this.AddElementFieldInfo("UserEntity", "RoleTypeEnum", typeof(System.Byte), false, true, false, false,  (int)UserFieldIndex.RoleTypeEnum, 0, 0, 3);
			this.AddElementFieldInfo("UserEntity", "Salt", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Salt, 250, 0, 0);
			this.AddElementFieldInfo("UserEntity", "Username", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Username, 50, 0, 0);
		}
		/// <summary>Inits UserActivityEntity's FieldInfo objects</summary>
		private void InitUserActivityEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(UserActivityFieldIndex), "UserActivityEntity");
			this.AddElementFieldInfo("UserActivityEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)UserActivityFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("UserActivityEntity", "DateLastModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)UserActivityFieldIndex.DateLastModified, 0, 0, 0);
			this.AddElementFieldInfo("UserActivityEntity", "DateLastModifiedByUserId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)UserActivityFieldIndex.DateLastModifiedByUserId, 0, 0, 10);
			this.AddElementFieldInfo("UserActivityEntity", "Name", typeof(System.String), true, false, false, false,  (int)UserActivityFieldIndex.Name, 50, 0, 0);
		}
		/// <summary>Inits UserRoleEntity's FieldInfo objects</summary>
		private void InitUserRoleEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(UserRoleFieldIndex), "UserRoleEntity");
			this.AddElementFieldInfo("UserRoleEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)UserRoleFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("UserRoleEntity", "DateLastModified", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)UserRoleFieldIndex.DateLastModified, 0, 0, 0);
			this.AddElementFieldInfo("UserRoleEntity", "DateLastModifiedByUserId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)UserRoleFieldIndex.DateLastModifiedByUserId, 0, 0, 10);
			this.AddElementFieldInfo("UserRoleEntity", "Name", typeof(System.String), false, false, false, false,  (int)UserRoleFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("UserRoleEntity", "RoleTypeEnum", typeof(System.Byte), true, false, false, false,  (int)UserRoleFieldIndex.RoleTypeEnum, 0, 0, 3);
		}
		/// <summary>Inits UserRoleActivityEntity's FieldInfo objects</summary>
		private void InitUserRoleActivityEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(UserRoleActivityFieldIndex), "UserRoleActivityEntity");
			this.AddElementFieldInfo("UserRoleActivityEntity", "RoleTypeEnum", typeof(System.Byte), true, true, false, false,  (int)UserRoleActivityFieldIndex.RoleTypeEnum, 0, 0, 3);
			this.AddElementFieldInfo("UserRoleActivityEntity", "UserActivityName", typeof(System.String), true, true, false, false,  (int)UserRoleActivityFieldIndex.UserActivityName, 50, 0, 0);
		}
		
	}
}




