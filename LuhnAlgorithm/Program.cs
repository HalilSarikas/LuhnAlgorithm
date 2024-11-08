Console.WriteLine("Kart Giriniz:");
var readCard = Console.ReadLine();
var bankCard = Convert.ToInt64(readCard.Replace(" ", ""));

 var cardDigits = bankCard.ToString().Select(c => c - '0').ToArray();
var sumTotal = 0;
for (int i = 0; i < cardDigits.Length; i++)
{
	if (i % 2 == 0)
	{
		var multi = cardDigits[i] * 2;
		if (multi >= 10)
		{
			sumTotal += multi.ToString().Sum(c => c - '0');
		}
		else
		{
			sumTotal += multi;
		}
	}
	else
	{
		sumTotal += cardDigits[i];
	}

}

 if (sumTotal % 10 == 0)
	Console.WriteLine("Kart Geçerli");
else
	Console.WriteLine("Kart Geçersiz");