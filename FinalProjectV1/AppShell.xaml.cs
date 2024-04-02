using FinalProjectV1.FunctionLibrary;

namespace FinalProjectV1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(AddBooks), typeof(AddBooks));

            Routing.RegisterRoute(nameof(SearchBooks), typeof(SearchBooks));

            Routing.RegisterRoute(nameof(DeleteBooks), typeof(DeleteBooks));

            Routing.RegisterRoute(nameof(HomeScreen), typeof(HomeScreen));

            Routing.RegisterRoute(nameof(UpdateBooks), typeof(UpdateBooks));


        }
    }
}
