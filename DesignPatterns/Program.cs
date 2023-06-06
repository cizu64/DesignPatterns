using DesignPatterns.AbstractFactory.Product.Air;
using DesignPatterns.AbstractFactory.Product.Land;
using DesignPatterns.Bridge;
using DesignPatterns.Builder;
using DesignPatterns.Commands;
using DesignPatterns.Decorator;
using DesignPatterns.Facade;
using DesignPatterns.Factory;
using DesignPatterns.Factory.Creator;
using DesignPatterns.Factory.Product;
using DesignPatterns.Factory.Product.Samsung;
using DesignPatterns.Iterator;
using DesignPatterns.Mediator;
using DesignPatterns.Mediator.Components;
using DesignPatterns.Observable.Publisher;
using DesignPatterns.Observable.Subscribers;
using DesignPatterns.Prototype;
using DesignPatterns.Proxy;
using DesignPatterns.Singleton;
using DesignPatterns.Strategy;
using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {  
        static void Main(string[] args)
        {
           
            
        }
    }
}


#region examples
//var p = new Program();
//Expression<Func<int, int, int>> res = (a, b) => a + b;
//Predicate<int> criteria = (c) => c > 10;
//Console.WriteLine(res);

//proxy

//Cart cart = new Cart(); //service object
//CartManager cartManager = new CartManager(cart); //client
//Console.WriteLine(cartManager.DisplayCartProductsAndFinalTotal());


//DiscountProxy discountProxy = new DiscountProxy(cart); //the proxy class
//cartManager = new CartManager(discountProxy);
//Console.WriteLine(cartManager.DisplayCartProductsAndFinalTotal());


//builder
//var builder = new ConcreteAutomobile();
////can also use a director to defined the order to call the construction steps
//string honda = builder.BuildHonda(new Honda
// {custo
//     Id=1,
//     Color="Red",
//     Model = "Honda Crosstour"
// });
//Console.WriteLine(honda);

//Bridge
//Samsung samsung = new Samsung(); //comcrete implementations
//Device device = new Device(samsung);
//Console.WriteLine(device.Color(Color.GOLD));

//Redmi redmi = new Redmi();
//device = new Device(redmi);
//Console.WriteLine(device.Color(Color.BLACK));

//Prototype
//ConcretePrototype proto = new ConcretePrototype();
//int result = proto.Add(1, 2, 3, 4, 5);
//Console.WriteLine(result);
//var clone = proto.Clone();
//int result2 = clone.Add(1, 2, 3, 3);
//Console.WriteLine(result2);

//var result = JsonConvert.SerializeObject(profile);
//Console.WriteLine(result);
//profile.Fulname = "Charles Nnaji";
//Console.WriteLine("Cloned object");
//var newProf = profile.Clone();
//var result2 = JsonConvert.SerializeObject(newProf);
//Console.WriteLine(result2);


//var l = new AbstractFactory.Creator.Logistics();
//ILand land = l.CreateLandTransport(nameof(AbstractFactory.Product.Land.Train));
//land.Deliver();

////dont depend on concrete class
//var t = new AbstractFactory.Product.Land.Train();
//t.Deliver();

//Adapter
//var xml = new XmlConverter();
//var adapter = new XmlToJsonAdapter(xml);
//adapter.ConvertXmlToJson();

//Singleton
//Called Log.Instance method trice but it is initialized just once.
//Log l = Log.Instance;
//Log l2 = Log.Instance;
//Log l3 = Log.Instance;

//Factory
//DangoteFactory creator = new DangoteSaltFactory();
//DangoteFood food = creator.GetFood();
//food.Quantity = 500;
//food.Price = 20000;
//food.Total = food.Quantity * food.Price;

//Console.WriteLine($"Quantity:{food.Quantity }\nPrice:{food.Price}\nTotal:{food.Total}");

//Factory 2
//Logistics logistics = new Logistics();
//var t = (Train)logistics.FactoryMethod(new Train());
//t.Deliver();
//Console.WriteLine("Enter a delivery method");
//Console.WriteLine("1. Train");
//Console.WriteLine("2. Ship");

//int key = int.Parse(Console.ReadLine());
//Logistics logistics = null;
//switch (key)
//{
//    case 1:
//        logistics = new TrainLogistics();
//        break;
//    case 2:
//        logistics = new ShipLogistics();
//        break;
//}
//var samsung = new Factory.Creator.Samsung();
//ISamsung creator = samsung.Create(nameof(A72));
//decimal buy = creator.Buy(2);
//Console.WriteLine($"Samsung {Type.GetType(creator.ToString()).Name} purchased at {buy}USD");

//Facade
//CalculateFacade calc = new CalculateFacade(new Facade.Math());
//int sum = calc.Addition(1, 2, 3, 4, 5);
//Console.WriteLine(sum);

//Decorator 2
//DefaultChannel defaultChannel = new DefaultChannel();
//AdvertDecorator advert = new CNN(defaultChannel);
//advert = new BBC(advert);

//Console.WriteLine(advert.Broadcast());


//Iterator
//The iterator encapsulates the details of working with a complex data structure, providing the client with several simple methods of accessing the collection elements
//var customer = new CustomerCollection();
//customer.AddItem(new Customer
//{
//    Fullname = "John Doe",
//    Id = 1,
//    CustomerType = CustomerType.REGULAR
//});
//customer.AddItem(new Customer
//{
//    Fullname = "Jane Doe",
//    Id = 2,
//    CustomerType = CustomerType.PREMIUM
//});

//foreach (var c in customer.getItems())
//{
//    Console.WriteLine(c.Fullname);
//}
//customer.MoveNext();
//Customer cus = customer.Current() as Customer;

//Console.WriteLine(cus.Id);



//Strategy
//UserProfile profile = new UserProfile(new BasicProfile());
//profile.AddProfile(new
//{
//    Id = 1,
//    UserId = 1,
//    Fullname = "John Doe",
//    Email = "johndoe@gmail.com",
//    Phone = "12345",
//    Gender = "Male"
//});
//profile.GetProfile();

//profile = new UserProfile(new JobProfile());
//profile.AddProfile(new
//{
//    UserId = 1,
//    ExpectedSalary = 70000,
//    CV = "link to cv"
//});
//profile.GetProfile();


//Command
//var customer = new Commands.Customer
//{
//    Fullname = "John Doe",
//    Age = 30,
//    Email = "johndoe@gmail.com",
//    Address = "Anonymous"
//};

//new Invoker(new CreateCustomer(customer)).Trigger();
//new Invoker(new CompleteRegistration(customer, "johndoe@gmail.com")).Trigger();


//Mediator
//Cordinator cordinate = new Cordinator();

//Category cat = new Category(cordinate);
//Mediator.Components.Log log = new Mediator.Components.Log(cordinate);

//cordinate.AddComponents(cat, log); //the concrete mediator manages all components it manages
//cat.AddCategory("Givenchy");
//cat.AddCategory("Prada");


//observable
//we want to notify a customer that the new macbook pro 14 is available
// StoreManager store = new StoreManager(); //the publisher

// MacBook14Pro mac = new MacBook14Pro(); //concrete subscriber
//Observable.Subscribers.Samsung_S22_Ultra samsung = new Observable.Subscribers.Samsung_S22_Ultra();

// store.Subscribe(mac); //the customer subscribe to receive notification from the store for mac book products
// //store.Subscribe(samsung);


// store.NotifySubscribers(new[] {mac.ToString() }); //the store notifies the subscribers of the new products 

#endregion
