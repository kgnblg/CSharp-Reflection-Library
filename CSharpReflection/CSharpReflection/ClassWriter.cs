using System;
using System.Collections.Generic;

namespace CSharpReflection
{
    class ClassWriter
    {
        Type type;
        public Elements elements;

        public ClassWriter(Type type, Elements elements)
        {
            this.type = type;
            this.elements = elements;
        }

        public void Write()
        {
            ClassElements classelement = new ClassElements();

            classelement.className = type.Name;
            classelement.classNamespace = type.Namespace;

            FieldWriter fieldwriter = new FieldWriter(type.GetFields());
            classelement.classFields = fieldwriter.Writer();

            PropertyWriter propertywriter = new PropertyWriter(type.GetProperties());
            classelement.classPropertys = propertywriter.Writer();

            elements.classList.Add(classelement);
        }
    }
}
