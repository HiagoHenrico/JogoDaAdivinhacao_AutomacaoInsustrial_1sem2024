# JogoDaAdivinhacao_AutomacaoInsustrial_1sem2024
Código fonte jogo acertou perdeu;

Int vez=1, li=1, ls=100, palpite, oculto;

Console.WriteLine(“Jogador neutro: Digite um número entre 1 e 100”);
Oculto = int.Parse(Console.ReadLine());
If(oculto <=1 || oculto >= 100){
     Console.WriteLine(“Jogador neutro:              Digite um número entre 1 e 100”);
Oculto = int.Parse(Console.ReadLine());
}
Else{ 
   Console.WriteLine(“Jogador {0}:              Digite um número entre {1} e {2}”, vez, li, ls);
Palpite = int.Parse(Console.ReadLine());
}

If(palpite <= li || palpite >= ls){

}Else If(palpite = oculto){

}Else If(){}
