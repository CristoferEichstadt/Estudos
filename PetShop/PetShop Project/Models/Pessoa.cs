using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShop_Project.Models
{
    public class Pessoa
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public char TipoPessoa { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string InscricaoEstadual { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
        public Contato Contato { get; set; }

        public bool ValidaCadastroPessoa()
        {
            CpfCnpj = CpfCnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            //if (CpfCnpj == "00000000000" && TipoPessoa == 'F' || CpfCnpj == "11111111111" && TipoPessoa == 'F' || CpfCnpj == "22222222222" && TipoPessoa == 'F' || CpfCnpj == "33333333333" && TipoPessoa == 'F' || CpfCnpj == "44444444444" && TipoPessoa == 'F' ||
            //CpfCnpj == "55555555555" && TipoPessoa == 'F' || CpfCnpj == "66666666666" && TipoPessoa == 'F' || CpfCnpj == "77777777777" && TipoPessoa == 'F' || CpfCnpj == "88888888888" && TipoPessoa == 'F' || CpfCnpj == "99999999999" && TipoPessoa == 'F')
            //{
            //    return false;
            //}

            //var r = 0;
            //var s = 0;
            //for (int i = 1; i <= 9; i++)
            //{
            //    s = s + Convert.ToInt32(CpfCnpj[i - 1]) * (11 - i);
            //    r = (s * 10) % 11;
            //}

            //if ((r == 10) || (r == 11))
            //{
            //    r = 0;
            //}

            //if (r != Convert.ToInt32(CpfCnpj[9]))
            //{
            //    return false;
            //}


            //s = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    s = s + Convert.ToInt32(CpfCnpj[i - 1]) * (12 - i);
            //}


            //r = (s * 10) % 11;
            //if ((r == 10) || (r == 11))
            //{
            //    r = 0;
            //}

            //if (r != Convert.ToInt32(CpfCnpj[10]))
            //{
            //    return false;
            //}

            //cnpj
            //if (CpfCnpj == "00000000000000" && TipoPessoa == 'J' || CpfCnpj == "11111111111111" && TipoPessoa == 'J' || CpfCnpj == "22222222222222" && TipoPessoa == 'J' || CpfCnpj == "33333333333333" && TipoPessoa == 'J' ||
            //    CpfCnpj == "44444444444444" && TipoPessoa == 'J' || CpfCnpj == "55555555555555" && TipoPessoa == 'J' || CpfCnpj == "66666666666666" && TipoPessoa == 'J' || CpfCnpj == "77777777777777" && TipoPessoa == 'J' ||
            //    CpfCnpj == "88888888888888" && TipoPessoa == 'J' ||
            //    CpfCnpj == "99999999999999" && TipoPessoa == 'J')
            //    return false;

            //// Valida DVs
            //var tamanho = CpfCnpj.Length - 2;
            //var numeros = CpfCnpj.Substring(0, tamanho);
            //var digitos = CpfCnpj.Substring(tamanho);
            //var soma = 0;
            //var pos = tamanho - 7;

            //for (int i = tamanho; i >= 1; i--)
            //{
            //    soma += numeros[tamanho - i] * pos--;

            //    if (pos < 2)
            //        pos = 9;
            //}

            //var resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;
            //if (resultado != digitos[0])
            //    return false;

            //tamanho = tamanho + 1;
            //numeros = CpfCnpj.Substring(0, tamanho);
            //soma = 0;
            //pos = tamanho - 7;

            //for (int i = tamanho; i >= 1; i--)
            //{
            //    soma += numeros[tamanho - i] * pos--;
            //    if (pos < 2)
            //        pos = 9;
            //}

            //resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;

            //if (resultado != digitos[1])
            //    return false;

            //else
            //{
                return true;
            //}
        }
    }
}