using System;

namespace Атрибуты__Attribute__и_Рефлексия__Reflection_
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Constructor)]
    class GeoAttributte : Attribute
    {
        public int X { get; set; }
        public int Y { get; set; }

        public GeoAttributte()
        {

        }
        public GeoAttributte(int x, int y)
        {
            // Проверка входных данных
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"x[{X}] ; y[{Y}]";
        }
    }
}
