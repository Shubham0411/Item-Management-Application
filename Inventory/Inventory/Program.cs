using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
     class ComputerProgram
    {
        public string name,category;
        public int code;
        public float size;
        

        //Method takes input of Computer Program Details from user
        public void InputDetails() 
        {
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Code");
            code = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter size");
            size = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter category");
            category = Console.ReadLine();
        }
    }

    //Inherits the variables of Computer Program for it's use
   class MusicFiles : ComputerProgram
    {
        public string singer_name;
        public int length;
        
        // This method takes input from user regarding the details of the song
            public void MusicInputDetails()
        {
            Console.WriteLine("Enter Singer name");
            singer_name = Console.ReadLine();
            Console.WriteLine("Enter Length of music");
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

    //Inherits Computer Program to use it's variables
    class Films:ComputerProgram
    {
        public string actor_name,director_name,actress_name;
        
        //This method asks the user for input
            public void FilmInputDetails()
        {
            Console.WriteLine("Enter Actor name");
            actor_name = Console.ReadLine();
            Console.WriteLine("Actress name");
            actress_name = Console.ReadLine();
            Console.WriteLine("Director name");
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
                Console.WriteLine("Computer Program" + i);
                computerProgram.InputDetails();
                Console.WriteLine("Name is " + computerProgram.name + " code is " + computerProgram.code +" size "+ computerProgram.size+" category "+ computerProgram.category);
                Console.WriteLine("Press to continue");
                Console.ReadKey();
            }
            
            for (int i=0;i<filmsObject.Length;i++)
            {
                Films films = new Films();
                Console.WriteLine(films.ToString());
                Console.WriteLine(" Films " + i);
                films.InputDetails();
                films.FilmInputDetails();
                Console.WriteLine("Name is " + films.name + " code is " + films.code + " size " + films.size + " category " + films.category + " Actor name " + films.actor_name + " Actress name " + films.actress_name + " Director name " + films.director_name);
                Console.WriteLine("Press to continue");
                Console.ReadKey();
            }
            
            for (int i =0;i<musicFilesObject.Length;i++)
            {
                MusicFiles musicFiles = new MusicFiles();
                Console.WriteLine(musicFiles.ToString());
                Console.WriteLine("Music Files" + i);
                musicFiles.InputDetails();
                musicFiles.MusicInputDetails();
                Console.WriteLine("Name is " + musicFiles.name + " code is " + musicFiles.code + " size " + musicFiles.size + " category " + musicFiles.category+"Singer name"+ musicFiles.singer_name+"length"+ musicFiles.length);
                Console.WriteLine("Press to continue");
                Console.ReadKey();
            }
        }
    }
}
