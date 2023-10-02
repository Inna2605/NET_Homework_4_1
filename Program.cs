//Запрограмуйте клас Money (об'єкт класу оперує однією валютою) для роботи з грошима.
//У класі мають бути передбачені: поле для зберігання цілої частини грошей (долари, євро, гривні тощо)
//і поле для зберігання копійок (центи, євроценти, копійки тощо)
//Реалізувати методи виведення суми на екран, задання значень частин.
//На базі класу Money створити клас Product для роботи з продуктом або товаром.
//Реалізувати метод, який дозволяє зменшити ціну на задане число.
//Для кожного з класів реалізувати необхідні методи і поля.

using NET_Homework_4_1;

Money Hryvnia = new Money();

Console.Write("Введіть кількість гривень: ");
int hryvnia = Convert.ToInt32(Console.ReadLine());
Hryvnia.SetWhole(hryvnia);

Console.Write("Введіть кількість копійок: ");
int copies = Convert.ToInt32(Console.ReadLine());
Hryvnia.SetPennies(copies);

Console.Write("Всього коштів: ");
Hryvnia.SumMoney();
Hryvnia.ShowMoney();
Console.WriteLine();

Console.Write("Введіть на яку суму товарів ми купили: ");
double purchase = Convert.ToDouble(Console.ReadLine());

double monies = Hryvnia.Monies;

Product product = new Product(monies);

product.DeclineMoney(purchase);
Console.Write("Cума коштів після покупки: ");
product.ShowMoney();

