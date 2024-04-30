﻿using LL4.Methods.DeleteMethods;
using LL4.Methods.GetMethods;
using LL4.Methods.PostMethods;
using LL4.Methods.PutMethods;

class Program
{
    static async Task Main(string[] args)
    {
        bool showMenu = true;
        while (showMenu)
        {
            showMenu = await MainMenu();
        }
    }

    static async Task<bool> MainMenu()
    {
        Console.Clear();
        Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                        Meniu Principal                     ║");
        Console.WriteLine("╠════════════════════════════════════════════════════════════╣");
        Console.WriteLine("║ 1. Afiseaza toate categoriile                              ║");
        Console.WriteLine("║ 2. Adauga o categorie noua                                 ║");
        Console.WriteLine("║ 3. Sterge o categorie                                      ║");
        Console.WriteLine("║ 4. Schimba titlu unei categorii                            ║");
        Console.WriteLine("║ 5. Afisare informatii despre categorie utilizand ID-ul     ║");
        Console.WriteLine("║ 6. Afisare informatii despre categorie utilizand titlul    ║");
        Console.WriteLine("║ 7. Afisare produse din categorie                           ║");
        Console.WriteLine("║ 8. Adauga produs nou intr-o categorie                      ║");
        Console.WriteLine("║ 9. Iesire                                                  ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════╝");

        switch (Console.ReadLine())
        {
            case "1":
                GetCategories.getCategory();
                //WaitForKey();
                return true;
            case "2":
                AddCategory.addCategory();
                WaitForKey();
                return true;
            case "3":
                DeleteCategory.DeleteCategoryWithId();
                WaitForKey();
                return true;
            case "4":
                ChangeTitle.ChangeTitleCategoryWithId();
                WaitForKey();
                return true;
            case "5":
                GetInfoCategory.GetInfoCategoryById();
                WaitForKey();
                return true;
            case "6":
                GetInfoCategory.GetInfoCategoryApiByTitle();
                WaitForKey();
                return true;
            case "7":
                GetProductsFromCategory.GetProductsByIdCategory();
                WaitForKey();
                return true;
            case "8":
                AddProducts.AddProduct();
                WaitForKey();
                return true;
            case "9":
                return false;
            default:
                return true;
        }
    }

    static void WaitForKey()
    {
        Console.WriteLine("\nApasă orice buton pentru a reveni la meniul principal...");
        Console.ReadKey();
    }
}
