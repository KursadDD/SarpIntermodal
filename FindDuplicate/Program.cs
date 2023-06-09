class FindDuplicateClass
{
    static void Main(string[] args)
    {
        int[] array = { 2, 5, 3, 2, 8, 5, 9, 2, 8, 10, 25 };

        var duplicateNumbers = FindDuplicate(array);
    }

    static List<int> FindDuplicate(int[] array)
    {
        List<int> duplicates = new List<int>(); //tekrar eden sayıları tutacağımız dizi
        HashSet<int> hashSet = new HashSet<int>(); //sadece tekrar etmeyen eleman tutabilen bir liste türü 

        foreach (int item in array)
        {
            //hashSet dizisinin içine elemanı ekleyebilirsek true, ekleyemez isek yani o eleman zaten var ise false değer dönecektir
            //ekleyemiyor isek o eleman tekrar ediyor demektir
            if (!hashSet.Add(item))
            {
                if (!duplicates.Contains(item))
                {
                    duplicates.Add(item);
                }
            }
        }

        //döngü sonrası array parametresi ile gelen sayıların hepsi tekrar etmeyecek şekilde hashSet değişkeni içerisine atıldı
        //tekrar eden sayılar ise duplicates değişkeni içerisine atıldı 

        return duplicates;
    }


}