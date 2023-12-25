using System;
using System.Collections.Generic;
using System.Text;

namespace Work5
{
    class MyDictionary<Key, Value>
    {
        Key[] keys;
        Value[] values;
        public MyDictionary()
        {
            keys = new Key[0];
            values = new Value[0];
        }
        public void Add(Key ogrenciId, Value ogrenciName)
        {
            Key[] tempKey = keys;
            Value[] tempValue = values;

            keys = new Key[keys.Length + 1];
            values = new Value[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }
            keys[keys.Length - 1] = ogrenciId;
            values[values.Length - 1] = ogrenciName;
        }
        public int Length
        {
            get { return keys.Length; }

        }

        public Key[] _Keys
        {
            get { return keys; }
        }

        public Value[] _Values
        {
            get { return values; }
        }


    }
}
