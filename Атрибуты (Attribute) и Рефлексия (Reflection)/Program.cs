using System;
using System.Linq;

namespace Атрибуты__Attribute__и_Рефлексия__Reflection_
{
    class Program
    {
        static void Main(string[] args)
        {
            var photo = new Photo("hello.png")
            {
                Path = @"C:\hello.png"
            };

            var type = typeof(Photo);
            var attributes = type.GetCustomAttributes(false);
            
            foreach (var item in attributes)
            {
                Console.WriteLine(item);
            }

            var properties = type.GetProperties();
            foreach (var item in properties)
            {
                var attrs = item.GetCustomAttributes(false);

                if(attrs.Any(a => a.GetType() == typeof(GeoAttributte)))
                {
                Console.WriteLine(item.PropertyType +" "+item.Name);

                }


                //foreach (var a in attrs)
                //{
                //    Console.WriteLine(a);
                //}
            }
        }
    }
}
