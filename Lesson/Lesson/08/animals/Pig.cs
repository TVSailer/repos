
namespace Lesson._08
{
    class Pig : BaseAnim, IAnim
    {
        public override string Name => "Свинья";
        public override string Voic => "Хрю!";
        public override int positions => 3;
    }
}
