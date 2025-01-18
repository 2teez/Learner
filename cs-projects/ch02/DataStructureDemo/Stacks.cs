namespace Stacks
{
    public class Stack<T>
    {
        private int size;
        private T[] data;
        private int index;
        public Stack(int size)
        {
            this.size = size;
            data = new T[size];
            index = 0;
        }
        public Stack() : this(10) { }
        public int Size
        {
            get => size;
        }

        public void Push(T item)
        {
            if (index == size)
            {
                throw new IndexOutOfRangeException("Index out of range.");
            }
            else
            {
                data[index++] = item;
            }
        }

        public T Pop()
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Empty Stack. No action can be carried out.");
            }
            var result = data[index - 1];
            data[index - 1] = default(T);
            index -= 1;
            return result;
        }

        public void Peek()
        {
            if (index < 0)
            {
                throw new ArgumentNullException("Empty Stack. Nothing to viewed.");
            }
            System.Console.WriteLine($"{index} - {data[index - 1]}");
        }

        public T this[int newIndex]
        {
            get => (T)data[newIndex];
            set => data[newIndex] = value;
        }

        public void Print(T? item = default(T))
        {
            if (item == null)
            {
                Console.WriteLine($"{ToString()}");
            }
            else
            {
                Console.WriteLine($"{string.Join(",", item)}");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var value in data)
            {
                yield return (T)value;
            }
        }

        public override string ToString() => $"Stack{{{string.Join(",", data)}}}";
    }
}
