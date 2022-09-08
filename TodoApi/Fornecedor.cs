using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models {
   public class Fornecedor {
      private Guid _id;
      private string? _nome;
      private string? _documento;
      private bool _ativo;

      /*
      public void AlteraNome(string nome) {
         if(nome != null && nome.Length >= 2) {
            _nome = nome;
         }
      }
      */

      public string Nome {
         get { return _nome; }
         set {
            if(value != null && value.Length >= 2) {
               _nome = value;
            }
         }
      }

      public string Documento {
         get { return _documento; }
         set {
            if(value != null && value.Length >= 2) {
               _documento = value;
            }
         }
      }

   }
}