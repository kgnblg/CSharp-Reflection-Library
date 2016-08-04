using System.Collections.Generic;
using System.Reflection;

namespace CSharpReflection
{
    class FieldWriter
    {
        FieldInfo[] fields;

        public FieldWriter(FieldInfo [] fields)
        {
            this.fields = fields;
        }

        public List<FieldElements> Writer()
        {
            List<FieldElements> fieldlist = new List<FieldElements>();

            foreach (var field in fields)
            {
                FieldElements fieldelement = new FieldElements();
                fieldelement.fieldName = field.Name;
                fieldelement.fieldTypeFullName = field.FieldType.FullName;
                fieldelement.fieldReturnType = field.FieldType.Name;
                fieldelement.FieldType = field.FieldType;

                fieldlist.Add(fieldelement);
            }

            return fieldlist;
        }

    }
}
