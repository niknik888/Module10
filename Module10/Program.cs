using Module10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    class Program
    {
        public static void Main()
        {
            Writer writer = new Writer();
            ((IWriter) writer).Write();


            Worker worker = new Worker();
            ((IWorker) worker).Build();

        }

    }

    public class ElectronicBook : IBook,
    IDevice
    {
        void IDevice.TurnOff()
        {
            throw new NotImplementedException();
        }
        void IDevice.TurnOn()
        {
            throw new NotImplementedException();
        }

        void IBook.Read()
        {
            throw new NotImplementedException();
        }
    }

    public class Entity : ICreatable,
    IDeletable,
    IUpdatable
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }


    public class FileManager : IWriter, IReader, IMailer
    {
        void IWriter.Write()
        {
            Console.WriteLine("Do write");
        }
        void IReader.Read() 
        {
            Console.WriteLine("Do read");
        }
        void IMailer.SendEmail()
        {
            Console.WriteLine("Do send");
        }

    }





    public class Writer : IWriter
    {
        void IWriter.Write() { }
    }

    public class Worker : IWorker
    {
        public void Build() { }
    }
}

