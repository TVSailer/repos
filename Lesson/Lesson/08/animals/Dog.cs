
namespace Lesson._08
{
    class Dog : BaseAnim, IAnim
    {
        public override string Name => "Собака";
        public override string Voic => "Гав!";
        public override int positions => 2;
    }
}
