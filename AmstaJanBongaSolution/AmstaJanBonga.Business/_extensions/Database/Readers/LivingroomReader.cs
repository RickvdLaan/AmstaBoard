using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using AmstaJanBonga.Business.Security;
using Rlaan.Toolkit.Extensions;
using System;

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
        /// Gets the livingroom with the corresponding livingroom id or null.
        /// </summary>
        /// <param name="LivingRoomId">The living rooms unique id.</param>
        /// <param name="name">The name of the living room.</param>
        /// <param name="colourType">The colour of the living room, default is grey.</param>
        /// <param name="throwExceptionWhenNotFound"></param>
        /// <returns></returns>
        public static LivingRoomEntity GetLivingRoomById(int LivingRoomId, bool throwExceptionWhenNotFound)
        {
            var livingroom = GetLivingRoomById(LivingRoomId);

            if (livingroom.IsNew && throwExceptionWhenNotFound)
                throw new Exception("Living room not found by id {0}.".FormatString(LivingRoomId));

            return livingroom;
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

        #endregion
    }
}
