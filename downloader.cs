using System.Net;
public class Downloader
{
    public static void start(int n)
    {
       using (var client = new WebClient()) 
       {        
            client.DownloadFile($"https://server7.mp3quran.net/s_gmd/{n:000}.mp3" ,
            $"d:\\\\{Namer.nameSurah(n):d3}.mp3" );
       }
    }
    public static async void DownloadStart(int n)
    {
        Console.WriteLine($"{n} - sura yuklanmoqda...");        
        await Task.Run(() => start(n));
        Console.WriteLine($"{n} - sura, {Namer.nameSurah(n)} yuklandi");
    }
}