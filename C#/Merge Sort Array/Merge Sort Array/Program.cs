
    static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        for (int i = 0; i < n; i++)
        {
            nums1[m + i] = nums2[i];
        }

        for (int i = 0; i < nums1.Length; i++)
        {

            for (int j = i + 1; j < nums1.Length; j++)
            {
                if (nums1[i] > nums1[j])
                {
                    int temp = nums1[i];
                    nums1[i] = nums1[j];
                    nums1[j] = temp;    
                }
            }
        }
        

    }
    int[] array = new int[6] { 1, 5, 2, 0, 0,0 };
    int[] array2 = new int[3] { 1, 5, 2 };

    Merge(array, 3, array2, 3);

