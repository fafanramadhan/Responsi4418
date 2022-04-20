//object Karyawan

using ResponsiPemrograman4418;

Karyawan karyawan1 = new Karyawan("12345678", "Joko", 10000000);
Karyawan karyawan2 = new Karyawan("87654321", "Udin", 20000000);

Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
Console.WriteLine("---------------------------------");
Console.WriteLine("1    {0}/{1}         {2}", karyawan1.Nik, karyawan1.Name, karyawan1.Gajibulanan);
Console.WriteLine("2    {0}/{1}         {2}", karyawan2.Nik, karyawan2.Name, karyawan2.Gajibulanan);

Console.WriteLine();
Console.WriteLine("Naik gaji cuyyy 10%");
Console.WriteLine();

karyawan1.NaikGaji();
karyawan2.NaikGaji();

Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
Console.WriteLine("---------------------------------");
Console.WriteLine("1    {0}/{1}         {2}", karyawan1.Nik, karyawan1.Name, karyawan1.Gajibulanan);
Console.WriteLine("2    {0}/{1}         {2}", karyawan2.Nik, karyawan2.Name, karyawan2.Gajibulanan);