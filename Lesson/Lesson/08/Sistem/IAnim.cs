using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson._08
{
    interface IAnim
    {
        string Name { get; }
        string Voic { get; }
        int positions { get; }
        bool ChekAnim(int position);
    }
}
