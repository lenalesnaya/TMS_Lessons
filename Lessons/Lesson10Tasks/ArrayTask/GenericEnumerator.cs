using System.Collections;

namespace Lessons.Lesson10Tasks.ArrayTask
{
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
            currentElement = default(ElementType);
        }

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

        public void Reset()
        {
            position = -1;
        }

        public void Dispose() { }
    }
}