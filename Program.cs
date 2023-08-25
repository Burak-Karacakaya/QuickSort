
    int[] numbers = new int[]
    {
        2,5,4,8,6,1,12,15,98,65,43,21,23,43,521,13,89,76
    };

    Console.WriteLine("Original array:");
    foreach (int num in numbers)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();

    QuickSort(numbers, 0, numbers.Length - 1);

    Console.WriteLine("Sorted array:");
    foreach (int num in numbers)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();


    static void QuickSort(int[] arr, int low, int high)

    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);
            QuickSort(arr, low, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int temp2 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp2;

        return i + 1;
    }
