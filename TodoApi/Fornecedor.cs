using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi
{
   public class Fornecedor
   {
      /* Atributos Privados, com implementação */
      private string? _nroDeAcesso;

      /*Atributos autoimplementados: */
      public Guid Id { get; private set; }
      public bool Status { get; private set; }
      public string? UserName { get; private set; }
      public int Email { get; private set; }
      public double Limite { get; private set; }
      public double ValorCompra { get; private set; }

      /* Construtores padrão */
      public Fornecedor() { }
      public Fornecedor(string username, bool status, int email)
      {
         Status = status;
         UserName = username;
         Email = email;
      }

      /* Implementações da classe */
      public string? NroDeAcesso
      {
         get { return _nroDeAcesso; }
         set
         {
            if (value != null && value.Length >= 5)
            {
               _nroDeAcesso = value;
            }
         }
      }
      public void EfetuarCompra(double vlr_compra)
      {
         if (Status == true && Limite > 0)
         {
            ValorCompra = ValorCompra + vlr_compra;
            Limite = Limite - vlr_compra;
         }
      }

      /* Retorno formatado ao usuário */
      public override string ToString()
      {
         return "Olá " + UserName + " número gerado com sucesso " + Id + " seu limite de compras é de R$ " + Limite;
      }



   }
}