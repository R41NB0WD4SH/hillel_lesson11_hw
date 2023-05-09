using Ninject;
using Ninject.Modules;

namespace Hillel_Lesson11_HW
{


    public class MessageModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IMessage>().To<RandomMessageBuilder>();
            this.Bind<IName>().ToMethod(name => new NamesGenerator(new string[] { "Dave", "James", "Kirk" }));
            this.Bind<IGreeting>().ToMethod(greeting =>
                new GreetingsGenerator(new string[]{"Hello!", "Hi!", "¡Hola!", "Buenos Dìas"}));
            this.Bind<IDate>().To<DateTimeGenerator>();
        }
    }
}