using System.ComponentModel;

namespace Futbolin.Domain.Enums
{
    public enum PlayerGeneralPosition
    {
        [Description("Nieznana")]
        Unknown = 0,

        [Description("Bramkarz")]
        Goalkeeper = 1,

        [Description("Obrońca")]
        Defender = 2,

        [Description("Pomocnik")]
        Midfielder = 3,

        [Description("Skrzydłowy")]
        Winger = 4,

        [Description("Napastnik")]
        Striker = 5
    }
}
