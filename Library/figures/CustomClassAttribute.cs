using System;

namespace Library
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class CustomClassAttribute : Attribute
    {
        public string ClassName { get; }

        public CustomClassAttribute(string className)
        {
            ClassName = className;
        }
    }
}