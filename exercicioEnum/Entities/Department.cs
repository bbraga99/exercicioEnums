using System;

namespace exercicioEnum.Entities
{
    internal class Department
    {
        public string Name { get; set; }

        public Department()
        {
        }//constructor padrao

        public Department(string name)
        {
            Name = name;
        }// constructor recebendo o nome
    }
}
