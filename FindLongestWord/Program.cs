class FindLongestWordClass
{
    static void Main(string[] args)
    {
        ClientModel();
    }

    // bu metot istek yapan clientı modeller. 
    static string ClientModel()
    {
        //client bir dosya yükler ve bu dosyanın gerçekten olup olmadığı burada kontrol edilir
        var path = @"C:\Users\Hp\Masaüstü\text.txt";
        bool isExistsFile = File.Exists(path);
        if (isExistsFile)
        {
            //dosyanın var olduğu anlaşıldığında backende istek yapılır ve en uzun kelimeyi dönmesi istenir
            string text = File.ReadAllText(path);
            string result = FindLongestWord(text);
            return result;
        }
        else
        {
            //böyle bir dosya yok ise clienta uyarı mesajı verilir
            throw new UserFriendlyException("Yüklediğiniz dosya bulunamamıştır!");
        }

    }
    // bu metot backend tarafında istek yapılan ve geriye cevap dönen bir api yi modeller
    static string FindLongestWord(string text)
    {
        //metin içerisindeki kelimeler arasında kullanılabilecek noktalama işaretlerini baz alarak metni kelimelere ayrır ve metin içerisindeki gereksiz boşlukları temizler.
        //metnin kelimelerinin her birisi bir item olacak şekilde string bir dizi içerisine toplar
        string[] words = text.Split(new[] { ' ', '\n', '\r', '\t', '.', ',', ';', ':', '?', '!', '-', '_' }, StringSplitOptions.RemoveEmptyEntries);

        //kelimelerden oluşan dizi üzerinde kelime uzunluklarına göre sıralama yapar ve en uzun olan ilk kelimeyi longestWord değişkenine atar
        string longestWord = words.OrderByDescending(word => word.Length).FirstOrDefault();

        //bulunan en uzun kelimeyi geri döner
        return longestWord;
    }
}

