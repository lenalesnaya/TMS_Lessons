using System.Collections;

namespace Lessons.Lesson10Tasks.ArrayTask
{
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

        public void Add(ElementType element)
        {
            Array.Resize(ref array, array.Length + 1);
            array[^1] = element;
        }

        public void Add(ElementType[] newElements)
        {
            var difference = array.Length;
            Array.Resize(ref array, array.Length + newElements.Length);
            for (int i = 0; i < newElements.Length; i++)
            {
                array[i + difference] = newElements[i];
            }
        }

        public void Add(GenericArrayWrapper<ElementType> newElements)
        {
            var difference = array.Length;
            Array.Resize(ref array, array.Length + newElements.Length());
            for (int i = 0; i < newElements.Length(); i++)
            {
                array[i + difference] = newElements.GetValue(i);
            }
        }

        public void Remove(ElementType element)
        {
            var newArrayElementsCounter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (!array[i].Equals(element))
                {
                    array[newArrayElementsCounter++] = array[i];
                }
            }

            if (newArrayElementsCounter != array.Length)
            {
                Array.Resize(ref array, newArrayElementsCounter);
            }
        }

        public ElementType GetValue(int index)
        {
            return array[index];
        }

        public int Length()
        {
            return array.Length;
        }

        public IEnumerator<ElementType> GetEnumerator()
        {
            return new GenericEnumerator<ElementType>(array);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}