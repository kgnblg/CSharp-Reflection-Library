using System;
using System.Reflection;

namespace CSharpReflection
{
    public class TypeHandler
    {
        Type[] types;
        Elements elements = new Elements();

        public TypeHandler(Assembly assembly)
        {
            types = assembly.GetTypes();
        }

        public Elements TypeSender()
        {
            foreach (var type in types)
            {
                if (type.IsClass)
                {
                    ClassWriter classwriter = new ClassWriter(type, elements);
                    classwriter.Write();
                    elements = classwriter.elements;
                }
                else if (type.IsEnum)
                {
                    EnumWriter enumwriter = new EnumWriter(type, elements);
                    enumwriter.Write();
                    elements = enumwriter.elements;
                }
                else
                {
                    StructWriter structwriter = new StructWriter(type, elements);
                    structwriter.Write();
                    elements = structwriter.element;
                }
            }

            return elements;
        }
    }
}

