using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static ProyectoCenfotec.Models.WikiaModel;

namespace ProyectoCenfotec
{
	public partial class MainPage 
	{

        public ObservableCollection<object> Items { get; set; } = new ObservableCollection<object>();
        public Command sbBuscar { get; set; }
        public Command seleccionarComando { get; set; }

        public WikiaItem seleccionar { get; set; }
        public String TextoBuscar { get; set; }
        
        public MainPage()
		{
            sbBuscar = new Command(() => EjecutarBusqueda());
            InitializeComponent();

        }

        async void EjecutarBusqueda()
        {
            var wikiaService = new Service.WikiaService();

            IsBusy = true;
            Items.Clear();

            var data = await wikiaService.Read(TextoBuscar);

            if(data != null)
            {
                foreach(var item in data.items)
                {
                    Items.Add(item);
                }
            }

            IsBusy = false;
        }

        public void verMas(object sender, EventArgs e)
        {
            WikiaItem wikiaItem = new WikiaItem();
            var mi = ((MenuItem)sender);
            wikiaItem = (WikiaItem)mi.CommandParameter;

            Navigation.PushAsync(new DetallesTapPage(wikiaItem));
        }
    }
}
