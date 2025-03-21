using System;
using System.Reflection.Metadata.Ecma335;
using Bogus;
using Spectre.Console;
using WorkerInfo;

namespace WorkerTable
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Randomizer.Seed = new Random(int.Parse(args[0]));
            Table tabela = new Table();
            tabela.AddColumn("ID");
            tabela.AddColumn("Name");
            tabela.AddColumn("Job");

            Faker fakerInfo = new Faker("pt_PT");

            WorkerClass[] workers = new WorkerClass[(int.Parse(args[0]))];

            for (int i = 0; i < int.Parse(args[0]); i++)
            {
                tabela.AddRow(fakerInfo.Random.Number(0, 1000).ToString(), fakerInfo.Name.FullName(), fakerInfo.Name.JobTitle());
            }

            AnsiConsole.Write(tabela);



        }
    }
}
