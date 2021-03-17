using System;

namespace Интерфейсы
{


    public class Cyborg : ICar, IPerson
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        // явная реализация
        int ICar.Move(int distnace)
        {
            return distnace / 100;
        }

        int IPerson.Move(int distance)
        {
            return distance / 5;
        }

        /*
         не явная реализация

        int Move(int distnace)
        {
            return distnace / 100;
        }
         */
    }
}
