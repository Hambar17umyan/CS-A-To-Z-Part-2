namespace Task_01
{
    internal class Human
    {
        public Passport Passport { get; private set; }
        public string Nick { get; private set; }
        public Profession Profession { get; private set; }
        public string PassportNumber => Passport.ID;
        public string Name => Passport.Name;
        public string Surname => Passport.Surname;
        public DateOnly DateOfBirth => Passport.DateOfBirth;

        public Human(Passport passport, Profession profession, string nick = "None")
        {
            Passport = passport;
            Nick = nick;
            Profession = profession;
        }

        public override string ToString()
        {
            return $"{PassportNumber},{Name},{Surname},{Nick},{DateOfBirth},{Profession}";
        }
    }
}