
using task2;

List<Menu> products = new List<Menu>

{
    new Menu { Id = 1, itemName="mansaf", price=30 , ingreadiant= new string[]{"Rice", "Yogurt","Meet", "Ghee", "Jameed"}, },
    new Menu { Id = 2, itemName="burger", price=20 , ingreadiant= new string[]{"bread", "Ground beef","Tomato", "kutchup", "Cheese "}, },
    new Menu { Id = 3, itemName="shawerma", price=10 , ingreadiant= new string[]{ "bread", "chicken", "mayo","potato", "Tahini sauce"}, },

};

Console.WriteLine($" 1.main menu");
Console.WriteLine($" 2.Add Item");
Console.WriteLine($" 3.Search");

Console.WriteLine("Enter what you need");
int choose = int.Parse(Console.ReadLine()); ;

if (choose == 1)
{
    foreach (var item in products)
    {
        Console.WriteLine($"product number   \t  product name      \t  product price ");
        Console.WriteLine($" {item.Id}         \t    \t  {item.itemName} \t           {item.price} jd  ");

        Console.WriteLine("*********************************************************************************");

    }
    Console.WriteLine("Enter number item for show Ingrediats");
    int ItemNum = int.Parse(Console.ReadLine());
    foreach (var prod in products)
    {
        if (prod.Id == ItemNum)
        {

            Console.WriteLine($"the {prod.itemName} ingrediats are: ");
            foreach (var w in prod.ingreadiant)
            {
                Console.WriteLine("-" + w);
            }

        }
    }
    Console.WriteLine("*********************************************************************************");
}

if (choose == 2)
{
    // add recipe

    try
    {
        Console.WriteLine("Add new recipe");
        Console.WriteLine("Enter recipe id");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter recipe name");
        string recName = Console.ReadLine();
        Console.WriteLine("Enter recipe price");
        int priceR = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter recipe ingreadiants");

        string[] ingred = new string[3];
        ingred[0] = Console.ReadLine();
        ingred[1] = Console.ReadLine();
        ingred[2] = Console.ReadLine();

        products.Add(new Menu
        {
            Id = id,
            itemName = recName,
            price = priceR,
            ingreadiant = ingred

        });

        Console.WriteLine($"The recipe has been successfully added");

        //Console.WriteLine("list after add new recipe");
        //foreach (var item in products) 
        //{
        //    Console.WriteLine($"product number   \t  product name      \t  product price ");
        //    Console.WriteLine($" {item.Id}         \t    \t  {item.itemName} \t           {item.price} jd  ");
        //    Console.WriteLine("ingrediant");
        //    foreach (var i in item.ingreadiant)
        //    {
        //        Console.WriteLine("-" + i);
        //    }

        //}

    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }
}
if (choose == 3)
{
    //search
    // search recipes

    Console.WriteLine("Enter the recipe name (Search  recipes)");
    string search = Console.ReadLine();
    Console.WriteLine("Search  results: ");
    bool found1 = false;
    foreach (var product in products)
    {
        if (search == product.itemName)
        {
            Console.WriteLine($"product number   \t  product name      \t  product price ");
            Console.WriteLine($" {product.Id}         \t    \t  {product.itemName} \t          {product.price} jd  ");

            Console.WriteLine($"the {product.itemName} ingrediants are : ");
            foreach (var i in product.ingreadiant)
            {
                Console.WriteLine("-" + i);
            }
            Console.WriteLine("*********************************************************************************");

            found1 = true;
        }

    }

    if (found1 == false)
    {
        Console.WriteLine("The Recipe is not found");
    }
}
