using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    static class LightElementNodeTypeFactory // Flyweight factory
    {
        private static Dictionary<string, LightElementNodeType> _cache = new Dictionary<string, LightElementNodeType>();

        public static LightElementNodeType GetLightElementNodeType(string tagName, string viewType, bool isDoubleTag)
        {
            LightElementNodeType? nodeElement = LightElementNodeTypeFactory._cache.GetValueOrDefault(tagName);

            if (nodeElement == null)
            {
                nodeElement = new LightElementNodeType(tagName, viewType, isDoubleTag);
                LightElementNodeTypeFactory._cache[tagName] = nodeElement;
            }

            return nodeElement;
        }
    }
}
