using System.Collections.Generic;

namespace CSharpReflection
{
    public class ClassElements
    {
        public string classNamespace;
        public string className;
        public List<FieldElements> classFields = new List<FieldElements>();
        public List<PropertyElements> classPropertys = new List<PropertyElements>();
    }
}
