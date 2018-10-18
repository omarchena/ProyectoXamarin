using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static ProyectoCenfotec.Models.WikiaInformacion;
using static ProyectoCenfotec.Models.WikiaModel;

namespace ProyectoCenfotec
{

	public partial class DetallePage : ContentPage
	{
        public ExpandedWikiaItem expandedWikiaItem { get; set; }
        public String name { get; set; }
        public String hub { get; set; }
        public String lang { get; set; }
        public String domain { get; set; }
        public DetallePage (WikiaItem item )
		{
			InitializeComponent ();
            EjecutarBusqueda(item);

        }

        async void EjecutarBusqueda(WikiaItem wikiaItem)
        {
            var wikiaService = new Service.WikiaService();

            IsBusy = true;
            //Items.Clear();

            //var data = await wikiaService.ReadDetail(wikiaItem.id);
            var data = await wikiaService.ReadByHub(wikiaItem.hub);
            if (data != null)
            {
                //var ItemsRoot = data.FirstOrDefault();
                //var pItem = data.items.FirstOrDefault();
                //name = pItem.name;
                //hub = pItem.hub;
                //lang = pItem.lang;
                //domain = pItem.domain;

            }

            IsBusy = false;
        }
    }
}