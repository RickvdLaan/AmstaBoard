///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AmstaJanBonga.Business.HelperClasses
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal static class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass(15);
			InitAgendaEventEntityMappings();
			InitAgendaEventMetaEntityMappings();
			InitEmployeeEntityMappings();
			InitIpEntityMappings();
			InitLivingRoomEntityMappings();
			InitLivingRoomChoreEventEntityMappings();
			InitLivingRoomGeneralEntityMappings();
			InitLivingRoomGeneralEventEntityMappings();
			InitLivingRoomShiftEventEntityMappings();
			InitPatientEntityMappings();
			InitUserEntityMappings();
			InitUserActivityEntityMappings();
			InitUserRoleEntityMappings();
			InitUserRoleActivityEntityMappings();
			InitGetAllEventsByDateAndByPatientIdResultTypedViewMappings();
		}

		/// <summary>Inits AgendaEventEntity's mappings</summary>
		private void InitAgendaEventEntityMappings()
		{
			this.AddElementMapping("AgendaEventEntity", @"Vanderlaan_jouwsoftware_janbonga_development", @"Vanderlaan", "AgendaEvent", 11, 0);
			this.AddElementFieldMapping("AgendaEventEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("AgendaEventEntity", "DateDeleted", "DateDeleted", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("AgendaEventEntity", "DateLastModified", "DateLastModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("AgendaEventEntity", "DateLastModifiedByUserId", "DateLastModifiedByUserId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("AgendaEventEntity", "Description", "Description", true, "VarChar", 500, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("AgendaEventEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("AgendaEventEntity", "IsMarkedAsDeleted", "IsMarkedAsDeleted", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 6);
			this.AddElementFieldMapping("AgendaEventEntity", "Location", "Location", true, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 7);
			this.AddElementFieldMapping("AgendaEventEntity", "TimeEnd", "TimeEnd", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 8);
			this.AddElementFieldMapping("AgendaEventEntity", "TimeStart", "TimeStart", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 9);
			this.AddElementFieldMapping("AgendaEventEntity", "Title", "Title", false, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 10);
		}

		/// <summary>Inits AgendaEventMetaEntity's mappings</summary>
		private void InitAgendaEventMetaEntityMappings()
		{
			this.AddElementMapping("AgendaEventMetaEntity", @"Vanderlaan_jouwsoftware_janbonga_development", @"Vanderlaan", "AgendaEventMeta", 10, 0);
			this.AddElementFieldMapping("AgendaEventMetaEntity", "AgendaEventId", "AgendaEventId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("AgendaEventMetaEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("AgendaEventMetaEntity", "DateDeleted", "DateDeleted", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("AgendaEventMetaEntity", "DateLastModified", "DateLastModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("AgendaEventMetaEntity", "DateLastModifiedByUserId", "DateLastModifiedByUserId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("AgendaEventMetaEntity", "EventUnixTimeStamp", "EventUnixTimeStamp", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("AgendaEventMetaEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 6);
			this.AddElementFieldMapping("AgendaEventMetaEntity", "IsMarkedAsDeleted", "IsMarkedAsDeleted", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 7);
			this.AddElementFieldMapping("AgendaEventMetaEntity", "PatientId", "PatientId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 8);
			this.AddElementFieldMapping("AgendaEventMetaEntity", "RepeatInterval", "RepeatInterval", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 9);
		}

		/// <summary>Inits EmployeeEntity's mappings</summary>
		private void InitEmployeeEntityMappings()
		{
			this.AddElementMapping("EmployeeEntity", @"Vanderlaan_jouwsoftware_janbonga_development", @"Vanderlaan", "Employee", 10, 0);
			this.AddElementFieldMapping("EmployeeEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("EmployeeEntity", "DateDeleted", "DateDeleted", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("EmployeeEntity", "DateLastModified", "DateLastModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("EmployeeEntity", "DateLastModifiedByUserId", "DateLastModifiedByUserId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("EmployeeEntity", "FirstName", "FirstName", false, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("EmployeeEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("EmployeeEntity", "ImagePath", "ImagePath", true, "VarChar", 250, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("EmployeeEntity", "IsMarkedAsDeleted", "IsMarkedAsDeleted", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 7);
			this.AddElementFieldMapping("EmployeeEntity", "LivingRoomId", "LivingRoomId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 8);
			this.AddElementFieldMapping("EmployeeEntity", "UserId", "UserId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 9);
		}

		/// <summary>Inits IpEntity's mappings</summary>
		private void InitIpEntityMappings()
		{
			this.AddElementMapping("IpEntity", @"Vanderlaan_jouwsoftware_janbonga_development", @"Vanderlaan", "IP", 5, 0);
			this.AddElementFieldMapping("IpEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("IpEntity", "DateLastModified", "DateLastModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("IpEntity", "DateLastModifiedByUserId", "DateLastModifiedByUserId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("IpEntity", "Description", "Description", false, "VarChar", 250, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("IpEntity", "Ipaddress", "IPAddress", false, "VarChar", 20, 0, 0, false, "", null, typeof(System.String), 4);
		}

		/// <summary>Inits LivingRoomEntity's mappings</summary>
		private void InitLivingRoomEntityMappings()
		{
			this.AddElementMapping("LivingRoomEntity", @"Vanderlaan_jouwsoftware_janbonga_development", @"Vanderlaan", "LivingRoom", 8, 0);
			this.AddElementFieldMapping("LivingRoomEntity", "ColourTypeEnum", "ColourTypeEnum", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 0);
			this.AddElementFieldMapping("LivingRoomEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("LivingRoomEntity", "DateDeleted", "DateDeleted", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("LivingRoomEntity", "DateLastModified", "DateLastModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("LivingRoomEntity", "DateLastModifiedByUserId", "DateLastModifiedByUserId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("LivingRoomEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("LivingRoomEntity", "IsMarkedAsDeleted", "IsMarkedAsDeleted", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 6);
			this.AddElementFieldMapping("LivingRoomEntity", "Name", "Name", false, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 7);
		}

		/// <summary>Inits LivingRoomChoreEventEntity's mappings</summary>
		private void InitLivingRoomChoreEventEntityMappings()
		{
			this.AddElementMapping("LivingRoomChoreEventEntity", @"Vanderlaan_jouwsoftware_janbonga_development", @"Vanderlaan", "LivingRoomChoreEvent", 7, 0);
			this.AddElementFieldMapping("LivingRoomChoreEventEntity", "Date", "Date", false, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("LivingRoomChoreEventEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("LivingRoomChoreEventEntity", "DateLastModified", "DateLastModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("LivingRoomChoreEventEntity", "DateLastModifiedByUserId", "DateLastModifiedByUserId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("LivingRoomChoreEventEntity", "LivingRoomId", "LivingRoomId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("LivingRoomChoreEventEntity", "PatientId", "PatientId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("LivingRoomChoreEventEntity", "TimeOfDayTypeEnum", "TimeOfDayTypeEnum", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 6);
		}

		/// <summary>Inits LivingRoomGeneralEntity's mappings</summary>
		private void InitLivingRoomGeneralEntityMappings()
		{
			this.AddElementMapping("LivingRoomGeneralEntity", @"Vanderlaan_jouwsoftware_janbonga_development", @"Vanderlaan", "LivingRoomGeneral", 5, 0);
			this.AddElementFieldMapping("LivingRoomGeneralEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("LivingRoomGeneralEntity", "DateLastModified", "DateLastModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("LivingRoomGeneralEntity", "DateLastModifiedByUserId", "DateLastModifiedByUserId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("LivingRoomGeneralEntity", "Description", "Description", true, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("LivingRoomGeneralEntity", "LivingRoomId", "LivingRoomId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
		}

		/// <summary>Inits LivingRoomGeneralEventEntity's mappings</summary>
		private void InitLivingRoomGeneralEventEntityMappings()
		{
			this.AddElementMapping("LivingRoomGeneralEventEntity", @"Vanderlaan_jouwsoftware_janbonga_development", @"Vanderlaan", "LivingRoomGeneralEvent", 6, 0);
			this.AddElementFieldMapping("LivingRoomGeneralEventEntity", "Date", "Date", false, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("LivingRoomGeneralEventEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("LivingRoomGeneralEventEntity", "DateLastModified", "DateLastModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("LivingRoomGeneralEventEntity", "DateLastModifiedByUserId", "DateLastModifiedByUserId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("LivingRoomGeneralEventEntity", "Description", "Description", false, "VarChar", 250, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("LivingRoomGeneralEventEntity", "LivingRoomId", "LivingRoomId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
		}

		/// <summary>Inits LivingRoomShiftEventEntity's mappings</summary>
		private void InitLivingRoomShiftEventEntityMappings()
		{
			this.AddElementMapping("LivingRoomShiftEventEntity", @"Vanderlaan_jouwsoftware_janbonga_development", @"Vanderlaan", "LivingRoomShiftEvent", 7, 0);
			this.AddElementFieldMapping("LivingRoomShiftEventEntity", "Date", "Date", false, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("LivingRoomShiftEventEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("LivingRoomShiftEventEntity", "DateLastModified", "DateLastModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("LivingRoomShiftEventEntity", "DateLastModifiedByUserId", "DateLastModifiedByUserId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("LivingRoomShiftEventEntity", "EmployeeId", "EmployeeId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("LivingRoomShiftEventEntity", "LivingRoomId", "LivingRoomId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("LivingRoomShiftEventEntity", "ShiftTypeEnum", "ShiftTypeEnum", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 6);
		}

		/// <summary>Inits PatientEntity's mappings</summary>
		private void InitPatientEntityMappings()
		{
			this.AddElementMapping("PatientEntity", @"Vanderlaan_jouwsoftware_janbonga_development", @"Vanderlaan", "Patient", 9, 0);
			this.AddElementFieldMapping("PatientEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("PatientEntity", "DateDeleted", "DateDeleted", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("PatientEntity", "DateLastModified", "DateLastModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("PatientEntity", "DateLastModifiedByUserId", "DateLastModifiedByUserId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("PatientEntity", "FirstName", "FirstName", false, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("PatientEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("PatientEntity", "ImagePath", "ImagePath", false, "VarChar", 250, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("PatientEntity", "IsMarkedAsDeleted", "IsMarkedAsDeleted", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 7);
			this.AddElementFieldMapping("PatientEntity", "LivingRoomId", "LivingRoomId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 8);
		}

		/// <summary>Inits UserEntity's mappings</summary>
		private void InitUserEntityMappings()
		{
			this.AddElementMapping("UserEntity", @"Vanderlaan_jouwsoftware_janbonga_development", @"Vanderlaan", "User", 12, 0);
			this.AddElementFieldMapping("UserEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("UserEntity", "DateDeleted", "DateDeleted", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("UserEntity", "DateLastLogin", "DateLastLogin", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("UserEntity", "DateLastModified", "DateLastModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("UserEntity", "DateLastModifiedByUserId", "DateLastModifiedByUserId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("UserEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("UserEntity", "IsMarkedAsDeleted", "IsMarkedAsDeleted", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 6);
			this.AddElementFieldMapping("UserEntity", "Iterations", "Iterations", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 7);
			this.AddElementFieldMapping("UserEntity", "Password", "Password", false, "VarChar", 250, 0, 0, false, "", null, typeof(System.String), 8);
			this.AddElementFieldMapping("UserEntity", "RoleTypeEnum", "RoleTypeEnum", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 9);
			this.AddElementFieldMapping("UserEntity", "Salt", "Salt", false, "VarChar", 250, 0, 0, false, "", null, typeof(System.String), 10);
			this.AddElementFieldMapping("UserEntity", "Username", "Username", false, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 11);
		}

		/// <summary>Inits UserActivityEntity's mappings</summary>
		private void InitUserActivityEntityMappings()
		{
			this.AddElementMapping("UserActivityEntity", @"Vanderlaan_jouwsoftware_janbonga_development", @"Vanderlaan", "UserActivity", 2, 0);
			this.AddElementFieldMapping("UserActivityEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("UserActivityEntity", "Name", "Name", false, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
		}

		/// <summary>Inits UserRoleEntity's mappings</summary>
		private void InitUserRoleEntityMappings()
		{
			this.AddElementMapping("UserRoleEntity", @"Vanderlaan_jouwsoftware_janbonga_development", @"Vanderlaan", "UserRole", 5, 0);
			this.AddElementFieldMapping("UserRoleEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("UserRoleEntity", "DateLastModified", "DateLastModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("UserRoleEntity", "DateLastModifiedByUserId", "DateLastModifiedByUserId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("UserRoleEntity", "Name", "Name", false, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("UserRoleEntity", "RoleTypeEnum", "RoleTypeEnum", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 4);
		}

		/// <summary>Inits UserRoleActivityEntity's mappings</summary>
		private void InitUserRoleActivityEntityMappings()
		{
			this.AddElementMapping("UserRoleActivityEntity", @"Vanderlaan_jouwsoftware_janbonga_development", @"Vanderlaan", "UserRoleActivity", 2, 0);
			this.AddElementFieldMapping("UserRoleActivityEntity", "RoleTypeEnum", "RoleTypeEnum", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 0);
			this.AddElementFieldMapping("UserRoleActivityEntity", "UserActivityName", "UserActivityName", false, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
		}


		/// <summary>Inits GetAllEventsByDateAndByPatientIdResultView's mappings</summary>
		private void InitGetAllEventsByDateAndByPatientIdResultTypedViewMappings()
		{
			this.AddElementMapping("GetAllEventsByDateAndByPatientIdResultTypedView", @"Vanderlaan_jouwsoftware_janbonga_development", @"Vanderlaan", "Resultset1", 11);
			this.AddElementFieldMapping("GetAllEventsByDateAndByPatientIdResultTypedView", "Id", "Id", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("GetAllEventsByDateAndByPatientIdResultTypedView", "Title", "Title", false, "VarChar", 50, 0, 0, false, string.Empty, null, typeof(System.String), 1);
			this.AddElementFieldMapping("GetAllEventsByDateAndByPatientIdResultTypedView", "Location", "Location", false, "VarChar", 50, 0, 0, false, string.Empty, null, typeof(System.String), 2);
			this.AddElementFieldMapping("GetAllEventsByDateAndByPatientIdResultTypedView", "TimeStart", "TimeStart", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("GetAllEventsByDateAndByPatientIdResultTypedView", "TimeEnd", "TimeEnd", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("GetAllEventsByDateAndByPatientIdResultTypedView", "Description", "Description", false, "VarChar", 500, 0, 0, false, string.Empty, null, typeof(System.String), 5);
			this.AddElementFieldMapping("GetAllEventsByDateAndByPatientIdResultTypedView", "IsMarkedAsDeleted", "IsMarkedAsDeleted", false, "Bit", 0, 0, 0, false, string.Empty, null, typeof(System.Boolean), 6);
			this.AddElementFieldMapping("GetAllEventsByDateAndByPatientIdResultTypedView", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, string.Empty, null, typeof(System.DateTime), 7);
			this.AddElementFieldMapping("GetAllEventsByDateAndByPatientIdResultTypedView", "DateLastModified", "DateLastModified", false, "DateTime", 0, 0, 0, false, string.Empty, null, typeof(System.DateTime), 8);
			this.AddElementFieldMapping("GetAllEventsByDateAndByPatientIdResultTypedView", "DateLastModifiedByUserId", "DateLastModifiedByUserId", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 9);
			this.AddElementFieldMapping("GetAllEventsByDateAndByPatientIdResultTypedView", "DateDeleted", "DateDeleted", false, "DateTime", 0, 0, 0, false, string.Empty, null, typeof(System.DateTime), 10);
		}

	}
}
