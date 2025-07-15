using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment2.cs
{
    public class GenericCache<T>
    {

        private Dictionary<string, CacheItem<T>> cache = new Dictionary<string, CacheItem<T>>();

        public void AddItem(string key, T value, TimeSpan expirationDuration)
        {
            CacheItem<T> cacheItem = new CacheItem<T>(value, expirationDuration);
            cache[key] = cacheItem;
        }

        public T GetItem(string key)
        {
            if(cache.TryGetValue(key, out CacheItem<T> cacheItem))
            {
                if (cacheItem.isExpired())
                {
                    //removing the expired item
                    cache.Remove(key);
                    throw new InvalidOperationException("Trying to retrieve an expired item from the cache");
                }

                return cacheItem.Value;

            }
            throw new KeyNotFoundException($"Item with key '{key}' has not been found in the cache");
        }

        public void Display()
        {
            Console.WriteLine("The following items are currentlystored in the cache: ");

            foreach(var keyValuePair in cache)
            {
                Console.WriteLine($"Key: {keyValuePair.Key}, Value: {keyValuePair.Value.Value}, ExpirationTime: {keyValuePair.Value.ExpirationTime}");
            }
        }
    }
}
