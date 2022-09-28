using Dal;

namespace Sep28Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operations o = new Operations();
            MemberOperations mo = new MemberOperations();
            Console.WriteLine("1.Book 2.Member");
            int io = Convert.ToInt32(Console.ReadLine());
            switch (io)
            {
                case 1:
                    Console.WriteLine("1.Add 2.Update 3.Delete 4.Find 5.Showall 6.Count");
                    int k = Convert.ToInt32(Console.ReadLine());
                    switch (k)
                    {
                        case 1:
                            Books1 m = new Books1();
                            Console.WriteLine("Enter Book Id");
                            m.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Book name");
                            m.Name = Console.ReadLine();
                            Console.WriteLine("Enter Author");
                            m.Author = Console.ReadLine();
                            Console.WriteLine("Enter Cost");
                            m.Cost = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter Category");
                            m.Category = Console.ReadLine();
                            o.insertbook(m);
                            break;
                        case 2:
                            Console.WriteLine("Enter the book no you want to update");
                            int op = Convert.ToInt32(Console.ReadLine());
                            Books1 m1 = new Books1();
                            Console.WriteLine("Enter Book Id");
                            m1.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Book name");
                            m1.Name = Console.ReadLine();
                            Console.WriteLine("Enter Author");
                            m1.Author = Console.ReadLine();
                            Console.WriteLine("Enter Cost");
                            m1.Cost = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Category");
                            m1.Category = Console.ReadLine();
                            o.updatebook(op, m1);
                            break;
                        case 3:
                            Console.WriteLine("Enter Book Id you want to delete");
                            int hi = Convert.ToInt32(Console.ReadLine());
                            o.deletebook(hi);
                            break;
                        case 4:
                            Console.WriteLine("Enter Book Id you want to find");
                            int hik = Convert.ToInt32(Console.ReadLine());
                            Books1 lo = new Books1();
                            lo = o.findbook(hik);
                            Console.WriteLine(lo.Id + " " + lo.Name + " " + lo.Author + " " + lo.Cost + " " + lo.Category);
                            break;
                        case 5:

                            List<Books1> books1s = new List<Books1>();
                            books1s = o.list1();
                            foreach (var item in books1s)
                            {
                                Console.WriteLine(item.Id + " " + item.Name.Trim() + " " + item.Author + " " + item.Cost + " " + item.Category);
                            }
                            break;
                        case 6:
                            Console.WriteLine($"No. of books {o.Bookcount()}");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("1.Add 2.Update 3.Delete 4.Find 5.Showall 6.Count");
                    int k1 = Convert.ToInt32(Console.ReadLine());
                    switch (k1)
                    {
                        case 1:
                            Member1 m1 = new Member1();
                            Console.WriteLine("Enter you member id");
                            m1.member_id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter you member name");
                            m1.member_name = Console.ReadLine();
                            Console.WriteLine("Enter you member Accopendate");
                            m1.Accopen = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Enter you maxbooks");
                            m1.maxbooks = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter you penalty");
                            m1.penalty= Convert.ToDouble(Console.ReadLine());
                            mo.insertmember(m1);

                            break;
                        case 2:
                            Console.WriteLine("Enter number you want to update");
                            int j= Convert.ToInt32(Console.ReadLine());
                            Member1 m2 = new Member1();
                            Console.WriteLine("Enter you member id");
                            m2.member_id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter you member name");
                            m2.member_name = Console.ReadLine();
                            Console.WriteLine("Enter you member Accopendate");
                            m2.Accopen = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Enter you maxbooks");
                            m2.maxbooks = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter you penalty");
                            m2.penalty = Convert.ToDouble(Console.ReadLine());
                            mo.updatemember(j,m2);
                            break;
                        case 3:
                            Console.WriteLine("Enter number you want to delete");
                            int ji = Convert.ToInt32(Console.ReadLine());
                            mo.deletemember(ji);
                            break;
                        case 4:
                            Console.WriteLine("Enter number you want to find");
                            int jii = Convert.ToInt32(Console.ReadLine());
                            Member1 koi = new Member1();
                            koi=mo.findmember(jii);
                            Console.WriteLine(koi.member_id + " " + koi.member_name + " " + koi.Accopen + " " + koi.maxbooks + " " + koi.penalty);
                            break;

                        case 5:
                            List<Member1> lot = new List<Member1>();
                            lot = mo.Showall();
                            foreach(var item in lot)
                            {
                                Console.WriteLine(item.member_id + " " + item.member_name + " "+item.Accopen+" "+ item.maxbooks + " " + item.penalty);
                            }

                            break;
                        case 6:
                            Console.WriteLine("Noof member count is" + " " + mo.membercount());
                            break;
                    }
                    break;
            }
            Console.ReadLine();

        }
    }
}