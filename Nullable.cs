using System;

namespace Test
{
    class Nullable
    {
        class Monster
        {
            public int Id{get;set;}
        }
        static void Main(string[] args)
        {
            // Nullable -> Null + able
            int? number = null;

            number = 3;
            // 아래 두 if문은 거의 차이가 없음.
            if (number != null)
            {
                
            }
            if (number.HasValue)
            {
                
            }
            int a = number.Value;

            int b = number ?? 0; // 만약 number가 null이면 뒤에 값(0)을 넣어줌


            Monster monster = null;

            if (monster != null)
            {
                int monsterid = monster.Id;
            }

            int? id = monster?.Id; // 아래 if문과 이 구문은 동일하게 동작함

            if (monster == null)
            {
                id = null;
            }
            else
            {
                id = monster.Id;
            }
        }
    }
}