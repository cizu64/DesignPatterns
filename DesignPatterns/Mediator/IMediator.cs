using DesignPatterns.Mediator.Colleagues;
using System;

namespace DesignPatterns.Mediator
{
    public interface IMediator
    {
        void Notify(object sender, string data); //a single notification method
    }
}
