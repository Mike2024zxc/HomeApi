using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApi.Contracts.Models.Rooms
{
    /// <summary>
    /// Обновление данных помещения.
    /// </summary>
    public class EditRoomRequest
    {
        public string NewName { get; set; }
        public int NewVoltage { get; set; }
        public int NewArea { get; set; }
        
    }
}
