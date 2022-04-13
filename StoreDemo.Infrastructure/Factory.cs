using StoreDemo.Domain;

namespace StoreDemo.Infrastructure
{
    // All the code in this file is included in all platforms.
    public  static class Factory // desgin pattern :- simple factory pattern
    {
        private static  Dictionary<string, CustomerBase> custs = new Dictionary<string, CustomerBase>();
        
        public static CustomerBase Create (string TypeCust)
        {
            // Desgin pattern :- Lazy loading. Eager loading
            if(custs.Count == 0)
            {
                custs.Add("Customer", new Customer());
                custs.Add("Lead", new Lead());
            }
            return custs[TypeCust];
        }
    }
}