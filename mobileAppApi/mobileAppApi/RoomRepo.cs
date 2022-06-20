using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobileAppApi
{
    public class RoomRepo
    {
        private List<TrainingRoom> _trainingRooms;
        public RoomRepo()
        {
            _trainingRooms = new List<TrainingRoom>
            {
                new TrainingRoom
                {
                    Id = 1,
                    Name = "Room1",
                    Location = "loc 1",
                    NumberComputers = 1
                },
                new TrainingRoom
                {
                    Id = 2,
                    Name = "Room2",
                    Location = "loc 2",
                    NumberComputers = 2
                },
                new TrainingRoom
                {
                    Id = 3,
                    Name = "Room3",
                    Location = "loc 3",
                    NumberComputers = 3
                },
                new TrainingRoom
                {
                    Id = 4,
                    Name = "Room4",
                    Location = "loc 4",
                    NumberComputers = 4
                },
                new TrainingRoom
                {
                    Id = 5,
                    Name = "Room5",
                    Location = "loc 5",
                    NumberComputers = 5
                }
            };
        }

        public List<TrainingRoom> GetRooms()
        {
            return _trainingRooms;
        }

        public TrainingRoom GetRoom(int roomId)
        {
            return GetRooms()[roomId];
        }
    }
}
