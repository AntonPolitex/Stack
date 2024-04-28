namespace Stack
{
    public static class StackExtensions
    {
        /// <summary>
        /// Добавляет один стек к другому, в обратном порядке
        /// </summary>
        /// <param name="stack1"></param>
        /// <param name="stack2"></param>
        /// <returns></returns>
        public static Stack Merge(this Stack stack1, Stack stack2)
        {
            if (stack2.Size <= 0)
            {
                return stack1;
            }

            stack1.Add(stack2.Top);

            while (stack2.Size > 1)
            {
                stack2.Pop();
                stack1.Add(stack2.Top);
               
            }
            return stack1;
        }
    }
}
