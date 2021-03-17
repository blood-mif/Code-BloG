using System;

namespace Интерфейсы
{
    class BMVSeven : ICar
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public int Move(int distnace)
        {
            return distnace / 100;
        }
    }
}
