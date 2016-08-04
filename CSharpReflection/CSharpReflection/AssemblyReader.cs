using System.Reflection;

namespace CSharpReflection
{
    class AssemblyReader
    {
        private Assembly Assembly;

        public AssemblyReader(string sourceLocation)
        {
            Assembly = Assembly.LoadFile(sourceLocation);
        }

        public Assembly GetAssembly()
        {
            return Assembly;
        }
    }
}
