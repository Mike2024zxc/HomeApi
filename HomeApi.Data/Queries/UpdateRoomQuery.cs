using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApi.Data.Queries
{
    public class UpdateRoomQuery
    {
        public UpdateRoomQuery(string newName, int newVoltage, int newArea)
        {
            NewName = newName;
            NewVoltage = newVoltage;
            NewArea = newArea;

        }
        public string NewName { get; }
        public int NewVoltage { get; }
        public int NewArea { get; }
    }
}
