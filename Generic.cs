using System;
using System.Collections.Generic;

namespace Test
{
    class Generic
    {
        class MyList<T> // 제네릭 클래스 (where T : 객체) 
        // where T : new() 는 반드시 어떤 생성자가 있어야된다는 의미임
        // where T : int 는 반드시 T는 int 혹은 int를 상속받는 자식이여야된다는 의미
        {
            T[] arr = new T[10];
            public T GetItem(int i)
            {
                return arr[i];
            }
        }
        static void Test<T>(T input)
        {
            // 제네릭 함수
        }
        static void Main(string[] args)
        {
            MyList<int> myIntList = new MyList<int>();
            MyList<short> myShortList = new MyList<short>();
        }
    }
}