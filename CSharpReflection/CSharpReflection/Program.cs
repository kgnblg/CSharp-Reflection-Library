using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyReader assemblyReader = new AssemblyReader("C:/Users/gnygl/Downloads/ReflectionOrnekClass.dll");
            TypeHandler typehandler = new TypeHandler(assemblyReader.GetAssembly());
            typehandler.TypeSender();
        }
    }
}
