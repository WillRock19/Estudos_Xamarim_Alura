using AluraApp.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AluraApp
{
    public partial class MainPage : ContentPage
    {
        public List<Book> Books { get; set; }

        public MainPage()
        {
            InitializeComponent();
            InitializeBooksCollection();

            listViewBooks.ItemsSource = Books;
            Books.Add(new Book("Batman: Terra um 3", "Geoff Johns", 55M));

            //BindingContext = this;
        }

        private void InitializeBooksCollection()
        {
            Books = new List<Book>()
            {
                new Book("A Torre Negra: O pistoleiro", "Stephen King", 49.90M),
                new Book("Harry Potter e a câmara secreta", "J.K. Rowling", 56M),
                new Book("Demolidor: revelado", "Ed brubaker", 70.90M),
                new Book("Batman: ano um", "Frank Miller", 45.20M)
            };
        }

        private void InformSelectedItem(object sender, ItemTappedEventArgs e)
        {
            var selectedBook = (Book)e.Item;
            DisplayAlert("Item Selecionado", $"Você selecionou o livro {selectedBook.Name}, que custa {selectedBook.Price}", "Ta serto", "Endoidou?!");
        }
    }
}
