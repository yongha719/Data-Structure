using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure
{
    class YHDictionary<TKey, TValue>
    {
        struct Bucket
        {
            TKey key;
            TValue value;
            int hashcode;
            int next;
        }

        Bucket[] buckets;




        public YHDictionary() : this(0) { }
        public YHDictionary(int capacity)
        {
            if (capacity < 0) throw new ArgumentOutOfRangeException("Capacity 제대로 넣어라잉");
        }
    }
}
