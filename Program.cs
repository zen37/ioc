using Autofac;

/*
var myDependency = new MyDependency();
var myClass = new MyClass(myDependency);
myClass.ThisIsAMethod();
*/

//create instance of ContainerBuilder 
var builder = new ContainerBuilder();
//registers MyDependency type as an implementation of interface IMyInterface
builder.RegisterType<MyDependency>().As<IMyInterface>();
//registers MyClass type
builder.RegisterType<MyClass>();

//builds the Autofac container based on the registrations made with ContainerBuilder
//using ensures the container is properly disposed of when it is no longer needed
using (var container = builder.Build())
{
    //Autofac creates and object of a class called MyClass, by calling the Resolve method on the container instance created with the Autofac builder
    var myClass = container.Resolve<MyClass>();
    myClass.ThisIsAMethod();
}