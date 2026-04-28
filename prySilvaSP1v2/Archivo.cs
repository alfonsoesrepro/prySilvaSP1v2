using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySilvaSP1v2
{
    public class Archivo
    {
        public string NombreArchivo { get; set; }
        
        public bool GrabarRepuesto(Repuesto rep)
        {
            bool resultado = false;
            if (NombreArchivo != "")
            {
                StreamWriter sw = new StreamWriter(NombreArchivo, true); // Abrir
                
                // Escribir
                sw.WriteLine(rep.Codigo + "," + rep.Nombre + "," + rep.Marca + "," +
                rep.Precio.ToString("#.00", CultureInfo.InvariantCulture) + "," + rep.Origen);
                
                sw.Close(); //Cerrar
                sw.Dispose();
                
                resultado = true;
            }
            return resultado;
        }

        public bool BuscarCodigoRepuesto(string cod)
        { 
            bool resultado = false;
            string Linea;
            string CodigoEnArchivo;
            
            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader sr = new StreamReader(NombreArchivo); //Abrir
                
                while (sr.EndOfStream == false)
                {
                    Linea = sr.ReadLine(); // Leer
                                           
                    CodigoEnArchivo = Linea.Split(',')[0];
                    
                    if (cod == CodigoEnArchivo)
                    {
                        resultado = true;
                        break;
                    }
                }
                sr.Close(); // Cerrar
                sr.Dispose();
            }
            return resultado;
    
            // devuelve falso si el código no existe en el archivo
            // devuelve verdadero si el código ya está grabado
        }

        public List<Repuesto> ObtenerRepuestos()
        {
            List<Repuesto> Lista = new List<Repuesto>();
            string Linea;
            
            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader sr = new StreamReader(NombreArchivo);
                
                while (sr.EndOfStream == false)
                {
                    Linea = sr.ReadLine();
                   
                    Repuesto rep = new Repuesto();
                    rep.Codigo = Linea.Split(',')[0];
                    rep.Nombre = Linea.Split(',')[1];
                    rep.Marca = Linea.Split(',')[2];
                    rep.Precio = decimal.Parse(Linea.Split(',')[3], CultureInfo.InvariantCulture);
                    rep.Origen = Linea.Split(',')[4];
                    
                    Lista.Add(rep);
                }
                sr.Close();
                sr.Dispose();
            }
            
            return Lista;
        }

        public List<Repuesto> ObtenerRepuestosOrdenados()
        {
            List<Repuesto> Lista = ObtenerRepuestos();
            
            Repuesto[] repuestosArray = Lista.ToArray();
            // Método de Burbuja por el campo Nombre en forma ascendente (de menor a mayor)
            for (int i = 0; i < repuestosArray.Length - 1; i++)
            {
                for (int j = 0; j < repuestosArray.Length - 1; j++)
                {
                    if (string.Compare(repuestosArray[j].Nombre,
                    repuestosArray[j + 1].Nombre) > 0)
                    {
                        Repuesto aux = repuestosArray[j];
                        repuestosArray[j] = repuestosArray[j + 1];
                        repuestosArray[j + 1] = aux;
                    }
                }
            }
            
            List<Repuesto> ListaOrdenada = repuestosArray.ToList<Repuesto>();
            
            return ListaOrdenada;
        }

    }
}