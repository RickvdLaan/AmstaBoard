using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using AmstaJanBonga.Business.Security;
using System;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class LivingRoomManager
    {
        public static void InsertLivingRoom(string name, ColourTypeEnum colourType)
        {
            Authentication.AuthenticateActivity("CreateLivingRoom");

            var livingRoom = new LivingRoomEntity()
            {
                Name = name,
                ColourTypeEnum = (byte)colourType,
                DateCreated = DateTime.Now
            };

            livingRoom.Save();
        }

        public static void UpdateLivingRoom(int livingRoomId, string name, ColourTypeEnum colourType)
        {
            Authentication.AuthenticateActivity("UpdateLivingRoom");

            var livingRoom = new LivingRoomEntity(livingRoomId);
            livingRoom.Name = name;
            livingRoom.ColourTypeEnum = (byte)colourType;

            livingRoom.Save();
        }

        public static void MarkLivingRoomAsDeleted(LivingRoomEntity livingRoom)
        {
            Authentication.AuthenticateActivity("DeleteLivingRoom");

            livingRoom.IsMarkedAsDeleted = true;
            livingRoom.DateDeleted = DateTime.Now;

            livingRoom.Save();
        }

        public static void MarkLivingRoomAsDeleted(int livingRoomId)
        {
            Authentication.AuthenticateActivity("DeleteLivingRoom");

            var livingRoom = new LivingRoomEntity(livingRoomId)
            {
                IsMarkedAsDeleted = true,
                DateDeleted = DateTime.Now
            };

            livingRoom.Save();
        }
    }
}
