using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces.Fruits
{
    class Banana:IFruit
    {
        public string Name => "Banana";
        public bool IsPeeled { get; private set; } = false;
        public bool IsSweet { get; private set; } = true;
        
        public string Peel()
        {
            IsPeeled = true;
            return $"You peeled the {GetType().Name}";
        }

    } // \banana class

    public class Orange:IFruit
    {
        public string Name => "Orange";
        public bool IsPeeled { get; private set; }
        public bool IsSweet { get; private set; } = true;

        public Orange(bool isPeeled)
        {
        
        IsPeeled = isPeeled;
        }

        public string Peel()
        {
            
            IsPeeled = true;
            return $"You peeled the {GetType().Name}";
        }

        public string Squeeze()
        {
            return "you got juice";
        }

    } // \orange class

    public class Grape : IFruit
    {
        public string Name => "grape";
        public bool IsPeeled { get; private set; } = false;
        public bool IsSweet { get; private set; } = true;
        public string Peel()
        {
            IsPeeled = false;
            return $"Dont peel the {GetType().Name}s";
        }

    }// \Grape class
    
    public class Mandarin:Orange
    {
        public Mandarin(bool isPeeled) : base(isPeeled) { }

    }// \Mandarin class

    public class Tomato : IFruit
    {
        public bool IsSweet { get; private set; } = false;
        public string Name => "grape";
        public bool IsPeeled { get; private set; } = false;
        
        
        public string Peel()
        {
            IsPeeled = false;
            return $"Dont peel the {GetType().Name}s";
        }


    }


} // \ns

//create unique Peel and one each additional prop and method - add to basket in test