using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enunciado01
{
    public class State
    {
        // A - 1 MINUTO, B - 2 MINUTOS, C - 5 MINUTOS, D - 10 MINUTOS
        public List<String> LadoDerecha { get; set; }
        public List<String> LadoIzquierda { get; set; }
        public bool Farola { get; set; } // TRUE - DERECHA | FALSE - IZQUIERDA
        public bool Explorado { get; set; }
        public int MinutosAcumulados { get; set; }
        public State Padre { get; set; }
        public List<State> Hijos { get; set; }

        public State(List<string> ladoDerecha, List<string> ladoIzquierda, bool farola, int minutosAcumulados)
        {
            LadoDerecha = ladoDerecha;
            LadoIzquierda = ladoIzquierda;
            Farola = farola;
            MinutosAcumulados = minutosAcumulados;
            Explorado = false;
            Padre = null;
            Hijos = new List<State>();
        }
        
        public void GenerarHijos()
        {
            List<String> listaDerecha;
            List<String> listaIzquierda;

            if (Farola) // FAROLA DERECHA
            {
                // CASO 1
                // PASA A - B
                // VALIDAR
                if (EsValido(1))
                {
                    // COPIAR LISTA
                    listaDerecha = LadoDerecha.ToList();
                    listaIzquierda = LadoIzquierda.ToList();
                    // ELIMINAR ELEMENTOS
                    listaDerecha.RemoveAll((p => p == "A" || p == "B"));
                    listaIzquierda.AddRange(new string[] { "A", "B" });
                    // AGREGAR A LOS HIJOS
                    Hijos.Add(new State(listaDerecha, listaIzquierda, false, MinutosAcumulados + 2));
                }

                // CASO 2
                // PASA A - C
                // VALIDAR
                if (EsValido(2))
                {
                    // COPIAR LISTA
                    listaDerecha = LadoDerecha.ToList();
                    listaIzquierda = LadoIzquierda.ToList();
                    // ELIMINAR ELEMENTOS
                    listaDerecha.RemoveAll((p => p == "A" || p == "C"));
                    listaIzquierda.AddRange(new string[] { "A", "C" });
                    // AGREGAR A LOS HIJOS
                    Hijos.Add(new State(listaDerecha, listaIzquierda, false, MinutosAcumulados + 5));
                }

                // CASO 3
                // PASA A - D
                // VALIDAR
                if (EsValido(3))
                {
                    // COPIAR LISTA
                    listaDerecha = LadoDerecha.ToList();
                    listaIzquierda = LadoIzquierda.ToList();
                    // ELIMINAR ELEMENTOS
                    listaDerecha.RemoveAll((p => p == "A" || p == "D"));
                    listaIzquierda.AddRange(new string[] { "A", "D" });
                    // AGREGAR A LOS HIJOS
                    Hijos.Add(new State(listaDerecha, listaIzquierda, false, MinutosAcumulados + 10));
                }

                // CASO 4
                // PASA B - C
                // VALIDAR
                if (EsValido(4))
                {
                    // COPIAR LISTA
                    listaDerecha = LadoDerecha.ToList();
                    listaIzquierda = LadoIzquierda.ToList();
                    // ELIMINAR ELEMENTOS
                    listaDerecha.RemoveAll((p => p == "B" || p == "C"));
                    listaIzquierda.AddRange(new string[] { "B", "C" });
                    // AGREGAR A LOS HIJOS
                    Hijos.Add(new State(listaDerecha, listaIzquierda, false, MinutosAcumulados + 5));
                }

                // CASO 5
                // PASA B - D
                // VALIDAR
                if (EsValido(5))
                {
                    // COPIAR LISTA
                    listaDerecha = LadoDerecha.ToList();
                    listaIzquierda = LadoIzquierda.ToList();
                    // ELIMINAR ELEMENTOS
                    listaDerecha.RemoveAll((p => p == "B" || p == "D"));
                    listaIzquierda.AddRange(new string[] { "B", "D" });
                    // AGREGAR A LOS HIJOS
                    Hijos.Add(new State(listaDerecha, listaIzquierda, false, MinutosAcumulados + 10));
                }

                // CASO 6
                // PASA C - D
                // VALIDAR
                if (EsValido(6))
                {
                    // COPIAR LISTA
                    listaDerecha = LadoDerecha.ToList();
                    listaIzquierda = LadoIzquierda.ToList();
                    // ELIMINAR ELEMENTOS
                    listaDerecha.RemoveAll((p => p == "C" || p == "D"));
                    listaIzquierda.AddRange(new string[] { "C", "D" });
                    // AGREGAR A LOS HIJOS
                    Hijos.Add(new State(listaDerecha, listaIzquierda, false, MinutosAcumulados + 10));
                }
            }
            else // FAROLA IZQUIERDA
            {
                // CASO 7
                // PASA A
                // VALIDAR
                if (EsValido(7))
                {
                    // COPIAR LISTA
                    listaDerecha = LadoDerecha.ToList();
                    listaIzquierda = LadoIzquierda.ToList();
                    // ELIMINAR ELEMENTOS
                    listaIzquierda.Remove("A");
                    listaDerecha.Add("A");
                    // AGREGAR A LOS HIJOS
                    Hijos.Add(new State(listaDerecha, listaIzquierda, true, MinutosAcumulados + 1));
                }

                // CASO 8
                // PASA B
                // VALIDAR
                if (EsValido(8))
                {
                    // COPIAR LISTA
                    listaDerecha = LadoDerecha.ToList();
                    listaIzquierda = LadoIzquierda.ToList();
                    // ELIMINAR ELEMENTOS
                    listaIzquierda.Remove("B");
                    listaDerecha.Add("B");
                    // AGREGAR A LOS HIJOS
                    Hijos.Add(new State(listaDerecha, listaIzquierda, true, MinutosAcumulados + 2));
                }

                // CASO 9
                // PASA C
                // VALIDAR
                if (EsValido(9))
                {
                    // COPIAR LISTA
                    listaDerecha = LadoDerecha.ToList();
                    listaIzquierda = LadoIzquierda.ToList();
                    // ELIMINAR ELEMENTOS
                    listaIzquierda.Remove("C");
                    listaDerecha.Add("C");
                    // AGREGAR A LOS HIJOS
                    Hijos.Add(new State(listaDerecha, listaIzquierda, true, MinutosAcumulados + 5));
                }

                // CASO 10
                // PASA D
                // VALIDAR
                if (EsValido(10))
                {
                    // COPIAR LISTA
                    listaDerecha = LadoDerecha.ToList();
                    listaIzquierda = LadoIzquierda.ToList();
                    // ELIMINAR ELEMENTOS
                    listaIzquierda.Remove("D");
                    listaDerecha.Add("D");
                    // AGREGAR A LOS HIJOS
                    Hijos.Add(new State(listaDerecha, listaIzquierda, true, MinutosAcumulados + 10));
                }
            }
        }
        
        public bool EsValido(int caso)
        {
            String resultado1;
            String resultado2;

            switch (caso)
            {
                // CASO 1
                // PASA A - B
                case 1:
                    if(Farola) // DERECHA
                    {
                        resultado1 = LadoDerecha.Find(s => s == "A");
                        resultado2 = LadoDerecha.Find(s => s == "B");

                        if (resultado1 != null && resultado2 != null)
                            return true;
                        return false;
                    }
                    return false; // IZQUIERDA

                // CASO 2
                // PASA A - C
                case 2:
                    if (Farola) // DERECHA
                    {
                        resultado1 = LadoDerecha.Find(s => s == "A");
                        resultado2 = LadoDerecha.Find(s => s == "C");

                        if (resultado1 != null && resultado2 != null)
                            return true;
                        return false;
                    }
                    return false; // IZQUIERDA

                // CASO 3
                // PASA A - D
                case 3:
                    if (Farola) // DERECHA
                    {
                        resultado1 = LadoDerecha.Find(s => s == "A");
                        resultado2 = LadoDerecha.Find(s => s == "D");

                        if (resultado1 != null && resultado2 != null)
                            return true;
                        return false;
                    }
                    return false; // IZQUIERDA

                // CASO 4
                // PASA B - C
                case 4:
                    if (Farola) // DERECHA
                    {
                        resultado1 = LadoDerecha.Find(s => s == "B");
                        resultado2 = LadoDerecha.Find(s => s == "C");

                        if (resultado1 != null && resultado2 != null)
                            return true;
                        return false;
                    }
                    return false; // IZQUIERDA

                // CASO 5
                // PASA B - D
                case 5:
                    if (Farola) // DERECHA
                    {
                        resultado1 = LadoDerecha.Find(s => s == "B");
                        resultado2 = LadoDerecha.Find(s => s == "D");

                        if (resultado1 != null && resultado2 != null)
                            return true;
                        return false;
                    }
                    return false; // IZQUIERDA

                // CASO 6
                // PASA C - D
                case 6:
                    if (Farola) // DERECHA
                    {
                        resultado1 = LadoDerecha.Find(s => s == "C");
                        resultado2 = LadoDerecha.Find(s => s == "D");

                        if (resultado1 != null && resultado2 != null)
                            return true;
                        return false;
                    }
                    return false; // IZQUIERDA

                // CASO 7
                // PASA A
                case 7:
                    if (Farola) // DERECHA
                    {
                        resultado1 = LadoDerecha.Find(s => s == "A");

                        if (resultado1 != null)
                            return true;
                        return false;
                    }
                    else // IZQUIERDA
                    {
                        resultado1 = LadoIzquierda.Find(s => s == "A");

                        if (resultado1 != null)
                            return true;
                        return false;
                    }

                // CASO 8
                // PASA B
                case 8:
                    if (Farola) // DERECHA
                    {
                        resultado1 = LadoDerecha.Find(s => s == "B");

                        if (resultado1 != null)
                            return true;
                        return false;
                    }
                    else // IZQUIERDA
                    {
                        resultado1 = LadoIzquierda.Find(s => s == "B");

                        if (resultado1 != null)
                            return true;
                        return false;
                    }

                // CASO 9
                // PASA C
                case 9:
                    if (Farola) // DERECHA
                    {
                        resultado1 = LadoDerecha.Find(s => s == "C");

                        if (resultado1 != null)
                            return true;
                        return false;
                    }
                    else // IZQUIERDA
                    {
                        resultado1 = LadoIzquierda.Find(s => s == "C");

                        if (resultado1 != null)
                            return true;
                        return false;
                    }
                
                // CASO 10
                // PASA D
                case 10:
                    if (Farola) // DERECHA
                    {
                        resultado1 = LadoDerecha.Find(s => s == "D");

                        if (resultado1 != null)
                            return true;
                        return false;
                    }
                    else // IZQUIERDA
                    {
                        resultado1 = LadoIzquierda.Find(s => s == "D");

                        if (resultado1 != null)
                            return true;
                        return false;
                    }

                default:
                    return false; // GRACIAS COMPILADOR
            }
        }

        public bool EsFinal() => LadoIzquierda.Count == 4 && LadoDerecha.Count == 0;

        public string ObtenerRecorrido() // OBTENER EL RECORRIDO HASTA EL PADRE
        {
            State next = this;
            List<State> reporte = new List<State>();
            string textoTotal = "";
            string textoIzquierda = "";
            string textoDerecha = "";

            while (next.Padre != null) // OBTENER CAMINO
            {
                reporte.Add(next);
                next = next.Padre;
            }

            for (int i = reporte.Count - 1, j = 1; i >= 0; i--, j++)
            {
                textoTotal += "Paso N°: " + j + "\n"
                       + "Personas Izquierda: \n";
                       
                foreach(String str in reporte[i].LadoIzquierda.OrderBy(s => s))
                    textoIzquierda += str + "\n";

                textoTotal += textoIzquierda;

                textoTotal += "Personas Derecha: \n";

                foreach (String str in reporte[i].LadoDerecha.OrderBy(s => s))
                    textoDerecha += str + "\n";

                textoTotal += textoDerecha;

                textoTotal += "Minutos: " + reporte[i].MinutosAcumulados.ToString() + "\n";

                if (reporte[i].Farola)
                    textoTotal += "Farola: " + "DERECHA";
                else
                    textoTotal += "Farola: " + "IZQUIERDA";

                textoTotal += "\n--------------------------------\n\n";
                textoIzquierda = textoDerecha = "";
            }

            return textoTotal;
        }
    }
}
