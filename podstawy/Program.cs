namespace podstawy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wiek = 19;
            double waga = 76.5;
            string imie = "Adam";

            Console.WriteLine("Podaj semestr studiów");
            int semestr = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Student ma na imie "+ imie +" ma "+ wiek+" lat, waży "+ waga +" kg i jest na "+
            //    semestr + " semestrze studiów");
            //Console.WriteLine($"Student ma na imie {imie}, ma {wiek} lat, waży {waga} kg " +
            //    $"i jest na {semestr} semestrze studiów");

            //int numer_albumu1 = 35423;
            //int numer_albumu2 = 34554;
            //int numer_albumu3 = 54678;

            //int[] numery_albumów = new int[5];
            //numery_albumów[0] = numer_albumu1;
            //numery_albumów[1] = numer_albumu2;
            //numery_albumów[2] = numer_albumu3;
            //numery_albumów[3] = 46623;
            //numery_albumów[4] = 43254;

            //List<int> lista_numerów_albumów = new List<int>();
            //lista_numerów_albumów.Add(numer_albumu1);
            //lista_numerów_albumów.Add(numer_albumu2);
            //lista_numerów_albumów.Add(numer_albumu3);
            //lista_numerów_albumów.RemoveAt(0);

            //if (imie == "Adam" || imie == "Bartosz")
            //{

            //}
            //else if (imie == "Tomasz")
            //{

            //}
            //else
            //{

            //}

            //switch (imie)
            //{
            //    case "Adam":
            //        Console.WriteLine();
            //        break;
            //    case "Bartosz":
            //        break;
            //    default:
            //        break;
            //}
            ////for (int i = 0; i<numery_albumów.Length; i++)
            //for (int i = 0; i<lista_numerów_albumów.Count; i++) //for i=1:lista_numerów_albumów.Count
            //{
            //    Console.WriteLine(lista_numerów_albumów [i]);
            //}//i++
            //foreach (int numer_albumu in numery_albumów) //for el=numery_albumów
            //{
            //    Console.WriteLine(numer_albumu);
            //}

            Student student = new Student();
            student.Imie = imie;
            student.Waga = waga;
            student.Wiek = wiek;
            student.Semestr = semestr;

            Student student2 = new Student();
            student2.Imie = "Bartosz";
            student2.Waga = 88;
            student2.Wiek = 24;
            student2.Semestr = semestr;

            List<Student> students = new List<Student>();
            students.Add(student);
            students.Add(student2);

            //            Console.WriteLine($"Student ma na imie {imie}, ma {wiek} lat, waży {waga} kg " +
            //$"i jest na {semestr} semestrze studiów");
            //Console.WriteLine($"Student ma na imie {student.Imie}, ma {student.Wiek} lat, waży {student.Waga} kg " +
            //$"i jest na {student.Semestr} semestrze studiów");

            foreach(Student s  in students)
            {
                Console.WriteLine($"Student ma na imie {s.Imie}, ma {s.Wiek} lat, waży {s.Waga} kg " +
                $"i jest na {s.Semestr} semestrze studiów");  
            }
        }
    }
}
