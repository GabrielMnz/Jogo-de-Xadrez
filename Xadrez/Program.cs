﻿// See https://aka.ms/new-console-template for more information
using System;
using tabuleiro;
using tabuleiro.Enums;
using xadrez;
using Xadrez;


try {
    PartidaDeXadrez partida = new PartidaDeXadrez();

    while (!partida.terminada) {

        try {
            Console.Clear();
            Tela.imprimirPartida(partida);

            Console.WriteLine();
            Console.Write("Origem: ");
            Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
            partida.validarPosicaodeOrigem(origem);

            bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

            Console.Clear();
            Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

            Console.WriteLine();
            Console.Write("Destino: ");
            Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
            partida.validarPosicaodeDestino(origem, destino);

            partida.realizaJogada(origem, destino);
        }
        catch (TabuleiroException e) {
            Console.WriteLine(e.Message);
            Console.ReadLine();
        }
    } 

    
} catch (TabuleiroException e) {
    Console.WriteLine(e.Message);
}


Console.ReadLine();