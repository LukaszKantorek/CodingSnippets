using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingSnippets.MultidimensionalArray
{
    public static class MultidimensionalArrayHelper
    {
        public static IEnumerable<object> ToFlattenArray(this object itemsArrayToFlat)
        {
            try
            {
                var arrayWithObjects = NotNullableArray
                    .Init(itemsArrayToFlat);

                var flattenArray = new HashSet<object>();

                IterateThroughDimentions(arrayWithObjects, flattenArray);

                return flattenArray;
            }
            catch (Exception e)
            {
                Console.WriteLine(e); 
                throw;
            }
        }

        private static void IterateThroughDimentions(NotNullableArray arrayWithObjects,
            HashSet<object> flattenArray)
        {
            if (arrayWithObjects.IsLeafArray)
            {
                flattenArray.Add(arrayWithObjects.First());
                
                return;
            }

            foreach (var listElement in arrayWithObjects)
            {
                var notNullableArray = NotNullableArray.Init(listElement);

                IterateThroughDimentions(notNullableArray, flattenArray);
            }
        }
    }
}
