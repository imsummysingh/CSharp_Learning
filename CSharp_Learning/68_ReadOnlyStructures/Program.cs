using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Read only structure Example
namespace _68_ReadOnlyStructures
{
    //Creating Readonly structures
    public readonly struct Marvel
    {
        //field
        private readonly string _characterName;

        //public readonly property
        public string CharacterName
        {
            get
            {
                return _characterName;
            }
        }

        //public method
        public void GetCharacterName()
        {
            Console.WriteLine(this.CharacterName);
        }

        //Constructor
        public Marvel(string characterName)
        {
            this._characterName = characterName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Creating structure instance
            Marvel m = new Marvel("Iron Man");
            Console.WriteLine(m.CharacterName);
            m.GetCharacterName();

            Console.ReadLine();
        }
    }
}
