using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcoes
{
    class FuncoesBLL
    {
        public static void validadados(Funcoes funcoes)
        {
            Erro.setErro(false);

            if (funcoes.getTxt_1().Length == 0)
            {
                Erro.setErro("O campo é de preenchimento obrigatório...");
                return;
            }
            else { funcoes.getTxt_1(); }

                try
                {
                    float.Parse(funcoes.getTxt_1());
                    funcoes.getTxt_1();
                }

                catch
                {
                    Erro.setErro("O campo deve ser numérico...");
                    return;
                }

        }

        public static void validadados2(Funcoes funcoes)
        {
            Erro.setErro(false);

            if (funcoes.getTxt_1().Length == 0)
            {
                Erro.setErro("O campo é de preenchimento obrigatório...");
                return;
            }
            else { funcoes.getTxt_1(); }

            try
            {
                float.Parse(funcoes.getTxt_1());
                funcoes.getTxt_1();
            }

            catch
            {
                Erro.setErro("O campo deve ser numérico...");
                return;
            }

            if (funcoes.getTxt_2().Length == 0)
            {
                Erro.setErro("O campo é de preenchimento obrigatório...");
                return;
            }
            else { funcoes.getTxt_2(); }

            try
            {
                float.Parse(funcoes.getTxt_2());
                funcoes.getTxt_2();
            }

            catch
            {
                Erro.setErro("O campo deve ser numérico...");
                return;
            }
        }

        public static void validadados3(Funcoes funcoes)
        {
            Erro.setErro(false);

            if (funcoes.getTxt_1().Length == 0)
            {
                Erro.setErro("O campo é de preenchimento obrigatório...");
                return;
            }
            else { funcoes.getTxt_1(); }

            try
            {
                float.Parse(funcoes.getTxt_1());
                funcoes.getTxt_1();
            }

            catch
            {
                Erro.setErro("O campo deve ser numérico...");
                return;
            }

            if (funcoes.getTxt_2().Length == 0)
            {
                Erro.setErro("O campo é de preenchimento obrigatório...");
                return;
            }
            else { funcoes.getTxt_2(); }

            try
            {
                float.Parse(funcoes.getTxt_2());
                funcoes.getTxt_2();
            }

            catch
            {
                Erro.setErro("O campo deve ser numérico...");
                return;
            }

            if (funcoes.getTxt_3().Length == 0)
            {
                Erro.setErro("O campo é de preenchimento obrigatório...");
                return;
            }
            else { funcoes.getTxt_3(); }

            try
            {
                float.Parse(funcoes.getTxt_3());
                funcoes.getTxt_3();
            }

            catch
            {
                Erro.setErro("O campo deve ser numérico...");
                return;
            }

        }
    }
}
