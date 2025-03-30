//Jorge Augusto Blanco Fernandez
//Adrian Arbas Perdiguero
using System.Runtime.Intrinsics.X86;

namespace Listas{
    class Lista{
        // clase interna Nodo
        private class Nodo{
            public int dato;
            public Nodo sig;
            public Nodo(int e=0, Nodo x=null){
                dato = e;
                sig = x;
            }            
        }
        // fin clase Nodo

        Nodo pri;


        public Lista(){
            pri = null;
        }

        public bool InsertaPos(int e, int pos){
            if (pos==0) {
                pri = new Nodo(e, pri);
                return true;
            } else {
                Nodo aux = pri;
                while (aux!=null && pos>1) {
                    aux = aux.sig;
                    pos--;
                }
                if (aux!=null) {
                    aux.sig = new Nodo(e, aux.sig);
                    return true;
                }
                else return false;
            }                
        }

        public void InsertaPri(int e){
            pri = new Nodo(e, pri);
        }


        // devuelve pos de elem e en la lista; -1 si no está
        public int PosElto(int e){
            Nodo aux = pri;
            int pos = 0;
            while (aux!=null && aux.dato!=e) {
                pos++;
                aux = aux.sig;
            }
            if (aux==null) return -1;
            else return pos;
            return -1;
        }

        public int CuentaEltos()
        {
            Nodo aux = pri;
            int NumElem;
            if (pri == null)
            {
                NumElem = 0;
            }

            else
            {
                NumElem = 1;

                while (aux.sig != null)
                {
                    NumElem++;
                    aux = aux.sig;
                }
            }

            return NumElem;
        }

        public void InsertUlt(int e)
        {
            if (pri != null)
            {
                Nodo aux = pri;

                while (aux.sig != null)
                {
                    aux = aux.sig;
                }

                aux.sig = new Nodo(e, aux.sig);
            }

            else
            {
                InsertaPri(e);
            }

        }
        public bool BorraPrimElto(int e)
        {
            bool encontrado = false;

            if (pri == null) {
                Console.WriteLine("No hay elementos en la lista");
            }

            else if (pri.sig != null)
            {                
                Nodo aux = pri;
                while(aux.sig != null && encontrado == false)
                {
                    if(aux.dato == e)
                    {
                        while (aux.sig.sig != null)
                        {
                            aux.dato = aux.sig.dato;
                            aux = aux.sig;
                        }

                        aux.dato = aux.sig.dato;
                        aux.sig = null;
                    }

                    else aux = aux.sig;
                }
                
                /*
                Nodo aux = pri;

                while (aux.sig != null && encontrado == false)
                {
                    if (aux.sig.dato == e && aux.sig.sig == null)
                    {
                        aux.sig = null;

                        encontrado = true;
                    }


                    else if (aux.dato == e)
                    {
                        while (aux.sig.sig != null)
                        {
                            aux.dato = aux.sig.dato;
                            aux = aux.sig;
                        }

                        aux.dato = aux.sig.dato;
                        aux.sig = null;

                        encontrado = true;
                    }

                    else aux = aux.sig;
                }
                */
            }
  

            else
            {
                if (pri.dato == e)
                {
                    pri = null;
                    encontrado = true;
                }
            }




            return encontrado;
        }


        public int Suma()
        {
            Nodo aux = pri;
            int SumElem;
            if (pri == null)
            {
                SumElem = 0;
            }

            else
            {
                SumElem = pri.dato;

                while (aux.sig != null)
                {
                    SumElem += aux.sig.dato;
                    aux = aux.sig;
                }
            }

            return SumElem;

        }

        public int CuentaOcurrencias(int e)
        { 
            Nodo aux = pri;
            int ApariElem = 0;

            if (pri != null)
            {
                if (pri.dato == e)
                {
                    ApariElem = 1;
                }                           

                while (aux.sig != null)
                {
                    if (aux.sig.dato == e)
                    {
                        ApariElem++;
                    }
                    aux = aux.sig;
                }
            }

            return ApariElem;

        }

        private Nodo NesimoNodo(int n)
        {
            if (n < 0) return null;

            Nodo aux = pri;

            for (int i = 0; i < n - 1 && aux.sig != null; i++)
            {
                aux = aux.sig;
            }
            return aux;

        }

        public int Nesimo(int n)
        {
            Nodo aux = NesimoNodo(n);
            return aux.dato;
        }

        public void InsertaNesimo(int n, int e)
        {
            Nodo aux = NesimoNodo(n);
            aux.dato = e;
        }


        // public bool BorraPos(int pos){}


        public void BorraTodos(int e)
        {
            Nodo aux = pri;
            bool encontrado = false;

            if (pri == null)
            {
                Console.WriteLine("No hay elementos que eliminar");
            }

            else
            {
                
                while (aux.sig != null && encontrado == false)
                {
                    if (aux.dato == e)
                    {
                        while(aux.sig != null)
                        {
                            if (aux.sig.dato == e)
                            {
                                aux.dato = aux.sig.sig.dato;
                                aux = aux.sig;
                                aux.dato = aux.sig.sig.dato;
                                aux = aux.sig.sig;
                            }

                            else
                            {
                                aux.dato = aux.sig.dato;
                                aux = aux.sig;
                            }
                            
                        }
                    }

                    aux = aux.sig;
                }
            }
        
        }

        // public int Longitud(){}

        // public int CuentaElto(int e){ }


        // public void Intercambia(int pos1, int pos2){}


        // public void Init(){ }
        // public int Next(){ }

        // public void Retrocede(){ }


        public override string ToString()
        {
            string s="";
            Nodo aux = pri;
            while (aux!=null) {
                s += aux.dato + " ";
                aux = aux.sig;
            }
            return s;
        }


    }
}