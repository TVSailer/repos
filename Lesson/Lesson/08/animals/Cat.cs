
namespace Lesson._08
{
    class Cat : BaseAnim, IAnim
    {
        public override string Name => "Кот";
        public override string Voic => "Мяу";
        public override int positions => 1;
    }
}
