﻿
namespace Lesson._07
{
    class Delit : Fahter
    {
        public override string operetions => "/";

        public override double Run(double[] param)
        {
            return param[0] / param[1];
        }
    }
}
