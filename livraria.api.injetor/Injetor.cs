using SimpleInjector;

namespace livraria.api.injetor
{
    public class Injetor
    {
        private static Container _container;


        public static void Iniciar()
        {
            if (_container != null)
                _container.Dispose();

            _container = new Container();

          

            _container.Verify();
        }

        public static T ObterInstancia<T>() where T : class
        {
            return _container.GetInstance<T>();
        }

        public static Container Container
        {
            get
            {
                return _container;
            }
        }
    }
}
