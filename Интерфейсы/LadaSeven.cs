using System;

namespace Интерфейсы
{
    class LadaSeven : ICar
    {
        public int Move(int distnace)
        {
            return distnace / 40;
        }
    }
}
