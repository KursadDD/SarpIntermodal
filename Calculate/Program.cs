class CalculateClass
{
    static void Main(string[] args)
    {
        //bu soru için iki senaryo var
        //1. yolllanan dizi için her defasında 3 işlemi birden yapacak ise diziyi alırım ve geriye sonuçları içeren bir object dönerim
        int[] array = { 2, 5, 3, 2, 8, 5, 9, 2, 8, 10, 25 };
        var result = AllCalculate(array);
        #region ikinci senaryo

        //2. yollanan dizi ile birlikte yapılacak olan işlem tipinin de seçilmesi isteniyor ise

        //parametre olarak dizi ile birlikte işlem tipini alarak metot içerisinde gelen tipe göre if yapıları ile kontrol yaparak sonuç dönebiliriz
        //var result = Calculate(array, int type); gibi

        //ama bir metoda fazla iş yaptırmak yerine her iş parçacığı için farklı metot tanımlamak daha okunaklı olacaktır
        //var result = CalculateTotal(array); 
        //var result = CalculateMultiplication(array); 
        //var result = CalculateAverage(array); 
        #endregion
    }
    static ResultDto AllCalculate(int[] array)
    {
        int total = array.Sum();
        int multiplication = array.Aggregate((x,y) => x*y);
        decimal average = (decimal)array.Average();

        return new ResultDto()
        {
            Total = total,
            Multiplication = multiplication,
            Average = average
        };
    }

    class ResultDto
    {
        public int Total { get; set; }
        public int Multiplication { get; set; }
        public decimal Average { get; set; }
    }
    
}