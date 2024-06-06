using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Parameterized constructor with Structure 
namespace _66_ParameterizedStructureConstructor
{
    //creating structure
    public struct Category
    {
        //private fields
        private int _categoryId;
        private string _categoryName;

        //parameterized constructor
        public Category(int categoryId, string categoryName)
        {
            _categoryId = categoryId;
            _categoryName = categoryName;
        }

        //properties
        public int CategoryId
        {
            set
            {
                _categoryId = value;
            }
            get
            {
                return _categoryId;
            }
        }

        public string CategoryName
        {
            set
            {
                _categoryName = value;
            }
            get
            {
                return _categoryName;
            }
        }

        //public method
        public int GetCategoryNameLength()
        {
            return this._categoryName.Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creating instance for the structure category
            Category c = new Category(101,"Ipad");

            Console.WriteLine(c.CategoryId);
            Console.WriteLine(c.CategoryName);
            Console.WriteLine("The length of category name: " + c.GetCategoryNameLength());


            Console.ReadLine();
        }
    }
}
