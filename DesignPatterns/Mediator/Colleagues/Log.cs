using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Mediator.Colleagues
{
    class Log
    {
        private readonly IMediator _mediator;

        public Log(IMediator mediator)
        {
            _mediator = mediator;
        }
        public string AddLog(dynamic message)
        {
            //_mediator.Notify(this, message); //i don't want to notify other objects
            Console.WriteLine($"Log: {message}");
            return message;
        }

    }
}
