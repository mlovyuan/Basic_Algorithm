# Basic_Algorithm 基礎演算法練習


### 泡泡排序法
---
- 比較一數列兩項數值，透過頻繁交換雙方位置達到排序效果。
- 由第i項不停與後續進行比較交換，單趟i項過程中若第j項有比第i項小，則進行交換，並以交換後的值繼續向j+1項後比對。
- 等同於該數列由第i項向後尋找，只要找到比第i項小的值，便進行一次交換，因此可能會有多次的交換動作，期間第i項的數值並不固定，而當內圈循環結束，第i項必為第i小值。
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
- 是泡泡排序法的進階排序法，取代了泡泡排序法頻繁且多餘的交換動作（每找到一次較小的便交換）。
- 其運行原理乃是**最先**查找完一數列第i項後的最小值，將其與第i項值交換位置，往後延續相同作法。
- 也就是說，這種作法每在一個位置下向往後進行搜索，記錄下所有值的最小值後，只進行一次交換動作。
``` C#
// 由小往大排
public static void SelectionSort(this int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minValueIndex = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minValueIndex])
            {
                minValueIndex = j;
            }
        }
        int temp = array[minValueIndex];
        array[minValueIndex] = array[i];
        array[i] = temp;
    }
}
```
上述算是一套排序法的改善。

### 插入排序法
---
- 插入排序法原理如同打牌時每拿到一次新牌便會依據手中排組順序大小決定其該插入的手牌位置。
- 泡泡排序法乃是以**位置**為出發點，每次對比後一順位來找到最小值；插入排序則是以**數字**為出發點，由第i項數值向前比對，若左方較大便交換（非如同泡泡排序一樣兩者實際交換，而是較小的那方記下更換後的位置，較大的那方則有實際交換至相比的位置），直到發現前項數值小於自身便停止。
- 也就是說，這種作法每在一個位置下向往後進行搜索，記錄下所有值的最小值後，只進行一次交換動作。
``` C#
public static void InsertionSort(this int[] array)
{
    for (int i = 1; i < array.Length - 1; i++)
    {
        int iIndex = i;
        int iValue = array[i];
        if(iIndex > 0 && array[iIndex - 1] > iValue)
        {
            array[iIndex] = array[iIndex - 1];
            iIndex--;
        }
        array[iIndex] = iValue;
    }
    array.Print();
}
```


### 希爾排序法
---
