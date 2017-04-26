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
			this.InitClass(9);
			InitEmployeeEntityMappings();
			InitEmployeeLivingroomEntityMappings();
			InitLivingroomEntityMappings();
			InitLivingroomChoreEventEntityMappings();
			InitLivingroomGeneralEntityMappings();
			InitLivingroomGeneralEventEntityMappings();
			InitPatientEntityMappings();
			InitUserEntityMappings();
			InitUserRoleEntityMappings();
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
			this.AddElementFieldMapping("EmployeeEntity", "IsActive", "IsActive", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 7);
			this.AddElementFieldMapping("EmployeeEntity", "IsMarkedAsDeleted", "IsMarkedAsDeleted", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 8);
			this.AddElementFieldMapping("EmployeeEntity", "UserId", "UserId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 9);
		}

		/// <summary>Inits EmployeeLivingroomEntity's mappings</summary>
		private void InitEmployeeLivingroomEntityMappings()
		{
			this.AddElementMapping("EmployeeLivingroomEntity", @"Vanderlaan_jouwsoftware_janbonga_development", @"Vanderlaan", "EmployeeLivingroom", 2, 0);
			this.AddElementFieldMapping("EmployeeLivingroomEntity", "EmployeeId", "EmployeeId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("EmployeeLivingroomEntity", "LivingroomId", "LivingroomId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
		}

		/// <summary>Inits LivingroomEntity's mappings</summary>
		private void InitLivingroomEntityMappings()
		{
			this.AddElementMapping("LivingroomEntity", @"Vanderlaan_jouwsoftware_janbonga_development", @"Vanderlaan", "Livingroom", 9, 0);
			this.AddElementFieldMapping("LivingroomEntity", "ColourTypeEnum", "ColourTypeEnum", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 0);
			this.AddElementFieldMapping("LivingroomEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("LivingroomEntity", "DateDeleted", "DateDeleted", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("LivingroomEntity", "DateLastModified", "DateLastModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("LivingroomEntity", "DateLastModifiedByUserId", "DateLastModifiedByUserId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("LivingroomEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("LivingroomEntity", "IsActive", "IsActive", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 6);
			this.AddElementFieldMapping("LivingroomEntity", "IsMarkedAsDeleted", "IsMarkedAsDeleted", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 7);
			this.AddElementFieldMapping("LivingroomEntity", "Name", "Name", false, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 8);
		}

		/// <summary>Inits LivingroomChoreEventEntity's mappings</summary>
		private void InitLivingroomChoreEventEntityMappings()
		{
			this.AddElementMapping("LivingroomChoreEventEntity", @"Vanderlaan_jouwsoftware_janbonga_development", @"Vanderlaan", "LivingroomChoreEvent", 7, 0);
			this.AddElementFieldMapping("LivingroomChoreEventEntity", "Date", "Date", false, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("LivingroomChoreEventEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("LivingroomChoreEventEntity", "DateLastModified", "DateLastModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("LivingroomChoreEventEntity", "DateLastModifiedByUserId", "DateLastModifiedByUserId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("LivingroomChoreEventEntity", "LivingroomId", "LivingroomId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("LivingroomChoreEventEntity", "PatientId", "PatientId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("LivingroomChoreEventEntity", "TimeOfDayTypeEnum", "TimeOfDayTypeEnum", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 6);
		}

		/// <summary>Inits LivingroomGeneralEntity's mappings</summary>
		private void InitLivingroomGeneralEntityMappings()
		{
			this.AddElementMapping("LivingroomGeneralEntity", @"Vanderlaan_jouwsoftware_janbonga_development", @"Vanderlaan", "LivingroomGeneral", 5, 0);
			this.AddElementFieldMapping("LivingroomGeneralEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("LivingroomGeneralEntity", "DateLastModified", "DateLastModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("LivingroomGeneralEntity", "DateLastModifiedByUserId", "DateLastModifiedByUserId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("LivingroomGeneralEntity", "Description", "Description", true, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("LivingroomGeneralEntity", "LivingroomId", "LivingroomId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
		}

		/// <summary>Inits LivingroomGeneralEventEntity's mappings</summary>
		private void InitLivingroomGeneralEventEntityMappings()
		{
			this.AddElementMapping("LivingroomGeneralEventEntity", @"Vanderlaan_jouwsoftware_janbonga_development", @"Vanderlaan", "LivingroomGeneralEvent", 6, 0);
			this.AddElementFieldMapping("LivingroomGeneralEventEntity", "Date", "Date", false, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("LivingroomGeneralEventEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("LivingroomGeneralEventEntity", "DateLastModified", "DateLastModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("LivingroomGeneralEventEntity", "DateLastModifiedByUserId", "DateLastModifiedByUserId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("LivingroomGeneralEventEntity", "Description", "Description", false, "VarChar", 250, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("LivingroomGeneralEventEntity", "LivingroomId", "LivingroomId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
		}

		/// <summary>Inits PatientEntity's mappings</summary>
		private void InitPatientEntityMappings()
		{
			this.AddElementMapping("PatientEntity", @"Vanderlaan_jouwsoftware_janbonga_development", @"Vanderlaan", "Patient", 10, 0);
			this.AddElementFieldMapping("PatientEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("PatientEntity", "DateDeleted", "DateDeleted", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("PatientEntity", "DateLastModified", "DateLastModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("PatientEntity", "DateLastModifiedByUserId", "DateLastModifiedByUserId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("PatientEntity", "FirstName", "FirstName", false, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("PatientEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("PatientEntity", "ImagePath", "ImagePath", false, "VarChar", 250, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("PatientEntity", "IsActive", "IsActive", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 7);
			this.AddElementFieldMapping("PatientEntity", "IsMarkedAsDeleted", "IsMarkedAsDeleted", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 8);
			this.AddElementFieldMapping("PatientEntity", "LivingroomId", "LivingroomId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 9);
		}

		/// <summary>Inits UserEntity's mappings</summary>
		private void InitUserEntityMappings()
		{
			this.AddElementMapping("UserEntity", @"Vanderlaan_jouwsoftware_janbonga_development", @"Vanderlaan", "User", 11, 0);
			this.AddElementFieldMapping("UserEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("UserEntity", "DateDeleted", "DateDeleted", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("UserEntity", "DateLastLogin", "DateLastLogin", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("UserEntity", "DateLastModified", "DateLastModified", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("UserEntity", "DateLastModifiedByUserId", "DateLastModifiedByUserId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("UserEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("UserEntity", "IsActive", "IsActive", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 6);
			this.AddElementFieldMapping("UserEntity", "IsMarkedAsDeleted", "IsMarkedAsDeleted", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 7);
			this.AddElementFieldMapping("UserEntity", "Password", "Password", false, "VarChar", 250, 0, 0, false, "", null, typeof(System.String), 8);
			this.AddElementFieldMapping("UserEntity", "Salt", "Salt", false, "VarChar", 250, 0, 0, false, "", null, typeof(System.String), 9);
			this.AddElementFieldMapping("UserEntity", "Username", "Username", false, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 10);
		}

		/// <summary>Inits UserRoleEntity's mappings</summary>
		private void InitUserRoleEntityMappings()
		{
			this.AddElementMapping("UserRoleEntity", @"Vanderlaan_jouwsoftware_janbonga_development", @"Vanderlaan", "UserRole", 2, 0);
			this.AddElementFieldMapping("UserRoleEntity", "RoleTypeEnum", "RoleTypeEnum", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 0);
			this.AddElementFieldMapping("UserRoleEntity", "UserId", "UserId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
		}

	}
}
