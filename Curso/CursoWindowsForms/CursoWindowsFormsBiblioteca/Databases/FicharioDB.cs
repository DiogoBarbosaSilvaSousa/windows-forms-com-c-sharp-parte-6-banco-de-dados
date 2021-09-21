using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class FicharioDB
    {
        public string mensagem;
        public bool status;
        public string tabela;
        public LocalDBClass db;

        public FicharioDB(string Tabela)
        {
            status = true;
            try
            {
                db = new LocalDBClass();
                tabela = Tabela;
                mensagem = "Conexão com a Tabela criada com sucesso";

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com a Tabela com erro: " + ex.Message;
            }
        }

        public void Incluir(string Id, string jsonUnit)
        {
            status = true;
            try
            {
                //INSERT INTO CLIENTE (ID, JSON) VALUES ('000001','{...}')

                var SQL = "INSERT INTO " + tabela + "(Id, JSON) VALUES ('" + Id + "','" + jsonUnit + "')";
                db.SQLCommand(SQL);

                status = true;
                mensagem = "Inclusão efetuada com sucesso. Identificador: " + Id;

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o Fichario com erro: " + ex.Message;
            }

        }
    }
}
