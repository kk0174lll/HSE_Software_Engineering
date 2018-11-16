using LaboratoryWork;
using LaboratoryWork1.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork1.works.classroomWork01
{
    class Task3 : ATask
    {
        public Task3()
        {
            taskName = "v19. class room work 01, task 3";
        }

        /// <summary>
        /// При выборе места строительства жилого комплекса при металлургическом комбинате 
        /// необходимо учитывать "розу ветров" (следует расположить жилой комплекс так, чтобы частота
        /// ветра со стороны металлургического комбината была бы минимальной). Для этого в течение
        /// года проводилась регистрация направления ветра в районе строительства.Данные
        /// представлены в виде массива, в котором направление ветра за каждый день кодируется
        /// следующим образом: 1 — северный, 2 — южный, 3 — восточный, 4 — западный, 5 — северо- 
        /// западный, 6 — северо-восточный, 7 — юго-западный, 8 — юго-восточный.Определить, как
        /// должен быть расположен жилой комплекс по отношению к комбинату. 
        /// </summary>
        protected override void executeTasck()
        {
            Random random = new Random(0);
            int[] roseOfWind = ArrayUtils.CreateArray(365, (e) => { return ArrayUtils.random.Next(1, 9); });
            Utils.PrintLnText($"roseOfWind: {ArrayUtils.PrintArray(roseOfWind)}");
            int[] directionСounter = new int[8];
            foreach (int direction in roseOfWind)
            {
                directionСounter[direction - 1]++;
            }
            Utils.PrintLnText($"directionСounter: {ArrayUtils.PrintArray(directionСounter)}");

            int minDirection = 0;
            int minDirectionCount = 365;
            for (int i = 0; i < 8; i++)
            {
                if (minDirectionCount < directionСounter[i])
                {
                    minDirectionCount = directionСounter[i];
                    minDirection = i;
                }
            }
            Utils.PrintLnText($"profitable direction: {minDirection + 1}");
        }
    }
}
