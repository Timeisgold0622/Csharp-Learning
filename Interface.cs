using System;

namespace Test
{
    // 죽음의 다이아몬드 문제 때문에 C#은 다중 상속을 막음 -> 그래서 인터페이스를 씀
    class Interface
    {
        abstract class Monster // abstract : 추상 클래스 키워드 이고, 추상 함수는 무조건 오버라이딩
        // 추상클래스 안에서 필드 불가(변수 못 만듬)
        {
            // public virtual void Shout(){}
            public abstract void Shout(); // shout를 추상 함수로 선언
        };

        interface IFlyable // 인터페이스면 키워드 앞에 I를 붙어주는게 사람들의 규칙임
        {
            void Fly(); // 굳이 키워드나 그런건 물러주지 않음
        }
        class Orc : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("록타르 오가르!");
            }
        };
        
        class FlyableOrc : Orc , IFlyable
        {
            public void Fly()
            {
                
            }
        }
        class Skeleton : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("꾸에엑!!");
            }
        };
    }
}