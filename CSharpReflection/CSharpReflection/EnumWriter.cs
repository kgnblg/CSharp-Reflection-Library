using System;
using System.Collections.Generic;

namespace CSharpReflection
{
    class EnumWriter
    {
        Type type;
        Elements elements;

        public EnumWriter(Type type, Elements elements)
        {
            this.type = type;
            this.elements = elements;
        }

        public void Write()
        {
            EnumElements enumelements = new EnumElements();
            enumelements.enumName = type.Name;
            enumelements.enumNamespace = type.Namespace;

            List<EnumFields> enumfields = new List<EnumFields>();

            foreach (var value in type.GetEnumValues())
            {
                EnumFields enumfield = new EnumFields();
                enumfield.enumValue = value.ToString();
                enumfield.enumNumberValue = (int)value;

                enumfields.Add(enumfield);
            }
        }
    }
}
