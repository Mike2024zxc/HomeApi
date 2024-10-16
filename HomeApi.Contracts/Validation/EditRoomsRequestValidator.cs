using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HomeApi.Contracts.Models.Devices;
using HomeApi.Contracts.Models.Rooms;

namespace HomeApi.Contracts.Validation
{
    public class EditRoomsRequestValidator : AbstractValidator<EditRoomRequest>
    {
        public EditRoomsRequestValidator()
        {
            RuleFor(x => x.NewArea).NotEmpty();
            RuleFor(x => x.NewVoltage).NotEmpty();
            RuleFor(x => x.NewName).NotEmpty()
                .WithMessage($"Please choose one of the following locations: { string.Join(", ", Values.ValidRooms)}");
        }
    }
}
