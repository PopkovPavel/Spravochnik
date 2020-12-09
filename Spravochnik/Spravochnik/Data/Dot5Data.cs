using System.Collections.Generic;
using Spravochnik.Models;

namespace Spravochnik.Data
{
    public static class Dot5Data
    {
        public static IList<Fluids> D5 { get; private set; }

        static Dot5Data()
        {
            D5 = new List<Fluids>
            {
                new Fluids
                {
                    Name = "TRW DOT 5 0.25L",
                    Brand = "Brembo",
                    Details = "Производитель: Brembo\n" +
                    "Объем упаковки: 0,25 л\n" +
                    "Спецификации FMVSS 116: DOT 5" +
                    "\nЦена от 1 580 ₽\n\n" +
                    "Описание:\n" +
                    "Тормозная жидкость СИЛИКОНОВАЯ TRW DOT 5 0.25L.",
                    ImageUrl = "https://avatars.mds.yandex.net/get-marketpic/1723579/market_mcO0av8UHJbvpEcnITMk9w/200x200"
                },

                new Fluids
                {
                    Name = "Toyota: 08823-80004 DOT 5",
                    Brand = "Toyota",
                    Details = "Производитель: Toyota\n" +
                    "Объем упаковки: 1 л\n" +
                    "Спецификации FMVSS 116: DOT 5" +
                    "\nЦена от 870 ₽\n\n" +
                    "Описание:\n" +
                    "Жидкость тормозная toyota Toyota 08823-80004 Toyota: 08823-80004 DOT5.11.0л.",
                    ImageUrl = "https://avatars.mds.yandex.net/get-marketpic/1887356/market_XejRZYSTteE0aL5LnOgfCg/200x200"
                },

                new Fluids
                {
                    Name = "FEBI 06161 1л",
                    Brand = "Febi",
                    Details = "Производитель: Febi\n" +
                    "Объем упаковки: 1 л\n" +
                    "Спецификации FMVSS 116: DOT 5" +
                    "\nЦена от 949 ₽\n\n" +
                    "Описание:\n" +
                    "Жидкость гидроусилителя руля зеленая FEBI 06161 1л.",
                    ImageUrl = "https://cdn1.ozone.ru/s3/multimedia-s/wc250/6016860052.jpg"
                },

                new Fluids
                {
                    Name = "TOYOTA 08823-80004 DOT-5",
                    Brand = "Toyota",
                    Details = "Производитель: Toyota\n" +
                    "Объем упаковки: 1 л\n" +
                    "Спецификации FMVSS 116: DOT 5" +
                    "\nЦена от 1 403 ₽\n\n" +
                    "Описание:\n" +
                    "Жидкость тормозная TOYOTA 08823-80004 DOT-5 1л.",
                    ImageUrl = "https://cdn1.ozone.ru/s3/multimedia-m/wc250/6017257162.jpg"
                },

                new Fluids
                {
                    Name = "TRW PFB750 DOT-5 ESP 0.5л",
                    Brand = "TRW",
                    Details = "Производитель: TRW\n" +
                    "Объем упаковки: 0,5 л\n" +
                    "Спецификации FMVSS 116: DOT 5" +
                    "\nЦена от 774 ₽\n\n" +
                    "Описание:\n" +
                    "Жидкость тормозная TRW PFB750 DOT-5 ESP 0.5л.",
                    ImageUrl = "https://cdn1.ozone.ru/s3/multimedia-j/wc250/6017257159.jpg"
                },

                new Fluids
                {
                    Name = "Dot5 (250ml) TRW",
                    Brand = "TRW",
                    Details = "Производитель: TRW\n" +
                    "Объем упаковки: 4 л\n" +
                    "Спецификации FMVSS 116: DOT 5" +
                    "\nЦена от 1 618 ₽\n\n" +
                    "Описание:\n" +
                    "Жидкость тормозная dot5 (250ml) TRW.",
                    ImageUrl = "https://cdn1.ozone.ru/s3/multimedia-v/wc1200/6024036115.jpg"
                },

                new Fluids
                {
                    Name = "Bel-Ray Silicone DOT 5",
                    Brand = "Bel-Ray",
                    Details = "Производитель: Bel-Ray\n" +
                    "Объем упаковки: 0,4 л\n" +
                    "Спецификации FMVSS 116: DOT 5" +
                    "\nЦена от 1 052 ₽\n\n" +
                    "Описание:\n" +
                    "Bel-Ray Silicone DOT 5 Тормозные жидкости 355 мл.",
                    ImageUrl = "https://www.fc-moto.de/WebRoot/FCMotoDB/Shops/10207048/5C87/8DCC/A0CA/E8CB/907C/AC1E/1407/E5AE/99450_P3572.01_Silicone_Dot_5_355mL_Front_ml.jpg"
                }
            };
        }
    }
}


