using System.Collections;

namespace Lessons.Lesson10Tasks.ArrayTask
{
    ///<summary>
    ///Supports a simple iteration over a generic collection (implements generic IEnumerator<ElementType>).
    ///A type parameter ElementType represents the type of the collection elements.
    ///</summary>
    internal class GenericEnumerator<ElementType> : IEnumerator<ElementType>
    {
        private readonly ElementType[] array;
        private int position;
        private ElementType currentElement;

        public ElementType Current => currentElement;
        object IEnumerator.Current => Current;

        public GenericEnumerator(ElementType[] array)
        {
            this.array = array;
            position = -1;
            currentElement = default;
        }

        ///<summary>
        ///Moves the pointer to the next element in the collection.
        ///</summary>
        public bool MoveNext()
        {
            if (++position >= array.Length)
            {
                return false;
            }
            else
            {
                currentElement = array[position];
            }
            return true;
        }

        ///<summary>
        ///Moves the pointer to the position before the first element of the collection.
        ///</summary>
        public void Reset()
        {
            position = -1;
        }

        public void Dispose() { }
    }
}