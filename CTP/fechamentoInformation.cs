using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LEVINNI
{
    public class fechamentoInformation
    {
        private decimal dinheiro;

        public decimal Dinheiro
        {
            get { return dinheiro; }
            set { dinheiro = value; }
        }
        

        private decimal credito;

        public decimal Credito
        {
            get { return credito; }
            set { credito = value; }
        }

        private decimal debito;

        public decimal Debito
        {
            get { return debito; }
            set { debito = value; }
        }

        private decimal cheque;

        public decimal Cheque
        {
            get { return cheque; }
            set { cheque = value; }
        }

        private decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        private decimal inicial;

        public decimal Inicial
        {
            get { return inicial; }
            set { inicial = value; }
        }

        private decimal final;

        public decimal Final
        {
            get { return final; }
            set { final = value; }
        }

        private string operador;

        public string Operador
        {
            get { return operador; }
            set { operador = value; }
        }

        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private char tipo;

        public char Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private DateTime data;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        private decimal prazo;

        public decimal Prazo
        {
            get { return prazo; }
            set { prazo = value; }
        }

        private decimal dinCaixa;

        public decimal DinCaixa
        {
            get { return dinCaixa; }
            set { dinCaixa = value; }
        }

        private decimal entrada;

        public decimal Entrada
        {
            get { return entrada; }
            set { entrada = value; }
        }

        private decimal recebimento;

        public decimal Recebimento
        {
            get { return recebimento; }
            set { recebimento = value; }
        }
        
        
    }
}
