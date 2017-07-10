using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Security;
using AmstaJanBonga.Business.StoredProcedureCallerClasses;
using Rlaan.Toolkit.Extensions;
using System;
using System.Data;

namespace AmstaJanBonga.Business.Database.Readers
{
    public abstract class LivingRoomReader
    {
        #region Entities

        /// <summary>
        /// Gets the living room with the corresponding living room id or null. 
        /// </summary>
        /// <param name="livingRoomId">The living rooms unique id.</param>
        /// <param name="name">The name of the living room.</param>
        /// <param name="colourType">The colour of the living room, default is grey.</param>
        /// <returns></returns>
        public static LivingRoomEntity GetLivingRoomById(int livingRoomId)
        {
            Authentication.AuthenticateActivity("ReadLivingRoom");

            return new LivingRoomEntity(livingRoomId);
        }

        /// <summary>
        /// Gets the living room with the corresponding living room id or null.
        /// </summary>
        /// <param name="LivingRoomId">The living rooms unique id.</param>
        /// <param name="name">The name of the living room.</param>
        /// <param name="colourType">The colour of the living room, default is grey.</param>
        /// <param name="throwExceptionWhenNotFound"></param>
        /// <returns></returns>
        public static LivingRoomEntity GetLivingRoomById(int LivingRoomId, bool throwExceptionWhenNotFound)
        {
            // Uses the Authentication.AuthenticateActivity from GetLivingRoomById.

            var livingRoom = GetLivingRoomById(LivingRoomId);

            if (livingRoom.IsNew && throwExceptionWhenNotFound)
                throw new Exception("Living room not found by id {0}.".FormatString(LivingRoomId));

            return livingRoom;
        }

        #endregion

        #region Collections

        /// <summary>
        /// Returns a collection of all the living rooms.
        /// </summary>
        /// <returns></returns>
        public static LivingRoomCollection GetAllLivingRooms()
        {
            Authentication.AuthenticateActivity("ReadLivingRoom");

            var livingRooms = new LivingRoomCollection();
            livingRooms.GetMulti(null, 0);

            return livingRooms;
        }

        public static DataTable GetAllLivingRoomStatisticsByDateWithStoredProcedure(DateTime date)
        {
            Authentication.AuthenticateActivity("ReadLivingRoom");

            // The statement (query) for the the stored procedure. 
            #region Query
            /*
                SELECT 
	                lr.[Name], 
	                COALESCE([chore].ChoreCount, 0) AS [ChoreCount], 
	                COALESCE([shift].ShiftCount, 0) AS [ShiftCount],
	                COALESCE([general].GeneralCount, 0) AS [GeneralCount]
                FROM LivingRoom AS lr
	                LEFT JOIN (
		                SELECT LivingRoomId, 
			                COUNT([chore].[LivingRoomId]) AS [ChoreCount] 
		                FROM LivingRoomChoreEvent AS [chore] 
		                WHERE [chore].[Date] = '2017-07-10'
		                GROUP BY LivingRoomId
		                ) [chore] ON [chore].LivingRoomId = lr.Id
	                LEFT JOIN (
		                SELECT LivingRoomId, 
			                COUNT([shift].[LivingRoomId]) AS [ShiftCount] 
		                FROM LivingRoomShiftEvent AS [shift] 
		                WHERE [shift].[Date] = '2017-07-10'
		                GROUP BY LivingRoomId
		                ) [shift] ON [shift].LivingRoomId = lr.Id
			                LEFT JOIN (
		                SELECT LivingRoomId, 
			                COUNT([general].[LivingRoomId]) AS [GeneralCount] 
		                FROM LivingRoomGeneralEvent AS [general] 
		                WHERE [general].[Date] = '2017-07-10'
		                GROUP BY LivingRoomId
		                ) [general] ON [general].LivingRoomId = lr.Id
                GROUP BY 
	                lr.[Name], 	
	                [chore].ChoreCount, 
	                [shift].ShiftCount,
	                [general].GeneralCount
                ORDER BY 
	                lr.[Name] DESC;
            */
            #endregion

            return RetrievalProcedures.GetAllLivingRoomStatisticsByDate(date.Date);
        }

        #endregion
    }
}
