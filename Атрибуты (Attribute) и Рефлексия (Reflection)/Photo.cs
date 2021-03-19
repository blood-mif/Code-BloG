using System;
using System.Collections.Generic;
using System.Text;

namespace Атрибуты__Attribute__и_Рефлексия__Reflection_
{
    public class Photo
    {
    [GeoAttributte(10,20)]
        public string Name { get; set; }
        [GeoAttributte(10, 20)]
        public string Path { get; set; }
        public Photo(string name)
        {
            // Проверка входных данных

            Name = name;
        }
    }
}
