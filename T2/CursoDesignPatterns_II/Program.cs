using CursoDesignPatterns_II.Cap2;
using CursoDesignPatterns_II.Cap3;
using CursoDesignPatterns_II.Cap4;
using CursoDesignPatterns_II.Cap5;
using CursoDesignPatterns_II.Cap6;
using CursoDesignPatterns_II.Cap7;
using CursoDesignPatterns_II.Cap8;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CursoDesignPatterns_II
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente();
            cliente.Nome = "Guilherme";
            cliente.Endereco = "Luiza Lucas";
            cliente.DataNascimento = DateTime.Now;

            String xml = new GeradorDeXml().GeraXml(cliente);

            Console.WriteLine(xml);
            Console.ReadKey();
        }
    }
}
