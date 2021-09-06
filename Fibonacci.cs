using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    public class Fibonacci
    {
        static Hashtable hashtable = new Hashtable();
        static Dictionary<int,int> hashTableBottomUp = new Dictionary<int, int>();
        public static int NormalFibonacci(int n)
        {
            int sum = 0;
            int prev = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = sum;
                sum = prev;
                prev = temp + sum;
            }
            return sum;
        }

        public static int NormalFibonnacciReturningFromOnetoTo(int n)
        {
            var fibNumber = 0;
            var prevPrevNumber = 0;
            var prevNumber = 1;
            if (n <= 2)
                return 1;
            else
            {
                for (int i = 3; i <= n + 1; i++)
                {
                    fibNumber = prevPrevNumber + prevNumber;
                    prevPrevNumber = prevNumber;
                    prevNumber = fibNumber;
                }
            }
            return fibNumber;
        }

        public static int RecursiveFibonacci(int n)
        {
            if (n <= 2)
                return 1;
            else
                return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }

        public static int RecursiveMemoizedFibonacci(int n)
        {
            if (n <= 2)
                return 1;

            var fibNumber = RecursiveMemoizedFibonacci(n - 2) + RecursiveMemoizedFibonacci(n - 1);

            hashtable[n] = fibNumber;

            return fibNumber;
        }

        public static int BottomUpMemoized(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int temp;
                if (i <= 2)
                    temp = 1;
                else
                    temp = hashTableBottomUp[i - 2] + hashTableBottomUp[i - 1];

                hashTableBottomUp[i] = temp;
            }
            return hashTableBottomUp[n];
        }
    }
}
