using AutoEngeneering.Models;
using System;

namespace AutoEngeneering.Tools
{
    public class IndustryContext
    {   
        public static void UseDatabase(Action<TechnicEngeneeringEntities> action)
        {
            using (TechnicEngeneeringEntities context = new TechnicEngeneeringEntities())
            {
                action(context);
            }
        }
        
        public static T UseDatabase<T>(Func<TechnicEngeneeringEntities, T> action)
        {
            using (TechnicEngeneeringEntities context = new TechnicEngeneeringEntities())
            {
                return action(context);
            }
        }
    }
}
