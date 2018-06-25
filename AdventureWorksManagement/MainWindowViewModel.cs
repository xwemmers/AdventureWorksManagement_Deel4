using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using AWM.BusinessLayer;
using AWM.DataLayer;

namespace AdventureWorksManagement
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        ProductLogic pl = new ProductLogic();
        CategoryLogic cl = new CategoryLogic();

        public List<ProductViewModel> Products { get; set; }
        public List<ProductCategory> MainCategories { get; set; }
        public List<ProductCategory> SubCategories { get; set; }

        private ProductCategory _currentMainCategory;

        public ProductCategory CurrentMainCategory
        {
            get { return _currentMainCategory; }
            set
            {
                _currentMainCategory = value;
                GetSubCategories();
            }
        }

        private ProductCategory _currentSubCategory;

        public ProductCategory CurrentSubCategory
        {
            get { return _currentSubCategory; }
            set
            {
                _currentSubCategory = value;
                GetProducts();
            }
        }


        private string _message;

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propname));
        }

        public MainWindowViewModel()
        {
            // De constructor mag niet async zijn! Maar hij mag wel async functies aanroepen...

            this.Message = "Getting products. Patience...";
            GetMainCategories();
            GetAllProducts();
        }

        private void GetMainCategories()
        {
            this.MainCategories = cl.GetMainCategories();
            OnPropertyChanged(nameof(MainCategories));
        }

        private void GetSubCategories()
        {
            this.SubCategories = cl.GetSubCategories(this.CurrentMainCategory.ProductCategoryID);
            OnPropertyChanged(nameof(SubCategories));
        }

        public async void GetAllProducts()
        {
            this.Products = await pl.GetAllProducts();
            OnPropertyChanged(nameof(Products));
            this.Message = "The data was loaded!";
        }

        public void GetProducts()
        {
            if (this.CurrentSubCategory == null)
                this.Products = null;
            else
                this.Products = pl.GetProducts(this.CurrentSubCategory.ProductCategoryID);

            OnPropertyChanged(nameof(Products));
        }

    }
}
