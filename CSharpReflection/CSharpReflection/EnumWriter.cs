using System;

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
            enumelements.enumValues = type.GetEnumValues();
        }
    }
}
