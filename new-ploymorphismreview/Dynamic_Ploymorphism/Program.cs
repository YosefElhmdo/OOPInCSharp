namespace Dynamic_Ploymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Machine machine = new Fighter();
            List<Machine> lst = new List<Machine>();
            lst.Add(new Fighter());
            lst.Add(new Fighter());
            lst.Add(new Fighter());
            lst.Add(new Fighter());
            lst.Add(new Fighter());
            lst.Add(new Fighter());
            lst.Add(new Plain());
            lst.Add(new Plain());
            lst.Add(new Plain());
            lst.Add(new Tank());
            lst.Add(new Tank());
            lst.Add(new Tank());
            lst.Add(new Tank());
            lst.Add(new BkcFighter());
            lst.Add(new BkcFighter());
            lst.Add(new BkcFighter());
            lst.Add(new BkcFighter());
            lst.Add(new BkcFighter());
            lst.Add(null);
            lst.Add(null);
            lst.Add(null);
            foreach (Machine item in lst)
            {
                if (item != null)
                {
                    item.print();
                }
            }
            Machine machine = new Machine();
            machine.print();
            Fighter fighter = new Fighter();
            fighter.print();
            BkcFighter bkcFighter = new BkcFighter();
            bkcFighter.print();
            Tank tank = new Tank();
            tank.print();
            Plain plain = new Plain();
            plain.print();
        }
    }
}

