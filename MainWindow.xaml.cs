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

namespace SloppyJoe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeTheMenu();                                  // This method gets called as soon as the program starts.
        }

        private void MakeTheMenu()
        {
            MenuItem[] menuItems = new MenuItem[5];                                                                                         // We create an array of 5 references to the MenuItem-class. 
            string guacamolePrice;                                                                                                          // We declare this variable that later will contain the randomized price to add guacamole to the order.


            for (int i = 0; i < 5; i++)                                                                                                     // The loop iterates 5 times (as many times as dishes displayed on the menu)
            {
                menuItems[i] = new MenuItem();                                                                                              // For every iteration of the loop a new index/reference gets pointed at an object of the MenuItems-class.

                if (i >= 3)                                                                                                                 // On iteration 3 & 4 of the loop...
                {
                    menuItems[i].Breads = new string[] { "plain bagel", "onion bagel", "pumpernickel bagel", "everything bagel" };          // Add these 4 strings to the field Breads instad of the "original" ones.
                }
                menuItems[i].Generate();                                                                                                    // When the current index in the "menuItems"-array have been instatiated and points to the object and its fields, we call on the Generate()-method. This method generates the random-dishes that gets displayed on the menu.
            }

            // After all the indexes in the "menuItems"-array have received a random dish thru the Generate()-method, we do this:

            item1.Text = menuItems[0].Description;                  // We want to add the Description-field of index 0 (in the array "menuItems") to the first item-TextBlock. 
            price1.Text = menuItems[0].Price;                       // We want to add the Price-field of index 0 (in the array "menuItems") to the first price-TextBlock. 
            item2.Text = menuItems[1].Description;                  // And so on...
            price2.Text = menuItems[1].Price;
            item3.Text = menuItems[2].Description;
            price3.Text = menuItems[2].Price;
            item4.Text = menuItems[3].Description;
            price4.Text = menuItems[3].Price;
            item5.Text = menuItems[4].Description;
            price5.Text = menuItems[4].Price;

            MenuItem specialMenuItem = new MenuItem()               // The last item on the menu is for the daily special. We create an instance of the class MenuItem and call this instance "specialMenuItem"...
            {
                Proteins = new string[] { "Organic ham", "Mushroom patty", "Mortadella" },          // We set it's fields Proteins, Breads and Condiments to have special ingredients. 
                Breads = new string[] { "a gluten free roll", "a wrap", "pita" },
                Condiments = new string[] { "dijon mustard", "miso dressing", "au jus" }
            };
            specialMenuItem.Generate();                                                     // We then call the Generate()-method on the object and the method then randomizes the ingredients above. The result will be stored in the "Description" and "Price"-fields yet again. 

            item6.Text = specialMenuItem.Description;                                       // We want to add the "Description"-field of "specialMenuItem" to the last item-textBlock. 
            price6.Text = specialMenuItem.Price;                                            // We want to add the "Price"-field of "specialMenuItem" to the last price-textBlock. 

            MenuItem guacamoleMenuItem = new MenuItem();                                    // We create an instance of the class MenuItem and call this instance "guacamoleMenuItem". 
            guacamoleMenuItem.Generate();                                                   // We then call the Generate()-method on the object and the method generates a random price and stores it in the objects field called "Price". 
            guacamolePrice = guacamoleMenuItem.Price;

            guacamole.Text = "Add guacamole for " + guacamoleMenuItem.Price;                // We want to add this concatenated string containing the random price to the guacamole-TextBlock.
        }
    }
}
