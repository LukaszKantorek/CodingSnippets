using System.Collections.Generic;

namespace CodingSnippets.MultidimensionalArray
{
    public static class MultidimensionalArrayHelper
    {
        public static IEnumerable<object> ToFlattenArray(this object itemsArrayToFlat)
        {
            var arrayWithObjects = NotNullableArray
                .Init(itemsArrayToFlat);
            
            return IterateThroughDimentions(arrayWithObjects);
        }

        private static IEnumerable<object> IterateThroughDimentions(NotNullableArray arrayWithObjects)
        {
            if (arrayWithObjects.IsLeafArray)
                return arrayWithObjects;

            var flattenArray = new List<object>();

            foreach (var listElement in arrayWithObjects)
            {
                flattenArray.AddRange(ToFlattenArray(listElement));
            }

            return flattenArray;
        }
    }
}
