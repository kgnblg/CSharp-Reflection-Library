using System.Reflection;

namespace CSharpReflection
{
    public class AssemblyReader
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
