using System;
using System.Collections.Generic;
using System.Text;

namespace validadordeCPF
{
    class ValidacaoCpf
    {
        public static bool Verificar(string cpf)
        {
            int[] verificarOdigito = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2, };
            int[] verificado2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, };
            string CPF1, CPF2;
            int soma, resultado;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", ""); //Para apenas mostra os numeros

            if (cpf.Length != 11)
                return false;

            CPF1 = cpf.Substring(0, 10); // Numero informado pelo usuario
            //Substring vai conta ate a 10 possição
            soma = 0;
            for (int a = 0; a < 9; a++)
                soma += int.Parse(CPF1[a].ToString()) * verificarOdigito[a];
            resultado = soma % 11; //Recebe o resto da divisao

            if (resultado < 2)
            {
                resultado = 0;
            }
            else
            {
                resultado = 11 - resultado;
            }
            CPF2 = resultado.ToString(); // recebe o primeiro digito vertificador
            CPF1 = CPF1 + CPF2;

            soma = 0; // resetar a variavel soma
            for (int b = 0; b < 10; b++)
                soma += int.Parse(CPF1[b].ToString()) * verificado2[b];
            resultado = soma % 11;

            if (resultado < 2)
            {
                resultado = 0;
            }
            else
            {
                resultado = 11 - resultado;
            }
            CPF2 = CPF2 + resultado.ToString();
            return cpf.EndsWith(CPF2); // buscando o cpf2  retornando pra variavel bool
        }
    }
}
