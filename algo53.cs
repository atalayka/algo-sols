public class Solution {
    public int[] FindErrorNums(int[] nums) {
        // Bir `Dictionary` nesnesi oluşturuyoruz. Anahtarlar sayıları, değerler ise o sayıların kaç kez tekrarladığını temsil edecek.
        var map = new Dictionary<int, int>();

        // Hata numaralarını saklamak için iki elemanlı bir dizi oluşturuyoruz.
        var result = new int[2];

        // Dizi içerisindeki her sayı için:
        foreach (var num in nums)
        {
            // Sayı `map` içerisinde var ise:
            if (map.ContainsKey(num))
            {
                // Sayının tekrar sayısını 1 artırıyoruz.
                map[num]++;
            }
            else
            {
                // Sayı `map` içerisinde yok ise:
                // Sayıyı ve tekrar sayısını (1) `map`'e ekliyoruz.
                map.Add(num, 1);
            }
        }

        // 1'den dizinin uzunluğuna kadar her sayı için:
        for (int i = 1; i <= nums.Length; i++)
        {
            // Sayı `map` içerisinde var ise:
            if (map.ContainsKey(i))
            {
                // Sayı iki kere tekrarlamış ise:
                if (map[i] == 2)
                {
                    // Tekrarlayan sayıyı `result`'un ilk elemanına atıyoruz.
                    result[0] = i;
                }
            }
            else
            {
                // Sayı `map` içerisinde yok ise:
                // Eksik sayıyı `result`'un ikinci elemanına atıyoruz.
                result[1] = i;
            }
        }

        // Hata numaralarını içeren diziyi döndürüyoruz.
        return result;
    }
}
