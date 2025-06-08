using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBackEnd.Estruturas
{
    internal class Pilha : IEstruturaDeDados
    {
        private int[] dados = new int[10];
        private int topo = -1;
        public void Adicionar()
        {
            Console.Clear();
            Console.WriteLine("======== PILHA -> EMPILHAR <- ========");
            if(topo<dados.Length-1)
            {
                Console.WriteLine("\nDigite o numero que deseja empilhar");
                int num = int.Parse(Console.ReadLine());
                topo++;
                dados[topo] = num;
                Console.WriteLine($"Elemento {num} empilhado com sucesso!");
            } else
            {
                Console.WriteLine("A pilha está lotada!");
                return;
            }
        }

        public void Remover()
        {
            Console.Clear();
            Console.WriteLine("======== PILHA -> DESEMPILHAR <- ========");

            if(topo == -1) 
            {
                Console.WriteLine("A pilha está vazia!");
            } else
            {
                Console.WriteLine($"ultimo elemento {topo} desempilhado com sucesso!");
                topo--;
                Thread.Sleep(2000);
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("======== PILHA -> IMPRIMINDO <- ========");
            for (int i=topo; i>0; i--)
            {
                Console.WriteLine($"{dados[i]}\n");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();

        }

        public void Aprender()
        {
            Console.WriteLine("======== PILHA -> APRENDENDO <- ========");
            Console.WriteLine("PILHAS-> Você só consegue inserir novos elementos, no topo da pilha! O primeiro a entrar é o último a sair\n");
            Console.WriteLine("PILHAS EM C -> A inserção de elementos numa pilha em C, ocorre apenas no topo da pilha. Lá, usamos uma estrutura chamada struct e ponteiros para isso\n");
            Console.WriteLine("PILHAS EM C# -> Aqui, usamos classes ao invés de struct's e ponteiros, até porque aqui, o gerenciamento de memória ocorre por de baixo dos panos - Não precisamos chamar 'free' ou 'delete', o coletor de lixo faz isso");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();

        }
        public void Menu()
        {
            int op;
            do
            {
                Console.WriteLine("======== PILHA ========");
                Console.WriteLine("\nEscolha uma das opções:");
                Console.WriteLine("1.Empilhar\n2.Desempilhar\n3.Imprimir\n4.Aprender\n5.Voltar ao menu inicial");
                op = int.Parse(Console.ReadLine());

                    switch(op)
                {
                    case 1:
                        Adicionar();
                        break;
                    case 2:
                        Remover();
                        break;
                    case 3:
                        Imprimir();
                        break;
                    case 4:
                        Aprender();
                        break;
                }

            } while (op != 5);
            

        }
    }
}

/*
Resumo do que foi aplicado neste projeto:

Utilizamos o conceito de polimorfismo através de uma interface, que define métodos obrigatórios para estruturas diferentes (pilha, fila, lista), permitindo que cada classe implemente suas próprias versões desses métodos. Isso difere da herança tradicional, onde o código é reaproveitado diretamente.

Ao contrário de C, onde usamos struct e ponteiros para manipular estruturas, em C# utilizamos classes, com gerenciamento automático de memória.

A pilha foi implementada manualmente com um vetor de tamanho fixo e um controle de topo. A função de adicionar incrementa o topo e armazena o novo valor. A função de remover apenas decrementa o topo, simulando a exclusão do último elemento inserido. Já a função de imprimir percorre o vetor do topo até o início, respeitando a ordem da pilha (LIFO).

Esse projeto serve como base prática para reforçar o entendimento das estruturas de dados e os princípios de orientação a objetos em C#.
*/

