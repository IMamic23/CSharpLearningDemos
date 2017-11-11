using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAndEnumeratorDemo
{
    class AnimalFarm : IEnumerable
    {
        private List<Animal> _animalList = new List<Animal>();

        public AnimalFarm(List<Animal> animalList)
        {
            _animalList = animalList;
        }

        public AnimalFarm()
        {
            
        }

        public Animal this[int index]
        {
            get { return (Animal)_animalList[index]; }
            set { _animalList.Insert(index, value);}
        }

        public int Count
        {
            get { return _animalList.Count; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _animalList.GetEnumerator();
        }
    }
}
