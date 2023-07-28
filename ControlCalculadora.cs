using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class ControlCalculadora
    {   
        //Criando um objeto calculadora na memoria
        ModelCalculadora calculadora = new ModelCalculadora();

        public ControlCalculadora() 
        {
            this.calculadora = new ModelCalculadora(); //a variavel calculadora é a representaçao do objeto
        }//Fim do construtor 

        public void Coletar()
        {
            Console.WriteLine("Iinforme um numero: ");
            this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Informe outro numero: ");
            this.calculadora.GetSetNum2 = Convert.ToDouble(Console.ReadLine());
        }//Fim do Coletar

        public void Coleta()
        {
            Console.WriteLine("Informe um numero: ");
            this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
                
        }//Fim do coleta

        //Criar um menu
        public int Menu()
        {
            Console.WriteLine("-------- Menu --------"                                      +
                              "\n"                                                          +
                              "\n0.  Sari"                                                  +
                              "\n1.  Somar"                                                 +
                              "\n2.  Subtrair"                                              +        
                              "\n3.  Dividir"                                               +         
                              "\n4.  Multiplicar"                                           +
                              "\n5.  Potencia"                                              +
                              "\n6.  Raiz"                                                  +
                              "\n7.  Tabuada"                                               +
                              "\n8.  Decimal para Binario"                                  +
                              "\n9.  Binario para Decima"                                   +
                              "\n10. Decimal para Hexadecimal"                              +
                              "\n11. Hexadecimal para Decimal"                              +
                              "\n12. Equação do 2° Grau"                                    +
                              "\n13. Binario para hexa"                                     +
                              "\n\n|---- EXERCICIOS DA AULA ----|"                          +
                              "\n"                                                          +
                              "\n14. Dobro e o triplo do numero"                            +
                              "\n15. Salario Aumento de 30%"                                +
                              "\n16. Numero par ou impar e negativo ou positivo"            +
                              "\n17. Soma de numeros Inteiros de 1 a 100"                   +
                              "\n18. Tabuada de 1 a N"                                      +
                              "\n19. Numero Final e Inicial"                                +
                              "\n20. Numeros Impares de 100 a 200"                          +
                              "\n21. Soma de todos os numeros Inteiros Informado"           +  
                              "\n22. Mesmo que o EX anterior so que para ao digitar 0"      +
                              "\n23. Valores inteiros e encontra o maior e o menor deles"   +
                              "\n24. Algoritimo que le 20 valores inteiros"                 +
                              "\n25. (13)"+
                              "\n26. (14)"+
                              "\n27. (15)"+
                              "\n28. (16)"+
                              "\n29. (17)"+
                              "\n30. (18)"+
                              "\n31. (19)"+
                              "\n32. (20)"+
                              "\n\n  Escolha uma das opçoes acima: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }//Fim do metodo Menu


        public void Operacao()
        {
             int opcao = 0;
            do
            {

                opcao = Menu();

                Console.Clear(); //limpa tela

                switch (opcao)
                {

                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Coletar();
                        Console.WriteLine("Soma: " + this.calculadora.Somar());
                        break;
                    case 2:
                        Coletar();
                        Console.WriteLine("Subtracao: " + this.calculadora.Subtrair());
                        break;
                    case 3:
                        Coletar();
                        if (this.calculadora.Dividir() == 1)
                        {
                            Console.WriteLine("Inpossivel dividir!");
                        }
                        else
                        {
                            Console.WriteLine("Divisao: " + this.calculadora.Dividir());
                        }
                        break;
                    case 4:
                        Coletar();
                        Console.WriteLine("Multiplicar: " + this.calculadora.Multiplicar());
                        break;

                    case 5:
                        Coletar();
                        Console.WriteLine("Potencia: " + this.calculadora.Potencia());
                        break;
                    case 6:
                        Coletar();
                        Console.WriteLine("Raiz: " + this.calculadora.Raiz());
                        break;

                    case 7:
                        Coletar();

                        Console.WriteLine("Informe um numero: ");
                        this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaNum1());
                        break;

                    case 8:
                        Console.WriteLine(this.calculadora.DecimalBinario(Console.ReadLine()));
                        break;

                    case 9:
                        Console.WriteLine("Informe o numero binário: ");
                        string valor = Console.ReadLine();
                        int resultado = Convert.ToInt32(ModelCalculadora.BinarioDecimal(valor));
                        Console.WriteLine($" O numero {valor} é igual a {resultado} ");
                        Console.WriteLine();
                        break;

                    case 10:
                        Console.WriteLine("Informe um valor em Hexadecimal: ");
                       // Console.WriteLine(this.calculadora.ConverterHexaDecimal(Console.ReadLine()); //precisa arrumar aq colocar algo enrto o parenteses
                        break; 
                    
                    case 11:
                        Console.WriteLine("Informe o numero binário: ");
                        //Console.WriteLine(this.calculadora.ConverterDecimalHexa(Convert.ToInt32()));
                        break;

                    case 12:
                        Coletar();
                        if (this.calculadora.X1() == -1)
                        {
                            Console.WriteLine("Delta Negativo!");
                        }
                        else
                        {
                            Console.WriteLine("Delta: " + this.calculadora.Delta());
                            Console.WriteLine("X1: " + this.calculadora.X1());
                            Console.WriteLine("X2: " + this.calculadora.X2());
                        }
                        break;

                    case 13:
                        Console.WriteLine("Informe o numero binário: ");
                        string binario = Console.ReadLine();
                        Console.WriteLine(this.calculadora.ConverterBinarioHexadecimal(binario));
                        break;
                        default:
                        Console.WriteLine("Opçao escolhida nao é valida");
                        break;



                    //   eeeeee     x   x    eeeeee     rrrrr    ccccccc    ii   ccccccc    ii    oooooooo    ssssssss  
                    //   ee          x x     ee         r   r    cc         ii   cc         ii    oo    oo    ss
                    //   eeee         x      eeee       rrrrr    cc         ii   cc         ii    oo    oo    ssssssss  
                    //   ee          x x     ee         r   r    cc         ii   cc         ii    oo    oo          ss
                    //   eeeeee     x   x    eeeeee     r    r   ccccccc    ii   ccccccc    ii    oooooooo    ssssssss
                    
                    
                    //EX 1
                    case 14:
                        Console.WriteLine("Digite um número:");
                        int numero = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dobro: " + (numero * 2));
                        Console.WriteLine("Triplo: " + (numero * 3));
                        Console.ReadLine();
                        break;

                    //EX 2
                    case 15:
                        Coleta();
                        Console.WriteLine("O valor em 30% que tera que ser aumentado sera de: " + this.calculadora.PorcentagemDoSalario());
                        break;

                    //EX 3
                    case 16:
                        Console.Write("Informe um número: ");
                        int number = int.Parse(Console.ReadLine());
                        ModelCalculadora numberHelper = new ModelCalculadora();
                        string result = numberHelper.NumeroNegPos(number);
                        Console.WriteLine(result);
                        break;

                    //EX 4
                    case 17:
                        ModelCalculadora modelCalculadora = new ModelCalculadora();
                        int comeco = 1;
                        int fim = 100;
                        int soma = modelCalculadora.SomaInteiros(comeco, fim);
                        Console.WriteLine($"A soma dos números inteiros de {comeco} a {fim} é: {soma}");
                        break;

                    //EX 5
                    case 18:
                        Coleta();

                        Console.WriteLine("Informe um numero: ");
                        this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaN1());
                        break;

                    //EX 6 
                    case 19:
                        Console.WriteLine("Informe um numero: ");
                        int n1 = Convert.ToInt32(Console.ReadLine());   

                        Console.WriteLine("Informe um numero: ");
                        int n2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.calculadora.InicialFinal(n1 , n2));
                        break;

                    //EX 7
                    case 20:
                        Console.WriteLine(this.calculadora.ImparesDe100a200());
                        break;

                    //EX 8
                    case 21:
                        Coleta();
                        Console.WriteLine(this.calculadora.Soma10Inteiros());
                        break;

                    //EX 9
                    case 22:
                        Console.WriteLine("Soma dos números até digitar 0: " + this.calculadora.SomaNumeros());
                        break;

                    //EX 10
                    case 23:
                        double media = this.calculadora.MediaPar();
                        if (media != 0)
                            Console.WriteLine("Média dos números pares: " + media);
                        break;

                    //EX 11
                    case 24:

                        break;

                    //EX 12
                    case 25:
                        Console.WriteLine(this.calculadora.SomaPositivo());
                        break;

                    //EX 13
                    case 26:

                        break; 
                    
                    //EX 14
                    case 27:

                        break; 
                    
                    //EX 15
                    case 28:
                    
                        break;
    
                    //EX 16
                    case 29:

                        break;

                    //EX 17
                    case 30:

                        break;

                    //EX 18
                    case 31:

                        break;

                    //EX 19
                    case 32:

                        break;

                    //EX 20
                    case 33:

                        break;
                }//FIm so switch
            }  while(opcao != 0); //Fim do...While
        }//FIm do operacao

    }//Fim da classe

}//Fim do projeto
