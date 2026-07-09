using System;

namespace Test
{
    class Property
    {
        // 객체 지향 -> 은닉성
        class Knight
        {
            protected int hp;

            public int Hp // get, set이 없어도 됨
            {
                get {return hp;}
                set {hp = value;} // 추가적인 접근 지정자(private등) 설정시 내부에서만 사용가능하게 가능
            }
            public int Damage // 자동으로 필드 설정 및, getter setter 설정함
            {
                get; set;
            } = 100; // = 을 붙여 바로 초기화도 가능 (C# 7.0)
            void Test()
            {
                Hp - 100;
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}