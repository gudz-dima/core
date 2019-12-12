using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1_2
{
    public interface IDataManager
    {
        //void Init();
        List<int> GenerateNumbers();

        List<int> GenerateNumbers(int start, int end);

        int GenerateNumbersId(int id);

        bool GenerateNumbersPost(int id);

        bool GenerateNumbersPut(int id, int value);

        bool GenerateNumberDelete(int id);
    }
}
