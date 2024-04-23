﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatosT6
{
    internal class Contato
    {
        // Declaração de variáveis.
        private string nome;
        private string sobrenome;
        private string telefone;

        // Propriedades. São os métodos "get" e "set".
        // get = leitura
        // set = definição
        // É possível ser somente leitura, ou somente definição...
        public string Nome
        { 
            get
            { 
                return nome; 
            }
            set 
            { 
                nome = value;
            }
                
        }
        public string Sobrenome
        {
            get 
            {
                return sobrenome;           
            }
            set
            {
                sobrenome = value;
            }
        }
        public string Telefone
        {
            get 
            { 
                return telefone;        
            }
            set 
            { 
                if(value.Length == 13)
                { 
                    telefone = value;                
                }
                else
                {
                    Telefone = "(00) 00000-0000";
                }
            }
        }
        // Construtor da classe.
        public Contato()
        {
            Nome = "Jesus";
            Sobrenome = "Cristo";
            Telefone = "(11) 90424-2512";
        }

        // Sobrecarga do método construtor.
        public Contato
    }
}