using StaclkA;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Stack_Methods
{
    internal class Program
    {
        public static StackA<T> CreateStackFromArray<T>(T[] arr)
        {
            StackA<T> stack = new StackA<T>(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                stack.Push(arr[i]);
            }

            return stack;
        }

        public static void SpillOn<T>(StackA<T> from, StackA<T> to)
        {
            // Move from temporart stack to destination stack (result = original order)
            while (!from.Is_Empty())
            {
                to.Push(from.Pop());
            }
        }

        public static StackA<T> Clone<T>(StackA<T> origin)
        {
            StackA<T> temp = new StackA<T>(Size(origin));

            // Move values from original stack to temporary stack
            while (!origin.Is_Empty())
            {
                temp.Push(origin.Pop());
            }

            StackA<T> newStack = new StackA<T>(1000);

            // Move values from temporary stack to new stack and back to original stack
            while (!temp.Is_Empty())
            {
                T save = temp.Pop();
                newStack.Push(save);
                origin.Push(save);
            }

            return newStack;
        }

        public static int Size<T>(StackA<T> stack)
        {
            T[] arr = new T[1000]; // temp arr for saving stack values

            // count + save values in arr
            int cnt = 0;
            while(!stack.Is_Empty())
            {
                arr[cnt] = stack.Pop();
                cnt++;
            }

            // Return values to stack in the correct order
            for (int i = cnt-1; i >= 0; i--)
            {
                stack.Push(arr[i]);
            }

            return cnt;
        }

        public static int Sum(StackA<int> stack)
        {
            // Iterate throught stack and sum up values

            StackA<int> temp = new StackA<int>(Size(stack));
            temp = Clone(stack);

            int sum = 0;
            while(!temp.Is_Empty())
            {
                sum += temp.Pop();
            }

            return sum;
        }

        public static bool IsExist(StackA<int> stack, int num)
        {
            // Iterate through stack and look for value given (num)

            StackA<int> temp = Clone(stack);

            bool found = false;
            while(!found && !temp.Is_Empty())
            {
                if (temp.Pop() == num)
                    found = true;
            }

            return found;
        }

        public static bool IsSorted(StackA<int> s)
        {
            // Check if every value in stack is bigger than the one under it

            StackA<int> copy = Clone(s);

            int last = copy.Pop();
            int current = copy.Pop();
            bool isSorted = true;
            while(!copy.Is_Empty())
            {
                if (last < current)
                    isSorted = false;

                last = current;
                current = copy.Pop();
            }

            return isSorted;
        }

        public static void PushToBottom<T>(StackA<T> s, T eivar)
        {
            // temporary stack to make changes
            StackA<T> temp = new StackA<T>(1000);

            SpillOn(s, temp);
            s.Push(eivar);
            SpillOn(temp, s);
        }

        public static void MakeTopBottom<T>(StackA<T> s)
        {
            StackA<T> temp = new StackA<T>(1000);

            T saveObj = s.Pop(); // save top
            SpillOn(s, temp);
            s.Push(saveObj);
            SpillOn(temp, s);
        }

        public static void PopBottom<T>(StackA<T> s)
        {
            StackA<T> temp = new StackA<T>(1000);
            SpillOn(s, temp);
            temp.Pop();
            SpillOn(temp, s);
        }

        public static void MakeBottomTop<T>(StackA<T> s)
        {
            StackA<T> temp = new StackA<T>(1000);

            SpillOn(s, temp);
            T saveObj = temp.Pop(); // save Bottom
            SpillOn(temp, s);
            s.Push(saveObj);
        }

        public static int FindMax(StackA<int> s)
        {
            StackA<int> temp = Clone(s);

            int max = temp.Pop();
            while(!temp.Is_Empty())
            {
                max = Math.Max(max, temp.Pop());
            }

            return max;
        }

        public static void PopMax(StackA<int> s)
        {
            int stackLength = Size(s);  // save original size of stack
            StackA<int> temp = Clone(s);   // for finding index of max value
            StackA<int> saveStack = new StackA<int>(1000);  // for "Refilling" stack afterwards
            SpillOn(s, saveStack);

            // Find Max index
            int max = temp.Pop();
            int maxIndex = 0;
            int cnt = 1;
            while(!temp.Is_Empty())
            {
                int last = temp.Pop();
                if (last > max)
                {
                    max = last;
                    maxIndex = cnt;
                }
                cnt++;
            }

            // "Refill" original stack without max value
            for (int i = 0; i < cnt; i++)
            {
                int last_value = saveStack.Pop();

                if (i != stackLength - 1 - maxIndex)
                    s.Push(last_value);
            }
        }

        public static void PushToIndex<T>(StackA<T> s, T eivar, int n)
        {
            StackA<T> temp = new StackA<T>(1000);

            // save stack size
            int stack_size = Size(s);

                                // n - index
            for (int i = 0; i < stack_size - n; i++)
                temp.Push(s.Pop());

            s.Push(eivar); // Push eivar to right index

            // Move all values back to original stack
            SpillOn(temp, s);
        }

        public static void PopFromIndex<T>(StackA<T> s, int n)
        {
            StackA<T> temp = new StackA<T>(1000);

            // Save stack size
            int stack_size = Size(s);

            // move out all values on top of index
            for (int i = 0; i < stack_size - 1 - n; i++)
                temp.Push(s.Pop());

            s.Pop(); // pop desired value

            // return all values to place
            while (!temp.Is_Empty())
                s.Push(temp.Pop());
        }

        public static void Reverese<T>(ref StackA<T> s)
        {
            StackA<T> temp = new StackA<T>(1000);

            SpillOn(s, temp);

            s = temp;
        }

        public static StackA<int> Sort(StackA<int> s)
        {
            // Iterate through stack: every time pop biggest, then return to original stack
            StackA<int> temp = new StackA<int>(1000);

            while(!s.Is_Empty())
            {
                temp.Push(FindMax(s));
                PopMax(s);
            }

            while(!temp.Is_Empty())
                s.Push(temp.Pop());

            return s;
        }



        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 2, 4, 5 };
            StackA<int> stack1 = CreateStackFromArray<int>(arr);
            StackA<int> stack2 = new StackA<int>(10);
            stack2.Push(1);
            stack2.Push(2);
            stack2.Push(3);
            stack2.Push(0);
            stack2.Push(10);

            Sort(stack2);
            Console.WriteLine(stack2);
        }
    }
}
