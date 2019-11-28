using System;

namespace Exam_SK.Models
{
    internal class MinLengthAttribute : Attribute
    {
        private int v;

        public MinLengthAttribute(int v)
        {
            this.v = v;
        }
    }
}