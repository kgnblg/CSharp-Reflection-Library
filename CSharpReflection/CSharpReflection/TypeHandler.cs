using System;
using System.Reflection;

namespace CSharpReflection
{
    class TypeHandler
    {
        Type[] types;
        Elements elements = new Elements();

        public TypeHandler(Assembly assembly)
        {
            types = assembly.GetTypes();
        }

        public void TypeSender()
        {
            foreach (var type in types)
            {
                if (type.IsClass)
                {
                    ClassWriter classwriter = new ClassWriter(type, elements);
                    classwriter.Write();
                }
                else if (type.IsEnum)
                {
                    EnumWriter enumwriter = new EnumWriter(type, elements);
                    enumwriter.Write();
                }
                else
                {
                    StructWriter structwriter = new StructWriter(type, elements);
                    structwriter.Write();
                }
            }
        }
    }
}
