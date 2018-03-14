using FrameForAList.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FrameForAList.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ShopPage : ContentPage
	{
        private List<ShopItem> itemList;
        public List<ShopItem> ItemList
        {
            get { return itemList; }
            set
            {
                itemList = value;
                OnPropertyChanged();
            }
        }

        List<ShopItem> _item = new List<ShopItem>();

        public List<ShopItem> LoadTheListOfPages()
        {
            _item.Add(new ShopItem() { Id = "1", Image = "handbag.png", Name = "Gucci hand bag light brown", Description = "Almost new", Price = "3000.00 SAR" });
            _item.Add(new ShopItem() { Id = "2", Image = "Leather.png", Name = "Gucci hand bag light brown", Description = "Almost new", Price = "3000.00 SAR" });
            _item.Add(new ShopItem() { Id = "3", Image = "holder.png", Name = "Gucci hand bag light brown", Description = "Almost new", Price = "3000.00 SAR" });

            return _item;
        }

        public ShopPage ()
		{
			InitializeComponent ();
            ItemList = LoadTheListOfPages();
            ListItems1.ItemsSource = ItemList;
        }




	}
}