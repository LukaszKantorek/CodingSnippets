using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodingSnippets.MultidimensionalArray
{
    public class NotNullableArray : IEnumerable<object>
    {
        public bool IsLeafArray { get; set; }

        private IEnumerable<object> _objects;

        private NotNullableArray(object arrayObject)
        {
            CastAndSetArray(arrayObject);
        }

        public static NotNullableArray Init(object arrayObject)
        {
            Validate(arrayObject);

            return new NotNullableArray(arrayObject);
        }

        private static void Validate(object arrayObject)
        {
            if (arrayObject == null)
                throw new ArgumentNullException($"{nameof(arrayObject)} is not initialized");

            // ... maybe other checking
        }

        private void CastAndSetArray(object arrayObject)
        {
            if (arrayObject is IEnumerable enumerable)
            {
                _objects = enumerable.Cast<object>();
                IsLeafArray = false;
            }
            else
            {
                _objects = new[] {arrayObject};
                IsLeafArray = true;
            }
        }

        public IEnumerator<object> GetEnumerator()
        {
            return _objects.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}