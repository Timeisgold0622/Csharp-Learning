using System;

namespace Test
{
    class Delegate
    {
        // 업체 사장 - 사장님의 비서
            // 우리의 연락처 / 용건 거꾸로 -> 연락을 달라고

        delegate int OnClicked();
        // delegate -> 형식은 형식인데, 함수 자체를 인자로 넘겨주는 그런 형식
        // 반환 : int, 입력 void
        // OnClicked 이 delegate 형식의 이름임
        // UI
        static void ButtonPressed(OnClicked clickedFunction/*함수 자체를 인자로 넘겨주고 */)
        {
            // 함수를 호출();
        }

        static int TestDelegate()
        {
            return 0;
        }

        static int TestDelegate2()
        {
            return 0;
        }
        static void Main(string[] args)
        {
            ButtonPressed(/* */);

            ButtonPressed(TestDelegate);

            // 체이닝
            OnClicked click = new OnClicked(TestDelegate);
            click += TestDelegate2;

            ButtonPressed(click);


        }
    }
}