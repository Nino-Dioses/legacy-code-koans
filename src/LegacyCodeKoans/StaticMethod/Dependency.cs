using System;

namespace LegacyCodeKoans.StaticMethod
{
    public class Dependency
    {
        public static void SomeSideEffect()
        {
            throw new Exception("This method should not be called in a unit test!");
        }
    }
}