//*****************************************************************************
//** 769. Max Chunks To Make Sorted                                 leetcode **
//*****************************************************************************

int maxChunksToSorted(int* arr, int arrSize) {
    int count = 0;
    int max = 0;
    for(int i = 0; i < arrSize; i++)
    {
        max = (max > arr[i]) ? max : arr[i];
        if(max == i) count++;
    }
    return count;
}