﻿using System.Collections.Generic;
using Spravochnik.Models;

namespace Spravochnik.Data
{
    public static class Dot51Data
    {
        public static IList<Fluids> D51 { get; private set; }

        static Dot51Data()
        {
            D51 = new List<Fluids>
            {
                new Fluids
                {
                    Name = "DOT 5.1, Brake Fluid, 1л",
                    Brand = "Toyota",
                    Details = "Производитель: Toyota\n" +
                    "Объем упаковки: 1 л\n" +
                    "Спецификации FMVSS 116: DOT 5.1" +
                    "\nЦена от 948 ₽\n\n" +
                    "Описание:\n" +
                    "Тормозная жидкость DOT 5.1.",
                    ImageUrl = "https://www.emex.ru/Catalog/Catalog/GetImage?id=5135423&h=250"
                },

                new Fluids
                {
                    Name = "DOT 5.1 Motul",
                    Brand = "Motul",
                    Details = "Производитель: Motul\n" +
                    "Объем упаковки: 0,5 л\n" +
                    "Спецификации FMVSS 116: DOT 5.1" +
                    "\nЦена от 729 ₽\n\n" +
                    "Описание:\n" +
                    "Жидкость длительного использования для гидравлических тормозных приводов и сцепления DOT 5.1 NON SILICONE BASE. " +
                    "100% синтетика. Цвет - Желтый. Для всех систем гидравлических тормозных приводов и сцеплений, в которых рекомендовано " +
                    "применение DOT 3, DOT 4, DOT 5.1. Адаптирована к применению в тормозных системах с автоблокировочной системой (ABS). " +
                    "Специально рекомендован для сильнонагруженных многопоршневых тормозных систем. Обладает повышенной текучестью, специально " +
                    "создана для применения в странах с холодным климатом. Нормы: FMVSS 116 DOT 5.1 NON SILICONE BASE DOT 4 DOT 3 SAE J " +
                    "1703/ISO 4925. Можно смешивать с DOT 3, DOT 4 и DOT 5 на без силиконовой основе. Можно смешивать с MOTUL HYDRAULIC DOT 5 " +
                    "(на основе полигликолей без силикона). Не смешивать с жидкостями на минеральной основе (LHM) и силиконовой (DOT 5 " +
                    "silicone base). Продукт хранить в плотно закрытой таре, без доступа влаги. Агрессивна по отношению к лакам, краскам, " +
                    "и коже. В случае контакта с кожей смыть водой. Замена производится один раз в 12 или 24 месяца в соответствии с " +
                    "рекомендациями конструкторов. 100% синтетическая жидкость на основе полигликолей.",
                    ImageUrl = "https://www.emex.ru/Catalog/Catalog/GetImage?id=5149446&h=250"
                },

                new Fluids
                {
                    Name = "DOT 5.1 Ravenol",
                    Brand = "Ravenol",
                    Details = "Производитель: Ravenol\n" +
                    "Объем упаковки: 1 л\n" +
                    "Спецификации FMVSS 116: DOT 5.1" +
                    "\nЦена от 733 ₽\n\n" +
                    "Описание:\n" +
                    "Тормозная жидкость, предназначенная для использования во всех тормозных системах автомобилей, оснащенных ABS. " +
                    "Является химически стабильным продуктом без содержания нефти, со специальным комплексом присадок, обеспечивающих " +
                    "высокую смазочную способность. Соответствует и превосходит спецификации SAE J 1703, ISO 4925 FMVSS 116 DOT 5.1. " +
                    "Применение: для применения во всех тормозных системах автомобилей, требующих применения жидкостей уровня качества " +
                    "DOT-5.1. Также подходит для применения во всех гидравлических тормозных системах вместе с синтетическими жидкостями. " +
                    "Допускается смешивание RAVENOL DOT 5.1 со всеми жидкостями такого класса. Тормозная жидкость RAVENOL DOT 5.1 соответствует " +
                    "следующим спецификациям: SAE J1703; ISO 4925; FMVSS 116 DOT 5.1. Применение обеспечивает: Оптимальную работу ABS, " +
                    "Химическую стабильность, Высокую смазочную способность, Нейтрален по отношению к элементам тормозной системы, Хорошая " +
                    "текучесть даже при низких температурах, Смешивание со всеми жидкостями такого класса.",
                    ImageUrl = "https://www.emex.ru/Catalog/Catalog/GetImage?id=5139022&h=250"
                },

                new Fluids
                {
                    Name = "DOT 5.1, 250мл",
                    Brand = "Liqui Moly",
                    Details = "Производитель: Liqui Moly\n" +
                    "Объем упаковки: 0,25 л\n" +
                    "Спецификации FMVSS 116: DOT 5.1" +
                    "\nЦена от 410 ₽\n\n" +
                    "Описание:\n" +
                    "Синтетическая тормозная жидкость на основе гликольэтеров, алкиленполигликоленов и полигликольэфиров. Содержит " +
                    "ингибиторы, предотвращающие коррозию металлических элементов тормозной системы и существенно уменьшающие процесс " +
                    "окисления в высокотемпературных условиях. Разработана специально с целью увеличения сроков эксплуатации конструкционных " +
                    "элементов гидравлики тормозных систем и систем сцеплений автомобилей. Особенно хорошо приспособлена для использования " +
                    "в тормозных системах с ABS. Обеспечивает надёжную смазку всех подвижных компонентов тормозной системы. Смешиваема и " +
                    "совместима с высококачественными синтетическими тормозными жидкостями (кроме силиконовых). Применение:Замену тормозной " +
                    "жидкости рекомендуется производить в соответствии с предписаниями производителей транспортных средств. Максимальный срок " +
                    "эксплуатации тормозной жидкости гарантируется только в случае не смешивания её с прочими тормозными жидкостями. " +
                    "Соответствие и допуски: SAE J 1703, J 1704; ISO 4 925; CUNA NC 956-01 и FMVSS 5 71. 116 DOT 5.1.",
                    ImageUrl = "https://www.emex.ru/Catalog/Catalog/GetImage?id=11298549&h=250"
                },

                new Fluids
                {
                    Name = "Ravenol Racing Brake Fluid R 325+",
                    Brand = "Ravenol",
                    Details = "Производитель: Ravenol\n" +
                    "Объем упаковки: 0,5 л\n" +
                    "Спецификации FMVSS 116: DOT 5.1" +
                    "\nЦена от 867 ₽\n\n" +
                    "Описание:\n" +
                    "Тормозная жидкость специально разработанная для высоких термических нагрузок, уровня качества DOT 4. Рецептура основана " +
                    "на высококачественной гликоль-эстеровой технологии. Специально подобранный комплекс присадок гарантирует безопасность при " +
                    "высоких температурах и экстремальных нагрузках. Имеет высокую температуру кипения, что идеально подходит для " +
                    "использования жидкости для техники в условиях спортивных соревнований (авто и мото). Обеспечивает высочайшие показатели " +
                    "в тяжёлых условиях гоночной эксплуатации. Высокая стабильность при высокой температуре. DOT 4, FMVSS 116 DOT 5.1, " +
                    "SAE J1703, SAE J1704.",
                    ImageUrl = "https://www.emex.ru/Catalog/Catalog/GetImage?id=5054998&h=250"
                },

                new Fluids
                {
                    Name = "WOLF DOT 5.1 500мл",
                    Brand = "Wolf",
                    Details = "Производитель: Wolf\n" +
                    "Объем упаковки: 0,5 л\n" +
                    "Спецификации FMVSS 116: DOT 5.1" +
                    "\nЦена от 293 ₽\n\n" +
                    "Описание:\n" +
                    "WOLF BRAKE FLUID DOT 5.1 500ML.",
                    ImageUrl = "https://www.emex.ru/Catalog/Catalog/GetImage?id=10467484&h=250"
                },

                new Fluids
                {
                    Name = "ELF, 500мл",
                    Brand = "ELF",
                    Details = "Производитель: ELF\n" +
                    "Объем упаковки: 0,5 л\n" +
                    "Спецификации FMVSS 116: DOT 5.1" +
                    "\nЦена от 785 ₽\n\n" +
                    "Описание:\n" +
                    "MOTO BRAKE FLUID DOT 5.1 Синтетическая тормозная жидкость с высокими рабочими характеристиками MOTO BRAKE FLUID DOT " +
                    "5.1 ПРИМЕНЕНИЕ Мотоциклы Спецификации Специально разработана для тормозных систем работающих в очень тяжелых условиях, " +
                    "мотоциклов оснащенных дисковыми тормозами и используемых для соревнований. Данная синтетическая тормозная жидкость " +
                    "смешивается с другими синтетическими тормозными жидкостями, такими как DOT 3, DOT 4, DOT 5.1, исключая силиконовые " +
                    "жидкости DOT 5 и специальные жидкости LHM. FMVSS 116 DOT 5.1.",
                    ImageUrl = "https://www.emex.ru/Catalog/Catalog/GetImage?id=5120932&h=250"
                }
            };
        }
    }
}
