using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson._08
{
    abstract class BaseAnim : IAnim
    {
        public abstract string Name { get; }
        public abstract string Voic { get; }
        public abstract int positions { get; }
        public bool ChekAnim(int position)
        {
            return position == positions;
        }
    }
}
