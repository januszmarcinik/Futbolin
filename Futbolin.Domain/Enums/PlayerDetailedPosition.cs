using System.ComponentModel;

namespace Futbolin.Domain.Enums
{
    public enum PlayerDetailedPosition
    {
        [Description("Nieznana")]
        Unknown = 0,

        [Description("Bramkarz")]
        GK = 1,

        [Description("Lewy obrońca")]
        LB = 2,

        [Description("Środkowy obrońca")]
        CB = 3,

        [Description("Prawy obrońca")]
        RB = 4,

        [Description("Lewy obrońca wahadłowy")]
        LWB = 5,

        [Description("Prawy obrońca wahadłowy")]
        RWB = 6,

        [Description("Defensywny pomocnik")]
        CDM = 7,

        [Description("Lewy pomocnik")]
        LM = 8,

        [Description("Środkowy pomocnik")]
        CM = 9,

        [Description("Prawy pomocnik")]
        RM = 10,

        [Description("Ofensywny pomocnik")]
        CAM = 11,

        [Description("Lewy skrzydłowy")]
        LW = 12,

        [Description("Prawy skrzydłowy")]
        RW = 13,

        [Description("Lewy napastnik")]
        LF = 14,

        [Description("Środkowy napastnik")]
        CF = 15,

        [Description("Prawy napastnik")]
        RF = 16,

        [Description("Snajper")]
        ST = 17
    }
}
