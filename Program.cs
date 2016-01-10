using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooksManager
{
    public enum Genres
    {
        BioOrAutoBiography = 1,
        Classic,
        ComicAndGraphics,
        CrimeAndDetective,
        Drama,
        Essay,
        Fable,
        FairyTale,
        Fantasy,
        FictionNarative,
        FictionInVerse,
        Horror,
        LabReport,
        Legend,
        MagicalRealism,
        Mystery,
        Mythology,
        NarrativeNonFiction,
        RealisticFiction,
        Referencebook,
        ScienceFiction,
        ShortStory,
        Speech,
        SuspenseOrThriller,
        TallTale,
        TextBook,
        Western
    }
    public enum Languages
    {
        English = 1,
        Hindi,
        Tamil,
        Marathi,
        Telugu,
        Gujarati,
        Malayalam,
        Sanskrit,
        Bengali,
        Kannada,
        German,
        French,
        Punjabi,
        Spanish,
        Urdu,
        Chinese,
        Nepali,
        Assamese,
        Italian,
        Dutch,
        Arabic,
        Japanese,
        Russian,
        Korean,
        Danish,
        Albanian,
        Swedish,
        Greek,
        Afrikaans,
        Polish,
        Latin,
        Persian,
        Thai,
        Turkish,
        Norwegian,
        Ukrainian,
        Bosnian,
        Bulgarian,
        Czech,
        Estonian,
        Finnish,
        Hungarian,
        Irish,
        Javanese,
        Latvian,
        Malay,
        Mongolian,
        Serbian,
        Tibetan,
        Vietnamese,
    }
    public interface IBook
    {
        List<Genres> Genre { get; set; }
        string Name { get; set; }
        double Price { get; set; }
        int Discount { get; set; }
        long ISBN { get; set; }
        string[] Authors { get; set; }
        string Publication { get; set; }
        DateTime ReleaseDate { get; set; }
        string Description { get; set; }
        Languages Language { get; set; }
    }
    public class Book : IBook
    {
        private List<Genres> _genre;
        private string _name;
        private double _price;
        private int _discount;
        private long _isbn;
        private string[] _authors;
        private string _publication;
        private DateTime _releaseDate;
        private string _description;
        private Languages _language;

        public List<Genres> Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public int Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }
        public long ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        public string[] Authors
        {
            get { return _authors; }
            set { _authors = value; }
        }
        public string Publication
        {
            get { return _publication; }
            set { _publication = value; }
        }
        public DateTime ReleaseDate
        {
            get { return _releaseDate; }
            set { _releaseDate = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public Languages Language
        {
            get { return _language; }
            set { _language = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            int choice;
            Book x = new Book();
            x.Genre = new List<Genres>();
            x.Language = (Languages)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Enum.GetName(typeof(Languages), x.Language).ToString());
            do
            {
                //Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("\n\t\tWelcome to Library Manager.\n\n");
                Console.ResetColor();
                Console.WriteLine("Please enter your choice.");
                Console.WriteLine("\n\t1. Add a new book to the Library.");
                Console.WriteLine("\n\t2. Edit the details of a Book.");
                Console.WriteLine("\n\t3. Delete a Book details from the Library.");
                Console.WriteLine("\n\t4. Show a Book details.");
                Console.WriteLine("\n\t5. Search for Books.");
                Console.WriteLine("\n\t6. Exit Library Manager");
                Console.Write(">>> ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Book newBook = new Book();
                        newBook.Authors = new string[10];
                        newBook.Genre = new List<Genres>();
                        Console.WriteLine("Please enter the Name of the Book.");
                        newBook.Name = Console.ReadLine();

                        Console.WriteLine("Please enter the Price of the Book.");
                        newBook.Price = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Please enter Discount for the Book if any.");
                        newBook.Discount = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Please enter the ISBN code of the Book.");
                        newBook.ISBN = Convert.ToInt64(Console.ReadLine());

                        Console.WriteLine("Please enter the Authors of the Book.");
                        for (int i = 0; i < newBook.Authors.Length; i++)
                        {
                            Console.Write("Enter Author {0}:", i+1);
                            newBook.Authors[i] = Console.ReadLine();
                            Console.WriteLine("\nHit 'Enter' to enter next author or 'Esc' to go to next variable.");
                            if(Console.ReadKey().Key == ConsoleKey.Escape)
                            {
                                break;
                            }
                            else if(Console.ReadKey().Key == ConsoleKey.Enter)
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }

                        Console.WriteLine("Please enter the Publication Company of the Book.");
                        newBook.Publication = Console.ReadLine();

                        Console.WriteLine("Please enter the Language of the Book. (enter the choice number)");
                        Console.WriteLine("\t1.  English\t2.  Hindi\t3.  Tamil\t4.  Marathi\t5.  Telugu\t6.  Gujarati\t7.  Malayalam\t8.  Sanskrit\t9.  Bengali\t10. Kannada\n" +
                                          "\t11. German\t12. French\t13. Punjabi\t14. Spanish\t15. Urdu\t16. Chinese\t17. Nepali\t18. Assamese\t19. Italian\t20. Dutch\n" +
                                          "\t21. Arabic\t22. Japanese\t23. Russian\t24. Korean\t25. Danish\t26. Albanian\t27. Swedish\t28. Greek\t29. Afrikaans\t30. Polish\n" +
                                          "\t31. Latin\t32. Persian\t33. Thai\t34. Turkish\t35. Norwegian\t36. Ukrainian\t37. Bosnian\t38. Bulgarian\t39. Czech\t40. Estonian\n" +
                                          "\t41. Finnish\t42. Hungarian\t43. Irish\t44. Javanese\t45. Latvian\t46. Malay\t47. Mongolian\t48. Serbian\t49. Tibetan\t50. Vietnamese\n");
                        newBook.Language = (Languages)Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Please enter the Genre/s of the Book. (enter the choice number)");
                        Console.WriteLine(@"1.  BioOrAutoBiography
                                            2.  Classic
                                            3.  ComicAndGraphics
                                            4.  CrimeAndDetective
                                            5.  Drama
                                            6.  Essay
                                            7.  Fable
                                            8.  FairyTale
                                            9.  Fantasy
                                            10. FictionNarative
                                            11. FictionInVerse
                                            12. Horror
                                            13. LabReport
                                            14. Legend
                                            15. MagicalRealism
                                            16. Mystery
                                            17. Mythology
                                            18. NarrativeNonFiction
                                            19. RealisticFiction
                                            20. Referencebook
                                            21. ScienceFiction
                                            22. ShortStory
                                            23. Speech
                                            24. SuspenseOrThriller
                                            25. TallTale
                                            26. TextBook
                                            27. Western");
                        while(Console.ReadKey().Key != ConsoleKey.Escape)
                        {
                            newBook.Genre.Add((Genres)Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine("\nHit 'Enter' to enter next author or 'Esc' to go to next variable.");
                            if(Console.ReadKey().Key != ConsoleKey.Enter)
                            {
                                continue;
                            }
                            else { break; }
                        }
                        
                        string g = string.Empty;
                        foreach (Genres genre in newBook.Genre.Distinct<Genres>())
                        {
                            g = string.Concat(Enum.GetName(typeof(Genres), genre).ToString(), ", ", g);
                        }
                        Console.WriteLine("The details of the book are as follows,\n\tName:\t\t{0},\n\tPrice:\t\t{1},\n\tDiscount:\t\t{2},\n\tISBN:\t\t{3},\n\tPublication Company:\t\t{4},\n\tLanguage:\t\t{5},\n\tAuthors:\t\t{6},\n\tGenres:\t\t{7}",
                                            newBook.Name, newBook.Price, newBook.Discount, newBook.ISBN, newBook.Publication, Enum.GetName(typeof(Languages), newBook.Language), string.Join(", ", newBook.Authors), g);
                        
                        File.WriteAllText(@"C:\Users\vkkpp\Desktop\Projects\C# Learning\LibraryBooksManager\Books.json", JsonConvert.SerializeObject(JsonConvert.SerializeObject(newBook, Formatting.Indented)));
                        Console.ReadLine();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        flag = true;
                        break;
                    default:
                        break;
                }
            } while (flag == false);
        }
    }
}
