using System;

namespace Test
{
    class Event
    {
        static void OnInputTest()
        {
            Console.WriteLine("Input Receive");
        }
        static void Main(string[] args)
        {
            InputManger inputManger = new InputManger();

            inputManger.InputKey += OnInputTest();
            while (true)
            {
                inputManger.Update();
            }
            inputManger.InputKey();
        }
    }
}