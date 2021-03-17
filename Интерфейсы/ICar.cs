namespace Интерфейсы
{
    internal interface ICar 
    {
        /// <summary>
        /// Выполнить перемещение. 
        /// </summary>
        /// <param name="distnace">Расстояние.</param>
        /// <returns>Время движения</returns>
        int Move(int distnace);
    }
}
