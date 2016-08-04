using System.Collections.Generic;
using System.Reflection;

namespace CSharpReflection
{
    class PropertyWriter
    {
        PropertyInfo[] propertys;

        public PropertyWriter(PropertyInfo[] propertys)
        {
            this.propertys = propertys;
        }

        public List<PropertyElements> Writer()
        {
            List<PropertyElements> propertyelements = new List<PropertyElements>();

            foreach (var property in propertys)
            {
                PropertyElements propertyelement = new PropertyElements();
                propertyelement.propertyName = property.Name;
                propertyelement.propertyTypeFullName = property.PropertyType.FullName;
                propertyelement.propertyReturnType = property.PropertyType.Name;
                propertyelement.propertyType = property.PropertyType;

                propertyelements.Add(propertyelement);
            }

            return propertyelements;
        }
    }
}
