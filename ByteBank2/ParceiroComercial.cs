﻿using ByteBank2.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
        
    }
}
