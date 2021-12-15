using System;

namespace HomeWorkUser
{
    class Program
    {
        static void Main(string[] args)
        {

            List<User> listUser = new List<User>();

            Console.WriteLine("Welcome To User App \n" +
                "To Add User enter-1 \n" +
                "To Editing User information -2 \n" +
                "To Delete User -3 \n" +
                "To Show one User-4 \n" +
                "To Show all User-5 \n"
                );


            int Result = int.Parse(Console.ReadLine());

            switch (Result)
            {
                case 1:
                    GetDitel(listUser);
                    SaveAllUser(listUser);
                    break;

                case 2:

                    break;

                case 3:
                    DeleteUser();
                    break;

                case 4:
                    SeeOneUser();
                    break;

                case 5:
                    ConsoleUser();
                    break;

            }

        }


        static void GetDitel(List<User> list)
        {
            try
            {

                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("Enter First Name:");
                    string FN = Console.ReadLine();

                    Console.WriteLine("Enter Last Name:");
                    string LN = Console.ReadLine();

                    Console.WriteLine("Enter Born Year:");
                    int Born = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Email:");
                    string EMAIL = Console.ReadLine();


                    User User1 = new User(FN, LN, Born, EMAIL);

                    list.Add(User1);
                    SaveOneUser(list, FN);
                }

                list.Sort();
            }
            catch (FormatException)
            {
                Console.WriteLine("value must be number");

            }
            catch (FormatException)
            {
                Console.WriteLine("value must be number");

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void SaveAllUser(List<User> list)
        {
            try
            {
                FileStream fs = new FileStream($@"C:\Users\liory\source\repos\UserFile\UserList.txt", FileMode.Append);
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    foreach (User item in list)
                    {
                        writer.WriteLine($"the first name: {item.FirstName} | the last name: {item.LastName} | the Born is: {item.Born} | the Email is: {item.Email} | ");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ConsoleUser()
        {
            try
            {
                FileStream fs = new FileStream($@"C:\Users\liory\source\repos\UserFile\UserList.txt", FileMode.Open);
                using (StreamReader reader = new StreamReader(fs))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("value must be number");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void SaveOneUser(List<User> list, string FN)
        {
            try
            {
                FileStream fs = new FileStream($@"C:\Users\liory\source\repos\UserFile\{FN}.txt", FileMode.Append);
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    foreach (User item in list)
                    {
                        writer.WriteLine($"the first name: {item.FirstName} | the last name: {item.LastName} | the Born is: {item.Born} | the Email is: {item.Email} | ");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void SeeOneUser()
        {

            try
            {
                Console.WriteLine("what the name of User");
                string FN = Console.ReadLine();

                FileStream fs = new FileStream($@"C:\Users\liory\source\repos\UserFile\{FN}.txt", FileMode.Open);
                using (StreamReader reader = new StreamReader(fs))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
                throw new Exception($"User {FN} - didnt found");
            }
            catch (FormatException)
            {
                Console.WriteLine("value must be number");

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void DeleteUser()
        {
            try
            {
                Console.WriteLine("enter a name user you went to Delete");
                string nameUser = Console.ReadLine();

                File.Delete($@"C:\Users\liory\source\repos\UserFile\{nameUser}.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}