namespace Constructor
{
    class CopyConstructor
    {
        private string name;
        private int year;

         
        public CopyConstructor(CopyConstructor s)
        {
            name = s.name;
            year = s.year;
        }
        public CopyConstructor(string _name, int _year)
        {
            this.name = _name;
            this.year = _year;
        }
        public string GetDatail()
        {
            return "User Name is " + name + " and date of year is " + year;
        }
    }
}
