using Ninject;
using Ninject.Modules;

namespace Hillel_Lesson11_HW
{
    class Programm
    {
        static void Main(string[] args)
        {
            var messageModule = new MessageModule();
            var kernel = new StandardKernel(messageModule);

            var message2 = kernel.Get<IMessage>();

            message2.ShowResult();
            
            
            Console.ReadKey();
        }
    }
}
