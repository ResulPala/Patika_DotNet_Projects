using System;
using System.Collections.Generic;

namespace phonebook
{
    public class contactsProgram
    {
        string inputSelect;
        List<contacts> contactsList = new List<contacts>();
        

        
        public void Begin()
        {
            contacts contact1 = new contacts() {Name = "Prof. Dr. Abuzer", Surname = "Kömürcü", Number = 5361234501};
            contacts contact2 = new contacts() {Name = "Tadmayacan", Surname = "AsitAnhidrit", Number = 5361234502};
            contacts contact3 = new contacts() {Name = "Baghmayacan", Surname = "AsitAnhidrit", Number = 5361234503};
            contacts contact4 = new contacts() {Name = "Koghlamayacan", Surname = "AsitAnhidrit", Number = 5361234504};
            contacts contact5 = new contacts() {Name = "Doghunmayacan", Surname = "AsitAnhidrit", Number = 5361234505};

            contactsList.Add(contact1);
            contactsList.Add(contact2);
            contactsList.Add(contact3);
            contactsList.Add(contact4);
            contactsList.Add(contact5);

            while(true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: \n" +
                                  "*******************************************\n" + 
                                  "(1) Yeni Numara Kaydet\n" + 
                                  "(2) Varolan Numarayı Sil\n" + 
                                  "(3) Varolan Numarayı Güncelle\n" + 
                                  "(4) Rehberi Listelemek\n" + 
                                  "(5) Rehberde Arama Yapmak\n");

                inputSelect = Console.ReadLine();

                if(inputSelect.Equals("1")) Add();

                else if(inputSelect.Equals("2")) Delete();
                
                else if(inputSelect.Equals("3")) Update();

                else if(inputSelect.Equals("4")) Listing();

                else if(inputSelect.Equals("5")) Search();

                else Console.WriteLine("Lütfen geçerli bir değer giriniz!");

            }
                  

        }

        public void Add()
        {
            for (int i = 0; i < 1; i++)
            {
                contacts contact = new contacts() {};
                Console.WriteLine("Lütfen isim giriniz             :");
                contact.Name = Console.ReadLine().ToLower();
                Console.WriteLine("Lütfen soyisim giriniz             :");
                contact.Surname = Console.ReadLine().ToLower();
                Console.WriteLine("Lütfen numara giriniz             :");
                contact.Number = long.Parse(Console.ReadLine());

                contactsList.Add(contact);
                
            }

        }

        public void Delete()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string inputDelete = Console.ReadLine().ToLower();

            foreach (var member in contactsList)
            {
                if (member.Name.Equals(inputDelete) || member.Surname.Equals(inputDelete))
                {
                    Console.WriteLine("{0} {1} rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", member.Name, member.Surname);
                    if (Console.ReadLine().Equals("y"))
                    {
                        contactsList.Remove(member);
                        Console.WriteLine("{0} {1} rehberden silindi.", member.Name, member.Surname);
                    }

                    else if(Console.ReadLine().Equals("n"))
                    {
                        Begin();
                    }

                    else  
                    {
                        Console.WriteLine("Lütfen geçerli bir değer giriniz!");
                        Delete();               
                    }
                }

                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n" +
                                      "* Silmeyi sonlandırmak için : (1)\n" + 
                                      "* Yeniden denemek için      : (2)"); 

