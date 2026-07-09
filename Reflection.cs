using System;
using System.Reflection;

namespace Test
{
    class Reflection
    {
        class Important : System.Attribute
        {
            string message;
            Important(string message) { this.message = message; }
        }
        class Monster
        {
            // hp입니다. 중요한 정보입니다.
            [Important("Very Important.")]
            public int hp;
            protected int attack;
            private float speed;
            void Attack()
            {
                
            }
        }

        static void Main(string[] args)
        {
            // Reflection : X-Ray
            Monster monster = new Monster();

            Type type = monster.GetType();
            var fields = type.GetFields(System.Reflection.BindingFlags.Public) 
            | type.GetFields(System.Reflection.BindingFlags.NonPublic) 
            | type.GetFields(System.Reflection.BindingFlags.Static) 
            | type.GetFields(System.Reflection.BindingFlags.Instance);

            
            foreach (FieldInfo field in fields)
            {
                string access = "protected";
                if (field.IsPublic)
                {
                    access = "public";
                }else if (field.IsPrivate)
                {
                    access = "private";
                }
                var attributes = field.GetCustomAttributes();
            }
        }
    }
}