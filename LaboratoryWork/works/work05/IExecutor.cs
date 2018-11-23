using LaboratoryWork1.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork1.works.work05
{
    interface IExecutor
    {
        void CreateArray(IntArrayUtils.createElementFunction makeFunction);
        void CreateMatrix(IntArrayUtils.createElementFunction makeFunction);
        void CreateRaggedArray(IntArrayUtils.createElementFunction makeFunction);
        void PrintArray();
        void PrintMatrix();
        void PrintRaggedArray();
        void AddElem();
        void DeleteRow();
        void AddRowToBeginning();
    }
}
