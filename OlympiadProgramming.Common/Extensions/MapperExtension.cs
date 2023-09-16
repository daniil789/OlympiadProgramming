using AutoMapper;

namespace OlympiadProgramming.Common.Extensions
{
    public static class MapperExtension
    {
        public static List<T> MapList<T>(this IMapper mapper, IEnumerable<object> sourses)
        {
            var result = new List<T>();

            foreach (var sourse in sourses)
            {
                result.Add(mapper.Map<T>(sourse));
            }

            return result;
        }
    }
}