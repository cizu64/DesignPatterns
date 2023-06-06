using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Mediator.Colleagues
{
    //colleagues
    class Category 
    {
        private readonly IMediator _mediator;
        public Category(IMediator mediator)
        {
            _mediator = mediator;
        }
        public string AddCategory(string category)
        {
            Console.WriteLine($"Category: {category}");

            _mediator.Notify(this, category); //call the mediator notification object
            return category;
        }
    
        //public class Cat
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //}
    }
}
