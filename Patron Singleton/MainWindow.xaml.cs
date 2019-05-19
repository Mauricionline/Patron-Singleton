using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Patron_Singleton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // No se puede crear una nueva instancia ya que puse el constructor en PRIVADO
            //Singleton singleton = new Singleton();             

            Singleton singleton = Singleton.Intance;
            /* 
                Ya que no podemos crear una intancia de la clase lo que hacemos es acceder a su 
                metodo ESTATICO el cual crea una instancia una sola vez            
            */

            //damos valor a su atributo mensaje
            singleton.Mensaje = "Hola Mundo";

            //imprimimos su atributo 'mensaje' para comprobar que la clase esta intanciada correctamente
            txt_respuesta.Text = singleton.Mensaje; 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Singleton singleton_de_persona2 = Singleton.Intance;
            //Podemos observar que el atributo 'Mensaje' de singletone_de_persona2 ya tiene un valor 
            //solo si oprimimos el boton de la primera persona o el de la segunda persona
            txt_respuesta2.Text = singleton_de_persona2.Mensaje;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // creo un nuevo objeto Singleton
            Singleton singleton_de_persona3 = Singleton.Intance;
            //le doy el valor a su atributo 'Mensaje'
            singleton_de_persona3.Mensaje = "Adios Mundo";

            txt_respuesta3.Text = singleton_de_persona3.Mensaje;
        }
    }
}
