// See https://aka.ms/new-console-template for more information
using MediatorMediatr.MediatorMediatr;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System.Runtime.CompilerServices;

var customer = new CreateCustomer("John", "Doe", "john@gmail.com"); //doing this automatically add the notification to the list
var customer2 = new CreateCustomer("Jane", "Doe", "jane@gmail.com");

var serviceCollection = new ServiceCollection();
var provider = serviceCollection.AddMediatR(m => { m.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()); }).BuildServiceProvider();

var mediatr = provider.GetRequiredService<IMediator>();
await mediatr.Publish(customer);
await mediatr.Publish(customer2);