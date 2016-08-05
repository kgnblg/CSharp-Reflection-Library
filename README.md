# ReflectionTeamWork

This project created with .NET Framework, using Reflection. By this project, you can take a DLL file and take all classes, structs, enums, fields and properts in an "Elements" array.

"Elements" array have 3 field arrays;

- ClassElements: ClassElements is a Generic list for taking all classes in DLL file. It has 4 fields. (className, classNamespace, Generic List <FieldElements>, Generic List <PropertyList>.
- EnumElements: EnumElements is a Generic list for taking all enums in DLL file. It has 3 fields. (enumName, enumNamespace, Generic List <EnumFields>)
- StructElements: StructElements is a Generic list for taking all structs in DLL file. It has 3 fields. (structName, structNamespace, Generic List <StructFields>)

The "Writer" classes are taking data from DLL and write this data to arrays.

TypeHandler class, sending Types to classes for that job.



