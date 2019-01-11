

namespace LaboratoryWork.works.classroomWork01
{
    class Task2 : ATask
    {
        delegate bool checker(int e);

        public Task2()
        {
            taskName = "v19. class room work 01, task 2";
        }

        /// <summary>
        /// Дан массив ненулевых целых чисел. Определить, сколько раз элементы массива при 
        /// просмотре от его начала меняют знак.Например, в массиве 10, –4, 12, 56, –4, –89 знак
        /// меняется 3 раза.
        /// </summary>
        protected override void executeTasck()
        {
            int[] array = IntArrayUtils.CreateArray((e) => { return Utils.random.Next(-50, 51); });
            int changeCount = 0;

            checker checkSign = e => e >= 0;
            bool lastCheng = checkSign(array[0]);

            foreach (int currentElement in array)
            {
                if (checkSign(currentElement) != lastCheng)
                {
                    lastCheng = !lastCheng;
                    changeCount++;
                }
            }
            Utils.PrintLnText($"changeCount: {changeCount}");
        }
    }
}
