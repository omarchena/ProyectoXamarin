using ProyectoCenfotec.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static ProyectoCenfotec.Models.WikiaModel;

namespace ProyectoCenfotec
{
    public partial class DetallesTapPage : TabbedPage
    {
        public ObservableCollection<object> ItemsRelacionados { get; set; } = new ObservableCollection<object>();
  
        public DetallesTapPage (WikiaItem item)
        {
            InitializeComponent();
            EjecutarBusquedaDetalleUsuario(item);
            EjecutarBusquedaRelacionados(item);
        }

        async void EjecutarBusquedaDetalleUsuario(WikiaItem wikiaItem)
        {
            var wikiaService = new Service.WikiaService();

            IsBusy = true;
            //Items.Clear();
            var data = await wikiaService.GetDetailsUser(wikiaItem.founding_user_id);
            if(data != null)
            {
                WikiUsuarios.UserElement userElement = new WikiUsuarios.UserElement();
                userElement = data.items.FirstOrDefault();
                user_id.Text = userElement.user_id.ToString();
                name.Text = userElement.name;
                url.Text = userElement.url;
                Uri myUri = new Uri(userElement.avatar);
                Imagen.Source = FileImageSource.FromUri(myUri);
            }

            IsBusy = false;
        }

        async void EjecutarBusquedaRelacionados(WikiaItem wikiaItem)
        {
            var wikiaService = new Service.WikiaService();

            IsBusy = true;
            ItemsRelacionados.Clear();

            var data = await wikiaService.ReadByHub(wikiaItem.hub);
            if (data != null)
            {
                foreach (var item in data.items)
                {
                    ItemsRelacionados.Add(item);
                }
            }

            IsBusy = false;
        }
    }
}