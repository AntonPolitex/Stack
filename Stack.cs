namespace Stack
{

    public partial class Stack
    {

        private StackItem? _up;
        private int _size = 0;
        private string? _top = null;
        public string Top { get { return _top; } }
        public int Size { get { return _size; } }
        public Stack(params string[] parametrs)
        {

            foreach (string tmp in parametrs)
            {
                this.Add(tmp);
            }
        }

        /// <summary>
        /// Принимает на вход неограниченное количество параметров типа Stack
        /// и возвращает новый стек с элементами каждого стека в порядке параметров, но сами элементы записаны в обратном порядке
        /// </summary>
        /// <param name="stacks"></param>
        /// <returns></returns>
        public static Stack Concat(params Stack[] stacks)
        {
            Stack stack = new Stack();
            foreach (Stack tmp in stacks)
            {
                stack.Merge(tmp);
            }
            return stack;
        }

        /// <summary>
        /// Метод Add(string) - добавляет элемент в стек
        /// </summary>
        /// <param name="something"></param>
        public void Add(string something)
        {
            try
            {
                    if (_size == 0)
                    {
                        _up = new StackItem(something);
                    }
                    else
                    {
                        _up = new StackItem(something, _up);
                    }
                    _size++;
                    _top = something;

            }
            catch(ArgumentNullException ex )
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }

        }

        /// <summary>
        /// Метод Pop() - извлекает верхний элемент и удаляет его из стека. 
        /// При попытке вызова метода Pop у пустого стека - выбрасывать исключение с сообщением "Стек пустой"
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NullStakException"></exception>
        public string Pop()
        {
            string tmp;

            if (_size > 0) 
            { 
                _size--;
            }

            tmp = _top;

            try
            {
                
                _up = _up.Prev;
                _top = _up.Value;
                return tmp;

            }
            catch (ArgumentNullException ex)
            {
                _top = null;

                Console.WriteLine();
                Console.WriteLine(ex.Message);
                Console.WriteLine();

                return _top;
            }




        }
    }
}
