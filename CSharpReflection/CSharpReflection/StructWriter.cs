using System;

namespace CSharpReflection
{
    class StructWriter
    {
        Type type;
        public Elements element;

        public StructWriter(Type type, Elements element)
        {
            this.type = type;
            this.element = element;
        }

        public void Write()
        {
            StructElements structelement = new StructElements();
            structelement.structName = type.Name;
            structelement.structNamespace = type.Namespace;

            FieldWriter structfields = new FieldWriter(type.GetFields());
            structelement.structFields = structfields.Writer();

            element.structList.Add(structelement);
        }
    }
}
