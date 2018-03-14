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
        private List<ShopItemPair> itemList;
        public List<ShopItemPair> ItemList
        {
            get { return itemList; }
            set
            {
                itemList = value;
                OnPropertyChanged();
            }
        }

        List<ShopItemPair> _item = new List<ShopItemPair>();

        public List<ShopItemPair> LoadTheListOfPages()
        {
            _item.Add(new ShopItemPair(new ShopItem() { Id = "1", Image = "handbag.png", Name = "Gucci hand bag light brown", Description = "Almost new", Price = "3000.00 SAR",IsVisible=true },

                                      new ShopItem() { Id = "1", Image = "handbag.png", Name = "Gucci hand bag light brown", Description = "Almost new", Price = "3000.00 SAR" , IsVisible = true }));
            _item.Add(new ShopItemPair(new ShopItem() { Id = "1", Image = "handbag.png", Name = "Gucci hand bag light brown", Description = "Almost new", Price = "3000.00 SAR" , IsVisible = true },

                                     new ShopItem() { Id = "1", Image = "handbag.png", Name = "Gucci hand bag light brown", Description = "Almost new", Price = "3000.00 SAR" , IsVisible = true }));
            _item.Add(new ShopItemPair(new ShopItem() { Id = "1", Image = "handbag.png", Name = "Gucci hand bag light brown", Description = "Almost new", Price = "3000.00 SAR", IsVisible = true },

                                     new ShopItem() { Id = "1", Image = "handbag.png", Name = "Gucci hand bag light brown", Description = "Almost new", Price = "3000.00 SAR", IsVisible = true }));

            _item.Add(new ShopItemPair(new ShopItem() { Id = "1", Image = "handbag.png", Name = "Gucci hand bag light brown", Description = "Almost new", Price = "3000.00 SAR", IsVisible = true },null));

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