﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Exam
    {
        public int Exam_No { get; set; }

        public QuestionList questions { get; set; } = new QuestionList();

        public int CrsID { get; set; }

    }
}
