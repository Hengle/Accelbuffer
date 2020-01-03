﻿using System.Collections.Generic;

namespace Accelbuffer.Runtime.Injection
{
    internal sealed class CollectionSerializeProxy<T, TValue> : ISerializeProxy<T> where T : ICollection<TValue>, new()
    {
        T ISerializeProxy<T>.Deserialize(ref UnmanagedReader reader)
        {
            int count = reader.ReadVariableInt32(0);

            if (count == -1)
            {
                return default;
            }

            T result = new T();

            while (count > 0)
            {
                result.Add(Serializer<TValue>.Deserialize(ref reader));
                count--;
            }

            return result;
        }

        void ISerializeProxy<T>.Serialize(T obj, ref UnmanagedWriter writer)
        {
            int count = obj == null ? -1 : obj.Count;
            writer.WriteValue(0, count, Number.Var);

            if (count == -1)
            {
                return;
            }

            foreach (TValue o in obj)
            {
                Serializer<TValue>.Serialize(o, ref writer);
            }
        }
    }
}