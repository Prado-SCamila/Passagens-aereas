using System;

namespace Passagens_aereas
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha;
            string[]nomes =new string[5];
            string[]origem = new string[5];
            string[]destino = new string[5];
            string[]data = new string[5];
            string resposta;

            Console.WriteLine("---------------------------");
            Console.WriteLine("Sistema de Passagens Aéreas");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Digite sua senha");
            senha = Console.ReadLine();

            EfetuarLogin(senha);

            bool EfetuarLogin(string senha){

                bool senhaValida = false;
                do{
                    if(senha == "123456"){
                    return true;
                    }else{ Console.WriteLine("senha incorreta");
                    }
                }while (!senhaValida);
                    return false;
            }
            bool senhaValida;
            do{
                Console.WriteLine("Digite sua senha");
                senha = Console.ReadLine();
                senhaValida = EfetuarLogin(senha);
            }while(!senhaValida);
                int escolha;
                int contador = 0;
            
            //Criar menu
            do{
                Console.WriteLine("Menu inicial");
                Console.WriteLine("Selecionar uma opção");
                Console.WriteLine("[1]- Cadastrar Passagens");
                Console.WriteLine("[2]- Listar Passagens");
                Console.WriteLine("[0]- Sair");
                escolha = int.Parse(Console.ReadLine());
            
            switch(escolha)
            {
                case 1:
                                                           
                    do{
                        if(contador<5){
                            Console.WriteLine($"Digite o nome do {contador+1}º Passageiro");
                            nomes [contador]= Console.ReadLine();
                            Console.WriteLine($"Digite a origem do {contador+1}º Passageiro");
                            origem [contador]= Console.ReadLine();
                            Console.WriteLine($"Digite o destino do {contador+1}º Passageiro");
                            destino[contador]= Console.ReadLine();
                            Console.WriteLine($"Digite a data do vôo do {contador+1}º Passageiro");
                            data[contador]= Console.ReadLine();
                            contador++;
                            
                        }else{ Console.WriteLine("Limite de Passagens Excedido");
                         break;
                         }
                         Console.WriteLine("Gostaria de Cadastrar um novo passageiro? s/n? ");
                         resposta = Console.ReadLine();
                    }while(resposta =="s");
                                    
                         break;
                case 2:
                
                        for(var i =0; i< 5; i++){
                            Console.WriteLine($"{nomes[i]}");
                            Console.WriteLine($"{origem[i]}");
                            Console.WriteLine($"{destino[i]}");
                            Console.WriteLine($"{data[i]}");
                        }
                        break;

                case 0:
                        //sair
                        break;

                default:
                       break;
                       
                }       
            
            }while(escolha!=0);
                    
        }
    }
}
        

    


    

        
    

