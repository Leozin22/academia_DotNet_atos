﻿namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,Pessoa> lista = new Dictionary<int,Pessoa>();
            Dictionary<int, Aluno> listaAlunos = new Dictionary<int, Aluno>();
            Util util = new Util();
            string nomeArquivo = @"C:\Users\leosc\OneDrive\Área de Trabalho\Academia_DotNet_Atos\Arquivos\Desafio_1.txt";
            util.popularLista(lista,listaAlunos, nomeArquivo);


            Console.WriteLine("Foram criados "+listaAlunos.Count+" objetos aluno e "+lista.Count+" objetos pessoa");
            Console.WriteLine("-----------------------------------------------------");
            foreach(var item in listaAlunos)
            {
                Console.WriteLine(" Nome:"+ item.Value.Nome+" Curso: "+item.Value.NomeDoCurso);
                Console.WriteLine("-----------------------------------------------------");
            }




        }
    }
}