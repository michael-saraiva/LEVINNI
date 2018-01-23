using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTP
{
    class Dados
    {
        public static string conexaoBancoDados
        {
            get
            {
                #region Conexão Servidor Levinne Modas Rede
                //return @"Server=192.168.1.136,1433; Database=CTP2; User Id=levinni; Password=0101; Trusted_Connection=false";
                #endregion

                #region Conexão Servidor Levinne Modas Local
                //Conexão Servidor da Loja
                //return @"server=ADMIN-PC\SQLEXPRESS; database = CTP2; Trusted_Connection = true";
                #endregion

                // FAGNER
                //return @"server=ADMIN-PC\SQLEXPRESS; database = CTP2; Trusted_Connection = true";

                // FAGNER DESKTOP PADRAO
                //return @"server=FAGNER-PC\SQLEXPRESS; database = CTP2; Trusted_Connection = true";

                //SAMUEL
                //return @"server=SAMUEL\SQLEXPRESS01; database = CTP2; Trusted_Connection = true";

                //SAMUEL DESKTOP
                return @"server=STARK-PC\SQLEXPRESS; database = CTP2; Trusted_Connection = true";                

                //Saraiva
                //return @"server=DESKTOP-QB1F12V\SQLEXPRESS; database = CTP2; Trusted_Connection = true";

                //return @"server=(LocalDB)\MSSQLLocalDB; database = C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS01\MSSQL\DATA\CTP2.mdf; Trusted_Connection = true";
            }
        }
    }
}
