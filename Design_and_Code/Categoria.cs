using System;

namespace Design_and_Code
{
    public class Categoria
    {
        public string Name;
        public string Description;

        public List<Level>Level;
    }

    public class List<Level>
    {
        public string High;
        public string Medium;
        public string Low;
    }

    public class subcategory : Categoria
    {
        public string SubName;
        public string SubDescription;
    }




}
