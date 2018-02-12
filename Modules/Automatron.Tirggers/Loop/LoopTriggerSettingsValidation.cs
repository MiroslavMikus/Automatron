using FluentValidation;
using System;

namespace Automatron.Tirggers.Loop
{
    public class LoopTriggerSettingsValidation : AbstractValidator<LoopTriggerSettings>
    {
        public static Lazy<LoopTriggerSettingsValidation> Singleton = 
            new Lazy<LoopTriggerSettingsValidation>(() => new LoopTriggerSettingsValidation());

        private LoopTriggerSettingsValidation()
        {
            RuleFor(a => a.LoopCount)
                .Must(a => a > 0).WithMessage("Loop count have to be more than 0")
                .Must(a => a < 20).WithMessage("Loop count have to be less than 20");

            RuleFor(a => a.LoopInterval)
                .Must(a => a < 20).WithMessage("Loop interval have to be less than 20");
        }
    }
}
