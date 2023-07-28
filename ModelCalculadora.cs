using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class ModelCalculadora
    {
        //Declarando Variaveis
        private double num1;
        private double num2;
        private double num3;
        
        //Metodo construtor
        public ModelCalculadora() 
        {
            GetSetNum1= 0; //Valor inicial é 0
            GetSetNum2= 0;
            GetSetNum3= 0;
        }//Fim do Construtor

        //Metodoas gets e sets
        public double GetSetNum1
        {
            get { return this.num1; }
            set { this.num1 = value; }
        } //Fim do get e set num1

        public double GetSetNum2
        { 
          get { return this.num2; } 
          set { this.num2 = value; } 
        }//Fim do get e set num2

        public double GetSetNum3 
        {
            get { return this.num3; }
            set { this.num3 = value; }       
        }//Fim do get e set num3

        public static string ReverteString(string str)
        {                                                       //sdvbsdbv/]//]/]/]/]/]/]/]/]/]/]/
            return new string(str.Reverse().ToArray());        //sdvbsdbv/]//]/]/]/]/]/]/]/]/]/]/
        }//fim do reverte string
            

        //Metodos
        public double Somar() 
        { 
            return GetSetNum1 + GetSetNum2;
        }//Fim do metodo Somar

        public double Subtrair()
        {
            return GetSetNum1 - GetSetNum2;
        }//Fim do metodo subritair

        public double Dividir()
        {
            if (GetSetNum2 <= 0)
            {
                return -1;
            }
            else
            {
                return GetSetNum1 / GetSetNum2;
            }
        }//Fim do metodo Dividir

        public double Multiplicar()
        { 
            return GetSetNum1 * GetSetNum2;
        }//Fim do metodo multiplicar

        public double Potencia()
        {
            return Math.Pow(GetSetNum1, GetSetNum2); // Pow é de potencia
        }//Fim da Potencia

        public string Raiz()
        {
            string msg = "Raiz do primeiro numero: " + Math.Sqrt(GetSetNum1) +
                         "\n Raiz do segundo numero: " + Math.Sqrt(GetSetNum2);
            return msg;
        }//Fim do metodo Raiz

        public string TabuadaNum1()
        {
            string resultado = "";

            for(int i = 0; i <= 10; i++) // i++ é uma variavel acumuladora ex i+3 vai contando de 3 em 3 
            {

                resultado += GetSetNum1 + " * " + i + " = " + (GetSetNum1 * i); //+= serve para concatenar a linha ao inves de colocar resultado = resultado
                
            }//Fim do for
            
            return resultado;
        }//Fim do metodo tabuada

        public string TabuadaNum2()
        {
            string resultado = "";

            for (int i = 0; i <= 10; i++) // i++ é uma variavel acumuladora ex i+3 vai contando de 3 em 3 
            {

                resultado += GetSetNum2 + " * " + i + " = " + (GetSetNum2 * i); //+= serve para concatenar a linha ao inves de colocar resultado = resultado

            }//Fim do for

            return resultado;
        }//Fim do metodo tabuada


        public int DecimalBinario(string binario)
        {
            int dec = 0;
            string caract = "";
            int tamanho = binario.Length;
            int pote = tamanho;

            for (int i=0; i < tamanho; i++)
            {
                pote--;
                caract = binario.Substring(i, 1);
                if (caract == "1")
                {
                    dec += Convert.ToInt32(Math.Pow(2, pote));
                }
            }//Fim do for
            return dec;
        }//Fim do metodo converter decimal


        public static int BinarioDecimal(string numBinario)
        {
            int expoente = 0;
            int numero;
            int soma = 0;                                                           //svdvsdvdfvafvadfvfa/]/]/]/]//]/]/]//]/]
            string numeroInvertido = ReverteString(numBinario);                     //cacacdcacddsacacvavdvs]]/]]/]]/]/]//]/                    
            for (int i = 0; i < numeroInvertido.Length; i++)
            {
                numero = Convert.ToInt32(numeroInvertido.Substring(i, 1));
                soma += numero * (int)Math.Pow(2, expoente);
                expoente++;
            }
            return soma;
        }//fim do binario para decimal

        
        public double ConverterHexaDecimal(string hexadecimal)
        {
            double dec = 0;
            string caract = "";
            int num = 0;
            int tamanho = hexadecimal.Length;
            int pote = tamanho;
            for (int i = 0; i < tamanho; i++)
            {
                pote--;
                caract = hexadecimal.Substring(i, 1);
                switch (caract) 
                {
                    case "A":
                        num = 10;
                        break;
                    case "B":
                        num = 11;
                        break;
                    case "C":
                        num = 12;
                        break;
                    case "D":
                        num = 13;
                        break;
                    case "E":
                        num = 14;
                        break;
                    case "F":
                        num = 15;
                        break;
                }//Fim do switch
                dec += num * Math.Pow(16, pote);
            }//Fim do For
            return dec;
        }//fim do metodo converter decimal


        public string ConverterDecimalHexa(int dec)
        {
            int resto = 0;
            string hexadecimal = "";

            do
            {
                resto = dec % 16;
                switch (resto) 
                {
                    case 10:
                        hexadecimal += "A";
                        break;
                    case 11:
                        hexadecimal += "B";
                        break;
                    case 12:
                        hexadecimal += "C";
                        break;
                    case 13:
                        hexadecimal += "D";
                        break;
                    case 14:
                        hexadecimal += "E";
                        break;
                    case 15:
                        hexadecimal += "F";
                        break;
                    default:
                        hexadecimal += resto;
                        break;
                }//Fim do switch
                dec = dec / 16;

            }   while(dec != 0);
                return new string (hexadecimal.Reverse().ToArray());
        }


        public double Delta()
        {
            return (GetSetNum2 * GetSetNum2) - (4) * (GetSetNum1 * GetSetNum3);
        }//Fim do método Delta


        //Método X1
        public double X1()
        {
            return (-GetSetNum2 + Math.Sqrt(Delta())) / (2 * GetSetNum1);
        }//Fim do método X1


        //Método X1
        public double X2()
        {
            return (-GetSetNum2 - Math.Sqrt(Delta())) / (2 * GetSetNum1);
        }//Fim do método X2

        public string ConverterBinarioHexadecimal(string binario)
        {
            int dec = DecimalBinario(binario);
            string hex = ConverterDecimalHexa(dec);
            return hex;
        }//Fim do metodo ConverterBinarioHexadecimal







        //   eeeeee     x   x    eeeeee     rrrrr    ccccccc    ii   ccccccc    ii    oooooooo    ssssssss  
        //   ee          x x     ee         r   r    cc         ii   cc         ii    oo    oo    ss
        //   eeee         x      eeee       rrrrr    cc         ii   cc         ii    oo    oo    ssssssss  
        //   ee          x x     ee         r   r    cc         ii   cc         ii    oo    oo          ss
        //   eeeeee     x   x    eeeeee     r    r   ccccccc    ii   ccccccc    ii    oooooooo    ssssssss




        //EX 1
        public void NumeroMultiplicado()
        {
            Console.WriteLine("Informe um number: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            double dobro = numero * 2;
            double triplo = numero * 3;

            Console.WriteLine($"O dobro de {numero} é: {dobro}");
            Console.WriteLine($"O dobro de {numero} é: {triplo}");
            
        }//Fim do metodo tabuada    (EX 1)


        
        //EX 2
        public string PorcentagemDoSalario()
        {
            return "" + (GetSetNum1 * 30 / 100);
        }//Fim do Porcentagem do Salario   (EX 2)


        //EX 3
        public string NumeroNegPos(int num)
        {
            string result = "O número ";

            if (num > 0)
                result += "é positivo ";
            else if (num < 0)
                result += "é negativo ";
            else
                result += "é zero.";


            if (num % 2 == 0)
                result += "e o numero é par.";
            else
                result += "e o numero é ímpar.";

            return result;
        }// Fim dos Numeros Negativos POsitivos e pares e impares   (EX 3)


        //EX 4 
        public int SomaInteiros(int comeco, int fim)
        {
            int soma = 0;
            for (int i = comeco; i <= fim; i++)
            {
                soma += i;
            }
            return soma;
        }// fim da Soma dos Inteiros  (EX 4)


        //EX 5 
        public string TabuadaN1()
        {
            string resultado = "";



            for (int i = 1; i <= GetSetNum1; i++)// i++ é uma variavel acumuladora ex i+3 vai contando de 3 em 3 
            {
                resultado += "\n" + 1 + " * " + i + " = " + (1 * i); //+= serve para concatenar a linha ao inves de colocar resultado = resultado
            }//Fim do método For

            return resultado;
        }// Fim do 1 para N       (EX 5)


        //EX 6
        public string InicialFinal(int n1, int n2)
        {
            string resultado = "";

            for (int i = n1; i <= n2; i++)
            {
                resultado += "\n" + (n1 + (1 * i - n1));
            }//Fim do método for

            return resultado;
        }//Fim do Inicial Final         (EX 6)

        //EX 7
        public string ImparesDe100a200()
        {
            string resultado = "";

            // Laço for para percorrer os números de 100 a 200
            for (int i = 101; i <= 199; i += 2)
            {
                Console.WriteLine(i);
            }
            return resultado;

        }//Fim do Numeros Impares de 100 a 200          (EX 7)

        //EX 8
        public int Soma10Inteiros()
        {

            int contador = 0;
            int numS;

            //Início;Fim;Contagem
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Digite um número: ");
                numS = Convert.ToInt32(Console.ReadLine());

                contador += numS;
            }//fim do for

            return contador;
        }//Fim do método Soma de 10 Números Inteiros        (EX 8)

        //EX 9
        public int SomaNumeros()
        {
            int soma = 0;
            Console.WriteLine("Informe numeros Inpares(Para parar digite 0)");

            do
            {
                int num1 = Convert.ToInt32(Console.ReadLine());
                if (num1 == 0)
                    break;

                soma += num1;
            }while(num1 == 0);

            return soma;
        }//Fim da soma dos numeros      (EX 9)

        //EX 10
        public double MediaPar()
        {
            int soma = 0;
            int quantidadePares = 0;

            Console.WriteLine("Informe numeros Pares(Para parar digite 0)");

            while (true)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                    break;

                if (num % 2 == 0)
                {
                    soma += num;
                    quantidadePares++;
                }
            }

            if (quantidadePares == 0)
            {
                Console.WriteLine("Nenhum número par foi digitado.");
                return 0;
            }

            double media = (double)soma / quantidadePares;
            return media;

        }//Fim da media dos numeros pares  (EX 10)

        //EX 11


        //EX 12
        public string SomaPositivo()
        {
            int soma = 0;
            int cont = 0;
            int i = 0;
            string msg = "";
            int numP = 0;
            //Início; Fim; Contagem
            for (i = 1; i <= 20; i++)
            {
                Console.WriteLine(i + "º Número: ");
                numP = Convert.ToInt32(Console.ReadLine());

                if (numP >= 0)
                {
                    soma += numP;
                }
                else
                {
                    cont += 1;
                }
            }//fim do for
            msg = "Soma dos positivos: " + numP + "\nContagem dos negativos: " + cont;
            return msg;
        }//Fim do método Soma Positivo

    }//Fim da classe
}//Fim do Projeto
