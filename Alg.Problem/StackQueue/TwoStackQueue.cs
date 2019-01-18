using System.Collections.Generic;

namespace Alg.Problem.StackQueue
{
    public class TwoStackQueue
    {
        private readonly Stack<int> stackPush;
        private readonly Stack<int> stackPop;

        public TwoStackQueue()
        {
            stackPush = new Stack<int>();
            stackPop = new Stack<int>();
        }

        public void Add(int item)
        {
            stackPush.Push(item);
        }

        public int? Poll()
        {
            Update();

            if (stackPop.TryPop(out int result))
                return result;
            else
                return null;
        }

        public int? Peek()
        {
            Update();

            if (stackPop.TryPeek(out int result))
                return result;
            else
                return null;
        }

        private void Update()
        {
            if (0 == stackPop.Count)
                while (stackPush.Count > 0)
                    stackPop.Push(stackPush.Pop());
        }
    }
}
