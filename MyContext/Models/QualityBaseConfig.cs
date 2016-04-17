using System;
using System.Collections.Generic;

namespace MyContext.Models
{
    public partial class QualityBaseConfig
    {
        public int Id { get; set; }
        public string ModuleCode { get; set; }
        public bool NeedJudgeGrade { get; set; }
        public bool GradeUseInvmas { get; set; }
        public bool NeedGradePrice { get; set; }
        public bool NeedSample { get; set; }
    }
}
