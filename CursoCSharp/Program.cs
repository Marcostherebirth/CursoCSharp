using System;
using System.Collections.Generic;
using CursoCSharp.Estrutura_de_Controle;
using CursoCSharp.Fundamentos;
using CursoCSharp.Classes_e_Métodos;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Estudos;
using static CursoCSharp.ClassesEMetodos.Moto;
using static CursoCSharp.Estudos.Moto;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formantando Numeros - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritiméticos - Fundamentos", OporadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternários - Fundamentos", OperadorTernario.Executar},
                
                //Estrutura de Controle
                {"Estrutura do If - Estrutura de Controle", EstruturaIF.Executar},
                {"Estrutura do If e Else - Estrutura de Controle", EstruturaIfElse.Executar},
                {"Estrutura do If e Else/If - Estrutura de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura do Switch - Estrutura de Controle", EstruturaSwitch.Executar},
                {"Estrutura do While - Estrutura de Controle", EstruturaWhile.Executar},
                {"Estrutura DO/While - Estrutura de Controle", EstruturaDOWhile.Executar},
                {"Estrutura For - Estrutura de Controle", EstruturaFor.Executar},
                {"Estrutura For Each - Estrutura de Controle", EstruturaForEach.Executar},
                {"Estrutura Usando Break - Estrutura de Controle", UsandoBreak.Executar},
                {"Estrutura Usando Continue - Estrutura de Controle", UsandoContinue.Executar},
                

               
                
                //Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Pessoas - Classes e Métodos", Pessoa.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parâmetros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"GetSet - Classes e Métodos", GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"Readonly - Classes e Métodos", Readonly.Executar},
                {"Enum - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct vs Classes - Classes e Métodos", StructVsClasse.Executar},
                {"Valor vs Referência - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parâmetros por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parâmetro com Valor Padrão - Classes e Métodos", ParametroPadrao.Executar},


                // Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Array List - Coleções", ColecoesArrayList.Executar},
                {"Set  - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecaoStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},

                // OO
                {"Herança - OO", Heranca.Executar},


                
                
                
                
                
                //Estudos
                //{"Estudos - imc", IMC.Executar},
                //{"Estudos - Calulo Massa Radioativa", CalculoMassaRadiotiva.Executar},
                {"Estudos - Percorrer Percurso", PercorrerPercurso.Executar},
                //{"Estudos - Família", Familia.Executar},
                //{"Estudos - GetSet", GetSetEstudo.Executar},
                //{"Estudos - AcerteONúmero", EstudoDoWhile.Executar},
                //{"Estudos - Apresentar Família", AFamilia.Executar},
                //{"Estudos - Apresentar Pessoa", PessoasApresentar.Executar},
                //{"Estudos - Construtores", ConstrutoresEstudo.Executar},
                //{"Estudos - Somar Em Cadeia", ResultadoEmCadeia.Executar},
                //{"Estudos - Array", EstudoArray.Executar},




            });

            central.SelecionarEExecutar();
        }
    }
}