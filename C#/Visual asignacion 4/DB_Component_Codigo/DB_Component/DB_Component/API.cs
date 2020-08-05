using Npgsql;

namespace DB_Component
{
    public class API
    {
        Conection_conf C;
        Pool_Manager PM;
        Pool P;
        Sentences Sc;

        public NpgsqlConnection GetConnection()
        {
            C = PM.GetConnection();
            return C.GetConnection();
        }

        public void LoadPool(string DatabaseID)
        {
            P = new Pool(DatabaseID);
            PM = new Pool_Manager(P);
        }

        public void LoadSentences()
        {
            Sc = new Sentences();
        }

        public void AddParam(string Param)
        {
            Sc.AddParam(Param);
        }

        public string[] GetParams()
        {
            return Sc.GetParams();
        }

        public void ClearParams()
        {
            Sc.ClearParams();
        }

        public string GetSentence(string QueryID, string[] Params, string Table_Name)
        {
            return Sc.GetSentence(QueryID, Params, Table_Name);
        }

        public void ExectueSentence(string Sentence, NpgsqlConnection Conn)
        {
            var Command = new NpgsqlCommand(Sentence, Conn);
            Command.ExecuteNonQuery();
            PM.ReturnConn(C);
        }

        public void ReturnConn()
        {
            PM.ReturnConn(C);
        }
    }
}
