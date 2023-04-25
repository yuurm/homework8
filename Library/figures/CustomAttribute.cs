using System;

namespace Library.figures
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class CustomAttribute : Attribute
    {
        public string AttributeName { get; }

        public CustomAttribute(string attributeName)
        {
            AttributeName = attributeName;
        }
    }
}