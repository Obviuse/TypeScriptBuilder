﻿namespace TypeScriptBuilder
{
    public class TypeScriptGeneratorOptions
    {
        public bool UseCamelCase = true;    // changes fields names: TestField1 -> testField1
        public bool EmitIinInterface = true; // use I in interface names: MyData -> IMyData
        public bool EmitReadonly = true;    // emits readonly for readonly fields (need TypeScript 2.0)
        
        /// <summary>
        /// Emits comments with original C# type
        /// </summary>
        public bool EmitComments = false;    
        
        /// <summary>
        /// Emits documentation comments from assembly XML-file (if found)
        /// </summary>
        public bool EmitDocumentation = true;
        
        /// <summary>
        /// Creates models without any namespaces.
        /// </summary>
        public bool IgnoreNamespaces = false; // ignores namespace in emissions

        /// <summary>
        /// Use this to have dates typed as string. Useful since JSON-serialization of C# DateTime will be a string.
        /// </summary>
        public bool DatesAsString = false;

    }
}
