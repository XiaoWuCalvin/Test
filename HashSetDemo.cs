  int[] nums = {1,3,5,6,8,11,23,5,6,8,19,120 };
            //过滤掉重复的元素,返回没有重复的元素 1.List，2.Linq 3.HashSet..
            //var newInts= nums.Distinct(); //Distinct
            //foreach (var item in newInts)
            //{
            //    Console.WriteLine(item);
            //}
            HashSet<int> hs = new HashSet<int>();
            foreach (var item in nums)
            {
                hs.Add(item); //逐个添加不重复的元素
            }

            foreach (var item in hs)
            {
                Console.WriteLine(item);
            }
