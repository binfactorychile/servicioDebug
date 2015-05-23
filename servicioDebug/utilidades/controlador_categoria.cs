using System;
using System.Collections;
using System.Data;
using querytor;
namespace utilidades
{
    class Controlador_Categoria
    {

        Categoria_Fachada fachada = new Categoria_Fachada();
        public Categoria[] getListado(Query query)
        {
            query.AddWhere("estado", "1");
            DataSet dataset = fachada.getListado(query);
            Categoria[] categoria = new Categoria[dataset.Tables[0].Rows.Count];
            int contador = 0;
            if (dataset != null)
            {
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    Categoria objeto = new Categoria(fila);
                    categoria[contador] = objeto;
                    contador++;
                }
            }
            return categoria;

        }
        public int guardar(Categoria objeto)
        {
            objeto.festado = 1;
            return fachada.guardar(objeto);
        }

        public void actualizar(Categoria objeto)
        {
            fachada.actualizar(objeto);
        }
        public void eliminar(Query query)
        {
            fachada.eliminar(query);
        }
        public void ejecutaSin_retorno(Query query)
        {
            fachada.ejecutaSin_retorno(query);
        }
        public Categoria getCategoria(string id)
        {
            Query query = new Query("select", "Categoria");
            query.AddWhere("ID", id);
            query.AddSelect("*");
            Categoria objeto = new Categoria();
            DataSet dataset = fachada.getListado(query);
            int contador = 0;
            if (dataset != null)
            {
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    objeto = new Categoria(fila);
                    contador++;
                }
            }
            return objeto;
        }
        public int getID(string nombre)
        {
            try
            {
                if (nombre.Length > 0)
                {
                    nombre = nombre.Trim();
                    Query query = new Query("Categoria");
                    query.AddWhereExacto("nombre", nombre);
                    Categoria[] arrCategoria = getListado(query);
                    if (arrCategoria.Length > 0)
                    {
                        return arrCategoria[0].fID;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                    return 0;
            }
            catch (Exception ex)
            {
                utilidades.Utils.EscribeLog(ex);
                return -1;
            }
        }
    }
}//Fin name_space
//------------------------------------------------------------------------------
//	FIN CONTROLADOR
//------------------------------------------------------------------------------
