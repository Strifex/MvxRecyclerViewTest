using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;

namespace MvxRecyclerViewTest_Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart(new AppStart());
        }
    }
}
