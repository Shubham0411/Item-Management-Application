using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    //4 basic variables, they form the skeleton of code
    abstract class MyAbstractDetails
    {
        public string name, category;
        public int code;
        public float size;

        public void InputDetails()
        {
            Console.Write("Enter name :-");
            name = Console.ReadLine();
            Console.Write("Enter Code:-");
            code = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter size:-");
            size = float.Parse(Console.ReadLine());
            Console.Write("Enter category:-");
            category = Console.ReadLine();
        }

    }

    class ComputerProgram:MyAbstractDetails
    {
        //First Class, extends MyAbstarctDetails to use the variables
    }

    //Inherits the variables of MyAbstractDetails for it's use
   class MusicFiles : MyAbstractDetails
    {
        public string singer_name;
        public int length;
        
        // This method takes input from user regarding the details of the song
            public void MusicInputDetails()
        {
            Console.Write("Enter Singer name:-");
            singer_name = Console.ReadLine();
            Console.Write("Enter Length of music:-");
            length = Convert.ToInt32(Console.ReadLine());
        }

        public void PlayMusic()
        {
            //Not implemented yet but created for future use
        }
        public void ReteriveInformationMusic()
        {
            //Not implemented yet but created for future use
        }
    }

    //Inherits MyAbstractDetails to use it's variables
    class Films:MyAbstractDetails
    {
        public string actor_name,director_name,actress_name;
        
        //This method asks the user for input
            public void FilmInputDetails()
        {
            Console.Write("Enter Actor name:-");
            actor_name = Console.ReadLine();
            Console.Write("Actress name:-");
            actress_name = Console.ReadLine();
            Console.Write("Director name:-");
            director_name = Console.ReadLine();
        }

        public void PlayFilms()
        {
            //Not implemented yet but created for future use
        }
        public void ReteriveInformationFilms()
        {
            //Not implemented yet but created for future use
        }
    }

    class Inventory
    { 
        static void Main(string[] args)
        {
            ComputerProgram[] computerProgramsObject = new ComputerProgram[5];
            Films[] filmsObject = new Films[5];
            MusicFiles[] musicFilesObject = new MusicFiles[5];
            
            for (int i=0;i<computerProgramsObject.Length;i++)
            {
                ComputerProgram computerProgram = new ComputerProgram();
                Console.WriteLine(computerProgram.ToString());
                Console.WriteLine("Computer Program " + (1+i) +" ");
                computerProgram.InputDetails();
                Console.WriteLine("Name is " + computerProgram.name + " code is " + computerProgram.code +" size "+ computerProgram.size+" category "+ computerProgram.category);
                Console.WriteLine("Press to continue");
                Console.ReadKey();
                Console.WriteLine("");
            }
            
            for (int i=0;i<filmsObject.Length;i++)
            {
                Films films = new Films();
                Console.WriteLine(films.ToString());
                Console.WriteLine(" Films " + (1+i)+" ");
                films.InputDetails();
                films.FilmInputDetails();
                Console.WriteLine("Name is " + films.name + " code is " + films.code + " size " + films.size + " category " + films.category + " Actor name " + films.actor_name + " Actress name " + films.actress_name + " Director name " + films.director_name);
                Console.WriteLine("Press to continue");
                Console.ReadKey();
                Console.WriteLine("");
            }
            
            for (int i =0;i<musicFilesObject.Length;i++)
            {
                MusicFiles musicFiles = new MusicFiles();
                Console.WriteLine(musicFiles.ToString());
                Console.WriteLine("Music Files" + (1+i) + " ");
                musicFiles.InputDetails();
                musicFiles.MusicInputDetails();
                Console.WriteLine("Name is " + musicFiles.name + " code is " + musicFiles.code + " size " + musicFiles.size + " category " + musicFiles.category+"Singer name"+ musicFiles.singer_name+"length"+ musicFiles.length);
                Console.WriteLine("Press to continue");
                Console.ReadKey();
                Console.WriteLine("");
            }
        }
    }
}
