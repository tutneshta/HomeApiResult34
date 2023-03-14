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
    /// <summary>
    /// Класс- валидатор запросов обновления комнат
    /// </summary>
    public class EditRoomRequestValidator : AbstractValidator<EditRoomRequest>
    {
        public EditRoomRequestValidator()
        {
            RuleFor(x => x.NewName).NotEmpty().Must(BeSupported).WithMessage("недопустимое название");
        }

        private bool BeSupported(string location)
        {
            return Values.ValidRooms.Any(e => e == location);
        }
    }
}