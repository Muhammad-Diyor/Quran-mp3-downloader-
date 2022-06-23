
    while(true)
        {
            int surahIndex = int.Parse(Console.ReadLine());
            if(surahIndex > 114 || surahIndex <= 0) 
                {
                    Console.WriteLine("Xatolik. 1 dan 114 gacha raqam kiritishingiz mumkin.");
                }
            else
                {
                    Downloader.DownloadStart(surahIndex);            
                }
        }
