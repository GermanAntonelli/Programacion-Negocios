using System;

namespace _01___Fábrica_de_Conexiones
{
    internal class OleDbConnection
    {
        private string v;

        public OleDbConnection(string v)
        {
            this.v = v;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}