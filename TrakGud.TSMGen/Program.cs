using System;
using TrakGud.DAL.Models;
using TypeScriptBuilder;

namespace TrakGud.TSMGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converting C# Models to TypeScript Models:\n");

            var ts = new TypeScriptGenerator();

            Type CSharpModel__type = typeof(CmAddress);
            Console.WriteLine("Converting " + CSharpModel__type.Name + " to TypeScript Model in file api-models.ts");

            // add types you need (dependant types will be added automatically)
            ts.AddCSType(CSharpModel__type);

            // get generated code as string
            ts.ToString();

            // or write to file
            ts.Store("api-models.ts");
        }
    }
}
