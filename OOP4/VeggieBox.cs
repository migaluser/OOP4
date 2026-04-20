using System.Collections;

namespace OOP4
{
    class VeggieBox : IEnumerable
    {
        private Vegetables[] _veggies;

        public VeggieBox(Vegetables[] veggiesArray)
        {
            _veggies = veggiesArray;
        }

        public IEnumerator GetEnumerator()
        {
            return _veggies.GetEnumerator();
        }
    }
}
