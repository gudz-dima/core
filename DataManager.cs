using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1_2
{
    public class DataManager : IDataManager
    {
        List<int> array = new List<int>();

        public DataManager()
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                array.Add(rand.Next());
            }
        }

        public List<int> GenerateNumbers()
        {
            return array;
        }

        public List<int> GenerateNumbers(int start, int end)
        {
            return array.GetRange(start, end);
        }

        public int GenerateNumbersId(int id)
        {
            return array[id];
        }

        public bool GenerateNumbersPost(int value)
        {
            array.Add(value);
            return true;
        }

        public bool GenerateNumbersPut(int id, int value)
        {
            if (id < array.Count)
            {
                array[id] = value;
                return true;
            } else
            {
                return false;
            }
        }

        public bool GenerateNumberDelete(int id)
        {
            if (id < array.Count)
            {
                array.RemoveAt(id);
                return true;
            } else
            {
                return false;
            }
        }
    }
}
