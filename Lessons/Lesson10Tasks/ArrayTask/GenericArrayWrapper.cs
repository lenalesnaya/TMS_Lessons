using System.Collections;

namespace Lessons.Lesson10Tasks.ArrayTask
{
    ///<summary>
    ///Generic wrapper class for an array with auxiliary methods
    ///(including the GetEnumerator method, which allows to work with the class as a collection). Implements IEnumerable<ElementType>.
    ///A type parameter ElementType represents the type of the array elements.
    ///</summary>
    internal class GenericArrayWrapper<ElementType> : IEnumerable<ElementType>
    {
        private ElementType[] array;

        public GenericArrayWrapper()
        {
            array = Array.Empty<ElementType>();
        }

        public GenericArrayWrapper(ElementType[] array)
        {
            this.array = array;
        }

        public GenericArrayWrapper(GenericArrayWrapper<ElementType> array)
        {
            this.array = new ElementType[array.Length()];
            for (int i = 0; i < array.Length(); i++)
            {
                this.array[i] = array.GetValue(i);
            }
        }

        ///<summary>
        ///Adds a new element to the end of the array.
        ///</summary>
        ///<param name="element">New element, added to the array.</param>
        public void Add(ElementType element)
        {
            Array.Resize(ref array, array.Length + 1);
            array[^1] = element;
        }

        ///<summary>
        ///Adds a range of elements to the end of the array.
        ///</summary>
        ///<param name="newElements">The range of elements, added to the array.</param>
        public void Add(ElementType[] newElements)
        {
            var difference = array.Length;
            Array.Resize(ref array, array.Length + newElements.Length);
            for (int i = 0; i < newElements.Length; i++)
            {
                array[i + difference] = newElements[i];
            }
        }

        ///<summary>
        ///Adds a range of elements, wrapped in GenericArrayWrapper class, to the end of the array.
        ///</summary>
        ///<param name="newElements">The range of elements, wrapped in GenericArrayWrapper class, added to the array.</param>
        public void Add(GenericArrayWrapper<ElementType> newElements)
        {
            var difference = array.Length;
            Array.Resize(ref array, array.Length + newElements.Length());
            for (int i = 0; i < newElements.Length(); i++)
            {
                array[i + difference] = newElements.GetValue(i);
            }
        }

        ///<summary>
        ///Removes the specified element from the array.
        ///</summary>
        ///<param name="element">The element to remove.</param>
        public void Remove(ElementType element)
        {
            var newArrayElementsCounter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] is null || !array[i].Equals(element))
                {
                    array[newArrayElementsCounter++] = array[i];
                }
            }

            if (newArrayElementsCounter != array.Length)
            {
                Array.Resize(ref array, newArrayElementsCounter);
            }
        }

        ///<summary>
        ///Removes null references from the array.
        ///</summary>
        public void RemoveNullElements()
        {
            var newArrayElementsCounter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] is not null)
                {
                    array[newArrayElementsCounter++] = array[i];
                }
            }

            if (newArrayElementsCounter != array.Length)
            {
                Array.Resize(ref array, newArrayElementsCounter);
            }
        }

        ///<summary>
        ///Gets an element from the array by index.
        ///</summary>
        ///<param name="index">Search element index.</param>
        ///<returns>
        ///Returns the found element.
        ///</returns>
        public ElementType GetValue(int index)
        {
            return array[index];
        }

        ///<summary>
        ///Gets the number of elements in the array.
        ///</summary>
        ///<returns>
        ///Returns the number of elements in the array.
        ///</returns>
        public int Length()
        {
            return array.Length;
        }

        ///<summary>
        ///Gets the object of GenericEnumerator.
        ///</summary>
        ///<returns>
        ///Returns the object of GenericEnumerator.
        ///</returns>
        public IEnumerator<ElementType> GetEnumerator()
        {
            return new GenericEnumerator<ElementType>(array);
        }

        ///<summary>
        ///Calls GetEnumerator() of GenericArrayWrapper.
        ///</summary>
        ///<returns>
        ///Returns the object of GenericEnumerator.
        ///</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}