using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    class Categoria_Fachada
    {

        public DataSet getListado(Query query)
        {
            return BDConnect.Exec_cQuery(query.listo());
        }
        public int guardar(Categoria objeto)
        {
            Query query = new Query("insert", "categoria");
            query.AddInsert("ID", Utils.preparaIU(objeto.fID));
            query.AddInsert("nombre", Utils.preparaIU(objeto.fnombre));
            query.AddInsert("descripcion", Utils.preparaIU(objeto.fdescripcion));
            query.AddInsert("categoria_ID", Utils.preparaIU(objeto.fcategoria_ID));
            query.AddInsert("estado", Utils.preparaIU(objeto.festado));
            query.AddInsert("cuenta_contable_ID", Utils.preparaIU(objeto.fcuenta_contable_ID));
            query.AddInsert("exento", Utils.preparaIU(objeto.fexento));
            //BDConnect.Exec_sQuery(query.listo());

            string queryID = query.lastInsertID();
            DataSet dataset = BDConnect.Exec_cQuery(query.listo() + ";" + queryID);
            int Categoria_ID = 0;
            foreach (DataRow fila in dataset.Tables[0].Rows)
            {
                Categoria_ID = Utils.cint(fila["LAST_INSERT_ID()"].ToString());
            }
            return Categoria_ID;

        }
        public void actualizar(Categoria objeto)
        {

            Query query = new Query("update", "categoria");
            query.AddSet("ID", Utils.preparaIU(objeto.fID));
            query.AddSet("nombre", Utils.preparaIU(objeto.fnombre));
            query.AddSet("descripcion", Utils.preparaIU(objeto.fdescripcion));
            query.AddSet("categoria_ID", Utils.preparaIU(objeto.fcategoria_ID));
            query.AddSet("estado", Utils.preparaIU(objeto.festado));
            query.AddSet("cuenta_contable_ID", Utils.preparaIU(objeto.fcuenta_contable_ID));
            query.AddSet("exento", Utils.preparaIU(objeto.fexento));
            query.AddWhere("ID", objeto.fID.ToString());
            BDConnect.Exec_sQuery(query.listo());
        }
        public void ejecutaSin_retorno(Query query)
        {
            BDConnect.Exec_sQuery(query.listo());
        }
        public void eliminar(Query query)
        {
            BDConnect.Exec_sQuery(query.listo());
        }

    }//Fin Clase
}//Fin name_space

