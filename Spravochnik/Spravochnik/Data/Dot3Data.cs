﻿using System.Collections.Generic;
using Spravochnik.Models;

namespace Spravochnik.Data
{
    public static class Dot3Data
    {
        public static IList<Fluids> D3 { get; private set; }

        static Dot3Data()
        {
            D3 = new List<Fluids>
            {
                new Fluids
                {
                    Name = "DOT 3 Felix",
                    Brand = "Felix",
                    Details = "Производитель: Felix\n" +
                    "Объем упаковки: 0,5 л\n" +
                    "Спецификации FMVSS 116: DOT 3\n" +
                    "Цена от 78 ₽\n\n" +
                    "Описание:\n" +
                    "Тормозная жидкость на основе простых эфиров гликолей, эфиров полиэтиленгликолей с добавлением пластифицирующей, " +
                    "антиокислительной и антикоррозионной присадок. FELIX ДОТ 3 тормозная жидкость для использования в тормозных системах, " +
                    "а также гидроприводах сцепления современных импортных и отечественных автомобилей. Cодержит фракции эфиров " +
                    "полигликолей, обеспечивающих хорошие смазывающие свойства жидкости, а значит, свободное движение поршней в тормозных " +
                    "цилиндрах. Эффективная защита тормозной системы. Высокая температура кипения и оптимальная вязкость при низких " +
                    "температурах Гарантия безотказности тормозной системы в широком диапазоне температур Соответствует международным " +
                    "стандартам: FMVSS 116, ISO 4925, SAE J1703. Совместима с тормозными жидкостями классов DOT 3 и DОТ 4.",
                    ImageUrl = "https://www.emex.ru/Catalog/Catalog/GetImage?id=5061256&h=250"
                },

                new Fluids
                {
                    Name = "DOT 3, Hyundai",
                    Brand = "Hyundai / KIA",
                    Details = "Производитель: Hyundai / KIA\n" +
                    "Объем упаковки: 1 л\n" +
                    "Спецификации FMVSS 116: DOT 3\n" +
                    "Цена от 610 ₽\n\n" +
                    "Описание:\n" +
                    "Жидкость тормозная.",
                    ImageUrl = "https://www.emex.ru/Catalog/Catalog/GetImage?id=5144114&h=250"
                },

                new Fluids
                {
                    Name = "DOT 3, Brake Fluid, 0.354л",
                    Brand = "Toyota",
                    Details = "Производитель: Toyota\n" +
                    "Объем упаковки 0,4 л\n" +
                    "Спецификации FMVSS 116: DOT 3\n" +
                    "Цена от 517 ₽\n\n" +
                    "Описание:\n" +
                    "Тормозная жидкость DOT 3.",
                    ImageUrl = "https://www.emex.ru/Catalog/Catalog/GetImage?id=5135424&h=250"
                },

                new Fluids
                {
                    Name = "No.2500 NR-3, 500мл",
                    Brand = "Nissan",
                    Details = "Производитель: Nissan\n" +
                    "Объем упаковки: 0,5 л\n" +
                    "Спецификации FMVSS 116: DOT 3\n" +
                    "Цена от 1 111 ₽\n\n" +
                    "Описание:\n" +
                    "Тормозная жидкость с температурой кипения не менее 260 градусов, предназначенная для использования в гидроприводах " +
                    "тормозов всех японских автомобилей. Идеально подходит для автомобилей NISSAN. Соответствует американскому стандарту " +
                    "автомобильной безопасности DOT-3, обладает улучшенными техническими характеристиками. Сохраняет тормозную систему " +
                    "автомобиля чистой на протяжении всего срока эксплуатации. Совместима с другими тормозными жидкостями классов DOT-3 " +
                    "и DOT-4 на гликолевой основе.",
                    ImageUrl = "https://www.emex.ru/Catalog/Catalog/GetImage?id=5142945&h=250"
                },

                new Fluids
                {
                    Name = "DOT 3 Роса",
                    Brand = "Роса",
                    Details = "Производитель: Роса\n" +
                    "Объем упаковки: 0,5 л\n" +
                    "Спецификации FMVSS 116: DOT 3\n" +
                    "Цена от 97 ₽\n\n" +
                    "Описание:\n" +
                    "Тормозная жидкость на основе простых эфиров гликолей, эфиров полиэтиленгликолей с добавлением пластифицирующей, " +
                    "антиокислительной и антикоррозионной присадок. Тормозная жидкость РОСА 4 – одна из лучших традиционных тормозных " +
                    "жидкостей, рецептура которой была значительно улучшена и адаптирована к современным требованиям российских и зарубежных " +
                    "автопроизводителей.\n - Улучшенные технические характеристики;\n - Современная рецептура с использованием высокотехнологичных " +
                    "сырьевых компонентов и присадок специального назначени;я\n - Полная совместимость с металлическими и резиновыми материалами " +
                    "тормозной системы;\n - Оптимальная термостабильность и вязкость.\nПревосходит требования международного стандарта FMVSS 116 " +
                    "для DOT 3.",
                    ImageUrl = "https://www.emex.ru/Catalog/Catalog/GetImage?id=5061279&h=250"
                },

                new Fluids
                {
                    Name = "DOT 3 Нева-М",
                    Brand = "Нева-М",
                    Details = "Производитель: Нева-М\n" +
                    "Объем упаковки: 1 л\n" +
                    "Спецификации FMVSS 116: DOT 3\n" +
                    "Цена от 172 ₽\n\n" +
                    "Описание:\n" +
                    "Тормозная жидкость на основе простых эфиров гликолей, эфиров полиэтиленгликолей с добавлением пластифицирующей, " +
                    "антиокислительной и антикоррозионной присадок. Тормозная жидкость Нева-М предназначена для использования в качестве " +
                    "рабочей жидкости в сцеплениях и тормозных системах «подержанных» отечественных автомобилей и сельхозтехнике, а также " +
                    "автомобилей, эксплуатируемых в режиме невысоких динамических и температурных нагрузок. Содержит фракции эфиров " +
                    "полигликолей, обеспечивающих хорошие смазывающие свойства жидкости, а значит - свободное движение поршней в тормозных " +
                    "цилиндрах. Превосходит требования международного стандарта FMVSS 116 для DOT 3.",
                    ImageUrl = "https://www.emex.ru/Catalog/Catalog/GetImage?id=5061271&h=250"
                },

                new Fluids
                {
                    Name = "DOT 3 Томъ, 1л",
                    Brand = "Томъ",
                    Details = "Производитель: Томъ\n" +
                    "Объем упаковки: 1 л\n" +
                    "Спецификации FMVSS 116: DOT 3\n" +
                    "Цена от 174 ₽\n\n" +
                    "Описание:\n" +
                    "Тормозная жидкость на основе простых эфиров гликолей, эфиров полиэтиленгликолей с добавлением пластифицирующей, " +
                    "антиокислительной и антикоррозионной присадок. Тормозная жидкость ТОМЪ 4 предназначена для использования в тормозных " +
                    "системах отечественных и импортных автомобилей, эксплуатируемых в условиях значительных колебаний температуры внешней " +
                    "среды. Рекомендована для использования в регионах с низкой температурой окружающей среды: Сибири, Урала, Дальнего " +
                    "Востока.\n - Улучшенные технические характеристики: температура кипения — выше плюс 230°С;\n - Полная совместимость с " +
                    "металлическими и резиновыми материалами тормозной системы;\n - Оптимальная термостабильность и вязкость;\n - Улучшенными " +
                    "показателями прокачиваемости тормозной жидкости в тормозной системе при низких температурах.\nПревосходит требования " +
                    "международного стандарта FMVSS 116 для DOT 3.",
                    ImageUrl = "https://www.emex.ru/Catalog/Catalog/GetImage?id=5061282&h=250"
                },

                new Fluids
                {
                    Name = "MAZDA Brake Fluid DPT/BF-3",
                    Brand = "Mazda",
                    Details = "Производитель: Mazda\n" +
                    "Объем упаковки: 0,5 л\n" +
                    "Спецификации FMVSS 116: DOT 3\n" +
                    "Цена от 3 684 ₽\n\n" +
                    "Описание:\n" +
                    "Тормозная жидкость MAZDA Brake Fluid DPT/BF-3.",
                    ImageUrl = "https://www.emex.ru/Catalog/Catalog/GetImage?id=5134802&h=250"
                },

                new Fluids
                {
                    Name = "Kixx Brake DOT 3 /0,5л",
                    Brand = "kixx",
                    Details = "Производитель: Kixx\n" +
                    "Объем упаковки: 0,5 л\n" +
                    "Спецификации FMVSS 116: DOT 3\n" +
                    "Цена от 274 ₽\n\n" +
                    "Описание:\n" +
                    "Современная автомобильная тормозная жидкость на полиэфирной основе (без масла), разработанная для использования " +
                    "в большинстве обычных гидравлических тормозов и систем сцепления в тяжелых рабочих условиях, при наличии рекомендаций " +
                    "использования тормозной жидкости класса DOT 3. FMVSS №116 DOT3, SAE J1703, ISO 4925.",
                    ImageUrl = "https://www.emex.ru/Catalog/Catalog/GetImage?id=10074147&h=250"
                },

                new Fluids
                {
                    Name = "WOLF DOT 3 1л",
                    Brand = "Wolf",
                    Details = "Производитель: Wolf\n" +
                    "Объем упаковки: 1 л\n" +
                    "Спецификации FMVSS 116: DOT 3\n" +
                    "Цена от 664 ₽\n\n" +
                    "Описание:\n" +
                    "WOLF BRAKE FLUID DOT 3 1L",
                    ImageUrl = "https://www.emex.ru/Catalog/Catalog/GetImage?id=10467473&h=250"
                }

            };
        }
    }
}
