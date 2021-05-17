using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDUEX.Domain.Enums;

namespace EDUEX.Web.Extensions
{
    public static class ParsingDifficultyLevel
    {
        public static CourseDifficultyLevelEnum GetLevel(this string Level)
        {
            
            switch (Level)
            {
                case "Beginner": return CourseDifficultyLevelEnum.Beginner;
                    break;
                case "Intermediate": return CourseDifficultyLevelEnum.Intermediate;
                    break;
                case "Advanced": return CourseDifficultyLevelEnum.Advanced;
                    break;
                default: return  CourseDifficultyLevelEnum.Beginner;
                    break;
            }
        }
    }
}
