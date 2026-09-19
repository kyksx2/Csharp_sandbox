// See https://aka.ms/new-console-template for more information
using System.Data.Common;
using Microsoft.VisualBasic;
using Test;



namespace Test
{
    class Class_Test
    {
        int Id { get; set;}
        string name = "class";
    }

    struct Struct_Test
    {
        private int Id = 2;
        private string name = "struct";
        public Struct_Test() {}
    }

    record Record_Test
    {
        int Id = 3;
        string name = "record"; 
    };

}
