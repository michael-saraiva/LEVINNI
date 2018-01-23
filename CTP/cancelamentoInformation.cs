using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LEVINNI
{
    class cancelamentoInformation
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private DateTime data;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        private int documento;

        public int Documento
        {
            get { return documento; }
            set { documento = value; }
        }

        private string operador;

        public string Operador
        {
            get { return operador; }
            set { operador = value; }
        }

        private string motivo;

        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }



    }
}
