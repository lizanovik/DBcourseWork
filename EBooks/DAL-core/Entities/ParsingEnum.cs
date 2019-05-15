using System;

namespace DAL_core.Entities
{
    public static class ParsingEnum
    {
        public static T ParseEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
