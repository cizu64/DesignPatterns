using DesignPatterns.Mediator.Colleagues;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    //the concrete mediator references all components it manages
    class Cordinator : IMediator
    {
        Category cat;
        Log log;

        //object that needs to collaborate
        public void AddColleagues(Category cat, Log log)
        {
            this.cat = cat;
            this.log = log;
        }
        public void Notify(object sender, string data)
        {
            if (sender == cat)
            {                                
                var logMsg = new
                {
                    Message = "Product Category added",
                    Data = data
                };

                //can do something with log component
               log.AddLog(JsonConvert.SerializeObject(logMsg)); 
             
            }
            //if (sender == log)
            //{
            //    //can further do something 
            //}
        }
    }
}
