using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{

    public interface IWorker
    {
        public void Build();
    }
    public interface IWriter
    {
        void Write();
    }

    public interface IReader
    {
        void Read();
    }

    public interface IMailer
    {
        void SendEmail();
    }

    //---
    public interface ICreatable
    {
        void Create();
    }

    public interface IDeletable
    {
        void Delete();
    }

    public interface IUpdatable
    {
        void Update();
    }

    //---
    public interface IBook
    {
        void Read();
    }

    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
    }
}
