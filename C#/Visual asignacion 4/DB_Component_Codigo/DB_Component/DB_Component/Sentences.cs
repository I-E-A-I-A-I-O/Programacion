using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Component
{
    class Sentences
    {
        List<String> Params = new List<string>();

        public String GetSentence(String QueryID, String[] Params, String Table_Name)
        {
            if (QueryID.Equals("q1"))
                return "INSERT INTO " + Table_Name + " VALUES(" + int.Parse(Params[0]) + ", '" + Params[1] + "', " + int.Parse(Params[2]) + ", '" + Params[3] + "');";
            else if (QueryID.Equals("q2"))
            {
                if (Params.Length == 0)
                    return "SELECT * FROM " + Table_Name;
                else if (Params[1].Equals("product_id") || Params[1].Equals("product_existence"))
                    return "SELECT " + Params[0] + " FROM " + Table_Name + " WHERE " + Params[1] + " = " + Params[2];
                else
                    return "SELECT " + Params[0] + " FROM " + Table_Name + " WHERE " + Params[1] + " = '" + Params[2] + "'";
            }
            else if (QueryID.Equals("q3"))
            {
                if (Params[0].Equals("product_id") || Params[0].Equals("product_existence"))
                {
                    if (Params[2].Equals("product_id") || Params[2].Equals("product_existence"))
                        return "UPDATE " + Table_Name + " SET " + Params[0] + " = " + Params[1] + " WHERE " + Params[2] + " = " + Params[3];
                    else
                        return "UPDATE " + Table_Name + " SET " + Params[0] + " = " + Params[1] + " WHERE " + Params[2] + " = '" + Params[3] + "'";
                }
                else
                {
                    if (Params[2].Equals("product_id") || Params[2].Equals("product_existence"))
                        return "UPDATE " + Table_Name + " SET " + Params[0] + " = '" + Params[1] + "' WHERE " + Params[2] + " = " + Params[3];
                    else
                        return "UPDATE " + Table_Name + " SET " + Params[0] + " = '" + Params[1] + "' WHERE " + Params[2] + " = '" + Params[3] + "'";
                }
            }
            else
            {
                if (Params[0].Equals("product_id") || Params[0].Equals("product_existence"))
                    return "DELETE FROM " + Table_Name + " WHERE " + Params[0] + " = " + Params[1];
                else
                    return "DELETE FROM " + Table_Name + " WHERE " + Params[0] + " = '" + Params[1] + "'";
            }
        }

        public void AddParam(String Param)
        {
            Params.Add(Param);
        }

        public String[] GetParams()
        {
            return Params.ToArray();
        }
        
        public void ClearParams()
        {
            Params.Clear();
        }
    }
}
