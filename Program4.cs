Console.Write("Birinci sayıyı giriniz:");
int birincisayi = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci sayıyı giriniz:");
int ikincisayi = Convert.ToInt32(Console.ReadLine());

Console.Write("Üçüncü sayıyı giriniz:");
int ucuncusayi = Convert.ToInt32(Console.ReadLine());

Console.Write("Dördüncü sayıyı giriniz:");
int dorduncusayi = Convert.ToInt32(Console.ReadLine());

int toplam = birincisayi + ikincisayi + ucuncusayi + dorduncusayi;
Console.WriteLine("Dört sayının toplamı=" + toplam);

int carpim = birincisayi * ikincisayi * ucuncusayi * dorduncusayi;
Console.WriteLine("Dört sayının çarpımı=" + carpim);

Console.ReadKey();