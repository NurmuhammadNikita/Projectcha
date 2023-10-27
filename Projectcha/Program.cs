namespace Projectcha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name, Surname, Email, Login, Password,Role,ColumnName,Value,ConColumnName,ConValue;
            int amal=5,usul;


            /* Name = "Nurmuhammad";
             Surname = "Sharobiddinov";
             Email = "888legolas77@gmail.com";
             Login = "NikitaN";
             Password = "Neal09";
             AdminService.CreateEmployee(Name,Surname,Email,Login,Password,Role.CEO);
 */

            //AdminService.CreateEmployee("Kamronbek", "Ibragimov", "Ibragimovkamron@gmail.com", "Kamron010", "Kamron010", Role.Programmer);

            //AdminService.DeleteEmployee("id", "1");

            //AdminService.UpdateEmployee("Empolyee", "Password", "Niki09", "Login", "NikitaN");


            //AdminService.DeepDeleteEmployee("Name", "Nurmuhammad");

            //AdminService.GetAllEmployee();

            //AdminService.GetByEmployee("Name", "Nurmuhammad");




            do
            {
                Console.Write("1.Qo'shish\t2.Yangilash\t3.O'chirish\t4.Ko'rish\t5.To'liq Jadvalni ko'rish\n0.Chiqish\nAmalni kiriting: ");
                amal = int.Parse(Console.ReadLine());

                switch (amal)
                {
                    case 0: break;

                    case 1:
                        {
                            Console.Write("Ismni kiriting: ");
                            Name = Console.ReadLine();

                            Console.Write("Familiyani kiriting: ");
                            Surname = Console.ReadLine();

                            Console.Write("Emailni kiriting: ");
                            Email = Console.ReadLine();

                            Console.Write("Login kiriting: ");
                            Login = Console.ReadLine();

                            Console.Write("Parol kiriting: ");
                            Password = Console.ReadLine();

                            Console.WriteLine("Ro'llar--->\nAdmin\tProgrammer\tOfficer\tCleaner\tRecruiter\nManager\tCEO \tCoFounder\tFounder, ");
                            Console.Write("Rolini kiriting: ");
                            Role = Console.ReadLine();

                            AdminService.CreateEmployee(Name, Surname, Email, Login, Password, Role);
                            Console.Clear();

                            Console.WriteLine("Ma'lumotlaringiz qo'shildi!!!");
                            Console.ReadKey();
                        }

                        break;



                    case 2:

                    {   Console.WriteLine("Ustun nomini kiriting: ");
                        ColumnName = Console.ReadLine();
                        Console.WriteLine("Qiymatini kiriting: ");
                        Value = Console.ReadLine();
                        Console.WriteLine("Qaysi ustun bo'yicha kiriting: ");
                        ConColumnName = Console.ReadLine();
                        Console.WriteLine("Shart uchun qiymat kiriting: ");
                        ConValue = Console.ReadLine();

                        AdminService.UpdateEmployee(ColumnName, Value, ConColumnName, ConValue);
                        Console.Clear();
                        Console.WriteLine("Ma'lumot yangilandi!!!");
                        Console.ReadKey(); 
                    }

                        break;

                        case 3:
                        {
                            Console.WriteLine("1.Savatga tashlash\t2.To'liq o'chirish");
                            usul = int.Parse(Console.ReadLine());
                            Console.Write("Qaysi ustun bo'yicha qidiray: ");
                            ColumnName = Console.ReadLine();
                            Console.Write("Qiymat bering: ");
                            Value = Console.ReadLine();

                            if (usul == 1)
                            {
                                AdminService.DeleteEmployee(ColumnName, Value);
                            }
                            else
                            {
                                AdminService.DeepDeleteEmployee(ColumnName, Value);
                            }
                            Console.Clear();
                            Console.WriteLine("Ma'lumot o'chirildi!!!");
                            Console.ReadKey();
                            break;
                        }



                        case 4:
                        {
                            Console.WriteLine("1.To'liq Jadvalni ko'rish\t2.Bitta elementni ko'rish");
                            usul = int.Parse(Console.ReadLine());

                            if(usul == 1)
                            {
                                AdminService.GetAllEmployee();
                            }
                            else 
                            {
                                Console.Write("Qaysi ustun bo'yicha qidiray: ");
                                ColumnName = Console.ReadLine();
                                Console.Write("Qiymat bering: ");
                                Value = Console.ReadLine();
                                AdminService.GetByEmployee(ColumnName,Value); 
                                
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        break;
                }



                Console.Clear();
            } while (amal != 0);




        }
    }
}
