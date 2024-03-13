namespace ATV3_CJ3021912
{
    [TestClass]
    public class atividade
    {
        [TestMethod]
        public void TestMethod1()
        {
            //exercicio 1
            Console.WriteLine("exercicio 1");
            int num;
            Console.WriteLine("insira um numero.");
            num = int.Parse(Console.ReadLine());
            if (num / 2 == 0)
            {
                Console.WriteLine("seu numero é par.\n");
            }
            else
            {
                Console.WriteLine("seu numero é impar\n.");
            }

            //exercicio 2
            Console.WriteLine("exercicio 2");
            float lado1, lado2, lado3;
            Console.WriteLine("insira o tamanho do lado 1.");
            lado1 = float.Parse(Console.ReadLine());
            Console.WriteLine("insira o tamanho do lado 2.");
            lado2 = float.Parse(Console.ReadLine());
            Console.WriteLine("insira o tamanho do lado 3.");
            lado3 = float.Parse(Console.ReadLine());
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("este triangulo é equilatero\n");
            }
            else
            {
                if (lado1 != lado2 && lado2 != lado3 && lado3 != lado1)
                {
                    Console.WriteLine("este triangulo é escaleno\n");
                }
                else
                {
                    Console.WriteLine("este triangulo é isosceles\n");
                }
            }

            //exercicio 3
            Console.WriteLine("exercicio 3");
            int jogador, computador;
            Console.WriteLine("insira um numero de 1 a 100");
            jogador = int.Parse(Console.ReadLine());
            Random gerador = new Random();
            computador = gerador.Next(1,100);
            if (jogador == computador) {
                Console.WriteLine("voce ganhou");
            }else
            {
                if(jogador > computador)
                {
                    Console.WriteLine("o numero escolhido pelo computador é maior que este, escolha outro.");
                    jogador = int.Parse(Console.ReadLine());
                }else
                {
                    if(jogador < computador)
                    {
                        Console.WriteLine("o numero escolhido pelo computaor é menor que este, escolha outro numero.");
                        jogador = int.Parse(Console.ReadLine());
                    }
                }
            }
            //exercicio 4
            Console.WriteLine("exercicio 4");
            string usuario, senha, usuario_atual = "admin", senha_atual = "admin123";
            Console.WriteLine("insira seu nome de usuario");
            usuario = Console.ReadLine();
            Console.WriteLine("insira sua senha");
            senha = Console.ReadLine();
            if(usuario != usuario_atual && senha != senha_atual) {
                Console.WriteLine("acesso negado\n");
            }else
            {
                Console.WriteLine("acesso concedido\n");
            }
            //exercicio 5
            Console.WriteLine("exercicio 5");
            int nota;
            Console.WriteLine("insira uma nota de 0 a 100");
            nota = int.Parse(Console.ReadLine());
            if(nota < 0 || nota > 100) {
                Console.WriteLine("nota invalida\n");
            }else
            {
                if(nota >= 90) {
                    Console.WriteLine("sua nota é A\n");
                }else
                {
                    if(nota >= 80)
                    {
                        Console.WriteLine("sua nota é B\n");
                    }else
                    {
                        if (nota >= 70)
                        {
                            Console.WriteLine("sua nota é C\n");
                        }else
                        {
                            if(nota >= 60)
                            {
                                Console.WriteLine("sua nota é D\n");

                            }else
                            {
                                if (nota < 60)
                                {
                                    Console.WriteLine("sua nota é F\n");
                                }
                            }
                        }
                    }
                }
            }
            //exercicio 6
            Console.WriteLine("exercicio 6");
            // 1 - pedra 2 - papel 3 - tesoura
            int player, computer;
            Console.WriteLine("escolha pedra, pepel ou tesoura");
            player = int.Parse(Console.ReadLine());
            Random generator = new Random();
            computer = generator.Next(1,3);
            if(player < 1 || player > 3)
            {
                Console.WriteLine("escolha invalida\n");

            }else
            {
                if(player == computer)
                {
                    Console.WriteLine("empate\n");
                }else
                {
                    if(computer == 1 &&  player == 2) {

                        Console.WriteLine("jogador ganhou\n");
                    }else
                    {
                        if(computer == 1 && player == 3)
                        {
                            Console.WriteLine("computador ganhou\n");
                        }
                        else
                        {
                            if(computer == 2 && player == 1) {
                                Console.WriteLine("computador ganhou\n");
                            }
                            else
                            {
                                if(computer == 2 && player == 3) {
                                    Console.WriteLine("jogador ganhou\n");
                                }
                                else
                                {
                                    if(computer == 3 && player == 1) {
                                        Console.WriteLine("jogador ganhou\n");
                                    }else
                                    {
                                        if(computer == 3 && player == 2) {
                                            Console.WriteLine("computador ganhou\n");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //exercicio 7
            Console.WriteLine("exercicio 7");
            float desconto, valor_total;
            Console.WriteLine("insira o valor da compra");
            valor_total = float.Parse(Console.ReadLine());
            if(valor_total > 100)
            {
                desconto = (valor_total / 100) * 10;
                Console.WriteLine("seu valor de desconto é de: "+  desconto+" reais\n");
            }else
            {
                if (valor_total > 200)
                {
                    desconto = (valor_total / 100) * 20;
                    Console.WriteLine("seu valor de desconto é de: " + desconto + " reais\n");
                }else
                {
                    if(valor_total > 300)
                    {
                        desconto = (valor_total / 100) * 30;
                        Console.WriteLine("seu valor de desconto é de: " + desconto + " reais\n");
                    }else
                    {
                        if(valor_total > 400)
                        {
                            desconto = (valor_total / 100) * 40;
                            Console.WriteLine("seu valor de desconto é de: "+ desconto + " reais\n");
                        }
                    }
                }
            }
            //exercicio 8
            Console.WriteLine("exercicio 8");
            float peso, altura, IMC;
            Console.WriteLine("insira seu peso");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("insira sua altura");
            altura = float.Parse(Console.ReadLine());
            IMC = peso / (altura * altura);
            if (IMC < 18.5)
            {
                Console.WriteLine("voce esta abaixo do peso");
            }else
            {
                if(IMC >= 18.5)
                {
                    Console.WriteLine("voce tem o peso normal");
                }else
                {
                    if (IMC >= 25)
                    {
                        Console.WriteLine("voce esta com sobrepeso");
                    }else
                    {
                        if(IMC >= 30)
                        {
                            Console.WriteLine("voce tem obesidade de grau 1");
                        }else
                        {
                            if(IMC >= 35)
                            {
                                Console.WriteLine("voce tem obesidade de grau 2");
                            }
                            else
                            {
                                if(IMC >= 40)
                                {
                                    Console.WriteLine("voce tem obesidade de grau 3");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}