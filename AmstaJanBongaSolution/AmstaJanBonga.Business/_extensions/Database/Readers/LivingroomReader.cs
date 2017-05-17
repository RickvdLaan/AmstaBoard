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
        /// Gets the livingroom with the corresponding livingroom id or null. 
        /// </summary>
        /// <param name="livingRoomId">The living rooms unique id.</param>
        /// <param name="name">The name of the living room.</param>
        /// <param name="colourType">The colour of the living room, default is grey.</param>
        /// <returns></returns>
        public static LivingRoomEntity GetLivingroomById(int livingRoomId)
        {
            return new LivingRoomEntity(livingRoomId);
        }

        /// <summary>
        /// Gets the livingroom with the corresponding livingroom id or null.
        /// </summary>
        /// <param name="livingroomId">The living rooms unique id.</param>
        /// <param name="name">The name of the living room.</param>
        /// <param name="colourType">The colour of the living room, default is grey.</param>
        /// <param name="throwExceptionWhenNotFound"></param>
        /// <returns></returns>
        public static LivingRoomEntity GetLivingroomById(int livingroomId, bool throwExceptionWhenNotFound)
        {
            var livingroom = GetLivingroomById(livingroomId);

            if (livingroom.IsNew && throwExceptionWhenNotFound)
                throw new Exception("Livingroom not found by id {0}.".FormatString(livingroomId));

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
