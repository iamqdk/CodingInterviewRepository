using System.Collections;

namespace DataStructures.Neetcode;
public static class ArraysAndHashing
{
    // // https://neetcode.io/problems/top-k-elements-in-list (M)
    // #region Top K Frequent Elements
    // public static int[] TopKFrequent_Sorting(int[] nums, int k)
    // {
    //     if (nums.Length == 1 && k == 1)
    //     {
    //         return nums;
    //     }
    //
    //     Dictionary<int, int> dic = new Dictionary<int, int>();
    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         if (!dic.ContainsKey(nums[i]))
    //         {
    //             dic.Add(nums[i], 1);
    //             continue;
    //         }
    //     
    //         dic[nums[i]]++;
    //     }
    //
    //     List<int>[] bucket = new List<int>[nums.Length + 1];
    //     foreach (var key in dic.Keys)
    //     {
    //         if (bucket[dic[key]] == null)
    //         {
    //             bucket[dic[key]] = new List<int>();
    //         }
    //
    //         bucket[dic[key]].Add(key);
    //     }
    //
    //     int[] result = new int[k];
    //
    //     int count = 0;
    //     for (int i = bucket.Length - 1; i >= 0; i--)
    //     {
    //         foreach (var item in bucket[i])
    //         {
    //             if (count < k)
    //             {
    //                 result[count++] = item;
    //             }
    //         }
    //     }
    //
    //     return result;
    // }
    // #endregion Top K Frequent Elements
    //
    // public static int[] ProductExceptSelf(int[] nums) {
    //     
    //     
    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         
    //     }
    // }



    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (m + n == 1)
        {
            if (m == 0)
            {
                nums1[0] = nums2[0];
            }

            return;
        }

        int[] result = new int[m + n];

        int i =0;
        int j = 0;
        for (int position = 0; position < result.Length; position++)
        {
            if (i == m)
            {
                result[position] = nums2[j++];
                continue;
            }
            if (j == n)
            {
                result[position] = nums1[i++];
                continue;
            }

            if (nums1[i] <= nums2[j])
            {
                result[position] = nums1[i++];
            }
            else
            {
                result[position] = nums2[j++];
            }
        }

        i = 0;
        nums1 = new int[m + n];
        foreach (var item in result)
        {
            nums1[i++] = item;
        }
    }

    public int FirstUniqChar(string s)
    {
        Dictionary<int,int> dictionary = new Dictionary<int, int>();
        foreach (char x in s)
        {
            if (!dictionary.ContainsKey(x))
            {
                dictionary.Add(x - 'a', 1);
            }
            else
            {
                dictionary[x - 'a']++;
            }
        }

        foreach (int key in dictionary.Keys)
        {
            if (dictionary[key] == 1)
            {
                return key;
            }
        }

        return 0;
    }
}