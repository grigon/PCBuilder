using System;
using System.Collections.Generic;

namespace PCBuilder
{
    public class Computer
    {
        public int ComponentsNumber { get; }
        private List<Component> Components = new List<Component>();

        public Computer(int componentsNumber)
        {
            ComponentsNumber = componentsNumber;
        }

        public void MountComponent(Component component)
        {

            foreach (var mountedComponet in Components)
            {
                if (mountedComponet.GetType() == component.GetType())
                {
                    Console.WriteLine("Already mounted");
                    return;
                }
            }
            Components.Add(component);
            Console.WriteLine("Component mounted");
        }


        /// <summary>
        /// Checks specified computer parameter.
        /// </summary>
        private int CheckParameter(String parameter)
        {
            int parameterSum = 0;
            foreach (var mountedComponet in Components)
            {
                switch (parameter)
                {
                    case "power":
                        parameterSum += mountedComponet.PowerChange;
                        break;
                    case "temp":
                        parameterSum += mountedComponet.TempChange;
                        break;
                }
            }

            return parameterSum;
        }

        /// <summary>
        /// Checks if all components are mounted and power and temp are positive.
        /// </summary>
        public bool CheckIfWorks()
        {
            foreach (var mountedComponet in Components)
            {
                if (Components.Count != ComponentsNumber)
                {
                    Console.WriteLine("Not all components mounted");
                    return false;
                }
            }

            if (CheckParameter("power") < 0)

            {
                Console.WriteLine("Not enough power");
                return false;
            }

            if (CheckParameter("temp") < 0)
            {
                Console.WriteLine("Too hot");
                return false;
            }

            Console.WriteLine("Works");
            return true;
        }
    }
}