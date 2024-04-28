namespace Stack
{
    public partial class Stack
    {
        private class StackItem
        {

            private readonly string _value;
            private readonly StackItem? _prev;

            public string Value
            {
                get
                {
                    return _value;
                }
            }
            public StackItem? Prev
            {
                get
                {
                    try
                    {
                        if (_prev != null)
                        {
                            return _prev;
                        }
                        else
                        {
                            throw new ArgumentNullException(" Попытка обращения к несуществующему элемента стека, стек пуст! ");
                        }
                    }
                    catch (ArgumentNullException)
                    {
                        throw;
                    }


                }
            }
            public StackItem(string value, StackItem? prev = null)
            {

                _prev = prev;
                try
                {
                    if (value != null)
                    {
                        _value = value;
                    }
                    else
                    {
                        throw new ArgumentNullException("значение null не принимается");
                    }
                }
                catch (ArgumentNullException)
                {
                    _value = "";
                    throw;
                }


            }

        }
    }
}
