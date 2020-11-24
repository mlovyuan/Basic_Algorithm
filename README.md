# Basic_Algorithm 基礎演算法練習


### 泡泡排序法
---
- 比較一數列前後兩項數值，透過頻繁交換雙方位置達到排序效果。
``` C#
// 由小往大排
public static void BubbleSort(this int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[i])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}
```


### 選擇排序法
---
- 是泡泡排序法的進階排序法，取代了泡泡排序法頻繁且多餘的交換動作。
- 其運行原理乃是**最先**查找完一數列的最小值後，將其與第一位數交換位置，往後延續相同作法。也就是說，這種作法每在一個位置下往後進行搜索，並且只進行一次交換。
