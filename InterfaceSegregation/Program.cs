using System;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
            * Bir metod ihtiyaç olmadığı halde implemente ediliyorsa, bu prensibi ihlal ediyorsunuz.
            * 
            */

        }

        public interface IDataSource
        {
            void ReadData();          
            bool IsAvailable();
            void Connect();
            

        }

        public interface IWritableSource
        {
            void WriteData();
        }

        public interface IProcessable
        {
            void Process();
        }

        public class XmlDataSource : IDataSource
        {
            public void Connect()
            {
                throw new NotImplementedException();
            }

            public bool IsAvailable()
            {
                throw new NotImplementedException();
            }

            public void Process()
            {
                throw new NotImplementedException();
            }

            public void ReadData()
            {
                throw new NotImplementedException();
            }

         
        }

        public class ExcelDataSource : IDataSource
        {
            public void Connect()
            {
             
            }

            public bool IsAvailable()
            {
                return true;
            }

           
            public void ReadData()
            {
         
            }

         
        }

        public class DbDataSource : IDataSource, IWritableSource, IProcessable
        {
            public void Connect()
            {
                throw new NotImplementedException();
            }

            public bool IsAvailable()
            {
                throw new NotImplementedException();
            }

            public void Process()
            {
                throw new NotImplementedException();
            }

            public void ReadData()
            {
                throw new NotImplementedException();
            }

            public void WriteData()
            {
                throw new NotImplementedException();
            }
        }
    }
}
