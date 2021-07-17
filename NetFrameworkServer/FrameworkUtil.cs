using System;

namespace NetFrameworkServer
{
    public class FrameworkUtil
    {
        public static T[] ArrayRange<T>(T[] array, int start, int end)
        {
            T[] tmp = new T[end - start];
            Array.Copy(array, start, tmp, 0, tmp.Length);
            return tmp;
        }
    }
}
