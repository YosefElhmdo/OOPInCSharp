using Interface;
            List<U> list = new List<U>();
            list.Add(new U());
            list.Add(new U());
            list.Add(new U());
            //U1=>U1
            //U2=>U2
            //U=>U
            U2 u1 = new U();
            u1.print();


        I1 i1 = new C();
        i1.print();
        i1.print1();
        I2 i2 = new C();
        Console.WriteLine("_____________________");
        C c = new C();
        c.print();
        c.print1();
        c.print2();
        c.print3();
        Console.WriteLine("_________________________");
        //Up Cassting
        I2 t = (I2)c;
        t.print2();
        t.print3();
        Console.WriteLine("___________________");
        //Down Cassting
        C cc = (C)t;
        cc.print();
        cc.print1();
        cc.print2();
        cc.print3();