                    if (Console.ReadLine() == "1")  Begin();
                    else if (Console.ReadLine() == "2")  Delete();
                    else
                    {
                        Console.WriteLine("Lütfen geçerli bir değer giriniz!");
                        Delete();  
                    }
                }
            }

        }

        public void Update()
        {
            Console.WriteLine("Lütfen güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string inputUpdate = Console.ReadLine().ToLower();

            foreach (var member in contactsList)
            {
                if (member.Name.Equals(inputUpdate) || member.Surname.Equals(inputUpdate))
                {
                    Console.WriteLine("{0} {1} rehberden güncellenmek üzere, onaylıyor musunuz ?(y/n)", member.Name, member.Surname);
                    if (Console.ReadLine().Equals("y"))
                    {
                        Console.WriteLine("Lütfen isim giriniz             :");
                        member.Name = Console.ReadLine().ToLower();
                        Console.WriteLine("Lütfen soyisim giriniz             :");
                        member.Surname = Console.ReadLine().ToLower();
                        Console.WriteLine("Lütfen numara giriniz             :");
                        member.Number = long.Parse(Console.ReadLine());
                    }

                    else if(Console.ReadLine().Equals("n"))
                    {
                        Begin();
                    }

                    else  
                    {
                        Console.WriteLine("Lütfen geçerli bir değer giriniz!");
                        Update();               
                    }
                }

                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n" +
                                      "* Güncellemeyi sonlandırmak için : (1)\n" + 
                                      "* Yeniden denemek için      : (2)"); 

                    if (Console.ReadLine() == "1")  Begin();
                    else if (Console.ReadLine() == "2")  Update();
                    else
                    {
                        Console.WriteLine("Lütfen geçerli bir değer giriniz!");
                        Delete();  
                    }
                }
            }

        }

        public void Listing()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("*************************************");
        
            foreach (var member in contactsList)
            {
                Console.WriteLine("\nİsim : {0} \nSoyisim : {1} \nNumara : {2}", member.Name, member.Surname, member.Number);

            }
            Console.WriteLine("\nDevam etmek için herhangi bir tuşa basınız.");
            Console.ReadLine();

        }

        public void Search()
        {
            Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.\n" +
            "**********************************************\n" + 
            "İsim veya soyisime göre arama yapmak için: (1)\n" + 
            "Telefon numarasına göre arama yapmak için: (2)");

            while (true)
            {
                inputSelect= Console.ReadLine();
                if (inputSelect == "1")
                {
                    Console.WriteLine("Lütfen aramak istediğiniz kişinin adını ya da soyadını giriniz: ");
                    string inputSearch= Console.ReadLine().ToLower();

                    foreach (var member in contactsList)
                    {
                        if (member.Name.Equals(inputSearch) || member.Surname.Equals(inputSearch))
                        {
                            Console.WriteLine("Arama Sonuçlarınız");
                            Console.WriteLine("*************************************");
                            Console.WriteLine("\nİsim : {0} \nSoyisim : {1} \nNumara : {2}", member.Name, member.Surname, member.Number);
                        }

                        else
                        {
                            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n" +
                                              "* Aramayı sonlandırmak için : (1)\n" + 
                                              "* Yeniden denemek için      : (2)"); 

                            if (Console.ReadLine() == "1")  Begin();
                            else if (Console.ReadLine() == "2")  Search();                         
                        }
                    }
                }

                else if (inputSelect == "2")
                {
                    Console.WriteLine("Lütfen aramak istediğiniz kişinin numarasını giriniz: ");
                    long inputSearchN= long.Parse(Console.ReadLine());

                    foreach (var member in contactsList)
                    {
                        if (member.Number.Equals(inputSearchN))
                        {
                            Console.WriteLine("Arama Sonuçlarınız");
                            Console.WriteLine("*************************************");
                            Console.WriteLine("\nİsim : {0} \nSoyisim : {1} \nNumara : {2}", member.Name, member.Surname, member.Number);
                        }

                        else
                        {
                            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n" +
                                              "* Aramayı sonlandırmak için : (1)\n" + 
                                              "* Yeniden denemek için      : (2)"); 

                            if (Console.ReadLine() == "1")  Begin();
                            else if (Console.ReadLine() == "2")  Search();                         
                        }
                    }
                }

                else Console.WriteLine("Lütfen geçerli bir değer giriniz!");
                
            }

            Console.WriteLine("\nDevam etmek için herhangi bir tuşa basınız.");
            Console.ReadLine();
        }


    }

}

