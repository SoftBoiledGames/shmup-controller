using System;

namespace SoftBoiledGames.Comprehensive2DController.Extensions
{
    public static class SystemTypeExtensions 
    {
        public static Type GetListElementType(this Type self)
        {
            if (self.IsGenericType)
                return self.GetGenericArguments()[0];
            else
                return self.GetElementType();
        }
    }
}