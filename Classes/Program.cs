using System;


namespace Classes
{

    public class Nullable<T> where T : struct
    {
        private object _value;
        public Nullable()
        {

        }
        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
           get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
            {
                return (T)_value;
            }
            else
            {
                return default(T);
            }
        }
    }




    class Program
    {
        public static void Main()
        {
            Nullable<int> obj = new Nullable<int>(45);
            Console.WriteLine(obj.HasValue);
            Console.WriteLine(obj.GetValueOrDefault());
        }
    }
}
