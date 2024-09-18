namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human(
                new Passport("Sergey", "Hambardzumyan", new DateOnly(2007, 11, 27)), 
                Profession.Programmer);

            Human human2 = new Human(
                new Passport("Poghos", "Poghosyan", new DateOnly(2000, 9, 18)),
                Profession.Engineer,
                "Pogh");

            Human human3 = new Human(
                new Passport("Petros", "Petrosyan", new DateOnly(1964, 2, 25)),
                Profession.Doctor,
                "Peto");

            Human human4 = new Human(
                new Passport("Martiros", "Poghosyan", new DateOnly(2005, 9, 17)),
                Profession.Automechanic,
                "Mrdo");

            Human human5 = new Human(
                new Passport("Anna", "Avanesyan", new DateOnly(1990, 4, 17)),
                Profession.Doctor,
                "Pogh");

            DataRepository.WriteInExcel("table1.csv", human1, human2, human3, human4, human5);

            DataRepository.WriteAsJson(human1);
            DataRepository.WriteAsJson(human2);
            DataRepository.WriteAsJson(human3);
            DataRepository.WriteAsJson(human4);
            Human human1Copy = DataRepository.ReadAsJson($"{human1.PassportNumber}.txt");
            Human human2Copy = DataRepository.ReadAsJson($"{human2.PassportNumber}.txt");
            Human human3Copy = DataRepository.ReadAsJson($"{human3.PassportNumber}.txt");
            Human human4Copy = DataRepository.ReadAsJson($"{human4.PassportNumber}.txt");
            DataRepository.WriteInExcel("result.csv", human1Copy, human2Copy, human3Copy, human4Copy);

            //Breakpoint here
            DataRepository.Clear();
        }
    }
}
